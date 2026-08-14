using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B76")]
public class BooyahgoNodeDesc
{
	[Token(Token = "0x400ACBD")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ACBE")]
	[FieldOffset(Offset = "0xC")]
	public EMiniGame.BooyahgoNodeType type;

	[Token(Token = "0x60081D1")]
	[Address(RVA = "0x317CF6C", Offset = "0x317CF6C", VA = "0x317CF6C")]
	public BooyahgoNodeDesc()
	{
	}
}
