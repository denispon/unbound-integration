#########################################################################################
# Gets a random strong password encryped with an Unbound CORE KMS Key.
#
# The encrypted password is stored in a file along with the key ID
# The filepath can be set using the UB_PASSWORD_FILE env variable.
#
# If the file is not found, for example on the first run of this script),
# a new random password is created
#
# The password can be reset by setting the env variable RESET_PASSWORD to YES
#
# Every time the script is executed, it encrypts the password again with the latest
# version of the key, this supports key rotation for increased security.
#
# The script returns the cleartext password
#########################################################################################
#!/bin/bash
set -e

if [[ -z "${UB_CORE_URL}" ]]; then
    echo "Environment variable UB_CORE_URL must be set with Unbound CORE KMS service URL"
    echo "For example: https://www.unboundserver.com"
    exit 1
fi

UB_PARTITION=${UB_PARTITION:-'encfs'}

if [[ -z "${UB_USER}" ]]; then
    echo "Environment variable UB_USER must be set with Unbound CORE KMS crypto username"
    echo "Must be a valid user of partition '$UB_PARTITION' with a password"
    exit 1
fi

if [[ -z "${UB_USER_PASSWORD}" ]]; then
    echo "Environment variable UB_USER_PASSWORD must be set with the password for Unbound CORE KMS user '$UB_USER'"
    exit 1
fi

if [[ -z "${UB_KEY_NAME}" ]]; then
    echo "Environment variable UB_KEY_NAME must be set with Unbound CORE KMS key name for encryption"
    echo "The key must be an RSA key which was created in partition '$UB_PARTITION'"
    exit 1
fi

# The full path and filename for storing the encrypted passphrase 
# The encrypted passphrase file contains both the cipher and the UID of the 
# CORE key that was used for encrypting it
UB_PASSWORD_FILE=${UB_PASSWORD_FILE:=${PWD}/encfs_pass.txt}

# Sends a GET request to Unbound CORE KMS
ub_get() {
    curl -k --silent --user $UB_USER@$UB_PARTITION:$UB_USER_PASSWORD\
         $UB_CORE_URL/api/v1/$1?partitionId=$UB_PARTITION
}

# Sends a POST request to Unbound CORE KMS
ub_post() {
    curl -k --silent  --user $UB_USER@$UB_PARTITION:$UB_USER_PASSWORD -X POST\
     -H "Content-Type: application/json" \
     -d "$2" $UB_CORE_URL/api/v1/$1?partitionId=$UB_PARTITION
}

# check connection to ukc
set +e
ub_get info > /dev/null
ret=$?
if [ $ret -ne 0 ]; then
    echo "Could not connect to Unbound CORE at: '${UB_CORE_URL}'. Please check your UB_CORE_URL env value "
    exit $ret
fi
set -e
# Encryption algorithm parameters
ASSYM_PARAMS="\"aSymmetricParams\": {\"padding\": {\"type\":\"OAEP\", \"oaep\": { \"mgf\": \"SHA256\"}}}"

#### 1. Get the passowrd either by decrypting it from a 
####    previously saved encrypted data or by generating a new one
if test -f "$UB_PASSWORD_FILE"; then
    # Get key UID from first line of file
    KEYUID_1=$(sed '1!d' $UB_PASSWORD_FILE)
    # Get cipher from second line of file
    CIPHER_1=$(sed '2!d' $UB_PASSWORD_FILE)
    # Decrypt with Unbound CORE
    PASSPHRASE_B64=$(ub_post keys/${KEYUID_1}/decrypt "{\"cipher\":{ \"cipherTextBase64\":\"$CIPHER_1\"}, $ASSYM_PARAMS}"\
        | grep -oP clearText\":\"\\K[^\"]*)
fi

# In case password reset was requested 
if [[ "${RESET_PASSWORD}" == "YES" ]]; then
    unset PASSPHRASE_B64    
fi
# If no previously decrypted password, or if explicit reset requeted create a new random password
PASSPHRASE_B64=${PASSPHRASE_B64:=$(head -c 128 /dev/random | base64 -w 0)}

#### 2. Encrypt the password using the latest version of Unbound CORE key 
####    The key version changes every time the key is rotated either manually
####    or automatically. Versions are identified by distinct UID's
# Find Unbound CORE key UID by key name - this gets the latest key version
KEY_UID=$(ub_get keys/${UB_KEY_NAME} | grep -oP uid\":\"\\K[[:alnum:]]*)
# Export the public key to use for encryption
PUBLIC_KEY_PEM=$(ub_get keys/${KEY_UID}/public | grep -oP keyData\":\"\\K[^\"\}]*)
# Encrypt the password using latest key revision
ENC_REQUEST="{\"clearText\":\"$PASSPHRASE_B64\" ,$ASSYM_PARAMS}"
CIPHER=$(ub_post keys/${KEY_UID}/encrypt "$ENC_REQUEST" | grep -oP cipherTextBase64\":\"\\K[^\"]*)

#### 3. Store the encrypted password allong with the CORE key UID
rm -f $UB_PASSWORD_FILE
echo $KEY_UID >> $UB_PASSWORD_FILE
echo $CIPHER >> $UB_PASSWORD_FILE

#### 4. Return the cleartext password
echo $PASSPHRASE_B64
