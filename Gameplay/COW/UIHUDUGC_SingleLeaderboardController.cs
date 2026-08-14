using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002478")]
internal class UIHUDUGC_SingleLeaderboardController : UIHUDUGC_BaseLeaderboardController, _Attribute
{
	[Token(Token = "0x2002479")]
	private sealed class _003COnPlayersChanged_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E254")]
		[FieldOffset(Offset = "0x8")]
		internal int pid;

		[Token(Token = "0x600CFF1")]
		[Address(RVA = "0x291F9C8", Offset = "0x291F9C8", VA = "0x291F9C8")]
		public _003COnPlayersChanged_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600CFF2")]
		[Address(RVA = "0x29214B8", Offset = "0x29214B8", VA = "0x29214B8")]
		internal bool _003C_003Em__0(PlayerLeaderBoardData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200247A")]
	private sealed class _003COnPlayerRanksChanged_003Ec__AnonStorey1
	{
		[Token(Token = "0x400E255")]
		[FieldOffset(Offset = "0x8")]
		internal uint pid;

		[Token(Token = "0x600CFF3")]
		[Address(RVA = "0x291FECC", Offset = "0x291FECC", VA = "0x291FECC")]
		public _003COnPlayerRanksChanged_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600CFF4")]
		[Address(RVA = "0x29213C0", Offset = "0x29213C0", VA = "0x29213C0")]
		internal bool _003C_003Em__0(PlayerLeaderBoardData d)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E24A")]
	[FieldOffset(Offset = "0x40")]
	private UIHUDUGC_SingleLeaderboardView m_View;

	[Token(Token = "0x400E24B")]
	[FieldOffset(Offset = "0x44")]
	private SingleLeaderboardHudEntity m_ViewData;

	[Token(Token = "0x400E24C")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<IHAAMHPPLMG, UIHUDUGC_SingleLeaderboard_ItemController> m_PlayerDict;

	[Token(Token = "0x400E24D")]
	[FieldOffset(Offset = "0x4C")]
	private UIDetailTipsInUGCMatchResultController m_HelpTips;

	[Token(Token = "0x400E24E")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<int, UILabel> m_LabelDict;

	[Token(Token = "0x400E24F")]
	[FieldOffset(Offset = "0x54")]
	private UIHUDUGC_SingleLeaderboard_ItemController m_SelfRankItem;

	[Token(Token = "0x400E250")]
	[FieldOffset(Offset = "0x58")]
	private int m_EasyListSelfItemIndex;

	[Token(Token = "0x400E251")]
	[FieldOffset(Offset = "0x5C")]
	private List<PlayerLeaderBoardData> m_PlayerDataList;

	[Token(Token = "0x400E252")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<PlayerLeaderBoardData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E253")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<PlayerLeaderBoardData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x600CFD7")]
	[Address(RVA = "0x291E2A0", Offset = "0x291E2A0", VA = "0x291E2A0")]
	public UIHUDUGC_SingleLeaderboardController()
	{
	}

	[Token(Token = "0x600CFD8")]
	[Address(RVA = "0x291E394", Offset = "0x291E394", VA = "0x291E394")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CFD9")]
	[Address(RVA = "0x291E43C", Offset = "0x291E43C", VA = "0x291E43C", Slot = "33")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x600CFDA")]
	[Address(RVA = "0x291E834", Offset = "0x291E834", VA = "0x291E834", Slot = "39")]
	public override void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CFDB")]
	[Address(RVA = "0x291EA74", Offset = "0x291EA74", VA = "0x291EA74", Slot = "40")]
	public override void DestroyEntity()
	{
	}

	[Token(Token = "0x600CFDC")]
	[Address(RVA = "0x291EAF4", Offset = "0x291EAF4", VA = "0x291EAF4", Slot = "36")]
	protected override UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex)
	{
		return null;
	}

	[Token(Token = "0x600CFDD")]
	[Address(RVA = "0x291EB58", Offset = "0x291EB58", VA = "0x291EB58", Slot = "34")]
	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	[Token(Token = "0x600CFDE")]
	[Address(RVA = "0x291EBBC", Offset = "0x291EBBC", VA = "0x291EBBC", Slot = "35")]
	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x600CFDF")]
	[Address(RVA = "0x291ED20", Offset = "0x291ED20", VA = "0x291ED20", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CFE0")]
	[Address(RVA = "0x291EEEC", Offset = "0x291EEEC", VA = "0x291EEEC")]
	private void OnSpaceBtnClick()
	{
	}

	[Token(Token = "0x600CFE1")]
	[Address(RVA = "0x291EF58", Offset = "0x291EF58", VA = "0x291EF58")]
	private void OnHelpBtnClick(Vector3 position)
	{
	}

	[Token(Token = "0x600CFE2")]
	[Address(RVA = "0x291F1C8", Offset = "0x291F1C8", VA = "0x291F1C8")]
	private uint GetPlayerID(int index)
	{
		return default(uint);
	}

	[Token(Token = "0x600CFE3")]
	[Address(RVA = "0x291F384", Offset = "0x291F384", VA = "0x291F384")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CFE4")]
	[Address(RVA = "0x291F40C", Offset = "0x291F40C", VA = "0x291F40C")]
	private void OnPlayersChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CFE5")]
	[Address(RVA = "0x291F9D0", Offset = "0x291F9D0", VA = "0x291F9D0")]
	private void OnPlayerRanksChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CFE6")]
	[Address(RVA = "0x29200CC", Offset = "0x29200CC", VA = "0x29200CC")]
	private void OnPlayerScoreTypesChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CFE7")]
	[Address(RVA = "0x29208AC", Offset = "0x29208AC", VA = "0x29208AC")]
	private void UpdateTitles(List<int> scoreTypes)
	{
	}

	[Token(Token = "0x600CFE8")]
	[Address(RVA = "0x2920CE4", Offset = "0x2920CE4", VA = "0x2920CE4")]
	private string GetInfoTitle(CBNPMCENMKE infoType)
	{
		return null;
	}

	[Token(Token = "0x600CFE9")]
	[Address(RVA = "0x2920E50", Offset = "0x2920E50", VA = "0x2920E50", Slot = "41")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600CFEA")]
	[Address(RVA = "0x2920F48", Offset = "0x2920F48", VA = "0x2920F48", Slot = "42")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600CFEB")]
	[Address(RVA = "0x2920FC4", Offset = "0x2920FC4", VA = "0x2920FC4")]
	private void OnScrollViewDragMoving()
	{
	}

	[Token(Token = "0x600CFEC")]
	[Address(RVA = "0x2921248", Offset = "0x2921248", VA = "0x2921248")]
	private static bool _003COnPlayersChanged_003Em__0(PlayerLeaderBoardData x)
	{
		return default(bool);
	}

	[Token(Token = "0x600CFED")]
	[Address(RVA = "0x2921360", Offset = "0x2921360", VA = "0x2921360")]
	private static int _003COnPlayerRanksChanged_003Em__1(PlayerLeaderBoardData a, PlayerLeaderBoardData b)
	{
		return default(int);
	}

	[Token(Token = "0x600CFEE")]
	[Address(RVA = "0x29213A8", Offset = "0x29213A8", VA = "0x29213A8")]
	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	[Token(Token = "0x600CFEF")]
	[Address(RVA = "0x29213B0", Offset = "0x29213B0", VA = "0x29213B0")]
	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	[Token(Token = "0x600CFF0")]
	[Address(RVA = "0x29213B8", Offset = "0x29213B8", VA = "0x29213B8")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
