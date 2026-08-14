using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA4")]
public class PrayRandomDesc
{
	[Token(Token = "0x400A75B")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A75C")]
	[FieldOffset(Offset = "0xC")]
	public uint chest_sub_id;

	[Token(Token = "0x400A75D")]
	[FieldOffset(Offset = "0x10")]
	public uint pray_point;

	[Token(Token = "0x400A75E")]
	[FieldOffset(Offset = "0x14")]
	public uint rate;

	[Token(Token = "0x6008101")]
	[Address(RVA = "0x33E00A4", Offset = "0x33E00A4", VA = "0x33E00A4")]
	public PrayRandomDesc()
	{
	}
}
