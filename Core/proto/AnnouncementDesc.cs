using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C3")]
public class AnnouncementDesc
{
	[Token(Token = "0x40096E7")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x40096E8")]
	[FieldOffset(Offset = "0xC")]
	public uint order_in_this_language;

	[Token(Token = "0x40096E9")]
	[FieldOffset(Offset = "0x10")]
	public string title;

	[Token(Token = "0x40096EA")]
	[FieldOffset(Offset = "0x14")]
	public string image_url;

	[Token(Token = "0x40096EB")]
	[FieldOffset(Offset = "0x18")]
	public string fb_page_id;

	[Token(Token = "0x40096EC")]
	[FieldOffset(Offset = "0x1C")]
	public string image_url_for_lobby;

	[Token(Token = "0x40096ED")]
	[FieldOffset(Offset = "0x20")]
	public string link_url;

	[Token(Token = "0x40096EE")]
	[FieldOffset(Offset = "0x24")]
	public string desc;

	[Token(Token = "0x40096EF")]
	[FieldOffset(Offset = "0x28")]
	public long start_time;

	[Token(Token = "0x40096F0")]
	[FieldOffset(Offset = "0x30")]
	public long end_time;

	[Token(Token = "0x40096F1")]
	[FieldOffset(Offset = "0x38")]
	public string region;

	[Token(Token = "0x40096F2")]
	[FieldOffset(Offset = "0x3C")]
	public uint id;

	[Token(Token = "0x40096F3")]
	[FieldOffset(Offset = "0x40")]
	public bool use_embedded_browser;

	[Token(Token = "0x40096F4")]
	[FieldOffset(Offset = "0x44")]
	public EAnnouncement.Platform platform;

	[Token(Token = "0x40096F5")]
	[FieldOffset(Offset = "0x48")]
	public string country_code;

	[Token(Token = "0x40096F6")]
	[FieldOffset(Offset = "0x4C")]
	public EAnnouncement.AboutMax using_version;

	[Token(Token = "0x40096F7")]
	[FieldOffset(Offset = "0x50")]
	public EAnnouncement.PhoneQuality active_phone_quality;

	[Token(Token = "0x40096F8")]
	[FieldOffset(Offset = "0x54")]
	public uint gos_pos;

	[Token(Token = "0x40096F9")]
	[FieldOffset(Offset = "0x58")]
	public string sub_go_pos;

	[Token(Token = "0x40096FA")]
	[FieldOffset(Offset = "0x5C")]
	public string id_last_num;

	[Token(Token = "0x40096FB")]
	[FieldOffset(Offset = "0x60")]
	public uint announcement_type;

	[Token(Token = "0x40096FC")]
	[FieldOffset(Offset = "0x64")]
	public string table_title;

	[Token(Token = "0x6007D24")]
	[Address(RVA = "0x317AA18", Offset = "0x317AA18", VA = "0x317AA18")]
	public AnnouncementDesc()
	{
	}
}
