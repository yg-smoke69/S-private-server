using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BBA")]
public class MusicFestCardDesc
{
	[Token(Token = "0x400AE85")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AE86")]
	[FieldOffset(Offset = "0xC")]
	public uint item_id;

	[Token(Token = "0x400AE87")]
	[FieldOffset(Offset = "0x10")]
	public string card_icon1;

	[Token(Token = "0x400AE88")]
	[FieldOffset(Offset = "0x14")]
	public string card_icon2;

	[Token(Token = "0x400AE89")]
	[FieldOffset(Offset = "0x18")]
	public string card_text1;

	[Token(Token = "0x400AE8A")]
	[FieldOffset(Offset = "0x1C")]
	public string card_text2;

	[Token(Token = "0x400AE8B")]
	[FieldOffset(Offset = "0x20")]
	public string default_cdn;

	[Token(Token = "0x400AE8C")]
	[FieldOffset(Offset = "0x24")]
	public uint go_pos;

	[Token(Token = "0x400AE8D")]
	[FieldOffset(Offset = "0x28")]
	public string sub_go_pos;

	[Token(Token = "0x6008215")]
	[Address(RVA = "0x30A9208", Offset = "0x30A9208", VA = "0x30A9208")]
	public MusicFestCardDesc()
	{
	}
}
