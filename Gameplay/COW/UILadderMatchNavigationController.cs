using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002163")]
public class UILadderMatchNavigationController : UINavigationController, _Attribute
{
	[Token(Token = "0x2002164")]
	public class RewardExhitbitEasyList : _Attribute
	{
		[Token(Token = "0x400D1C5")]
		[FieldOffset(Offset = "0x8")]
		private UILadderMatchNavigationController levelRwardListController;

		[Token(Token = "0x600B0B7")]
		[Address(RVA = "0x22BD6E8", Offset = "0x22BD6E8", VA = "0x22BD6E8")]
		public RewardExhitbitEasyList(UILadderMatchNavigationController levelRwardListController)
		{
		}

		[Token(Token = "0x600B0B8")]
		[Address(RVA = "0x22BD708", Offset = "0x22BD708", VA = "0x22BD708", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600B0B9")]
		[Address(RVA = "0x22BD784", Offset = "0x22BD784", VA = "0x22BD784", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400D1B1")]
	[FieldOffset(Offset = "0x68")]
	private LadderMatchNavigationView m_View;

	[Token(Token = "0x400D1B2")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelLadderMatch m_ModelLadderBR;

	[Token(Token = "0x400D1B3")]
	[FieldOffset(Offset = "0x70")]
	private UIModelCSLadderMatch m_ModelLadderCS;

	[Token(Token = "0x400D1B4")]
	[FieldOffset(Offset = "0x74")]
	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	[Token(Token = "0x400D1B5")]
	[FieldOffset(Offset = "0x78")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D1B6")]
	[FieldOffset(Offset = "0x7C")]
	private UILadderMatchLeaderboardController m_LadderBoardCtrl;

	[Token(Token = "0x400D1B7")]
	[FieldOffset(Offset = "0x80")]
	private UILadderMatchSeasonMiniInfoController m_SeasonMiniInfoCtrl;

	[Token(Token = "0x400D1B8")]
	[FieldOffset(Offset = "0x84")]
	private UIModelProfile m_UIModelProfile;

	[Token(Token = "0x400D1B9")]
	[FieldOffset(Offset = "0x88")]
	private RewardExhitbitEasyList m_RewardEasyList;

	[Token(Token = "0x400D1BA")]
	[FieldOffset(Offset = "0x8C")]
	private ResourceID m_CurrentBGResID;

	[Token(Token = "0x400D1BB")]
	[FieldOffset(Offset = "0x90")]
	private string m_CurrentCdnBGUrl;

	[Token(Token = "0x400D1BC")]
	[FieldOffset(Offset = "0x94")]
	private JOKABEAPNPP m_ChosenGameMode;

	[Token(Token = "0x400D1BD")]
	[FieldOffset(Offset = "0x98")]
	private DGNDKMLMLPM m_ChosenMatchMode;

	[Token(Token = "0x400D1BE")]
	[FieldOffset(Offset = "0x9C")]
	private bool m_IsModelAndViewInit;

	[Token(Token = "0x400D1BF")]
	[FieldOffset(Offset = "0xA0")]
	private UIPopMenuSmallControler m_PopMenu;

	[Token(Token = "0x400D1C0")]
	[FieldOffset(Offset = "0xA4")]
	private uint m_BRUnlockMatchRemainTime;

	[Token(Token = "0x400D1C1")]
	[FieldOffset(Offset = "0xA8")]
	private uint m_PeriodicUnlockMatchRemainTime;

	[Token(Token = "0x400D1C2")]
	[FieldOffset(Offset = "0xAC")]
	private uint m_CSUnlockMatchRemainTime;

	[Token(Token = "0x400D1C3")]
	[FieldOffset(Offset = "0xB0")]
	private List<BaseItemInfo> m_UnlockRewardBaseItemInfoList;

	[Token(Token = "0x400D1C4")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B086")]
	[Address(RVA = "0x1AF6DD4", Offset = "0x1AF6DD4", VA = "0x1AF6DD4")]
	public UILadderMatchNavigationController()
	{
	}

	[Token(Token = "0x600B087")]
	[Address(RVA = "0x1AF6EE8", Offset = "0x1AF6EE8", VA = "0x1AF6EE8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B088")]
	[Address(RVA = "0x1AF6F8C", Offset = "0x1AF6F8C", VA = "0x1AF6F8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B089")]
	[Address(RVA = "0x1AF78B8", Offset = "0x1AF78B8", VA = "0x1AF78B8")]
	private void InitViewData()
	{
	}

	[Token(Token = "0x600B08A")]
	[Address(RVA = "0x1AF7624", Offset = "0x1AF7624", VA = "0x1AF7624")]
	private void InitModelAndView()
	{
	}

	[Token(Token = "0x600B08B")]
	[Address(RVA = "0x1AF8218", Offset = "0x1AF8218", VA = "0x1AF8218")]
	private void UpdateGrandMasterRuleBtn()
	{
	}

	[Token(Token = "0x600B08C")]
	[Address(RVA = "0x1AF85A0", Offset = "0x1AF85A0", VA = "0x1AF85A0")]
	private void UpdateSeasonRankLabel()
	{
	}

	[Token(Token = "0x600B08D")]
	[Address(RVA = "0x1AF9040", Offset = "0x1AF9040", VA = "0x1AF9040", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600B08E")]
	[Address(RVA = "0x1AF97BC", Offset = "0x1AF97BC", VA = "0x1AF97BC", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600B08F")]
	[Address(RVA = "0x1AF954C", Offset = "0x1AF954C", VA = "0x1AF954C")]
	private void SetData(DGNDKMLMLPM matchMode)
	{
	}

	[Token(Token = "0x600B090")]
	[Address(RVA = "0x1AF9820", Offset = "0x1AF9820", VA = "0x1AF9820")]
	private void SetData(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode)
	{
	}

	[Token(Token = "0x600B091")]
	[Address(RVA = "0x1AFB360", Offset = "0x1AFB360", VA = "0x1AFB360")]
	private void OnBtnClickRankMasterRuleBtnClick()
	{
	}

	[Token(Token = "0x600B092")]
	[Address(RVA = "0x1AF7D7C", Offset = "0x1AF7D7C", VA = "0x1AF7D7C")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600B093")]
	[Address(RVA = "0x1AFC23C", Offset = "0x1AFC23C", VA = "0x1AFC23C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600B094")]
	[Address(RVA = "0x1AFC348", Offset = "0x1AFC348", VA = "0x1AFC348")]
	private void OnRuleBtnClick()
	{
	}

	[Token(Token = "0x600B095")]
	[Address(RVA = "0x1AFB98C", Offset = "0x1AFB98C", VA = "0x1AFB98C")]
	private void RefreshModelSelection()
	{
	}

	[Token(Token = "0x600B096")]
	[Address(RVA = "0x1AF7B7C", Offset = "0x1AF7B7C", VA = "0x1AF7B7C")]
	private void SetSeasonCdnBg()
	{
	}

	[Token(Token = "0x600B097")]
	[Address(RVA = "0x1AF9654", Offset = "0x1AF9654", VA = "0x1AF9654")]
	private void RefreshCurrencyCount()
	{
	}

	[Token(Token = "0x600B098")]
	[Address(RVA = "0x1AFC6F8", Offset = "0x1AFC6F8", VA = "0x1AFC6F8", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600B099")]
	[Address(RVA = "0x1AFC820", Offset = "0x1AFC820", VA = "0x1AFC820")]
	private string GetCdnUrlSeasonAward()
	{
		return null;
	}

	[Token(Token = "0x600B09A")]
	[Address(RVA = "0x1AFBF1C", Offset = "0x1AFBF1C", VA = "0x1AFBF1C")]
	private string GetSeasonRewardBgUrl()
	{
		return null;
	}

	[Token(Token = "0x600B09B")]
	[Address(RVA = "0x1AFC980", Offset = "0x1AFC980", VA = "0x1AFC980")]
	private ResourceID GetResIdSpriteAwardRank()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B09C")]
	[Address(RVA = "0x1AFC15C", Offset = "0x1AFC15C", VA = "0x1AFC15C")]
	private bool IsReachRankThreshold()
	{
		return default(bool);
	}

	[Token(Token = "0x600B09D")]
	[Address(RVA = "0x1AFC07C", Offset = "0x1AFC07C", VA = "0x1AFC07C")]
	private bool IsSeasonOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x600B09E")]
	[Address(RVA = "0x1AFC598", Offset = "0x1AFC598", VA = "0x1AFC598")]
	private string GetCdnUrlSeasonBg()
	{
		return null;
	}

	[Token(Token = "0x600B09F")]
	[Address(RVA = "0x1AFCAEC", Offset = "0x1AFCAEC", VA = "0x1AFCAEC")]
	private uint GetSeasonAwardId()
	{
		return default(uint);
	}

	[Token(Token = "0x600B0A0")]
	[Address(RVA = "0x1AFCBCC", Offset = "0x1AFCBCC", VA = "0x1AFCBCC")]
	public void ShowClaimedResetAward()
	{
	}

	[Token(Token = "0x600B0A1")]
	[Address(RVA = "0x1AFCE60", Offset = "0x1AFCE60", VA = "0x1AFCE60")]
	private void OnViewAllBtnClicked()
	{
	}

	[Token(Token = "0x600B0A2")]
	[Address(RVA = "0x1AFD1B0", Offset = "0x1AFD1B0", VA = "0x1AFD1B0")]
	public void ShowScreenShotComponent(bool value)
	{
	}

	[Token(Token = "0x600B0A3")]
	[Address(RVA = "0x1AFD748", Offset = "0x1AFD748", VA = "0x1AFD748")]
	private void OnScreenshotStart(object[] data)
	{
	}

	[Token(Token = "0x600B0A4")]
	[Address(RVA = "0x1AFD7B4", Offset = "0x1AFD7B4", VA = "0x1AFD7B4")]
	private void OnScreenshotFinish(object[] data)
	{
	}

	[Token(Token = "0x600B0A5")]
	[Address(RVA = "0x1AFD820", Offset = "0x1AFD820", VA = "0x1AFD820")]
	private void OnExchangMallBtnClick()
	{
	}

	[Token(Token = "0x600B0A6")]
	[Address(RVA = "0x1AFDD38", Offset = "0x1AFDD38", VA = "0x1AFDD38")]
	private void OnExchangMallTokenClick()
	{
	}

	[Token(Token = "0x600B0A7")]
	[Address(RVA = "0x1AFD990", Offset = "0x1AFD990", VA = "0x1AFD990")]
	private void OnGotoMallExchangeLadderReward()
	{
	}

	[Token(Token = "0x600B0A8")]
	[Address(RVA = "0x1AFDEA8", Offset = "0x1AFDEA8", VA = "0x1AFDEA8")]
	private void OnClickSelectGameMode()
	{
	}

	[Token(Token = "0x600B0A9")]
	[Address(RVA = "0x1AFA36C", Offset = "0x1AFA36C", VA = "0x1AFA36C")]
	private void RefreshUnlockMatchView()
	{
	}

	[Token(Token = "0x600B0AA")]
	[Address(RVA = "0x1AFE1F8", Offset = "0x1AFE1F8", VA = "0x1AFE1F8")]
	private void OnResetMatchRewardClick()
	{
	}

	[Token(Token = "0x600B0AB")]
	[Address(RVA = "0x1AF9960", Offset = "0x1AF9960", VA = "0x1AF9960")]
	private void UpdatePreviewReward(DGNDKMLMLPM matchMode)
	{
	}

	[Token(Token = "0x600B0AC")]
	[Address(RVA = "0x1AFE8D4", Offset = "0x1AFE8D4", VA = "0x1AFE8D4")]
	private void OnSelectBR()
	{
	}

	[Token(Token = "0x600B0AD")]
	[Address(RVA = "0x1AFEAB4", Offset = "0x1AFEAB4", VA = "0x1AFEAB4")]
	private void OnSelectCS()
	{
	}

	[Token(Token = "0x600B0AE")]
	[Address(RVA = "0x1AFEC94", Offset = "0x1AFEC94", VA = "0x1AFEC94")]
	private void OnSelectLW()
	{
	}

	[Token(Token = "0x600B0AF")]
	[Address(RVA = "0x1AFEE98", Offset = "0x1AFEE98", VA = "0x1AFEE98")]
	private void OnSelectGameMode(object[] data)
	{
	}

	[Token(Token = "0x600B0B0")]
	[Address(RVA = "0x1AFEFAC", Offset = "0x1AFEFAC", VA = "0x1AFEFAC", Slot = "42")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B0B1")]
	[Address(RVA = "0x1AFF164", Offset = "0x1AFF164", VA = "0x1AFF164", Slot = "43")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B0B2")]
	[Address(RVA = "0x1AFF264", Offset = "0x1AFF264", VA = "0x1AFF264")]
	private static CommonRewardItemInfo _003CShowClaimedResetAward_003Em__0(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x600B0B3")]
	[Address(RVA = "0x1AFF26C", Offset = "0x1AFF26C", VA = "0x1AFF26C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B0B4")]
	[Address(RVA = "0x1AFF274", Offset = "0x1AFF274", VA = "0x1AFF274")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600B0B5")]
	[Address(RVA = "0x1AFF27C", Offset = "0x1AFF27C", VA = "0x1AFF27C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600B0B6")]
	[Address(RVA = "0x1AFF284", Offset = "0x1AFF284", VA = "0x1AFF284")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}
}
