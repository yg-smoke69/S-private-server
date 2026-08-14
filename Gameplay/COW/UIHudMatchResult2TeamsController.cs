using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20027B0")]
internal class UIHudMatchResult2TeamsController : UIHudMatchResultBaseShareController
{
	[Token(Token = "0x400F4F1")]
	[FieldOffset(Offset = "0x4C")]
	protected UIHudMatchResult2TeamsView m_View;

	[Token(Token = "0x400F4F2")]
	[FieldOffset(Offset = "0x50")]
	protected bool m_UIInited;

	[Token(Token = "0x400F4F3")]
	[FieldOffset(Offset = "0x54")]
	private UIModelFriends friendsModel;

	[Token(Token = "0x400F4F4")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600F4F1")]
	[Address(RVA = "0xFFEC0C", Offset = "0xFFEC0C", VA = "0xFFEC0C")]
	public UIHudMatchResult2TeamsController()
	{
	}

	[Token(Token = "0x600F4F2")]
	[Address(RVA = "0xFFEC14", Offset = "0xFFEC14", VA = "0xFFEC14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F4F3")]
	[Address(RVA = "0xFFECB8", Offset = "0xFFECB8", VA = "0xFFECB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F4F4")]
	[Address(RVA = "0xFFF254", Offset = "0xFFF254", VA = "0xFFF254", Slot = "33")]
	protected override void OnMatchStatsChange(MatchStats stats, MatchIncome income)
	{
	}

	[Token(Token = "0x600F4F5")]
	[Address(RVA = "0xFFEF2C", Offset = "0xFFEF2C", VA = "0xFFEF2C")]
	public void ShowUI(MatchStats statsData, MatchIncome income)
	{
	}

	[Token(Token = "0x600F4F6")]
	[Address(RVA = "0xFFEE5C", Offset = "0xFFEE5C", VA = "0xFFEE5C")]
	private void ShowElements(bool show)
	{
	}

	[Token(Token = "0x600F4F7")]
	[Address(RVA = "0xFFF2DC", Offset = "0xFFF2DC", VA = "0xFFF2DC")]
	private bool IsLocalTeamWinning(MatchStats stats)
	{
		return default(bool);
	}

	[Token(Token = "0x600F4F8")]
	[Address(RVA = "0xFFF358", Offset = "0xFFF358", VA = "0xFFF358")]
	private void InitTeamInfo(bool win, MatchStats statsData)
	{
	}

	[Token(Token = "0x600F4F9")]
	[Address(RVA = "0xFFF918", Offset = "0xFFF918", VA = "0xFFF918")]
	private void InitTeammates(UIGrid grid, List<TeammateStats> players, bool win, ulong localUserId)
	{
	}

	[Token(Token = "0x600F4FA")]
	[Address(RVA = "0x100121C", Offset = "0x100121C", VA = "0x100121C", Slot = "38")]
	protected virtual UIHudMatchResult2TeamsView OnCreateView()
	{
		return null;
	}

	[Token(Token = "0x600F4FB")]
	[Address(RVA = "0xFFFF84", Offset = "0xFFFF84", VA = "0xFFFF84")]
	public void ShowRewards(MatchIncome incomeData, List<BaseItemInfo> rewardList)
	{
	}

	[Token(Token = "0x600F4FC")]
	[Address(RVA = "0x10012C8", Offset = "0x10012C8", VA = "0x10012C8")]
	private static CommonRewardItemInfo _003CShowRewards_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600F4FD")]
	[Address(RVA = "0x10012D0", Offset = "0x10012D0", VA = "0x10012D0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F4FE")]
	[Address(RVA = "0x10012D8", Offset = "0x10012D8", VA = "0x10012D8")]
	public void _003C_003EiFixBaseProxy_OnMatchStatsChange(MatchStats P0, MatchIncome P1)
	{
	}
}
