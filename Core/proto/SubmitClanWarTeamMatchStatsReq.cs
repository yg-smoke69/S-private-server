using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001662")]
public class SubmitClanWarTeamMatchStatsReq
{
	[Token(Token = "0x4009611")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x4009612")]
	[FieldOffset(Offset = "0x10")]
	public string lock_region;

	[Token(Token = "0x4009613")]
	[FieldOffset(Offset = "0x14")]
	public string noti_region;

	[Token(Token = "0x4009614")]
	[FieldOffset(Offset = "0x18")]
	public ClanWarTeamMatchStats clan_war_match_stats;

	[Token(Token = "0x6007CAC")]
	[Address(RVA = "0x33E2B34", Offset = "0x33E2B34", VA = "0x33E2B34")]
	public SubmitClanWarTeamMatchStatsReq()
	{
	}
}
