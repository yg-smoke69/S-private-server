using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2001C33")]
public enum ServiceMessageTypeHTTP
{
	[Token(Token = "0x400B180")]
	LogEvent,
	[Token(Token = "0x400B181")]
	Login,
	[Token(Token = "0x400B182")]
	DebugLogin,
	[Token(Token = "0x400B183")]
	ChooseRegion,
	[Token(Token = "0x400B184")]
	GetPlatformProfile,
	[Token(Token = "0x400B185")]
	AccountMatchStats,
	[Token(Token = "0x400B186")]
	GetWallet,
	[Token(Token = "0x400B187")]
	GetBackpack,
	[Token(Token = "0x400B188")]
	GetCardsAndIAPInfo,
	[Token(Token = "0x400B189")]
	IAPPurchase,
	[Token(Token = "0x400B18A")]
	GetPBWSpecialStoreDesc,
	[Token(Token = "0x400B18B")]
	GetPayBundleWindowDesc,
	[Token(Token = "0x400B18C")]
	PayBundleWindowPurchase,
	[Token(Token = "0x400B18D")]
	GetRebateReward,
	[Token(Token = "0x400B18E")]
	GetRebateSubscriptionBonusStatus,
	[Token(Token = "0x400B18F")]
	Billboard,
	[Token(Token = "0x400B190")]
	GetFriend,
	[Token(Token = "0x400B191")]
	SetFriendAlias,
	[Token(Token = "0x400B192")]
	RemoveFriendAlias,
	[Token(Token = "0x400B193")]
	GetFriendRequestList,
	[Token(Token = "0x400B194")]
	RemoveFriend,
	[Token(Token = "0x400B195")]
	DeclineFriendRequest,
	[Token(Token = "0x400B196")]
	ConfirmFriendRequest,
	[Token(Token = "0x400B197")]
	RequestAddingFriend,
	[Token(Token = "0x400B198")]
	GetBlockList,
	[Token(Token = "0x400B199")]
	BlockPlayer,
	[Token(Token = "0x400B19A")]
	CancelBlock,
	[Token(Token = "0x400B19B")]
	DeclineAllFriendRequests,
	[Token(Token = "0x400B19C")]
	FuzzySearchAccountByName,
	[Token(Token = "0x400B19D")]
	GetAccountInfoByAccountID,
	[Token(Token = "0x400B19E")]
	GetRecommendedPlayersByCondition,
	[Token(Token = "0x400B19F")]
	GetFacebookFriend,
	[Token(Token = "0x400B1A0")]
	GetPlatformFriends,
	[Token(Token = "0x400B1A1")]
	AddStarFriend,
	[Token(Token = "0x400B1A2")]
	RemoveStarFriend,
	[Token(Token = "0x400B1A3")]
	GetStore,
	[Token(Token = "0x400B1A4")]
	Purchase,
	[Token(Token = "0x400B1A5")]
	OpenTreasureBox,
	[Token(Token = "0x400B1A6")]
	GetRecommendedFriend,
	[Token(Token = "0x400B1A7")]
	Leaderboard,
	[Token(Token = "0x400B1A8")]
	GetClanWeekLeaderboardInfo,
	[Token(Token = "0x400B1A9")]
	GetPlayerStats,
	[Token(Token = "0x400B1AA")]
	GetAttendanceList,
	[Token(Token = "0x400B1AB")]
	AttendanceSignin,
	[Token(Token = "0x400B1AC")]
	ChooseLoadout,
	[Token(Token = "0x400B1AD")]
	LinkFacebookAccount,
	[Token(Token = "0x400B1AE")]
	Logout,
	[Token(Token = "0x400B1AF")]
	GetTopNDailyLeaderboard,
	[Token(Token = "0x400B1B0")]
	GetDailyLeaderboardByAccountID,
	[Token(Token = "0x400B1B1")]
	LoginGetSplash,
	[Token(Token = "0x400B1B2")]
	GetPresenceByAccountIds,
	[Token(Token = "0x400B1B3")]
	GetCBTGiftsAnnouncement,
	[Token(Token = "0x400B1B4")]
	ReadCBTGiftsAnnouncement,
	[Token(Token = "0x400B1B5")]
	GetAccountFreshInfo,
	[Token(Token = "0x400B1B6")]
	ClaimFreshSigninRewards,
	[Token(Token = "0x400B1B7")]
	ClaimFreshActivityRewards,
	[Token(Token = "0x400B1B8")]
	MarkProfileStar,
	[Token(Token = "0x400B1B9")]
	GetNewPlayerRewardsList,
	[Token(Token = "0x400B1BA")]
	GetActivityDesc,
	[Token(Token = "0x400B1BB")]
	GetActivityRewards,
	[Token(Token = "0x400B1BC")]
	GetBingoRewardsInfo,
	[Token(Token = "0x400B1BD")]
	FlipBingo,
	[Token(Token = "0x400B1BE")]
	GetBingoRewards,
	[Token(Token = "0x400B1BF")]
	FinishBingoActivity,
	[Token(Token = "0x400B1C0")]
	ActivityTrigger,
	[Token(Token = "0x400B1C1")]
	GetActivenessAndRewardInfo,
	[Token(Token = "0x400B1C2")]
	GetActivenessDesc,
	[Token(Token = "0x400B1C3")]
	GetActivenessReward,
	[Token(Token = "0x400B1C4")]
	QueryOrUploadSettingsInfo,
	[Token(Token = "0x400B1C5")]
	QueryOrDownloadSettingsInfo,
	[Token(Token = "0x400B1C6")]
	CSVConfig,
	[Token(Token = "0x400B1C7")]
	GetMatchDailyBonus,
	[Token(Token = "0x400B1C8")]
	CreateClan,
	[Token(Token = "0x400B1C9")]
	RequestJoinClan,
	[Token(Token = "0x400B1CA")]
	GetClanApplicantListByClanID,
	[Token(Token = "0x400B1CB")]
	ApproveJoinClanApplication,
	[Token(Token = "0x400B1CC")]
	DeclineJoinClanApplication,
	[Token(Token = "0x400B1CD")]
	InviteToClan,
	[Token(Token = "0x400B1CE")]
	ApproveJoinClanInvitation,
	[Token(Token = "0x400B1CF")]
	ChangeMemberTypeByCaptain,
	[Token(Token = "0x400B1D0")]
	ReassignCaptain,
	[Token(Token = "0x400B1D1")]
	RemoveClanMember,
	[Token(Token = "0x400B1D2")]
	QuitClan,
	[Token(Token = "0x400B1D3")]
	GetClanInfoByClanID,
	[Token(Token = "0x400B1D4")]
	GetClanInfoByClanName,
	[Token(Token = "0x400B1D5")]
	FuzzySearchClanByName,
	[Token(Token = "0x400B1D6")]
	GetClanMembers,
	[Token(Token = "0x400B1D7")]
	ModifyClanInfo,
	[Token(Token = "0x400B1D8")]
	ModifyClanName,
	[Token(Token = "0x400B1D9")]
	GetRandomClanList,
	[Token(Token = "0x400B1DA")]
	GetClanWarBasicInfo,
	[Token(Token = "0x400B1DB")]
	GetClanWarTeamMemberStatus,
	[Token(Token = "0x400B1DC")]
	GetClanWarTeamInfo,
	[Token(Token = "0x400B1DD")]
	GetClanWarRecruitInfo,
	[Token(Token = "0x400B1DE")]
	ModifyClanWarRecruitInfo,
	[Token(Token = "0x400B1DF")]
	CreateClanWarTeam,
	[Token(Token = "0x400B1E0")]
	JoinClanWarTeam,
	[Token(Token = "0x400B1E1")]
	QuitClanWarTeam,
	[Token(Token = "0x400B1E2")]
	InviteToClanWarTeam,
	[Token(Token = "0x400B1E3")]
	AppointClanWarTeamCaptain,
	[Token(Token = "0x400B1E4")]
	RemoveClanWarTeamMember,
	[Token(Token = "0x400B1E5")]
	PrepareForClanWar,
	[Token(Token = "0x400B1E6")]
	ApproveJoinClanWarTeamInvitation,
	[Token(Token = "0x400B1E7")]
	CheckAllClanWarMembersPrepareStatus,
	[Token(Token = "0x400B1E8")]
	CheckAccountIsMemberOfClanWarTeam,
	[Token(Token = "0x400B1E9")]
	ClaimClanWarTeamAward,
	[Token(Token = "0x400B1EA")]
	ClaimClanWarPersonalAward,
	[Token(Token = "0x400B1EB")]
	OpenBundle,
	[Token(Token = "0x400B1EC")]
	OpenOptionalBundle,
	[Token(Token = "0x400B1ED")]
	GetLadderMatchLeaderBoardRank,
	[Token(Token = "0x400B1EE")]
	GetProfiles,
	[Token(Token = "0x400B1EF")]
	GetSkills,
	[Token(Token = "0x400B1F0")]
	LoginGetProfile,
	[Token(Token = "0x400B1F1")]
	SetPregameShowChoices,
	[Token(Token = "0x400B1F2")]
	GetLimitedEventEPSetting,
	[Token(Token = "0x400B1F3")]
	GetLimitedEventEPInfo,
	[Token(Token = "0x400B1F4")]
	PurchaseLimitedEventEP,
	[Token(Token = "0x400B1F5")]
	ClaimLimitedEventEPReward,
	[Token(Token = "0x400B1F6")]
	ExchangeLimitedEventEPProgress,
	[Token(Token = "0x400B1F7")]
	GetLimitedEventInventorySetting,
	[Token(Token = "0x400B1F8")]
	GetLimitedEventInventoryInfo,
	[Token(Token = "0x400B1F9")]
	ClaimLimitedEventSettleRewards,
	[Token(Token = "0x400B1FA")]
	SelectProfile,
	[Token(Token = "0x400B1FB")]
	UnlockProfile,
	[Token(Token = "0x400B1FC")]
	UpgradeProfile,
	[Token(Token = "0x400B1FD")]
	EquipSkill,
	[Token(Token = "0x400B1FE")]
	ChangeClothes,
	[Token(Token = "0x400B1FF")]
	MajorModifyNickname,
	[Token(Token = "0x400B200")]
	DismissClan,
	[Token(Token = "0x400B201")]
	ExtendClanScale,
	[Token(Token = "0x400B202")]
	GetPlayerRankingInfo,
	[Token(Token = "0x400B203")]
	GetMailList,
	[Token(Token = "0x400B204")]
	ReadMail,
	[Token(Token = "0x400B205")]
	GetReportMailList,
	[Token(Token = "0x400B206")]
	ReadReportMail,
	[Token(Token = "0x400B207")]
	GetMatchStatsHistory,
	[Token(Token = "0x400B208")]
	ChooseBanner,
	[Token(Token = "0x400B209")]
	ChooseHeadPic,
	[Token(Token = "0x400B20A")]
	ChoosePin,
	[Token(Token = "0x400B20B")]
	ChooseSlots,
	[Token(Token = "0x400B20C")]
	GetRoomList,
	[Token(Token = "0x400B20D")]
	GetAds,
	[Token(Token = "0x400B20E")]
	GetAdvert,
	[Token(Token = "0x400B20F")]
	GetBundle,
	[Token(Token = "0x400B210")]
	GetTreasureBox,
	[Token(Token = "0x400B211")]
	GetEPInfo,
	[Token(Token = "0x400B212")]
	EPPurchase,
	[Token(Token = "0x400B213")]
	EPClaimReward,
	[Token(Token = "0x400B214")]
	EPClaimBadge,
	[Token(Token = "0x400B215")]
	EPPurchaseBadge,
	[Token(Token = "0x400B216")]
	EPPreorder,
	[Token(Token = "0x400B217")]
	GetEPDebrisIngame,
	[Token(Token = "0x400B218")]
	GetDailyQuestRewards,
	[Token(Token = "0x400B219")]
	GetEPTreasureBoxReward,
	[Token(Token = "0x400B21A")]
	GetEPSubscriptionBonusStatus,
	[Token(Token = "0x400B21B")]
	GetDailyChallengeProcessRewards,
	[Token(Token = "0x400B21C")]
	GetCurOrRecentRankingConfig,
	[Token(Token = "0x400B21D")]
	GetGachaDesc,
	[Token(Token = "0x400B21E")]
	GetGachaInfo,
	[Token(Token = "0x400B21F")]
	GetGachaSpecialExchangeDesc,
	[Token(Token = "0x400B220")]
	GetGachaProbability,
	[Token(Token = "0x400B221")]
	ExchangeGachaExtraReward,
	[Token(Token = "0x400B222")]
	PurchaseGacha,
	[Token(Token = "0x400B223")]
	UnlockSkillSlot,
	[Token(Token = "0x400B224")]
	GetAvatarSkillSlots,
	[Token(Token = "0x400B225")]
	GetScrollMarquee,
	[Token(Token = "0x400B226")]
	GetUnlockProfileInfo,
	[Token(Token = "0x400B227")]
	GetGiftStore,
	[Token(Token = "0x400B228")]
	GetGiftStoreDetails,
	[Token(Token = "0x400B229")]
	SendGift,
	[Token(Token = "0x400B22A")]
	GetPlayerPersonalShow,
	[Token(Token = "0x400B22B")]
	GetPlayerBriefInfo,
	[Token(Token = "0x400B22C")]
	GetHeroicInfo,
	[Token(Token = "0x400B22D")]
	GetBattleTag,
	[Token(Token = "0x400B22E")]
	GetFriendIDs,
	[Token(Token = "0x400B22F")]
	GetPlatformFriendIDs,
	[Token(Token = "0x400B230")]
	GetBroadcastList,
	[Token(Token = "0x400B231")]
	MajorDelAccount,
	[Token(Token = "0x400B232")]
	SetShowRank,
	[Token(Token = "0x400B233")]
	GetExchangeStore,
	[Token(Token = "0x400B234")]
	GetWeeklyChallengeProcessRewards,
	[Token(Token = "0x400B235")]
	ExchangeStorePurchase,
	[Token(Token = "0x400B236")]
	GetVeteranRewardList,
	[Token(Token = "0x400B237")]
	VeteranClaimReward,
	[Token(Token = "0x400B238")]
	VeteranTaskTrigger,
	[Token(Token = "0x400B239")]
	GetVeteranTaskDesc,
	[Token(Token = "0x400B23A")]
	GetVeteranTaskInfo,
	[Token(Token = "0x400B23B")]
	GetVeteranTaskRewards,
	[Token(Token = "0x400B23C")]
	GetVeteranTaskBigPrize,
	[Token(Token = "0x400B23D")]
	ClaimVeteranReturnAward,
	[Token(Token = "0x400B23E")]
	ClaimVeteranBundleAward,
	[Token(Token = "0x400B23F")]
	GetVeteranConfigDesc,
	[Token(Token = "0x400B240")]
	ConfirmVeteranBundleItem,
	[Token(Token = "0x400B241")]
	GetTreasureBoxPR,
	[Token(Token = "0x400B242")]
	GetAllSwitchs,
	[Token(Token = "0x400B243")]
	GetHideAvatar,
	[Token(Token = "0x400B244")]
	GetAvatarAwakenTaskInfo,
	[Token(Token = "0x400B245")]
	RefreshAvatarAwakenTaskInfo,
	[Token(Token = "0x400B246")]
	GetAvatarAwakenComicInfo,
	[Token(Token = "0x400B247")]
	UnlockAvatarAwakenComic,
	[Token(Token = "0x400B248")]
	ClaimAwakenTaskRewards,
	[Token(Token = "0x400B249")]
	GetAwakenAvatarByAwakenComic,
	[Token(Token = "0x400B24A")]
	BatchGetSelectedProfiles,
	[Token(Token = "0x400B24B")]
	ClanSignIn,
	[Token(Token = "0x400B24C")]
	TransformGeneralDebris,
	[Token(Token = "0x400B24D")]
	GetClanSignInRewardsByLevel,
	[Token(Token = "0x400B24E")]
	ClaimSignInReward,
	[Token(Token = "0x400B24F")]
	GetClanRaceInfo,
	[Token(Token = "0x400B250")]
	ClaimClanRaceAward,
	[Token(Token = "0x400B251")]
	ExchangeAwardWithRP,
	[Token(Token = "0x400B252")]
	FriendInvite,
	[Token(Token = "0x400B253")]
	GetReturnPlayerDesc,
	[Token(Token = "0x400B254")]
	LoginGetBroadcast,
	[Token(Token = "0x400B255")]
	ChooseEmote,
	[Token(Token = "0x400B256")]
	LoginGetDesc,
	[Token(Token = "0x400B257")]
	GetAttendance,
	[Token(Token = "0x400B258")]
	ChooseShow,
	[Token(Token = "0x400B259")]
	ChooseGameBagShow,
	[Token(Token = "0x400B25A")]
	GetPlayerRankingSeasonStats,
	[Token(Token = "0x400B25B")]
	GetDailyRankingReward,
	[Token(Token = "0x400B25C")]
	GetGiftRankDesc,
	[Token(Token = "0x400B25D")]
	GetGiftRankRewardInfo,
	[Token(Token = "0x400B25E")]
	GetGiftRankReward,
	[Token(Token = "0x400B25F")]
	ChooseRankingCards,
	[Token(Token = "0x400B260")]
	ResetNeedLastSeasonInfo,
	[Token(Token = "0x400B261")]
	GetPetList,
	[Token(Token = "0x400B262")]
	SelectPet,
	[Token(Token = "0x400B263")]
	FeedPet,
	[Token(Token = "0x400B264")]
	RenamePet,
	[Token(Token = "0x400B265")]
	GetPetSkins,
	[Token(Token = "0x400B266")]
	GetPetActions,
	[Token(Token = "0x400B267")]
	SelectPetSkin,
	[Token(Token = "0x400B268")]
	DoGachaSpecialExchange,
	[Token(Token = "0x400B269")]
	EPVideoAdPortal,
	[Token(Token = "0x400B26A")]
	GetAgoraToken,
	[Token(Token = "0x400B26B")]
	BuyChatItems,
	[Token(Token = "0x400B26C")]
	ChoosePVEPrimaryWeapon,
	[Token(Token = "0x400B26D")]
	GetDiscountStore,
	[Token(Token = "0x400B26E")]
	DiscountStorePurchase,
	[Token(Token = "0x400B26F")]
	FestivalAttendanceSignin,
	[Token(Token = "0x400B270")]
	GetFestivalAttendanceInfo,
	[Token(Token = "0x400B271")]
	GetFestivalItemInfo,
	[Token(Token = "0x400B272")]
	FestivalGetRewards,
	[Token(Token = "0x400B273")]
	GetWinnerTakesAllInfo,
	[Token(Token = "0x400B274")]
	GetGoogleRewardsDesc,
	[Token(Token = "0x400B275")]
	GetDigitaluniverseBSettings,
	[Token(Token = "0x400B276")]
	GetDigitaluniverseBInfo,
	[Token(Token = "0x400B277")]
	GetDigitaluniverseBPlayReview,
	[Token(Token = "0x400B278")]
	ClaimDigitaluniverseBMissionAward,
	[Token(Token = "0x400B279")]
	ReadDigitaluniverseBCharacterGateStory,
	[Token(Token = "0x400B27A")]
	InitDigitalUniverseBStarCraftPlayerInfo,
	[Token(Token = "0x400B27B")]
	GetDigitalUniverseBStarCraftSelfInfo,
	[Token(Token = "0x400B27C")]
	GetDigitalUniverseBStarCraftPlayerInfo,
	[Token(Token = "0x400B27D")]
	UpdateDigitalUniverseBStarCraftMessage,
	[Token(Token = "0x400B27E")]
	UpvoteDigitalUniverseBStarCraftMessage,
	[Token(Token = "0x400B27F")]
	AssistDigitalUniverseBStarCraftPlayer,
	[Token(Token = "0x400B280")]
	ClaimDigitalUniverseBStarCraftProgressAward,
	[Token(Token = "0x400B281")]
	NetworkLogEvent,
	[Token(Token = "0x400B282")]
	Settings,
	[Token(Token = "0x400B283")]
	Upload,
	[Token(Token = "0x400B284")]
	GetClanLuckyBagsInfo,
	[Token(Token = "0x400B285")]
	DrawClanLuckyBag,
	[Token(Token = "0x400B286")]
	BatchDrawClanLuckyBag,
	[Token(Token = "0x400B287")]
	GetGameBonusEventDesc,
	[Token(Token = "0x400B288")]
	GetFullscreenCg,
	[Token(Token = "0x400B289")]
	GetClanNews,
	[Token(Token = "0x400B28A")]
	GetManualCollectInfo,
	[Token(Token = "0x400B28B")]
	GetManualAllWeaponRewardStates,
	[Token(Token = "0x400B28C")]
	GetManualAllMapRewardStates,
	[Token(Token = "0x400B28D")]
	GetManualWeaponReward,
	[Token(Token = "0x400B28E")]
	GetManualMapReward,
	[Token(Token = "0x400B28F")]
	CreateTeam,
	[Token(Token = "0x400B290")]
	RequestJoinTeam,
	[Token(Token = "0x400B291")]
	ModifyTeamInfo,
	[Token(Token = "0x400B292")]
	AddTeamContactInfo,
	[Token(Token = "0x400B293")]
	GetTeamInfoByTeamID,
	[Token(Token = "0x400B294")]
	GetTeamMembers,
	[Token(Token = "0x400B295")]
	QuitTeam,
	[Token(Token = "0x400B296")]
	DismissTeam,
	[Token(Token = "0x400B297")]
	GetTeamApplicantListByTeamID,
	[Token(Token = "0x400B298")]
	ApproveJoinTeamApplication,
	[Token(Token = "0x400B299")]
	DeclineJoinTeamApplication,
	[Token(Token = "0x400B29A")]
	InviteToTeam,
	[Token(Token = "0x400B29B")]
	ApproveJoinTeamInvitation,
	[Token(Token = "0x400B29C")]
	DeclineJoinTeamInvitation,
	[Token(Token = "0x400B29D")]
	GetTeamInvitationList,
	[Token(Token = "0x400B29E")]
	GetTeamInvitationListByTeamID,
	[Token(Token = "0x400B29F")]
	FuzzySearchTeamByName,
	[Token(Token = "0x400B2A0")]
	RemoveTeamMember,
	[Token(Token = "0x400B2A1")]
	GetTopupEventInfo,
	[Token(Token = "0x400B2A2")]
	MysteryBonusSpin,
	[Token(Token = "0x400B2A3")]
	GetMysteryBonusProbability,
	[Token(Token = "0x400B2A4")]
	GetInGameBonusPR,
	[Token(Token = "0x400B2A5")]
	InitTeamChampionshipInfo,
	[Token(Token = "0x400B2A6")]
	GetTeamChampionshipInfo,
	[Token(Token = "0x400B2A7")]
	GetChampionshipConfig,
	[Token(Token = "0x400B2A8")]
	GetTeamChampionshipSeasonStats,
	[Token(Token = "0x400B2A9")]
	InstallmentPurchase,
	[Token(Token = "0x400B2AA")]
	GetInstallmentStore,
	[Token(Token = "0x400B2AB")]
	GetInstallmentItems,
	[Token(Token = "0x400B2AC")]
	GetAccountLifeSeasonStats,
	[Token(Token = "0x400B2AD")]
	GetTeamMatchStatsHistory,
	[Token(Token = "0x400B2AE")]
	GenerateNickname,
	[Token(Token = "0x400B2AF")]
	MajorLogin,
	[Token(Token = "0x400B2B0")]
	MajorRegister,
	[Token(Token = "0x400B2B1")]
	GetLoginData,
	[Token(Token = "0x400B2B2")]
	MajorGuestBind,
	[Token(Token = "0x400B2B3")]
	MajorSecondaryAccountBind,
	[Token(Token = "0x400B2B4")]
	SetAntiAddictionAgeState,
	[Token(Token = "0x400B2B5")]
	MajorGetGlobalLeaderboard,
	[Token(Token = "0x400B2B6")]
	PlayerClaimRetentionReward,
	[Token(Token = "0x400B2B7")]
	GetSubscribeStore,
	[Token(Token = "0x400B2B8")]
	GetAccountSubscriptions,
	[Token(Token = "0x400B2B9")]
	ClaimSubscription,
	[Token(Token = "0x400B2BA")]
	GetLinkEquipSet,
	[Token(Token = "0x400B2BB")]
	OfferPurchase,
	[Token(Token = "0x400B2BC")]
	GetNewPlayerLevelUpTaskInfo,
	[Token(Token = "0x400B2BD")]
	GetBlockedIDs,
	[Token(Token = "0x400B2BE")]
	SetHideMyLobbyInPrefers,
	[Token(Token = "0x400B2BF")]
	SelectPetSkill,
	[Token(Token = "0x400B2C0")]
	ActivateAccount,
	[Token(Token = "0x400B2C1")]
	InitPlayerCSRankingInfo,
	[Token(Token = "0x400B2C2")]
	GetPlayerCSRankingInfo,
	[Token(Token = "0x400B2C3")]
	GetPlayerCSRankingSeasonStats,
	[Token(Token = "0x400B2C4")]
	GetCurOrRecentCSRankingConfig,
	[Token(Token = "0x400B2C5")]
	GetPlayerTCStats,
	[Token(Token = "0x400B2C6")]
	GetPlayerCSRankingInfoByAccountID,
	[Token(Token = "0x400B2C7")]
	GetCSRankMasterLevel,
	[Token(Token = "0x400B2C8")]
	GetRankMasterLevel,
	[Token(Token = "0x400B2C9")]
	InitPlayerPeriodicRankingInfo,
	[Token(Token = "0x400B2CA")]
	GetPlayerPeriodicRankingInfo,
	[Token(Token = "0x400B2CB")]
	GetCurOrRecentPeriodicRankingConfig,
	[Token(Token = "0x400B2CC")]
	GetPlayerPeriodicRankingInfoByAccountID,
	[Token(Token = "0x400B2CD")]
	NewbieChoice,
	[Token(Token = "0x400B2CE")]
	GetNewbieGuideDesc,
	[Token(Token = "0x400B2CF")]
	ClaimNewbieGuideRewards,
	[Token(Token = "0x400B2D0")]
	GetWeaponSkinOpenTime,
	[Token(Token = "0x400B2D1")]
	GetWeaponSkinUpgrade,
	[Token(Token = "0x400B2D2")]
	UpgradeWeaponSkin,
	[Token(Token = "0x400B2D3")]
	ExchangeWeaponSkinUpgradeToken,
	[Token(Token = "0x400B2D4")]
	GetActGachaInfo,
	[Token(Token = "0x400B2D5")]
	GetEPArchivesInfo,
	[Token(Token = "0x400B2D6")]
	GetMysteryShopLuckyDraw,
	[Token(Token = "0x400B2D7")]
	GetMysteryShopInfo,
	[Token(Token = "0x400B2D8")]
	GetMysteryShopInfoList,
	[Token(Token = "0x400B2D9")]
	GetMysteryShopProbability,
	[Token(Token = "0x400B2DA")]
	GetMysteryPoolInfo,
	[Token(Token = "0x400B2DB")]
	MysteryPurchase,
	[Token(Token = "0x400B2DC")]
	PurchaseMysteryAnotherPool,
	[Token(Token = "0x400B2DD")]
	GetLimitedEventStore,
	[Token(Token = "0x400B2DE")]
	GetLimitedEventOpenInfo,
	[Token(Token = "0x400B2DF")]
	GetLimitedEventEntrances,
	[Token(Token = "0x400B2E0")]
	GetPlayerRampageInfo,
	[Token(Token = "0x400B2E1")]
	GetRampageConfig,
	[Token(Token = "0x400B2E2")]
	ChooseFaction,
	[Token(Token = "0x400B2E3")]
	LimitedEventStorePurchase,
	[Token(Token = "0x400B2E4")]
	EliminateGoodsFromLimitPool,
	[Token(Token = "0x400B2E5")]
	GetMonopolyConfig,
	[Token(Token = "0x400B2E6")]
	GetPlayerMonopolyInfo,
	[Token(Token = "0x400B2E7")]
	MonopolyRoll,
	[Token(Token = "0x400B2E8")]
	MonopolyEventChoose,
	[Token(Token = "0x400B2E9")]
	GetMVPInfo,
	[Token(Token = "0x400B2EA")]
	ClaimMVPProcessRewards,
	[Token(Token = "0x400B2EB")]
	GetLimitedEventOpenEntries,
	[Token(Token = "0x400B2EC")]
	GetAnniversaryNodesInfo,
	[Token(Token = "0x400B2ED")]
	GetAnniversarySetting,
	[Token(Token = "0x400B2EE")]
	ClaimAnniversaryRewards,
	[Token(Token = "0x400B2EF")]
	GetDispatchInfo,
	[Token(Token = "0x400B2F0")]
	ExecuteDispatchQuest,
	[Token(Token = "0x400B2F1")]
	ClaimDispatchQuestRewards,
	[Token(Token = "0x400B2F2")]
	GetBountySetting,
	[Token(Token = "0x400B2F3")]
	GetBountyWarmUpStatus,
	[Token(Token = "0x400B2F4")]
	GetBountyInfo,
	[Token(Token = "0x400B2F5")]
	GetPlayerPayLevelInfo,
	[Token(Token = "0x400B2F6")]
	ClaimPayLevelReward,
	[Token(Token = "0x400B2F7")]
	RoleDebrisPurchase,
	[Token(Token = "0x400B2F8")]
	ApplyForDeputyCaptain,
	[Token(Token = "0x400B2F9")]
	ExchangeClanBadge,
	[Token(Token = "0x400B2FA")]
	GetRankingSeasonInfo,
	[Token(Token = "0x400B2FB")]
	GetLeaderBoardThresholdScore,
	[Token(Token = "0x400B2FC")]
	GetMegaPunchSetting,
	[Token(Token = "0x400B2FD")]
	GetBigEventTokenTipsDesc,
	[Token(Token = "0x400B2FE")]
	GetBermudaSettings,
	[Token(Token = "0x400B2FF")]
	GetBermudaInfo,
	[Token(Token = "0x400B300")]
	ClaimBermudaAward,
	[Token(Token = "0x400B301")]
	GetMVPSetting,
	[Token(Token = "0x400B302")]
	ReRandomCompletionLottery,
	[Token(Token = "0x400B303")]
	CompletionLotteryGainItems,
	[Token(Token = "0x400B304")]
	GetLegendClothesDesc,
	[Token(Token = "0x400B305")]
	UpdateSocialBasicInfo,
	[Token(Token = "0x400B306")]
	GetGoliathSetting,
	[Token(Token = "0x400B307")]
	GetAccountGoliathInfo,
	[Token(Token = "0x400B308")]
	GetGoliathAFKGroupInfo,
	[Token(Token = "0x400B309")]
	CreateGoliathAFKGroup,
	[Token(Token = "0x400B30A")]
	JoinGoliathAFKGroup,
	[Token(Token = "0x400B30B")]
	ClaimGoliathAFKGroupAwards,
	[Token(Token = "0x400B30C")]
	OpenGoliathAFKGroupActivity,
	[Token(Token = "0x400B30D")]
	SetWeaponRack,
	[Token(Token = "0x400B30E")]
	SetVehicleDisplay,
	[Token(Token = "0x400B30F")]
	SetLobbyDisplay,
	[Token(Token = "0x400B310")]
	SetGlooDisplay,
	[Token(Token = "0x400B311")]
	SendMatchLikeInfo,
	[Token(Token = "0x400B312")]
	UpdateAuthInspect,
	[Token(Token = "0x400B313")]
	GetSupercarSetting,
	[Token(Token = "0x400B314")]
	GetSupercarInfo,
	[Token(Token = "0x400B315")]
	HelpToAccelerateSupercar,
	[Token(Token = "0x400B316")]
	TokenToAccelerateSupercar,
	[Token(Token = "0x400B317")]
	ClaimSupercarRewards,
	[Token(Token = "0x400B318")]
	SupercarChangeCar,
	[Token(Token = "0x400B319")]
	GetSpecialFriendsState,
	[Token(Token = "0x400B31A")]
	GetSpecialFriendList,
	[Token(Token = "0x400B31B")]
	CreateOrDismissSpecialRelation,
	[Token(Token = "0x400B31C")]
	GetAccountSpecialFriendApps,
	[Token(Token = "0x400B31D")]
	ConfirmSpecialRelationRequest,
	[Token(Token = "0x400B31E")]
	GetIntimacyRankAwardInfo,
	[Token(Token = "0x400B31F")]
	ClaimIntimacyAward,
	[Token(Token = "0x400B320")]
	GetIntimacyAllDesc,
	[Token(Token = "0x400B321")]
	DeclineSpecialFriendRequest,
	[Token(Token = "0x400B322")]
	CallbackDismissSpecialFriendRequest,
	[Token(Token = "0x400B323")]
	UnlockFittingSlot,
	[Token(Token = "0x400B324")]
	SaveFittingSlot,
	[Token(Token = "0x400B325")]
	GetUnlockedFittingSlots,
	[Token(Token = "0x400B326")]
	GetAllChummyDesc,
	[Token(Token = "0x400B327")]
	GetChummyState,
	[Token(Token = "0x400B328")]
	RegisterAsMentor,
	[Token(Token = "0x400B329")]
	GetRecommendedMentorList,
	[Token(Token = "0x400B32A")]
	GetRecommendedStudentList,
	[Token(Token = "0x400B32B")]
	RequestAddingChummy,
	[Token(Token = "0x400B32C")]
	RequestDismissChummy,
	[Token(Token = "0x400B32D")]
	ConfirmAddingChummy,
	[Token(Token = "0x400B32E")]
	DeclineAddingChummy,
	[Token(Token = "0x400B32F")]
	ConfirmDismissChummy,
	[Token(Token = "0x400B330")]
	DeclineDismissChummy,
	[Token(Token = "0x400B331")]
	RevokeDismissChummyRequest,
	[Token(Token = "0x400B332")]
	GetChummyRequests,
	[Token(Token = "0x400B333")]
	GetChummyIntimacyAwardInfo,
	[Token(Token = "0x400B334")]
	ClaimChummyIntimacyAward,
	[Token(Token = "0x400B335")]
	GetBooyahday21Setting,
	[Token(Token = "0x400B336")]
	GetBooyahday21Info,
	[Token(Token = "0x400B337")]
	ClaimBooyahday21ProcessRewards,
	[Token(Token = "0x400B338")]
	GetBooyahgoConfig,
	[Token(Token = "0x400B339")]
	GetPlayerBooyahgoInfo,
	[Token(Token = "0x400B33A")]
	BooyahgoRoll,
	[Token(Token = "0x400B33B")]
	GetPoolLeaderboard,
	[Token(Token = "0x400B33C")]
	InitPoolLeaderboard,
	[Token(Token = "0x400B33D")]
	PoolLeaderboardClaimReward,
	[Token(Token = "0x400B33E")]
	GetPoolLeaderboardClaimedReward,
	[Token(Token = "0x400B33F")]
	GetPoolLeaderboardSetting,
	[Token(Token = "0x400B340")]
	GetFFWS03Setting,
	[Token(Token = "0x400B341")]
	GetFFWS03GuessingInfo,
	[Token(Token = "0x400B342")]
	StartFFWS03Guessing,
	[Token(Token = "0x400B343")]
	ClaimFFWS03GuessingAward,
	[Token(Token = "0x400B344")]
	FFWS03GetManagerInfo,
	[Token(Token = "0x400B345")]
	FFWS03ChooseTeamCards,
	[Token(Token = "0x400B346")]
	FFWS03ChangeTeamCardsSequence,
	[Token(Token = "0x400B347")]
	FFWS03SingleTrain,
	[Token(Token = "0x400B348")]
	FFWS03Milestone,
	[Token(Token = "0x400B349")]
	FFWS03StartMatch,
	[Token(Token = "0x400B34A")]
	FFWS03DailyCheckInInfo,
	[Token(Token = "0x400B34B")]
	GetFourSymbolsSetting,
	[Token(Token = "0x400B34C")]
	GetFourSymbolsSignInInfo,
	[Token(Token = "0x400B34D")]
	FourSymbolsSignIn,
	[Token(Token = "0x400B34E")]
	ClaimFourSymbolsAccumulatedAwards,
	[Token(Token = "0x400B34F")]
	GetFourSymbolsRoadInfo,
	[Token(Token = "0x400B350")]
	FourSymbolsRoadAdvance,
	[Token(Token = "0x400B351")]
	ClaimFourSymbolsRoadBigAward,
	[Token(Token = "0x400B352")]
	UploadWorkshop,
	[Token(Token = "0x400B353")]
	GetUploadWorkshopURL,
	[Token(Token = "0x400B354")]
	ReportUploadSuss,
	[Token(Token = "0x400B355")]
	DownloadWorkshop,
	[Token(Token = "0x400B356")]
	GetWorkshopBasicInfo,
	[Token(Token = "0x400B357")]
	UnlockWorkshopSlot,
	[Token(Token = "0x400B358")]
	ShareWorkshopSlot,
	[Token(Token = "0x400B359")]
	DeleteWorkshopInfo,
	[Token(Token = "0x400B35A")]
	PreviewWorkshopCode,
	[Token(Token = "0x400B35B")]
	SubscribeWorkshopCode,
	[Token(Token = "0x400B35C")]
	SearchWorkshopCode,
	[Token(Token = "0x400B35D")]
	ReportWorkshopCode,
	[Token(Token = "0x400B35E")]
	UpdateWorkshopBasicInfo,
	[Token(Token = "0x400B35F")]
	GetWorkshopRecommendationInfo,
	[Token(Token = "0x400B360")]
	GetWorkshopLatestInfo,
	[Token(Token = "0x400B361")]
	GetWorkshopHistoryInfo,
	[Token(Token = "0x400B362")]
	GetWorkshopAccountInfo,
	[Token(Token = "0x400B363")]
	SendWorkshopLike,
	[Token(Token = "0x400B364")]
	GetWorkshopMatchInfo,
	[Token(Token = "0x400B365")]
	GetWorkshopPersonalRecommendationInfo,
	[Token(Token = "0x400B366")]
	SendWorkshopCommentTag,
	[Token(Token = "0x400B367")]
	GetWorkshopEditorChoiceInfo,
	[Token(Token = "0x400B368")]
	GetWorkshopDesc,
	[Token(Token = "0x400B369")]
	GetCreditScoreDesc,
	[Token(Token = "0x400B36A")]
	GetCreditScoreInfo,
	[Token(Token = "0x400B36B")]
	GetCreditScoreChangeInfo,
	[Token(Token = "0x400B36C")]
	ClaimCreditScoreWeeklyRewards,
	[Token(Token = "0x400B36D")]
	GetAllCupConfig,
	[Token(Token = "0x400B36E")]
	CreateCupTeam,
	[Token(Token = "0x400B36F")]
	RequestJoinCupTeam,
	[Token(Token = "0x400B370")]
	ModifyCupTeamInfo,
	[Token(Token = "0x400B371")]
	GetCupTeamInfoByTeamID,
	[Token(Token = "0x400B372")]
	GetCupTeamMemberByMemberID,
	[Token(Token = "0x400B373")]
	GetCupTeamMembers,
	[Token(Token = "0x400B374")]
	QuitCupTeam,
	[Token(Token = "0x400B375")]
	DismissCupTeam,
	[Token(Token = "0x400B376")]
	GetCupTeamApplicantList,
	[Token(Token = "0x400B377")]
	GetCupTeamInvitationList,
	[Token(Token = "0x400B378")]
	GetSentCupTeamInvitationList,
	[Token(Token = "0x400B379")]
	ApproveJoinCupTeamApplication,
	[Token(Token = "0x400B37A")]
	DeclineJoinCupTeamApplication,
	[Token(Token = "0x400B37B")]
	InviteToCupTeam,
	[Token(Token = "0x400B37C")]
	ApproveJoinCupTeamInvitation,
	[Token(Token = "0x400B37D")]
	DeclineJoinCupTeamInvitation,
	[Token(Token = "0x400B37E")]
	RemoveCupTeamMember,
	[Token(Token = "0x400B37F")]
	VerifyAndLockCupTeam,
	[Token(Token = "0x400B380")]
	InitAccountCupInfo,
	[Token(Token = "0x400B381")]
	GetAccountCupInfo,
	[Token(Token = "0x400B382")]
	ToggleCupTicket,
	[Token(Token = "0x400B383")]
	ClaimCupReward,
	[Token(Token = "0x400B384")]
	GetAccountCupInfoBundleByAccountIDsOrderly,
	[Token(Token = "0x400B385")]
	GetLuckyWheelDesc,
	[Token(Token = "0x400B386")]
	GetLuckyWheelInfo,
	[Token(Token = "0x400B387")]
	SpinLuckyWheel,
	[Token(Token = "0x400B388")]
	BuyLuckyWheelShopItem,
	[Token(Token = "0x400B389")]
	RefreshLuckyWheelShop,
	[Token(Token = "0x400B38A")]
	GetSutoritoSetting,
	[Token(Token = "0x400B38B")]
	GetAccountSutoritoInfo,
	[Token(Token = "0x400B38C")]
	SutoritoAttack,
	[Token(Token = "0x400B38D")]
	SutoritoChoose,
	[Token(Token = "0x400B38E")]
	GetMusicFestSetting,
	[Token(Token = "0x400B38F")]
	GetMusicFestInfo,
	[Token(Token = "0x400B390")]
	MusicFestUsePuzzleToken,
	[Token(Token = "0x400B391")]
	MusicFestSendPuzzleToken,
	[Token(Token = "0x400B392")]
	MusicFestReceivePuzzleToken,
	[Token(Token = "0x400B393")]
	ClaimMusicFestPuzzleProgressRewards,
	[Token(Token = "0x400B394")]
	ClaimMusicFestPuzzleBlockRewards,
	[Token(Token = "0x400B395")]
	ClaimMusicFestCardReward,
	[Token(Token = "0x400B396")]
	GetMocoMonthSetting,
	[Token(Token = "0x400B397")]
	GetMocoMonthGameInfo,
	[Token(Token = "0x400B398")]
	SubmitMocoHackGameData,
	[Token(Token = "0x400B399")]
	GetMocoCurProcess,
	[Token(Token = "0x400B39A")]
	GetVipCardDescs,
	[Token(Token = "0x400B39B")]
	GetVipCardInfo,
	[Token(Token = "0x400B39C")]
	ClaimVipCardAward,
	[Token(Token = "0x400B39D")]
	GetVipCardStoreInfo,
	[Token(Token = "0x400B39E")]
	ClaimExpiredVipCardAward,
	[Token(Token = "0x400B39F")]
	VipCardStorePurchase,
	[Token(Token = "0x400B3A0")]
	GetCustomEventOpenInfo,
	[Token(Token = "0x400B3A1")]
	GetCustomEventProcessSetting,
	[Token(Token = "0x400B3A2")]
	GetCustomEventProcessInfo,
	[Token(Token = "0x400B3A3")]
	GetCustomEventCurrentProcess,
	[Token(Token = "0x400B3A4")]
	ClaimCustomEventProcessRewards,
	[Token(Token = "0x400B3A5")]
	GetCustomEvenStoreAccountInfo,
	[Token(Token = "0x400B3A6")]
	GetCustomEventStoreSetting,
	[Token(Token = "0x400B3A7")]
	CustomEventStorePurchase,
	[Token(Token = "0x400B3A8")]
	FFVoiceReport,
	[Token(Token = "0x400B3A9")]
	GetJumpsuitSetting,
	[Token(Token = "0x400B3AA")]
	GetJumpsuitInfo,
	[Token(Token = "0x400B3AB")]
	CollectJumpsuitStorage,
	[Token(Token = "0x400B3AC")]
	ClaimJumpsuitStageAwards,
	[Token(Token = "0x400B3AD")]
	ClaimJumpsuitExtraBox,
	[Token(Token = "0x400B3AE")]
	HelpJumpsuitFriend,
	[Token(Token = "0x400B3AF")]
	GetJumpsuitFriendHelpToken,
	[Token(Token = "0x400B3B0")]
	PutJumpsuitToken,
	[Token(Token = "0x400B3B1")]
	SetAccountPrefers,
	[Token(Token = "0x400B3B2")]
	GetLimitedChestInfo,
	[Token(Token = "0x400B3B3")]
	PurchaseLimitedChest,
	[Token(Token = "0x400B3B4")]
	SelectLimitedChestPrize,
	[Token(Token = "0x400B3B5")]
	GetLimitedChestProbability,
	[Token(Token = "0x400B3B6")]
	GetNewVaultItemDesc,
	[Token(Token = "0x400B3B7")]
	ClaimRankingResetRankAward,
	[Token(Token = "0x400B3B8")]
	ClaimCSRankingResetRankAward,
	[Token(Token = "0x400B3B9")]
	ClaimPeriodicRankingResetRankAward,
	[Token(Token = "0x400B3BA")]
	GetHurricaneBSetting,
	[Token(Token = "0x400B3BB")]
	GetHurricaneBAccountInfo,
	[Token(Token = "0x400B3BC")]
	GetHurricaneBCheckPointSetting,
	[Token(Token = "0x400B3BD")]
	SkipOffHurricaneBSelectedLevel,
	[Token(Token = "0x400B3BE")]
	StartHurricaneBSelectedLevel,
	[Token(Token = "0x400B3BF")]
	ProcessHurricaneBLevelSettlement,
	[Token(Token = "0x400B3C0")]
	GetHurricaneBTeamSetting,
	[Token(Token = "0x400B3C1")]
	JoinHurricaneBTeam,
	[Token(Token = "0x400B3C2")]
	GetHurricaneBTeamInfo,
	[Token(Token = "0x400B3C3")]
	GetHurricaneBTeamReward,
	[Token(Token = "0x400B3C4")]
	GetFriendsHurricaneBTeamInfo,
	[Token(Token = "0x400B3C5")]
	GetBoybandBSetting,
	[Token(Token = "0x400B3C6")]
	GetBoybandBAccountInfo,
	[Token(Token = "0x400B3C7")]
	BoybandBExchangeSuits,
	[Token(Token = "0x400B3C8")]
	BoybandBExchangeCard,
	[Token(Token = "0x400B3C9")]
	GetLinkSettingInfo,
	[Token(Token = "0x400B3CA")]
	GetLinkProfileList,
	[Token(Token = "0x400B3CB")]
	GetLinkedProfile,
	[Token(Token = "0x400B3CC")]
	RelinkProfile,
	[Token(Token = "0x400B3CD")]
	ClaimLinkProfile,
	[Token(Token = "0x400B3CE")]
	UpdateExchangeLink,
	[Token(Token = "0x400B3CF")]
	ReportPlayerInGameBehavior,
	[Token(Token = "0x400B3D0")]
	GetLabSetting,
	[Token(Token = "0x400B3D1")]
	GetHyperBookSetting,
	[Token(Token = "0x400B3D2")]
	GetHyperBookInfo,
	[Token(Token = "0x400B3D3")]
	UnlockHyperBookPage,
	[Token(Token = "0x400B3D4")]
	ClaimHyperBookReward,
	[Token(Token = "0x400B3D5")]
	SpinHyperBookHiddenPage,
	[Token(Token = "0x400B3D6")]
	GetRankingTaskList,
	[Token(Token = "0x400B3D7")]
	ReportNetworkMetricEvent,
	[Token(Token = "0x400B3D8")]
	GetSecretMissionDesc,
	[Token(Token = "0x400B3D9")]
	GetSecretMissionKey,
	[Token(Token = "0x400B3DA")]
	ExchangeSecretMissionKey,
	[Token(Token = "0x400B3DB")]
	GetFlashStoreDesc,
	[Token(Token = "0x400B3DC")]
	GetFlashStoreAccountInfo,
	[Token(Token = "0x400B3DD")]
	FlashStorePurchase,
	[Token(Token = "0x400B3DE")]
	ClaimWorkshopLevelReward,
	[Token(Token = "0x400B3DF")]
	ChooseRandomSlots
}
