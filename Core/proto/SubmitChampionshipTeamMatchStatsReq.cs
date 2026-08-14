using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B5")]
public class SubmitChampionshipTeamMatchStatsReq
{
	[Token(Token = "0x4009B2F")]
	[FieldOffset(Offset = "0x8")]
	public ulong match_id;

	[Token(Token = "0x4009B30")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B31")]
	[FieldOffset(Offset = "0x14")]
	public uint team_count;

	[Token(Token = "0x4009B32")]
	[FieldOffset(Offset = "0x18")]
	public TeamMatchStats team_stats;

	[Token(Token = "0x4009B33")]
	[FieldOffset(Offset = "0x1C")]
	public uint create_time;

	[Token(Token = "0x4009B34")]
	[FieldOffset(Offset = "0x20")]
	public uint end_time;

	[Token(Token = "0x4009B35")]
	[FieldOffset(Offset = "0x24")]
	public string noti_region;

	[Token(Token = "0x4009B36")]
	[FieldOffset(Offset = "0x28")]
	public string lock_region;

	[Token(Token = "0x4009B37")]
	[FieldOffset(Offset = "0x2C")]
	public bool is_fake;

	[Token(Token = "0x6007E0F")]
	[Address(RVA = "0x33E2A88", Offset = "0x33E2A88", VA = "0x33E2A88")]
	public SubmitChampionshipTeamMatchStatsReq()
	{
	}
}
