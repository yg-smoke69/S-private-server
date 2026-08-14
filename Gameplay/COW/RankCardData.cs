using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200020D")]
public class RankCardData : CSVBaseData
{
	[Token(Token = "0x4000C23")]
	[FieldOffset(Offset = "0x8")]
	public int Id;

	[Token(Token = "0x4000C24")]
	[FieldOffset(Offset = "0xC")]
	public int RPTimes;

	[Token(Token = "0x4000C25")]
	[FieldOffset(Offset = "0x10")]
	public int TokenTimes;

	[Token(Token = "0x4000C26")]
	[FieldOffset(Offset = "0x14")]
	public ERankCardType type;

	[Token(Token = "0x4000C27")]
	[FieldOffset(Offset = "0x18")]
	public int LowerRank;

	[Token(Token = "0x4000C28")]
	[FieldOffset(Offset = "0x1C")]
	public int UpperRank;

	[Token(Token = "0x6000A8B")]
	[Address(RVA = "0x196D728", Offset = "0x196D728", VA = "0x196D728")]
	public RankCardData()
	{
	}

	[Token(Token = "0x6000A8C")]
	[Address(RVA = "0x196D7AC", Offset = "0x196D7AC", VA = "0x196D7AC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000A8D")]
	[Address(RVA = "0x196D810", Offset = "0x196D810", VA = "0x196D810", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000A8E")]
	[Address(RVA = "0x196DA04", Offset = "0x196DA04", VA = "0x196DA04")]
	private ERankCardType GetCardType(int CardType)
	{
		return default(ERankCardType);
	}
}
