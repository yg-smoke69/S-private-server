using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016C5")]
public class ScrollMarqueeDesc
{
	[Token(Token = "0x4009714")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x4009715")]
	[FieldOffset(Offset = "0xC")]
	public uint order_in_this_language;

	[Token(Token = "0x4009716")]
	[FieldOffset(Offset = "0x10")]
	public string content;

	[Token(Token = "0x4009717")]
	[FieldOffset(Offset = "0x18")]
	public long start_time;

	[Token(Token = "0x4009718")]
	[FieldOffset(Offset = "0x20")]
	public long end_time;

	[Token(Token = "0x4009719")]
	[FieldOffset(Offset = "0x28")]
	public string region;

	[Token(Token = "0x400971A")]
	[FieldOffset(Offset = "0x2C")]
	public uint gos_pos;

	[Token(Token = "0x400971B")]
	[FieldOffset(Offset = "0x30")]
	public string gos_url;

	[Token(Token = "0x400971C")]
	[FieldOffset(Offset = "0x34")]
	public bool use_embedded_browser;

	[Token(Token = "0x400971D")]
	[FieldOffset(Offset = "0x38")]
	public string sub_go_pos;

	[Token(Token = "0x400971E")]
	[FieldOffset(Offset = "0x3C")]
	public EAnnouncement.Platform platform;

	[Token(Token = "0x400971F")]
	[FieldOffset(Offset = "0x40")]
	public string country_code;

	[Token(Token = "0x4009720")]
	[FieldOffset(Offset = "0x44")]
	public EAnnouncement.AboutMax using_version;

	[Token(Token = "0x4009721")]
	[FieldOffset(Offset = "0x48")]
	public EAnnouncement.PhoneQuality active_phone_quality;

	[Token(Token = "0x6007D26")]
	[Address(RVA = "0x33E1F90", Offset = "0x33E1F90", VA = "0x33E1F90")]
	public ScrollMarqueeDesc()
	{
	}
}
