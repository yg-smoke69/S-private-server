using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002063")]
public class UICupMatchController : UINavigationController, _Attribute
{
	[Token(Token = "0x2002064")]
	public enum EPage
	{
		[Token(Token = "0x400CB21")]
		None = -1,
		[Token(Token = "0x400CB22")]
		Main,
		[Token(Token = "0x400CB23")]
		Team,
		[Token(Token = "0x400CB24")]
		Course,
		[Token(Token = "0x400CB25")]
		Accomplished
	}

	[Token(Token = "0x400CB00")]
	[FieldOffset(Offset = "0x68")]
	private UICupMatchView m_View;

	[Token(Token = "0x400CB01")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelCupMatch m_ModelCupMatch;

	[Token(Token = "0x400CB02")]
	[FieldOffset(Offset = "0x70")]
	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	[Token(Token = "0x400CB03")]
	[FieldOffset(Offset = "0x74")]
	private UIModelLobbyEventBubble m_UIModelLobbyEventBubble;

	[Token(Token = "0x400CB04")]
	[FieldOffset(Offset = "0x78")]
	private CupOpenInfoDesc m_CupOpenInfo;

	[Token(Token = "0x400CB05")]
	[FieldOffset(Offset = "0x7C")]
	private CupSettingDesc m_CupSettingInfo;

	[Token(Token = "0x400CB06")]
	[FieldOffset(Offset = "0x80")]
	private CupCDNSettingDesc m_CupCDNSetting;

	[Token(Token = "0x400CB07")]
	[FieldOffset(Offset = "0x84")]
	private MapOpeningInfo m_MapInfo;

	[Token(Token = "0x400CB08")]
	[FieldOffset(Offset = "0x88")]
	private uint m_CupMatchType;

	[Token(Token = "0x400CB09")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_BtnBGGrey;

	[Token(Token = "0x400CB0A")]
	[FieldOffset(Offset = "0x90")]
	private uint m_CupMatchID;

	[Token(Token = "0x400CB0B")]
	[FieldOffset(Offset = "0x94")]
	private int m_CupMatchKey;

	[Token(Token = "0x400CB0C")]
	[FieldOffset(Offset = "0x98")]
	private bool m_NeedUpdateTeamInfo;

	[Token(Token = "0x400CB0D")]
	[FieldOffset(Offset = "0x99")]
	private bool m_AccomplisedPage;

	[Token(Token = "0x400CB0E")]
	[FieldOffset(Offset = "0x9C")]
	private Color m_StartBtnColor;

	[Token(Token = "0x400CB0F")]
	[FieldOffset(Offset = "0xAC")]
	private UINavigationData m_LastNavigationData;

	[Token(Token = "0x400CB10")]
	[FieldOffset(Offset = "0xB0")]
	private UIModelCupMatch.CupMatchOpenState m_CupMatchState;

	[Token(Token = "0x400CB11")]
	[FieldOffset(Offset = "0xB4")]
	private List<Transform> m_RewardContainerList;

	[Token(Token = "0x400CB12")]
	[FieldOffset(Offset = "0xB8")]
	private bool m_FromJoinBtn;

	[Token(Token = "0x400CB13")]
	[FieldOffset(Offset = "0xB9")]
	private bool m_TeamTabClickLogged;

	[Token(Token = "0x400CB14")]
	[FieldOffset(Offset = "0xBC")]
	private EPage m_CurSelectPage;

	[Token(Token = "0x400CB15")]
	[FieldOffset(Offset = "0xC0")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x400CB16")]
	[FieldOffset(Offset = "0xC4")]
	private UICupMatchTeamProfileSelfController m_TeamProfileSelfCtrl;

	[Token(Token = "0x400CB17")]
	[FieldOffset(Offset = "0xC8")]
	private UICupMatchCoursePageController m_CoursePageCtrl;

	[Token(Token = "0x400CB18")]
	[FieldOffset(Offset = "0xCC")]
	private UICupMatchAccomplishedController m_AccomplishedCtrl;

	[Token(Token = "0x400CB19")]
	[FieldOffset(Offset = "0xD0")]
	private Dictionary<int, UIToggleButton> m_StateBtnDict;

	[Token(Token = "0x400CB1A")]
	[FieldOffset(Offset = "0xD4")]
	private string[] m_DayInWeekStrDict;

	[Token(Token = "0x400CB1B")]
	private const float VFX_BLINK_DURATION = 2.15f;

	[Token(Token = "0x400CB1C")]
	private const string ACCOMPLISHED_KEY = "T_31_ZZ_ACCOMPLISHED_BTN";

	[Token(Token = "0x400CB1D")]
	private const string COURSE_KEY = "T_31_ZZ_COURSE_BTN";

	[Token(Token = "0x400CB1E")]
	[FieldOffset(Offset = "0xD8")]
	private List<StandardTabItemViewData> m_MainTabDataList;

	[Token(Token = "0x400CB1F")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<uint, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A59C")]
	[Address(RVA = "0x273E59C", Offset = "0x273E59C", VA = "0x273E59C")]
	public UICupMatchController()
	{
	}

	[Token(Token = "0x600A59D")]
	[Address(RVA = "0x273E668", Offset = "0x273E668", VA = "0x273E668")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A59E")]
	[Address(RVA = "0x273E710", Offset = "0x273E710", VA = "0x273E710", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A59F")]
	[Address(RVA = "0x273F84C", Offset = "0x273F84C", VA = "0x273F84C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A5A0")]
	[Address(RVA = "0x273FA7C", Offset = "0x273FA7C", VA = "0x273FA7C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600A5A1")]
	[Address(RVA = "0x274038C", Offset = "0x274038C", VA = "0x274038C")]
	private void SetTierInfo()
	{
	}

	[Token(Token = "0x600A5A2")]
	[Address(RVA = "0x274184C", Offset = "0x274184C", VA = "0x274184C", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A5A3")]
	[Address(RVA = "0x273EEBC", Offset = "0x273EEBC", VA = "0x273EEBC")]
	private void InitRewardContainer()
	{
	}

	[Token(Token = "0x600A5A4")]
	[Address(RVA = "0x273F070", Offset = "0x273F070", VA = "0x273F070")]
	private void InitLookUpDict()
	{
	}

	[Token(Token = "0x600A5A5")]
	[Address(RVA = "0x2741080", Offset = "0x2741080", VA = "0x2741080")]
	private void CreateTabs()
	{
	}

	[Token(Token = "0x600A5A6")]
	[Address(RVA = "0x2740B74", Offset = "0x2740B74", VA = "0x2740B74")]
	private void CreateTeamPage()
	{
	}

	[Token(Token = "0x600A5A7")]
	[Address(RVA = "0x2740D14", Offset = "0x2740D14", VA = "0x2740D14")]
	private void CreateCoursePage()
	{
	}

	[Token(Token = "0x600A5A8")]
	[Address(RVA = "0x2740EE4", Offset = "0x2740EE4", VA = "0x2740EE4")]
	private void CreateAccomplishedPage()
	{
	}

	[Token(Token = "0x600A5A9")]
	[Address(RVA = "0x2742040", Offset = "0x2742040", VA = "0x2742040")]
	public UICupMatchTeamProfileSelfController GetTeamCtrl()
	{
		return null;
	}

	[Token(Token = "0x600A5AA")]
	[Address(RVA = "0x27401EC", Offset = "0x27401EC", VA = "0x27401EC")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A5AB")]
	[Address(RVA = "0x2742098", Offset = "0x2742098", VA = "0x2742098")]
	private void RefreshMainPageInfo()
	{
	}

	[Token(Token = "0x600A5AC")]
	[Address(RVA = "0x27418B8", Offset = "0x27418B8", VA = "0x27418B8")]
	private void UpdateTabRedPoint()
	{
	}

	[Token(Token = "0x600A5AD")]
	[Address(RVA = "0x2742CCC", Offset = "0x2742CCC", VA = "0x2742CCC", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600A5AE")]
	[Address(RVA = "0x273FF84", Offset = "0x273FF84", VA = "0x273FF84")]
	protected void SetCDNBG()
	{
	}

	[Token(Token = "0x600A5AF")]
	[Address(RVA = "0x274283C", Offset = "0x274283C", VA = "0x274283C")]
	private void RefreshSeasonInfo()
	{
	}

	[Token(Token = "0x600A5B0")]
	[Address(RVA = "0x2742D24", Offset = "0x2742D24", VA = "0x2742D24", Slot = "44")]
	protected virtual void RefreshCupIcon()
	{
	}

	[Token(Token = "0x600A5B1")]
	[Address(RVA = "0x2740664", Offset = "0x2740664", VA = "0x2740664")]
	private void SetStartMatchBtnState()
	{
	}

	[Token(Token = "0x600A5B2")]
	[Address(RVA = "0x2740860", Offset = "0x2740860", VA = "0x2740860")]
	private void SetMainPageTeamBtnState()
	{
	}

	[Token(Token = "0x600A5B3")]
	[Address(RVA = "0x2742FAC", Offset = "0x2742FAC", VA = "0x2742FAC")]
	private string CheckCanStartMatch()
	{
		return null;
	}

	[Token(Token = "0x600A5B4")]
	[Address(RVA = "0x27429EC", Offset = "0x27429EC", VA = "0x27429EC")]
	private void RefreshNoticeBtn()
	{
	}

	[Token(Token = "0x600A5B5")]
	[Address(RVA = "0x274358C", Offset = "0x274358C", VA = "0x274358C")]
	private bool IsShowNotice()
	{
		return default(bool);
	}

	[Token(Token = "0x600A5B6")]
	[Address(RVA = "0x2743604", Offset = "0x2743604", VA = "0x2743604", Slot = "45")]
	protected virtual void AutoShowNotice()
	{
	}

	[Token(Token = "0x600A5B7")]
	[Address(RVA = "0x2743734", Offset = "0x2743734", VA = "0x2743734")]
	private void ShowNoticeWnd()
	{
	}

	[Token(Token = "0x600A5B8")]
	[Address(RVA = "0x27415D4", Offset = "0x27415D4", VA = "0x27415D4")]
	private bool IsNoticShow()
	{
		return default(bool);
	}

	[Token(Token = "0x600A5B9")]
	[Address(RVA = "0x2743CF8", Offset = "0x2743CF8", VA = "0x2743CF8")]
	private void SetCDNUrlList(List<string> cdnList, string url)
	{
	}

	[Token(Token = "0x600A5BA")]
	[Address(RVA = "0x2742AA8", Offset = "0x2742AA8", VA = "0x2742AA8")]
	private void RefreshTicket()
	{
	}

	[Token(Token = "0x600A5BB")]
	[Address(RVA = "0x2741A90", Offset = "0x2741A90", VA = "0x2741A90")]
	private void RefreshCourseRedPoint()
	{
	}

	[Token(Token = "0x600A5BC")]
	[Address(RVA = "0x2741938", Offset = "0x2741938", VA = "0x2741938")]
	private void RefreshTeamRedPoint()
	{
	}

	[Token(Token = "0x600A5BD")]
	[Address(RVA = "0x2743E1C", Offset = "0x2743E1C", VA = "0x2743E1C")]
	public void RefreshFirstReward()
	{
	}

	[Token(Token = "0x600A5BE")]
	[Address(RVA = "0x27443F4", Offset = "0x27443F4", VA = "0x27443F4", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x600A5BF")]
	[Address(RVA = "0x27444B0", Offset = "0x27444B0", VA = "0x27444B0", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x600A5C0")]
	[Address(RVA = "0x274456C", Offset = "0x274456C", VA = "0x274456C")]
	private void OnStartMatchBtnClick()
	{
	}

	[Token(Token = "0x600A5C1")]
	[Address(RVA = "0x2744A94", Offset = "0x2744A94", VA = "0x2744A94")]
	private void OnShowAllRewardBtnClick()
	{
	}

	[Token(Token = "0x600A5C2")]
	[Address(RVA = "0x2744D80", Offset = "0x2744D80", VA = "0x2744D80")]
	private void OnBtnAccomplishedClick()
	{
	}

	[Token(Token = "0x600A5C3")]
	[Address(RVA = "0x2744C04", Offset = "0x2744C04", VA = "0x2744C04")]
	private void ShowAllReward()
	{
	}

	[Token(Token = "0x600A5C4")]
	[Address(RVA = "0x2745440", Offset = "0x2745440", VA = "0x2745440")]
	private void OnSeasonTipsBtnClick()
	{
	}

	[Token(Token = "0x600A5C5")]
	[Address(RVA = "0x2745EC8", Offset = "0x2745EC8", VA = "0x2745EC8")]
	private void OnNoticyBtnClick()
	{
	}

	[Token(Token = "0x600A5C6")]
	[Address(RVA = "0x2746038", Offset = "0x2746038", VA = "0x2746038")]
	private void OnMapModeSelecteSuccess(object[] param)
	{
	}

	[Token(Token = "0x600A5C7")]
	[Address(RVA = "0x2746134", Offset = "0x2746134", VA = "0x2746134")]
	public void OnBtnMainPageClick()
	{
	}

	[Token(Token = "0x600A5C8")]
	[Address(RVA = "0x274666C", Offset = "0x274666C", VA = "0x274666C")]
	public void OnBtnTeamPageClick()
	{
	}

	[Token(Token = "0x600A5C9")]
	[Address(RVA = "0x2746BF0", Offset = "0x2746BF0", VA = "0x2746BF0")]
	public void OnBtnCourseClick()
	{
	}

	[Token(Token = "0x600A5CA")]
	[Address(RVA = "0x2746D3C", Offset = "0x2746D3C", VA = "0x2746D3C")]
	private void ShowCupMatchRecruitWnd(object[] param)
	{
	}

	[Token(Token = "0x600A5CB")]
	[Address(RVA = "0x2746E84", Offset = "0x2746E84", VA = "0x2746E84")]
	private void OnTicketClick(object[] param)
	{
	}

	[Token(Token = "0x600A5CC")]
	[Address(RVA = "0x2747180", Offset = "0x2747180", VA = "0x2747180")]
	public void GotoTeamPage()
	{
	}

	[Token(Token = "0x600A5CD")]
	[Address(RVA = "0x2747294", Offset = "0x2747294", VA = "0x2747294")]
	public void GotoPage(EPage page)
	{
	}

	[Token(Token = "0x600A5CE")]
	[Address(RVA = "0x2746390", Offset = "0x2746390", VA = "0x2746390")]
	private void ShowMainPage()
	{
	}

	[Token(Token = "0x600A5CF")]
	[Address(RVA = "0x2746A4C", Offset = "0x2746A4C", VA = "0x2746A4C")]
	private void ShowTeamPage()
	{
	}

	[Token(Token = "0x600A5D0")]
	[Address(RVA = "0x2744DF8", Offset = "0x2744DF8", VA = "0x2744DF8")]
	private void ShowCoursePage()
	{
	}

	[Token(Token = "0x600A5D1")]
	[Address(RVA = "0x27451AC", Offset = "0x27451AC", VA = "0x27451AC")]
	private void ShowAccomplisedPage()
	{
	}

	[Token(Token = "0x600A5D2")]
	[Address(RVA = "0x27477A4", Offset = "0x27477A4", VA = "0x27477A4")]
	private void OnBtnRecuitClick()
	{
	}

	[Token(Token = "0x600A5D3")]
	[Address(RVA = "0x27478E4", Offset = "0x27478E4", VA = "0x27478E4", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A5D4")]
	[Address(RVA = "0x2747CA8", Offset = "0x2747CA8", VA = "0x2747CA8", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A5D5")]
	[Address(RVA = "0x2747D40", Offset = "0x2747D40", VA = "0x2747D40")]
	private string _003CRefreshMainPageInfo_003Em__0(uint item)
	{
		return null;
	}

	[Token(Token = "0x600A5D6")]
	[Address(RVA = "0x2747D8C", Offset = "0x2747D8C", VA = "0x2747D8C")]
	private bool _003CSetCDNBG_003Em__1(AdvertDesc ad)
	{
		return default(bool);
	}

	[Token(Token = "0x600A5D7")]
	[Address(RVA = "0x2747DC4", Offset = "0x2747DC4", VA = "0x2747DC4")]
	private void _003COnStartMatchBtnClick_003Em__2()
	{
	}

	[Token(Token = "0x600A5D8")]
	[Address(RVA = "0x2747E08", Offset = "0x2747E08", VA = "0x2747E08")]
	private void _003COnStartMatchBtnClick_003Em__3()
	{
	}

	[Token(Token = "0x600A5D9")]
	[Address(RVA = "0x2747E4C", Offset = "0x2747E4C", VA = "0x2747E4C")]
	private static string _003COnSeasonTipsBtnClick_003Em__4(uint day)
	{
		return null;
	}

	[Token(Token = "0x600A5DA")]
	[Address(RVA = "0x2747E70", Offset = "0x2747E70", VA = "0x2747E70")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A5DB")]
	[Address(RVA = "0x2747E78", Offset = "0x2747E78", VA = "0x2747E78")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A5DC")]
	[Address(RVA = "0x2747E80", Offset = "0x2747E80", VA = "0x2747E80")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600A5DD")]
	[Address(RVA = "0x2747E88", Offset = "0x2747E88", VA = "0x2747E88")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A5DE")]
	[Address(RVA = "0x2747E90", Offset = "0x2747E90", VA = "0x2747E90")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x600A5DF")]
	[Address(RVA = "0x2747E98", Offset = "0x2747E98", VA = "0x2747E98")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x600A5E0")]
	[Address(RVA = "0x2747EA0", Offset = "0x2747EA0", VA = "0x2747EA0")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
