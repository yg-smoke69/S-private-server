using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C12")]
public class Rampage4BTowerStoryDesc
{
	[Token(Token = "0x400B0A3")]
	[FieldOffset(Offset = "0x8")]
	public uint story_id;

	[Token(Token = "0x400B0A4")]
	[FieldOffset(Offset = "0xC")]
	public uint[] next_story_id;

	[Token(Token = "0x400B0A5")]
	[FieldOffset(Offset = "0x10")]
	public uint story_content_type;

	[Token(Token = "0x400B0A6")]
	[FieldOffset(Offset = "0x14")]
	public uint character_id;

	[Token(Token = "0x400B0A7")]
	[FieldOffset(Offset = "0x18")]
	public string story_content_key;

	[Token(Token = "0x400B0A8")]
	[FieldOffset(Offset = "0x1C")]
	public string fight_character_vfx;

	[Token(Token = "0x400B0A9")]
	[FieldOffset(Offset = "0x20")]
	public string fight_character_sound;

	[Token(Token = "0x400B0AA")]
	[FieldOffset(Offset = "0x24")]
	public uint story_result;

	[Token(Token = "0x400B0AB")]
	[FieldOffset(Offset = "0x28")]
	public uint bg_character_id;

	[Token(Token = "0x400B0AC")]
	[FieldOffset(Offset = "0x2C")]
	public string after_dialogue_show_spine_res;

	[Token(Token = "0x600826C")]
	[Address(RVA = "0x33E03EC", Offset = "0x33E03EC", VA = "0x33E03EC")]
	public Rampage4BTowerStoryDesc()
	{
	}
}
