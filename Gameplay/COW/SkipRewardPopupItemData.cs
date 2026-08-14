using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000234")]
public class SkipRewardPopupItemData : CSVBaseData
{
	[Token(Token = "0x4000D81")]
	[FieldOffset(Offset = "0x8")]
	public uint ItemID;

	[Token(Token = "0x4000D82")]
	[FieldOffset(Offset = "0xC")]
	public uint Type;

	[Token(Token = "0x4000D83")]
	[FieldOffset(Offset = "0x10")]
	public uint SubType;

	[Token(Token = "0x4000D84")]
	[FieldOffset(Offset = "0x14")]
	public uint RareOpen;

	[Token(Token = "0x6000B31")]
	[Address(RVA = "0x20F0014", Offset = "0x20F0014", VA = "0x20F0014")]
	public SkipRewardPopupItemData()
	{
	}

	[Token(Token = "0x6000B32")]
	[Address(RVA = "0x20F0098", Offset = "0x20F0098", VA = "0x20F0098", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B33")]
	[Address(RVA = "0x20F00FC", Offset = "0x20F00FC", VA = "0x20F00FC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
