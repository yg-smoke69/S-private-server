using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C11")]
public class Rampage4BTowerDesc
{
	[Token(Token = "0x400B09D")]
	[FieldOffset(Offset = "0x8")]
	public uint phase_id;

	[Token(Token = "0x400B09E")]
	[FieldOffset(Offset = "0xC")]
	public uint level;

	[Token(Token = "0x400B09F")]
	[FieldOffset(Offset = "0x10")]
	public uint hyper_level;

	[Token(Token = "0x400B0A0")]
	[FieldOffset(Offset = "0x14")]
	public ERampage4BTower.TowerType type;

	[Token(Token = "0x400B0A1")]
	[FieldOffset(Offset = "0x18")]
	public uint before_story_id;

	[Token(Token = "0x400B0A2")]
	[FieldOffset(Offset = "0x1C")]
	public uint after_story_id;

	[Token(Token = "0x600826B")]
	[Address(RVA = "0x33E03CC", Offset = "0x33E03CC", VA = "0x33E03CC")]
	public Rampage4BTowerDesc()
	{
	}
}
