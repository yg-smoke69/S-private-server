using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A2")]
public class CSTeamChampionshipSeasonStatsRes
{
	[Token(Token = "0x4009ADD")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009ADE")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009ADF")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009AE0")]
	[FieldOffset(Offset = "0x18")]
	public ulong[] members;

	[Token(Token = "0x4009AE1")]
	[FieldOffset(Offset = "0x1C")]
	public uint games_played;

	[Token(Token = "0x4009AE2")]
	[FieldOffset(Offset = "0x20")]
	public int max_score;

	[Token(Token = "0x4009AE3")]
	[FieldOffset(Offset = "0x24")]
	public uint wins;

	[Token(Token = "0x4009AE4")]
	[FieldOffset(Offset = "0x28")]
	public uint top_10_percent_times;

	[Token(Token = "0x4009AE5")]
	[FieldOffset(Offset = "0x2C")]
	public uint top_50_percent_times;

	[Token(Token = "0x4009AE6")]
	[FieldOffset(Offset = "0x30")]
	public uint survival_time;

	[Token(Token = "0x4009AE7")]
	[FieldOffset(Offset = "0x34")]
	public uint moving_distance;

	[Token(Token = "0x4009AE8")]
	[FieldOffset(Offset = "0x38")]
	public uint kills;

	[Token(Token = "0x4009AE9")]
	[FieldOffset(Offset = "0x3C")]
	public uint damage;

	[Token(Token = "0x4009AEA")]
	[FieldOffset(Offset = "0x40")]
	public uint one_game_most_kills;

	[Token(Token = "0x4009AEB")]
	[FieldOffset(Offset = "0x44")]
	public uint one_game_most_damage;

	[Token(Token = "0x4009AEC")]
	[FieldOffset(Offset = "0x48")]
	public uint headshot_kills;

	[Token(Token = "0x4009AED")]
	[FieldOffset(Offset = "0x4C")]
	public AccountInfoBasicBundleRes members_info;

	[Token(Token = "0x6007DFC")]
	[Address(RVA = "0x309A15C", Offset = "0x309A15C", VA = "0x309A15C")]
	public CSTeamChampionshipSeasonStatsRes()
	{
	}
}
