using Il2CppDummyDll;

[Token(Token = "0x2000D43")]
public enum EGameVoiceEvent
{
	[Token(Token = "0x4006B06")]
	None,
	[Token(Token = "0x4006B07")]
	InitOK,
	[Token(Token = "0x4006B08")]
	InitFailed,
	[Token(Token = "0x4006B09")]
	JoinOK,
	[Token(Token = "0x4006B0A")]
	JoinFailed,
	[Token(Token = "0x4006B0B")]
	Leaved,
	[Token(Token = "0x4006B0C")]
	Resumed,
	[Token(Token = "0x4006B0D")]
	Paused,
	[Token(Token = "0x4006B0E")]
	Reconnecting,
	[Token(Token = "0x4006B0F")]
	Reconnected,
	[Token(Token = "0x4006B10")]
	OthersMicOff,
	[Token(Token = "0x4006B11")]
	OthersMicOn,
	[Token(Token = "0x4006B12")]
	OthersSpeakerOff,
	[Token(Token = "0x4006B13")]
	OthersSpeakerOn,
	[Token(Token = "0x4006B14")]
	OthersVoiceOff,
	[Token(Token = "0x4006B15")]
	OthersVoiceOn,
	[Token(Token = "0x4006B16")]
	OwnVoiceStart,
	[Token(Token = "0x4006B17")]
	OwnVoiceOver,
	[Token(Token = "0x4006B18")]
	OwnVoiceOn,
	[Token(Token = "0x4006B19")]
	ListenOtherOn,
	[Token(Token = "0x4006B1A")]
	ListenOtherOff,
	[Token(Token = "0x4006B1B")]
	ReportAudio,
	[Token(Token = "0x4006B1C")]
	MuteNotify,
	[Token(Token = "0x4006B1D")]
	HasError
}
