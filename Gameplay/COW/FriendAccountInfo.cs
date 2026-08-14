using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2003038")]
public class FriendAccountInfo : _Attribute
{
	[Token(Token = "0x2003039")]
	private sealed class _003CCompareTo_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012638")]
		[FieldOffset(Offset = "0x8")]
		internal FriendAccountInfo other;

		[Token(Token = "0x4012639")]
		[FieldOffset(Offset = "0xC")]
		internal FriendAccountInfo _0024this;

		[Token(Token = "0x6014317")]
		[Address(RVA = "0xDF1130", Offset = "0xDF1130", VA = "0xDF1130")]
		public _003CCompareTo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014318")]
		[Address(RVA = "0xDF1490", Offset = "0xDF1490", VA = "0xDF1490")]
		internal bool _003C_003Em__0(TeamMemberWithAccountInfo e)
		{
			return default(bool);
		}

		[Token(Token = "0x6014319")]
		[Address(RVA = "0xDF14F8", Offset = "0xDF14F8", VA = "0xDF14F8")]
		internal bool _003C_003Em__1(TeamMemberWithAccountInfo e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40125F6")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<uint, int> AccountPresenceSortOrder;

	[Token(Token = "0x40125F7")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x40125F8")]
	[FieldOffset(Offset = "0x10")]
	public uint account_type;

	[Token(Token = "0x40125F9")]
	[FieldOffset(Offset = "0x14")]
	public string nickname;

	[Token(Token = "0x40125FA")]
	[FieldOffset(Offset = "0x18")]
	public uint level;

	[Token(Token = "0x40125FB")]
	[FieldOffset(Offset = "0x1C")]
	public uint exp;

	[Token(Token = "0x40125FC")]
	[FieldOffset(Offset = "0x20")]
	public EPresence.AccountPresence presence;

	[Token(Token = "0x40125FD")]
	[FieldOffset(Offset = "0x24")]
	public JOKABEAPNPP presenceGameMode;

	[Token(Token = "0x40125FE")]
	[FieldOffset(Offset = "0x28")]
	public DGNDKMLMLPM presenceMatchMode;

	[Token(Token = "0x40125FF")]
	[FieldOffset(Offset = "0x2C")]
	public uint presenceMapID;

	[Token(Token = "0x4012600")]
	[FieldOffset(Offset = "0x30")]
	public string external_id;

	[Token(Token = "0x4012601")]
	[FieldOffset(Offset = "0x38")]
	public ulong external_platform_id;

	[Token(Token = "0x4012602")]
	[FieldOffset(Offset = "0x40")]
	public uint external_type;

	[Token(Token = "0x4012603")]
	[FieldOffset(Offset = "0x48")]
	public long update_time;

	[Token(Token = "0x4012604")]
	[FieldOffset(Offset = "0x50")]
	public EAccountAdscription account_adscription;

	[Token(Token = "0x4012605")]
	[FieldOffset(Offset = "0x54")]
	public string external_name;

	[Token(Token = "0x4012606")]
	[FieldOffset(Offset = "0x58")]
	public string portrait;

	[Token(Token = "0x4012607")]
	[FieldOffset(Offset = "0x5C")]
	public string region;

	[Token(Token = "0x4012608")]
	[FieldOffset(Offset = "0x60")]
	public ulong groupId;

	[Token(Token = "0x4012609")]
	[FieldOffset(Offset = "0x68")]
	public double solo_score;

	[Token(Token = "0x401260A")]
	[FieldOffset(Offset = "0x70")]
	public double duo_score;

	[Token(Token = "0x401260B")]
	[FieldOffset(Offset = "0x78")]
	public double quad_score;

	[Token(Token = "0x401260C")]
	[FieldOffset(Offset = "0x80")]
	public AccountInfoWithStats solo_stats;

	[Token(Token = "0x401260D")]
	[FieldOffset(Offset = "0x84")]
	public AccountInfoWithStats duo_stats;

	[Token(Token = "0x401260E")]
	[FieldOffset(Offset = "0x88")]
	public AccountInfoWithStats quad_stats;

	[Token(Token = "0x401260F")]
	[FieldOffset(Offset = "0x8C")]
	public AccountInfoWithStats solo_stats_ranking;

	[Token(Token = "0x4012610")]
	[FieldOffset(Offset = "0x90")]
	public AccountInfoWithStats duo_stats_ranking;

	[Token(Token = "0x4012611")]
	[FieldOffset(Offset = "0x94")]
	public AccountInfoWithStats quad_stats_ranking;

	[Token(Token = "0x4012612")]
	[FieldOffset(Offset = "0x98")]
	public AccountInfoWithStats solo_stats_casual;

	[Token(Token = "0x4012613")]
	[FieldOffset(Offset = "0x9C")]
	public AccountInfoWithStats duo_stats_casual;

	[Token(Token = "0x4012614")]
	[FieldOffset(Offset = "0xA0")]
	public AccountInfoWithStats quad_stats_casual;

	[Token(Token = "0x4012615")]
	[FieldOffset(Offset = "0xA4")]
	public AccountInfoWithStats cs_stats;

	[Token(Token = "0x4012616")]
	[FieldOffset(Offset = "0xA8")]
	public bool is_friend;

	[Token(Token = "0x4012617")]
	[FieldOffset(Offset = "0xAC")]
	public uint friend_intimacy;

	[Token(Token = "0x4012618")]
	[FieldOffset(Offset = "0xB0")]
	public uint rank;

	[Token(Token = "0x4012619")]
	[FieldOffset(Offset = "0xB4")]
	public uint ranking_points;

	[Token(Token = "0x401261A")]
	[FieldOffset(Offset = "0xB8")]
	public uint peak_rank_pos;

	[Token(Token = "0x401261B")]
	[FieldOffset(Offset = "0xBC")]
	public uint csrank;

	[Token(Token = "0x401261C")]
	[FieldOffset(Offset = "0xC0")]
	public uint csranking_points;

	[Token(Token = "0x401261D")]
	[FieldOffset(Offset = "0xC4")]
	public uint cspeak_rank_pos;

	[Token(Token = "0x401261E")]
	[FieldOffset(Offset = "0xC8")]
	public uint periodic_rank;

	[Token(Token = "0x401261F")]
	[FieldOffset(Offset = "0xCC")]
	public uint periodic_ranking_points;

	[Token(Token = "0x4012620")]
	[FieldOffset(Offset = "0xD0")]
	public string clan_name;

	[Token(Token = "0x4012621")]
	[FieldOffset(Offset = "0xD8")]
	public ulong championship_team_id;

	[Token(Token = "0x4012622")]
	[FieldOffset(Offset = "0xE0")]
	public string championship_team_name;

	[Token(Token = "0x4012623")]
	[FieldOffset(Offset = "0xE4")]
	public uint championship_team_member_num;

	[Token(Token = "0x4012624")]
	[FieldOffset(Offset = "0xE8")]
	public uint banner_id;

	[Token(Token = "0x4012625")]
	[FieldOffset(Offset = "0xEC")]
	public uint headpic_id;

	[Token(Token = "0x4012626")]
	[FieldOffset(Offset = "0xF0")]
	public uint pin_id;

	[Token(Token = "0x4012627")]
	[FieldOffset(Offset = "0xF4")]
	public uint ep_badgeId;

	[Token(Token = "0x4012628")]
	[FieldOffset(Offset = "0xF8")]
	public bool is_ep;

	[Token(Token = "0x4012629")]
	[FieldOffset(Offset = "0xFC")]
	public uint ep_badge_count;

	[Token(Token = "0x401262A")]
	[FieldOffset(Offset = "0x100")]
	public bool ShowRank;

	[Token(Token = "0x401262B")]
	[FieldOffset(Offset = "0x108")]
	public long LastLoginAt;

	[Token(Token = "0x401262C")]
	[FieldOffset(Offset = "0x110")]
	public uint Role;

	[Token(Token = "0x401262D")]
	[FieldOffset(Offset = "0x114")]
	public bool isCommonFriend;

	[Token(Token = "0x401262E")]
	[FieldOffset(Offset = "0x115")]
	public bool isClanmate;

	[Token(Token = "0x401262F")]
	[FieldOffset(Offset = "0x116")]
	public bool isRecentMate;

	[Token(Token = "0x4012630")]
	[FieldOffset(Offset = "0x117")]
	public bool is_cs_ranking_ban;

	[Token(Token = "0x4012631")]
	[FieldOffset(Offset = "0x118")]
	public uint friendNumInSameChampionshipTeam;

	[Token(Token = "0x4012632")]
	[FieldOffset(Offset = "0x120")]
	public long updateTime;

	[Token(Token = "0x4012633")]
	[FieldOffset(Offset = "0x128")]
	public ESocial.Gender gender;

	[Token(Token = "0x4012634")]
	[FieldOffset(Offset = "0x12C")]
	public ESocial.Language language;

	[Token(Token = "0x4012635")]
	[FieldOffset(Offset = "0x130")]
	public ESocial.ModePrefer modePrefer;

	[Token(Token = "0x4012636")]
	[FieldOffset(Offset = "0x134")]
	public ESocial.TimeActive timeActive;

	[Token(Token = "0x4012637")]
	[FieldOffset(Offset = "0x138")]
	public bool isOnlyId;

	[Token(Token = "0x6014309")]
	[Address(RVA = "0xDEF994", Offset = "0xDEF994", VA = "0xDEF994")]
	public FriendAccountInfo()
	{
	}

	[Token(Token = "0x601430A")]
	[Address(RVA = "0xDEFA64", Offset = "0xDEFA64", VA = "0xDEFA64")]
	public FriendAccountInfo(ulong id, bool friend_flag)
	{
	}

	[Token(Token = "0x601430B")]
	[Address(RVA = "0xDEFB54", Offset = "0xDEFB54", VA = "0xDEFB54")]
	public void CopyFromAccountInfoWithPresence(AccountInfoWithPresence info)
	{
	}

	[Token(Token = "0x601430C")]
	[Address(RVA = "0xDEFEBC", Offset = "0xDEFEBC", VA = "0xDEFEBC")]
	private AccountInfoWithStats CreateEmptyAccountInfoStats()
	{
		return null;
	}

	[Token(Token = "0x601430D")]
	[Address(RVA = "0xDEFFDC", Offset = "0xDEFFDC", VA = "0xDEFFDC")]
	public void CopyFromBaseProfileInfo(BaseProfileInfo info)
	{
	}

	[Token(Token = "0x601430E")]
	[Address(RVA = "0xDF0290", Offset = "0xDF0290", VA = "0xDF0290")]
	public void CopyFromAccountInfoBasic(AccountInfoBasic info)
	{
	}

	[Token(Token = "0x601430F")]
	[Address(RVA = "0xDF0664", Offset = "0xDF0664", VA = "0xDF0664")]
	public void CopyFromAccountInfoBase(AccountInfoBasic info)
	{
	}

	[Token(Token = "0x6014310")]
	[Address(RVA = "0xDF083C", Offset = "0xDF083C", VA = "0xDF083C")]
	public void SetSocialInfo(SocialBasicInfo info)
	{
	}

	[Token(Token = "0x6014311")]
	[Address(RVA = "0xDF090C", Offset = "0xDF090C", VA = "0xDF090C", Slot = "4")]
	public int CompareTo(FriendAccountInfo other)
	{
		return default(int);
	}

	[Token(Token = "0x6014312")]
	[Address(RVA = "0xDF1138", Offset = "0xDF1138", VA = "0xDF1138", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6014313")]
	[Address(RVA = "0xDF1250", Offset = "0xDF1250", VA = "0xDF1250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6014315")]
	[Address(RVA = "0xDF1480", Offset = "0xDF1480", VA = "0xDF1480")]
	public bool _003C_003EiFixBaseProxy_Equals(object P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6014316")]
	[Address(RVA = "0xDF1488", Offset = "0xDF1488", VA = "0xDF1488")]
	public int _003C_003EiFixBaseProxy_GetHashCode()
	{
		return default(int);
	}
}
