using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001EA")]
public class PeriodicRankingDataDisplayData : CSVBaseData
{
	[Token(Token = "0x4000B75")]
	[FieldOffset(Offset = "0x8")]
	public int GameMode;

	[Token(Token = "0x4000B76")]
	[FieldOffset(Offset = "0xC")]
	public bool ShowDoubleKill;

	[Token(Token = "0x4000B77")]
	[FieldOffset(Offset = "0xD")]
	public bool ShowQuadraKill;

	[Token(Token = "0x6000A12")]
	[Address(RVA = "0x2DDFC54", Offset = "0x2DDFC54", VA = "0x2DDFC54")]
	public PeriodicRankingDataDisplayData()
	{
	}

	[Token(Token = "0x6000A13")]
	[Address(RVA = "0x2DDFCD8", Offset = "0x2DDFCD8", VA = "0x2DDFCD8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A14")]
	[Address(RVA = "0x2DDFD3C", Offset = "0x2DDFD3C", VA = "0x2DDFD3C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
