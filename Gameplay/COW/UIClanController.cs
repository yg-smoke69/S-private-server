using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002538")]
public class UIClanController : UINavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002539")]
	public enum ClanTab
	{
		[Token(Token = "0x400E6AD")]
		MainPage,
		[Token(Token = "0x400E6AE")]
		Members,
		[Token(Token = "0x400E6AF")]
		PointMatch,
		[Token(Token = "0x400E6B0")]
		ClanWar,
		[Token(Token = "0x400E6B1")]
		ClanWarNews,
		[Token(Token = "0x400E6B2")]
		ClanWarMarch
	}

	[Token(Token = "0x200253A")]
	public class ClanTabData
	{
		[Token(Token = "0x400E6B3")]
		[FieldOffset(Offset = "0x8")]
		public ClanTab m_ClanTab;

		[Token(Token = "0x400E6B4")]
		[FieldOffset(Offset = "0xC")]
		public string m_Title;

		[Token(Token = "0x400E6B5")]
		[FieldOffset(Offset = "0x10")]
		public ETipsType m_RedDot;

		[Token(Token = "0x400E6B6")]
		[FieldOffset(Offset = "0x14")]
		public Action m_OnSelectTab;

		[Token(Token = "0x400E6B7")]
		[FieldOffset(Offset = "0x18")]
		public List<int> m_SubTabs;

		[Token(Token = "0x400E6B8")]
		[FieldOffset(Offset = "0x1C")]
		public bool hasRedDot;

		[Token(Token = "0x600D8AB")]
		[Address(RVA = "0x2F2BE4C", Offset = "0x2F2BE4C", VA = "0x2F2BE4C")]
		public ClanTabData()
		{
		}
	}

	[Token(Token = "0x200253B")]
	private enum TabType
	{
		[Token(Token = "0x400E6BA")]
		Details,
		[Token(Token = "0x400E6BB")]
		List,
		[Token(Token = "0x400E6BC")]
		Race
	}

	[Token(Token = "0x200253C")]
	private sealed class _003CCreateDrawerTab_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E6BD")]
		[FieldOffset(Offset = "0x8")]
		internal StandardTabItemViewData mainTabData;

		[Token(Token = "0x400E6BE")]
		[FieldOffset(Offset = "0xC")]
		internal UIClanController _0024this;

		[Token(Token = "0x600D8AC")]
		[Address(RVA = "0x2F2BE54", Offset = "0x2F2BE54", VA = "0x2F2BE54")]
		public _003CCreateDrawerTab_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600D8AD")]
		[Address(RVA = "0x2F30220", Offset = "0x2F30220", VA = "0x2F30220")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600D8AE")]
		[Address(RVA = "0x2F302BC", Offset = "0x2F302BC", VA = "0x2F302BC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400E697")]
	[FieldOffset(Offset = "0x68")]
	private AutoPopup m_AutoPopup;

	[Token(Token = "0x400E698")]
	[FieldOffset(Offset = "0x6C")]
	protected Color unselectIconColor;

	[Token(Token = "0x400E699")]
	[FieldOffset(Offset = "0x7C")]
	protected Color selectIconColor;

	[Token(Token = "0x400E69A")]
	[FieldOffset(Offset = "0x8C")]
	private UIClanViewExt m_View;

	[Token(Token = "0x400E69B")]
	[FieldOffset(Offset = "0x90")]
	private ClanLuckyBagConfigData m_ClanLuckyBagConfigData;

	[Token(Token = "0x400E69C")]
	[FieldOffset(Offset = "0x94")]
	private UIPointsRaceController m_RaceController;

	[Token(Token = "0x400E69D")]
	[FieldOffset(Offset = "0x98")]
	private UIClanWarScheduleController m_ClanWarScheduleController;

	[Token(Token = "0x400E69E")]
	[FieldOffset(Offset = "0x9C")]
	private UIClanWarNewsController m_ClanWarNewsController;

	[Token(Token = "0x400E69F")]
	[FieldOffset(Offset = "0xA0")]
	private UIClanMainPageController m_ClanMainPageController;

	[Token(Token = "0x400E6A0")]
	[FieldOffset(Offset = "0xA4")]
	private UIClanMemberPageController m_ClanMemberPageController;

	[Token(Token = "0x400E6A1")]
	[FieldOffset(Offset = "0xA8")]
	private UIWidget m_DetailBtnWidget;

	[Token(Token = "0x400E6A2")]
	[FieldOffset(Offset = "0xAC")]
	private UICommonGuideController m_GuideCtrl;

	[Token(Token = "0x400E6A3")]
	[FieldOffset(Offset = "0xB0")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E6A4")]
	[FieldOffset(Offset = "0xB4")]
	private bool clanRaceOpened;

	[Token(Token = "0x400E6A5")]
	[FieldOffset(Offset = "0xB8")]
	private EClan.ClanWarPhaseType m_ClanWarStage;

	[Token(Token = "0x400E6A6")]
	[FieldOffset(Offset = "0xBC")]
	private List<ClanTabData> m_ClanTabDataList;

	[Token(Token = "0x400E6A7")]
	[FieldOffset(Offset = "0xC0")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x400E6A8")]
	[FieldOffset(Offset = "0xC4")]
	private List<StandardTabItemViewData> m_MainTabDataList;

	[Token(Token = "0x400E6A9")]
	[FieldOffset(Offset = "0xC8")]
	private List<StandardSubTabItemViewData> m_SubTabDataList;

	[Token(Token = "0x400E6AA")]
	[FieldOffset(Offset = "0xCC")]
	private ClanTab m_CurrentClanTab;

	[Token(Token = "0x400E6AB")]
	[FieldOffset(Offset = "0xD0")]
	private bool m_IsInClanWarMarch;

	[Token(Token = "0x600D87F")]
	[Address(RVA = "0x2F29340", Offset = "0x2F29340", VA = "0x2F29340")]
	public UIClanController()
	{
	}

	[Token(Token = "0x600D880")]
	[Address(RVA = "0x2F29520", Offset = "0x2F29520", VA = "0x2F29520")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D881")]
	[Address(RVA = "0x2F295C4", Offset = "0x2F295C4", VA = "0x2F295C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D882")]
	[Address(RVA = "0x2F2B7DC", Offset = "0x2F2B7DC", VA = "0x2F2B7DC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600D883")]
	[Address(RVA = "0x2F2BDD4", Offset = "0x2F2BDD4", VA = "0x2F2BDD4")]
	private void Update()
	{
	}

	[Token(Token = "0x600D884")]
	[Address(RVA = "0x2F2A184", Offset = "0x2F2A184", VA = "0x2F2A184")]
	private void InitClanTabData()
	{
	}

	[Token(Token = "0x600D885")]
	[Address(RVA = "0x2F2A7E0", Offset = "0x2F2A7E0", VA = "0x2F2A7E0")]
	public void CreateDrawerTab()
	{
	}

	[Token(Token = "0x600D886")]
	[Address(RVA = "0x2F2BE5C", Offset = "0x2F2BE5C", VA = "0x2F2BE5C")]
	private void DoLog(ClanTab tabType)
	{
	}

	[Token(Token = "0x600D887")]
	[Address(RVA = "0x2F2C080", Offset = "0x2F2C080", VA = "0x2F2C080")]
	private void OnGroupJoin(object[] data)
	{
	}

	[Token(Token = "0x600D888")]
	[Address(RVA = "0x2F2C220", Offset = "0x2F2C220", VA = "0x2F2C220")]
	private void OnKickOutClan(object[] data)
	{
	}

	[Token(Token = "0x600D889")]
	[Address(RVA = "0x2F2C458", Offset = "0x2F2C458", VA = "0x2F2C458")]
	private void OnToggleDetailsTabChange()
	{
	}

	[Token(Token = "0x600D88A")]
	[Address(RVA = "0x2F2CC04", Offset = "0x2F2CC04", VA = "0x2F2CC04")]
	private void OnToggleRaceTabChange()
	{
	}

	[Token(Token = "0x600D88B")]
	[Address(RVA = "0x2F2CD88", Offset = "0x2F2CD88", VA = "0x2F2CD88")]
	private void OnToggleListTabChange()
	{
	}

	[Token(Token = "0x600D88C")]
	[Address(RVA = "0x2F2CFAC", Offset = "0x2F2CFAC", VA = "0x2F2CFAC")]
	private void OnToggleClanWarScheduleChange()
	{
	}

	[Token(Token = "0x600D88D")]
	[Address(RVA = "0x2F2D634", Offset = "0x2F2D634", VA = "0x2F2D634")]
	private void OnToggleClanWarNewsChange()
	{
	}

	[Token(Token = "0x600D88E")]
	[Address(RVA = "0x2F2C668", Offset = "0x2F2C668", VA = "0x2F2C668")]
	private void RefreshDisplayContent()
	{
	}

	[Token(Token = "0x600D88F")]
	[Address(RVA = "0x2F2DB6C", Offset = "0x2F2DB6C", VA = "0x2F2DB6C", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D890")]
	[Address(RVA = "0x2F2DC4C", Offset = "0x2F2DC4C", VA = "0x2F2DC4C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D891")]
	[Address(RVA = "0x2F2E71C", Offset = "0x2F2E71C", VA = "0x2F2E71C")]
	private void RefreshRaceInfo()
	{
	}

	[Token(Token = "0x600D892")]
	[Address(RVA = "0x2F2E9E4", Offset = "0x2F2E9E4", VA = "0x2F2E9E4")]
	private void UpdateRaceState()
	{
	}

	[Token(Token = "0x600D893")]
	[Address(RVA = "0x2F2EC2C", Offset = "0x2F2EC2C", VA = "0x2F2EC2C")]
	public void OnOpenRankList()
	{
	}

	[Token(Token = "0x600D894")]
	[Address(RVA = "0x2F2EE88", Offset = "0x2F2EE88", VA = "0x2F2EE88")]
	public void OnClickAddFriend()
	{
	}

	[Token(Token = "0x600D895")]
	[Address(RVA = "0x2F2EF70", Offset = "0x2F2EF70", VA = "0x2F2EF70")]
	private void OnClickCheckIn()
	{
	}

	[Token(Token = "0x600D896")]
	[Address(RVA = "0x2F2F080", Offset = "0x2F2F080", VA = "0x2F2F080")]
	private void OnClanShopBtnClick()
	{
	}

	[Token(Token = "0x600D897")]
	[Address(RVA = "0x2F2F2B4", Offset = "0x2F2F2B4", VA = "0x2F2F2B4")]
	private void OnClanWarPushNotifyOpen(object[] param)
	{
	}

	[Token(Token = "0x600D898")]
	[Address(RVA = "0x2F2F390", Offset = "0x2F2F390", VA = "0x2F2F390")]
	private void OnRuleClicked(object[] param)
	{
	}

	[Token(Token = "0x600D899")]
	[Address(RVA = "0x2F2F574", Offset = "0x2F2F574", VA = "0x2F2F574")]
	private void OnLuckyBagBtnClick()
	{
	}

	[Token(Token = "0x600D89A")]
	[Address(RVA = "0x2F2F684", Offset = "0x2F2F684", VA = "0x2F2F684")]
	private void OnClanCurrencyBtnClick(object[] data)
	{
	}

	[Token(Token = "0x600D89B")]
	[Address(RVA = "0x2F2F94C", Offset = "0x2F2F94C", VA = "0x2F2F94C")]
	private void OnClanWarRewardClick(object[] data)
	{
	}

	[Token(Token = "0x600D89C")]
	[Address(RVA = "0x2F2F9D4", Offset = "0x2F2F9D4", VA = "0x2F2F9D4")]
	private void OnClanWarMatchClick(object[] data)
	{
	}

	[Token(Token = "0x600D89D")]
	[Address(RVA = "0x2F2FA5C", Offset = "0x2F2FA5C", VA = "0x2F2FA5C")]
	private void OnGameVoiceJoin(object[] data)
	{
	}

	[Token(Token = "0x600D89E")]
	[Address(RVA = "0x2F2FAC4", Offset = "0x2F2FAC4", VA = "0x2F2FAC4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600D89F")]
	[Address(RVA = "0x2F2FD3C", Offset = "0x2F2FD3C", VA = "0x2F2FD3C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600D8A0")]
	[Address(RVA = "0x2F2D7B8", Offset = "0x2F2D7B8", VA = "0x2F2D7B8")]
	private void RefreshGameVoiceBtnGroup()
	{
	}

	[Token(Token = "0x600D8A1")]
	[Address(RVA = "0x2F2D8EC", Offset = "0x2F2D8EC", VA = "0x2F2D8EC")]
	private void RefreshClanCurrencyCnt()
	{
	}

	[Token(Token = "0x600D8A2")]
	[Address(RVA = "0x2F2FEF4", Offset = "0x2F2FEF4", VA = "0x2F2FEF4", Slot = "44")]
	private void COW_002EITipsDelegate_002EOnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600D8A3")]
	[Address(RVA = "0x2F2FF64", Offset = "0x2F2FF64", VA = "0x2F2FF64")]
	private bool IsPlayLuckyBagAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x600D8A4")]
	[Address(RVA = "0x2F2B698", Offset = "0x2F2B698", VA = "0x2F2B698")]
	private void UpdateClanRaceTabWhetherIsOpenning()
	{
	}

	[Token(Token = "0x600D8A5")]
	[Address(RVA = "0x2F2FFEC", Offset = "0x2F2FFEC", VA = "0x2F2FFEC")]
	private void OnClickDeputyCaptainApply()
	{
	}

	[Token(Token = "0x600D8A6")]
	[Address(RVA = "0x2F30120", Offset = "0x2F30120", VA = "0x2F30120")]
	private void _003CRefreshRaceInfo_003Em__0()
	{
	}

	[Token(Token = "0x600D8A7")]
	[Address(RVA = "0x2F30200", Offset = "0x2F30200", VA = "0x2F30200")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D8A8")]
	[Address(RVA = "0x2F30208", Offset = "0x2F30208", VA = "0x2F30208")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600D8A9")]
	[Address(RVA = "0x2F30210", Offset = "0x2F30210", VA = "0x2F30210")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600D8AA")]
	[Address(RVA = "0x2F30218", Offset = "0x2F30218", VA = "0x2F30218")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
