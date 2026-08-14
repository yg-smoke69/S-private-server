using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002D9B")]
public class AutoPopupWindowCtrlData : CSVBaseData
{
	[Token(Token = "0x4011810")]
	[FieldOffset(Offset = "0x8")]
	public int id;

	[Token(Token = "0x4011811")]
	[FieldOffset(Offset = "0xC")]
	public int levelLimitA;

	[Token(Token = "0x4011812")]
	[FieldOffset(Offset = "0x10")]
	public int regDayLimitA;

	[Token(Token = "0x4011813")]
	[FieldOffset(Offset = "0x14")]
	public int levelLimitB;

	[Token(Token = "0x4011814")]
	[FieldOffset(Offset = "0x18")]
	public int regDayLimitB;

	[Token(Token = "0x4011815")]
	[FieldOffset(Offset = "0x1C")]
	public int levelLimitC;

	[Token(Token = "0x4011816")]
	[FieldOffset(Offset = "0x20")]
	public int regDayLimitC;

	[Token(Token = "0x6013178")]
	[Address(RVA = "0x10E8508", Offset = "0x10E8508", VA = "0x10E8508")]
	public AutoPopupWindowCtrlData()
	{
	}

	[Token(Token = "0x6013179")]
	[Address(RVA = "0x10E858C", Offset = "0x10E858C", VA = "0x10E858C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x601317A")]
	[Address(RVA = "0x10E85F0", Offset = "0x10E85F0", VA = "0x10E85F0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
