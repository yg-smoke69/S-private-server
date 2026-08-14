using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BBC")]
public class MusicFestSignInDesc
{
	[Token(Token = "0x400AE91")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AE92")]
	[FieldOffset(Offset = "0xC")]
	public uint start_timestamp;

	[Token(Token = "0x400AE93")]
	[FieldOffset(Offset = "0x10")]
	public uint end_timestamp;

	[Token(Token = "0x400AE94")]
	[FieldOffset(Offset = "0x14")]
	public string today_pic;

	[Token(Token = "0x400AE95")]
	[FieldOffset(Offset = "0x18")]
	public string sign_in_desc;

	[Token(Token = "0x400AE96")]
	[FieldOffset(Offset = "0x1C")]
	public string next_pic;

	[Token(Token = "0x400AE97")]
	[FieldOffset(Offset = "0x20")]
	public string next_desc;

	[Token(Token = "0x400AE98")]
	[FieldOffset(Offset = "0x24")]
	public string today_activity_pic;

	[Token(Token = "0x400AE99")]
	[FieldOffset(Offset = "0x28")]
	public string today_activity_pic_desc;

	[Token(Token = "0x400AE9A")]
	[FieldOffset(Offset = "0x2C")]
	public string go_pos_text;

	[Token(Token = "0x400AE9B")]
	[FieldOffset(Offset = "0x30")]
	public uint go_pos;

	[Token(Token = "0x400AE9C")]
	[FieldOffset(Offset = "0x34")]
	public string sub_go_pos;

	[Token(Token = "0x400AE9D")]
	[FieldOffset(Offset = "0x38")]
	public string character;

	[Token(Token = "0x400AE9E")]
	[FieldOffset(Offset = "0x3C")]
	public string next_char;

	[Token(Token = "0x6008217")]
	[Address(RVA = "0x30A93B4", Offset = "0x30A93B4", VA = "0x30A93B4")]
	public MusicFestSignInDesc()
	{
	}
}
