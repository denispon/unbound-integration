﻿namespace unbound.cryptoki {

public class CK
{
  public const uint CK_UNAVAILABLE_INFORMATION = 0xffffffff;
    
  public const uint CKK_RSA                 = 0x00000000;
  public const uint CKK_EC                  = 0x00000003;
  public const uint CKK_GENERIC_SECRET      = 0x00000010;
  public const uint CKK_RC2                 = 0x00000011;
  public const uint CKK_DES                 = 0x00000013;
  public const uint CKK_DES3                = 0x00000015;
  public const uint CKK_AES                 = 0x0000001F;
  public const uint CKK_CHACHA20            = 0x00000033;
  public const uint CKK_AES_XTS             = 0x00000035;
  public const uint CKK_EC_EDWARDS          = 0x00000040;
  public const uint CKK_EC_MONTGOMERY       = 0x00000041;
    
  public const uint DYCKK_AES_SIV      = 0x80007104;
  public const uint DYCKK_AES_XTS      = 0x80007105;
  public const uint DYCKK_LIMA         = 0x80007107;
  public const uint DYCKK_EDDSA        = 0x80007108;
  public const uint DYCKK_ADV_PASSWORD = 0x80007101;
  public const uint DYCKK_ADV_PRF      = 0x80007103;

  public const uint CKD_NULL       = 0x00000001;
  public const uint CKD_SHA1_KDF   = 0x00000002;
  public const uint CKD_SHA256_KDF = 0x00000006;
  public const uint CKD_SHA384_KDF = 0x00000007;
  public const uint CKD_SHA512_KDF = 0x00000008;

  public const uint CKF_HW             = 0x00000001;  /* performed by HW */
  public const uint CKF_RW_SESSION     = 0x00000002;
  public const uint CKF_SERIAL_SESSION = 0x00000004;
  public const uint CKF_LOGIN_REQUIRED = 0x00000004;

  public const uint CKR_OK = 0x00000000;
  public const uint CKR_CANCEL = 0x00000001;
  public const uint CKR_HOST_MEMORY = 0x00000002;
  public const uint CKR_SLOT_ID_INVALID = 0x00000003;
  public const uint CKR_GENERAL_ERROR = 0x00000005;
  public const uint CKR_FUNCTION_FAILED = 0x00000006;
  public const uint CKR_ARGUMENTS_BAD = 0x00000007;
  public const uint CKR_NO_EVENT = 0x00000008;
  public const uint CKR_NEED_TO_CREATE_THREADS = 0x00000009;
  public const uint CKR_CANT_LOCK = 0x0000000A;
  public const uint CKR_ATTRIBUTE_READ_ONLY = 0x00000010;
  public const uint CKR_ATTRIBUTE_SENSITIVE = 0x00000011;
  public const uint CKR_ATTRIBUTE_TYPE_INVALID = 0x00000012;
  public const uint CKR_ATTRIBUTE_VALUE_INVALID = 0x00000013;
  public const uint CKR_DATA_INVALID = 0x00000020;
  public const uint CKR_DATA_LEN_RANGE = 0x00000021;
  public const uint CKR_DEVICE_ERROR = 0x00000030;
  public const uint CKR_DEVICE_MEMORY = 0x00000031;
  public const uint CKR_DEVICE_REMOVED = 0x00000032;
  public const uint CKR_ENCRYPTED_DATA_INVALID = 0x00000040;
  public const uint CKR_ENCRYPTED_DATA_LEN_RANGE = 0x00000041;
  public const uint CKR_FUNCTION_CANCELED = 0x00000050;
  public const uint CKR_FUNCTION_NOT_PARALLEL = 0x00000051;
  public const uint CKR_FUNCTION_NOT_SUPPORTED = 0x00000054;
  public const uint CKR_KEY_HANDLE_INVALID = 0x00000060;
  public const uint CKR_KEY_SIZE_RANGE = 0x00000062;
  public const uint CKR_KEY_TYPE_INCONSISTENT = 0x00000063;
  public const uint CKR_KEY_NOT_NEEDED = 0x00000064;
  public const uint CKR_KEY_CHANGED = 0x00000065;
  public const uint CKR_KEY_NEEDED = 0x00000066;
  public const uint CKR_KEY_INDIGESTIBLE = 0x00000067;
  public const uint CKR_KEY_FUNCTION_NOT_PERMITTED = 0x00000068;
  public const uint CKR_KEY_NOT_WRAPPABLE = 0x00000069;
  public const uint CKR_KEY_UNEXTRACTABLE = 0x0000006A;
  public const uint CKR_MECHANISM_INVALID = 0x00000070;
  public const uint CKR_MECHANISM_PARAM_INVALID = 0x00000071;
  public const uint CKR_OBJECT_HANDLE_INVALID = 0x00000082;
  public const uint CKR_OPERATION_ACTIVE = 0x00000090;
  public const uint CKR_OPERATION_NOT_INITIALIZED = 0x00000091;
  public const uint CKR_PIN_INCORRECT = 0x000000A0;
  public const uint CKR_PIN_INVALID = 0x000000A1;
  public const uint CKR_PIN_LEN_RANGE = 0x000000A2;
  public const uint CKR_PIN_EXPIRED = 0x000000A3;
  public const uint CKR_PIN_LOCKED = 0x000000A4;
  public const uint CKR_SESSION_CLOSED = 0x000000B0;
  public const uint CKR_SESSION_COUNT = 0x000000B1;
  public const uint CKR_SESSION_HANDLE_INVALID = 0x000000B3;
  public const uint CKR_SESSION_PARALLEL_NOT_SUPPORTED = 0x000000B4;
  public const uint CKR_SESSION_READ_ONLY = 0x000000B5;
  public const uint CKR_SESSION_EXISTS = 0x000000B6;
  public const uint CKR_SESSION_READ_ONLY_EXISTS = 0x000000B7;
  public const uint CKR_SESSION_READ_WRITE_SO_EXISTS = 0x000000B8;
  public const uint CKR_SIGNATURE_INVALID = 0x000000C0;
  public const uint CKR_SIGNATURE_LEN_RANGE = 0x000000C1;
  public const uint CKR_TEMPLATE_INCOMPLETE = 0x000000D0;
  public const uint CKR_TEMPLATE_INCONSISTENT = 0x000000D1;
  public const uint CKR_TOKEN_NOT_PRESENT = 0x000000E0;
  public const uint CKR_TOKEN_NOT_RECOGNIZED = 0x000000E1;
  public const uint CKR_TOKEN_WRITE_PROTECTED = 0x000000E2;
  public const uint CKR_UNWRAPPING_KEY_HANDLE_INVALID = 0x000000F0;
  public const uint CKR_UNWRAPPING_KEY_SIZE_RANGE = 0x000000F1;
  public const uint CKR_UNWRAPPING_KEY_TYPE_INCONSISTENT = 0x000000F2;
  public const uint CKR_USER_ALREADY_LOGGED_IN = 0x00000100;
  public const uint CKR_USER_NOT_LOGGED_IN = 0x00000101;
  public const uint CKR_USER_PIN_NOT_INITIALIZED = 0x00000102;
  public const uint CKR_USER_TYPE_INVALID = 0x00000103;
  public const uint CKR_USER_ANOTHER_ALREADY_LOGGED_IN = 0x00000104;
  public const uint CKR_USER_TOO_MANY_TYPES = 0x00000105;
  public const uint CKR_WRAPPED_KEY_INVALID = 0x00000110;
  public const uint CKR_WRAPPED_KEY_LEN_RANGE = 0x00000112;
  public const uint CKR_WRAPPING_KEY_HANDLE_INVALID = 0x00000113;
  public const uint CKR_WRAPPING_KEY_SIZE_RANGE = 0x00000114;
  public const uint CKR_WRAPPING_KEY_TYPE_INCONSISTENT = 0x00000115;
  public const uint CKR_RANDOM_SEED_NOT_SUPPORTED = 0x00000120;
  public const uint CKR_RANDOM_NO_RNG = 0x00000121;
  public const uint CKR_DOMAIN_PARAMS_INVALID = 0x00000130;
  public const uint CKR_BUFFER_TOO_SMALL = 0x00000150;
  public const uint CKR_SAVED_STATE_INVALID = 0x00000160;
  public const uint CKR_INFORMATION_SENSITIVE = 0x00000170;
  public const uint CKR_STATE_UNSAVEABLE = 0x00000180;
  public const uint CKR_CRYPTOKI_NOT_INITIALIZED = 0x00000190;
  public const uint CKR_CRYPTOKI_ALREADY_INITIALIZED = 0x00000191;
  public const uint CKR_MUTEX_BAD = 0x000001A0;
  public const uint CKR_MUTEX_NOT_LOCKED = 0x000001A1;
  public const uint CKR_VENDOR_DEFINED = 0x80000000;

  public const uint CKO_DATA              = 0x00000000;
  public const uint CKO_CERTIFICATE       = 0x00000001;
  public const uint CKO_PUBLIC_KEY        = 0x00000002;
  public const uint CKO_PRIVATE_KEY       = 0x00000003;
  public const uint CKO_SECRET_KEY        = 0x00000004;
  public const uint CKO_HW_FEATURE        = 0x00000005;
  public const uint CKO_DOMAIN_PARAMETERS = 0x00000006;

  public const uint CKA_CLASS = 0x00000000;
  public const uint CKA_TOKEN = 0x00000001;
  public const uint CKA_PRIVATE = 0x00000002;
  public const uint CKA_LABEL = 0x00000003;
  public const uint CKA_APPLICATION = 0x00000010;
  public const uint CKA_VALUE = 0x00000011;
  public const uint CKA_OBJECT_ID = 0x00000012;
  public const uint CKA_CERTIFICATE_TYPE = 0x00000080;
  public const uint CKA_ISSUER = 0x00000081;
  public const uint CKA_SERIAL_NUMBER = 0x00000082;
  public const uint CKA_TRUSTED = 0x00000086;
  public const uint CKA_CERTIFICATE_CATEGORY = 0x00000087;
  public const uint CKA_KEY_TYPE = 0x00000100;
  public const uint CKA_SUBJECT = 0x00000101;
  public const uint CKA_ID = 0x00000102;
  public const uint CKA_SENSITIVE = 0x00000103;
  public const uint CKA_ENCRYPT = 0x00000104;
  public const uint CKA_DECRYPT = 0x00000105;
  public const uint CKA_WRAP = 0x00000106;
  public const uint CKA_UNWRAP = 0x00000107;
  public const uint CKA_SIGN = 0x00000108;
  public const uint CKA_SIGN_RECOVER = 0x00000109;
  public const uint CKA_VERIFY = 0x0000010A;
  public const uint CKA_VERIFY_RECOVER = 0x0000010B;
  public const uint CKA_DERIVE = 0x0000010C;
  public const uint CKA_START_DATE = 0x00000110;
  public const uint CKA_END_DATE = 0x00000111;
  public const uint CKA_MODULUS = 0x00000120;
  public const uint CKA_MODULUS_BITS = 0x00000121;
  public const uint CKA_PUBLIC_EXPONENT = 0x00000122;
  public const uint CKA_PRIVATE_EXPONENT = 0x00000123;
  public const uint CKA_PRIME_1 = 0x00000124;
  public const uint CKA_PRIME_2 = 0x00000125;
  public const uint CKA_EXPONENT_1 = 0x00000126;
  public const uint CKA_EXPONENT_2 = 0x00000127;
  public const uint CKA_COEFFICIENT = 0x00000128;
  public const uint CKA_VALUE_BITS = 0x00000160;
  public const uint CKA_VALUE_LEN = 0x00000161;
  public const uint CKA_EXTRACTABLE = 0x00000162;
  public const uint CKA_LOCAL = 0x00000163;
  public const uint CKA_NEVER_EXTRACTABLE = 0x00000164;
  public const uint CKA_ALWAYS_SENSITIVE = 0x00000165;
  public const uint CKA_KEY_GEN_MECHANISM = 0x00000166;
  public const uint CKA_MODIFIABLE = 0x00000170;
  public const uint CKA_EC_PARAMS = 0x00000180;
  public const uint CKA_EC_POINT = 0x00000181;
  public const uint CKA_SECONDARY_AUTH = 0x00000200;
  public const uint CKA_WRAP_WITH_TRUSTED = 0x00000210;
  public const uint CKA_ALWAYS_AUTHENTICATE = 0x00000202;

  public const uint DYCKA_UID                          = 0x80007201;
  public const uint DYCKA_REPLACED_UID                 = 0x80007205;
  public const uint DYCKA_LIMA_PUB_KEY                 = 0x80007207;
  public const uint DYCKA_EDDSA_PUB_KEY                = 0x80007208;
  public const uint DYCKA_PRIVATE_KEY_UID              = 0x8000720d;
  public const uint DYCKA_ECDSA_BIP_LEVEL              = 0x80007210;
  public const uint DYCKA_ECDSA_BIP_CHILD_NUMBER       = 0x80007211;
  public const uint DYCKA_ECDSA_BIP_PARENT_FINGERPRINT = 0x80007212;
  public const uint DYCKA_ECDSA_BIP_CPAR               = 0x80007213;
  public const uint DYCKA_ECDSA_BIP_PARENT_UID         = 0x80007214;
  public const uint DYCKA_ECDSA_BIP_HARDENED           = 0x80007215;
  public const uint DYCKA_DISTRIBUTED_KEY_GENERATION   = 0x80007216;
  public const uint DYCKA_STATE                        = 0x80007224;

  public const uint CKM_RSA_PKCS_KEY_PAIR_GEN = 0x00000000;
  public const uint CKM_RSA_PKCS = 0x00000001;
  public const uint CKM_RSA_X_509 = 0x00000003;
  public const uint CKM_SHA1_RSA_PKCS = 0x00000006;
  public const uint CKM_RSA_PKCS_OAEP = 0x00000009;
  public const uint CKM_RSA_PKCS_PSS = 0x0000000D;
  public const uint CKM_SHA1_RSA_PKCS_PSS = 0x0000000E;
  public const uint CKM_SHA256_RSA_PKCS = 0x00000040;
  public const uint CKM_SHA384_RSA_PKCS = 0x00000041;
  public const uint CKM_SHA512_RSA_PKCS = 0x00000042;
  public const uint CKM_SHA256_RSA_PKCS_PSS = 0x00000043;
  public const uint CKM_SHA384_RSA_PKCS_PSS = 0x00000044;
  public const uint CKM_SHA512_RSA_PKCS_PSS = 0x00000045;
  public const uint CKM_SHA_1 = 0x00000220;
  public const uint CKM_SHA256 = 0x00000250;
  public const uint CKM_SHA384 = 0x00000260;
  public const uint CKM_SHA512 = 0x00000270;
  public const uint CKM_EC_KEY_PAIR_GEN = 0x00001040;
  public const uint CKM_ECDSA = 0x00001041;
  public const uint CKM_ECDSA_SHA1 = 0x00001042;
  public const uint CKM_ECDSA_SHA256 = 0x00001044;
  public const uint CKM_ECDSA_SHA384 = 0x00001045;
  public const uint CKM_ECDSA_SHA512 = 0x00001046;
  public const uint CKM_ECDH1_DERIVE = 0x00001050;
  public const uint CKM_AES_CCM = 0x00001088;
  public const uint CKM_AES_KEY_GEN = 0x00001080;
  public const uint CKM_DES3_ECB = 0x00000132;
  public const uint CKM_AES_ECB = 0x00001081;
  public const uint CKM_AES_CBC = 0x00001082;
  public const uint CKM_DES3_CBC = 0x00000133;
  public const uint CKM_AES_OFB = 0x00002104;
  public const uint CKM_AES_CTR = 0x00001086;
  public const uint CKM_AES_GCM = 0x00001087;
  public const uint CKM_AES_GMAC = 0x0000108E;
  public const uint CKM_AES_CBC_PAD = 0x00001085;
  public const uint CKM_AES_CFB128 = 0x00002107;
  public const uint CKM_AES_CMAC = 0x0000108A;
  public const uint CKM_AES_KEY_WRAP = 0x00002109;
  public const uint CKM_AES_KEY_WRAP_PAD = 0x0000210A;
  public const uint CKM_DES3_KEY_GEN = 0x00000131;
  public const uint CKM_DES3_CBC_PAD = 0x00000136;
  public const uint CKM_DES_CFB64 = 0x00000152;
  public const uint CKM_DES_OFB64 = 0x00000150;
  public const uint CKM_DES3_CMAC = 0x00000138;
  public const uint CKM_GENERIC_SECRET_KEY_GEN = 0x00000350;
  public const uint CKM_SHA_1_HMAC = 0x00000221;
  public const uint CKM_SHA_1_HMAC_GENERAL = 0x00000222;
  public const uint CKM_SHA256_HMAC = 0x00000251;
  public const uint CKM_SHA256_HMAC_GENERAL = 0x00000252;
  public const uint CKM_SHA384_HMAC = 0x00000261;
  public const uint CKM_SHA384_HMAC_GENERAL = 0x00000262;
  public const uint CKM_SHA512_HMAC = 0x00000271;
  public const uint CKM_SHA512_HMAC_GENERAL = 0x00000272;
  public const uint CKM_CONCATENATE_BASE_AND_DATA = 0x00000362;
  public const uint CKM_CONCATENATE_DATA_AND_BASE = 0x00000363;
  public const uint CKM_SHA1_KEY_DERIVATION = 0x00000392;
  public const uint CKM_SHA256_KEY_DERIVATION = 0x00000393;
  public const uint CKM_SHA384_KEY_DERIVATION = 0x00000394;
  public const uint CKM_SHA512_KEY_DERIVATION = 0x00000395;
  public const uint CKM_EC_EDWARDS_KEY_PAIR_GEN    = 0x00001055;
  public const uint CKM_EC_MONTGOMERY_KEY_PAIR_GEN = 0x00001056;
  public const uint CKM_EDDSA                      = 0x00001057;

  public const uint DYCKM_AES_SIV           = 0x80007e01;
  public const uint DYCKM_AES_SIV_KEY_GEN   = 0x80007e02;
  public const uint DYCKM_PRF               = 0x80007e11;
  public const uint DYCKM_PRF_KEY_GEN       = 0x80007e12;
  public const uint DYCKM_ECIES             = 0x80007e13;
  public const uint DYCKM_FPE               = 0x80007e14; // format preserving
  public const uint DYCKM_OPE               = 0x80007e15; // order preserving
  public const uint DYCKM_SPE               = 0x80007e16; // size preserving
  public const uint DYCKM_NIST_KDF_CMAC_CTR = 0x80007e17;
  public const uint DYCKM_PASSWORD          = 0x80007e21;
  public const uint DYCKM_PASSWORD_KEY_GEN  = 0x80007e22;
  public const uint DYCKM_AES_XTS           = 0x80007e41;
  public const uint DYCKM_AES_XTS_KEY_GEN   = 0x80007e42;
  public const uint DYCKM_LIMA              = 0x80007e51;
  public const uint DYCKM_LIMA_KEY_GEN      = 0x80007e52;
  public const uint DYCKM_DERIVE_ECDSA_BIP  = 0x80007e60;
  public const uint DYCKM_DERIVE_EDDSA_BIP  = 0x80007e61;
  public const uint DYCKM_EDDSA             = 0x80007e81;
  public const uint DYCKM_EDDSA_KEY_GEN     = 0x80007e82;
  public const uint DYCKM_SCHNORR           = 0x80007e90;

  public const uint CKS_RO_PUBLIC_SESSION = 0x00000000;
  public const uint CKS_RO_USER_FUNCTIONS = 0x00000001;
  public const uint CKS_RW_USER_FUNCTIONS = 0x00000003;

  public const uint CKG_MGF1_SHA1 = 0x00000001;
  public const uint CKG_MGF1_SHA256 = 0x00000002;
  public const uint CKG_MGF1_SHA384 = 0x00000003;
  public const uint CKG_MGF1_SHA512 = 0x00000004;

  public const uint CKU_SO = 0;
  public const uint CKU_USER = 1;
  public const uint DYCKU_USER_CHECK = 0x80007001;

  public const uint CKZ_DATA_SPECIFIED = 0x00000001;

  public const uint DYCK_FPE_EMAIL = 1;
  public const uint DYCK_FPE_CREDIT_CARD = 2;
  public const uint DYCK_FPE_US_PHONE = 3;
  public const uint DYCK_FPE_SSN = 4;
  public const uint DYCK_FPE_STRING = 5;

  public const uint DYCK_STATE_ANY                   = CK_UNAVAILABLE_INFORMATION;
  public const uint DYCK_STATE_PREACTIVE             = 1;
  public const uint DYCK_STATE_ACTIVE                = 2;
  public const uint DYCK_STATE_DEACTIVATED           = 3;
  public const uint DYCK_STATE_COMPROMIZED           = 4;
  public const uint DYCK_STATE_DESTROYED             = 5;
  public const uint DYCK_STATE_DESTROYED_COMPROMIZED = 6;
}

} // namespace unbound.cryptoki