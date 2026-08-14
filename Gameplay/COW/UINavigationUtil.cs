using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2000293")]
public static class UINavigationUtil
{
	[Token(Token = "0x2000294")]
	public enum UINavigationFrom
	{
		[Token(Token = "0x400314C")]
		None = 0,
		[Token(Token = "0x400314D")]
		Lobby = 1,
		[Token(Token = "0x400314E")]
		DeepLink = 2,
		[Token(Token = "0x400314F")]
		Activity = 3,
		[Token(Token = "0x4003150")]
		IAP = 4,
		[Token(Token = "0x4003151")]
		LobbyAds = 5,
		[Token(Token = "0x4003152")]
		LobbyExtraAds = 6,
		[Token(Token = "0x4003153")]
		MallAds = 7,
		[Token(Token = "0x4003154")]
		Announcement = 8,
		[Token(Token = "0x4003155")]
		SplashBanner = 9,
		[Token(Token = "0x4003156")]
		RollNotice = 10,
		[Token(Token = "0x4003157")]
		FriendReunionReward = 11,
		[Token(Token = "0x4003158")]
		ActivityReward = 12,
		[Token(Token = "0x4003159")]
		Debt = 13,
		[Token(Token = "0x400315A")]
		ElitePass = 14,
		[Token(Token = "0x400315B")]
		FirstTimePayment = 15,
		[Token(Token = "0x400315C")]
		MatchAfterLottery_OpenAll = 16,
		[Token(Token = "0x400315D")]
		MatchAfterLottery_OpenOne = 17,
		[Token(Token = "0x400315E")]
		Clan = 18,
		[Token(Token = "0x400315F")]
		UnlockSkill = 19,
		[Token(Token = "0x4003160")]
		SendGift = 20,
		[Token(Token = "0x4003161")]
		SendGift_Fast = 21,
		[Token(Token = "0x4003162")]
		Mall = 22,
		[Token(Token = "0x4003163")]
		Gacha_OneTime = 23,
		[Token(Token = "0x4003164")]
		Gacha_TenTimes = 24,
		[Token(Token = "0x4003165")]
		ModifyClanName = 25,
		[Token(Token = "0x4003166")]
		ModifyNickname = 26,
		[Token(Token = "0x4003167")]
		ActivityReward_Festival = 27,
		[Token(Token = "0x4003168")]
		Forge = 28,
		[Token(Token = "0x4003169")]
		PreviewCgShow = 29,
		[Token(Token = "0x400316A")]
		DeleteAccount = 30,
		[Token(Token = "0x400316B")]
		AnnouncementReward = 31,
		[Token(Token = "0x400316C")]
		CommonReward = 32,
		[Token(Token = "0x400316D")]
		AvatarProfile_GainAvatar = 33,
		[Token(Token = "0x400316E")]
		AvatarProfile_GainBundle = 34,
		[Token(Token = "0x400316F")]
		AvatarProfile_Vault = 35,
		[Token(Token = "0x4003170")]
		ElitePass_BadgePurchase = 36,
		[Token(Token = "0x4003171")]
		ElitePass_Challenge = 37,
		[Token(Token = "0x4003172")]
		ElitePass_Reward = 38,
		[Token(Token = "0x4003173")]
		Friend = 39,
		[Token(Token = "0x4003174")]
		Gacha_ExchangeActivity = 40,
		[Token(Token = "0x4003175")]
		IAPBundle_Preview = 41,
		[Token(Token = "0x4003176")]
		Inventory = 42,
		[Token(Token = "0x4003177")]
		Lobby_VideoTutorial = 43,
		[Token(Token = "0x4003178")]
		Lobby_WebTutorial = 44,
		[Token(Token = "0x4003179")]
		Login_TermsOfService = 45,
		[Token(Token = "0x400317A")]
		LotteryReward = 46,
		[Token(Token = "0x400317B")]
		Pet_ModifyName = 47,
		[Token(Token = "0x400317C")]
		Policy = 48,
		[Token(Token = "0x400317D")]
		ProfileTrendItem = 49,
		[Token(Token = "0x400317E")]
		LadderMatch_SeasonStats = 50,
		[Token(Token = "0x400317F")]
		LadderMatch_SeasonStatsDetail = 51,
		[Token(Token = "0x4003180")]
		Setting_TermsOfService = 52,
		[Token(Token = "0x4003181")]
		Setting_PrivacyPolicy = 53,
		[Token(Token = "0x4003182")]
		Setting_CustomerService = 54,
		[Token(Token = "0x4003183")]
		AutoPopup = 55,
		[Token(Token = "0x4003184")]
		PopupMenu = 56,
		[Token(Token = "0x4003185")]
		LadderMatch_LeaderboardItem = 57,
		[Token(Token = "0x4003186")]
		Chat_MessageItem = 58,
		[Token(Token = "0x4003187")]
		Clan_Item = 59,
		[Token(Token = "0x4003188")]
		Group_Invite = 60,
		[Token(Token = "0x4003189")]
		Player_LeaderboardItem = 61,
		[Token(Token = "0x400318A")]
		LeaderboardItem = 62,
		[Token(Token = "0x400318B")]
		FriendSearchItem = 63,
		[Token(Token = "0x400318C")]
		FriendApplyItem = 64,
		[Token(Token = "0x400318D")]
		LadderMatch_Rules = 65,
		[Token(Token = "0x400318E")]
		LadderLobby = 66,
		[Token(Token = "0x400318F")]
		PVEPrepare = 67,
		[Token(Token = "0x4003190")]
		PVEWeaponSelection = 68,
		[Token(Token = "0x4003191")]
		PaymentActivity = 69,
		[Token(Token = "0x4003192")]
		PaymentTotal = 70,
		[Token(Token = "0x4003193")]
		PaymentBundle = 71,
		[Token(Token = "0x4003194")]
		PaymentRebateCard = 72,
		[Token(Token = "0x4003195")]
		Pet_Mall = 73,
		[Token(Token = "0x4003196")]
		ActivityGW_Token = 74,
		[Token(Token = "0x4003197")]
		PveLuckyDraw = 75,
		[Token(Token = "0x4003198")]
		GoogleEngagementRewards = 76,
		[Token(Token = "0x4003199")]
		LiveTv = 77,
		[Token(Token = "0x400319A")]
		LiveTver = 78,
		[Token(Token = "0x400319B")]
		LobbyExtraAds_1 = 79,
		[Token(Token = "0x400319C")]
		LobbyExtraAds_2 = 80,
		[Token(Token = "0x400319D")]
		Championship = 81,
		[Token(Token = "0x400319E")]
		ChampionshipTeamProfile = 82,
		[Token(Token = "0x400319F")]
		ChampionshipGameStats = 83,
		[Token(Token = "0x40031A0")]
		ManualWeapon = 84,
		[Token(Token = "0x40031A1")]
		Manual = 85,
		[Token(Token = "0x40031A2")]
		MallWebBtn = 86,
		[Token(Token = "0x40031A3")]
		PaymentShop = 87,
		[Token(Token = "0x40031A4")]
		PaymentDiamondEvent = 88,
		[Token(Token = "0x40031A5")]
		LinkActivity = 89,
		[Token(Token = "0x40031A6")]
		GameModeMain = 90,
		[Token(Token = "0x40031A7")]
		ChampionshipLobby = 91,
		[Token(Token = "0x40031A8")]
		VeteranTask = 92,
		[Token(Token = "0x40031A9")]
		Veteran = 93,
		[Token(Token = "0x40031AA")]
		Gacha_BuyBuff = 94,
		[Token(Token = "0x40031AB")]
		UpgradeCard = 95,
		[Token(Token = "0x40031AC")]
		DownloadCenter = 96,
		[Token(Token = "0x40031AD")]
		PaymentFirstTimeWindow = 97,
		[Token(Token = "0x40031AE")]
		InviteGroupBox = 98,
		[Token(Token = "0x40031AF")]
		IAPDiamondPurchase = 100,
		[Token(Token = "0x40031B0")]
		EPQuest = 101,
		[Token(Token = "0x40031B1")]
		EPUpgradeReward = 102,
		[Token(Token = "0x40031B2")]
		CDKeyPopUp = 103,
		[Token(Token = "0x40031B3")]
		AnniversaryEnter = 105,
		[Token(Token = "0x40031B4")]
		MysteryMallLuckyDraw = 106,
		[Token(Token = "0x40031B5")]
		MysteryMall = 107,
		[Token(Token = "0x40031B6")]
		PaymentGrowthFund = 109,
		[Token(Token = "0x40031B7")]
		GrowthFundAd = 110,
		[Token(Token = "0x40031B8")]
		WeaponSkinMainEnter = 113,
		[Token(Token = "0x40031B9")]
		WeaponSkinUpgrader = 115,
		[Token(Token = "0x40031BA")]
		Gacha_WeaponSkin = 117,
		[Token(Token = "0x40031BB")]
		PreviewItem = 118,
		[Token(Token = "0x40031BC")]
		Loadout = 120,
		[Token(Token = "0x40031BD")]
		ChampionshipNoticeItem = 122,
		[Token(Token = "0x40031BE")]
		InvitationTipsBox = 125,
		[Token(Token = "0x40031BF")]
		GameFriendItem = 126,
		[Token(Token = "0x40031C0")]
		PlatformFriendItem = 127,
		[Token(Token = "0x40031C1")]
		FriendRelationshipGraphItem = 128,
		[Token(Token = "0x40031C2")]
		RoomObserverItem = 129,
		[Token(Token = "0x40031C3")]
		RoomPlayerItem = 130,
		[Token(Token = "0x40031C4")]
		HDVehicleDisplay = 135,
		[Token(Token = "0x40031C5")]
		HDWeaponRack = 136,
		[Token(Token = "0x40031C6")]
		Login_Main = 137,
		[Token(Token = "0x40031C7")]
		AvatarAwaken = 138,
		[Token(Token = "0x40031C8")]
		CupTeamProfile = 139,
		[Token(Token = "0x40031C9")]
		HDIceWallDisplay = 140,
		[Token(Token = "0x40031CA")]
		MallOtherChannelBtn = 142,
		[Token(Token = "0x40031CB")]
		TopUpEvent = 145,
		[Token(Token = "0x40031CC")]
		DailySignIn = 150,
		[Token(Token = "0x40031CD")]
		LegendClothVaultPick = 151,
		[Token(Token = "0x40031CE")]
		ClanLuckyBag = 152,
		[Token(Token = "0x40031CF")]
		HDSkyboardDisplay = 153,
		[Token(Token = "0x40031D0")]
		TrainingCamp = 154,
		[Token(Token = "0x40031D1")]
		ProfileHistoryMatchResult = 155,
		[Token(Token = "0x40031D2")]
		Setting = 156,
		[Token(Token = "0x40031D3")]
		NewVault = 157,
		[Token(Token = "0x40031D4")]
		CreateRoom = 158,
		[Token(Token = "0x40031D5")]
		Gacha = 159,
		[Token(Token = "0x40031D6")]
		AvatarLink = 160,
		[Token(Token = "0x40031D7")]
		MatchResultReward = 161,
		[Token(Token = "0x40031D8")]
		HyperBookContent = 162,
		[Token(Token = "0x40031D9")]
		FlashStore = 163,
		[Token(Token = "0x40031DA")]
		FlashStoreActivity = 164,
		[Token(Token = "0x40031DB")]
		BigEvent_DigitaluniverseB_Main = 188,
		[Token(Token = "0x40031DC")]
		BigEvent_DigitaluniverseB_RoleDoorDialog = 189,
		[Token(Token = "0x40031DD")]
		BigEvent_DigitaluniverseB_RoleDoor = 190,
		[Token(Token = "0x40031DE")]
		BigEvent_DigitaluniverseB_GunDoor = 191,
		[Token(Token = "0x40031DF")]
		BigEvent_DigitaluniverseB_ActivityDoor = 192,
		[Token(Token = "0x40031E0")]
		BigEvent_DigitaluniverseB_ClothDoor = 193,
		[Token(Token = "0x40031E1")]
		BigEvent_DigitaluniverseB_MapDoor = 194,
		[Token(Token = "0x40031E2")]
		BigEvent_DigitaluniverseB_ExchangeStore = 195,
		[Token(Token = "0x40031E3")]
		BigEvent_DigitaluniverseB_StarMap = 196,
		[Token(Token = "0x40031E4")]
		BigEvent = 197,
		[Token(Token = "0x40031E5")]
		BigEvent_GlobalProgress = 198,
		[Token(Token = "0x40031E6")]
		SurveyEntry = 199,
		[Token(Token = "0x40031E7")]
		Mail = 200,
		[Token(Token = "0x40031E8")]
		UGCWorkshopCreate = 201
	}

	[Token(Token = "0x2000295")]
	public enum UINavigationPageType
	{
		[Token(Token = "0x40031EA")]
		None = 0,
		[Token(Token = "0x40031EB")]
		Profile = 1,
		[Token(Token = "0x40031EC")]
		Group = 2,
		[Token(Token = "0x40031ED")]
		Mall = 3,
		[Token(Token = "0x40031EE")]
		Vault = 4,
		[Token(Token = "0x40031EF")]
		Clan = 5,
		[Token(Token = "0x40031F0")]
		Recharge = 6,
		[Token(Token = "0x40031F1")]
		Activity = 7,
		[Token(Token = "0x40031F2")]
		Friends = 8,
		[Token(Token = "0x40031F3")]
		Loadout = 9,
		[Token(Token = "0x40031F4")]
		Setting = 10,
		[Token(Token = "0x40031F5")]
		Tutorial = 11,
		[Token(Token = "0x40031F6")]
		RebateCard = 12,
		[Token(Token = "0x40031F7")]
		AvatarProfile = 13,
		[Token(Token = "0x40031F8")]
		ElitePass = 14,
		[Token(Token = "0x40031F9")]
		Gacha = 15,
		[Token(Token = "0x40031FA")]
		IAPBundle = 16,
		[Token(Token = "0x40031FB")]
		Chat = 17,
		[Token(Token = "0x40031FC")]
		Forge = 18,
		[Token(Token = "0x40031FD")]
		RewardedVideo = 19,
		[Token(Token = "0x40031FE")]
		GainItemPreview = 20,
		[Token(Token = "0x40031FF")]
		Leaderboard = 21,
		[Token(Token = "0x4003200")]
		LadderMatch = 22,
		[Token(Token = "0x4003201")]
		IngameDrop = 23,
		[Token(Token = "0x4003202")]
		Payment = 25,
		[Token(Token = "0x4003203")]
		Pet = 26,
		[Token(Token = "0x4003204")]
		ActivityGW = 27,
		[Token(Token = "0x4003205")]
		GoogleEngagementRewards = 28,
		[Token(Token = "0x4003206")]
		LiveTv = 29,
		[Token(Token = "0x4003207")]
		MemberShip = 30,
		[Token(Token = "0x4003208")]
		Championship = 31,
		[Token(Token = "0x4003209")]
		ChampionshipTeamProfile = 32,
		[Token(Token = "0x400320A")]
		ChampionshipNormalGameStats = 33,
		[Token(Token = "0x400320B")]
		ChampionshipTeamOtherProfile = 34,
		[Token(Token = "0x400320C")]
		ChampionshipGameWinnerDetail = 35,
		[Token(Token = "0x400320D")]
		Task = 36,
		[Token(Token = "0x400320E")]
		ChampionshipLobby = 37,
		[Token(Token = "0x400320F")]
		Veteran = 38,
		[Token(Token = "0x4003210")]
		SubscriptionHub = 39,
		[Token(Token = "0x4003211")]
		PaymentFirstTimeWindow = 41,
		[Token(Token = "0x4003212")]
		EPTask = 43,
		[Token(Token = "0x4003213")]
		Mail = 46,
		[Token(Token = "0x4003214")]
		AnniversaryAct = 47,
		[Token(Token = "0x4003215")]
		MystertyMall = 48,
		[Token(Token = "0x4003216")]
		SceneEdit = 49,
		[Token(Token = "0x4003217")]
		GotoMapMode = 53,
		[Token(Token = "0x4003218")]
		WeaponSkinMain = 54,
		[Token(Token = "0x4003219")]
		WeaponSkinUpgrader = 55,
		[Token(Token = "0x400321A")]
		ChampionshipWarmUp = 56,
		[Token(Token = "0x400321B")]
		ChampionshipDefault = 57,
		[Token(Token = "0x400321C")]
		DownloadCenter = 58,
		[Token(Token = "0x400321D")]
		LadderMatchDetail = 59,
		[Token(Token = "0x400321E")]
		PortraitCloseup = 64,
		[Token(Token = "0x400321F")]
		AvatarAwaken = 69,
		[Token(Token = "0x4003220")]
		DressUpMain = 70,
		[Token(Token = "0x4003221")]
		CupMatch = 76,
		[Token(Token = "0x4003222")]
		CupMatchTeamOtherProfile = 77,
		[Token(Token = "0x4003223")]
		LuckyWheel = 78,
		[Token(Token = "0x4003224")]
		BigEventTemplate = 79,
		[Token(Token = "0x4003225")]
		VeteranGuideance = 80,
		[Token(Token = "0x4003226")]
		VeteranDailyMission = 81,
		[Token(Token = "0x4003227")]
		BigEvent = 98,
		[Token(Token = "0x4003228")]
		WebView = 99,
		[Token(Token = "0x4003229")]
		MAX = 100
	}

	[Token(Token = "0x2000296")]
	public enum UINavagationProfileType
	{
		[Token(Token = "0x400322B")]
		ProfileDefault,
		[Token(Token = "0x400322C")]
		profileRankHistory,
		[Token(Token = "0x400322D")]
		ProfileStreamer,
		[Token(Token = "0x400322E")]
		ProfileChampionshipHistory,
		[Token(Token = "0x400322F")]
		ProfileCredit
	}

	[Token(Token = "0x2000297")]
	public enum UINavigationMallExType
	{
		[Token(Token = "0x4003231")]
		FFEx = 800000301,
		[Token(Token = "0x4003232")]
		DrawCardEx,
		[Token(Token = "0x4003233")]
		RankEx,
		[Token(Token = "0x4003234")]
		GachaEx
	}

	[Token(Token = "0x2000298")]
	public enum UINavigationGroupType
	{
		[Token(Token = "0x4003236")]
		GroupDuo = 1,
		[Token(Token = "0x4003237")]
		GroupSquad
	}

	[Token(Token = "0x2000299")]
	public enum UINavigationMallType
	{
		[Token(Token = "0x4003239")]
		MallTypeNone,
		[Token(Token = "0x400323A")]
		MallTypeNormal,
		[Token(Token = "0x400323B")]
		MallTypeWeapon,
		[Token(Token = "0x400323C")]
		MallTypeBox,
		[Token(Token = "0x400323D")]
		MallTypeGift,
		[Token(Token = "0x400323E")]
		MallTypeExchange
	}

	[Token(Token = "0x200029A")]
	public enum UINavigationMallTabType
	{
		[Token(Token = "0x4003240")]
		MallTabTypeNone = 0,
		[Token(Token = "0x4003241")]
		MallTabTypeAll = 1,
		[Token(Token = "0x4003242")]
		MallTabTypeExclusive = 2,
		[Token(Token = "0x4003243")]
		MallTabTypeAds = 3,
		[Token(Token = "0x4003244")]
		MallTabTypeNewItem = 4,
		[Token(Token = "0x4003245")]
		MallTabTypeTreasureBox = 5,
		[Token(Token = "0x4003246")]
		MallTabTypeBundle = 6,
		[Token(Token = "0x4003247")]
		MallTabTypeAvatar = 7,
		[Token(Token = "0x4003248")]
		MallTabTypeClothes = 8,
		[Token(Token = "0x4003249")]
		MallTabTypeWeapon = 9,
		[Token(Token = "0x400324A")]
		MallTabTypeProps = 10,
		[Token(Token = "0x400324B")]
		MallTabTypeCollection = 11,
		[Token(Token = "0x400324C")]
		MallTabTypePet = 12,
		[Token(Token = "0x400324D")]
		MallTabTypeOther = 13,
		[Token(Token = "0x400324E")]
		MallTabTypeDiscount = 14,
		[Token(Token = "0x400324F")]
		MallTabInstallment = 15,
		[Token(Token = "0x4003250")]
		MallTabTypeSpecialViewStart = 50,
		[Token(Token = "0x4003251")]
		MallTabTypeGiftLeadBoard = 51,
		[Token(Token = "0x4003252")]
		MallTabHide = 99
	}

	[Token(Token = "0x200029B")]
	public enum UINavigationVaultType
	{
		[Token(Token = "0x4003254")]
		ChangeClothes = 1,
		[Token(Token = "0x4003255")]
		ChangeApperance,
		[Token(Token = "0x4003256")]
		SelectBundle
	}

	[Token(Token = "0x200029C")]
	public enum UINavigationElitePassType
	{
		[Token(Token = "0x4003258")]
		ElitePass = 1,
		[Token(Token = "0x4003259")]
		ElitePassChallenge,
		[Token(Token = "0x400325A")]
		ElitePassPurchaseBadge,
		[Token(Token = "0x400325B")]
		ElitePassUpgrade,
		[Token(Token = "0x400325C")]
		ElitePassPreorder,
		[Token(Token = "0x400325D")]
		ElitePassSubscription
	}

	[Token(Token = "0x200029D")]
	public enum UINavigationFriendType
	{
		[Token(Token = "0x400325F")]
		PlatformFriends = 1,
		[Token(Token = "0x4003260")]
		GameFriends,
		[Token(Token = "0x4003261")]
		Requests,
		[Token(Token = "0x4003262")]
		Search,
		[Token(Token = "0x4003263")]
		Reunion,
		[Token(Token = "0x4003264")]
		Relationship,
		[Token(Token = "0x4003265")]
		TrainingCamp
	}

	[Token(Token = "0x200029E")]
	public enum UINavigationClanType
	{
		[Token(Token = "0x4003267")]
		Clan = 1,
		[Token(Token = "0x4003268")]
		SrarchClanById
	}

	[Token(Token = "0x200029F")]
	public class GotoParams
	{
		[Token(Token = "0x4003269")]
		[FieldOffset(Offset = "0x8")]
		public ulong SubType1;

		[Token(Token = "0x400326A")]
		[FieldOffset(Offset = "0x10")]
		public ulong SubType2;

		[Token(Token = "0x400326B")]
		[FieldOffset(Offset = "0x18")]
		public ulong SubType3;

		[Token(Token = "0x400326C")]
		[FieldOffset(Offset = "0x20")]
		public string Param;

		[Token(Token = "0x400326D")]
		[FieldOffset(Offset = "0x24")]
		public object Extra;

		[Token(Token = "0x400326E")]
		[FieldOffset(Offset = "0x28")]
		public string SpecialFromLogName;

		[Token(Token = "0x6000D1C")]
		[Address(RVA = "0x2797D30", Offset = "0x2797D30", VA = "0x2797D30")]
		public GotoParams()
		{
		}
	}

	[Token(Token = "0x20002A0")]
	public class ShowRewardsParams
	{
		[Token(Token = "0x400326F")]
		[FieldOffset(Offset = "0x8")]
		public uint ItemID;

		[Token(Token = "0x4003270")]
		[FieldOffset(Offset = "0xC")]
		public uint Count;

		[Token(Token = "0x4003271")]
		[FieldOffset(Offset = "0x10")]
		public ExchangeChangeData Data;

		[Token(Token = "0x4003272")]
		[FieldOffset(Offset = "0x14")]
		public bool needRemoveDeleteItem;

		[Token(Token = "0x6000D1D")]
		[Address(RVA = "0x2797D38", Offset = "0x2797D38", VA = "0x2797D38")]
		public ShowRewardsParams()
		{
		}
	}

	[Token(Token = "0x20002A1")]
	public class WebViewOptions
	{
		[Token(Token = "0x20002A2")]
		public enum WebViewStyle
		{
			[Token(Token = "0x4003279")]
			Normal,
			[Token(Token = "0x400327A")]
			Lite,
			[Token(Token = "0x400327B")]
			Tutorial
		}

		[Token(Token = "0x4003273")]
		[FieldOffset(Offset = "0x8")]
		public WebViewStyle Style;

		[Token(Token = "0x4003274")]
		[FieldOffset(Offset = "0xC")]
		public bool PrefersExternal;

		[Token(Token = "0x4003275")]
		[FieldOffset(Offset = "0xD")]
		public bool RecordTime;

		[Token(Token = "0x4003276")]
		[FieldOffset(Offset = "0x10")]
		public string Title;

		[Token(Token = "0x4003277")]
		[FieldOffset(Offset = "0x14")]
		public Action CloseCallBack;

		[Token(Token = "0x6000D1E")]
		[Address(RVA = "0x2797D48", Offset = "0x2797D48", VA = "0x2797D48")]
		public WebViewOptions()
		{
		}
	}

	[Token(Token = "0x20002A3")]
	public enum UINavigationLadderMatchType
	{
		[Token(Token = "0x400327D")]
		LadderMatch,
		[Token(Token = "0x400327E")]
		CSLadderMatch,
		[Token(Token = "0x400327F")]
		PeriodicLadderMatch
	}

	[Token(Token = "0x20002A4")]
	private sealed class _003CGoToBigEvent_003Ec__AnonStorey0
	{
		[Token(Token = "0x4003280")]
		[FieldOffset(Offset = "0x8")]
		internal UINavigationData naviDataSimple;

		[Token(Token = "0x6000D1F")]
		[Address(RVA = "0x2797A24", Offset = "0x2797A24", VA = "0x2797A24")]
		public _003CGoToBigEvent_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6000D20")]
		[Address(RVA = "0x2797A2C", Offset = "0x2797A2C", VA = "0x2797A2C")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x20002A5")]
	private sealed class _003CShowRewards_003Ec__AnonStorey2
	{
		[Token(Token = "0x4003281")]
		[FieldOffset(Offset = "0x8")]
		internal ShowRewardsParams param;

		[Token(Token = "0x6000D21")]
		[Address(RVA = "0x2797D28", Offset = "0x2797D28", VA = "0x2797D28")]
		public _003CShowRewards_003Ec__AnonStorey2()
		{
		}
	}

	[Token(Token = "0x20002A6")]
	private sealed class _003CShowRewards_003Ec__AnonStorey1
	{
		[Token(Token = "0x4003282")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelMall mall;

		[Token(Token = "0x4003283")]
		[FieldOffset(Offset = "0xC")]
		internal _003CShowRewards_003Ec__AnonStorey2 _003C_003Ef__ref_00242;

		[Token(Token = "0x6000D22")]
		[Address(RVA = "0x2797B00", Offset = "0x2797B00", VA = "0x2797B00")]
		public _003CShowRewards_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6000D23")]
		[Address(RVA = "0x2797B08", Offset = "0x2797B08", VA = "0x2797B08")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6000D24")]
		[Address(RVA = "0x2797B68", Offset = "0x2797B68", VA = "0x2797B68")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6000D25")]
		[Address(RVA = "0x2797BC8", Offset = "0x2797BC8", VA = "0x2797BC8")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6000D26")]
		[Address(RVA = "0x2797C84", Offset = "0x2797C84", VA = "0x2797C84")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x20002A7")]
	private sealed class _003CAssembleRewardsList_003Ec__AnonStorey3
	{
		[Token(Token = "0x4003284")]
		[FieldOffset(Offset = "0x8")]
		internal ExchangeChangeData data;

		[Token(Token = "0x6000D27")]
		[Address(RVA = "0x2797930", Offset = "0x2797930", VA = "0x2797930")]
		public _003CAssembleRewardsList_003Ec__AnonStorey3()
		{
		}
	}

	[Token(Token = "0x20002A8")]
	private sealed class _003CAssembleRewardsList_003Ec__AnonStorey4
	{
		[Token(Token = "0x4003285")]
		[FieldOffset(Offset = "0x8")]
		internal int j;

		[Token(Token = "0x4003286")]
		[FieldOffset(Offset = "0xC")]
		internal _003CAssembleRewardsList_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

		[Token(Token = "0x6000D28")]
		[Address(RVA = "0x2797938", Offset = "0x2797938", VA = "0x2797938")]
		public _003CAssembleRewardsList_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6000D29")]
		[Address(RVA = "0x2797940", Offset = "0x2797940", VA = "0x2797940")]
		internal bool _003C_003Em__0(Item x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4003146")]
	[FieldOffset(Offset = "0x0")]
	private static string[] V2NaviDataArray;

	[Token(Token = "0x4003147")]
	[FieldOffset(Offset = "0x4")]
	public static Dictionary<int, OtherChannelInfo> CommercialChannelInfo;

	[Token(Token = "0x4003148")]
	private const int m_RandomMapId = 99;

	[Token(Token = "0x4003149")]
	[FieldOffset(Offset = "0x8")]
	private static UINavigationFrom _003CFrom_003Ek__BackingField;

	[Token(Token = "0x400314A")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17000176")]
	public static UINavigationFrom From
	{
		[Token(Token = "0x6000CBF")]
		[Address(RVA = "0x1B44E6C", Offset = "0x1B44E6C", VA = "0x1B44E6C")]
		get
		{
			return default(UINavigationFrom);
		}
		[Token(Token = "0x6000CC0")]
		[Address(RVA = "0x1B44EF8", Offset = "0x1B44EF8", VA = "0x1B44EF8")]
		private set
		{
		}
	}

	[Token(Token = "0x6000C96")]
	[Address(RVA = "0x1B353D0", Offset = "0x1B353D0", VA = "0x1B353D0")]
	public static void GoToV2Navigation(UINavigationFrom from, uint gopos, string param)
	{
	}

	[Token(Token = "0x6000C97")]
	private static object GetV2NaviDataValue<T>(string dataKey, T dataValue)
	{
		return null;
	}

	[Token(Token = "0x6000C98")]
	[Address(RVA = "0x1B3650C", Offset = "0x1B3650C", VA = "0x1B3650C")]
	private static void GoToV2SceneEditUGCCenter()
	{
	}

	[Token(Token = "0x6000C99")]
	[Address(RVA = "0x1B36608", Offset = "0x1B36608", VA = "0x1B36608")]
	private static void GoToV2MysteryMall()
	{
	}

	[Token(Token = "0x6000C9A")]
	[Address(RVA = "0x1B36704", Offset = "0x1B36704", VA = "0x1B36704")]
	private static void GoToV2Profile()
	{
	}

	[Token(Token = "0x6000C9B")]
	[Address(RVA = "0x1B36828", Offset = "0x1B36828", VA = "0x1B36828")]
	private static void GoToV2Group()
	{
	}

	[Token(Token = "0x6000C9C")]
	[Address(RVA = "0x1B36924", Offset = "0x1B36924", VA = "0x1B36924")]
	private static void GoToV2Mall()
	{
	}

	[Token(Token = "0x6000C9D")]
	[Address(RVA = "0x1B36B54", Offset = "0x1B36B54", VA = "0x1B36B54")]
	private static void GoToV2Vault()
	{
	}

	[Token(Token = "0x6000C9E")]
	[Address(RVA = "0x1B36C7C", Offset = "0x1B36C7C", VA = "0x1B36C7C")]
	private static void GoToV2Clan()
	{
	}

	[Token(Token = "0x6000C9F")]
	[Address(RVA = "0x1B376C8", Offset = "0x1B376C8", VA = "0x1B376C8")]
	private static void GoToV2Activity()
	{
	}

	[Token(Token = "0x6000CA0")]
	[Address(RVA = "0x1B37A48", Offset = "0x1B37A48", VA = "0x1B37A48")]
	private static void GoToV2Friends()
	{
	}

	[Token(Token = "0x6000CA1")]
	[Address(RVA = "0x1B3812C", Offset = "0x1B3812C", VA = "0x1B3812C")]
	private static void GoToV2AvatarProfile()
	{
	}

	[Token(Token = "0x6000CA2")]
	[Address(RVA = "0x1B38228", Offset = "0x1B38228", VA = "0x1B38228")]
	private static void GoToV2ElitePass()
	{
	}

	[Token(Token = "0x6000CA3")]
	[Address(RVA = "0x1B38350", Offset = "0x1B38350", VA = "0x1B38350")]
	private static void GoToV2Gacha()
	{
	}

	[Token(Token = "0x6000CA4")]
	[Address(RVA = "0x1B386AC", Offset = "0x1B386AC", VA = "0x1B386AC")]
	private static void GoToV2Chat()
	{
	}

	[Token(Token = "0x6000CA5")]
	[Address(RVA = "0x1B387C4", Offset = "0x1B387C4", VA = "0x1B387C4")]
	private static void GoToV2Forge()
	{
	}

	[Token(Token = "0x6000CA6")]
	[Address(RVA = "0x1B38B70", Offset = "0x1B38B70", VA = "0x1B38B70")]
	private static void GoToV2LeaderBoard()
	{
	}

	[Token(Token = "0x6000CA7")]
	[Address(RVA = "0x1B38D28", Offset = "0x1B38D28", VA = "0x1B38D28")]
	private static void GotoV2LadderMatch()
	{
	}

	[Token(Token = "0x6000CA8")]
	[Address(RVA = "0x1B38E24", Offset = "0x1B38E24", VA = "0x1B38E24")]
	private static void GoToV2Payment()
	{
	}

	[Token(Token = "0x6000CA9")]
	[Address(RVA = "0x1B39180", Offset = "0x1B39180", VA = "0x1B39180")]
	private static void GoToV2MemberShip()
	{
	}

	[Token(Token = "0x6000CAA")]
	[Address(RVA = "0x1B393B8", Offset = "0x1B393B8", VA = "0x1B393B8")]
	private static void GoToV2Championship()
	{
	}

	[Token(Token = "0x6000CAB")]
	[Address(RVA = "0x1B39724", Offset = "0x1B39724", VA = "0x1B39724")]
	private static void GotoV2ChampionshipOtherTeam()
	{
	}

	[Token(Token = "0x6000CAC")]
	[Address(RVA = "0x1B39898", Offset = "0x1B39898", VA = "0x1B39898")]
	private static void GoToV2Task()
	{
	}

	[Token(Token = "0x6000CAD")]
	[Address(RVA = "0x1B39BD0", Offset = "0x1B39BD0", VA = "0x1B39BD0")]
	private static void GoToV2Veteran()
	{
	}

	[Token(Token = "0x6000CAE")]
	[Address(RVA = "0x1B39CCC", Offset = "0x1B39CCC", VA = "0x1B39CCC")]
	private static void GoToV2SubscriptionHub()
	{
	}

	[Token(Token = "0x6000CAF")]
	[Address(RVA = "0x1B39ED0", Offset = "0x1B39ED0", VA = "0x1B39ED0")]
	private static void GoToV2EPTask()
	{
	}

	[Token(Token = "0x6000CB0")]
	[Address(RVA = "0x1B39FCC", Offset = "0x1B39FCC", VA = "0x1B39FCC")]
	private static void GoToV2Mail()
	{
	}

	[Token(Token = "0x6000CB1")]
	[Address(RVA = "0x1B3AF0C", Offset = "0x1B3AF0C", VA = "0x1B3AF0C")]
	private static void GoToV2AvatarAwaken()
	{
	}

	[Token(Token = "0x6000CB2")]
	[Address(RVA = "0x1B3B10C", Offset = "0x1B3B10C", VA = "0x1B3B10C")]
	private static void GoToV2CupMatch()
	{
	}

	[Token(Token = "0x6000CB3")]
	[Address(RVA = "0x1B3B234", Offset = "0x1B3B234", VA = "0x1B3B234")]
	private static void GoToV2CupMatchOtherTeam()
	{
	}

	[Token(Token = "0x6000CB4")]
	[Address(RVA = "0x1B3A0C8", Offset = "0x1B3A0C8", VA = "0x1B3A0C8")]
	private static void GotoV2MapMode()
	{
	}

	[Token(Token = "0x6000CB5")]
	[Address(RVA = "0x1B3B9BC", Offset = "0x1B3B9BC", VA = "0x1B3B9BC")]
	private static void GoToV2BigEvent()
	{
	}

	[Token(Token = "0x6000CB6")]
	[Address(RVA = "0x1B3BB4C", Offset = "0x1B3BB4C", VA = "0x1B3BB4C")]
	private static void GoToV2WevView()
	{
	}

	[Token(Token = "0x6000CB7")]
	[Address(RVA = "0x1B3BD0C", Offset = "0x1B3BD0C", VA = "0x1B3BD0C")]
	private static void GoToV2NewVault()
	{
	}

	[Token(Token = "0x6000CB8")]
	[Address(RVA = "0x1B3C120", Offset = "0x1B3C120", VA = "0x1B3C120")]
	public static void GotoNewPlayer()
	{
	}

	[Token(Token = "0x6000CB9")]
	[Address(RVA = "0x1B3C390", Offset = "0x1B3C390", VA = "0x1B3C390")]
	private static void GotoAvatarLink()
	{
	}

	[Token(Token = "0x6000CBA")]
	[Address(RVA = "0x1B3C53C", Offset = "0x1B3C53C", VA = "0x1B3C53C")]
	private static void GotoHyperBookshelf()
	{
	}

	[Token(Token = "0x6000CBB")]
	[Address(RVA = "0x1B3C598", Offset = "0x1B3C598", VA = "0x1B3C598")]
	private static void GotoHyperBookContent()
	{
	}

	[Token(Token = "0x6000CBC")]
	[Address(RVA = "0x1B3CC44", Offset = "0x1B3CC44", VA = "0x1B3CC44")]
	private static void GotoSecretMessageRedeem()
	{
	}

	[Token(Token = "0x6000CBD")]
	[Address(RVA = "0x1B3CAA8", Offset = "0x1B3CAA8", VA = "0x1B3CAA8")]
	private static void GotoSecretMessageGenerate()
	{
	}

	[Token(Token = "0x6000CBE")]
	[Address(RVA = "0x1B3C7D0", Offset = "0x1B3C7D0", VA = "0x1B3C7D0")]
	private static void GotoFlashStore()
	{
	}

	[Token(Token = "0x6000CC1")]
	[Address(RVA = "0x1B44F88", Offset = "0x1B44F88", VA = "0x1B44F88")]
	public static void GotoNavigation(UINavigationFrom from, UINavigationPageType to, [Optional] GotoParams gotoParams, [Optional] UINavigationData navigationData)
	{
	}

	[Token(Token = "0x6000CC2")]
	[Address(RVA = "0x1B3B7AC", Offset = "0x1B3B7AC", VA = "0x1B3B7AC")]
	public static void GoToBigEventTemplate()
	{
	}

	[Token(Token = "0x6000CC3")]
	[Address(RVA = "0x1B436A4", Offset = "0x1B436A4", VA = "0x1B436A4")]
	public static void GoToBigEvent(proto.ELimitedEvent.EventID eventID, UIModelBigEvent.EBigEventEntranceID entranceId, string param, ulong subType3, object extra)
	{
	}

	[Token(Token = "0x6000CC4")]
	[Address(RVA = "0x1B47B0C", Offset = "0x1B47B0C", VA = "0x1B47B0C")]
	public static void GotoTermsOfService()
	{
	}

	[Token(Token = "0x6000CC5")]
	[Address(RVA = "0x1B47E20", Offset = "0x1B47E20", VA = "0x1B47E20")]
	public static void GotoPrivacyPolicy()
	{
	}

	[Token(Token = "0x6000CC6")]
	[Address(RVA = "0x1B48134", Offset = "0x1B48134", VA = "0x1B48134")]
	public static void GotoCustomerService()
	{
	}

	[Token(Token = "0x6000CC7")]
	[Address(RVA = "0x1B484A8", Offset = "0x1B484A8", VA = "0x1B484A8")]
	public static void GotoCustomerDelAccount()
	{
	}

	[Token(Token = "0x6000CC8")]
	[Address(RVA = "0x1B44704", Offset = "0x1B44704", VA = "0x1B44704")]
	public static void GotoWebView(UINavigationFrom from, string url, [Optional] object extra)
	{
	}

	[Token(Token = "0x6000CC9")]
	[Address(RVA = "0x1B48EEC", Offset = "0x1B48EEC", VA = "0x1B48EEC")]
	public static void GotoTutorialWebView(UINavigationFrom from, string url, [Optional] object extra, [Optional] Action callback)
	{
	}

	[Token(Token = "0x6000CCA")]
	[Address(RVA = "0x1B2AF38", Offset = "0x1B2AF38", VA = "0x1B2AF38")]
	public static void GotoNavigation(UINavigationFrom from, uint gotoPos, [Optional] string param, [Optional] object extra, string specialFromName = "")
	{
	}

	[Token(Token = "0x6000CCB")]
	[Address(RVA = "0x1B4937C", Offset = "0x1B4937C", VA = "0x1B4937C")]
	public static bool GotoNavigationByConfig(UINavigationFrom from, GoPos goPosObject)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CCC")]
	[Address(RVA = "0x1B47080", Offset = "0x1B47080", VA = "0x1B47080")]
	public static string GetBigEventLogName(proto.ELimitedEvent.EventID bigEventId, UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return null;
	}

	[Token(Token = "0x6000CCD")]
	[Address(RVA = "0x1B47248", Offset = "0x1B47248", VA = "0x1B47248")]
	public static string GetGachaNavigateLogName(uint chestID)
	{
		return null;
	}

	[Token(Token = "0x6000CCE")]
	[Address(RVA = "0x1B47444", Offset = "0x1B47444", VA = "0x1B47444")]
	public static string GetLadderMatchDetailNavigationlogName(string gameName)
	{
		return null;
	}

	[Token(Token = "0x6000CCF")]
	[Address(RVA = "0x1B2AE68", Offset = "0x1B2AE68", VA = "0x1B2AE68")]
	public static uint MakeGoPos(UINavigationPageType mainType, uint subType1 = 0u, uint subType2 = 0u, uint subType3 = 0u)
	{
		return default(uint);
	}

	[Token(Token = "0x6000CD0")]
	[Address(RVA = "0x1B494EC", Offset = "0x1B494EC", VA = "0x1B494EC")]
	public static uint GetBigEventGopos(proto.ELimitedEvent.EventID bigEventId, UIModelBigEvent.EBigEventEntranceID entranceID)
	{
		return default(uint);
	}

	[Token(Token = "0x6000CD1")]
	[Address(RVA = "0x1B49188", Offset = "0x1B49188", VA = "0x1B49188")]
	public static uint GetMainType(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x6000CD2")]
	[Address(RVA = "0x1B491F8", Offset = "0x1B491F8", VA = "0x1B491F8")]
	public static uint GetSubType1(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x6000CD3")]
	[Address(RVA = "0x1B49274", Offset = "0x1B49274", VA = "0x1B49274")]
	private static uint GetSubType2(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x6000CD4")]
	[Address(RVA = "0x1B492F8", Offset = "0x1B492F8", VA = "0x1B492F8")]
	private static uint GetSubType3(uint gotoPos)
	{
		return default(uint);
	}

	[Token(Token = "0x6000CD5")]
	[Address(RVA = "0x1B495D4", Offset = "0x1B495D4", VA = "0x1B495D4")]
	public static void ReturnToLobby()
	{
	}

	[Token(Token = "0x6000CD6")]
	[Address(RVA = "0x1B3D740", Offset = "0x1B3D740", VA = "0x1B3D740")]
	private static void GotoProfilePage(ulong accountId, UINavagationProfileType subType, ulong subtype3, bool reuseCache = true)
	{
	}

	[Token(Token = "0x6000CD7")]
	[Address(RVA = "0x1B3DB10", Offset = "0x1B3DB10", VA = "0x1B3DB10")]
	private static void GotoGroup(UINavigationGroupType groupType)
	{
	}

	[Token(Token = "0x6000CD8")]
	[Address(RVA = "0x1B3DCE0", Offset = "0x1B3DCE0", VA = "0x1B3DCE0")]
	public static void GotoMall(UINavigationFrom from, UINavigationMallType mallType, uint mallTabType = 0u, uint subType = 0u, [Optional] List<uint> itemIDList, [Optional] List<FriendInfo> lobbySeletFriendList, EGiftStore_BuddyType type = EGiftStore_BuddyType.BT_NONE, CollectionDataManager.ECollectionWeaponType weaponPageFilterType = CollectionDataManager.ECollectionWeaponType.all, uint weaponPageFilterId = 0u, uint weaponClickId = 0u)
	{
	}

	[Token(Token = "0x6000CD9")]
	[Address(RVA = "0x1B3E2DC", Offset = "0x1B3E2DC", VA = "0x1B3E2DC")]
	private static void GotoVault(UINavigationVaultType vaultType, uint bundleItemID)
	{
	}

	[Token(Token = "0x6000CDA")]
	[Address(RVA = "0x1B38F78", Offset = "0x1B38F78", VA = "0x1B38F78")]
	private static void GotoPet()
	{
	}

	[Token(Token = "0x6000CDB")]
	[Address(RVA = "0x1B3E3F0", Offset = "0x1B3E3F0", VA = "0x1B3E3F0")]
	private static void GotoClan(UINavigationClanType subType, string param)
	{
	}

	[Token(Token = "0x6000CDC")]
	[Address(RVA = "0x1B36E78", Offset = "0x1B36E78", VA = "0x1B36E78")]
	private static void GotoPayment(UIPaymentController.Tab tab, UIPaymentController.EBundleType type = UIPaymentController.EBundleType.Default, uint groupId = 0u)
	{
	}

	[Token(Token = "0x6000CDD")]
	[Address(RVA = "0x1B496C4", Offset = "0x1B496C4", VA = "0x1B496C4")]
	public static bool TryProcessGotoIAPOrMshop(UIPaymentController.Tab tab, out UIPaymentController.Tab resultTab)
	{
		return default(bool);
	}

	[Token(Token = "0x6000CDE")]
	[Address(RVA = "0x1B41294", Offset = "0x1B41294", VA = "0x1B41294")]
	private static void GotoSubscriptionHub(uint store_id = 0u)
	{
	}

	[Token(Token = "0x6000CDF")]
	[Address(RVA = "0x1B39DC8", Offset = "0x1B39DC8", VA = "0x1B39DC8")]
	private static void GotoPaymentFirstTimeWindow()
	{
	}

	[Token(Token = "0x6000CE0")]
	[Address(RVA = "0x1B49C58", Offset = "0x1B49C58", VA = "0x1B49C58")]
	private static void GotoRebateCard()
	{
	}

	[Token(Token = "0x6000CE1")]
	[Address(RVA = "0x1B38498", Offset = "0x1B38498", VA = "0x1B38498")]
	private static void GotoIAPBundle([Optional] IAPBundleStoreData data)
	{
	}

	[Token(Token = "0x6000CE2")]
	[Address(RVA = "0x1B477A4", Offset = "0x1B477A4", VA = "0x1B477A4")]
	private static void GotoVeteranDailyMission()
	{
	}

	[Token(Token = "0x6000CE3")]
	[Address(RVA = "0x1B49DF4", Offset = "0x1B49DF4", VA = "0x1B49DF4")]
	public static void ShowRewards(ShowRewardsParams param)
	{
	}

	[Token(Token = "0x6000CE4")]
	[Address(RVA = "0x1B4A67C", Offset = "0x1B4A67C", VA = "0x1B4A67C")]
	public static List<BaseItemInfo> AssembleRewardsList(ExchangeChangeData data, bool needRemoveDeleteItem = true)
	{
		return null;
	}

	[Token(Token = "0x6000CE5")]
	[Address(RVA = "0x1B4ABE4", Offset = "0x1B4ABE4", VA = "0x1B4ABE4")]
	private static List<CommonRewardItemInfo> FixPetRewardLevel(List<CommonRewardItemInfo> list)
	{
		return null;
	}

	[Token(Token = "0x6000CE6")]
	[Address(RVA = "0x1B488C0", Offset = "0x1B488C0", VA = "0x1B488C0")]
	private static void OpenWebView(string url, [Optional] WebViewOptions options)
	{
	}

	[Token(Token = "0x6000CE7")]
	[Address(RVA = "0x1B4AE4C", Offset = "0x1B4AE4C", VA = "0x1B4AE4C")]
	private static void _OpenWebView(string url, WebViewOptions options)
	{
	}

	[Token(Token = "0x6000CE8")]
	[Address(RVA = "0x1B389F4", Offset = "0x1B389F4", VA = "0x1B389F4")]
	private static void GotoGainItemPreview()
	{
	}

	[Token(Token = "0x6000CE9")]
	[Address(RVA = "0x1B3FE3C", Offset = "0x1B3FE3C", VA = "0x1B3FE3C")]
	private static void GotoLadderMatch(uint subType1 = 0u)
	{
	}

	[Token(Token = "0x6000CEA")]
	[Address(RVA = "0x1B3E620", Offset = "0x1B3E620", VA = "0x1B3E620")]
	private static void GotoActivityByTabtype(uint tabType, uint id = 0u)
	{
	}

	[Token(Token = "0x6000CEB")]
	[Address(RVA = "0x1B3E7D4", Offset = "0x1B3E7D4", VA = "0x1B3E7D4")]
	private static void GotoActivity(UIActivityMasterController.ActivityCategory actvType, uint id = 0u)
	{
	}

	[Token(Token = "0x6000CEC")]
	[Address(RVA = "0x1B418BC", Offset = "0x1B418BC", VA = "0x1B418BC")]
	private static void GotoMail(uint id = 0u)
	{
	}

	[Token(Token = "0x6000CED")]
	private static T GetActivityPopUpWindow<T>() where T : UIPopupWindowController
	{
		return null;
	}

	[Token(Token = "0x6000CEE")]
	[Address(RVA = "0x1B3E988", Offset = "0x1B3E988", VA = "0x1B3E988")]
	private static void GotoFriends(UINavigationFriendType subType)
	{
	}

	[Token(Token = "0x6000CEF")]
	[Address(RVA = "0x1B37B44", Offset = "0x1B37B44", VA = "0x1B37B44")]
	private static void GotoLoadout()
	{
	}

	[Token(Token = "0x6000CF0")]
	[Address(RVA = "0x1B37C4C", Offset = "0x1B37C4C", VA = "0x1B37C4C")]
	private static void GotoSettings()
	{
	}

	[Token(Token = "0x6000CF1")]
	[Address(RVA = "0x1B37D78", Offset = "0x1B37D78", VA = "0x1B37D78")]
	private static void GotoTutorial()
	{
	}

	[Token(Token = "0x6000CF2")]
	[Address(RVA = "0x1B3ED6C", Offset = "0x1B3ED6C", VA = "0x1B3ED6C")]
	private static void GotoAvatarProfile(uint avatarid)
	{
	}

	[Token(Token = "0x6000CF3")]
	[Address(RVA = "0x1B3EF04", Offset = "0x1B3EF04", VA = "0x1B3EF04")]
	private static void GotoElitePassControllers(UINavigationElitePassType subType1, uint subType2)
	{
	}

	[Token(Token = "0x6000CF4")]
	[Address(RVA = "0x1B4B5BC", Offset = "0x1B4B5BC", VA = "0x1B4B5BC")]
	private static void GotoElitePassPreorder()
	{
	}

	[Token(Token = "0x6000CF5")]
	[Address(RVA = "0x1B4B3D4", Offset = "0x1B4B3D4", VA = "0x1B4B3D4")]
	private static void GotoElitePassUpgrade()
	{
	}

	[Token(Token = "0x6000CF6")]
	[Address(RVA = "0x1B4BA48", Offset = "0x1B4BA48", VA = "0x1B4BA48")]
	private static void GotoElitePass()
	{
	}

	[Token(Token = "0x6000CF7")]
	[Address(RVA = "0x1B40FB4", Offset = "0x1B40FB4", VA = "0x1B40FB4")]
	private static void GotoTask(int tab)
	{
	}

	[Token(Token = "0x6000CF8")]
	[Address(RVA = "0x1B41768", Offset = "0x1B41768", VA = "0x1B41768")]
	private static void GotoEPTask(int tab)
	{
	}

	[Token(Token = "0x6000CF9")]
	[Address(RVA = "0x1B4B160", Offset = "0x1B4B160", VA = "0x1B4B160")]
	private static void GotoElitePassPurchaseBadge(uint count = 1u)
	{
	}

	[Token(Token = "0x6000CFA")]
	[Address(RVA = "0x1B4B7A4", Offset = "0x1B4B7A4", VA = "0x1B4B7A4")]
	private static void GotoElitePassSubscription()
	{
	}

	[Token(Token = "0x6000CFB")]
	[Address(RVA = "0x1B411B8", Offset = "0x1B411B8", VA = "0x1B411B8")]
	public static UIBaseController GotoVeteran(int tab)
	{
		return null;
	}

	[Token(Token = "0x6000CFC")]
	[Address(RVA = "0x1B47520", Offset = "0x1B47520", VA = "0x1B47520")]
	public static void GotoVeteranGuideance()
	{
	}

	[Token(Token = "0x6000CFD")]
	[Address(RVA = "0x1B47948", Offset = "0x1B47948", VA = "0x1B47948")]
	public static void GotoDownloadCenter(uint tab = 0u)
	{
	}

	[Token(Token = "0x6000CFE")]
	[Address(RVA = "0x1B3AA94", Offset = "0x1B3AA94", VA = "0x1B3AA94")]
	public static void GotoChampionshipWarmUp()
	{
	}

	[Token(Token = "0x6000CFF")]
	[Address(RVA = "0x1B3ACD0", Offset = "0x1B3ACD0", VA = "0x1B3ACD0")]
	public static void GotoChampionshipDefault()
	{
	}

	[Token(Token = "0x6000D00")]
	[Address(RVA = "0x1B3D0B8", Offset = "0x1B3D0B8", VA = "0x1B3D0B8")]
	public static void GoToMysteryMall(uint shopId)
	{
	}

	[Token(Token = "0x6000D01")]
	[Address(RVA = "0x1B3CDE0", Offset = "0x1B3CDE0", VA = "0x1B3CDE0")]
	public static void GoToSceneEditUGCCenter(uint tabType)
	{
	}

	[Token(Token = "0x6000D02")]
	[Address(RVA = "0x1B4BC30", Offset = "0x1B4BC30", VA = "0x1B4BC30")]
	public static void GotoLegendClothVault(LegendClothVaultPageType pageType, uint legendId = 1u)
	{
	}

	[Token(Token = "0x6000D03")]
	[Address(RVA = "0x1B3A280", Offset = "0x1B3A280", VA = "0x1B3A280")]
	public static void GotoWeaponSkinMain()
	{
	}

	[Token(Token = "0x6000D04")]
	[Address(RVA = "0x1B3A468", Offset = "0x1B3A468", VA = "0x1B3A468")]
	public static void GotoDressUpMain()
	{
	}

	[Token(Token = "0x6000D05")]
	[Address(RVA = "0x1B4BF74", Offset = "0x1B4BF74", VA = "0x1B4BF74")]
	public static void GotoWeaponSkinMain(uint skinId)
	{
	}

	[Token(Token = "0x6000D06")]
	[Address(RVA = "0x1B4C1E8", Offset = "0x1B4C1E8", VA = "0x1B4C1E8")]
	public static void GotoWeaponSkinMainForce(uint skinId, bool forcerefresh)
	{
	}

	[Token(Token = "0x6000D07")]
	[Address(RVA = "0x1B3A67C", Offset = "0x1B3A67C", VA = "0x1B3A67C")]
	public static void GotoWeaponSkinUpgrader(SkinOwnAndOpenInfo info)
	{
	}

	[Token(Token = "0x6000D08")]
	[Address(RVA = "0x1B39994", Offset = "0x1B39994", VA = "0x1B39994")]
	private static void GotoChampionshipLobby()
	{
	}

	[Token(Token = "0x6000D09")]
	[Address(RVA = "0x1B4028C", Offset = "0x1B4028C", VA = "0x1B4028C")]
	private static void GotoChampionship(uint championshipType)
	{
	}

	[Token(Token = "0x6000D0A")]
	[Address(RVA = "0x1B40C64", Offset = "0x1B40C64", VA = "0x1B40C64")]
	private static void GotoChampionshipOtherTeam(UIChampionshipOtherFormController.NavArgs cpNavArgs)
	{
	}

	[Token(Token = "0x6000D0B")]
	[Address(RVA = "0x1B394B4", Offset = "0x1B394B4", VA = "0x1B394B4")]
	private static void GotoChampionshipNormalGameStats([Optional] UIChampionshipGameStatsController.NavArgs args)
	{
	}

	[Token(Token = "0x6000D0C")]
	[Address(RVA = "0x1B41B54", Offset = "0x1B41B54", VA = "0x1B41B54")]
	private static void GotoCupMatch(int cupMatchKey, int gotoPage = 0)
	{
	}

	[Token(Token = "0x6000D0D")]
	[Address(RVA = "0x1B42528", Offset = "0x1B42528", VA = "0x1B42528")]
	private static void GotoCupMatchOtherTeam(UICupMatchOtherFormController.NavArgs cpNavArgs)
	{
	}

	[Token(Token = "0x6000D0E")]
	[Address(RVA = "0x1B3F174", Offset = "0x1B3F174", VA = "0x1B3F174")]
	private static void GotoGacha(int subGoPos = -1, string enterSource = "")
	{
	}

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0x1B4C4D0", Offset = "0x1B4C4D0", VA = "0x1B4C4D0")]
	private static void GotoLobbyGacha(string enterSource)
	{
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0x1B3FAC0", Offset = "0x1B3FAC0", VA = "0x1B3FAC0")]
	private static void GotoForge(uint tabType = 0u, uint itemId = 0u)
	{
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x1B4C6F8", Offset = "0x1B4C6F8", VA = "0x1B4C6F8")]
	public static UINavigationMallTabType ChangeItemtype2MallType(uint itemType)
	{
		return default(UINavigationMallTabType);
	}

	[Token(Token = "0x6000D12")]
	[Address(RVA = "0x1B4C7C0", Offset = "0x1B4C7C0", VA = "0x1B4C7C0")]
	public static UINavigationMallTabType ChangeItemtype2MallType(CSSharedItemDataManager.ItemType itemType)
	{
		return default(UINavigationMallTabType);
	}

	[Token(Token = "0x6000D13")]
	[Address(RVA = "0x1B3F7A4", Offset = "0x1B3F7A4", VA = "0x1B3F7A4")]
	private static void GotoChat(EChannel.ChannelType channelType, ulong channelID = 0uL, [Optional] MessageInfo info)
	{
	}

	[Token(Token = "0x6000D14")]
	[Address(RVA = "0x1B388EC", Offset = "0x1B388EC", VA = "0x1B388EC")]
	private static void GotoRewardedVideo()
	{
	}

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0x1B3FCD0", Offset = "0x1B3FCD0", VA = "0x1B3FCD0")]
	private static void GotoLeaderboard(string deepLink)
	{
	}

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0x1B3907C", Offset = "0x1B3907C", VA = "0x1B3907C")]
	private static void GotoLiveTv()
	{
	}

	[Token(Token = "0x6000D17")]
	[Address(RVA = "0x1B4C884", Offset = "0x1B4C884", VA = "0x1B4C884")]
	public static string MakeGoToMapModeParam(DGNDKMLMLPM matchModeId, JOKABEAPNPP gameModeId, EMapName mapId = EMapName.EMapParadise, int groupPlayerNum = 0)
	{
		return null;
	}

	[Token(Token = "0x6000D18")]
	[Address(RVA = "0x1B4286C", Offset = "0x1B4286C", VA = "0x1B4286C")]
	private static void GotoMapMode(string mapModeIDStr)
	{
	}

	[Token(Token = "0x6000D19")]
	[Address(RVA = "0x1B3B3C0", Offset = "0x1B3B3C0", VA = "0x1B3B3C0")]
	private static void GotoLuckyWheel()
	{
	}

	[Token(Token = "0x6000D1B")]
	[Address(RVA = "0x1B4CF40", Offset = "0x1B4CF40", VA = "0x1B4CF40")]
	private static CommonRewardItemInfo _003CShowRewards_003Em__0(BaseItemInfo item)
	{
		return null;
	}
}
