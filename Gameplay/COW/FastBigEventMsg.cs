using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F80")]
public class FastBigEventMsg : FastMessage
{
	[Token(Token = "0x400C5BE")]
	[FieldOffset(Offset = "0xC")]
	public uint MsgType;

	[Token(Token = "0x6009C82")]
	[Address(RVA = "0xDE49CC", Offset = "0xDE49CC", VA = "0xDE49CC")]
	public FastBigEventMsg()
	{
	}
}
