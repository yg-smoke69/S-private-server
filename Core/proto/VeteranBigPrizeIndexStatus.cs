using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A10")]
public class VeteranBigPrizeIndexStatus
{
	[Token(Token = "0x400A376")]
	[FieldOffset(Offset = "0x8")]
	public uint index;

	[Token(Token = "0x400A377")]
	[FieldOffset(Offset = "0xC")]
	public EAttendance.VeteranTaskBigPrize status;

	[Token(Token = "0x6008068")]
	[Address(RVA = "0x33E44F4", Offset = "0x33E44F4", VA = "0x33E44F4")]
	public VeteranBigPrizeIndexStatus()
	{
	}
}
