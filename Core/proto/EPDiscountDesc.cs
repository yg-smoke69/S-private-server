using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001702")]
public class EPDiscountDesc
{
	[Token(Token = "0x4009830")]
	[FieldOffset(Offset = "0x8")]
	public uint discount;

	[Token(Token = "0x4009831")]
	[FieldOffset(Offset = "0xC")]
	public bool is_show;

	[Token(Token = "0x4009832")]
	[FieldOffset(Offset = "0x10")]
	public string exp_group;

	[Token(Token = "0x4009833")]
	[FieldOffset(Offset = "0x14")]
	public string account_group;

	[Token(Token = "0x6007D5C")]
	[Address(RVA = "0x309F53C", Offset = "0x309F53C", VA = "0x309F53C")]
	public EPDiscountDesc()
	{
	}
}
