using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE8")]
public class JumpsuitSettingDesc
{
	[Token(Token = "0x400AFAE")]
	[FieldOffset(Offset = "0x8")]
	public uint total_amount;

	[Token(Token = "0x400AFAF")]
	[FieldOffset(Offset = "0xC")]
	public float first_level_speed;

	[Token(Token = "0x400AFB0")]
	[FieldOffset(Offset = "0x10")]
	public uint max_storage;

	[Token(Token = "0x400AFB1")]
	[FieldOffset(Offset = "0x14")]
	public uint token_id;

	[Token(Token = "0x400AFB2")]
	[FieldOffset(Offset = "0x18")]
	public uint amount_per_token;

	[Token(Token = "0x400AFB3")]
	[FieldOffset(Offset = "0x1C")]
	public uint token_per_help;

	[Token(Token = "0x400AFB4")]
	[FieldOffset(Offset = "0x20")]
	public AwardDesc helper_reward;

	[Token(Token = "0x400AFB5")]
	[FieldOffset(Offset = "0x24")]
	public string web_event_url;

	[Token(Token = "0x400AFB6")]
	[FieldOffset(Offset = "0x28")]
	public uint web_event_start_time;

	[Token(Token = "0x400AFB7")]
	[FieldOffset(Offset = "0x2C")]
	public uint web_event_end_time;

	[Token(Token = "0x400AFB8")]
	[FieldOffset(Offset = "0x30")]
	public string share_web_page_url;

	[Token(Token = "0x400AFB9")]
	[FieldOffset(Offset = "0x34")]
	public uint after_total_amount;

	[Token(Token = "0x400AFBA")]
	[FieldOffset(Offset = "0x38")]
	public uint invite_go_pos;

	[Token(Token = "0x400AFBB")]
	[FieldOffset(Offset = "0x3C")]
	public uint max_help_per_day;

	[Token(Token = "0x400AFBC")]
	[FieldOffset(Offset = "0x40")]
	public uint warning_storage;

	[Token(Token = "0x400AFBD")]
	[FieldOffset(Offset = "0x44")]
	public string invite_sub_go_pos;

	[Token(Token = "0x400AFBE")]
	[FieldOffset(Offset = "0x48")]
	public string invite_chat_msg_bg;

	[Token(Token = "0x400AFBF")]
	[FieldOffset(Offset = "0x4C")]
	public uint show_process_vfx_amount;

	[Token(Token = "0x400AFC0")]
	[FieldOffset(Offset = "0x50")]
	public float add_token_deliver_time;

	[Token(Token = "0x400AFC1")]
	[FieldOffset(Offset = "0x54")]
	public float add_token_deliver_speed;

	[Token(Token = "0x6008243")]
	[Address(RVA = "0x30A4260", Offset = "0x30A4260", VA = "0x30A4260")]
	public JumpsuitSettingDesc()
	{
	}
}
