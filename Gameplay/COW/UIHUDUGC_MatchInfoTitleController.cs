using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002456")]
internal class UIHUDUGC_MatchInfoTitleController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002457")]
	public class MatchInfoTitleData : UIHUDUGCBaseViewData
	{
		[Token(Token = "0x400E1BB")]
		[FieldOffset(Offset = "0xA")]
		public bool NeedPhaseCountDown;

		[Token(Token = "0x400E1BC")]
		[FieldOffset(Offset = "0xB")]
		public bool NeedRoundNum;

		[Token(Token = "0x400E1BD")]
		[FieldOffset(Offset = "0xC")]
		public bool NeedTeamPlayer;

		[Token(Token = "0x400E1BE")]
		[FieldOffset(Offset = "0xD")]
		public bool NeedTeamScore;

		[Token(Token = "0x400E1BF")]
		[FieldOffset(Offset = "0xE")]
		public bool NeedAliveNum;

		[Token(Token = "0x400E1C0")]
		[FieldOffset(Offset = "0xF")]
		public bool NeedTwoTeam;

		[Token(Token = "0x400E1C1")]
		[FieldOffset(Offset = "0x10")]
		public bool NeedTeammateFlag;

		[Token(Token = "0x400E1C2")]
		[FieldOffset(Offset = "0x14")]
		public int ATeamIndex;

		[Token(Token = "0x400E1C3")]
		[FieldOffset(Offset = "0x18")]
		public int BTeamIndex;

		[Token(Token = "0x400E1C4")]
		[FieldOffset(Offset = "0x1C")]
		public int ATeammateFinishedNum;

		[Token(Token = "0x400E1C5")]
		[FieldOffset(Offset = "0x20")]
		public int BTeammateFinishedNum;

		[Token(Token = "0x400E1C6")]
		[FieldOffset(Offset = "0x24")]
		public int TeamIndex;

		[Token(Token = "0x400E1C7")]
		[FieldOffset(Offset = "0x28")]
		public int TeamTargetScore;

		[Token(Token = "0x400E1C8")]
		[FieldOffset(Offset = "0x2C")]
		public bool ShowTargetScore;

		[Token(Token = "0x400E1C9")]
		[FieldOffset(Offset = "0x30")]
		public int TeamIndex_MoreTeam;

		[Token(Token = "0x400E1CA")]
		[FieldOffset(Offset = "0x34")]
		public int TeamRank_MoreTeam;

		[Token(Token = "0x400E1CB")]
		[FieldOffset(Offset = "0x38")]
		public bool ShowTeammateFinishNum_MoreTeam;

		[Token(Token = "0x400E1CC")]
		[FieldOffset(Offset = "0x3C")]
		public int TeammateFinishNum_MoreTeam;

		[Token(Token = "0x400E1CD")]
		[FieldOffset(Offset = "0x40")]
		public bool ShowTeamTargetScore_MoreTeam;

		[Token(Token = "0x400E1CE")]
		[FieldOffset(Offset = "0x44")]
		public int TeamTargetScore_MoreTeam;

		[Token(Token = "0x400E1CF")]
		[FieldOffset(Offset = "0x48")]
		public int AliveTeammateCount_MoreTeam;

		[Token(Token = "0x400E1D0")]
		[FieldOffset(Offset = "0x4C")]
		public int TeamCount_MoreTeam;

		[Token(Token = "0x400E1D1")]
		[FieldOffset(Offset = "0x50")]
		public float PhaseEndTime;

		[Token(Token = "0x600CE9A")]
		[Address(RVA = "0x2E0F780", Offset = "0x2E0F780", VA = "0x2E0F780")]
		public MatchInfoTitleData()
		{
		}
	}

	[Token(Token = "0x2002458")]
	public class TeamData_MoreTeam
	{
		[Token(Token = "0x400E1D2")]
		[FieldOffset(Offset = "0x8")]
		public int TeamIndex;

		[Token(Token = "0x400E1D3")]
		[FieldOffset(Offset = "0xC")]
		public int TeamRank;

		[Token(Token = "0x400E1D4")]
		[FieldOffset(Offset = "0x10")]
		public int TeammateFinishNum;

		[Token(Token = "0x400E1D5")]
		[FieldOffset(Offset = "0x14")]
		public int TeamTargetScore;

		[Token(Token = "0x600CE9B")]
		[Address(RVA = "0x2E0D76C", Offset = "0x2E0D76C", VA = "0x2E0D76C")]
		public TeamData_MoreTeam()
		{
		}
	}

	[Token(Token = "0x400E1AB")]
	private const int SHOW_MORE_TEAMITEM_COUNT = 2;

	[Token(Token = "0x400E1AC")]
	[FieldOffset(Offset = "0x28")]
	private Color Blue;

	[Token(Token = "0x400E1AD")]
	[FieldOffset(Offset = "0x38")]
	private Color Red;

	[Token(Token = "0x400E1AE")]
	[FieldOffset(Offset = "0x48")]
	private UIHUDUGC_MatchInfoTitleView m_View;

	[Token(Token = "0x400E1AF")]
	[FieldOffset(Offset = "0x4C")]
	private MatchInfoTitleData m_ViewData;

	[Token(Token = "0x400E1B0")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<uint, List<IHAAMHPPLMG>> m_TeammateDict;

	[Token(Token = "0x400E1B1")]
	[FieldOffset(Offset = "0x54")]
	private List<UIHUDUGC_MatchInfoTitle_MoreTeamItemController> m_MoreTeamItemList;

	[Token(Token = "0x400E1B2")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<int, int> m_MoreTeamRankDict;

	[Token(Token = "0x400E1B3")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<int, TeamData_MoreTeam> m_MoreTeamDataDict;

	[Token(Token = "0x400E1B4")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsInit;

	[Token(Token = "0x400E1B5")]
	[FieldOffset(Offset = "0x64")]
	private int m_LastTime;

	[Token(Token = "0x400E1B6")]
	[FieldOffset(Offset = "0x68")]
	private int m_PhaseCountDown;

	[Token(Token = "0x400E1B7")]
	[FieldOffset(Offset = "0x6C")]
	private uint m_PlayerHostTeamIndex;

	[Token(Token = "0x400E1B8")]
	[FieldOffset(Offset = "0x70")]
	private bool m_HostTeamRankIsFirst;

	[Token(Token = "0x400E1B9")]
	[FieldOffset(Offset = "0x74")]
	private int m_MaxTargetScore;

	[Token(Token = "0x400E1BA")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<int> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600CE74")]
	[Address(RVA = "0x2E0C420", Offset = "0x2E0C420", VA = "0x2E0C420")]
	public UIHUDUGC_MatchInfoTitleController()
	{
	}

	[Token(Token = "0x600CE75")]
	[Address(RVA = "0x2E0C610", Offset = "0x2E0C610", VA = "0x2E0C610")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CE76")]
	[Address(RVA = "0x2E0C6B4", Offset = "0x2E0C6B4", VA = "0x2E0C6B4")]
	public void SetStateByParams(bool isShow, List<FIMGICJHBNI> args)
	{
	}

	[Token(Token = "0x600CE77")]
	[Address(RVA = "0x2E0F3DC", Offset = "0x2E0F3DC", VA = "0x2E0F3DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CE78")]
	[Address(RVA = "0x2E0F788", Offset = "0x2E0F788", VA = "0x2E0F788")]
	private void InitView()
	{
	}

	[Token(Token = "0x600CE79")]
	[Address(RVA = "0x2E0F8A4", Offset = "0x2E0F8A4", VA = "0x2E0F8A4")]
	private void OnAddPlayer(object[] param)
	{
	}

	[Token(Token = "0x600CE7A")]
	[Address(RVA = "0x2E10830", Offset = "0x2E10830", VA = "0x2E10830")]
	private void OnPlayerStatusChanged(object[] param)
	{
	}

	[Token(Token = "0x600CE7B")]
	[Address(RVA = "0x2E10A98", Offset = "0x2E10A98", VA = "0x2E10A98")]
	private void OnLocalPlayerHPChanged(object[] data)
	{
	}

	[Token(Token = "0x600CE7C")]
	[Address(RVA = "0x2E10B90", Offset = "0x2E10B90", VA = "0x2E10B90")]
	private void OnPhaseEndTimeChanged(object[] data)
	{
	}

	[Token(Token = "0x600CE7D")]
	[Address(RVA = "0x2E10E08", Offset = "0x2E10E08", VA = "0x2E10E08")]
	private void OnRoundChanged(object[] data)
	{
	}

	[Token(Token = "0x600CE7E")]
	[Address(RVA = "0x2E11100", Offset = "0x2E11100", VA = "0x2E11100")]
	private void OnTeamScoreChanged(object[] data)
	{
	}

	[Token(Token = "0x600CE7F")]
	[Address(RVA = "0x2E0E004", Offset = "0x2E0E004", VA = "0x2E0E004")]
	private void UpdateView()
	{
	}

	[Token(Token = "0x600CE80")]
	[Address(RVA = "0x2E0D774", Offset = "0x2E0D774", VA = "0x2E0D774")]
	private void InitViewData()
	{
	}

	[Token(Token = "0x600CE81")]
	[Address(RVA = "0x2E11320", Offset = "0x2E11320", VA = "0x2E11320")]
	private void SetTeamPlayer()
	{
	}

	[Token(Token = "0x600CE82")]
	[Address(RVA = "0x2E0FC18", Offset = "0x2E0FC18", VA = "0x2E0FC18")]
	private void AddTeammateItem(Player player)
	{
	}

	[Token(Token = "0x600CE83")]
	[Address(RVA = "0x2E10898", Offset = "0x2E10898", VA = "0x2E10898")]
	private void UpdateAllTeammateStatus()
	{
	}

	[Token(Token = "0x600CE84")]
	[Address(RVA = "0x2E11EF4", Offset = "0x2E11EF4", VA = "0x2E11EF4")]
	private bool IsLeftTeam(uint teamIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600CE85")]
	[Address(RVA = "0x2E10D30", Offset = "0x2E10D30", VA = "0x2E10D30")]
	private void SetPhaseCountDown()
	{
	}

	[Token(Token = "0x600CE86")]
	[Address(RVA = "0x2E12078", Offset = "0x2E12078", VA = "0x2E12078")]
	private void UpdatePhaseCountDown()
	{
	}

	[Token(Token = "0x600CE87")]
	[Address(RVA = "0x2E1016C", Offset = "0x2E1016C", VA = "0x2E1016C")]
	private List<int> GetTeammateStates(List<IHAAMHPPLMG> playerIDs)
	{
		return null;
	}

	[Token(Token = "0x600CE88")]
	[Address(RVA = "0x2E1060C", Offset = "0x2E1060C", VA = "0x2E1060C")]
	private void SetTeamPlayerStatus(uint teamIndex, List<int> teammateStates)
	{
	}

	[Token(Token = "0x600CE89")]
	[Address(RVA = "0x2E11D20", Offset = "0x2E11D20", VA = "0x2E11D20")]
	private void SetTeammateFlagCount(uint teamIndex, int count)
	{
	}

	[Token(Token = "0x600CE8A")]
	[Address(RVA = "0x2E1185C", Offset = "0x2E1185C", VA = "0x2E1185C")]
	private void SetAliveNum()
	{
	}

	[Token(Token = "0x600CE8B")]
	[Address(RVA = "0x2E1190C", Offset = "0x2E1190C", VA = "0x2E1190C")]
	private void SetTeamScore()
	{
	}

	[Token(Token = "0x600CE8C")]
	[Address(RVA = "0x2E11AFC", Offset = "0x2E11AFC", VA = "0x2E11AFC")]
	private void SetTargetScore()
	{
	}

	[Token(Token = "0x600CE8D")]
	[Address(RVA = "0x2E0E188", Offset = "0x2E0E188", VA = "0x2E0E188")]
	private void UpdateMoreTeamItemList_ForRank(int teamIndex, int teamRank)
	{
	}

	[Token(Token = "0x600CE8E")]
	[Address(RVA = "0x2E0ED70", Offset = "0x2E0ED70", VA = "0x2E0ED70")]
	private void UpdateMoreTeamItemList_ForFinishNum()
	{
	}

	[Token(Token = "0x600CE8F")]
	[Address(RVA = "0x2E0EF4C", Offset = "0x2E0EF4C", VA = "0x2E0EF4C")]
	private void UpdateMoreTeamItemList_ForTargetScore()
	{
	}

	[Token(Token = "0x600CE90")]
	[Address(RVA = "0x2E0F130", Offset = "0x2E0F130", VA = "0x2E0F130")]
	private void UpdateAliveTeammateCount()
	{
	}

	[Token(Token = "0x600CE91")]
	[Address(RVA = "0x2E124D4", Offset = "0x2E124D4", VA = "0x2E124D4")]
	private UIHUDUGC_MatchInfoTitle_MoreTeamItemController GetMoreTeamItemController(int index)
	{
		return null;
	}

	[Token(Token = "0x600CE92")]
	[Address(RVA = "0x2E12760", Offset = "0x2E12760", VA = "0x2E12760")]
	private TeamData_MoreTeam GetMoreTeamData(int teamIndex)
	{
		return null;
	}

	[Token(Token = "0x600CE93")]
	[Address(RVA = "0x2E0D41C", Offset = "0x2E0D41C", VA = "0x2E0D41C")]
	private void NeedRoundNum(bool value)
	{
	}

	[Token(Token = "0x600CE94")]
	[Address(RVA = "0x2E13280", Offset = "0x2E13280", VA = "0x2E13280")]
	private void Update()
	{
	}

	[Token(Token = "0x600CE95")]
	[Address(RVA = "0x2E132F8", Offset = "0x2E132F8", VA = "0x2E132F8")]
	private void OnClickLeaderboardBtn()
	{
	}

	[Token(Token = "0x600CE96")]
	[Address(RVA = "0x2E13450", Offset = "0x2E13450", VA = "0x2E13450", Slot = "31")]
	public void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CE97")]
	[Address(RVA = "0x2E1352C", Offset = "0x2E1352C", VA = "0x2E1352C", Slot = "32")]
	public void DestroyEntity()
	{
	}

	[Token(Token = "0x600CE98")]
	[Address(RVA = "0x2E13600", Offset = "0x2E13600", VA = "0x2E13600")]
	private static int _003CGetTeammateStates_003Em__0(int a, int b)
	{
		return default(int);
	}

	[Token(Token = "0x600CE99")]
	[Address(RVA = "0x2E13624", Offset = "0x2E13624", VA = "0x2E13624")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
