using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A95")]
public class AdvertDesc
{
	[Token(Token = "0x400A66E")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A66F")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x400A670")]
	[FieldOffset(Offset = "0x10")]
	public uint sort_id;

	[Token(Token = "0x400A671")]
	[FieldOffset(Offset = "0x14")]
	public string language;

	[Token(Token = "0x400A672")]
	[FieldOffset(Offset = "0x18")]
	public string advertisment_url;

	[Token(Token = "0x400A673")]
	[FieldOffset(Offset = "0x1C")]
	public uint ad_start_time;

	[Token(Token = "0x400A674")]
	[FieldOffset(Offset = "0x20")]
	public uint ad_end_time;

	[Token(Token = "0x400A675")]
	[FieldOffset(Offset = "0x24")]
	public uint go_pos;

	[Token(Token = "0x400A676")]
	[FieldOffset(Offset = "0x28")]
	public uint sub_type;

	[Token(Token = "0x400A677")]
	[FieldOffset(Offset = "0x2C")]
	public string sub_go_pos;

	[Token(Token = "0x400A678")]
	[FieldOffset(Offset = "0x30")]
	public bool external_for_official_website;

	[Token(Token = "0x400A679")]
	[FieldOffset(Offset = "0x31")]
	public bool go_to_switch;

	[Token(Token = "0x400A67A")]
	[FieldOffset(Offset = "0x34")]
	public uint small_start_time;

	[Token(Token = "0x400A67B")]
	[FieldOffset(Offset = "0x38")]
	public uint show_end_time;

	[Token(Token = "0x60080F2")]
	[Address(RVA = "0x317A6E4", Offset = "0x317A6E4", VA = "0x317A6E4")]
	public AdvertDesc()
	{
	}
}
