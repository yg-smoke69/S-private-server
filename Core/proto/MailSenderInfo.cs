using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001370")]
public class MailSenderInfo
{
	[Token(Token = "0x400895F")]
	[FieldOffset(Offset = "0x8")]
	public ulong sender_id;

	[Token(Token = "0x4008960")]
	[FieldOffset(Offset = "0x10")]
	public string sender_nick;

	[Token(Token = "0x4008961")]
	[FieldOffset(Offset = "0x18")]
	public ulong clan_id;

	[Token(Token = "0x4008962")]
	[FieldOffset(Offset = "0x20")]
	public string clan_name;

	[Token(Token = "0x4008963")]
	[FieldOffset(Offset = "0x28")]
	public ulong clan_captain_id;

	[Token(Token = "0x4008964")]
	[FieldOffset(Offset = "0x30")]
	public string clan_captain_nick;

	[Token(Token = "0x4008965")]
	[FieldOffset(Offset = "0x34")]
	public uint season_id;

	[Token(Token = "0x4008966")]
	[FieldOffset(Offset = "0x38")]
	public uint season_rank;

	[Token(Token = "0x4008967")]
	[FieldOffset(Offset = "0x3C")]
	public uint ep_unlock_id;

	[Token(Token = "0x4008968")]
	[FieldOffset(Offset = "0x40")]
	public uint ep_challenge_id;

	[Token(Token = "0x4008969")]
	[FieldOffset(Offset = "0x44")]
	public string gift_message;

	[Token(Token = "0x400896A")]
	[FieldOffset(Offset = "0x48")]
	public MailGlobalDropInfo global_drop;

	[Token(Token = "0x400896B")]
	[FieldOffset(Offset = "0x4C")]
	public uint honor_delta;

	[Token(Token = "0x400896C")]
	[FieldOffset(Offset = "0x50")]
	public uint subscription_ep_id;

	[Token(Token = "0x400896D")]
	[FieldOffset(Offset = "0x58")]
	public ulong championship_team_id;

	[Token(Token = "0x400896E")]
	[FieldOffset(Offset = "0x60")]
	public string championship_team_name;

	[Token(Token = "0x400896F")]
	[FieldOffset(Offset = "0x64")]
	public uint championship_type;

	[Token(Token = "0x4008970")]
	[FieldOffset(Offset = "0x68")]
	public uint championship_id;

	[Token(Token = "0x4008971")]
	[FieldOffset(Offset = "0x6C")]
	public uint championship_trial_pos;

	[Token(Token = "0x4008972")]
	[FieldOffset(Offset = "0x70")]
	public string region;

	[Token(Token = "0x4008973")]
	[FieldOffset(Offset = "0x74")]
	public string championship_name;

	[Token(Token = "0x4008974")]
	[FieldOffset(Offset = "0x78")]
	public uint limitedevent_leaderboard_type;

	[Token(Token = "0x4008975")]
	[FieldOffset(Offset = "0x7C")]
	public uint limitedevent_rank;

	[Token(Token = "0x4008976")]
	[FieldOffset(Offset = "0x80")]
	public uint rank_master_level;

	[Token(Token = "0x4008977")]
	[FieldOffset(Offset = "0x84")]
	public uint recharge_time;

	[Token(Token = "0x4008978")]
	[FieldOffset(Offset = "0x88")]
	public int recharge_points;

	[Token(Token = "0x4008979")]
	[FieldOffset(Offset = "0x8C")]
	public uint periodic_ranking_game_mode;

	[Token(Token = "0x400897A")]
	[FieldOffset(Offset = "0x90")]
	public uint match_ban_expire_time;

	[Token(Token = "0x6007A71")]
	[Address(RVA = "0x30A756C", Offset = "0x30A756C", VA = "0x30A756C")]
	public MailSenderInfo()
	{
	}
}
