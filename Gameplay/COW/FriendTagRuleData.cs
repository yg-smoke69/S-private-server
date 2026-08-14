using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000138")]
public class FriendTagRuleData : CSVBaseData
{
	[Token(Token = "0x40007EB")]
	[FieldOffset(Offset = "0x8")]
	public RecommendedFriendTag Tag;

	[Token(Token = "0x40007EC")]
	[FieldOffset(Offset = "0xC")]
	public bool Switch;

	[Token(Token = "0x40007ED")]
	[FieldOffset(Offset = "0x10")]
	public int TagNumLimit;

	[Token(Token = "0x40007EE")]
	[FieldOffset(Offset = "0x14")]
	public Color BgColor;

	[Token(Token = "0x40007EF")]
	[FieldOffset(Offset = "0x24")]
	public string Key;

	[Token(Token = "0x600078B")]
	[Address(RVA = "0xDF20C4", Offset = "0xDF20C4", VA = "0xDF20C4")]
	public FriendTagRuleData()
	{
	}

	[Token(Token = "0x600078C")]
	[Address(RVA = "0xDF2148", Offset = "0xDF2148", VA = "0xDF2148", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600078D")]
	[Address(RVA = "0xDF2294", Offset = "0xDF2294", VA = "0xDF2294", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
