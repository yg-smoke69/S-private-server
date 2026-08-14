using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031AC")]
public enum EModelDownloadState
{
	[Token(Token = "0x4012E48")]
	None,
	[Token(Token = "0x4012E49")]
	NeedDownload,
	[Token(Token = "0x4012E4A")]
	Running,
	[Token(Token = "0x4012E4B")]
	Paused,
	[Token(Token = "0x4012E4C")]
	Finished
}
