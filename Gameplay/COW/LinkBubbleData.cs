using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000176")]
public class LinkBubbleData : CSVBaseData
{
	[Token(Token = "0x4000967")]
	[FieldOffset(Offset = "0x8")]
	public uint BubbleID;

	[Token(Token = "0x4000968")]
	[FieldOffset(Offset = "0xC")]
	public uint AvatarID;

	[Token(Token = "0x4000969")]
	[FieldOffset(Offset = "0x10")]
	public string BubbleKey;

	[Token(Token = "0x400096A")]
	[FieldOffset(Offset = "0x14")]
	public uint UnlockCondition;

	[Token(Token = "0x600088C")]
	[Address(RVA = "0xEC7228", Offset = "0xEC7228", VA = "0xEC7228")]
	public LinkBubbleData()
	{
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0xEC72AC", Offset = "0xEC72AC", VA = "0xEC72AC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0xEC7310", Offset = "0xEC7310", VA = "0xEC7310", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
