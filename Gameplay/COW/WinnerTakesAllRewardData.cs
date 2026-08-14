using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000270")]
internal class WinnerTakesAllRewardData : CSVBaseData
{
	[Token(Token = "0x4000ED9")]
	[FieldOffset(Offset = "0x8")]
	public uint GroupMode;

	[Token(Token = "0x4000EDA")]
	[FieldOffset(Offset = "0xC")]
	public uint FirstChipNum;

	[Token(Token = "0x4000EDB")]
	[FieldOffset(Offset = "0x10")]
	public uint SecondChipNum;

	[Token(Token = "0x4000EDC")]
	[FieldOffset(Offset = "0x14")]
	public uint ThirdChipNum;

	[Token(Token = "0x6000BF3")]
	[Address(RVA = "0x21BB1E4", Offset = "0x21BB1E4", VA = "0x21BB1E4")]
	public WinnerTakesAllRewardData()
	{
	}

	[Token(Token = "0x6000BF4")]
	[Address(RVA = "0x21BB268", Offset = "0x21BB268", VA = "0x21BB268", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BF5")]
	[Address(RVA = "0x21BB2CC", Offset = "0x21BB2CC", VA = "0x21BB2CC")]
	public uint SumChipNum()
	{
		return default(uint);
	}

	[Token(Token = "0x6000BF6")]
	[Address(RVA = "0x21BB334", Offset = "0x21BB334", VA = "0x21BB334", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
