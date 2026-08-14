using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001846")]
public class TriggeredEvent
{
	[Token(Token = "0x4009C93")]
	[FieldOffset(Offset = "0x8")]
	public EMiniGame.MonopolyNodeType type;

	[Token(Token = "0x4009C94")]
	[FieldOffset(Offset = "0xC")]
	public uint triggered_index;

	[Token(Token = "0x6007EA0")]
	[Address(RVA = "0x33E3DB0", Offset = "0x33E3DB0", VA = "0x33E3DB0")]
	public TriggeredEvent()
	{
	}
}
