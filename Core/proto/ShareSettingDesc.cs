using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF5")]
public class ShareSettingDesc
{
	[Token(Token = "0x400B00D")]
	[FieldOffset(Offset = "0x8")]
	public uint share_id;

	[Token(Token = "0x400B00E")]
	[FieldOffset(Offset = "0xC")]
	public string share_link_fb;

	[Token(Token = "0x400B00F")]
	[FieldOffset(Offset = "0x10")]
	public string share_link_vk;

	[Token(Token = "0x400B010")]
	[FieldOffset(Offset = "0x14")]
	public string share_link_line;

	[Token(Token = "0x400B011")]
	[FieldOffset(Offset = "0x18")]
	public string share_title_key;

	[Token(Token = "0x400B012")]
	[FieldOffset(Offset = "0x1C")]
	public string share_content_key;

	[Token(Token = "0x400B013")]
	[FieldOffset(Offset = "0x20")]
	public string share_caption_key;

	[Token(Token = "0x400B014")]
	[FieldOffset(Offset = "0x24")]
	public string sys_text_key_ios;

	[Token(Token = "0x400B015")]
	[FieldOffset(Offset = "0x28")]
	public string sys_text_key_android;

	[Token(Token = "0x400B016")]
	[FieldOffset(Offset = "0x2C")]
	public string share_picture_url;

	[Token(Token = "0x6008250")]
	[Address(RVA = "0x33E229C", Offset = "0x33E229C", VA = "0x33E229C")]
	public ShareSettingDesc()
	{
	}
}
