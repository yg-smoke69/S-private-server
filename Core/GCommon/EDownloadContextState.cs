using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x20040C8")]
public enum EDownloadContextState
{
	[Token(Token = "0x401B383")]
	None,
	[Token(Token = "0x401B384")]
	ReadyForStart,
	[Token(Token = "0x401B385")]
	Download,
	[Token(Token = "0x401B386")]
	Pending,
	[Token(Token = "0x401B387")]
	Paused,
	[Token(Token = "0x401B388")]
	DownloadFinished
}
