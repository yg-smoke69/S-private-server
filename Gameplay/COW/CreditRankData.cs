using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20000FB")]
public class CreditRankData : CSVBaseData
{
	[Token(Token = "0x4000659")]
	[FieldOffset(Offset = "0x8")]
	public int CreditRankBound;

	[Token(Token = "0x400065A")]
	[FieldOffset(Offset = "0xC")]
	public int CreditRecover;

	[Token(Token = "0x400065B")]
	[FieldOffset(Offset = "0x10")]
	public string CreditRankKey1;

	[Token(Token = "0x400065C")]
	[FieldOffset(Offset = "0x14")]
	public string CreditRankKey2;

	[Token(Token = "0x400065D")]
	[FieldOffset(Offset = "0x18")]
	public Color32 CreditScoreColor;

	[Token(Token = "0x6000657")]
	[Address(RVA = "0x1C86068", Offset = "0x1C86068", VA = "0x1C86068")]
	public CreditRankData()
	{
	}

	[Token(Token = "0x6000658")]
	[Address(RVA = "0x1C860EC", Offset = "0x1C860EC", VA = "0x1C860EC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000659")]
	[Address(RVA = "0x1C86150", Offset = "0x1C86150", VA = "0x1C86150", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
