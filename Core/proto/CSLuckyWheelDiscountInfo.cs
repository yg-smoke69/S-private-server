using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018B2")]
public class CSLuckyWheelDiscountInfo
{
	[Token(Token = "0x4009D96")]
	[FieldOffset(Offset = "0x8")]
	public uint discount_id;

	[Token(Token = "0x4009D97")]
	[FieldOffset(Offset = "0xC")]
	public bool is_used;

	[Token(Token = "0x4009D98")]
	[FieldOffset(Offset = "0xD")]
	public bool is_active;

	[Token(Token = "0x6007F0B")]
	[Address(RVA = "0x3097970", Offset = "0x3097970", VA = "0x3097970")]
	public CSLuckyWheelDiscountInfo()
	{
	}
}
