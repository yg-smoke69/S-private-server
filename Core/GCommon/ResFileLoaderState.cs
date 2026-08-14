using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040B4")]
public enum ResFileLoaderState
{
	[Token(Token = "0x401B2E0")]
	None,
	[Token(Token = "0x401B2E1")]
	Downloading,
	[Token(Token = "0x401B2E2")]
	DownloadEnd,
	[Token(Token = "0x401B2E3")]
	UnZip,
	[Token(Token = "0x401B2E4")]
	ZipEnd
}
