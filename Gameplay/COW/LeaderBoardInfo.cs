using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x20030EF")]
public class LeaderBoardInfo
{
	[Token(Token = "0x40129AA")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40129AB")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40129AC")]
	[FieldOffset(Offset = "0x14")]
	public uint badge_id;

	[Token(Token = "0x40129AD")]
	[FieldOffset(Offset = "0x18")]
	public uint current_rank;

	[Token(Token = "0x40129AE")]
	[FieldOffset(Offset = "0x1C")]
	public uint last_rank;

	[Token(Token = "0x40129AF")]
	[FieldOffset(Offset = "0x20")]
	public float score;

	[Token(Token = "0x40129B0")]
	[FieldOffset(Offset = "0x28")]
	public long play_time;

	[Token(Token = "0x40129B1")]
	[FieldOffset(Offset = "0x30")]
	public uint win_times;

	[Token(Token = "0x40129B2")]
	[FieldOffset(Offset = "0x34")]
	public uint kill_times;

	[Token(Token = "0x40129B3")]
	[FieldOffset(Offset = "0x38")]
	public float win_rating;

	[Token(Token = "0x40129B4")]
	[FieldOffset(Offset = "0x3C")]
	public float kill_rating;

	[Token(Token = "0x40129B5")]
	[FieldOffset(Offset = "0x40")]
	public float kda;

	[Token(Token = "0x40129B6")]
	[FieldOffset(Offset = "0x44")]
	public string portrait;

	[Token(Token = "0x40129B7")]
	[FieldOffset(Offset = "0x48")]
	public uint ladder_rank;

	[Token(Token = "0x40129B8")]
	[FieldOffset(Offset = "0x4C")]
	public uint peak_rank_pos;

	[Token(Token = "0x40129B9")]
	[FieldOffset(Offset = "0x50")]
	public uint ep_Badge_cnt;

	[Token(Token = "0x40129BA")]
	[FieldOffset(Offset = "0x54")]
	public int has_EP;

	[Token(Token = "0x40129BB")]
	[FieldOffset(Offset = "0x58")]
	public string region;

	[Token(Token = "0x40129BC")]
	[FieldOffset(Offset = "0x5C")]
	public uint honor;

	[Token(Token = "0x40129BD")]
	[FieldOffset(Offset = "0x60")]
	public uint clanlevel;

	[Token(Token = "0x40129BE")]
	[FieldOffset(Offset = "0x68")]
	public double leaderboard_score;

	[Token(Token = "0x40129BF")]
	[FieldOffset(Offset = "0x70")]
	public float kill_death_rating;

	[Token(Token = "0x40129C0")]
	[FieldOffset(Offset = "0x74")]
	public uint external_type;

	[Token(Token = "0x40129C1")]
	[FieldOffset(Offset = "0x78")]
	public uint cs_rank;

	[Token(Token = "0x40129C2")]
	[FieldOffset(Offset = "0x7C")]
	public uint cs_rankpoint;

	[Token(Token = "0x40129C3")]
	[FieldOffset(Offset = "0x80")]
	public uint cs_peak_rank_pos;

	[Token(Token = "0x40129C4")]
	[FieldOffset(Offset = "0x84")]
	public uint periodic_rank;

	[Token(Token = "0x40129C5")]
	[FieldOffset(Offset = "0x88")]
	public uint periodic_ranking_points;

	[Token(Token = "0x40129C6")]
	[FieldOffset(Offset = "0x8C")]
	public uint clanArms;

	[Token(Token = "0x40129C7")]
	[FieldOffset(Offset = "0x90")]
	public BaseProfileInfo profile_info;

	[Token(Token = "0x40129C8")]
	[FieldOffset(Offset = "0x94")]
	public TeamLeaderboardProfile team_profile_info;

	[Token(Token = "0x40129C9")]
	[FieldOffset(Offset = "0x98")]
	public ulong limited_event_score;

	[Token(Token = "0x60147FE")]
	[Address(RVA = "0x1EF7CC0", Offset = "0x1EF7CC0", VA = "0x1EF7CC0")]
	public LeaderBoardInfo(FriendAccountInfo info, uint type, bool is_ranking)
	{
	}

	[Token(Token = "0x60147FF")]
	[Address(RVA = "0x1EF81B0", Offset = "0x1EF81B0", VA = "0x1EF81B0")]
	public LeaderBoardInfo(FriendAccountInfo info)
	{
	}

	[Token(Token = "0x6014800")]
	[Address(RVA = "0x1EF83DC", Offset = "0x1EF83DC", VA = "0x1EF83DC")]
	public LeaderBoardInfo()
	{
	}

	[Token(Token = "0x6014801")]
	[Address(RVA = "0x1EF880C", Offset = "0x1EF880C", VA = "0x1EF880C")]
	private static void SetLeaderBoardInfo(LeaderBoardInfo info, AccountLeaderboardItem item)
	{
	}

	[Token(Token = "0x6014802")]
	[Address(RVA = "0x1EF8B30", Offset = "0x1EF8B30", VA = "0x1EF8B30")]
	private static void SetLeaderBoardInfo(LeaderBoardInfo info, ClanLeaderboardItem item)
	{
	}

	[Token(Token = "0x6014803")]
	[Address(RVA = "0x1EF8D30", Offset = "0x1EF8D30", VA = "0x1EF8D30")]
	private static void SetLeaderBoardInfo(LeaderBoardInfo info, TeamLeaderboardItem item)
	{
	}

	[Token(Token = "0x6014804")]
	[Address(RVA = "0x1EF7F34", Offset = "0x1EF7F34", VA = "0x1EF7F34")]
	private static void SetLeaderBoardStatsData(LeaderBoardInfo info, AccountInfoWithStats stat)
	{
	}

	[Token(Token = "0x6014805")]
	[Address(RVA = "0x1EF8E78", Offset = "0x1EF8E78", VA = "0x1EF8E78")]
	public static DetailedTCStats parseDetailTcStats(string detailed_stats)
	{
		return null;
	}

	[Token(Token = "0x6014806")]
	[Address(RVA = "0x1EF9110", Offset = "0x1EF9110", VA = "0x1EF9110")]
	private static DetailStats parseDetailStats(string detailed_stats)
	{
		return null;
	}

	[Token(Token = "0x6014807")]
	[Address(RVA = "0x1EF93A8", Offset = "0x1EF93A8", VA = "0x1EF93A8")]
	public static implicit operator LeaderBoardInfo(AccountLeaderboardItem item)
	{
		return null;
	}

	[Token(Token = "0x6014808")]
	[Address(RVA = "0x1EF9468", Offset = "0x1EF9468", VA = "0x1EF9468")]
	public static implicit operator LeaderBoardInfo(ClanLeaderboardItem item)
	{
		return null;
	}

	[Token(Token = "0x6014809")]
	[Address(RVA = "0x1EF9528", Offset = "0x1EF9528", VA = "0x1EF9528")]
	public static implicit operator LeaderBoardInfo(TeamLeaderboardItem item)
	{
		return null;
	}

	[Token(Token = "0x601480A")]
	[Address(RVA = "0x1EF95E8", Offset = "0x1EF95E8", VA = "0x1EF95E8")]
	public uint GetChampionshipTrailKills()
	{
		return default(uint);
	}
}
