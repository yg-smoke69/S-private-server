using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000A7")]
public class AvatarAwakenTaskRefreshData : CSVBaseData
{
	[Token(Token = "0x40003C1")]
	[FieldOffset(Offset = "0x8")]
	public uint CharacterID;

	[Token(Token = "0x40003C2")]
	[FieldOffset(Offset = "0xC")]
	public uint[] RefreshCostType;

	[Token(Token = "0x40003C3")]
	[FieldOffset(Offset = "0x10")]
	public uint[] RefreshCost;

	[Token(Token = "0x40003C4")]
	[FieldOffset(Offset = "0x14")]
	public uint RefreshTimesLimit;

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x10FBDAC", Offset = "0x10FBDAC", VA = "0x10FBDAC")]
	public AvatarAwakenTaskRefreshData()
	{
	}

	[Token(Token = "0x600043D")]
	[Address(RVA = "0x10FBE30", Offset = "0x10FBE30", VA = "0x10FBE30", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600043E")]
	[Address(RVA = "0x10FBE94", Offset = "0x10FBE94", VA = "0x10FBE94", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
