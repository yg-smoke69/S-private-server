using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B72")]
public class MonopolyNodeDesc
{
	[Token(Token = "0x400ACA2")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ACA3")]
	[FieldOffset(Offset = "0xC")]
	public EMiniGame.MonopolyNodeType type;

	[Token(Token = "0x60081CD")]
	[Address(RVA = "0x30A9030", Offset = "0x30A9030", VA = "0x30A9030")]
	public MonopolyNodeDesc()
	{
	}
}
