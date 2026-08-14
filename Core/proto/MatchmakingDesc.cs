using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019DC")]
public class MatchmakingDesc
{
	[Token(Token = "0x400A235")]
	[FieldOffset(Offset = "0x8")]
	public uint matchmaking_time;

	[Token(Token = "0x400A236")]
	[FieldOffset(Offset = "0xC")]
	public uint wait_join_time;

	[Token(Token = "0x400A237")]
	[FieldOffset(Offset = "0x10")]
	public uint wait_protect_time;

	[Token(Token = "0x400A238")]
	[FieldOffset(Offset = "0x14")]
	public uint login_gameserver_timeout;

	[Token(Token = "0x400A239")]
	[FieldOffset(Offset = "0x18")]
	public uint room_destroy_time;

	[Token(Token = "0x400A23A")]
	[FieldOffset(Offset = "0x1C")]
	public uint sleep_ms;

	[Token(Token = "0x400A23B")]
	[FieldOffset(Offset = "0x20")]
	public bool ingame_reconnection;

	[Token(Token = "0x400A23C")]
	[FieldOffset(Offset = "0x24")]
	public uint keep_reconnection_time_second;

	[Token(Token = "0x400A23D")]
	[FieldOffset(Offset = "0x28")]
	public uint bot_mmr_type;

	[Token(Token = "0x400A23E")]
	[FieldOffset(Offset = "0x2C")]
	public uint ranking_bot_mmr_type;

	[Token(Token = "0x400A23F")]
	[FieldOffset(Offset = "0x30")]
	public uint room_wait_start_timeout;

	[Token(Token = "0x400A240")]
	[FieldOffset(Offset = "0x34")]
	public bool inroom_reconnection;

	[Token(Token = "0x400A241")]
	[FieldOffset(Offset = "0x38")]
	public uint inroom_reconnection_time_second;

	[Token(Token = "0x400A242")]
	[FieldOffset(Offset = "0x3C")]
	public uint idc_timeout;

	[Token(Token = "0x400A243")]
	[FieldOffset(Offset = "0x40")]
	public uint[] hackers_pool_effect_mode;

	[Token(Token = "0x400A244")]
	[FieldOffset(Offset = "0x44")]
	public bool room_enable_emulator_check;

	[Token(Token = "0x400A245")]
	[FieldOffset(Offset = "0x48")]
	public uint room_limit_score;

	[Token(Token = "0x400A246")]
	[FieldOffset(Offset = "0x4C")]
	public bool disable_mm7;

	[Token(Token = "0x400A247")]
	[FieldOffset(Offset = "0x4D")]
	public bool loading_reconnection;

	[Token(Token = "0x400A248")]
	[FieldOffset(Offset = "0x50")]
	public uint mass_group_destory_time;

	[Token(Token = "0x400A249")]
	[FieldOffset(Offset = "0x54")]
	public uint waiting_gs_ready_timeout;

	[Token(Token = "0x400A24A")]
	[FieldOffset(Offset = "0x58")]
	public uint scan_interval;

	[Token(Token = "0x400A24B")]
	[FieldOffset(Offset = "0x5C")]
	public uint bot_scan_interval;

	[Token(Token = "0x400A24C")]
	[FieldOffset(Offset = "0x60")]
	public uint bot_open_uid;

	[Token(Token = "0x6008034")]
	[Address(RVA = "0x30A8584", Offset = "0x30A8584", VA = "0x30A8584")]
	public MatchmakingDesc()
	{
	}
}
