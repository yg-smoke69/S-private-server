using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000D0")]
public class ClanExtendScaleData : CSVBaseData
{
	[Token(Token = "0x40004F7")]
	[FieldOffset(Offset = "0x8")]
	public int ExtendTimes;

	[Token(Token = "0x40004F8")]
	[FieldOffset(Offset = "0xC")]
	public int ExtendSize;

	[Token(Token = "0x40004F9")]
	[FieldOffset(Offset = "0x10")]
	public int DiamondCost;

	[Token(Token = "0x600059C")]
	[Address(RVA = "0x172A7C0", Offset = "0x172A7C0", VA = "0x172A7C0")]
	public ClanExtendScaleData()
	{
	}

	[Token(Token = "0x600059D")]
	[Address(RVA = "0x172A844", Offset = "0x172A844", VA = "0x172A844", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600059E")]
	[Address(RVA = "0x172A8A8", Offset = "0x172A8A8", VA = "0x172A8A8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
