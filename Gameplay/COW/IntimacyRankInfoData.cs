using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200015F")]
public class IntimacyRankInfoData : CSVBaseData
{
	[Token(Token = "0x40008E7")]
	[FieldOffset(Offset = "0x8")]
	public uint RelationType;

	[Token(Token = "0x40008E8")]
	[FieldOffset(Offset = "0xC")]
	public uint IntimacyRank;

	[Token(Token = "0x40008E9")]
	[FieldOffset(Offset = "0x10")]
	public uint LowerBound;

	[Token(Token = "0x40008EA")]
	[FieldOffset(Offset = "0x14")]
	public uint UpperBound;

	[Token(Token = "0x40008EB")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID RelationBadgeIcon;

	[Token(Token = "0x6000847")]
	[Address(RVA = "0x1EDFD14", Offset = "0x1EDFD14", VA = "0x1EDFD14")]
	public IntimacyRankInfoData()
	{
	}

	[Token(Token = "0x6000848")]
	[Address(RVA = "0x1EDFD98", Offset = "0x1EDFD98", VA = "0x1EDFD98", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000849")]
	[Address(RVA = "0x1EDFDFC", Offset = "0x1EDFDFC", VA = "0x1EDFDFC")]
	public static string GeneratePrimaryKey(uint relationType, uint IntimacyRank)
	{
		return null;
	}

	[Token(Token = "0x600084A")]
	[Address(RVA = "0x1EDFE84", Offset = "0x1EDFE84", VA = "0x1EDFE84", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
