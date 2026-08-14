using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000251")]
public class TriggerDetailStyleData : CSVBaseData
{
	[Token(Token = "0x4000E11")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E12")]
	[FieldOffset(Offset = "0xC")]
	public string Title;

	[Token(Token = "0x4000E13")]
	[FieldOffset(Offset = "0x10")]
	public string Desc;

	[Token(Token = "0x4000E14")]
	[FieldOffset(Offset = "0x14")]
	public string TeamName;

	[Token(Token = "0x4000E15")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID TextureResID;

	[Token(Token = "0x4000E16")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID TeamIconRes;

	[Token(Token = "0x6000B87")]
	[Address(RVA = "0x232FA44", Offset = "0x232FA44", VA = "0x232FA44")]
	public TriggerDetailStyleData()
	{
	}

	[Token(Token = "0x6000B88")]
	[Address(RVA = "0x232FB1C", Offset = "0x232FB1C", VA = "0x232FB1C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B89")]
	[Address(RVA = "0x232FB80", Offset = "0x232FB80", VA = "0x232FB80", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
