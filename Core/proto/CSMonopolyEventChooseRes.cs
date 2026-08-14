using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200184A")]
public class CSMonopolyEventChooseRes
{
	[Token(Token = "0x4009C9B")]
	[FieldOffset(Offset = "0x8")]
	public EMiniGame.MonopolyEventResultType type;

	[Token(Token = "0x4009C9C")]
	[FieldOffset(Offset = "0xC")]
	public uint value;

	[Token(Token = "0x6007EA4")]
	[Address(RVA = "0x3097FD0", Offset = "0x3097FD0", VA = "0x3097FD0")]
	public CSMonopolyEventChooseRes()
	{
	}
}
