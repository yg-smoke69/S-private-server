using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA9")]
public class CupCDNSettingDesc
{
	[Token(Token = "0x400ADFD")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x400ADFE")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x400ADFF")]
	[FieldOffset(Offset = "0x10")]
	public bool is_animation_open;

	[Token(Token = "0x400AE00")]
	[FieldOffset(Offset = "0x14")]
	public string preview_resource;

	[Token(Token = "0x400AE01")]
	[FieldOffset(Offset = "0x18")]
	public string lobby_resource;

	[Token(Token = "0x400AE02")]
	[FieldOffset(Offset = "0x1C")]
	public string homepage_resource;

	[Token(Token = "0x400AE03")]
	[FieldOffset(Offset = "0x20")]
	public bool is_notice_open;

	[Token(Token = "0x400AE04")]
	[FieldOffset(Offset = "0x24")]
	public string notice_cdn1;

	[Token(Token = "0x400AE05")]
	[FieldOffset(Offset = "0x28")]
	public string notice_cdn2;

	[Token(Token = "0x400AE06")]
	[FieldOffset(Offset = "0x2C")]
	public string notice_cdn3;

	[Token(Token = "0x400AE07")]
	[FieldOffset(Offset = "0x30")]
	public string notice_cdn4;

	[Token(Token = "0x400AE08")]
	[FieldOffset(Offset = "0x34")]
	public string notice_cdn5;

	[Token(Token = "0x400AE09")]
	[FieldOffset(Offset = "0x38")]
	public uint go_pos1;

	[Token(Token = "0x400AE0A")]
	[FieldOffset(Offset = "0x3C")]
	public uint sub_pos1;

	[Token(Token = "0x400AE0B")]
	[FieldOffset(Offset = "0x40")]
	public uint go_pos2;

	[Token(Token = "0x400AE0C")]
	[FieldOffset(Offset = "0x44")]
	public uint sub_pos2;

	[Token(Token = "0x400AE0D")]
	[FieldOffset(Offset = "0x48")]
	public uint go_pos3;

	[Token(Token = "0x400AE0E")]
	[FieldOffset(Offset = "0x4C")]
	public uint sub_pos3;

	[Token(Token = "0x400AE0F")]
	[FieldOffset(Offset = "0x50")]
	public uint go_pos4;

	[Token(Token = "0x400AE10")]
	[FieldOffset(Offset = "0x54")]
	public uint sub_pos4;

	[Token(Token = "0x400AE11")]
	[FieldOffset(Offset = "0x58")]
	public uint go_pos5;

	[Token(Token = "0x400AE12")]
	[FieldOffset(Offset = "0x5C")]
	public uint sub_pos5;

	[Token(Token = "0x400AE13")]
	[FieldOffset(Offset = "0x60")]
	public string reward_resource;

	[Token(Token = "0x400AE14")]
	[FieldOffset(Offset = "0x64")]
	public bool full_screen_preheat_display;

	[Token(Token = "0x400AE15")]
	[FieldOffset(Offset = "0x68")]
	public string full_screen_preheat_resource;

	[Token(Token = "0x400AE16")]
	[FieldOffset(Offset = "0x6C")]
	public string login_animation_resource;

	[Token(Token = "0x400AE17")]
	[FieldOffset(Offset = "0x70")]
	public string language;

	[Token(Token = "0x6008204")]
	[Address(RVA = "0x309DA7C", Offset = "0x309DA7C", VA = "0x309DA7C")]
	public CupCDNSettingDesc()
	{
	}
}
