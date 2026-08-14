using Il2CppDummyDll;

[Token(Token = "0x2003D76")]
public enum AkGlobalCallbackLocation
{
	[Token(Token = "0x401A1D5")]
	AkGlobalCallbackLocation_Register = 1,
	[Token(Token = "0x401A1D6")]
	AkGlobalCallbackLocation_Begin = 2,
	[Token(Token = "0x401A1D7")]
	AkGlobalCallbackLocation_PreProcessMessageQueueForRender = 4,
	[Token(Token = "0x401A1D8")]
	AkGlobalCallbackLocation_PostMessagesProcessed = 8,
	[Token(Token = "0x401A1D9")]
	AkGlobalCallbackLocation_BeginRender = 16,
	[Token(Token = "0x401A1DA")]
	AkGlobalCallbackLocation_EndRender = 32,
	[Token(Token = "0x401A1DB")]
	AkGlobalCallbackLocation_End = 64,
	[Token(Token = "0x401A1DC")]
	AkGlobalCallbackLocation_Term = 128,
	[Token(Token = "0x401A1DD")]
	AkGlobalCallbackLocation_Monitor = 256,
	[Token(Token = "0x401A1DE")]
	AkGlobalCallbackLocation_MonitorRecap = 512,
	[Token(Token = "0x401A1DF")]
	AkGlobalCallbackLocation_Init = 1024,
	[Token(Token = "0x401A1E0")]
	AkGlobalCallbackLocation_Suspend = 2048,
	[Token(Token = "0x401A1E1")]
	AkGlobalCallbackLocation_WakeupFromSuspend = 4096,
	[Token(Token = "0x401A1E2")]
	AkGlobalCallbackLocation_Num = 13
}
