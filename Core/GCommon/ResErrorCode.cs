using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B3")]
public enum ResErrorCode
{
	[Token(Token = "0x401B2D7")]
	OK,
	[Token(Token = "0x401B2D8")]
	CorruptFile,
	[Token(Token = "0x401B2D9")]
	SaveFailed,
	[Token(Token = "0x401B2DA")]
	DownloadFailed,
	[Token(Token = "0x401B2DB")]
	SSLAuthFailed,
	[Token(Token = "0x401B2DC")]
	InsufficientStorage,
	[Token(Token = "0x401B2DD")]
	UnZipped,
	[Token(Token = "0x401B2DE")]
	Others
}
