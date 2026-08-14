using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C4")]
public class SplashBannerDesc
{
	[Token(Token = "0x40096FD")]
	[FieldOffset(Offset = "0x8")]
	public string region;

	[Token(Token = "0x40096FE")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x40096FF")]
	[FieldOffset(Offset = "0x10")]
	public uint id;

	[Token(Token = "0x4009700")]
	[FieldOffset(Offset = "0x14")]
	public string name;

	[Token(Token = "0x4009701")]
	[FieldOffset(Offset = "0x18")]
	public uint sort_id;

	[Token(Token = "0x4009702")]
	[FieldOffset(Offset = "0x20")]
	public long start_time;

	[Token(Token = "0x4009703")]
	[FieldOffset(Offset = "0x28")]
	public long end_time;

	[Token(Token = "0x4009704")]
	[FieldOffset(Offset = "0x30")]
	public string image_url;

	[Token(Token = "0x4009705")]
	[FieldOffset(Offset = "0x34")]
	public uint gos_pos;

	[Token(Token = "0x4009706")]
	[FieldOffset(Offset = "0x38")]
	public string gos_url;

	[Token(Token = "0x4009707")]
	[FieldOffset(Offset = "0x3C")]
	public bool use_embedded_browser;

	[Token(Token = "0x4009708")]
	[FieldOffset(Offset = "0x40")]
	public string sub_go_pos;

	[Token(Token = "0x4009709")]
	[FieldOffset(Offset = "0x44")]
	public string video_url;

	[Token(Token = "0x400970A")]
	[FieldOffset(Offset = "0x48")]
	public string bg_img_url;

	[Token(Token = "0x400970B")]
	[FieldOffset(Offset = "0x4C")]
	public uint type;

	[Token(Token = "0x400970C")]
	[FieldOffset(Offset = "0x50")]
	public EAnnouncement.Platform platform;

	[Token(Token = "0x400970D")]
	[FieldOffset(Offset = "0x54")]
	public uint weight;

	[Token(Token = "0x400970E")]
	[FieldOffset(Offset = "0x58")]
	public string country_code;

	[Token(Token = "0x400970F")]
	[FieldOffset(Offset = "0x5C")]
	public EAnnouncement.AboutMax using_version;

	[Token(Token = "0x4009710")]
	[FieldOffset(Offset = "0x60")]
	public EAnnouncement.PhoneQuality active_phone_quality;

	[Token(Token = "0x4009711")]
	[FieldOffset(Offset = "0x64")]
	public string id_last_num;

	[Token(Token = "0x4009712")]
	[FieldOffset(Offset = "0x68")]
	public uint dynamic_item_id;

	[Token(Token = "0x4009713")]
	[FieldOffset(Offset = "0x6C")]
	public float dynamic_size;

	[Token(Token = "0x6007D25")]
	[Address(RVA = "0x33E26A4", Offset = "0x33E26A4", VA = "0x33E26A4")]
	public SplashBannerDesc()
	{
	}
}
