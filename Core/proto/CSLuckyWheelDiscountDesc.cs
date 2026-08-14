using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B1")]
public class CSLuckyWheelDiscountDesc
{
	[Token(Token = "0x4009D90")]
	[FieldOffset(Offset = "0x8")]
	public uint discount_id;

	[Token(Token = "0x4009D91")]
	[FieldOffset(Offset = "0xC")]
	public uint award_type;

	[Token(Token = "0x4009D92")]
	[FieldOffset(Offset = "0x10")]
	public uint award_value;

	[Token(Token = "0x4009D93")]
	[FieldOffset(Offset = "0x14")]
	public uint weight;

	[Token(Token = "0x4009D94")]
	[FieldOffset(Offset = "0x18")]
	public uint award_level;

	[Token(Token = "0x4009D95")]
	[FieldOffset(Offset = "0x1C")]
	public bool need_share;

	[Token(Token = "0x6007F0A")]
	[Address(RVA = "0x3097968", Offset = "0x3097968", VA = "0x3097968")]
	public CSLuckyWheelDiscountDesc()
	{
	}
}
