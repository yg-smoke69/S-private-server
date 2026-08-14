using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200245C")]
internal class UIHUDUGC_MoreTeamLeaderboardController : UIHUDUGC_BaseLeaderboardController
{
	[Token(Token = "0x400E1E0")]
	[FieldOffset(Offset = "0x40")]
	private UIHUDUGC_MoreTeamLeaderboardView m_View;

	[Token(Token = "0x400E1E1")]
	[FieldOffset(Offset = "0x44")]
	private MoreTeamLeaderboardHudEntity m_ViewData;

	[Token(Token = "0x400E1E2")]
	[FieldOffset(Offset = "0x48")]
	private Dictionary<int, UIHUDUGC_MoreTeamLeaderboard_TeamItemController> m_TeamDict;

	[Token(Token = "0x400E1E3")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<IHAAMHPPLMG, UIHUDUGC_BaseLeaderboard_TeammateItemController> m_TeammateDict;

	[Token(Token = "0x400E1E4")]
	[FieldOffset(Offset = "0x50")]
	private UIDetailTipsInUGCMatchResultController m_HelpTips;

	[Token(Token = "0x600CEC8")]
	[Address(RVA = "0x2E14928", Offset = "0x2E14928", VA = "0x2E14928")]
	public UIHUDUGC_MoreTeamLeaderboardController()
	{
	}

	[Token(Token = "0x600CEC9")]
	[Address(RVA = "0x2E149E8", Offset = "0x2E149E8", VA = "0x2E149E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CECA")]
	[Address(RVA = "0x2E14A8C", Offset = "0x2E14A8C", VA = "0x2E14A8C", Slot = "33")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x600CECB")]
	[Address(RVA = "0x2E14C40", Offset = "0x2E14C40", VA = "0x2E14C40", Slot = "39")]
	public override void SetEntityID(string entityID)
	{
	}

	[Token(Token = "0x600CECC")]
	[Address(RVA = "0x2E14F38", Offset = "0x2E14F38", VA = "0x2E14F38", Slot = "40")]
	public override void DestroyEntity()
	{
	}

	[Token(Token = "0x600CECD")]
	[Address(RVA = "0x2E14FB8", Offset = "0x2E14FB8", VA = "0x2E14FB8", Slot = "36")]
	protected override UIHUDUGC_BaseLeaderboard_TeamItemController GetTeamItem(int teamIndex)
	{
		return null;
	}

	[Token(Token = "0x600CECE")]
	[Address(RVA = "0x2E150C4", Offset = "0x2E150C4", VA = "0x2E150C4", Slot = "34")]
	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController CreateTeammateItem(Player player)
	{
		return null;
	}

	[Token(Token = "0x600CECF")]
	[Address(RVA = "0x2E15310", Offset = "0x2E15310", VA = "0x2E15310", Slot = "35")]
	protected override UIHUDUGC_BaseLeaderboard_TeammateItemController FindTeammateItem(IHAAMHPPLMG playerId)
	{
		return null;
	}

	[Token(Token = "0x600CED0")]
	[Address(RVA = "0x2E15474", Offset = "0x2E15474", VA = "0x2E15474", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CED1")]
	[Address(RVA = "0x2E155B0", Offset = "0x2E155B0", VA = "0x2E155B0", Slot = "38")]
	protected override void UpdateAllTeammateItemInfo()
	{
	}

	[Token(Token = "0x600CED2")]
	[Address(RVA = "0x2E157A0", Offset = "0x2E157A0", VA = "0x2E157A0")]
	private void PostTeamTableReposition()
	{
	}

	[Token(Token = "0x600CED3")]
	[Address(RVA = "0x2E15988", Offset = "0x2E15988", VA = "0x2E15988")]
	private void OnSpaceBtnClick()
	{
	}

	[Token(Token = "0x600CED4")]
	[Address(RVA = "0x2E15B90", Offset = "0x2E15B90", VA = "0x2E15B90")]
	private void OnHelpBtnClick(Vector3 position)
	{
	}

	[Token(Token = "0x600CED5")]
	[Address(RVA = "0x2E15EDC", Offset = "0x2E15EDC", VA = "0x2E15EDC")]
	private int GetTeamIndex(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600CED6")]
	[Address(RVA = "0x2E16000", Offset = "0x2E16000", VA = "0x2E16000")]
	private void OnOpenStateChanged(bool old, bool cur)
	{
	}

	[Token(Token = "0x600CED7")]
	[Address(RVA = "0x2E16088", Offset = "0x2E16088", VA = "0x2E16088")]
	private void OnTeamIndexsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CED8")]
	[Address(RVA = "0x2E16F64", Offset = "0x2E16F64", VA = "0x2E16F64")]
	private void OnTeamRanksChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CED9")]
	[Address(RVA = "0x2E173D8", Offset = "0x2E173D8", VA = "0x2E173D8")]
	private void OnTeamScoresChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CEDA")]
	[Address(RVA = "0x2E17854", Offset = "0x2E17854", VA = "0x2E17854")]
	private void OnTeamColorsChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CEDB")]
	[Address(RVA = "0x2E17BF0", Offset = "0x2E17BF0", VA = "0x2E17BF0")]
	private void OnPlayerScoreTypesChanged(List<object> old, List<object> cur)
	{
	}

	[Token(Token = "0x600CEDC")]
	[Address(RVA = "0x2E17F4C", Offset = "0x2E17F4C", VA = "0x2E17F4C")]
	public void _003C_003EiFixBaseProxy_SetEntityID(string P0)
	{
	}

	[Token(Token = "0x600CEDD")]
	[Address(RVA = "0x2E17F54", Offset = "0x2E17F54", VA = "0x2E17F54")]
	public void _003C_003EiFixBaseProxy_DestroyEntity()
	{
	}

	[Token(Token = "0x600CEDE")]
	[Address(RVA = "0x2E17F5C", Offset = "0x2E17F5C", VA = "0x2E17F5C")]
	public new void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600CEDF")]
	[Address(RVA = "0x2E17F64", Offset = "0x2E17F64", VA = "0x2E17F64")]
	public void _003C_003EiFixBaseProxy_UpdateAllTeammateItemInfo()
	{
	}
}
