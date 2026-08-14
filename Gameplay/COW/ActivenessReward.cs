using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E8C")]
public class ActivenessReward
{
	[Token(Token = "0x4011C56")]
	[FieldOffset(Offset = "0x8")]
	public uint group_id;

	[Token(Token = "0x4011C57")]
	[FieldOffset(Offset = "0xC")]
	public uint box_id;

	[Token(Token = "0x4011C58")]
	[FieldOffset(Offset = "0x10")]
	public string box;

	[Token(Token = "0x4011C59")]
	[FieldOffset(Offset = "0x14")]
	public string box_icon1;

	[Token(Token = "0x4011C5A")]
	[FieldOffset(Offset = "0x18")]
	public string box_icon2;

	[Token(Token = "0x4011C5B")]
	[FieldOffset(Offset = "0x1C")]
	public string open_vfx;

	[Token(Token = "0x4011C5C")]
	[FieldOffset(Offset = "0x20")]
	public uint necessary_activeness;

	[Token(Token = "0x4011C5D")]
	[FieldOffset(Offset = "0x24")]
	public List<AwardDesc> awardsList;

	[Token(Token = "0x4011C5E")]
	[FieldOffset(Offset = "0x28")]
	public bool received;

	[Token(Token = "0x60136C6")]
	[Address(RVA = "0x14B93BC", Offset = "0x14B93BC", VA = "0x14B93BC")]
	public ActivenessReward()
	{
	}
}
