using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20028F9")]
public class UILeaderBoardNewController : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x20028FA")]
	private enum EStyle
	{
		[Token(Token = "0x400FC46")]
		Short,
		[Token(Token = "0x400FC47")]
		Long
	}

	[Token(Token = "0x20028FB")]
	public enum DeepLinkLayer
	{
		[Token(Token = "0x400FC49")]
		L0,
		[Token(Token = "0x400FC4A")]
		L1,
		[Token(Token = "0x400FC4B")]
		L2,
		[Token(Token = "0x400FC4C")]
		L3
	}

	[Token(Token = "0x20028FC")]
	private sealed class _003CNavigationToLeaderBoard_003Ec__AnonStorey0
	{
		[Token(Token = "0x400FC4D")]
		[FieldOffset(Offset = "0x8")]
		internal string fliter1;

		[Token(Token = "0x601038E")]
		[Address(RVA = "0x1A991F4", Offset = "0x1A991F4", VA = "0x1A991F4")]
		public _003CNavigationToLeaderBoard_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601038F")]
		[Address(RVA = "0x1AA2C3C", Offset = "0x1AA2C3C", VA = "0x1AA2C3C")]
		internal bool _003C_003Em__0(TabInfo tabinfo)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400FBF9")]
	[FieldOffset(Offset = "0x7C")]
	private UILeaderBoardNewView m_View;

	[Token(Token = "0x400FBFA")]
	[FieldOffset(Offset = "0x80")]
	private UINavigationData m_NavData;

	[Token(Token = "0x400FBFB")]
	[FieldOffset(Offset = "0x84")]
	private UIModelLeaderBoard m_ModelLeaderBoard;

	[Token(Token = "0x400FBFC")]
	[FieldOffset(Offset = "0x88")]
	public bool m_LeaderBoardMenuCreated;

	[Token(Token = "0x400FBFD")]
	[FieldOffset(Offset = "0x8C")]
	private int m_RequestPropIDs;

	[Token(Token = "0x400FBFE")]
	[FieldOffset(Offset = "0x90")]
	private Action m_RefreshList;

	[Token(Token = "0x400FBFF")]
	[FieldOffset(Offset = "0x94")]
	private UILeaderBoardItemNewController m_SelfRankUI;

	[Token(Token = "0x400FC00")]
	[FieldOffset(Offset = "0x98")]
	private UILeaderBoardItemNewController.DisplayType m_ListItemDisplayType;

	[Token(Token = "0x400FC01")]
	[FieldOffset(Offset = "0x9C")]
	private string m_DeepLink;

	[Token(Token = "0x400FC02")]
	[FieldOffset(Offset = "0xA0")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400FC03")]
	[FieldOffset(Offset = "0xA4")]
	private UIModelAvatarProfile m_ModelAvatarProfile;

	[Token(Token = "0x400FC04")]
	[FieldOffset(Offset = "0xA8")]
	private UIStandardDrawerTabController m_DrawerTabCtrl;

	[Token(Token = "0x400FC05")]
	[FieldOffset(Offset = "0xAC")]
	private List<UIPopMenuLeaderBoardControler> m_PopMenusList;

	[Token(Token = "0x400FC06")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<string, Action> m_DicCallBack;

	[Token(Token = "0x400FC07")]
	[FieldOffset(Offset = "0xB4")]
	private List<string> m_Fliters;

	[Token(Token = "0x400FC08")]
	[FieldOffset(Offset = "0xB8")]
	private Dictionary<string, List<FliterData>> m_DicFliterData;

	[Token(Token = "0x400FC09")]
	[FieldOffset(Offset = "0xBC")]
	private List<TabInfo> m_TabList;

	[Token(Token = "0x400FC0A")]
	[FieldOffset(Offset = "0xC0")]
	private int m_BGWidth1;

	[Token(Token = "0x400FC0B")]
	[FieldOffset(Offset = "0xC4")]
	private int m_BGWidth2;

	[Token(Token = "0x400FC0C")]
	[FieldOffset(Offset = "0xC8")]
	private EStyle m_CurrStyle;

	[Token(Token = "0x400FC0D")]
	[FieldOffset(Offset = "0xD0")]
	private ulong m_SelectedAccountID;

	[Token(Token = "0x400FC0E")]
	[FieldOffset(Offset = "0xD8")]
	private bool m_InitedBGWidth;

	[Token(Token = "0x400FC0F")]
	[FieldOffset(Offset = "0xDC")]
	private UIRoot uiRoot;

	[Token(Token = "0x400FC10")]
	public const string DL_Rank = "Rank";

	[Token(Token = "0x400FC11")]
	public const string DL_Casual = "Casual";

	[Token(Token = "0x400FC12")]
	public const string DL_CSRank = "CSRank";

	[Token(Token = "0x400FC13")]
	public const string DL_Team = "Team";

	[Token(Token = "0x400FC14")]
	public const string DL_Guild = "Guild";

	[Token(Token = "0x400FC15")]
	public const string DL_Badges = "Badges";

	[Token(Token = "0x400FC16")]
	public const string DL_Friend = "Friend";

	[Token(Token = "0x400FC17")]
	public const string DL_Region = "Region";

	[Token(Token = "0x400FC18")]
	public const string DL_Global = "Global";

	[Token(Token = "0x400FC19")]
	public const string DL_FFC = "FFC";

	[Token(Token = "0x400FC1A")]
	public const string DL_ThirdParty = "Third Party";

	[Token(Token = "0x400FC1B")]
	public const string DL_Kill = "Kill";

	[Token(Token = "0x400FC1C")]
	public const string DL_Win = "Win";

	[Token(Token = "0x400FC1D")]
	public const string DL_Score = "Score";

	[Token(Token = "0x400FC1E")]
	public const string DL_GuildWeek = "GuildWeek";

	[Token(Token = "0x400FC1F")]
	public const string DL_GuildTotal = "GuildTotal";

	[Token(Token = "0x400FC20")]
	public const string DL_SOLO = "Solo";

	[Token(Token = "0x400FC21")]
	public const string DL_DUO = "Duo";

	[Token(Token = "0x400FC22")]
	public const string DL_SQUA = "Squa";

	[Token(Token = "0x400FC23")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string DL_RankFriendKillSOLO;

	[Token(Token = "0x400FC24")]
	[FieldOffset(Offset = "0x4")]
	public static readonly string DL_RankFriendKillDUO;

	[Token(Token = "0x400FC25")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string DL_RankFriendKillSQUA;

	[Token(Token = "0x400FC26")]
	[FieldOffset(Offset = "0xC")]
	public static readonly string DL_RankFriendWinSOLO;

	[Token(Token = "0x400FC27")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string DL_RankFriendWinDUO;

	[Token(Token = "0x400FC28")]
	[FieldOffset(Offset = "0x14")]
	public static readonly string DL_RankFriendWinSQUA;

	[Token(Token = "0x400FC29")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string DL_RankRegionKillSOLO;

	[Token(Token = "0x400FC2A")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly string DL_RankRegionKillDUO;

	[Token(Token = "0x400FC2B")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string DL_RankRegionKillSQUA;

	[Token(Token = "0x400FC2C")]
	[FieldOffset(Offset = "0x24")]
	public static readonly string DL_RankRegionWinSOLO;

	[Token(Token = "0x400FC2D")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string DL_RankRegionWinDUO;

	[Token(Token = "0x400FC2E")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly string DL_RankRegionWinSQUA;

	[Token(Token = "0x400FC2F")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string DL_CasualFriendKillSOLO;

	[Token(Token = "0x400FC30")]
	[FieldOffset(Offset = "0x34")]
	public static readonly string DL_CasualFriendKillDUO;

	[Token(Token = "0x400FC31")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string DL_CasualFriendKillSQUA;

	[Token(Token = "0x400FC32")]
	[FieldOffset(Offset = "0x3C")]
	public static readonly string DL_CasualFriendWinSOLO;

	[Token(Token = "0x400FC33")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string DL_CasualFriendWinDUO;

	[Token(Token = "0x400FC34")]
	[FieldOffset(Offset = "0x44")]
	public static readonly string DL_CasualFriendWinSQUA;

	[Token(Token = "0x400FC35")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string DL_CSRankFriendKill;

	[Token(Token = "0x400FC36")]
	[FieldOffset(Offset = "0x4C")]
	public static readonly string DL_CSRankFriendWin;

	[Token(Token = "0x400FC37")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string DL_CSRankRegionKill;

	[Token(Token = "0x400FC38")]
	[FieldOffset(Offset = "0x54")]
	public static readonly string DL_CSRankRegionWin;

	[Token(Token = "0x400FC39")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string DL_TeamFFCKill;

	[Token(Token = "0x400FC3A")]
	[FieldOffset(Offset = "0x5C")]
	public static readonly string DL_TeamFFCScore;

	[Token(Token = "0x400FC3B")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string DL_TeamThirdPartyKill;

	[Token(Token = "0x400FC3C")]
	[FieldOffset(Offset = "0x64")]
	public static readonly string DL_TeamThirdPartyScore;

	[Token(Token = "0x400FC3D")]
	[FieldOffset(Offset = "0x68")]
	public static readonly string DL_GuildRegionWeek;

	[Token(Token = "0x400FC3E")]
	[FieldOffset(Offset = "0x6C")]
	public static readonly string DL_GuildRegionTotal;

	[Token(Token = "0x400FC3F")]
	[FieldOffset(Offset = "0x70")]
	public static readonly string DL_GuildGlobal;

	[Token(Token = "0x400FC40")]
	[FieldOffset(Offset = "0x74")]
	public static readonly string DL_EPBadgesFriend;

	[Token(Token = "0x400FC41")]
	[FieldOffset(Offset = "0x78")]
	public static readonly string DL_EPBadgesRegion;

	[Token(Token = "0x400FC42")]
	[FieldOffset(Offset = "0x7C")]
	public static readonly string DL_EPBadgesGlobal;

	[Token(Token = "0x400FC43")]
	[FieldOffset(Offset = "0xE0")]
	public LeaderBoardInfo m_SelectedInfo;

	[Token(Token = "0x400FC44")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_ClanLocalWeekSelected;

	[Token(Token = "0x6010318")]
	[Address(RVA = "0x1A8EFCC", Offset = "0x1A8EFCC", VA = "0x1A8EFCC")]
	public UILeaderBoardNewController()
	{
	}

	[Token(Token = "0x6010319")]
	[Address(RVA = "0x1A8F1FC", Offset = "0x1A8F1FC", VA = "0x1A8F1FC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601031A")]
	[Address(RVA = "0x1A8F2A0", Offset = "0x1A8F2A0", VA = "0x1A8F2A0", Slot = "44")]
	protected override bool IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x601031B")]
	[Address(RVA = "0x1A8F2F8", Offset = "0x1A8F2F8", VA = "0x1A8F2F8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601031C")]
	[Address(RVA = "0x1A8FEE8", Offset = "0x1A8FEE8", VA = "0x1A8FEE8")]
	private void InitSeasonInfo()
	{
	}

	[Token(Token = "0x601031D")]
	[Address(RVA = "0x1A915F0", Offset = "0x1A915F0", VA = "0x1A915F0")]
	private void InitBGWidth()
	{
	}

	[Token(Token = "0x601031E")]
	[Address(RVA = "0x1A904E8", Offset = "0x1A904E8", VA = "0x1A904E8")]
	private void InitTabInfoList()
	{
	}

	[Token(Token = "0x601031F")]
	[Address(RVA = "0x1A9088C", Offset = "0x1A9088C", VA = "0x1A9088C")]
	private void InitCallBackDic()
	{
	}

	[Token(Token = "0x6010320")]
	[Address(RVA = "0x1A91580", Offset = "0x1A91580", VA = "0x1A91580")]
	private void InitFliterDic()
	{
	}

	[Token(Token = "0x6010321")]
	[Address(RVA = "0x1A91A30", Offset = "0x1A91A30", VA = "0x1A91A30")]
	private void AddRankFliter()
	{
	}

	[Token(Token = "0x6010322")]
	[Address(RVA = "0x1A9265C", Offset = "0x1A9265C", VA = "0x1A9265C")]
	private void AddCasualFliter()
	{
	}

	[Token(Token = "0x6010323")]
	[Address(RVA = "0x1A93170", Offset = "0x1A93170", VA = "0x1A93170")]
	private void AddCSRankFliter()
	{
	}

	[Token(Token = "0x6010324")]
	[Address(RVA = "0x1A9393C", Offset = "0x1A9393C", VA = "0x1A9393C")]
	private void AddChampionshipFliter()
	{
	}

	[Token(Token = "0x6010325")]
	[Address(RVA = "0x1A94278", Offset = "0x1A94278", VA = "0x1A94278")]
	private void AddGuildFliter()
	{
	}

	[Token(Token = "0x6010326")]
	[Address(RVA = "0x1A94B58", Offset = "0x1A94B58", VA = "0x1A94B58")]
	private void AddBadgesFliter()
	{
	}

	[Token(Token = "0x6010327")]
	[Address(RVA = "0x1A950F4", Offset = "0x1A950F4", VA = "0x1A950F4")]
	private void CreateTabs()
	{
	}

	[Token(Token = "0x6010328")]
	[Address(RVA = "0x1A95894", Offset = "0x1A95894", VA = "0x1A95894")]
	private void OnRankTabClick()
	{
	}

	[Token(Token = "0x6010329")]
	[Address(RVA = "0x1A96F58", Offset = "0x1A96F58", VA = "0x1A96F58")]
	private void OnCasualTabClick()
	{
	}

	[Token(Token = "0x601032A")]
	[Address(RVA = "0x1A97200", Offset = "0x1A97200", VA = "0x1A97200")]
	private void OnCSRankTabClick()
	{
	}

	[Token(Token = "0x601032B")]
	[Address(RVA = "0x1A974E8", Offset = "0x1A974E8", VA = "0x1A974E8")]
	private void OnChampionshipTabClick()
	{
	}

	[Token(Token = "0x601032C")]
	[Address(RVA = "0x1A97978", Offset = "0x1A97978", VA = "0x1A97978")]
	private void OnGuildTabClick()
	{
	}

	[Token(Token = "0x601032D")]
	[Address(RVA = "0x1A97C74", Offset = "0x1A97C74", VA = "0x1A97C74")]
	private void OnElitePassTabClick()
	{
	}

	[Token(Token = "0x601032E")]
	[Address(RVA = "0x1A95B3C", Offset = "0x1A95B3C", VA = "0x1A95B3C")]
	private void InitFliterByConfig(Func<FliterData, List<PopMenuData>> func, string tabFliter)
	{
	}

	[Token(Token = "0x601032F")]
	[Address(RVA = "0x1A97F68", Offset = "0x1A97F68", VA = "0x1A97F68")]
	private List<PopMenuData> GenerateFilterData(FliterData fliterData)
	{
		return null;
	}

	[Token(Token = "0x6010330")]
	[Address(RVA = "0x1A98358", Offset = "0x1A98358", VA = "0x1A98358")]
	private void OnFliterSelected(object data)
	{
	}

	[Token(Token = "0x6010331")]
	[Address(RVA = "0x1A9854C", Offset = "0x1A9854C", VA = "0x1A9854C")]
	private void OnGuildRegionFliterSelected(object data)
	{
	}

	[Token(Token = "0x6010332")]
	[Address(RVA = "0x1A98828", Offset = "0x1A98828", VA = "0x1A98828")]
	private void OnGuildGlobalFliterSelected(object data)
	{
	}

	[Token(Token = "0x6010333")]
	[Address(RVA = "0x1A989A8", Offset = "0x1A989A8", VA = "0x1A989A8")]
	private void OnGuildWeekTotalFliterSelected(object data)
	{
	}

	[Token(Token = "0x6010334")]
	[Address(RVA = "0x1A968F8", Offset = "0x1A968F8", VA = "0x1A968F8")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x6010335")]
	[Address(RVA = "0x1A98A1C", Offset = "0x1A98A1C", VA = "0x1A98A1C")]
	private string BuildDeepLink()
	{
		return null;
	}

	[Token(Token = "0x6010336")]
	[Address(RVA = "0x1A95FB0", Offset = "0x1A95FB0", VA = "0x1A95FB0")]
	private void SetFliter(string fliter1 = "", string fliter2 = "", string fliter3 = "", string fliter4 = "")
	{
	}

	[Token(Token = "0x6010337")]
	[Address(RVA = "0x1A96140", Offset = "0x1A96140", VA = "0x1A96140")]
	private void UpdateStyle()
	{
	}

	[Token(Token = "0x6010338")]
	[Address(RVA = "0x1A98D2C", Offset = "0x1A98D2C", VA = "0x1A98D2C", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6010339")]
	[Address(RVA = "0x1A99118", Offset = "0x1A99118", VA = "0x1A99118", Slot = "45")]
	protected override bool NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x601033A")]
	[Address(RVA = "0x1A99170", Offset = "0x1A99170", VA = "0x1A99170", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x601033B")]
	[Address(RVA = "0x1A9552C", Offset = "0x1A9552C", VA = "0x1A9552C")]
	private void NavigationToLeaderBoard()
	{
	}

	[Token(Token = "0x601033C")]
	[Address(RVA = "0x1A99410", Offset = "0x1A99410", VA = "0x1A99410")]
	private void SetPopMenuData(DeepLinkLayer layer, string fliter)
	{
	}

	[Token(Token = "0x601033D")]
	[Address(RVA = "0x1A99594", Offset = "0x1A99594", VA = "0x1A99594", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601033E")]
	[Address(RVA = "0x1A99730", Offset = "0x1A99730", VA = "0x1A99730")]
	private void OnPlayerFriendKillsSoloSelected()
	{
	}

	[Token(Token = "0x601033F")]
	[Address(RVA = "0x1A99968", Offset = "0x1A99968", VA = "0x1A99968")]
	private void OnPlayerFriendKillsDuoSelected()
	{
	}

	[Token(Token = "0x6010340")]
	[Address(RVA = "0x1A99A4C", Offset = "0x1A99A4C", VA = "0x1A99A4C")]
	private void OnPlayerFriendKillsTeamSelected()
	{
	}

	[Token(Token = "0x6010341")]
	[Address(RVA = "0x1A99B30", Offset = "0x1A99B30", VA = "0x1A99B30")]
	private void OnPlayerFriendWinsSoloSelected()
	{
	}

	[Token(Token = "0x6010342")]
	[Address(RVA = "0x1A99C14", Offset = "0x1A99C14", VA = "0x1A99C14")]
	private void OnPlayerFriendWinsDuoSelected()
	{
	}

	[Token(Token = "0x6010343")]
	[Address(RVA = "0x1A99CF8", Offset = "0x1A99CF8", VA = "0x1A99CF8")]
	private void OnPlayerFriendWinsTeamSelected()
	{
	}

	[Token(Token = "0x6010344")]
	[Address(RVA = "0x1A99DDC", Offset = "0x1A99DDC", VA = "0x1A99DDC")]
	private void OnPlayerRegionKillsSoloSelected()
	{
	}

	[Token(Token = "0x6010345")]
	[Address(RVA = "0x1A9A234", Offset = "0x1A9A234", VA = "0x1A9A234")]
	private void OnPlayerRegionKillsDuaSelected()
	{
	}

	[Token(Token = "0x6010346")]
	[Address(RVA = "0x1A9A478", Offset = "0x1A9A478", VA = "0x1A9A478")]
	private void OnPlayerRegionKillsTeamSelected()
	{
	}

	[Token(Token = "0x6010347")]
	[Address(RVA = "0x1A9A6BC", Offset = "0x1A9A6BC", VA = "0x1A9A6BC")]
	private void OnPlayerRegionWinsSoloSelected()
	{
	}

	[Token(Token = "0x6010348")]
	[Address(RVA = "0x1A9A900", Offset = "0x1A9A900", VA = "0x1A9A900")]
	private void OnPlayerRegionWinsDuoSelected()
	{
	}

	[Token(Token = "0x6010349")]
	[Address(RVA = "0x1A9AB44", Offset = "0x1A9AB44", VA = "0x1A9AB44")]
	private void OnPlayerRegionWinsTeamSelected()
	{
	}

	[Token(Token = "0x601034A")]
	[Address(RVA = "0x1A9AD88", Offset = "0x1A9AD88", VA = "0x1A9AD88")]
	private void OnPlayerFriendCasualKillsSoloSelected()
	{
	}

	[Token(Token = "0x601034B")]
	[Address(RVA = "0x1A9AE6C", Offset = "0x1A9AE6C", VA = "0x1A9AE6C")]
	private void OnPlayerFriendCasualKillsDuoSelected()
	{
	}

	[Token(Token = "0x601034C")]
	[Address(RVA = "0x1A9AF50", Offset = "0x1A9AF50", VA = "0x1A9AF50")]
	private void OnPlayerFriendCasualKillsTeamSelected()
	{
	}

	[Token(Token = "0x601034D")]
	[Address(RVA = "0x1A9B034", Offset = "0x1A9B034", VA = "0x1A9B034")]
	private void OnPlayerFriendCasualWinsSoloSelected()
	{
	}

	[Token(Token = "0x601034E")]
	[Address(RVA = "0x1A9B118", Offset = "0x1A9B118", VA = "0x1A9B118")]
	private void OnPlayerFriendCasualWinsDuoSelected()
	{
	}

	[Token(Token = "0x601034F")]
	[Address(RVA = "0x1A9B1FC", Offset = "0x1A9B1FC", VA = "0x1A9B1FC")]
	private void OnPlayerFriendCasualWinsTeamSelected()
	{
	}

	[Token(Token = "0x6010350")]
	[Address(RVA = "0x1A9B2E0", Offset = "0x1A9B2E0", VA = "0x1A9B2E0")]
	private void OnPlayerFriendCSKillsSelected()
	{
	}

	[Token(Token = "0x6010351")]
	[Address(RVA = "0x1A9B3C8", Offset = "0x1A9B3C8", VA = "0x1A9B3C8")]
	private void OnPlayerFriendCSWinsSelected()
	{
	}

	[Token(Token = "0x6010352")]
	[Address(RVA = "0x1A9B4B0", Offset = "0x1A9B4B0", VA = "0x1A9B4B0")]
	private void OnPlayerRegionCSKillsSelected()
	{
	}

	[Token(Token = "0x6010353")]
	[Address(RVA = "0x1A9B6F8", Offset = "0x1A9B6F8", VA = "0x1A9B6F8")]
	private void OnPlayerRegionCSWinsSelected()
	{
	}

	[Token(Token = "0x6010354")]
	[Address(RVA = "0x1A9B940", Offset = "0x1A9B940", VA = "0x1A9B940")]
	private void OnFFCTeamRegionKillsSelected()
	{
	}

	[Token(Token = "0x6010355")]
	[Address(RVA = "0x1A9BB60", Offset = "0x1A9BB60", VA = "0x1A9BB60")]
	private void OnFFCTeamRegionScoreSelected()
	{
	}

	[Token(Token = "0x6010356")]
	[Address(RVA = "0x1A9BD80", Offset = "0x1A9BD80", VA = "0x1A9BD80")]
	private void OnThirdPartyTeamRegionScoreSelected()
	{
	}

	[Token(Token = "0x6010357")]
	[Address(RVA = "0x1A9BFA0", Offset = "0x1A9BFA0", VA = "0x1A9BFA0")]
	private void OnThirdPartyTeamRegionKillsSelected()
	{
	}

	[Token(Token = "0x6010358")]
	[Address(RVA = "0x1A9C1C0", Offset = "0x1A9C1C0", VA = "0x1A9C1C0")]
	private void OnGuildRegionWeekHonorSelected()
	{
	}

	[Token(Token = "0x6010359")]
	[Address(RVA = "0x1A9C71C", Offset = "0x1A9C71C", VA = "0x1A9C71C")]
	private void OnGuildRegionTotalHonorSelected()
	{
	}

	[Token(Token = "0x601035A")]
	[Address(RVA = "0x1A9C8EC", Offset = "0x1A9C8EC", VA = "0x1A9C8EC")]
	private void OnGuildGlobalHonorSelected()
	{
	}

	[Token(Token = "0x601035B")]
	[Address(RVA = "0x1A9CA5C", Offset = "0x1A9CA5C", VA = "0x1A9CA5C")]
	private void OnPlayerFriendBadgesSelected()
	{
	}

	[Token(Token = "0x601035C")]
	[Address(RVA = "0x1A9CB40", Offset = "0x1A9CB40", VA = "0x1A9CB40")]
	private void OnPlayerRegionBadgesSelected()
	{
	}

	[Token(Token = "0x601035D")]
	[Address(RVA = "0x1A9CD70", Offset = "0x1A9CD70", VA = "0x1A9CD70")]
	private void OnPlayerGlobalBadgesSelected()
	{
	}

	[Token(Token = "0x601035E")]
	[Address(RVA = "0x1A9CF6C", Offset = "0x1A9CF6C", VA = "0x1A9CF6C")]
	private void BeforeRequestData(int propID)
	{
	}

	[Token(Token = "0x601035F")]
	[Address(RVA = "0x1A99814", Offset = "0x1A99814", VA = "0x1A99814")]
	private void RequestFriendData(int propID)
	{
	}

	[Token(Token = "0x6010360")]
	[Address(RVA = "0x1A9A020", Offset = "0x1A9A020", VA = "0x1A9A020")]
	private void RequestData(int propID, int mainType = 0, int subType = 0, ulong mainKey = 0uL, ulong subKey = 0uL, string region = "", uint httpOp = 0u, bool force = false, uint pageIndex = 0u, uint pageSize = 100u, bool getSelf = true)
	{
	}

	[Token(Token = "0x6010361")]
	[Address(RVA = "0x1A9D0AC", Offset = "0x1A9D0AC", VA = "0x1A9D0AC")]
	private void SwitchListTitle()
	{
	}

	[Token(Token = "0x6010362")]
	[Address(RVA = "0x1A8FCD0", Offset = "0x1A8FCD0", VA = "0x1A8FCD0")]
	private void HideAllListTitle()
	{
	}

	[Token(Token = "0x6010363")]
	[Address(RVA = "0x1A9D268", Offset = "0x1A9D268", VA = "0x1A9D268")]
	private void RefreshListFriendPlayer()
	{
	}

	[Token(Token = "0x6010364")]
	[Address(RVA = "0x1A9D804", Offset = "0x1A9D804", VA = "0x1A9D804")]
	private void RefreshListPlayer()
	{
	}

	[Token(Token = "0x6010365")]
	[Address(RVA = "0x1A9DBBC", Offset = "0x1A9DBBC", VA = "0x1A9DBBC")]
	private void RefreshListGuild()
	{
	}

	[Token(Token = "0x6010366")]
	[Address(RVA = "0x1A9DF24", Offset = "0x1A9DF24", VA = "0x1A9DF24")]
	private void RefreshListTeam()
	{
	}

	[Token(Token = "0x6010367")]
	[Address(RVA = "0x1A9D5F4", Offset = "0x1A9D5F4", VA = "0x1A9D5F4")]
	private void SetSelfTipsInfoActive(bool show)
	{
	}

	[Token(Token = "0x6010368")]
	[Address(RVA = "0x1A9E334", Offset = "0x1A9E334", VA = "0x1A9E334", Slot = "64")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6010369")]
	[Address(RVA = "0x1A9D774", Offset = "0x1A9D774", VA = "0x1A9D774")]
	private void SetItemBGInfo(UILeaderBoardItemNewController ctrl)
	{
	}

	[Token(Token = "0x601036A")]
	[Address(RVA = "0x1A9E604", Offset = "0x1A9E604", VA = "0x1A9E604", Slot = "65")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601036B")]
	[Address(RVA = "0x1A98C7C", Offset = "0x1A98C7C", VA = "0x1A98C7C")]
	public int GetBGWidth1()
	{
		return default(int);
	}

	[Token(Token = "0x601036C")]
	[Address(RVA = "0x1A98CD4", Offset = "0x1A98CD4", VA = "0x1A98CD4")]
	public int GetBGWidth2()
	{
		return default(int);
	}

	[Token(Token = "0x601036D")]
	[Address(RVA = "0x1A96A40", Offset = "0x1A96A40", VA = "0x1A96A40")]
	private void SetSeasonBtnState(bool show)
	{
	}

	[Token(Token = "0x601036E")]
	[Address(RVA = "0x1A96AF8", Offset = "0x1A96AF8", VA = "0x1A96AF8")]
	private void SetCSSeasonBtnState(bool show)
	{
	}

	[Token(Token = "0x601036F")]
	[Address(RVA = "0x1A96BB0", Offset = "0x1A96BB0", VA = "0x1A96BB0")]
	private void SetShareBtnState(bool share1Show, bool share2Show)
	{
	}

	[Token(Token = "0x6010370")]
	[Address(RVA = "0x1A96840", Offset = "0x1A96840", VA = "0x1A96840")]
	private void SetProfileBtnState(bool show)
	{
	}

	[Token(Token = "0x6010371")]
	[Address(RVA = "0x1A9E680", Offset = "0x1A9E680", VA = "0x1A9E680")]
	private void OnSeasonTipsBtnClick()
	{
	}

	[Token(Token = "0x6010372")]
	[Address(RVA = "0x1A9ED40", Offset = "0x1A9ED40", VA = "0x1A9ED40")]
	private void OnCSSeasonTipsBtnClick()
	{
	}

	[Token(Token = "0x6010373")]
	[Address(RVA = "0x1A9C3CC", Offset = "0x1A9C3CC", VA = "0x1A9C3CC")]
	private void SetGuildWeekTipsInfo()
	{
	}

	[Token(Token = "0x6010374")]
	[Address(RVA = "0x1A96DF4", Offset = "0x1A96DF4", VA = "0x1A96DF4")]
	private void HideGuildWeekTipsInfo()
	{
	}

	[Token(Token = "0x6010375")]
	[Address(RVA = "0x1A9F4AC", Offset = "0x1A9F4AC", VA = "0x1A9F4AC", Slot = "66")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010376")]
	[Address(RVA = "0x1A9F994", Offset = "0x1A9F994", VA = "0x1A9F994", Slot = "67")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010377")]
	[Address(RVA = "0x1A991FC", Offset = "0x1A991FC", VA = "0x1A991FC")]
	private string GetDeepLink(DeepLinkLayer layer)
	{
		return null;
	}

	[Token(Token = "0x6010378")]
	[Address(RVA = "0x1A9FA54", Offset = "0x1A9FA54", VA = "0x1A9FA54")]
	private void OnShareClick()
	{
	}

	[Token(Token = "0x6010379")]
	[Address(RVA = "0x1A9FBB0", Offset = "0x1A9FBB0", VA = "0x1A9FBB0")]
	private void OnProfileClick()
	{
	}

	[Token(Token = "0x601037A")]
	[Address(RVA = "0x1A9FE98", Offset = "0x1A9FE98", VA = "0x1A9FE98", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x601037B")]
	[Address(RVA = "0x1A9FF64", Offset = "0x1A9FF64", VA = "0x1A9FF64", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x601037C")]
	[Address(RVA = "0x1AA0050", Offset = "0x1AA0050", VA = "0x1AA0050")]
	private void OnLeaderBoardItemSelected(object[] param)
	{
	}

	[Token(Token = "0x601037D")]
	[Address(RVA = "0x1A98F58", Offset = "0x1A98F58", VA = "0x1A98F58")]
	private void TryShowPreviewAvatar(ulong accountID)
	{
	}

	[Token(Token = "0x601037E")]
	[Address(RVA = "0x1A9F800", Offset = "0x1A9F800", VA = "0x1A9F800")]
	private bool ShowAvatar(ulong accountID)
	{
		return default(bool);
	}

	[Token(Token = "0x601037F")]
	[Address(RVA = "0x1A97918", Offset = "0x1A97918", VA = "0x1A97918")]
	private void ClearSelectedAccountID()
	{
	}

	[Token(Token = "0x6010380")]
	[Address(RVA = "0x1A96EA4", Offset = "0x1A96EA4", VA = "0x1A96EA4")]
	private void ShowLoading(bool show)
	{
	}

	[Token(Token = "0x6010381")]
	[Address(RVA = "0x1AA0168", Offset = "0x1AA0168", VA = "0x1AA0168", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6010382")]
	[Address(RVA = "0x1AA01D8", Offset = "0x1AA01D8", VA = "0x1AA01D8", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6010384")]
	[Address(RVA = "0x1AA2AB0", Offset = "0x1AA2AB0", VA = "0x1AA2AB0")]
	private void _003COnGuildRegionWeekHonorSelected_003Em__0()
	{
	}

	[Token(Token = "0x6010385")]
	[Address(RVA = "0x1AA2B6C", Offset = "0x1AA2B6C", VA = "0x1AA2B6C")]
	private void _003COnGuildRegionTotalHonorSelected_003Em__1()
	{
	}

	[Token(Token = "0x6010386")]
	[Address(RVA = "0x1AA2BFC", Offset = "0x1AA2BFC", VA = "0x1AA2BFC")]
	public bool _003C_003EiFixBaseProxy_IsAutoCalculatePreviewPanelSize()
	{
		return default(bool);
	}

	[Token(Token = "0x6010387")]
	[Address(RVA = "0x1AA2C04", Offset = "0x1AA2C04", VA = "0x1AA2C04")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010388")]
	[Address(RVA = "0x1AA2C0C", Offset = "0x1AA2C0C", VA = "0x1AA2C0C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6010389")]
	[Address(RVA = "0x1AA2C14", Offset = "0x1AA2C14", VA = "0x1AA2C14")]
	public bool _003C_003EiFixBaseProxy_NeedRecoverPreviewOnNavigationShowed()
	{
		return default(bool);
	}

	[Token(Token = "0x601038A")]
	[Address(RVA = "0x1AA2C1C", Offset = "0x1AA2C1C", VA = "0x1AA2C1C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x601038B")]
	[Address(RVA = "0x1AA2C24", Offset = "0x1AA2C24", VA = "0x1AA2C24")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601038C")]
	[Address(RVA = "0x1AA2C2C", Offset = "0x1AA2C2C", VA = "0x1AA2C2C")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x601038D")]
	[Address(RVA = "0x1AA2C34", Offset = "0x1AA2C34", VA = "0x1AA2C34")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
