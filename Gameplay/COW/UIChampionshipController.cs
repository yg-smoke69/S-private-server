using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001FFC")]
public class UIChampionshipController : UINavigationController, _Attribute
{
	[Token(Token = "0x2001FFD")]
	public enum EPage
	{
		[Token(Token = "0x400C917")]
		Main,
		[Token(Token = "0x400C918")]
		Team,
		[Token(Token = "0x400C919")]
		Ladder
	}

	[Token(Token = "0x2001FFE")]
	public enum ETeamSubPage
	{
		[Token(Token = "0x400C91B")]
		Info,
		[Token(Token = "0x400C91C")]
		Reward
	}

	[Token(Token = "0x2001FFF")]
	public class LeaderBoardEasyList : _Attribute
	{
		[Token(Token = "0x400C91D")]
		[FieldOffset(Offset = "0x8")]
		private UIChampionshipController championshipController;

		[Token(Token = "0x400C91E")]
		[FieldOffset(Offset = "0xC")]
		public uint championshipType;

		[Token(Token = "0x600A1AC")]
		[Address(RVA = "0x28219B8", Offset = "0x28219B8", VA = "0x28219B8")]
		public LeaderBoardEasyList(UIChampionshipController championshipController)
		{
		}

		[Token(Token = "0x600A1AD")]
		[Address(RVA = "0x28219D8", Offset = "0x28219D8", VA = "0x28219D8", Slot = "5")]
		public void CloseItemController(UIEasyListItemController itemController)
		{
		}

		[Token(Token = "0x600A1AE")]
		[Address(RVA = "0x2821A54", Offset = "0x2821A54", VA = "0x2821A54", Slot = "4")]
		public UIEasyListItemController OpenItemController(Transform parent)
		{
			return null;
		}
	}

	[Token(Token = "0x400C8F2")]
	[FieldOffset(Offset = "0x68")]
	private UIChampionshipView m_View;

	[Token(Token = "0x400C8F3")]
	[FieldOffset(Offset = "0x6C")]
	protected UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400C8F4")]
	[FieldOffset(Offset = "0x70")]
	protected ChampionshipInfo m_ChampionshipInfo;

	[Token(Token = "0x400C8F5")]
	[FieldOffset(Offset = "0x74")]
	protected ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	[Token(Token = "0x400C8F6")]
	[FieldOffset(Offset = "0x78")]
	protected ChampionshipSettingDesc m_ChampionshipSettingInfo;

	[Token(Token = "0x400C8F7")]
	[FieldOffset(Offset = "0x7C")]
	private UIModelMapOpeningInfo m_ModelMapOpeningInfo;

	[Token(Token = "0x400C8F8")]
	[FieldOffset(Offset = "0x80")]
	private UIModelLeaderBoard m_ModelLeaderBoard;

	[Token(Token = "0x400C8F9")]
	[FieldOffset(Offset = "0x84")]
	protected uint m_ChampionshipType;

	[Token(Token = "0x400C8FA")]
	[FieldOffset(Offset = "0x88")]
	private MapOpeningInfo m_MapInfo;

	[Token(Token = "0x400C8FB")]
	[FieldOffset(Offset = "0x8C")]
	private uint m_BtnBGGrey;

	[Token(Token = "0x400C8FC")]
	[FieldOffset(Offset = "0x90")]
	protected uint m_ChampionshipID;

	[Token(Token = "0x400C8FD")]
	[FieldOffset(Offset = "0x94")]
	private bool m_NeedUpdateCSInfo;

	[Token(Token = "0x400C8FE")]
	[FieldOffset(Offset = "0x98")]
	private Color m_StartBtnColor;

	[Token(Token = "0x400C8FF")]
	[FieldOffset(Offset = "0xA8")]
	private UINavigationData m_LastNavigationData;

	[Token(Token = "0x400C900")]
	[FieldOffset(Offset = "0xAC")]
	private UIModelChampionship.ChampionshipOpenState m_ChampionshipState;

	[Token(Token = "0x400C901")]
	[FieldOffset(Offset = "0xB0")]
	private List<Transform> m_RewardContainerList;

	[Token(Token = "0x400C902")]
	[FieldOffset(Offset = "0xB4")]
	private List<Transform> m_NewRewardContainerList;

	[Token(Token = "0x400C903")]
	[FieldOffset(Offset = "0xB8")]
	private List<Transform> m_RewardParentContainerList;

	[Token(Token = "0x400C904")]
	[FieldOffset(Offset = "0xBC")]
	private List<Transform> m_ChampionshipRewardContainerList;

	[Token(Token = "0x400C905")]
	[FieldOffset(Offset = "0xC0")]
	private int m_LastRankPos;

	[Token(Token = "0x400C906")]
	[FieldOffset(Offset = "0xC4")]
	private bool m_NeedPlayRewardAnim;

	[Token(Token = "0x400C907")]
	[FieldOffset(Offset = "0xC5")]
	private bool m_TransitionAnimFinish;

	[Token(Token = "0x400C908")]
	[FieldOffset(Offset = "0xC8")]
	private LeaderBoardEasyList m_LeaderBoardEasyList;

	[Token(Token = "0x400C909")]
	[FieldOffset(Offset = "0xCC")]
	private UIChampionshipLeaderBoardItem m_LeaderBoardSelfItem;

	[Token(Token = "0x400C90A")]
	[FieldOffset(Offset = "0xD0")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x400C90B")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_FromJoinBtn;

	[Token(Token = "0x400C90C")]
	[FieldOffset(Offset = "0xD5")]
	private bool m_TeamTabClickLogged;

	[Token(Token = "0x400C90D")]
	[FieldOffset(Offset = "0xD8")]
	private string m_MatchStateClockTips;

	[Token(Token = "0x400C90E")]
	[FieldOffset(Offset = "0xDC")]
	private EPage m_CurSelectPage;

	[Token(Token = "0x400C90F")]
	[FieldOffset(Offset = "0xE0")]
	private UIChampionshipTeamProfileSelfController m_TeamProfileSelfCtrl;

	[Token(Token = "0x400C910")]
	[FieldOffset(Offset = "0xE4")]
	private UICountDownController m_MatchOpenCountDownCtrl;

	[Token(Token = "0x400C911")]
	[FieldOffset(Offset = "0xE8")]
	private Dictionary<int, UIToggleButton> m_StateBtnDict;

	[Token(Token = "0x400C912")]
	[FieldOffset(Offset = "0xEC")]
	private string[] m_DayInWeekStrDict;

	[Token(Token = "0x400C913")]
	private const float VFX_BLINK_DURATION = 2.15f;

	[Token(Token = "0x400C914")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_IsMatchEnd;

	[Token(Token = "0x400C915")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<uint, string> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600A168")]
	[Address(RVA = "0x145E74C", Offset = "0x145E74C", VA = "0x145E74C")]
	public UIChampionshipController()
	{
	}

	[Token(Token = "0x600A169")]
	[Address(RVA = "0x145E868", Offset = "0x145E868", VA = "0x145E868")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A16A")]
	[Address(RVA = "0x145E90C", Offset = "0x145E90C", VA = "0x145E90C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A16B")]
	[Address(RVA = "0x145FFF8", Offset = "0x145FFF8", VA = "0x145FFF8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A16C")]
	[Address(RVA = "0x146024C", Offset = "0x146024C", VA = "0x146024C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600A16D")]
	[Address(RVA = "0x1461CD8", Offset = "0x1461CD8", VA = "0x1461CD8", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x600A16E")]
	[Address(RVA = "0x145F308", Offset = "0x145F308", VA = "0x145F308")]
	private void InitRewardContainer()
	{
	}

	[Token(Token = "0x600A16F")]
	[Address(RVA = "0x145F81C", Offset = "0x145F81C", VA = "0x145F81C")]
	private void InitLookUpDict()
	{
	}

	[Token(Token = "0x600A170")]
	[Address(RVA = "0x14613CC", Offset = "0x14613CC", VA = "0x14613CC")]
	private void CreateTabs()
	{
	}

	[Token(Token = "0x600A171")]
	[Address(RVA = "0x1461138", Offset = "0x1461138", VA = "0x1461138")]
	private void CreateTeamPage()
	{
	}

	[Token(Token = "0x600A172")]
	[Address(RVA = "0x1461DBC", Offset = "0x1461DBC", VA = "0x1461DBC")]
	public UIChampionshipTeamProfileSelfController GetTeamCtrl()
	{
		return null;
	}

	[Token(Token = "0x600A173")]
	[Address(RVA = "0x1460808", Offset = "0x1460808", VA = "0x1460808")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600A174")]
	[Address(RVA = "0x1462D78", Offset = "0x1462D78", VA = "0x1462D78")]
	private void RefreshMatchStateInfo()
	{
	}

	[Token(Token = "0x600A175")]
	[Address(RVA = "0x1461E14", Offset = "0x1461E14", VA = "0x1461E14")]
	private void RefreshMainPageInfo()
	{
	}

	[Token(Token = "0x600A176")]
	[Address(RVA = "0x1461D44", Offset = "0x1461D44", VA = "0x1461D44")]
	private void UpdateTabRedPoint()
	{
	}

	[Token(Token = "0x600A177")]
	[Address(RVA = "0x14606C8", Offset = "0x14606C8", VA = "0x14606C8")]
	protected void SetCDNBG()
	{
	}

	[Token(Token = "0x600A178")]
	[Address(RVA = "0x1463468", Offset = "0x1463468", VA = "0x1463468")]
	private void RequestLeaderBoardFriend(bool force)
	{
	}

	[Token(Token = "0x600A179")]
	[Address(RVA = "0x14634C4", Offset = "0x14634C4", VA = "0x14634C4")]
	private void RequestLeaderBoardRegion(bool force)
	{
	}

	[Token(Token = "0x600A17A")]
	[Address(RVA = "0x14636E8", Offset = "0x14636E8", VA = "0x14636E8")]
	private void RefreshLeardBoard()
	{
	}

	[Token(Token = "0x600A17B")]
	[Address(RVA = "0x14639E8", Offset = "0x14639E8", VA = "0x14639E8")]
	private void RefreshSelfLeardBoard()
	{
	}

	[Token(Token = "0x600A17C")]
	[Address(RVA = "0x1463B08", Offset = "0x1463B08", VA = "0x1463B08")]
	private void RefreshGameResult()
	{
	}

	[Token(Token = "0x600A17D")]
	[Address(RVA = "0x1462AB8", Offset = "0x1462AB8", VA = "0x1462AB8")]
	private void RefreshSeasonInfo()
	{
	}

	[Token(Token = "0x600A17E")]
	[Address(RVA = "0x14645F4", Offset = "0x14645F4", VA = "0x14645F4", Slot = "44")]
	protected virtual void RefreshCupIcon()
	{
	}

	[Token(Token = "0x600A17F")]
	[Address(RVA = "0x1464A04", Offset = "0x1464A04", VA = "0x1464A04")]
	private void RefreshRankReward()
	{
	}

	[Token(Token = "0x600A180")]
	[Address(RVA = "0x14633D0", Offset = "0x14633D0", VA = "0x14633D0")]
	private void SetRankReward(int rank, List<Transform> rewardContainerList, bool itemActive = true, [Optional] List<Transform> parentContainerList)
	{
	}

	[Token(Token = "0x600A181")]
	[Address(RVA = "0x1464BD4", Offset = "0x1464BD4", VA = "0x1464BD4")]
	private bool CheckRankRangUp(int rankBefore, int rankNow)
	{
		return default(bool);
	}

	[Token(Token = "0x600A182")]
	[Address(RVA = "0x1464D48", Offset = "0x1464D48", VA = "0x1464D48")]
	private void RefreshPosReward(int rank, List<Transform> rewardContainerList, bool itemActive = true, [Optional] List<Transform> parentContainerList)
	{
	}

	[Token(Token = "0x600A183")]
	[Address(RVA = "0x1460AA0", Offset = "0x1460AA0", VA = "0x1460AA0")]
	private void SetStartMatchBtnState()
	{
	}

	[Token(Token = "0x600A184")]
	[Address(RVA = "0x1460C9C", Offset = "0x1460C9C", VA = "0x1460C9C")]
	private void SetMainPageTeamBtnState()
	{
	}

	[Token(Token = "0x600A185")]
	[Address(RVA = "0x1465408", Offset = "0x1465408", VA = "0x1465408")]
	private string CheckCanStartMatch()
	{
		return null;
	}

	[Token(Token = "0x600A186")]
	[Address(RVA = "0x1465AD4", Offset = "0x1465AD4", VA = "0x1465AD4")]
	protected object GetView()
	{
		return null;
	}

	[Token(Token = "0x600A187")]
	[Address(RVA = "0x1462CBC", Offset = "0x1462CBC", VA = "0x1462CBC")]
	private void RefreshNoticeBtn()
	{
	}

	[Token(Token = "0x600A188")]
	[Address(RVA = "0x1465B2C", Offset = "0x1465B2C", VA = "0x1465B2C")]
	private bool ShowNotice()
	{
		return default(bool);
	}

	[Token(Token = "0x600A189")]
	[Address(RVA = "0x1465BA4", Offset = "0x1465BA4", VA = "0x1465BA4", Slot = "45")]
	protected virtual void AutoShowNotice()
	{
	}

	[Token(Token = "0x600A18A")]
	[Address(RVA = "0x1465CF0", Offset = "0x1465CF0", VA = "0x1465CF0")]
	private void ShowNoticeWnd()
	{
	}

	[Token(Token = "0x600A18B")]
	[Address(RVA = "0x14662D0", Offset = "0x14662D0", VA = "0x14662D0")]
	private void SetCDNUrlList(List<string> cdnList, string url)
	{
	}

	[Token(Token = "0x600A18C")]
	[Address(RVA = "0x1462E3C", Offset = "0x1462E3C", VA = "0x1462E3C")]
	private void RefreshChampionReward()
	{
	}

	[Token(Token = "0x600A18D")]
	[Address(RVA = "0x14663F4", Offset = "0x14663F4", VA = "0x14663F4")]
	private void OnStartMatchBtnClick()
	{
	}

	[Token(Token = "0x600A18E")]
	[Address(RVA = "0x14669E8", Offset = "0x14669E8", VA = "0x14669E8")]
	private void OnShowAllRewardBtnClick()
	{
	}

	[Token(Token = "0x600A18F")]
	[Address(RVA = "0x1466B8C", Offset = "0x1466B8C", VA = "0x1466B8C")]
	private void OnGameStatsBtnClick()
	{
	}

	[Token(Token = "0x600A190")]
	[Address(RVA = "0x1466ECC", Offset = "0x1466ECC", VA = "0x1466ECC")]
	private void OnSeasonTipsBtnClick()
	{
	}

	[Token(Token = "0x600A191")]
	[Address(RVA = "0x1467954", Offset = "0x1467954", VA = "0x1467954")]
	private void OnNoticyBtnClick()
	{
	}

	[Token(Token = "0x600A192")]
	[Address(RVA = "0x14679B4", Offset = "0x14679B4", VA = "0x14679B4")]
	private void OnMapModeSelecteSuccess(object[] param)
	{
	}

	[Token(Token = "0x600A193")]
	[Address(RVA = "0x1467AB0", Offset = "0x1467AB0", VA = "0x1467AB0")]
	private void AnimationEventHandler(object[] data)
	{
	}

	[Token(Token = "0x600A194")]
	[Address(RVA = "0x1467D4C", Offset = "0x1467D4C", VA = "0x1467D4C")]
	public void OnBtnMainPageClick()
	{
	}

	[Token(Token = "0x600A195")]
	[Address(RVA = "0x1467F58", Offset = "0x1467F58", VA = "0x1467F58")]
	public void OnBtnTeamPageClick()
	{
	}

	[Token(Token = "0x600A196")]
	[Address(RVA = "0x14683D8", Offset = "0x14683D8", VA = "0x14683D8")]
	public void OnBtnLadderPageClick()
	{
	}

	[Token(Token = "0x600A197")]
	[Address(RVA = "0x146862C", Offset = "0x146862C", VA = "0x146862C")]
	public void OnBtnMainPageSignUpClick()
	{
	}

	[Token(Token = "0x600A198")]
	[Address(RVA = "0x14686AC", Offset = "0x14686AC", VA = "0x14686AC")]
	private void ShowChampionshipRecruitWnd(object[] param)
	{
	}

	[Token(Token = "0x600A199")]
	[Address(RVA = "0x14687F4", Offset = "0x14687F4", VA = "0x14687F4")]
	private void GotoTeamPage()
	{
	}

	[Token(Token = "0x600A19A")]
	[Address(RVA = "0x1468884", Offset = "0x1468884", VA = "0x1468884")]
	private void GotoLadderPage()
	{
	}

	[Token(Token = "0x600A19B")]
	[Address(RVA = "0x1467E18", Offset = "0x1467E18", VA = "0x1467E18")]
	private void ShowMainPage()
	{
	}

	[Token(Token = "0x600A19C")]
	[Address(RVA = "0x146828C", Offset = "0x146828C", VA = "0x146828C")]
	private void ShowTeamPage()
	{
	}

	[Token(Token = "0x600A19D")]
	[Address(RVA = "0x14684A4", Offset = "0x14684A4", VA = "0x14684A4")]
	private void ShowLadderPage()
	{
	}

	[Token(Token = "0x600A19E")]
	[Address(RVA = "0x1468904", Offset = "0x1468904", VA = "0x1468904")]
	private void OnBtnRecuitClick()
	{
	}

	[Token(Token = "0x600A19F")]
	[Address(RVA = "0x1468A1C", Offset = "0x1468A1C", VA = "0x1468A1C", Slot = "42")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600A1A0")]
	[Address(RVA = "0x1468CAC", Offset = "0x1468CAC", VA = "0x1468CAC", Slot = "43")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600A1A1")]
	[Address(RVA = "0x1468D68", Offset = "0x1468D68", VA = "0x1468D68")]
	private void _003COnUIInit_003Em__0(UIToggleButton e)
	{
	}

	[Token(Token = "0x600A1A2")]
	[Address(RVA = "0x1468D84", Offset = "0x1468D84", VA = "0x1468D84")]
	private void _003CCreateTeamPage_003Em__1()
	{
	}

	[Token(Token = "0x600A1A3")]
	[Address(RVA = "0x1468DB8", Offset = "0x1468DB8", VA = "0x1468DB8")]
	private string _003CRefreshMainPageInfo_003Em__2(uint item)
	{
		return null;
	}

	[Token(Token = "0x600A1A4")]
	[Address(RVA = "0x1468ECC", Offset = "0x1468ECC", VA = "0x1468ECC")]
	private void _003COnStartMatchBtnClick_003Em__3()
	{
	}

	[Token(Token = "0x600A1A5")]
	[Address(RVA = "0x1468F10", Offset = "0x1468F10", VA = "0x1468F10")]
	private void _003COnStartMatchBtnClick_003Em__4()
	{
	}

	[Token(Token = "0x600A1A6")]
	[Address(RVA = "0x1468F54", Offset = "0x1468F54", VA = "0x1468F54")]
	private void _003COnStartMatchBtnClick_003Em__5()
	{
	}

	[Token(Token = "0x600A1A7")]
	[Address(RVA = "0x1468F98", Offset = "0x1468F98", VA = "0x1468F98")]
	private static string _003COnSeasonTipsBtnClick_003Em__6(uint day)
	{
		return null;
	}

	[Token(Token = "0x600A1A8")]
	[Address(RVA = "0x1468FBC", Offset = "0x1468FBC", VA = "0x1468FBC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600A1A9")]
	[Address(RVA = "0x1468FC4", Offset = "0x1468FC4", VA = "0x1468FC4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A1AA")]
	[Address(RVA = "0x1468FCC", Offset = "0x1468FCC", VA = "0x1468FCC")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x600A1AB")]
	[Address(RVA = "0x1468FD4", Offset = "0x1468FD4", VA = "0x1468FD4")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}
}
