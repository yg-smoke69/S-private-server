using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A5D")]
public class AwakenComicDesc
{
	[Token(Token = "0x400A512")]
	[FieldOffset(Offset = "0x8")]
	public uint original_avatar_id;

	[Token(Token = "0x400A513")]
	[FieldOffset(Offset = "0xC")]
	public uint comic_id;

	[Token(Token = "0x400A514")]
	[FieldOffset(Offset = "0x10")]
	public uint unlock_item_id;

	[Token(Token = "0x400A515")]
	[FieldOffset(Offset = "0x14")]
	public uint unlock_item_cnt;

	[Token(Token = "0x60080B5")]
	[Address(RVA = "0x317B2DC", Offset = "0x317B2DC", VA = "0x317B2DC")]
	public AwakenComicDesc()
	{
	}
}
