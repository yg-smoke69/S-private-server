using System;
using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2003263")]
internal class UIModelSpectator : UIBaseModel
{
	[Token(Token = "0x2003264")]
	public enum InfoTab
	{
		[Token(Token = "0x40132FC")]
		Player,
		[Token(Token = "0x40132FD")]
		AirDrop
	}

	[Token(Token = "0x2003265")]
	public class TeamWinInfo
	{
		[Token(Token = "0x40132FE")]
		[FieldOffset(Offset = "0x8")]
		public byte teamID;

		[Token(Token = "0x40132FF")]
		[FieldOffset(Offset = "0x9")]
		public byte winReason;

		[Token(Token = "0x601543F")]
		[Address(RVA = "0x168A9E8", Offset = "0x168A9E8", VA = "0x168A9E8")]
		public TeamWinInfo(byte teamID, byte winReason)
		{
		}
	}

	[Token(Token = "0x2003266")]
	private sealed class _003CGetTeamKillCount_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013300")]
		[FieldOffset(Offset = "0x8")]
		internal PlayerData data;

		[Token(Token = "0x6015440")]
		[Address(RVA = "0x168A7DC", Offset = "0x168A7DC", VA = "0x168A7DC")]
		public _003CGetTeamKillCount_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015441")]
		[Address(RVA = "0x168A7E4", Offset = "0x168A7E4", VA = "0x168A7E4")]
		internal bool _003C_003Em__0(RankingTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003267")]
	private sealed class _003CGetTeamKillCount_003Ec__AnonStorey1
	{
		[Token(Token = "0x4013301")]
		[FieldOffset(Offset = "0x8")]
		internal AccTeamData team;

		[Token(Token = "0x6015442")]
		[Address(RVA = "0x168A830", Offset = "0x168A830", VA = "0x168A830")]
		public _003CGetTeamKillCount_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6015443")]
		[Address(RVA = "0x168A838", Offset = "0x168A838", VA = "0x168A838")]
		internal bool _003C_003Em__0(RankingTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003268")]
	private sealed class _003CGenerateResult_003Ec__AnonStorey2
	{
		[Token(Token = "0x4013302")]
		[FieldOffset(Offset = "0x8")]
		internal PlayerData data;

		[Token(Token = "0x6015444")]
		[Address(RVA = "0x168A6A4", Offset = "0x168A6A4", VA = "0x168A6A4")]
		public _003CGenerateResult_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6015445")]
		[Address(RVA = "0x168A6AC", Offset = "0x168A6AC", VA = "0x168A6AC")]
		internal bool _003C_003Em__0(ResultTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003269")]
	private sealed class _003CGenerateTeamWinNum_003Ec__AnonStorey3
	{
		[Token(Token = "0x4013303")]
		[FieldOffset(Offset = "0x8")]
		internal int i;

		[Token(Token = "0x4013304")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelSpectator _0024this;

		[Token(Token = "0x6015446")]
		[Address(RVA = "0x168A6F8", Offset = "0x168A6F8", VA = "0x168A6F8")]
		public _003CGenerateTeamWinNum_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6015447")]
		[Address(RVA = "0x168A700", Offset = "0x168A700", VA = "0x168A700")]
		internal bool _003C_003Em__0(ResultTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200326A")]
	private sealed class _003COnTeamScoreInited_003Ec__AnonStorey4
	{
		[Token(Token = "0x4013305")]
		[FieldOffset(Offset = "0x8")]
		internal AccTeamData data;

		[Token(Token = "0x6015448")]
		[Address(RVA = "0x168A8D8", Offset = "0x168A8D8", VA = "0x168A8D8")]
		public _003COnTeamScoreInited_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6015449")]
		[Address(RVA = "0x168A8E0", Offset = "0x168A8E0", VA = "0x168A8E0")]
		internal bool _003C_003Em__0(RankingTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200326B")]
	private sealed class _003COnTeamScoreChanged_003Ec__AnonStorey5
	{
		[Token(Token = "0x4013306")]
		[FieldOffset(Offset = "0x8")]
		internal JOCPLNGCKMO team;

		[Token(Token = "0x601544A")]
		[Address(RVA = "0x168A884", Offset = "0x168A884", VA = "0x168A884")]
		public _003COnTeamScoreChanged_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601544B")]
		[Address(RVA = "0x168A88C", Offset = "0x168A88C", VA = "0x168A88C")]
		internal bool _003C_003Em__0(AccTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200326C")]
	private sealed class _003CUpdateCombatLevelInfo_003Ec__AnonStorey6
	{
		[Token(Token = "0x4013307")]
		[FieldOffset(Offset = "0x8")]
		internal LHAFKMCMAAF teams;

		[Token(Token = "0x601544C")]
		[Address(RVA = "0x168A92C", Offset = "0x168A92C", VA = "0x168A92C")]
		public _003CUpdateCombatLevelInfo_003Ec__AnonStorey6()
		{
		}
	}

	[Token(Token = "0x200326D")]
	private sealed class _003CUpdateCombatLevelInfo_003Ec__AnonStorey7
	{
		[Token(Token = "0x4013308")]
		[FieldOffset(Offset = "0x8")]
		internal TeamData team;

		[Token(Token = "0x4013309")]
		[FieldOffset(Offset = "0xC")]
		internal _003CUpdateCombatLevelInfo_003Ec__AnonStorey6 _003C_003Ef__ref_00246;

		[Token(Token = "0x601544D")]
		[Address(RVA = "0x168A934", Offset = "0x168A934", VA = "0x168A934")]
		public _003CUpdateCombatLevelInfo_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x601544E")]
		[Address(RVA = "0x168A93C", Offset = "0x168A93C", VA = "0x168A93C")]
		internal bool _003C_003Em__0(TeamData a)
		{
			return default(bool);
		}

		[Token(Token = "0x601544F")]
		[Address(RVA = "0x168A99C", Offset = "0x168A99C", VA = "0x168A99C")]
		internal bool _003C_003Em__1(RankingTeamData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40132C3")]
	[FieldOffset(Offset = "0xC")]
	private InfoTab _003CCurrentInfoTab_003Ek__BackingField;

	[Token(Token = "0x40132C4")]
	[FieldOffset(Offset = "0x10")]
	private List<byte> m_TeamList;

	[Token(Token = "0x40132C5")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<byte, List<PlayerData>> m_TeamPlayerDic;

	[Token(Token = "0x40132C6")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<IHAAMHPPLMG, PlayerData> m_PlayerDic;

	[Token(Token = "0x40132C7")]
	[FieldOffset(Offset = "0x1C")]
	private List<TeamData> m_TeamDataList;

	[Token(Token = "0x40132C8")]
	[FieldOffset(Offset = "0x20")]
	private List<RankingTeamData> m_RankingTeamDataList;

	[Token(Token = "0x40132C9")]
	[FieldOffset(Offset = "0x24")]
	private List<AccTeamData> m_AccTeamDataList;

	[Token(Token = "0x40132CA")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<int, TeamWinInfo> m_RoundResult;

	[Token(Token = "0x40132CB")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<IHAAMHPPLMG, List<PlayerKillInfo>> m_PlayerKillInfoList;

	[Token(Token = "0x40132CC")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<IHAAMHPPLMG, List<PlayerBestStatsData>> m_PlayerOutStandingStats;

	[Token(Token = "0x40132CD")]
	public const uint PropID_PlayerAdded = 2u;

	[Token(Token = "0x40132CE")]
	public const uint PropID_AirDropChanged = 4u;

	[Token(Token = "0x40132CF")]
	public const uint PropID_PlayerDeleted = 8u;

	[Token(Token = "0x40132D0")]
	public const uint PropID_PlayerKillCountChanged = 16u;

	[Token(Token = "0x40132D1")]
	public const uint PropID_PlayerRemainingCountChanged = 32u;

	[Token(Token = "0x40132D2")]
	public const uint PropID_SpectatorRejoin = 128u;

	[Token(Token = "0x40132D3")]
	public const uint PropID_SafeZoneChanged = 256u;

	[Token(Token = "0x40132D4")]
	public const uint PropID_TeamAce = 512u;

	[Token(Token = "0x40132D5")]
	public const uint PropID_GameAchievement = 1024u;

	[Token(Token = "0x40132D6")]
	public const uint PropID_ScoreChanged = 2048u;

	[Token(Token = "0x40132D7")]
	public const uint PropID_PlayerRankGet = 4096u;

	[Token(Token = "0x40132D8")]
	public const uint PropID_CombatLevelUpdated = 8192u;

	[Token(Token = "0x40132D9")]
	public const uint PropID_PlayerDeadCountChanged = 16384u;

	[Token(Token = "0x40132DA")]
	public const uint PropID_PlayerAssistCountChanged = 32768u;

	[Token(Token = "0x40132DB")]
	public const uint PropID_LiveCountChanged = 65536u;

	[Token(Token = "0x40132DC")]
	public const uint PropID_ReviveChanged = 131072u;

	[Token(Token = "0x40132DD")]
	[FieldOffset(Offset = "0x34")]
	public bool HasPlayerDead;

	[Token(Token = "0x40132DE")]
	[FieldOffset(Offset = "0x38")]
	public List<Transform> ResultShowPositionList;

	[Token(Token = "0x40132DF")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, AirdropInfo> m_Airdrops;

	[Token(Token = "0x40132E0")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<uint, Vector3> m_AirdopsPos;

	[Token(Token = "0x40132E1")]
	[FieldOffset(Offset = "0x44")]
	public List<AirdropInfo> m_AirDropsList;

	[Token(Token = "0x40132E2")]
	[FieldOffset(Offset = "0x48")]
	private List<PlayerData> m_DeadOrderList;

	[Token(Token = "0x40132E3")]
	[FieldOffset(Offset = "0x4C")]
	private List<ResultTeamData> m_MatchResult;

	[Token(Token = "0x40132E4")]
	[FieldOffset(Offset = "0x50")]
	private ResultMVPInfo m_MVPInfo;

	[Token(Token = "0x40132E5")]
	[FieldOffset(Offset = "0x54")]
	private int m_RemainingPlayerCount;

	[Token(Token = "0x40132E6")]
	[FieldOffset(Offset = "0x58")]
	private bool _003CGroupIconEnabled_003Ek__BackingField;

	[Token(Token = "0x40132E7")]
	[FieldOffset(Offset = "0x60")]
	private IHAAMHPPLMG m_currentKillLeaderPlayerID;

	[Token(Token = "0x40132E8")]
	[FieldOffset(Offset = "0x78")]
	private IHAAMHPPLMG _003CCurrentKillLeaderPlayerID_003Ek__BackingField;

	[Token(Token = "0x40132E9")]
	[FieldOffset(Offset = "0x90")]
	public float UI_PLAYER_ITEM_HEIGHT;

	[Token(Token = "0x40132EA")]
	[FieldOffset(Offset = "0x94")]
	private List<IHAAMHPPLMG> m_KingOfKiller_Player;

	[Token(Token = "0x40132EB")]
	[FieldOffset(Offset = "0x98")]
	private byte m_KingOfKiller_Team;

	[Token(Token = "0x40132EC")]
	[FieldOffset(Offset = "0x9C")]
	private float m_BattleCheckedTime;

	[Token(Token = "0x40132ED")]
	[FieldOffset(Offset = "0xA0")]
	private HashSet<byte> m_InBattleTeams;

	[Token(Token = "0x40132EE")]
	[FieldOffset(Offset = "0xA4")]
	private List<ReplayEvent> m_ReplayEventList;

	[Token(Token = "0x40132EF")]
	[FieldOffset(Offset = "0xA8")]
	private BitArrayBoolean m_InputBlock;

	[Token(Token = "0x40132F0")]
	public const uint INPUT_BLCOK_VIDEO_UI_FOUCUSED = 1u;

	[Token(Token = "0x40132F1")]
	public const uint INPUT_BLOCK_CHAT = 2u;

	[Token(Token = "0x40132F2")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PlayerData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40132F3")]
	[FieldOffset(Offset = "0x4")]
	private static Func<TeamData, byte> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40132F4")]
	[FieldOffset(Offset = "0x8")]
	private static Comparison<PlayerData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40132F5")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<ResultTeamData> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40132F6")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<ResultTeamData> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40132F7")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<ResultPlayerData> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40132F8")]
	[FieldOffset(Offset = "0x18")]
	private static Comparison<AccTeamData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x40132F9")]
	[FieldOffset(Offset = "0x1C")]
	private static Comparison<RankingTeamData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x40132FA")]
	[FieldOffset(Offset = "0x20")]
	private static Comparison<RankingTeamData> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x1700165C")]
	public InfoTab CurrentInfoTab
	{
		[Token(Token = "0x60153D8")]
		[Address(RVA = "0x30F3F64", Offset = "0x30F3F64", VA = "0x30F3F64")]
		get
		{
			return default(InfoTab);
		}
		[Token(Token = "0x60153D9")]
		[Address(RVA = "0x30F3F6C", Offset = "0x30F3F6C", VA = "0x30F3F6C")]
		set
		{
		}
	}

	[Token(Token = "0x1700165D")]
	public List<byte> TeamList
	{
		[Token(Token = "0x60153DA")]
		[Address(RVA = "0x30F3F74", Offset = "0x30F3F74", VA = "0x30F3F74")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700165E")]
	public Dictionary<IHAAMHPPLMG, PlayerData> PlayerDic
	{
		[Token(Token = "0x60153DB")]
		[Address(RVA = "0x30F3FCC", Offset = "0x30F3FCC", VA = "0x30F3FCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700165F")]
	public List<TeamData> TeamDataList
	{
		[Token(Token = "0x60153DC")]
		[Address(RVA = "0x30F4024", Offset = "0x30F4024", VA = "0x30F4024")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001660")]
	public List<RankingTeamData> RankingTeamDataListByLiving
	{
		[Token(Token = "0x60153DD")]
		[Address(RVA = "0x30F407C", Offset = "0x30F407C", VA = "0x30F407C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001661")]
	public List<RankingTeamData> RankingTeamDataByCombatLevel
	{
		[Token(Token = "0x60153DE")]
		[Address(RVA = "0x30F4228", Offset = "0x30F4228", VA = "0x30F4228")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001662")]
	public List<AccTeamData> AccTeamDataList
	{
		[Token(Token = "0x60153DF")]
		[Address(RVA = "0x30F43D4", Offset = "0x30F43D4", VA = "0x30F43D4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001663")]
	public Dictionary<int, TeamWinInfo> RoundResult
	{
		[Token(Token = "0x60153E0")]
		[Address(RVA = "0x30F442C", Offset = "0x30F442C", VA = "0x30F442C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001664")]
	public Dictionary<uint, AirdropInfo> Airdrops
	{
		[Token(Token = "0x60153E5")]
		[Address(RVA = "0x30F4BD0", Offset = "0x30F4BD0", VA = "0x30F4BD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001665")]
	public List<AirdropInfo> AirdropsList
	{
		[Token(Token = "0x60153E6")]
		[Address(RVA = "0x30F4C28", Offset = "0x30F4C28", VA = "0x30F4C28")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001666")]
	public List<ResultTeamData> MatchResult
	{
		[Token(Token = "0x60153E7")]
		[Address(RVA = "0x30F4C80", Offset = "0x30F4C80", VA = "0x30F4C80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001667")]
	public int RemainPlayer
	{
		[Token(Token = "0x60153E8")]
		[Address(RVA = "0x30F4CD8", Offset = "0x30F4CD8", VA = "0x30F4CD8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001668")]
	public bool GroupIconEnabled
	{
		[Token(Token = "0x60153E9")]
		[Address(RVA = "0x30F4D30", Offset = "0x30F4D30", VA = "0x30F4D30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60153EA")]
		[Address(RVA = "0x30F4D38", Offset = "0x30F4D38", VA = "0x30F4D38")]
		set
		{
		}
	}

	[Token(Token = "0x17001669")]
	public IHAAMHPPLMG CurrentKillLeaderPlayerID
	{
		[Token(Token = "0x60153EB")]
		[Address(RVA = "0x30F4D40", Offset = "0x30F4D40", VA = "0x30F4D40")]
		get
		{
			return default(IHAAMHPPLMG);
		}
		[Token(Token = "0x60153EC")]
		[Address(RVA = "0x30F4D58", Offset = "0x30F4D58", VA = "0x30F4D58")]
		set
		{
		}
	}

	[Token(Token = "0x1700166A")]
	public List<IHAAMHPPLMG> KingOfKiller_Player
	{
		[Token(Token = "0x601540C")]
		[Address(RVA = "0x30F9CD4", Offset = "0x30F9CD4", VA = "0x30F9CD4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700166B")]
	public byte KingOfKiller_Team
	{
		[Token(Token = "0x601540D")]
		[Address(RVA = "0x30F9D2C", Offset = "0x30F9D2C", VA = "0x30F9D2C")]
		get
		{
			return default(byte);
		}
	}

	[Token(Token = "0x60153D7")]
	[Address(RVA = "0x30F3B40", Offset = "0x30F3B40", VA = "0x30F3B40")]
	public UIModelSpectator()
	{
	}

	[Token(Token = "0x60153E1")]
	[Address(RVA = "0x30F4484", Offset = "0x30F4484", VA = "0x30F4484")]
	public void AddRoundResult(int round, byte winTeamId, byte winReason)
	{
	}

	[Token(Token = "0x60153E2")]
	[Address(RVA = "0x30F4648", Offset = "0x30F4648", VA = "0x30F4648")]
	public List<PlayerKillInfo> GetPlayerKillInfo(IHAAMHPPLMG id)
	{
		return null;
	}

	[Token(Token = "0x60153E3")]
	[Address(RVA = "0x30F47AC", Offset = "0x30F47AC", VA = "0x30F47AC")]
	public List<PlayerBestStatsData> GetPlayerOutStandingStats(IHAAMHPPLMG pId)
	{
		return null;
	}

	[Token(Token = "0x60153E4")]
	[Address(RVA = "0x30F4910", Offset = "0x30F4910", VA = "0x30F4910")]
	public void SetPlayerOutStandingStats(IHAAMHPPLMG pId, List<FFICCMDPDOA> gsStats)
	{
	}

	[Token(Token = "0x60153ED")]
	[Address(RVA = "0x30F4D8C", Offset = "0x30F4D8C", VA = "0x30F4D8C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60153EE")]
	[Address(RVA = "0x30F4DE4", Offset = "0x30F4DE4", VA = "0x30F4DE4")]
	public void StartMatch()
	{
	}

	[Token(Token = "0x60153EF")]
	[Address(RVA = "0x30F5100", Offset = "0x30F5100", VA = "0x30F5100")]
	public void OnAddPlayer(Player player)
	{
	}

	[Token(Token = "0x60153F0")]
	[Address(RVA = "0x30F6058", Offset = "0x30F6058", VA = "0x30F6058")]
	public void OnDelPlayer(IHAAMHPPLMG id, IHAAMHPPLMG killerId, Vector3 last_position, Vector3 last_forward)
	{
	}

	[Token(Token = "0x60153F1")]
	[Address(RVA = "0x30F6348", Offset = "0x30F6348", VA = "0x30F6348")]
	public void UpdateReviveInfo()
	{
	}

	[Token(Token = "0x60153F2")]
	[Address(RVA = "0x30F6410", Offset = "0x30F6410", VA = "0x30F6410")]
	public void OnHandlePlayerKillInfo(IHAAMHPPLMG bekillid, IHAAMHPPLMG damager, int weaponID)
	{
	}

	[Token(Token = "0x60153F3")]
	[Address(RVA = "0x30F5E90", Offset = "0x30F5E90", VA = "0x30F5E90")]
	public void SortTeams()
	{
	}

	[Token(Token = "0x60153F4")]
	[Address(RVA = "0x30F67A8", Offset = "0x30F67A8", VA = "0x30F67A8")]
	private bool IsTeamDead(TeamData team)
	{
		return default(bool);
	}

	[Token(Token = "0x60153F5")]
	[Address(RVA = "0x30F6978", Offset = "0x30F6978", VA = "0x30F6978")]
	public void OnAlivePlayerCountChanged(int remainingPlayers)
	{
	}

	[Token(Token = "0x60153F6")]
	[Address(RVA = "0x30F6A4C", Offset = "0x30F6A4C", VA = "0x30F6A4C")]
	public void OnUpdatePlayerKillCount(IHAAMHPPLMG id, byte oldValue, byte newValue)
	{
	}

	[Token(Token = "0x60153F7")]
	[Address(RVA = "0x30F6C7C", Offset = "0x30F6C7C", VA = "0x30F6C7C")]
	public void OnUpdatePlayerDeadCount(IHAAMHPPLMG id, byte oldValue, byte newValue)
	{
	}

	[Token(Token = "0x60153F8")]
	[Address(RVA = "0x30F6EFC", Offset = "0x30F6EFC", VA = "0x30F6EFC")]
	public void OnUpdatePlayerAssistCount(IHAAMHPPLMG id, byte oldValue, byte newValue)
	{
	}

	[Token(Token = "0x60153F9")]
	[Address(RVA = "0x30F717C", Offset = "0x30F717C", VA = "0x30F717C")]
	public void OnUpdatePlayerTotalDamage(IHAAMHPPLMG id, uint oldValue, uint newValue)
	{
	}

	[Token(Token = "0x60153FA")]
	[Address(RVA = "0x30F7320", Offset = "0x30F7320", VA = "0x30F7320")]
	public void OnUpdatePlayerFactionID(IHAAMHPPLMG id, int factionID)
	{
	}

	[Token(Token = "0x60153FB")]
	[Address(RVA = "0x30F74BC", Offset = "0x30F74BC", VA = "0x30F74BC")]
	public void OnUpdateTeamWinNum(byte teamID, uint newValue)
	{
	}

	[Token(Token = "0x60153FC")]
	[Address(RVA = "0x30F7648", Offset = "0x30F7648", VA = "0x30F7648")]
	public void OnUpdateTeamWinNum(IHAAMHPPLMG id, ushort newValue)
	{
	}

	[Token(Token = "0x60153FD")]
	[Address(RVA = "0x30F78D4", Offset = "0x30F78D4", VA = "0x30F78D4")]
	public Player GetNextLivePlayer(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x60153FE")]
	[Address(RVA = "0x30F7E58", Offset = "0x30F7E58", VA = "0x30F7E58")]
	public Player GetPrevLivePlayer(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x60153FF")]
	[Address(RVA = "0x30F83F0", Offset = "0x30F83F0", VA = "0x30F83F0")]
	public Player GetTeamNextLivePlayer(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x6015400")]
	[Address(RVA = "0x30F8750", Offset = "0x30F8750", VA = "0x30F8750")]
	public Player GetTeamPrevLivePlayer(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x6015401")]
	[Address(RVA = "0x30F8AC8", Offset = "0x30F8AC8", VA = "0x30F8AC8")]
	public Player GetNextTeamLivePlayer(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x6015402")]
	[Address(RVA = "0x30F8E30", Offset = "0x30F8E30", VA = "0x30F8E30")]
	public Player GetPrevTeamLivePlayer(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x6015403")]
	[Address(RVA = "0x30F9194", Offset = "0x30F9194", VA = "0x30F9194")]
	public Player GetRandomPlayer()
	{
		return null;
	}

	[Token(Token = "0x6015404")]
	[Address(RVA = "0x30F93E0", Offset = "0x30F93E0", VA = "0x30F93E0")]
	public Player GetFirtstLivePlayerByTeamId(int teamId)
	{
		return null;
	}

	[Token(Token = "0x6015405")]
	[Address(RVA = "0x30F955C", Offset = "0x30F955C", VA = "0x30F955C")]
	public List<PlayerData> GetPlayerListFromTeamId(byte team)
	{
		return null;
	}

	[Token(Token = "0x6015406")]
	[Address(RVA = "0x30F5C50", Offset = "0x30F5C50", VA = "0x30F5C50")]
	public PlayerData GetPlayerData(IHAAMHPPLMG id)
	{
		return null;
	}

	[Token(Token = "0x6015407")]
	[Address(RVA = "0x30F964C", Offset = "0x30F964C", VA = "0x30F964C")]
	public PlayerData GetPlayerDataByUserId(ulong userId)
	{
		return null;
	}

	[Token(Token = "0x6015408")]
	[Address(RVA = "0x30F9854", Offset = "0x30F9854", VA = "0x30F9854")]
	public bool IsCSTeamOnLeft(IHAAMHPPLMG id)
	{
		return default(bool);
	}

	[Token(Token = "0x6015409")]
	[Address(RVA = "0x30F9924", Offset = "0x30F9924", VA = "0x30F9924")]
	public int GetPlayerCount()
	{
		return default(int);
	}

	[Token(Token = "0x601540A")]
	[Address(RVA = "0x30F99E4", Offset = "0x30F99E4", VA = "0x30F99E4")]
	public uint GetTeamKillCount(IHAAMHPPLMG player)
	{
		return default(uint);
	}

	[Token(Token = "0x601540B")]
	[Address(RVA = "0x30F9B84", Offset = "0x30F9B84", VA = "0x30F9B84")]
	public uint GetTeamKillCount(AccTeamData team)
	{
		return default(uint);
	}

	[Token(Token = "0x601540E")]
	[Address(RVA = "0x30F9D84", Offset = "0x30F9D84", VA = "0x30F9D84")]
	public void OnGameAchievementNotify(IHAAMHPPLMG killerId, IHAAMHPPLMG beKilledId, int weaponDataId, List<ABDONPHCKLK> type)
	{
	}

	[Token(Token = "0x601540F")]
	[Address(RVA = "0x30FA920", Offset = "0x30FA920", VA = "0x30FA920")]
	public bool IsKingofKillPlayer(IHAAMHPPLMG pid)
	{
		return default(bool);
	}

	[Token(Token = "0x6015410")]
	[Address(RVA = "0x30FAB14", Offset = "0x30FAB14", VA = "0x30FAB14")]
	public void OnAddRejoinDeadPlayer(List<AADOBBJPEMN> deadPlayerInfos)
	{
	}

	[Token(Token = "0x6015411")]
	[Address(RVA = "0x30FBBF0", Offset = "0x30FBBF0", VA = "0x30FBBF0")]
	public void AddPickup(uint objID, MNGBAPBBJDC pickup, Vector3 position)
	{
	}

	[Token(Token = "0x6015412")]
	[Address(RVA = "0x30FC07C", Offset = "0x30FC07C", VA = "0x30FC07C")]
	public void DelPickup(uint objID, MNGBAPBBJDC pickup)
	{
	}

	[Token(Token = "0x6015413")]
	[Address(RVA = "0x30FC210", Offset = "0x30FC210", VA = "0x30FC210")]
	public Vector3 GetPickupPositionByIndex(int index)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6015414")]
	[Address(RVA = "0x30FC318", Offset = "0x30FC318", VA = "0x30FC318")]
	public int GetPickupCount()
	{
		return default(int);
	}

	[Token(Token = "0x6015415")]
	[Address(RVA = "0x30FC3D8", Offset = "0x30FC3D8", VA = "0x30FC3D8")]
	public int GetRandomPickupIndex()
	{
		return default(int);
	}

	[Token(Token = "0x6015416")]
	[Address(RVA = "0x30FC4A8", Offset = "0x30FC4A8", VA = "0x30FC4A8")]
	public void AddAirdrop(uint objID, Vector3 position)
	{
	}

	[Token(Token = "0x6015417")]
	[Address(RVA = "0x30FC5D8", Offset = "0x30FC5D8", VA = "0x30FC5D8")]
	public uint CalculateTriggerContainerID(Vector3 position)
	{
		return default(uint);
	}

	[Token(Token = "0x6015418")]
	[Address(RVA = "0x30F5D88", Offset = "0x30F5D88", VA = "0x30F5D88")]
	private Dictionary<uint, int> ConstructItemDic()
	{
		return null;
	}

	[Token(Token = "0x6015419")]
	[Address(RVA = "0x30FC8BC", Offset = "0x30FC8BC", VA = "0x30FC8BC")]
	public void ChangePlayerItem(IHAAMHPPLMG id, HICMEGJFGHB type, int count)
	{
	}

	[Token(Token = "0x601541A")]
	[Address(RVA = "0x30FCE84", Offset = "0x30FCE84", VA = "0x30FCE84")]
	public void SpectatorJoinChangePlayerItem(JOEINMGBILP msg)
	{
	}

	[Token(Token = "0x601541B")]
	[Address(RVA = "0x30FD324", Offset = "0x30FD324", VA = "0x30FD324")]
	public void GenerateSpectatorMatchResult(GFPPNNIBNHL msg)
	{
	}

	[Token(Token = "0x601541C")]
	[Address(RVA = "0x30FDEF8", Offset = "0x30FDEF8", VA = "0x30FDEF8")]
	public List<PlayerData> GetMatchWinnerPlayerData()
	{
		return null;
	}

	[Token(Token = "0x601541D")]
	[Address(RVA = "0x30FE238", Offset = "0x30FE238", VA = "0x30FE238")]
	public List<ResultTeamData> GenerateResult()
	{
		return null;
	}

	[Token(Token = "0x601541E")]
	[Address(RVA = "0x30FED74", Offset = "0x30FED74", VA = "0x30FED74")]
	public ResultMVPInfo GetMatchMvpInfo()
	{
		return null;
	}

	[Token(Token = "0x601541F")]
	[Address(RVA = "0x30FDCBC", Offset = "0x30FDCBC", VA = "0x30FDCBC")]
	private void GenerateTeamWinNum()
	{
	}

	[Token(Token = "0x6015420")]
	[Address(RVA = "0x30FEDCC", Offset = "0x30FEDCC", VA = "0x30FEDCC")]
	public void RegisterUIShowPosition(Transform transform)
	{
	}

	[Token(Token = "0x6015421")]
	[Address(RVA = "0x30FEE98", Offset = "0x30FEE98", VA = "0x30FEE98")]
	public void UnRegisterUIShowPosition(Transform transform)
	{
	}

	[Token(Token = "0x6015422")]
	[Address(RVA = "0x30FEF64", Offset = "0x30FEF64", VA = "0x30FEF64")]
	public void OnTeamScoreInited(List<GJMJKMBFEJH> teams)
	{
	}

	[Token(Token = "0x6015423")]
	[Address(RVA = "0x30FF4D0", Offset = "0x30FF4D0", VA = "0x30FF4D0")]
	public void OnTeamScoreChanged(List<JOCPLNGCKMO> teams)
	{
	}

	[Token(Token = "0x6015424")]
	[Address(RVA = "0x30FFC04", Offset = "0x30FFC04", VA = "0x30FFC04")]
	public void OnPlayerRankGet(EBLKGEHBKBF msg)
	{
	}

	[Token(Token = "0x6015425")]
	[Address(RVA = "0x30FFFC0", Offset = "0x30FFFC0", VA = "0x30FFFC0")]
	public void UpdateCombatLevelInfo(KIPMKBAKIPF msg)
	{
	}

	[Token(Token = "0x6015426")]
	[Address(RVA = "0x31004B8", Offset = "0x31004B8", VA = "0x31004B8")]
	public void OnBattleDetected(IHAAMHPPLMG damager, IHAAMHPPLMG beDamaged, FOFJEMOKAOH.JPGMOPJDINK type)
	{
	}

	[Token(Token = "0x6015427")]
	[Address(RVA = "0x3101178", Offset = "0x3101178", VA = "0x3101178")]
	private bool IsValidDamage(IHAAMHPPLMG damager, IHAAMHPPLMG beDamaged, FOFJEMOKAOH.JPGMOPJDINK type)
	{
		return default(bool);
	}

	[Token(Token = "0x6015428")]
	[Address(RVA = "0x3101404", Offset = "0x3101404", VA = "0x3101404")]
	public void RecordMatchInfo()
	{
	}

	[Token(Token = "0x6015429")]
	[Address(RVA = "0x31014EC", Offset = "0x31014EC", VA = "0x31014EC")]
	private void LogToFile()
	{
	}

	[Token(Token = "0x601542A")]
	[Address(RVA = "0x3102054", Offset = "0x3102054", VA = "0x3102054")]
	public void LogReplayEvent(OLDFDLECCBG evt, IHAAMHPPLMG id, float time = 0f, float fparam = 0f, string sparam = "")
	{
	}

	[Token(Token = "0x601542B")]
	[Address(RVA = "0x3102538", Offset = "0x3102538", VA = "0x3102538")]
	public List<ReplayEvent> GetReplayEvents()
	{
		return null;
	}

	[Token(Token = "0x601542C")]
	[Address(RVA = "0x3102590", Offset = "0x3102590", VA = "0x3102590")]
	private Color GetCurrentTeamColor(byte id)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x601542D")]
	[Address(RVA = "0x30F40E0", Offset = "0x30F40E0", VA = "0x30F40E0")]
	private void SortRankingTeamListByLiving()
	{
	}

	[Token(Token = "0x601542E")]
	[Address(RVA = "0x30F428C", Offset = "0x30F428C", VA = "0x30F428C")]
	private void SortRankingTeamListByCombatLevel()
	{
	}

	[Token(Token = "0x601542F")]
	[Address(RVA = "0x310268C", Offset = "0x310268C", VA = "0x310268C")]
	private void CalculateTeamScore()
	{
	}

	[Token(Token = "0x6015430")]
	[Address(RVA = "0x310297C", Offset = "0x310297C", VA = "0x310297C")]
	public string GerenateMatchInfo()
	{
		return null;
	}

	[Token(Token = "0x6015431")]
	[Address(RVA = "0x3102FF0", Offset = "0x3102FF0", VA = "0x3102FF0")]
	public bool LoadDirectoryBGImage(UITexture bgTexture)
	{
		return default(bool);
	}

	[Token(Token = "0x6015432")]
	[Address(RVA = "0x31030C4", Offset = "0x31030C4", VA = "0x31030C4")]
	public bool LoadPCTextures(UITexture texture, string dirName, string picName)
	{
		return default(bool);
	}

	[Token(Token = "0x6015433")]
	[Address(RVA = "0x31033C0", Offset = "0x31033C0", VA = "0x31033C0")]
	public void SetInputBlockValue(uint flag, bool val)
	{
	}

	[Token(Token = "0x6015434")]
	[Address(RVA = "0x3103460", Offset = "0x3103460", VA = "0x3103460")]
	public bool IsInputBlock()
	{
		return default(bool);
	}

	[Token(Token = "0x6015435")]
	[Address(RVA = "0x31034D8", Offset = "0x31034D8", VA = "0x31034D8")]
	private static int _003COnAddPlayer_003Em__0(PlayerData a, PlayerData b)
	{
		return default(int);
	}

	[Token(Token = "0x6015436")]
	[Address(RVA = "0x3103520", Offset = "0x3103520", VA = "0x3103520")]
	private int _003CSortTeams_003Em__1(TeamData a, TeamData b)
	{
		return default(int);
	}

	[Token(Token = "0x6015437")]
	[Address(RVA = "0x31035A8", Offset = "0x31035A8", VA = "0x31035A8")]
	private static byte _003CSortTeams_003Em__2(TeamData a)
	{
		return default(byte);
	}

	[Token(Token = "0x6015438")]
	[Address(RVA = "0x31035CC", Offset = "0x31035CC", VA = "0x31035CC")]
	private static int _003COnAddRejoinDeadPlayer_003Em__3(PlayerData a, PlayerData b)
	{
		return default(int);
	}

	[Token(Token = "0x6015439")]
	[Address(RVA = "0x3103614", Offset = "0x3103614", VA = "0x3103614")]
	private static int _003CGenerateSpectatorMatchResult_003Em__4(ResultTeamData a, ResultTeamData b)
	{
		return default(int);
	}

	[Token(Token = "0x601543A")]
	[Address(RVA = "0x310365C", Offset = "0x310365C", VA = "0x310365C")]
	private static int _003CGenerateResult_003Em__5(ResultTeamData a, ResultTeamData b)
	{
		return default(int);
	}

	[Token(Token = "0x601543B")]
	[Address(RVA = "0x31036A4", Offset = "0x31036A4", VA = "0x31036A4")]
	private static int _003CGenerateResult_003Em__6(ResultPlayerData a, ResultPlayerData b)
	{
		return default(int);
	}

	[Token(Token = "0x601543C")]
	[Address(RVA = "0x31036EC", Offset = "0x31036EC", VA = "0x31036EC")]
	private static int _003COnTeamScoreChanged_003Em__7(AccTeamData a, AccTeamData b)
	{
		return default(int);
	}

	[Token(Token = "0x601543D")]
	[Address(RVA = "0x3103734", Offset = "0x3103734", VA = "0x3103734")]
	private static int _003CSortRankingTeamListByLiving_003Em__8(RankingTeamData a, RankingTeamData b)
	{
		return default(int);
	}

	[Token(Token = "0x601543E")]
	[Address(RVA = "0x31037B4", Offset = "0x31037B4", VA = "0x31037B4")]
	private static int _003CSortRankingTeamListByCombatLevel_003Em__9(RankingTeamData a, RankingTeamData b)
	{
		return default(int);
	}
}
