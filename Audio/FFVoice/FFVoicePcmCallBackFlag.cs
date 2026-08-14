using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B3C")]
public enum FFVoicePcmCallBackFlag
{
	[Token(Token = "0x40193CC")]
	PcmCallbackFlag_Remote = 1,
	[Token(Token = "0x40193CD")]
	PcmCallbackFlag_Record = 2,
	[Token(Token = "0x40193CE")]
	PcmCallbackFlag_Mix = 4
}
