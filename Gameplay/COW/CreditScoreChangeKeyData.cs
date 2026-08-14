using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000101")]
public class CreditScoreChangeKeyData : CSVBaseData
{
	[Token(Token = "0x400066E")]
	[FieldOffset(Offset = "0x8")]
	public int ReasonId;

	[Token(Token = "0x400066F")]
	[FieldOffset(Offset = "0xC")]
	public string Key;

	[Token(Token = "0x6000683")]
	[Address(RVA = "0x1C865D0", Offset = "0x1C865D0", VA = "0x1C865D0")]
	public CreditScoreChangeKeyData()
	{
	}

	[Token(Token = "0x6000684")]
	[Address(RVA = "0x1C86654", Offset = "0x1C86654", VA = "0x1C86654", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000685")]
	[Address(RVA = "0x1C866B8", Offset = "0x1C866B8", VA = "0x1C866B8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
