using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B36")]
public class BigEventEntryDesc
{
	[Token(Token = "0x400AB11")]
	[FieldOffset(Offset = "0x8")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400AB12")]
	[FieldOffset(Offset = "0xC")]
	public uint entry_id;

	[Token(Token = "0x400AB13")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400AB14")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400AB15")]
	[FieldOffset(Offset = "0x18")]
	public uint start_timestamp;

	[Token(Token = "0x400AB16")]
	[FieldOffset(Offset = "0x1C")]
	public uint end_timestamp;

	[Token(Token = "0x400AB17")]
	[FieldOffset(Offset = "0x20")]
	public string entry_icon;

	[Token(Token = "0x400AB18")]
	[FieldOffset(Offset = "0x24")]
	public string title;

	[Token(Token = "0x400AB19")]
	[FieldOffset(Offset = "0x28")]
	public string go_pos;

	[Token(Token = "0x400AB1A")]
	[FieldOffset(Offset = "0x2C")]
	public string web_url;

	[Token(Token = "0x400AB1B")]
	[FieldOffset(Offset = "0x30")]
	public string is_main_activity;

	[Token(Token = "0x400AB1C")]
	[FieldOffset(Offset = "0x34")]
	public string cdn_image;

	[Token(Token = "0x400AB1D")]
	[FieldOffset(Offset = "0x38")]
	public string award_icon;

	[Token(Token = "0x400AB1E")]
	[FieldOffset(Offset = "0x3C")]
	public string title_cdn;

	[Token(Token = "0x400AB1F")]
	[FieldOffset(Offset = "0x40")]
	public string award_bg_cdn;

	[Token(Token = "0x400AB20")]
	[FieldOffset(Offset = "0x44")]
	public string title_language;

	[Token(Token = "0x400AB21")]
	[FieldOffset(Offset = "0x48")]
	public bool is_push_show;

	[Token(Token = "0x400AB22")]
	[FieldOffset(Offset = "0x4C")]
	public string sub_go_pos;

	[Token(Token = "0x6008191")]
	[Address(RVA = "0x317BF1C", Offset = "0x317BF1C", VA = "0x317BF1C")]
	public BigEventEntryDesc()
	{
	}
}
