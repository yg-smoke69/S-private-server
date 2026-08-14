using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000F2")]
public class WeaponScoreConfigData : CSVBaseData
{
	[Token(Token = "0x400061C")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x400061D")]
	[FieldOffset(Offset = "0xC")]
	public uint IsScore;

	[Token(Token = "0x6000620")]
	[Address(RVA = "0x21A5CB4", Offset = "0x21A5CB4", VA = "0x21A5CB4")]
	public WeaponScoreConfigData()
	{
	}

	[Token(Token = "0x6000621")]
	[Address(RVA = "0x21A5D38", Offset = "0x21A5D38", VA = "0x21A5D38", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000622")]
	[Address(RVA = "0x21A5D90", Offset = "0x21A5D90", VA = "0x21A5D90", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
