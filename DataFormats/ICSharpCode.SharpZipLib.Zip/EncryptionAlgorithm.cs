using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C02")]
public enum EncryptionAlgorithm
{
	[Token(Token = "0x401996C")]
	None = 0,
	[Token(Token = "0x401996D")]
	PkzipClassic = 1,
	[Token(Token = "0x401996E")]
	Des = 26113,
	[Token(Token = "0x401996F")]
	RC2 = 26114,
	[Token(Token = "0x4019970")]
	TripleDes168 = 26115,
	[Token(Token = "0x4019971")]
	TripleDes112 = 26121,
	[Token(Token = "0x4019972")]
	Aes128 = 26126,
	[Token(Token = "0x4019973")]
	Aes192 = 26127,
	[Token(Token = "0x4019974")]
	Aes256 = 26128,
	[Token(Token = "0x4019975")]
	RC2Corrected = 26370,
	[Token(Token = "0x4019976")]
	Blowfish = 26400,
	[Token(Token = "0x4019977")]
	Twofish = 26401,
	[Token(Token = "0x4019978")]
	RC4 = 26625,
	[Token(Token = "0x4019979")]
	Unknown = 65535
}
