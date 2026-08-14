using Il2CppDummyDll;

namespace GarenaMSDK;

[Token(Token = "0x200005F")]
internal enum SDKIAPTaskState
{
	[Token(Token = "0x4000230")]
	Created,
	[Token(Token = "0x4000231")]
	Pending,
	[Token(Token = "0x4000232")]
	Succeeded,
	[Token(Token = "0x4000233")]
	Failed,
	[Token(Token = "0x4000234")]
	Destroyed
}
