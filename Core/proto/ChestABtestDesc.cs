using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA5")]
public class ChestABtestDesc
{
	[Token(Token = "0x400A75F")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400A760")]
	[FieldOffset(Offset = "0xC")]
	public string @class;

	[Token(Token = "0x400A761")]
	[FieldOffset(Offset = "0x10")]
	public uint original_melon_pi;

	[Token(Token = "0x400A762")]
	[FieldOffset(Offset = "0x14")]
	public uint abtest_melon_pi;

	[Token(Token = "0x400A763")]
	[FieldOffset(Offset = "0x18")]
	public uint chest_sub_id;

	[Token(Token = "0x400A764")]
	[FieldOffset(Offset = "0x1C")]
	public uint id;

	[Token(Token = "0x400A765")]
	[FieldOffset(Offset = "0x20")]
	public float second_ratio0;

	[Token(Token = "0x400A766")]
	[FieldOffset(Offset = "0x24")]
	public float second_ratio1;

	[Token(Token = "0x400A767")]
	[FieldOffset(Offset = "0x28")]
	public float second_ratio2;

	[Token(Token = "0x400A768")]
	[FieldOffset(Offset = "0x2C")]
	public float second_ratio3;

	[Token(Token = "0x400A769")]
	[FieldOffset(Offset = "0x30")]
	public float second_ratio4;

	[Token(Token = "0x6008102")]
	[Address(RVA = "0x309B438", Offset = "0x309B438", VA = "0x309B438")]
	public ChestABtestDesc()
	{
	}
}
