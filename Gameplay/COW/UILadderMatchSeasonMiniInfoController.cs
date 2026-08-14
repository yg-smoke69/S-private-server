using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002173")]
internal class UILadderMatchSeasonMiniInfoController : UIBaseController, _Attribute
{
	[Token(Token = "0x2002174")]
	private sealed class _003CUpdateRoomMapItemDownloadStatus_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D208")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData mapModeData;

		[Token(Token = "0x400D209")]
		[FieldOffset(Offset = "0xC")]
		internal List<ResourceID> needDownloadRes;

		[Token(Token = "0x400D20A")]
		[FieldOffset(Offset = "0x10")]
		internal UILadderMatchSeasonMiniInfoController _0024this;

		[Token(Token = "0x600B14A")]
		[Address(RVA = "0x22D3138", Offset = "0x22D3138", VA = "0x22D3138")]
		public _003CUpdateRoomMapItemDownloadStatus_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B14B")]
		[Address(RVA = "0x22D5328", Offset = "0x22D5328", VA = "0x22D5328")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400D1EA")]
	[FieldOffset(Offset = "0x28")]
	private DGNDKMLMLPM m_ChooseLadderMatchType;

	[Token(Token = "0x400D1EB")]
	[FieldOffset(Offset = "0x2C")]
	private UILadderMatchSeasonMiniInfoView m_View;

	[Token(Token = "0x400D1EC")]
	[FieldOffset(Offset = "0x30")]
	private GameObject[] m_CSStarArray;

	[Token(Token = "0x400D1ED")]
	[FieldOffset(Offset = "0x34")]
	private GameObject[] m_CSBlackStarArray;

	[Token(Token = "0x400D1EE")]
	[FieldOffset(Offset = "0x38")]
	private Color32 m_LowPointColor;

	[Token(Token = "0x400D1EF")]
	[FieldOffset(Offset = "0x3C")]
	private Color32 m_HighPointColor;

	[Token(Token = "0x400D1F0")]
	[FieldOffset(Offset = "0x40")]
	private bool m_hideToggleButton;

	[Token(Token = "0x400D1F1")]
	[FieldOffset(Offset = "0x41")]
	private bool m_showToggle;

	[Token(Token = "0x400D1F2")]
	[FieldOffset(Offset = "0x44")]
	private UIModelPeriodicLadderMatch m_ModelLadderPeriodic;

	[Token(Token = "0x400D1F3")]
	[FieldOffset(Offset = "0x48")]
	private UIModelCSLadderMatch m_ModelLadderCS;

	[Token(Token = "0x400D1F4")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelLadderMatch m_ModelLadderBR;

	[Token(Token = "0x400D1F5")]
	[FieldOffset(Offset = "0x50")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D1F6")]
	[FieldOffset(Offset = "0x54")]
	private UIModelMapOpeningInfo m_ModelOpeningInfo;

	[Token(Token = "0x400D1F7")]
	[FieldOffset(Offset = "0x58")]
	private UIModelOptionalDownload m_ModelOptionalDownload;

	[Token(Token = "0x400D1F8")]
	[FieldOffset(Offset = "0x5C")]
	private UICenterOnChild m_wrapCenter;

	[Token(Token = "0x400D1F9")]
	[FieldOffset(Offset = "0x60")]
	private int m_LastSelectedIndex;

	[Token(Token = "0x400D1FA")]
	[FieldOffset(Offset = "0x64")]
	private List<UILadderMatchSeasonInfoMissionItemController> m_MissionItems;

	[Token(Token = "0x400D1FB")]
	[FieldOffset(Offset = "0x68")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x400D1FC")]
	[FieldOffset(Offset = "0x6C")]
	private int ScrollMissionCount;

	[Token(Token = "0x400D1FD")]
	[FieldOffset(Offset = "0x70")]
	private int AllMissionCount;

	[Token(Token = "0x400D1FE")]
	[FieldOffset(Offset = "0x74")]
	private MapModeData m_SelectedMapModeData;

	[Token(Token = "0x400D1FF")]
	private const string AnimationName = "play";

	[Token(Token = "0x400D200")]
	[FieldOffset(Offset = "0x78")]
	private RankCard m_SelectedRankCard;

	[Token(Token = "0x400D201")]
	private const string BRLADDERMATCHSEASONTIPS = "BRLADDERMATCHSEASONTIPS_";

	[Token(Token = "0x400D202")]
	private const string CSLADDERMATCHSEASONTIPS = "CSLADDERMATCHSEASONTIPS_";

	[Token(Token = "0x400D203")]
	private const string PERIODICLADDERMATCHSEASONTIPS = "PERIODICLADDERMATCHSEASONTIPS_";

	[Token(Token = "0x400D204")]
	[FieldOffset(Offset = "0x7C")]
	public UINewDownloadInfoController m_Downloader;

	[Token(Token = "0x400D205")]
	[FieldOffset(Offset = "0x80")]
	private string m_ToggleRankKey;

	[Token(Token = "0x400D206")]
	[FieldOffset(Offset = "0x84")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400D207")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<RankingTaskInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600B110")]
	[Address(RVA = "0x22C90D4", Offset = "0x22C90D4", VA = "0x22C90D4")]
	public UILadderMatchSeasonMiniInfoController()
	{
	}

	[Token(Token = "0x600B111")]
	[Address(RVA = "0x22C93B8", Offset = "0x22C93B8", VA = "0x22C93B8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B112")]
	[Address(RVA = "0x22C945C", Offset = "0x22C945C", VA = "0x22C945C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B113")]
	[Address(RVA = "0x22CA82C", Offset = "0x22CA82C", VA = "0x22CA82C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600B114")]
	[Address(RVA = "0x22CAA40", Offset = "0x22CAA40", VA = "0x22CAA40")]
	private void OnTweenFinish()
	{
	}

	[Token(Token = "0x600B115")]
	[Address(RVA = "0x22CAB80", Offset = "0x22CAB80", VA = "0x22CAB80")]
	public void SetViewData(DGNDKMLMLPM ladderMatchType)
	{
	}

	[Token(Token = "0x600B116")]
	[Address(RVA = "0x22CB080", Offset = "0x22CB080", VA = "0x22CB080")]
	private void RefreshCSData(object[] data)
	{
	}

	[Token(Token = "0x600B117")]
	[Address(RVA = "0x22CBD24", Offset = "0x22CBD24", VA = "0x22CBD24")]
	private void RefreshCSPeakRank()
	{
	}

	[Token(Token = "0x600B118")]
	[Address(RVA = "0x22CB66C", Offset = "0x22CB66C", VA = "0x22CB66C")]
	private void RefreshCSAboveHeroicRank(CSLadderRankInfo userRankInfo)
	{
	}

	[Token(Token = "0x600B119")]
	[Address(RVA = "0x22CB6D8", Offset = "0x22CB6D8", VA = "0x22CB6D8")]
	private void RefreshCSUnderHeroicRank(CSLadderRankInfo userRankInfo, CSRankData ldata)
	{
	}

	[Token(Token = "0x600B11A")]
	[Address(RVA = "0x22CD0A8", Offset = "0x22CD0A8", VA = "0x22CD0A8")]
	private void RefreshMaxRankTxt(CSLadderRankInfo userRankInfo)
	{
	}

	[Token(Token = "0x600B11B")]
	[Address(RVA = "0x22CC694", Offset = "0x22CC694", VA = "0x22CC694")]
	private void RefreshCSTopTips(bool isSeasonClosed, bool isReachHeroicRank, CSLadderRankInfo userRankInfo)
	{
	}

	[Token(Token = "0x600B11C")]
	[Address(RVA = "0x22CD28C", Offset = "0x22CD28C", VA = "0x22CD28C")]
	private void RefreshPeriodicData(object[] data)
	{
	}

	[Token(Token = "0x600B11D")]
	[Address(RVA = "0x22CAD64", Offset = "0x22CAD64", VA = "0x22CAD64")]
	private void HidePeriodicDownloader()
	{
	}

	[Token(Token = "0x600B11E")]
	[Address(RVA = "0x22CDEFC", Offset = "0x22CDEFC", VA = "0x22CDEFC")]
	private void RefreshPeriodicTipsTop(bool isSeasonClosed, CSPlayerPeriodicRankingInfoRes userRankInfo)
	{
	}

	[Token(Token = "0x600B11F")]
	[Address(RVA = "0x22CD8B0", Offset = "0x22CD8B0", VA = "0x22CD8B0")]
	private void RefreshPeriodicUnderHeroicRank(CSPlayerPeriodicRankingInfoRes userRankInfo, PeriodicRankData ldata)
	{
	}

	[Token(Token = "0x600B120")]
	[Address(RVA = "0x22CE6E4", Offset = "0x22CE6E4", VA = "0x22CE6E4")]
	private void RefreshBRData(bool playAni = true)
	{
	}

	[Token(Token = "0x600B121")]
	[Address(RVA = "0x22CE844", Offset = "0x22CE844", VA = "0x22CE844")]
	private void RefreshBRSeasonOpeningView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	[Token(Token = "0x600B122")]
	[Address(RVA = "0x22CE94C", Offset = "0x22CE94C", VA = "0x22CE94C")]
	private void RefreshBRSeasonClosedView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	[Token(Token = "0x600B123")]
	[Address(RVA = "0x22CEF54", Offset = "0x22CEF54", VA = "0x22CEF54")]
	private void RefreshBRTopTips(bool isSeasonClosed, bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	[Token(Token = "0x600B124")]
	[Address(RVA = "0x22CF704", Offset = "0x22CF704", VA = "0x22CF704")]
	private void RefreshBRSeasonOpeningRankIconView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	[Token(Token = "0x600B125")]
	[Address(RVA = "0x22CFBC0", Offset = "0x22CFBC0", VA = "0x22CFBC0")]
	private void RefreshBRSeasonOpeningScoreAndStarView(bool isReachPeakRank, LadderLevelData curLadderData)
	{
	}

	[Token(Token = "0x600B126")]
	[Address(RVA = "0x22D0498", Offset = "0x22D0498", VA = "0x22D0498")]
	private void RefreshSeasonOpeningDailyMissionData()
	{
	}

	[Token(Token = "0x600B127")]
	[Address(RVA = "0x22CC1CC", Offset = "0x22CC1CC", VA = "0x22CC1CC")]
	private void RefreshSeasonClosedDailyMissionData()
	{
	}

	[Token(Token = "0x600B128")]
	[Address(RVA = "0x22D160C", Offset = "0x22D160C", VA = "0x22D160C")]
	private void OnAutoScrollMissionItem()
	{
	}

	[Token(Token = "0x600B129")]
	[Address(RVA = "0x22D180C", Offset = "0x22D180C", VA = "0x22D180C")]
	private void GetCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x600B12A")]
	[Address(RVA = "0x22CC25C", Offset = "0x22CC25C", VA = "0x22CC25C")]
	private void RefreshStartBtnView(bool isSeasonClosed)
	{
	}

	[Token(Token = "0x600B12B")]
	[Address(RVA = "0x22CA3B0", Offset = "0x22CA3B0", VA = "0x22CA3B0")]
	private void RefreshRankCardState()
	{
	}

	[Token(Token = "0x600B12C")]
	[Address(RVA = "0x22CAEBC", Offset = "0x22CAEBC", VA = "0x22CAEBC")]
	private void RefreshRankCard()
	{
	}

	[Token(Token = "0x600B12D")]
	[Address(RVA = "0x22D1B1C", Offset = "0x22D1B1C", VA = "0x22D1B1C")]
	private void OnRankCardSelectedChange(object[] data)
	{
	}

	[Token(Token = "0x600B12E")]
	[Address(RVA = "0x22D1FCC", Offset = "0x22D1FCC", VA = "0x22D1FCC")]
	private void OnViewRankCardListClick()
	{
	}

	[Token(Token = "0x600B12F")]
	[Address(RVA = "0x22D2258", Offset = "0x22D2258", VA = "0x22D2258")]
	private void OnQuickStartBtn()
	{
	}

	[Token(Token = "0x600B130")]
	[Address(RVA = "0x22CE28C", Offset = "0x22CE28C", VA = "0x22CE28C")]
	public void UpdatePeriodicDownloaderInfo()
	{
	}

	[Token(Token = "0x600B131")]
	[Address(RVA = "0x22D2D24", Offset = "0x22D2D24", VA = "0x22D2D24")]
	public void UpdateRoomMapItemDownloadStatus(List<ResourceID> needDownloadRes, MapModeData mapModeData)
	{
	}

	[Token(Token = "0x600B132")]
	[Address(RVA = "0x22D3140", Offset = "0x22D3140", VA = "0x22D3140")]
	private void OnRuleClicked()
	{
	}

	[Token(Token = "0x600B133")]
	[Address(RVA = "0x22D32BC", Offset = "0x22D32BC", VA = "0x22D32BC")]
	private void OnDetailsBtnClick()
	{
	}

	[Token(Token = "0x600B134")]
	[Address(RVA = "0x22D34B0", Offset = "0x22D34B0", VA = "0x22D34B0")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x600B135")]
	[Address(RVA = "0x22D36DC", Offset = "0x22D36DC", VA = "0x22D36DC")]
	private void OnBtnClickCSTipsMiddle()
	{
	}

	[Token(Token = "0x600B136")]
	[Address(RVA = "0x22D3978", Offset = "0x22D3978", VA = "0x22D3978")]
	private void OnBtnClickProtectTip()
	{
	}

	[Token(Token = "0x600B137")]
	[Address(RVA = "0x22D3BC0", Offset = "0x22D3BC0", VA = "0x22D3BC0")]
	private void OnBtnClickHeroicStarTipsBtn()
	{
	}

	[Token(Token = "0x600B138")]
	[Address(RVA = "0x22D3D88", Offset = "0x22D3D88", VA = "0x22D3D88")]
	private void OnBtnClickBRTipsMiddle()
	{
	}

	[Token(Token = "0x600B139")]
	[Address(RVA = "0x22D4024", Offset = "0x22D4024", VA = "0x22D4024", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600B13A")]
	[Address(RVA = "0x22D4500", Offset = "0x22D4500", VA = "0x22D4500", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600B13B")]
	[Address(RVA = "0x22D19D4", Offset = "0x22D19D4", VA = "0x22D19D4")]
	public void RefreshToggleAndStartBtnView(bool hideToggleButton)
	{
	}

	[Token(Token = "0x600B13C")]
	[Address(RVA = "0x22D490C", Offset = "0x22D490C", VA = "0x22D490C")]
	public void RefreshToggleRankGroup()
	{
	}

	[Token(Token = "0x600B13D")]
	[Address(RVA = "0x22CC58C", Offset = "0x22CC58C", VA = "0x22CC58C")]
	private void RefreshToggleView(bool isSeasonClosed)
	{
	}

	[Token(Token = "0x600B13E")]
	[Address(RVA = "0x22D4A28", Offset = "0x22D4A28", VA = "0x22D4A28")]
	private void OnToggleRankClick()
	{
	}

	[Token(Token = "0x600B13F")]
	[Address(RVA = "0x22D4B74", Offset = "0x22D4B74", VA = "0x22D4B74")]
	public void RefreshToggleRank()
	{
	}

	[Token(Token = "0x600B140")]
	[Address(RVA = "0x22CCDD0", Offset = "0x22CCDD0", VA = "0x22CCDD0")]
	public void DelayRefreshTableUI()
	{
	}

	[Token(Token = "0x600B141")]
	[Address(RVA = "0x22D4C9C", Offset = "0x22D4C9C", VA = "0x22D4C9C", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600B142")]
	[Address(RVA = "0x22D512C", Offset = "0x22D512C", VA = "0x22D512C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600B143")]
	[Address(RVA = "0x22D51E4", Offset = "0x22D51E4", VA = "0x22D51E4")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600B144")]
	[Address(RVA = "0x22D5228", Offset = "0x22D5228", VA = "0x22D5228")]
	private void _003CRefreshSeasonOpeningDailyMissionData_003Em__1()
	{
	}

	[Token(Token = "0x600B145")]
	[Address(RVA = "0x22D528C", Offset = "0x22D528C", VA = "0x22D528C")]
	private static int _003CRefreshSeasonOpeningDailyMissionData_003Em__2(RankingTaskInfo x, RankingTaskInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x600B146")]
	[Address(RVA = "0x22D5308", Offset = "0x22D5308", VA = "0x22D5308")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B147")]
	[Address(RVA = "0x22D5310", Offset = "0x22D5310", VA = "0x22D5310")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600B148")]
	[Address(RVA = "0x22D5318", Offset = "0x22D5318", VA = "0x22D5318")]
	public void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600B149")]
	[Address(RVA = "0x22D5320", Offset = "0x22D5320", VA = "0x22D5320")]
	public void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
