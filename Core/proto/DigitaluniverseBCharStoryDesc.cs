using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B63")]
public class DigitaluniverseBCharStoryDesc
{
	[Token(Token = "0x400AC53")]
	[FieldOffset(Offset = "0x8")]
	public uint story_id;

	[Token(Token = "0x400AC54")]
	[FieldOffset(Offset = "0xC")]
	public uint story_group_id;

	[Token(Token = "0x400AC55")]
	[FieldOffset(Offset = "0x10")]
	public List<DigitaluniverseBStoryBranchDesc> branches;

	[Token(Token = "0x400AC56")]
	[FieldOffset(Offset = "0x14")]
	public uint story_content_type;

	[Token(Token = "0x400AC57")]
	[FieldOffset(Offset = "0x18")]
	public uint character_pose;

	[Token(Token = "0x400AC58")]
	[FieldOffset(Offset = "0x1C")]
	public string story_content_key;

	[Token(Token = "0x400AC59")]
	[FieldOffset(Offset = "0x20")]
	public uint character_left;

	[Token(Token = "0x400AC5A")]
	[FieldOffset(Offset = "0x24")]
	public uint character_right;

	[Token(Token = "0x60081BE")]
	[Address(RVA = "0x309E9EC", Offset = "0x309E9EC", VA = "0x309E9EC")]
	public DigitaluniverseBCharStoryDesc()
	{
	}
}
