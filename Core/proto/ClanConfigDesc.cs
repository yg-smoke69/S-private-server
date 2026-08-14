using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A21")]
public class ClanConfigDesc
{
	[Token(Token = "0x400A3BB")]
	[FieldOffset(Offset = "0x8")]
	public uint clan_max_pending_applications;

	[Token(Token = "0x400A3BC")]
	[FieldOffset(Offset = "0xC")]
	public uint player_max_requests_per_day;

	[Token(Token = "0x400A3BD")]
	[FieldOffset(Offset = "0x10")]
	public uint max_invite_num;

	[Token(Token = "0x400A3BE")]
	[FieldOffset(Offset = "0x14")]
	public uint join_days_before_sign_in;

	[Token(Token = "0x400A3BF")]
	[FieldOffset(Offset = "0x18")]
	public uint clan_log_time_max;

	[Token(Token = "0x400A3C0")]
	[FieldOffset(Offset = "0x1C")]
	public uint clan_log_cnt_max;

	[Token(Token = "0x400A3C1")]
	[FieldOffset(Offset = "0x20")]
	public uint[] clan_preset_level;

	[Token(Token = "0x400A3C2")]
	[FieldOffset(Offset = "0x24")]
	public uint[] clan_preset_rank;

	[Token(Token = "0x400A3C3")]
	[FieldOffset(Offset = "0x28")]
	public uint join_days_before_apply_for_deputy;

	[Token(Token = "0x400A3C4")]
	[FieldOffset(Offset = "0x2C")]
	public uint captain_offline_days;

	[Token(Token = "0x400A3C5")]
	[FieldOffset(Offset = "0x30")]
	public uint deputy_offline_days;

	[Token(Token = "0x400A3C6")]
	[FieldOffset(Offset = "0x34")]
	public uint[] clan_preset_cs_rank;

	[Token(Token = "0x6008079")]
	[Address(RVA = "0x309B848", Offset = "0x309B848", VA = "0x309B848")]
	public ClanConfigDesc()
	{
	}
}
