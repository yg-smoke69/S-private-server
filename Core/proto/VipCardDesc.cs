using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE0")]
public class VipCardDesc
{
	[Token(Token = "0x400AF5B")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AF5C")]
	[FieldOffset(Offset = "0xC")]
	public EVipCard.VipCardType type;

	[Token(Token = "0x400AF5D")]
	[FieldOffset(Offset = "0x10")]
	public uint percent;

	[Token(Token = "0x400AF5E")]
	[FieldOffset(Offset = "0x14")]
	public uint card_worth;

	[Token(Token = "0x400AF5F")]
	[FieldOffset(Offset = "0x18")]
	public uint other_worth;

	[Token(Token = "0x400AF60")]
	[FieldOffset(Offset = "0x1C")]
	public string show_id;

	[Token(Token = "0x600823B")]
	[Address(RVA = "0x33E4AD0", Offset = "0x33E4AD0", VA = "0x33E4AD0")]
	public VipCardDesc()
	{
	}
}
