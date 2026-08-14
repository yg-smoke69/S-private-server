using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B8A")]
public class FFWSSettingDesc
{
	[Token(Token = "0x400AD29")]
	[FieldOffset(Offset = "0x8")]
	public bool is_guessing_available;

	[Token(Token = "0x400AD2A")]
	[FieldOffset(Offset = "0xC")]
	public uint guessing_activity_start_time;

	[Token(Token = "0x400AD2B")]
	[FieldOffset(Offset = "0x10")]
	public uint guessing_deadline;

	[Token(Token = "0x400AD2C")]
	[FieldOffset(Offset = "0x14")]
	public bool is_live_available;

	[Token(Token = "0x400AD2D")]
	[FieldOffset(Offset = "0x18")]
	public uint live_start_time;

	[Token(Token = "0x400AD2E")]
	[FieldOffset(Offset = "0x1C")]
	public uint live_end_time;

	[Token(Token = "0x400AD2F")]
	[FieldOffset(Offset = "0x20")]
	public string live_url;

	[Token(Token = "0x400AD30")]
	[FieldOffset(Offset = "0x24")]
	public bool is_web_event_available;

	[Token(Token = "0x400AD31")]
	[FieldOffset(Offset = "0x28")]
	public uint web_event_start_time;

	[Token(Token = "0x400AD32")]
	[FieldOffset(Offset = "0x2C")]
	public uint web_event_end_time;

	[Token(Token = "0x400AD33")]
	[FieldOffset(Offset = "0x30")]
	public string web_event_url;

	[Token(Token = "0x400AD34")]
	[FieldOffset(Offset = "0x34")]
	public uint world_progress_start_time;

	[Token(Token = "0x400AD35")]
	[FieldOffset(Offset = "0x38")]
	public bool is_checkin_available;

	[Token(Token = "0x400AD36")]
	[FieldOffset(Offset = "0x3C")]
	public uint extra_reward_box;

	[Token(Token = "0x400AD37")]
	[FieldOffset(Offset = "0x40")]
	public bool is_activity_task_available;

	[Token(Token = "0x400AD38")]
	[FieldOffset(Offset = "0x44")]
	public uint final_team_url_show_start_time;

	[Token(Token = "0x400AD39")]
	[FieldOffset(Offset = "0x48")]
	public uint final_team_url_show_end_time;

	[Token(Token = "0x400AD3A")]
	[FieldOffset(Offset = "0x4C")]
	public string final_team_url;

	[Token(Token = "0x400AD3B")]
	[FieldOffset(Offset = "0x50")]
	public uint champion_url_show_switch_time;

	[Token(Token = "0x400AD3C")]
	[FieldOffset(Offset = "0x54")]
	public string champion_url;

	[Token(Token = "0x400AD3D")]
	[FieldOffset(Offset = "0x58")]
	public uint guessing_activity_end_time;

	[Token(Token = "0x400AD3E")]
	[FieldOffset(Offset = "0x5C")]
	public uint token_id;

	[Token(Token = "0x400AD3F")]
	[FieldOffset(Offset = "0x60")]
	public uint process_max_value;

	[Token(Token = "0x400AD40")]
	[FieldOffset(Offset = "0x64")]
	public bool is_exchange_available;

	[Token(Token = "0x400AD41")]
	[FieldOffset(Offset = "0x65")]
	public bool is_peakday_available;

	[Token(Token = "0x60081E5")]
	[Address(RVA = "0x30A063C", Offset = "0x30A063C", VA = "0x30A063C")]
	public FFWSSettingDesc()
	{
	}
}
