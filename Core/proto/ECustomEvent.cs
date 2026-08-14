using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001457")]
public class ECustomEvent
{
	[Token(Token = "0x2001458")]
	public enum EventState
	{
		[Token(Token = "0x4008D5A")]
		EventState_NONE,
		[Token(Token = "0x4008D5B")]
		EventState_WARMUP,
		[Token(Token = "0x4008D5C")]
		EventState_PROCESS
	}

	[Token(Token = "0x6007AFF")]
	[Address(RVA = "0x309F2B8", Offset = "0x309F2B8", VA = "0x309F2B8")]
	public ECustomEvent()
	{
	}
}
