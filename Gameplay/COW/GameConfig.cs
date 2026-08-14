using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003ADC")]
public static class GameConfig
{
	[Token(Token = "0x2003ADD")]
	public enum EAppStore
	{
		[Token(Token = "0x4019034")]
		GooglePlay,
		[Token(Token = "0x4019035")]
		GooglePlay_FullPackage,
		[Token(Token = "0x4019036")]
		Apple,
		[Token(Token = "0x4019037")]
		Official,
		[Token(Token = "0x4019038")]
		Huawei,
		[Token(Token = "0x4019039")]
		ThirdParty,
		[Token(Token = "0x401903A")]
		Samsung,
		[Token(Token = "0x401903B")]
		Trial,
		[Token(Token = "0x401903C")]
		GooglePlay_Max,
		[Token(Token = "0x401903D")]
		Apple_Max,
		[Token(Token = "0x401903E")]
		GooglePlay_India,
		[Token(Token = "0x401903F")]
		Apple_India
	}

	[Token(Token = "0x2003ADE")]
	private class LocalConfig
	{
		[Token(Token = "0x4019040")]
		[FieldOffset(Offset = "0x8")]
		public string serverUrl;

		[Token(Token = "0x4019041")]
		[FieldOffset(Offset = "0xC")]
		public string CDNAddr;

		[Token(Token = "0x4019042")]
		[FieldOffset(Offset = "0x10")]
		public string region;

		[Token(Token = "0x4019043")]
		[FieldOffset(Offset = "0x14")]
		public string countryCode;

		[Token(Token = "0x4019044")]
		[FieldOffset(Offset = "0x18")]
		public string verAddr;

		[Token(Token = "0x4019045")]
		[FieldOffset(Offset = "0x1C")]
		public bool skipVersionCheck;

		[Token(Token = "0x4019046")]
		[FieldOffset(Offset = "0x1D")]
		public bool skipResourceDownload;

		[Token(Token = "0x4019047")]
		[FieldOffset(Offset = "0x20")]
		public string ipRegion;

		[Token(Token = "0x4019048")]
		[FieldOffset(Offset = "0x24")]
		public string fakeVersion;

		[Token(Token = "0x4019049")]
		[FieldOffset(Offset = "0x28")]
		public bool forceReview;

		[Token(Token = "0x401904A")]
		[FieldOffset(Offset = "0x2C")]
		public string BillboardDesc;

		[Token(Token = "0x401904B")]
		[FieldOffset(Offset = "0x30")]
		public bool AnnouncementDebug;

		[Token(Token = "0x401904C")]
		[FieldOffset(Offset = "0x31")]
		public bool garenaOverride;

		[Token(Token = "0x401904D")]
		[FieldOffset(Offset = "0x32")]
		public bool garenaSandbox;

		[Token(Token = "0x401904E")]
		[FieldOffset(Offset = "0x33")]
		public bool gmsdkEnableDebugLog;

		[Token(Token = "0x401904F")]
		[FieldOffset(Offset = "0x34")]
		public bool legacyGuest;

		[Token(Token = "0x4019050")]
		[FieldOffset(Offset = "0x35")]
		public bool accountOverride;

		[Token(Token = "0x4019051")]
		[FieldOffset(Offset = "0x36")]
		public bool accountGuestAllowed;

		[Token(Token = "0x4019052")]
		[FieldOffset(Offset = "0x37")]
		public bool frontEndPreviewLogVerbose;

		[Token(Token = "0x4019053")]
		[FieldOffset(Offset = "0x38")]
		public bool showAllIngameTutorial;

		[Token(Token = "0x4019054")]
		[FieldOffset(Offset = "0x39")]
		public bool debugInfoOverride;

		[Token(Token = "0x4019055")]
		[FieldOffset(Offset = "0x3A")]
		public bool debugInfoDisplay;

		[Token(Token = "0x4019056")]
		[FieldOffset(Offset = "0x3B")]
		public bool debugSkipRoomCheck;

		[Token(Token = "0x4019057")]
		[FieldOffset(Offset = "0x3C")]
		public bool rebateCardOverride;

		[Token(Token = "0x4019058")]
		[FieldOffset(Offset = "0x3D")]
		public bool rebateCardEnabled;

		[Token(Token = "0x4019059")]
		[FieldOffset(Offset = "0x3E")]
		public bool paymentBundleOverride;

		[Token(Token = "0x401905A")]
		[FieldOffset(Offset = "0x3F")]
		public bool paymentBundleEnabled;

		[Token(Token = "0x401905B")]
		[FieldOffset(Offset = "0x40")]
		public bool paymentShopOverride;

		[Token(Token = "0x401905C")]
		[FieldOffset(Offset = "0x41")]
		public bool paymentShopEnabled;

		[Token(Token = "0x401905D")]
		[FieldOffset(Offset = "0x42")]
		public bool paymentShopFirstOverride;

		[Token(Token = "0x401905E")]
		[FieldOffset(Offset = "0x43")]
		public bool paymentShopFirst;

		[Token(Token = "0x401905F")]
		[FieldOffset(Offset = "0x44")]
		public string paymentShopCdnUrl;

		[Token(Token = "0x4019060")]
		[FieldOffset(Offset = "0x48")]
		public string paymentShopFallbackStrategy;

		[Token(Token = "0x4019061")]
		[FieldOffset(Offset = "0x4C")]
		public bool paymentShopFalseFaulty;

		[Token(Token = "0x4019062")]
		[FieldOffset(Offset = "0x4D")]
		public bool preferExternalUnityPaymentShopOverride;

		[Token(Token = "0x4019063")]
		[FieldOffset(Offset = "0x4E")]
		public bool preferExternalUnityPaymentShop;

		[Token(Token = "0x4019064")]
		[FieldOffset(Offset = "0x4F")]
		public bool recommitBeforePaymentOverride;

		[Token(Token = "0x4019065")]
		[FieldOffset(Offset = "0x50")]
		public bool recommitBeforePayment;

		[Token(Token = "0x4019066")]
		[FieldOffset(Offset = "0x51")]
		public bool resetGuest;

		[Token(Token = "0x4019067")]
		[FieldOffset(Offset = "0x54")]
		public string testOpenedByUrl;

		[Token(Token = "0x4019068")]
		[FieldOffset(Offset = "0x58")]
		public string testOpenedByDeepLinkUrl;

		[Token(Token = "0x4019069")]
		[FieldOffset(Offset = "0x5C")]
		public string testOpenedByWebViewUrl;

		[Token(Token = "0x401906A")]
		[FieldOffset(Offset = "0x60")]
		public string testOpenedByWebViewStyle;

		[Token(Token = "0x401906B")]
		[FieldOffset(Offset = "0x64")]
		public string testOpenedByBrowserUrl;

		[Token(Token = "0x401906C")]
		[FieldOffset(Offset = "0x68")]
		public uint prepareForNavigatePos;

		[Token(Token = "0x401906D")]
		[FieldOffset(Offset = "0x6C")]
		public string prepareForNavigateParam;

		[Token(Token = "0x401906E")]
		[FieldOffset(Offset = "0x70")]
		public string testOpenedByWebUrl;

		[Token(Token = "0x401906F")]
		[FieldOffset(Offset = "0x74")]
		public string testShareUrl;

		[Token(Token = "0x4019070")]
		[FieldOffset(Offset = "0x78")]
		public string testInviteUrl;

		[Token(Token = "0x4019071")]
		[FieldOffset(Offset = "0x7C")]
		public string testPayMainUrl_Paid;

		[Token(Token = "0x4019072")]
		[FieldOffset(Offset = "0x80")]
		public string testPayMainUrl_Unpaid;

		[Token(Token = "0x4019073")]
		[FieldOffset(Offset = "0x84")]
		public string testPayItemUrl_iOS;

		[Token(Token = "0x4019074")]
		[FieldOffset(Offset = "0x88")]
		public string testPayIAPButtonUrl_Android;

		[Token(Token = "0x4019075")]
		[FieldOffset(Offset = "0x8C")]
		public string testPaymentActivityImageUrl;

		[Token(Token = "0x4019076")]
		[FieldOffset(Offset = "0x90")]
		public string testPayAdImageUrl_Android;

		[Token(Token = "0x4019077")]
		[FieldOffset(Offset = "0x94")]
		public string testPayAdClickUrl_Android;

		[Token(Token = "0x4019078")]
		[FieldOffset(Offset = "0x98")]
		public string versionOfIAPProducts;

		[Token(Token = "0x4019079")]
		[FieldOffset(Offset = "0x9C")]
		public string versionOfPaymentBundles;

		[Token(Token = "0x401907A")]
		[FieldOffset(Offset = "0xA0")]
		public string versionOfRebateCards;

		[Token(Token = "0x401907B")]
		[FieldOffset(Offset = "0xA8")]
		public ulong paymentBundleNextResetTime;

		[Token(Token = "0x401907C")]
		[FieldOffset(Offset = "0xB0")]
		public bool logoutStopTPNS;

		[Token(Token = "0x401907D")]
		[FieldOffset(Offset = "0xB1")]
		public bool showDebugLog;

		[Token(Token = "0x401907E")]
		[FieldOffset(Offset = "0xB2")]
		public bool showProfilerLogs;

		[Token(Token = "0x401907F")]
		[FieldOffset(Offset = "0xB3")]
		public bool debugHack;

		[Token(Token = "0x4019080")]
		[FieldOffset(Offset = "0xB4")]
		public bool showServerTime;

		[Token(Token = "0x4019081")]
		[FieldOffset(Offset = "0xB5")]
		public bool integrationTest;

		[Token(Token = "0x4019082")]
		[FieldOffset(Offset = "0xB6")]
		public bool enableRemoteConsoleOverride;

		[Token(Token = "0x4019083")]
		[FieldOffset(Offset = "0xB7")]
		public bool enableRemoteConsole;

		[Token(Token = "0x4019084")]
		[FieldOffset(Offset = "0xB8")]
		public bool forceWebView;

		[Token(Token = "0x4019085")]
		[FieldOffset(Offset = "0xBC")]
		public string testWebViewUrl;

		[Token(Token = "0x4019086")]
		[FieldOffset(Offset = "0xC0")]
		public string testLiveTVUrl;

		[Token(Token = "0x4019087")]
		[FieldOffset(Offset = "0xC4")]
		public string testBooyahTVUrl;

		[Token(Token = "0x4019088")]
		[FieldOffset(Offset = "0xC8")]
		public string testMShopUrl;

		[Token(Token = "0x4019089")]
		[FieldOffset(Offset = "0xCC")]
		public uint overrideProduction;

		[Token(Token = "0x401908A")]
		[FieldOffset(Offset = "0xD0")]
		public bool androidWebViewUseActivityOverride;

		[Token(Token = "0x401908B")]
		[FieldOffset(Offset = "0xD1")]
		public bool androidWebViewUseActivity;

		[Token(Token = "0x401908C")]
		[FieldOffset(Offset = "0xD4")]
		public string testRebateCardNotifyTime;

		[Token(Token = "0x401908D")]
		[FieldOffset(Offset = "0xD8")]
		public string testPlayTestNotifyTime;

		[Token(Token = "0x401908E")]
		[FieldOffset(Offset = "0xDC")]
		public int testIAPBundleStoreID;

		[Token(Token = "0x401908F")]
		[FieldOffset(Offset = "0xE0")]
		public int testIAPBundleDuration;

		[Token(Token = "0x4019090")]
		[FieldOffset(Offset = "0xE4")]
		public int testMinutesOfNotifyBeforeIAPBundleEnds;

		[Token(Token = "0x4019091")]
		[FieldOffset(Offset = "0xE8")]
		public bool testIAPBundleFirstTime;

		[Token(Token = "0x4019092")]
		[FieldOffset(Offset = "0xE9")]
		public bool testIAPBundleAllPurchasable;

		[Token(Token = "0x4019093")]
		[FieldOffset(Offset = "0xEA")]
		public bool forceIAPBundleFullyDisplay;

		[Token(Token = "0x4019094")]
		[FieldOffset(Offset = "0xEB")]
		public bool forcePlatformFriendReunion;

		[Token(Token = "0x4019095")]
		[FieldOffset(Offset = "0xEC")]
		public bool testSparkEventOverride;

		[Token(Token = "0x4019096")]
		[FieldOffset(Offset = "0xED")]
		public bool testSparkEventEnable;

		[Token(Token = "0x4019097")]
		[FieldOffset(Offset = "0xEE")]
		public bool testSparkEventOnEnterLobby;

		[Token(Token = "0x4019098")]
		[FieldOffset(Offset = "0xEF")]
		public bool testSparkEventDebugMode;

		[Token(Token = "0x4019099")]
		[FieldOffset(Offset = "0xF0")]
		public bool testSparkEventDebugWithoutMTV;

		[Token(Token = "0x401909A")]
		[FieldOffset(Offset = "0xF4")]
		public string testDeviceIdForGoogleAdMob;

		[Token(Token = "0x401909B")]
		[FieldOffset(Offset = "0xF8")]
		public bool testAdMob;

		[Token(Token = "0x401909C")]
		[FieldOffset(Offset = "0xF9")]
		public bool testAdMobOverride;

		[Token(Token = "0x401909D")]
		[FieldOffset(Offset = "0xFC")]
		public string testRewardedVideoAdUnitId;

		[Token(Token = "0x401909E")]
		[FieldOffset(Offset = "0x100")]
		public bool forceEnableRewardedVideo;

		[Token(Token = "0x401909F")]
		[FieldOffset(Offset = "0x101")]
		public bool forceEnableRewardVideoAfterMatch;

		[Token(Token = "0x40190A0")]
		[FieldOffset(Offset = "0x104")]
		public string testFreeGachaNotifyTime;

		[Token(Token = "0x40190A1")]
		[FieldOffset(Offset = "0x108")]
		public bool disableRandomDelayForNotifies;

		[Token(Token = "0x40190A2")]
		[FieldOffset(Offset = "0x10C")]
		public int paymentBundleReloadInterval;

		[Token(Token = "0x40190A3")]
		[FieldOffset(Offset = "0x110")]
		public bool forceDisplayAllPaymentTabs;

		[Token(Token = "0x40190A4")]
		[FieldOffset(Offset = "0x111")]
		public bool screenshotForIAPBundles;

		[Token(Token = "0x40190A5")]
		[FieldOffset(Offset = "0x112")]
		public bool loginLogVerbose;

		[Token(Token = "0x40190A6")]
		[FieldOffset(Offset = "0x113")]
		public bool autoUIIntentsLogVerbose;

		[Token(Token = "0x40190A7")]
		[FieldOffset(Offset = "0x114")]
		public bool uiWaitingLogVerbose;

		[Token(Token = "0x40190A8")]
		[FieldOffset(Offset = "0x115")]
		public bool iapLogVerbose;

		[Token(Token = "0x40190A9")]
		[FieldOffset(Offset = "0x116")]
		public bool platformProductionLogVerbose;

		[Token(Token = "0x40190AA")]
		[FieldOffset(Offset = "0x117")]
		public bool rebateCardLogVerbose;

		[Token(Token = "0x40190AB")]
		[FieldOffset(Offset = "0x118")]
		public bool localNotifyLogVerbose;

		[Token(Token = "0x40190AC")]
		[FieldOffset(Offset = "0x120")]
		public long localNotifyStatsEventLogInterval;

		[Token(Token = "0x40190AD")]
		[FieldOffset(Offset = "0x128")]
		public bool gerLogVerbose;

		[Token(Token = "0x40190AE")]
		[FieldOffset(Offset = "0x129")]
		public bool interAppLogVerbose;

		[Token(Token = "0x40190AF")]
		[FieldOffset(Offset = "0x12A")]
		public bool tpnsLogVerbose;

		[Token(Token = "0x40190B0")]
		[FieldOffset(Offset = "0x12B")]
		public bool mambetLogVerbose;

		[Token(Token = "0x40190B1")]
		[FieldOffset(Offset = "0x12C")]
		public bool mambetDebugVoiceOverride;

		[Token(Token = "0x40190B2")]
		[FieldOffset(Offset = "0x12D")]
		public bool mambetDebugVoice;

		[Token(Token = "0x40190B3")]
		[FieldOffset(Offset = "0x12E")]
		public bool forceCrash;

		[Token(Token = "0x40190B4")]
		[FieldOffset(Offset = "0x12F")]
		public bool enableUGCFullCustom;

		[Token(Token = "0x40190B5")]
		[FieldOffset(Offset = "0x130")]
		public bool firebaseLogVerbose;

		[Token(Token = "0x40190B6")]
		[FieldOffset(Offset = "0x131")]
		public bool firebaseSettingsOverride;

		[Token(Token = "0x40190B7")]
		[FieldOffset(Offset = "0x132")]
		public bool firebaseEnabled;

		[Token(Token = "0x40190B8")]
		[FieldOffset(Offset = "0x133")]
		public bool firebaseMessagingEnabled;

		[Token(Token = "0x40190B9")]
		[FieldOffset(Offset = "0x134")]
		public bool firebaseAnalyticsEnabled;

		[Token(Token = "0x40190BA")]
		[FieldOffset(Offset = "0x135")]
		public bool firebaseCrashlyticsEnabled;

		[Token(Token = "0x40190BB")]
		[FieldOffset(Offset = "0x136")]
		public bool firebaseMessagingSettingsOverride;

		[Token(Token = "0x40190BC")]
		[FieldOffset(Offset = "0x137")]
		public bool firebaseMessagingUseUserProperties;

		[Token(Token = "0x40190BD")]
		[FieldOffset(Offset = "0x138")]
		public bool firebaseMessagingUseTopics;

		[Token(Token = "0x40190BE")]
		[FieldOffset(Offset = "0x139")]
		public bool firebaseCrashlyticsUnityLogTypesOverride;

		[Token(Token = "0x40190BF")]
		[FieldOffset(Offset = "0x13C")]
		public int firebaseCrashlyticsUnityLogTypes;

		[Token(Token = "0x40190C0")]
		[FieldOffset(Offset = "0x140")]
		public bool disableCacheForFirebaseAnalytics;

		[Token(Token = "0x40190C1")]
		[FieldOffset(Offset = "0x141")]
		public bool disableCacheForFirebaseMessaging;

		[Token(Token = "0x40190C2")]
		[FieldOffset(Offset = "0x144")]
		public string detectAndroidApplicationBundleIdentifier;

		[Token(Token = "0x40190C3")]
		[FieldOffset(Offset = "0x148")]
		public bool testChangeClothIngame;

		[Token(Token = "0x40190C4")]
		[FieldOffset(Offset = "0x14C")]
		public float durationforEatingChicken;

		[Token(Token = "0x40190C5")]
		[FieldOffset(Offset = "0x150")]
		public bool GER_Override;

		[Token(Token = "0x40190C6")]
		[FieldOffset(Offset = "0x151")]
		public bool GER_Enabled;

		[Token(Token = "0x40190C7")]
		[FieldOffset(Offset = "0x154")]
		public int GER_Env;

		[Token(Token = "0x40190C8")]
		[FieldOffset(Offset = "0x158")]
		public string GER_Region;

		[Token(Token = "0x40190C9")]
		[FieldOffset(Offset = "0x15C")]
		public bool GER_BypassAllFilters;

		[Token(Token = "0x40190CA")]
		[FieldOffset(Offset = "0x160")]
		public string GER_SponsorId;

		[Token(Token = "0x40190CB")]
		[FieldOffset(Offset = "0x164")]
		public string GER_ApiKey;

		[Token(Token = "0x40190CC")]
		[FieldOffset(Offset = "0x168")]
		public string GER_EP;

		[Token(Token = "0x40190CD")]
		[FieldOffset(Offset = "0x16C")]
		public bool Subscription_Override;

		[Token(Token = "0x40190CE")]
		[FieldOffset(Offset = "0x16D")]
		public bool Subscription_RebateCard_Enabled;

		[Token(Token = "0x40190CF")]
		[FieldOffset(Offset = "0x16E")]
		public bool Subscription_ElitePass_Enabled;

		[Token(Token = "0x40190D0")]
		[FieldOffset(Offset = "0x170")]
		public int Subscription_Bundles_Switch;

		[Token(Token = "0x40190D1")]
		[FieldOffset(Offset = "0x174")]
		public int Subscription_Memership_Switch;

		[Token(Token = "0x40190D2")]
		[FieldOffset(Offset = "0x178")]
		public string Subscription_ProductIdentifier_WeekCard;

		[Token(Token = "0x40190D3")]
		[FieldOffset(Offset = "0x17C")]
		public string Subscription_ProductIdentifier_MonthCard;

		[Token(Token = "0x40190D4")]
		[FieldOffset(Offset = "0x180")]
		public string Subscription_ProductIdentifier_ElitePass;

		[Token(Token = "0x40190D5")]
		[FieldOffset(Offset = "0x184")]
		public int Subscription_GracePeriod_ProductId;

		[Token(Token = "0x40190D6")]
		[FieldOffset(Offset = "0x188")]
		public ulong Subscription_GracePeriod_ExpiryTime;

		[Token(Token = "0x40190D7")]
		[FieldOffset(Offset = "0x190")]
		public string ElitePassSubscribeStart;

		[Token(Token = "0x40190D8")]
		[FieldOffset(Offset = "0x194")]
		public string ElitePassSubscribeEnd;

		[Token(Token = "0x40190D9")]
		[FieldOffset(Offset = "0x198")]
		public bool ElitePassSubscribedOverride;

		[Token(Token = "0x40190DA")]
		[FieldOffset(Offset = "0x199")]
		public bool ElitePassSubscribed;

		[Token(Token = "0x40190DB")]
		[FieldOffset(Offset = "0x19A")]
		public bool showPaymentFailureSignatureOverride;

		[Token(Token = "0x40190DC")]
		[FieldOffset(Offset = "0x19B")]
		public bool showPaymentFailureSignature;

		[Token(Token = "0x40190DD")]
		[FieldOffset(Offset = "0x19C")]
		public bool copyOpenID;

		[Token(Token = "0x40190DE")]
		[FieldOffset(Offset = "0x1A0")]
		public string languageCheckFlag;

		[Token(Token = "0x40190DF")]
		[FieldOffset(Offset = "0x1A4")]
		public string testProductIdentifier;

		[Token(Token = "0x40190E0")]
		[FieldOffset(Offset = "0x1A8")]
		public bool TPNS_Override;

		[Token(Token = "0x40190E1")]
		[FieldOffset(Offset = "0x1A9")]
		public bool TPNS;

		[Token(Token = "0x40190E2")]
		[FieldOffset(Offset = "0x1AA")]
		public bool TPNS_FCM;

		[Token(Token = "0x40190E3")]
		[FieldOffset(Offset = "0x1AB")]
		public bool TPNS_NoCache;

		[Token(Token = "0x40190E4")]
		[FieldOffset(Offset = "0x1AC")]
		public bool TPNS_Preview;

		[Token(Token = "0x40190E5")]
		[FieldOffset(Offset = "0x1AD")]
		public bool webViewOverride;

		[Token(Token = "0x40190E6")]
		[FieldOffset(Offset = "0x1AE")]
		public bool webViewDisableJavaScriptInjection;

		[Token(Token = "0x40190E7")]
		[FieldOffset(Offset = "0x1AF")]
		public bool webViewDisableMediaManipulationOnHideAndShowByJavaScript;

		[Token(Token = "0x40190E8")]
		[FieldOffset(Offset = "0x1B0")]
		public bool webViewProtect;

		[Token(Token = "0x40190E9")]
		[FieldOffset(Offset = "0x1B1")]
		public bool webViewPromptFaulty;

		[Token(Token = "0x40190EA")]
		[FieldOffset(Offset = "0x1B2")]
		public bool webViewFallbackToBrowser;

		[Token(Token = "0x40190EB")]
		[FieldOffset(Offset = "0x1B3")]
		public bool webViewFalseFaulty;

		[Token(Token = "0x40190EC")]
		[FieldOffset(Offset = "0x1B4")]
		public bool webViewDeferredDisplay;

		[Token(Token = "0x40190ED")]
		[FieldOffset(Offset = "0x1B8")]
		public float webViewLoadingProgressAnimationDuration;

		[Token(Token = "0x40190EE")]
		[FieldOffset(Offset = "0x1BC")]
		public float webViewPromptReloadDuration;

		[Token(Token = "0x40190EF")]
		[FieldOffset(Offset = "0x1C0")]
		public bool webViewOnlyAutoPlayMediaWithWIFI;

		[Token(Token = "0x40190F0")]
		[FieldOffset(Offset = "0x1C1")]
		public bool webViewOverrideReloadAsCaptureScreenshot;

		[Token(Token = "0x40190F1")]
		[FieldOffset(Offset = "0x1C4")]
		public string webViewJavaScriptName;

		[Token(Token = "0x40190F2")]
		[FieldOffset(Offset = "0x1C8")]
		public bool webViewRunJavaScript;

		[Token(Token = "0x40190F3")]
		[FieldOffset(Offset = "0x1CC")]
		public string webViewJavaScriptEcho;

		[Token(Token = "0x40190F4")]
		[FieldOffset(Offset = "0x1D0")]
		public bool webViewLogConsoleMessages;

		[Token(Token = "0x40190F5")]
		[FieldOffset(Offset = "0x1D1")]
		public bool androidWebViewActivityDebugLog;

		[Token(Token = "0x40190F6")]
		[FieldOffset(Offset = "0x1D4")]
		public string webViewLogUrls;

		[Token(Token = "0x40190F7")]
		[FieldOffset(Offset = "0x1D8")]
		public string googleClientId;

		[Token(Token = "0x40190F8")]
		[FieldOffset(Offset = "0x1DC")]
		public int veteranReminderDays;

		[Token(Token = "0x40190F9")]
		[FieldOffset(Offset = "0x1E0")]
		public bool UMALogErrors;

		[Token(Token = "0x40190FA")]
		[FieldOffset(Offset = "0x1E1")]
		public bool UMALogDetails;

		[Token(Token = "0x40190FB")]
		[FieldOffset(Offset = "0x1E2")]
		public bool UMALogDetails3P;

		[Token(Token = "0x40190FC")]
		[FieldOffset(Offset = "0x1E3")]
		public bool UMALogTimes;

		[Token(Token = "0x40190FD")]
		[FieldOffset(Offset = "0x1E4")]
		public bool inAppReviewOverride;

		[Token(Token = "0x40190FE")]
		[FieldOffset(Offset = "0x1E5")]
		public bool inAppReviewEnabled;

		[Token(Token = "0x40190FF")]
		[FieldOffset(Offset = "0x1E8")]
		public string test_hook;

		[Token(Token = "0x4019100")]
		[FieldOffset(Offset = "0x1EC")]
		public bool testFireWallOpen;

		[Token(Token = "0x4019101")]
		[FieldOffset(Offset = "0x1ED")]
		public bool lessIsMoreTest;

		[Token(Token = "0x4019102")]
		[FieldOffset(Offset = "0x1EE")]
		public bool lessIsMoreOverride;

		[Token(Token = "0x4019103")]
		[FieldOffset(Offset = "0x1EF")]
		public bool lessIsMoreUseGMSDK;

		[Token(Token = "0x4019104")]
		[FieldOffset(Offset = "0x1F0")]
		public ulong lessIsMoreMinReloadInterval;

		[Token(Token = "0x4019105")]
		[FieldOffset(Offset = "0x1F8")]
		public int lessIsMoreMaxReloadFailures;

		[Token(Token = "0x4019106")]
		[FieldOffset(Offset = "0x200")]
		public ulong lessIsMorePendingReloadInterval;

		[Token(Token = "0x4019107")]
		[FieldOffset(Offset = "0x208")]
		public int lessIsMoreFakeEventConfigsFailures;

		[Token(Token = "0x4019108")]
		[FieldOffset(Offset = "0x20C")]
		public int lessIsMoreFakeEventProductsFailures;

		[Token(Token = "0x4019109")]
		[FieldOffset(Offset = "0x210")]
		public string webPageFallbackStrategy;

		[Token(Token = "0x401910A")]
		[FieldOffset(Offset = "0x214")]
		public string translateDeepLinkInput;

		[Token(Token = "0x401910B")]
		[FieldOffset(Offset = "0x218")]
		public string translateDeepLinkOutput;

		[Token(Token = "0x401910C")]
		[FieldOffset(Offset = "0x21C")]
		public bool ffaiTraining;

		[Token(Token = "0x401910D")]
		[FieldOffset(Offset = "0x21D")]
		public bool testInvalidClientVersion;

		[Token(Token = "0x60175D3")]
		[Address(RVA = "0x1067830", Offset = "0x1067830", VA = "0x1067830")]
		public LocalConfig()
		{
		}
	}

	[Token(Token = "0x4018FFD")]
	[FieldOffset(Offset = "0x0")]
	public static string VerAddr;

	[Token(Token = "0x4018FFE")]
	[FieldOffset(Offset = "0x4")]
	public static string CDNAddr;

	[Token(Token = "0x4018FFF")]
	[FieldOffset(Offset = "0x8")]
	public static string ServerAddr;

	[Token(Token = "0x4019000")]
	[FieldOffset(Offset = "0xC")]
	public static string MajorServerAddr;

	[Token(Token = "0x4019001")]
	[FieldOffset(Offset = "0x10")]
	public static string LogServerAddr;

	[Token(Token = "0x4019002")]
	[FieldOffset(Offset = "0x14")]
	public static string NetworkLogServerAddr;

	[Token(Token = "0x4019003")]
	[FieldOffset(Offset = "0x18")]
	public static string NetworkDetectionServerAddr;

	[Token(Token = "0x4019004")]
	[FieldOffset(Offset = "0x1C")]
	private static bool _IsIOSReview;

	[Token(Token = "0x4019005")]
	[FieldOffset(Offset = "0x1D")]
	public static bool SkipVersionCheck;

	[Token(Token = "0x4019006")]
	[FieldOffset(Offset = "0x1E")]
	public static bool SkipResourceDownload;

	[Token(Token = "0x4019007")]
	[FieldOffset(Offset = "0x1F")]
	public static bool EnableRefreshFile;

	[Token(Token = "0x4019008")]
	[FieldOffset(Offset = "0x20")]
	public static bool LegacyGuest;

	[Token(Token = "0x4019009")]
	[FieldOffset(Offset = "0x24")]
	private static string m_BillboardServerAddr;

	[Token(Token = "0x401900A")]
	[FieldOffset(Offset = "0x28")]
	public static EAppStore AppStore;

	[Token(Token = "0x401900B")]
	[FieldOffset(Offset = "0x2C")]
	public static string AppStoreAddr;

	[Token(Token = "0x401900C")]
	[FieldOffset(Offset = "0x30")]
	public static bool NeedBigFileDownloadForHotupdate;

	[Token(Token = "0x401900D")]
	[FieldOffset(Offset = "0x31")]
	public static bool OpenOptionalDownloadInLogin;

	[Token(Token = "0x401900E")]
	[FieldOffset(Offset = "0x32")]
	public static bool UseAssetBundle;

	[Token(Token = "0x401900F")]
	[FieldOffset(Offset = "0x34")]
	public static LocLang CurrentLang;

	[Token(Token = "0x4019010")]
	[FieldOffset(Offset = "0x38")]
	public static float CAM_OFFSET_FOR_SNIPER;

	[Token(Token = "0x4019011")]
	[FieldOffset(Offset = "0x3C")]
	public static string ClientIP;

	[Token(Token = "0x4019012")]
	[FieldOffset(Offset = "0x40")]
	public static int EuroPolicyVersion;

	[Token(Token = "0x4019013")]
	[FieldOffset(Offset = "0x44")]
	private static string _Country;

	[Token(Token = "0x4019014")]
	[FieldOffset(Offset = "0x48")]
	public static bool IsFirewallOpen;

	[Token(Token = "0x4019015")]
	[FieldOffset(Offset = "0x49")]
	public static bool MuteSound;

	[Token(Token = "0x4019016")]
	[FieldOffset(Offset = "0x4C")]
	public static string DevId;

	[Token(Token = "0x4019017")]
	[FieldOffset(Offset = "0x50")]
	public static bool DebugMode;

	[Token(Token = "0x4019018")]
	[FieldOffset(Offset = "0x51")]
	private static bool _ShowDebugInfo;

	[Token(Token = "0x4019019")]
	[FieldOffset(Offset = "0x52")]
	private static bool _ShowDebugUI;

	[Token(Token = "0x401901A")]
	[FieldOffset(Offset = "0x53")]
	public static bool DrawAimAssistDebugInfo;

	[Token(Token = "0x401901B")]
	[FieldOffset(Offset = "0x54")]
	public static bool ChooseRegionEnabled;

	[Token(Token = "0x401901C")]
	[FieldOffset(Offset = "0x55")]
	public static bool TestModeEnabled;

	[Token(Token = "0x401901D")]
	[FieldOffset(Offset = "0x56")]
	public static bool EnableRemoteConsole;

	[Token(Token = "0x401901E")]
	[FieldOffset(Offset = "0x58")]
	public static string UrgentAnnouncement;

	[Token(Token = "0x401901F")]
	[FieldOffset(Offset = "0x5C")]
	public static bool DebugHack;

	[Token(Token = "0x4019020")]
	[FieldOffset(Offset = "0x5D")]
	public static bool garenaProduction;

	[Token(Token = "0x4019021")]
	[FieldOffset(Offset = "0x60")]
	public static string garenaAppId;

	[Token(Token = "0x4019022")]
	[FieldOffset(Offset = "0x64")]
	public static string garenaAppKeySandbox;

	[Token(Token = "0x4019023")]
	[FieldOffset(Offset = "0x68")]
	public static string garenaAppKeyProduction;

	[Token(Token = "0x4019024")]
	public const string GOOGLE_CLIENT_ID = "2518292083-8ld2che818jfrkjr5qnq13er6jf73gts.apps.googleusercontent.com";

	[Token(Token = "0x4019025")]
	[FieldOffset(Offset = "0x6C")]
	private static string _003COverrideGOPRootUrl_003Ek__BackingField;

	[Token(Token = "0x4019026")]
	[FieldOffset(Offset = "0x70")]
	private static string _003COverrideGOPNewRootUrl_003Ek__BackingField;

	[Token(Token = "0x4019027")]
	public const string GOP_CHECK_BIND = "oauth/token/checkbind";

	[Token(Token = "0x4019028")]
	[FieldOffset(Offset = "0x74")]
	public static string garenaPushAppkeySandbox;

	[Token(Token = "0x4019029")]
	[FieldOffset(Offset = "0x78")]
	public static string garenaPushAppkeyProduction;

	[Token(Token = "0x401902A")]
	[FieldOffset(Offset = "0x7C")]
	public static int NeedCheckLoginFailedCount;

	[Token(Token = "0x401902B")]
	[FieldOffset(Offset = "0x80")]
	private static bool _GarenaLogin;

	[Token(Token = "0x401902C")]
	[FieldOffset(Offset = "0x81")]
	private static bool _GarenaLoginHint;

	[Token(Token = "0x401902D")]
	[FieldOffset(Offset = "0x84")]
	private static LocalConfig m_LocalConfig;

	[Token(Token = "0x401902E")]
	[FieldOffset(Offset = "0x88")]
	private static DateTime APOCH_UTC;

	[Token(Token = "0x401902F")]
	[FieldOffset(Offset = "0x98")]
	private static readonly string[] _WebViewLogUrlSeparators;

	[Token(Token = "0x4019030")]
	[FieldOffset(Offset = "0x9C")]
	private static string[] _WebViewLogUrls;

	[Token(Token = "0x4019031")]
	[FieldOffset(Offset = "0xA0")]
	private static bool _003CTestChangeClothIngame_003Ek__BackingField;

	[Token(Token = "0x4019032")]
	[FieldOffset(Offset = "0xA1")]
	private static bool _003CTestAutoChangeClothInGame_003Ek__BackingField;

	[Token(Token = "0x170016F6")]
	public static bool IsIOSReview
	{
		[Token(Token = "0x60174F6")]
		[Address(RVA = "0x1055C60", Offset = "0x1055C60", VA = "0x1055C60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60174F7")]
		[Address(RVA = "0x1055E24", Offset = "0x1055E24", VA = "0x1055E24")]
		set
		{
		}
	}

	[Token(Token = "0x170016F7")]
	public static string BillboardServerAddr
	{
		[Token(Token = "0x60174F9")]
		[Address(RVA = "0x1056064", Offset = "0x1056064", VA = "0x1056064")]
		get
		{
			return null;
		}
		[Token(Token = "0x60174FA")]
		[Address(RVA = "0x1056240", Offset = "0x1056240", VA = "0x1056240")]
		set
		{
		}
	}

	[Token(Token = "0x170016F8")]
	public static string Country
	{
		[Token(Token = "0x60174FC")]
		[Address(RVA = "0x10563F0", Offset = "0x10563F0", VA = "0x10563F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60174FB")]
		[Address(RVA = "0x1056318", Offset = "0x1056318", VA = "0x1056318")]
		set
		{
		}
	}

	[Token(Token = "0x170016F9")]
	public static bool ShowAllIngameTutorial
	{
		[Token(Token = "0x60174FD")]
		[Address(RVA = "0x1056770", Offset = "0x1056770", VA = "0x1056770")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016FA")]
	public static bool ShowDebugInfo
	{
		[Token(Token = "0x60174FF")]
		[Address(RVA = "0x105697C", Offset = "0x105697C", VA = "0x105697C")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60174FE")]
		[Address(RVA = "0x10568A4", Offset = "0x10568A4", VA = "0x10568A4")]
		set
		{
		}
	}

	[Token(Token = "0x170016FB")]
	public static bool ShowDebugUI
	{
		[Token(Token = "0x6017501")]
		[Address(RVA = "0x1056D94", Offset = "0x1056D94", VA = "0x1056D94")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017500")]
		[Address(RVA = "0x1056CBC", Offset = "0x1056CBC", VA = "0x1056CBC")]
		set
		{
		}
	}

	[Token(Token = "0x170016FC")]
	public static bool ShowServerTime
	{
		[Token(Token = "0x6017502")]
		[Address(RVA = "0x1056E64", Offset = "0x1056E64", VA = "0x1056E64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016FD")]
	public static bool IntegrationTest
	{
		[Token(Token = "0x6017503")]
		[Address(RVA = "0x1056F98", Offset = "0x1056F98", VA = "0x1056F98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170016FE")]
	public static string GarenaAppKey
	{
		[Token(Token = "0x6017504")]
		[Address(RVA = "0x1056FE8", Offset = "0x1056FE8", VA = "0x1056FE8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170016FF")]
	public static string GoogleClientID
	{
		[Token(Token = "0x6017505")]
		[Address(RVA = "0x105712C", Offset = "0x105712C", VA = "0x105712C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001700")]
	public static string OverrideGOPRootUrl
	{
		[Token(Token = "0x6017507")]
		[Address(RVA = "0x1057888", Offset = "0x1057888", VA = "0x1057888")]
		get
		{
			return null;
		}
		[Token(Token = "0x6017508")]
		[Address(RVA = "0x1057768", Offset = "0x1057768", VA = "0x1057768")]
		private set
		{
		}
	}

	[Token(Token = "0x17001701")]
	public static string OverrideGOPNewRootUrl
	{
		[Token(Token = "0x6017509")]
		[Address(RVA = "0x1057914", Offset = "0x1057914", VA = "0x1057914")]
		get
		{
			return null;
		}
		[Token(Token = "0x601750A")]
		[Address(RVA = "0x10577F8", Offset = "0x10577F8", VA = "0x10577F8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001702")]
	public static string GarenaPushAppKey
	{
		[Token(Token = "0x601750B")]
		[Address(RVA = "0x10579A0", Offset = "0x10579A0", VA = "0x10579A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001703")]
	public static bool LessIsMoreTest
	{
		[Token(Token = "0x601750D")]
		[Address(RVA = "0x1057BCC", Offset = "0x1057BCC", VA = "0x1057BCC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001704")]
	public static bool LessIsMoreOverride
	{
		[Token(Token = "0x601750E")]
		[Address(RVA = "0x1057D00", Offset = "0x1057D00", VA = "0x1057D00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001705")]
	public static bool LessIsMoreUseGMSDK
	{
		[Token(Token = "0x601750F")]
		[Address(RVA = "0x1057E34", Offset = "0x1057E34", VA = "0x1057E34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001706")]
	public static ulong LessIsMoreMinReloadInterval
	{
		[Token(Token = "0x6017510")]
		[Address(RVA = "0x1057F68", Offset = "0x1057F68", VA = "0x1057F68")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001707")]
	public static int LessIsMoreMaxReloadFailures
	{
		[Token(Token = "0x6017511")]
		[Address(RVA = "0x105809C", Offset = "0x105809C", VA = "0x105809C")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001708")]
	public static ulong LessIsMorePendingReloadInterval
	{
		[Token(Token = "0x6017512")]
		[Address(RVA = "0x10581C8", Offset = "0x10581C8", VA = "0x10581C8")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001709")]
	public static int LessIsMoreFakeEventConfigsFailures
	{
		[Token(Token = "0x6017513")]
		[Address(RVA = "0x10582FC", Offset = "0x10582FC", VA = "0x10582FC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170A")]
	public static int LessIsMoreFakeEventProductsFailures
	{
		[Token(Token = "0x6017514")]
		[Address(RVA = "0x1058428", Offset = "0x1058428", VA = "0x1058428")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170B")]
	public static string WebPageFallbackStrategy
	{
		[Token(Token = "0x6017515")]
		[Address(RVA = "0x1058554", Offset = "0x1058554", VA = "0x1058554")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700170C")]
	public static string TranslateDeepLinkInput
	{
		[Token(Token = "0x6017516")]
		[Address(RVA = "0x1058758", Offset = "0x1058758", VA = "0x1058758")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700170D")]
	public static string TranslateDeepLinkOutput
	{
		[Token(Token = "0x6017517")]
		[Address(RVA = "0x10588C4", Offset = "0x10588C4", VA = "0x10588C4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700170E")]
	public static int VeteranReminderDays
	{
		[Token(Token = "0x6017519")]
		[Address(RVA = "0x1058B64", Offset = "0x1058B64", VA = "0x1058B64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700170F")]
	public static bool? DisplayDebugInfo
	{
		[Token(Token = "0x601751A")]
		[Address(RVA = "0x1056B00", Offset = "0x1056B00", VA = "0x1056B00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001710")]
	public static bool DebugSkipRoomCheck
	{
		[Token(Token = "0x601751B")]
		[Address(RVA = "0x1058C90", Offset = "0x1058C90", VA = "0x1058C90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001711")]
	public static string VersionOfIAPProducts
	{
		[Token(Token = "0x601751C")]
		[Address(RVA = "0x1058DC4", Offset = "0x1058DC4", VA = "0x1058DC4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001712")]
	public static float DurationForEatingChicken
	{
		[Token(Token = "0x601751D")]
		[Address(RVA = "0x1058F30", Offset = "0x1058F30", VA = "0x1058F30")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001713")]
	public static string VersionOfPaymentBundles
	{
		[Token(Token = "0x601751E")]
		[Address(RVA = "0x1059064", Offset = "0x1059064", VA = "0x1059064")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001714")]
	public static string VersionOfRebateCardss
	{
		[Token(Token = "0x601751F")]
		[Address(RVA = "0x10591D0", Offset = "0x10591D0", VA = "0x10591D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001715")]
	public static ulong PaymentBundleNextResetTime
	{
		[Token(Token = "0x6017520")]
		[Address(RVA = "0x105933C", Offset = "0x105933C", VA = "0x105933C")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001716")]
	public static string TestPayMainUrl_Paid
	{
		[Token(Token = "0x6017521")]
		[Address(RVA = "0x105946C", Offset = "0x105946C", VA = "0x105946C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001717")]
	public static string TestPayMainUrl_Unpaid
	{
		[Token(Token = "0x6017522")]
		[Address(RVA = "0x10595D8", Offset = "0x10595D8", VA = "0x10595D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001718")]
	public static string TestPaymentActivityImageUrl
	{
		[Token(Token = "0x6017523")]
		[Address(RVA = "0x1059744", Offset = "0x1059744", VA = "0x1059744")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001719")]
	public static string TestPayItemUrl_iOS
	{
		[Token(Token = "0x6017524")]
		[Address(RVA = "0x10598B0", Offset = "0x10598B0", VA = "0x10598B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171A")]
	public static string TestPayIAPButtonUrl_Android
	{
		[Token(Token = "0x6017525")]
		[Address(RVA = "0x1059A1C", Offset = "0x1059A1C", VA = "0x1059A1C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171B")]
	public static string TestPayAdImageUrl_Android
	{
		[Token(Token = "0x6017526")]
		[Address(RVA = "0x1059B88", Offset = "0x1059B88", VA = "0x1059B88")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171C")]
	public static string TestPayAdClickUrl_Android
	{
		[Token(Token = "0x6017527")]
		[Address(RVA = "0x1059CF4", Offset = "0x1059CF4", VA = "0x1059CF4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171D")]
	public static string TestShareUrl
	{
		[Token(Token = "0x6017528")]
		[Address(RVA = "0x1059E60", Offset = "0x1059E60", VA = "0x1059E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171E")]
	public static string TestInviteUrl
	{
		[Token(Token = "0x6017529")]
		[Address(RVA = "0x1059FCC", Offset = "0x1059FCC", VA = "0x1059FCC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700171F")]
	public static string TestOpenedByUrl
	{
		[Token(Token = "0x601752A")]
		[Address(RVA = "0x105A138", Offset = "0x105A138", VA = "0x105A138")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001720")]
	public static string TestOpenedByWebUrl
	{
		[Token(Token = "0x601752B")]
		[Address(RVA = "0x105A2A4", Offset = "0x105A2A4", VA = "0x105A2A4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001721")]
	public static string TestOpenedWithDeepLinkUrl
	{
		[Token(Token = "0x601752C")]
		[Address(RVA = "0x105A410", Offset = "0x105A410", VA = "0x105A410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001722")]
	public static string TestOpenedWithWebViewUrl
	{
		[Token(Token = "0x601752D")]
		[Address(RVA = "0x105A57C", Offset = "0x105A57C", VA = "0x105A57C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001723")]
	public static string TestOpenedWithWebViewStyle
	{
		[Token(Token = "0x601752E")]
		[Address(RVA = "0x105A6E8", Offset = "0x105A6E8", VA = "0x105A6E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001724")]
	public static string TestOpenedWithBrowserUrl
	{
		[Token(Token = "0x601752F")]
		[Address(RVA = "0x105A854", Offset = "0x105A854", VA = "0x105A854")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001725")]
	public static uint PrepareForNavigatePos
	{
		[Token(Token = "0x6017530")]
		[Address(RVA = "0x105A9C0", Offset = "0x105A9C0", VA = "0x105A9C0")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001726")]
	public static string PrepareForNavigateParam
	{
		[Token(Token = "0x6017531")]
		[Address(RVA = "0x105AAEC", Offset = "0x105AAEC", VA = "0x105AAEC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001727")]
	public static string BillboardTestDesc
	{
		[Token(Token = "0x6017532")]
		[Address(RVA = "0x105AC58", Offset = "0x105AC58", VA = "0x105AC58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001728")]
	public static bool GMSDKEnableDebugLog
	{
		[Token(Token = "0x6017533")]
		[Address(RVA = "0x105ADC4", Offset = "0x105ADC4", VA = "0x105ADC4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001729")]
	public static bool ResetGuest
	{
		[Token(Token = "0x6017534")]
		[Address(RVA = "0x105AEF8", Offset = "0x105AEF8", VA = "0x105AEF8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700172A")]
	public static bool RebateCardOverride
	{
		[Token(Token = "0x6017535")]
		[Address(RVA = "0x105B02C", Offset = "0x105B02C", VA = "0x105B02C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700172B")]
	public static bool RebateCardEnabled
	{
		[Token(Token = "0x6017536")]
		[Address(RVA = "0x105B160", Offset = "0x105B160", VA = "0x105B160")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700172C")]
	public static bool PaymentBundleOverride
	{
		[Token(Token = "0x6017537")]
		[Address(RVA = "0x105B294", Offset = "0x105B294", VA = "0x105B294")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700172D")]
	public static bool PaymentBundleEnabled
	{
		[Token(Token = "0x6017538")]
		[Address(RVA = "0x105B3C8", Offset = "0x105B3C8", VA = "0x105B3C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700172E")]
	public static bool PaymentShopOverride
	{
		[Token(Token = "0x6017539")]
		[Address(RVA = "0x105B4FC", Offset = "0x105B4FC", VA = "0x105B4FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700172F")]
	public static bool PaymentShopEnabled
	{
		[Token(Token = "0x601753A")]
		[Address(RVA = "0x105B630", Offset = "0x105B630", VA = "0x105B630")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001730")]
	public static bool PaymentShopFirstOverride
	{
		[Token(Token = "0x601753B")]
		[Address(RVA = "0x105B764", Offset = "0x105B764", VA = "0x105B764")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001731")]
	public static bool PaymentShopFirst
	{
		[Token(Token = "0x601753C")]
		[Address(RVA = "0x105B898", Offset = "0x105B898", VA = "0x105B898")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001732")]
	public static string PaymentShopCdnUrl
	{
		[Token(Token = "0x601753D")]
		[Address(RVA = "0x105B9CC", Offset = "0x105B9CC", VA = "0x105B9CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001733")]
	public static string PaymentShopFallbackStrategy
	{
		[Token(Token = "0x601753E")]
		[Address(RVA = "0x105BB38", Offset = "0x105BB38", VA = "0x105BB38")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001734")]
	public static bool PaymentShopFalseFaulty
	{
		[Token(Token = "0x601753F")]
		[Address(RVA = "0x105BCA4", Offset = "0x105BCA4", VA = "0x105BCA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001735")]
	public static bool PreferExternalUnityPaymentShopOverride
	{
		[Token(Token = "0x6017540")]
		[Address(RVA = "0x105BDD8", Offset = "0x105BDD8", VA = "0x105BDD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001736")]
	public static bool PreferExternalUnityPaymentShop
	{
		[Token(Token = "0x6017541")]
		[Address(RVA = "0x105BF0C", Offset = "0x105BF0C", VA = "0x105BF0C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001737")]
	public static bool RecommitBeforePaymentOverride
	{
		[Token(Token = "0x6017542")]
		[Address(RVA = "0x105C040", Offset = "0x105C040", VA = "0x105C040")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001738")]
	public static bool RecommitBeforePayment
	{
		[Token(Token = "0x6017543")]
		[Address(RVA = "0x105C174", Offset = "0x105C174", VA = "0x105C174")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001739")]
	public static bool ForceDisplayAllPaymentTabs
	{
		[Token(Token = "0x6017544")]
		[Address(RVA = "0x105C2A8", Offset = "0x105C2A8", VA = "0x105C2A8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173A")]
	public static bool ScreenshotForIAPBundles
	{
		[Token(Token = "0x6017545")]
		[Address(RVA = "0x105C3DC", Offset = "0x105C3DC", VA = "0x105C3DC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173B")]
	public static bool LogoutStopTPNS
	{
		[Token(Token = "0x6017546")]
		[Address(RVA = "0x105C510", Offset = "0x105C510", VA = "0x105C510")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173C")]
	public static bool ForceWebView
	{
		[Token(Token = "0x6017547")]
		[Address(RVA = "0x105C644", Offset = "0x105C644", VA = "0x105C644")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700173D")]
	public static string TestWebViewUrl
	{
		[Token(Token = "0x6017548")]
		[Address(RVA = "0x105C778", Offset = "0x105C778", VA = "0x105C778")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700173E")]
	public static string TestLiveTVUrl
	{
		[Token(Token = "0x6017549")]
		[Address(RVA = "0x105C8E4", Offset = "0x105C8E4", VA = "0x105C8E4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700173F")]
	public static string TestBooyahTVUrl
	{
		[Token(Token = "0x601754A")]
		[Address(RVA = "0x105CA50", Offset = "0x105CA50", VA = "0x105CA50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001740")]
	public static string TestMShopUrl
	{
		[Token(Token = "0x601754B")]
		[Address(RVA = "0x105CBBC", Offset = "0x105CBBC", VA = "0x105CBBC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001741")]
	public static uint OverrideProduction
	{
		[Token(Token = "0x601754C")]
		[Address(RVA = "0x105CD28", Offset = "0x105CD28", VA = "0x105CD28")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001742")]
	public static bool AndroidWebViewUseActivityOverride
	{
		[Token(Token = "0x601754D")]
		[Address(RVA = "0x105CE54", Offset = "0x105CE54", VA = "0x105CE54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001743")]
	public static bool AndroidWebViewUseActivity
	{
		[Token(Token = "0x601754E")]
		[Address(RVA = "0x105CF88", Offset = "0x105CF88", VA = "0x105CF88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001744")]
	public static string TestProductIdentifier
	{
		[Token(Token = "0x601754F")]
		[Address(RVA = "0x105D0BC", Offset = "0x105D0BC", VA = "0x105D0BC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001745")]
	public static long TestRebateCardNotifyTimeOfDay_Local_MS
	{
		[Token(Token = "0x6017550")]
		[Address(RVA = "0x105D228", Offset = "0x105D228", VA = "0x105D228")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001746")]
	public static long TestPlayTestNotifyTimeOfDay_Local_MS
	{
		[Token(Token = "0x6017551")]
		[Address(RVA = "0x105D5C4", Offset = "0x105D5C4", VA = "0x105D5C4")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001747")]
	public static string TestHook
	{
		[Token(Token = "0x6017552")]
		[Address(RVA = "0x105D6F8", Offset = "0x105D6F8", VA = "0x105D6F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001748")]
	public static int TestIAPBundleStoreID
	{
		[Token(Token = "0x6017555")]
		[Address(RVA = "0x105DB28", Offset = "0x105DB28", VA = "0x105DB28")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001749")]
	public static int TestIAPBundleDuration
	{
		[Token(Token = "0x6017556")]
		[Address(RVA = "0x105DC54", Offset = "0x105DC54", VA = "0x105DC54")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700174A")]
	public static int TestMinutesOfNotifyBeforeIAPBundleEnds
	{
		[Token(Token = "0x6017557")]
		[Address(RVA = "0x105DD80", Offset = "0x105DD80", VA = "0x105DD80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700174B")]
	public static bool TestIAPBundleFirstTime
	{
		[Token(Token = "0x6017558")]
		[Address(RVA = "0x105DEAC", Offset = "0x105DEAC", VA = "0x105DEAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700174C")]
	public static bool TestIAPBundleAllPurchasable
	{
		[Token(Token = "0x6017559")]
		[Address(RVA = "0x105DFE0", Offset = "0x105DFE0", VA = "0x105DFE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700174D")]
	public static bool ForceIAPBundleFullyDisplay
	{
		[Token(Token = "0x601755A")]
		[Address(RVA = "0x105E114", Offset = "0x105E114", VA = "0x105E114")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700174E")]
	public static bool ForcePlatformFriendReunion
	{
		[Token(Token = "0x601755B")]
		[Address(RVA = "0x105E248", Offset = "0x105E248", VA = "0x105E248")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700174F")]
	public static bool? TestSparkEventEnabled
	{
		[Token(Token = "0x601755C")]
		[Address(RVA = "0x105E37C", Offset = "0x105E37C", VA = "0x105E37C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001750")]
	public static bool? TestSparkEventDebugWithoutMTV
	{
		[Token(Token = "0x601755D")]
		[Address(RVA = "0x105E538", Offset = "0x105E538", VA = "0x105E538")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001751")]
	public static bool? TestSparkEventOnEnterLobby
	{
		[Token(Token = "0x601755E")]
		[Address(RVA = "0x105E6F4", Offset = "0x105E6F4", VA = "0x105E6F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001752")]
	public static bool? TestSparkEventDebugMode
	{
		[Token(Token = "0x601755F")]
		[Address(RVA = "0x105E8B0", Offset = "0x105E8B0", VA = "0x105E8B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001753")]
	public static long TestFreeGachaNotifyTimeOfDay_Local_MS
	{
		[Token(Token = "0x6017560")]
		[Address(RVA = "0x105EA6C", Offset = "0x105EA6C", VA = "0x105EA6C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001754")]
	public static bool DisableRandomDelayForNotifies
	{
		[Token(Token = "0x6017561")]
		[Address(RVA = "0x105EC38", Offset = "0x105EC38", VA = "0x105EC38")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001755")]
	public static string DetectAndroidApplicationBundleIdentifier
	{
		[Token(Token = "0x6017562")]
		[Address(RVA = "0x105ED6C", Offset = "0x105ED6C", VA = "0x105ED6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001756")]
	public static string TestDeviceIdForGoogleAdMob
	{
		[Token(Token = "0x6017563")]
		[Address(RVA = "0x105EED8", Offset = "0x105EED8", VA = "0x105EED8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001757")]
	public static bool TestAdMobOverride
	{
		[Token(Token = "0x6017564")]
		[Address(RVA = "0x105F044", Offset = "0x105F044", VA = "0x105F044")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001758")]
	public static string TestRewardedVideoAdUnitId
	{
		[Token(Token = "0x6017565")]
		[Address(RVA = "0x105F178", Offset = "0x105F178", VA = "0x105F178")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001759")]
	public static bool TestAdMob
	{
		[Token(Token = "0x6017566")]
		[Address(RVA = "0x105F2E4", Offset = "0x105F2E4", VA = "0x105F2E4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700175A")]
	public static bool ForceEnableRewardedVideo
	{
		[Token(Token = "0x6017567")]
		[Address(RVA = "0x105F418", Offset = "0x105F418", VA = "0x105F418")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700175B")]
	public static bool ForceEnableRewardVideoAfterMatch
	{
		[Token(Token = "0x6017568")]
		[Address(RVA = "0x105F54C", Offset = "0x105F54C", VA = "0x105F54C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700175C")]
	public static int PaymentBundlesReloadInterval
	{
		[Token(Token = "0x6017569")]
		[Address(RVA = "0x105F680", Offset = "0x105F680", VA = "0x105F680")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700175D")]
	public static bool IAPLogVerbose
	{
		[Token(Token = "0x601756A")]
		[Address(RVA = "0x105F7AC", Offset = "0x105F7AC", VA = "0x105F7AC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700175E")]
	public static bool PlatformProductionLogVerbose
	{
		[Token(Token = "0x601756B")]
		[Address(RVA = "0x105F8E0", Offset = "0x105F8E0", VA = "0x105F8E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700175F")]
	public static bool RebateCardLogVerbose
	{
		[Token(Token = "0x601756C")]
		[Address(RVA = "0x105FA14", Offset = "0x105FA14", VA = "0x105FA14")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001760")]
	public static bool LocalNotifyLogVerbose
	{
		[Token(Token = "0x601756D")]
		[Address(RVA = "0x105FB48", Offset = "0x105FB48", VA = "0x105FB48")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001761")]
	public static long LocalNotifyStatsEventLogInterval
	{
		[Token(Token = "0x601756E")]
		[Address(RVA = "0x105FC7C", Offset = "0x105FC7C", VA = "0x105FC7C")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001762")]
	public static bool UIWaitingLogVerbose
	{
		[Token(Token = "0x601756F")]
		[Address(RVA = "0x105FDB0", Offset = "0x105FDB0", VA = "0x105FDB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001763")]
	public static bool LoginLogVerbose
	{
		[Token(Token = "0x6017570")]
		[Address(RVA = "0x105FEE4", Offset = "0x105FEE4", VA = "0x105FEE4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001764")]
	public static bool AutoUIIntentsLogVerbose
	{
		[Token(Token = "0x6017571")]
		[Address(RVA = "0x1060018", Offset = "0x1060018", VA = "0x1060018")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001765")]
	public static bool ForceCrash
	{
		[Token(Token = "0x6017572")]
		[Address(RVA = "0x106014C", Offset = "0x106014C", VA = "0x106014C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001766")]
	public static bool EnableUGCFullCustom
	{
		[Token(Token = "0x6017573")]
		[Address(RVA = "0x1060280", Offset = "0x1060280", VA = "0x1060280")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001767")]
	public static bool FirebaseLogVerbose
	{
		[Token(Token = "0x6017574")]
		[Address(RVA = "0x10603B4", Offset = "0x10603B4", VA = "0x10603B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001768")]
	public static bool GERLogVerbose
	{
		[Token(Token = "0x6017575")]
		[Address(RVA = "0x10604E8", Offset = "0x10604E8", VA = "0x10604E8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001769")]
	public static bool InterAppLogVerbose
	{
		[Token(Token = "0x6017576")]
		[Address(RVA = "0x106061C", Offset = "0x106061C", VA = "0x106061C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700176A")]
	public static bool TPNSLogVerbose
	{
		[Token(Token = "0x6017577")]
		[Address(RVA = "0x1060750", Offset = "0x1060750", VA = "0x1060750")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700176B")]
	public static bool DisableCacheForFirebaseAnalytics
	{
		[Token(Token = "0x6017578")]
		[Address(RVA = "0x1060884", Offset = "0x1060884", VA = "0x1060884")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700176C")]
	public static bool DisableCacheForFirebaseMessaging
	{
		[Token(Token = "0x6017579")]
		[Address(RVA = "0x10609B8", Offset = "0x10609B8", VA = "0x10609B8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700176D")]
	public static bool FirebaseSettingsOverride
	{
		[Token(Token = "0x601757A")]
		[Address(RVA = "0x1060AEC", Offset = "0x1060AEC", VA = "0x1060AEC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700176E")]
	public static bool FirebaseEnabled
	{
		[Token(Token = "0x601757B")]
		[Address(RVA = "0x1060C20", Offset = "0x1060C20", VA = "0x1060C20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700176F")]
	public static bool FirebaseMessagingEnabled
	{
		[Token(Token = "0x601757C")]
		[Address(RVA = "0x1060D54", Offset = "0x1060D54", VA = "0x1060D54")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001770")]
	public static bool FirebaseAnalyticsEnabled
	{
		[Token(Token = "0x601757D")]
		[Address(RVA = "0x1060E88", Offset = "0x1060E88", VA = "0x1060E88")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001771")]
	public static bool FirebaseCrashlyticsEnabled
	{
		[Token(Token = "0x601757E")]
		[Address(RVA = "0x1060FBC", Offset = "0x1060FBC", VA = "0x1060FBC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001772")]
	public static bool FirebaseMessagingSettingsOverride
	{
		[Token(Token = "0x601757F")]
		[Address(RVA = "0x10610F0", Offset = "0x10610F0", VA = "0x10610F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001773")]
	public static bool FirebaseMessagingUseUserProperties
	{
		[Token(Token = "0x6017580")]
		[Address(RVA = "0x1061224", Offset = "0x1061224", VA = "0x1061224")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001774")]
	public static bool FirebaseMessagingUseTopics
	{
		[Token(Token = "0x6017581")]
		[Address(RVA = "0x1061358", Offset = "0x1061358", VA = "0x1061358")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001775")]
	public static bool GER_Override
	{
		[Token(Token = "0x6017582")]
		[Address(RVA = "0x106148C", Offset = "0x106148C", VA = "0x106148C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001776")]
	public static bool GER_Enabled
	{
		[Token(Token = "0x6017583")]
		[Address(RVA = "0x10615C0", Offset = "0x10615C0", VA = "0x10615C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001777")]
	public static int GER_Env
	{
		[Token(Token = "0x6017584")]
		[Address(RVA = "0x10616F4", Offset = "0x10616F4", VA = "0x10616F4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001778")]
	public static string GER_SponsorId
	{
		[Token(Token = "0x6017585")]
		[Address(RVA = "0x1061820", Offset = "0x1061820", VA = "0x1061820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001779")]
	public static bool GER_BypassAllFilters
	{
		[Token(Token = "0x6017586")]
		[Address(RVA = "0x106198C", Offset = "0x106198C", VA = "0x106198C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700177A")]
	public static string GER_ApiKey
	{
		[Token(Token = "0x6017587")]
		[Address(RVA = "0x1061AC0", Offset = "0x1061AC0", VA = "0x1061AC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177B")]
	public static string GER_EP
	{
		[Token(Token = "0x6017588")]
		[Address(RVA = "0x1061C2C", Offset = "0x1061C2C", VA = "0x1061C2C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700177C")]
	public static bool Subscription_Override
	{
		[Token(Token = "0x6017589")]
		[Address(RVA = "0x1061D98", Offset = "0x1061D98", VA = "0x1061D98")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700177D")]
	public static bool Subscription_RebateCard_Enabled
	{
		[Token(Token = "0x601758A")]
		[Address(RVA = "0x1061ECC", Offset = "0x1061ECC", VA = "0x1061ECC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700177E")]
	public static bool Subscription_ElitePass_Enabled
	{
		[Token(Token = "0x601758B")]
		[Address(RVA = "0x1062000", Offset = "0x1062000", VA = "0x1062000")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700177F")]
	public static int Subscription_Bundles_Switch
	{
		[Token(Token = "0x601758C")]
		[Address(RVA = "0x1062134", Offset = "0x1062134", VA = "0x1062134")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001780")]
	public static int Subscription_Membership_Switch
	{
		[Token(Token = "0x601758D")]
		[Address(RVA = "0x1062260", Offset = "0x1062260", VA = "0x1062260")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001781")]
	public static string Subscription_ProductIdentifier_ElitePass
	{
		[Token(Token = "0x601758E")]
		[Address(RVA = "0x106238C", Offset = "0x106238C", VA = "0x106238C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001782")]
	public static string Subscription_ProductIdentifier_MonthCard
	{
		[Token(Token = "0x601758F")]
		[Address(RVA = "0x10624F8", Offset = "0x10624F8", VA = "0x10624F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001783")]
	public static string Subscription_ProductIdentifier_WeekCard
	{
		[Token(Token = "0x6017590")]
		[Address(RVA = "0x1062664", Offset = "0x1062664", VA = "0x1062664")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001784")]
	public static int Subscription_GracePeriod_ProductId
	{
		[Token(Token = "0x6017591")]
		[Address(RVA = "0x10627D0", Offset = "0x10627D0", VA = "0x10627D0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001785")]
	public static ulong Subscription_GracePeriod_ExpiryTime
	{
		[Token(Token = "0x6017592")]
		[Address(RVA = "0x10628FC", Offset = "0x10628FC", VA = "0x10628FC")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001786")]
	public static bool ShowPaymentFailureSignatureOverride
	{
		[Token(Token = "0x6017593")]
		[Address(RVA = "0x1062A30", Offset = "0x1062A30", VA = "0x1062A30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001787")]
	public static bool ShowPaymentFailureSignature
	{
		[Token(Token = "0x6017594")]
		[Address(RVA = "0x1062B64", Offset = "0x1062B64", VA = "0x1062B64")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001788")]
	public static long ElitePassSubscribeStart_Seconds
	{
		[Token(Token = "0x6017595")]
		[Address(RVA = "0x1062C98", Offset = "0x1062C98", VA = "0x1062C98")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001789")]
	public static long ElitePassSubscribeEnd_Seconds
	{
		[Token(Token = "0x6017596")]
		[Address(RVA = "0x1062DCC", Offset = "0x1062DCC", VA = "0x1062DCC")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x1700178A")]
	public static bool ElitePassSubscribedOverride
	{
		[Token(Token = "0x6017597")]
		[Address(RVA = "0x1062F00", Offset = "0x1062F00", VA = "0x1062F00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700178B")]
	public static bool ElitePassSubscribed
	{
		[Token(Token = "0x6017598")]
		[Address(RVA = "0x1063034", Offset = "0x1063034", VA = "0x1063034")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700178C")]
	public static bool CopyOpenID
	{
		[Token(Token = "0x6017599")]
		[Address(RVA = "0x1063168", Offset = "0x1063168", VA = "0x1063168")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700178D")]
	public static bool TPNS_Override
	{
		[Token(Token = "0x601759A")]
		[Address(RVA = "0x106329C", Offset = "0x106329C", VA = "0x106329C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700178E")]
	public static bool TPNS
	{
		[Token(Token = "0x601759B")]
		[Address(RVA = "0x10633D0", Offset = "0x10633D0", VA = "0x10633D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700178F")]
	public static bool TPNS_FCM
	{
		[Token(Token = "0x601759C")]
		[Address(RVA = "0x1063504", Offset = "0x1063504", VA = "0x1063504")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001790")]
	public static bool TPNS_NoCache
	{
		[Token(Token = "0x601759D")]
		[Address(RVA = "0x1063638", Offset = "0x1063638", VA = "0x1063638")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001791")]
	public static bool TPNS_Preview
	{
		[Token(Token = "0x601759E")]
		[Address(RVA = "0x106376C", Offset = "0x106376C", VA = "0x106376C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001792")]
	public static bool WebViewOverride
	{
		[Token(Token = "0x601759F")]
		[Address(RVA = "0x10638A0", Offset = "0x10638A0", VA = "0x10638A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001793")]
	public static bool WebViewDisableJavaScriptInjection
	{
		[Token(Token = "0x60175A0")]
		[Address(RVA = "0x10639D4", Offset = "0x10639D4", VA = "0x10639D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001794")]
	public static bool WebViewOnlyAutoPlayMediaWithWIFI
	{
		[Token(Token = "0x60175A1")]
		[Address(RVA = "0x1063B08", Offset = "0x1063B08", VA = "0x1063B08")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001795")]
	public static bool WebViewOverrideReloadAsCaptureScreenshot
	{
		[Token(Token = "0x60175A2")]
		[Address(RVA = "0x1063C3C", Offset = "0x1063C3C", VA = "0x1063C3C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001796")]
	public static bool WebViewDisableMediaManipulationOnHideAndShowByJavaScript
	{
		[Token(Token = "0x60175A3")]
		[Address(RVA = "0x1063D70", Offset = "0x1063D70", VA = "0x1063D70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001797")]
	public static bool WebViewProtect
	{
		[Token(Token = "0x60175A4")]
		[Address(RVA = "0x1063EA4", Offset = "0x1063EA4", VA = "0x1063EA4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001798")]
	public static bool WebViewPromptFaulty
	{
		[Token(Token = "0x60175A5")]
		[Address(RVA = "0x1063FD8", Offset = "0x1063FD8", VA = "0x1063FD8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001799")]
	public static bool WebViewFallbackToBrowser
	{
		[Token(Token = "0x60175A6")]
		[Address(RVA = "0x106410C", Offset = "0x106410C", VA = "0x106410C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700179A")]
	public static bool WebViewFalseFaulty
	{
		[Token(Token = "0x60175A7")]
		[Address(RVA = "0x1064240", Offset = "0x1064240", VA = "0x1064240")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700179B")]
	public static string WebViewJavaScriptName
	{
		[Token(Token = "0x60175A8")]
		[Address(RVA = "0x1064374", Offset = "0x1064374", VA = "0x1064374")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179C")]
	public static bool WebViewRunJavaScript
	{
		[Token(Token = "0x60175A9")]
		[Address(RVA = "0x10644E0", Offset = "0x10644E0", VA = "0x10644E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700179D")]
	public static string WebViewJavaScriptEcho
	{
		[Token(Token = "0x60175AA")]
		[Address(RVA = "0x1064614", Offset = "0x1064614", VA = "0x1064614")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700179E")]
	public static bool WebViewLogConsoleMessages
	{
		[Token(Token = "0x60175AB")]
		[Address(RVA = "0x1064780", Offset = "0x1064780", VA = "0x1064780")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700179F")]
	public static bool AndroidWebViewActivityDebugLog
	{
		[Token(Token = "0x60175AC")]
		[Address(RVA = "0x10648B4", Offset = "0x10648B4", VA = "0x10648B4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A0")]
	public static string[] WebViewLogUrls
	{
		[Token(Token = "0x60175AD")]
		[Address(RVA = "0x10649E8", Offset = "0x10649E8", VA = "0x10649E8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017A1")]
	public static bool WebViewDeferredDisplay
	{
		[Token(Token = "0x60175AE")]
		[Address(RVA = "0x1064D30", Offset = "0x1064D30", VA = "0x1064D30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A2")]
	public static float WebViewLoadingProgressAnimationDuration
	{
		[Token(Token = "0x60175AF")]
		[Address(RVA = "0x1064EA4", Offset = "0x1064EA4", VA = "0x1064EA4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170017A3")]
	public static float WebViewPromptReloadDuration
	{
		[Token(Token = "0x60175B0")]
		[Address(RVA = "0x106501C", Offset = "0x106501C", VA = "0x106501C")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170017A4")]
	public static bool MambetLogVerbose
	{
		[Token(Token = "0x60175B1")]
		[Address(RVA = "0x1065194", Offset = "0x1065194", VA = "0x1065194")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A5")]
	public static bool MambetDebugVoiceOverride
	{
		[Token(Token = "0x60175B2")]
		[Address(RVA = "0x10652C8", Offset = "0x10652C8", VA = "0x10652C8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A6")]
	public static bool MambetDebugVoice
	{
		[Token(Token = "0x60175B3")]
		[Address(RVA = "0x10653FC", Offset = "0x10653FC", VA = "0x10653FC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A7")]
	public static bool AccountOverride
	{
		[Token(Token = "0x60175B4")]
		[Address(RVA = "0x1065530", Offset = "0x1065530", VA = "0x1065530")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A8")]
	public static bool AccountGuestAllowed
	{
		[Token(Token = "0x60175B5")]
		[Address(RVA = "0x1065664", Offset = "0x1065664", VA = "0x1065664")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017A9")]
	public static bool FrontEndPreviewLogVerbose
	{
		[Token(Token = "0x60175B6")]
		[Address(RVA = "0x1065798", Offset = "0x1065798", VA = "0x1065798")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017AA")]
	public static string LanguageCheckFlag
	{
		[Token(Token = "0x60175B7")]
		[Address(RVA = "0x10658CC", Offset = "0x10658CC", VA = "0x10658CC")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170017AB")]
	public static bool TestChangeClothIngame
	{
		[Token(Token = "0x60175B8")]
		[Address(RVA = "0x1065A38", Offset = "0x1065A38", VA = "0x1065A38")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60175B9")]
		[Address(RVA = "0x1065AC4", Offset = "0x1065AC4", VA = "0x1065AC4")]
		set
		{
		}
	}

	[Token(Token = "0x170017AC")]
	public static bool TestAutoChangeClothInGame
	{
		[Token(Token = "0x60175BA")]
		[Address(RVA = "0x1065B54", Offset = "0x1065B54", VA = "0x1065B54")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60175BB")]
		[Address(RVA = "0x1065BE0", Offset = "0x1065BE0", VA = "0x1065BE0")]
		set
		{
		}
	}

	[Token(Token = "0x170017AD")]
	public static bool IsAnnouncementDebugMode
	{
		[Token(Token = "0x60175BC")]
		[Address(RVA = "0x1065C70", Offset = "0x1065C70", VA = "0x1065C70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60175BD")]
		[Address(RVA = "0x1065DA4", Offset = "0x1065DA4", VA = "0x1065DA4")]
		set
		{
		}
	}

	[Token(Token = "0x170017AE")]
	public static bool UMALogErrors
	{
		[Token(Token = "0x60175BE")]
		[Address(RVA = "0x1065ED0", Offset = "0x1065ED0", VA = "0x1065ED0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017AF")]
	public static bool UMALogDetails
	{
		[Token(Token = "0x60175BF")]
		[Address(RVA = "0x1066004", Offset = "0x1066004", VA = "0x1066004")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017B0")]
	public static bool UMALogDetails3P
	{
		[Token(Token = "0x60175C0")]
		[Address(RVA = "0x1066138", Offset = "0x1066138", VA = "0x1066138")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017B1")]
	public static bool UMALogTimes
	{
		[Token(Token = "0x60175C1")]
		[Address(RVA = "0x106626C", Offset = "0x106626C", VA = "0x106626C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017B2")]
	public static bool InAppReviewOverride
	{
		[Token(Token = "0x60175C2")]
		[Address(RVA = "0x10663A0", Offset = "0x10663A0", VA = "0x10663A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017B3")]
	public static bool InAppReviewEnabled
	{
		[Token(Token = "0x60175C3")]
		[Address(RVA = "0x10664D4", Offset = "0x10664D4", VA = "0x10664D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017B4")]
	public static string IPRegion
	{
		[Token(Token = "0x60175C5")]
		[Address(RVA = "0x1066734", Offset = "0x1066734", VA = "0x1066734")]
		get
		{
			return null;
		}
		[Token(Token = "0x60175C4")]
		[Address(RVA = "0x1066608", Offset = "0x1066608", VA = "0x1066608")]
		set
		{
		}
	}

	[Token(Token = "0x170017B5")]
	public static bool TestInvalidClientVersion
	{
		[Token(Token = "0x60175C6")]
		[Address(RVA = "0x10668A0", Offset = "0x10668A0", VA = "0x10668A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170017B6")]
	public static bool IsFFAITraining
	{
		[Token(Token = "0x60175D1")]
		[Address(RVA = "0x1068B00", Offset = "0x1068B00", VA = "0x1068B00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60174F5")]
	[Address(RVA = "0x1055B88", Offset = "0x1055B88", VA = "0x1055B88")]
	public static void OverrideServerAddr(string addr)
	{
	}

	[Token(Token = "0x60174F8")]
	[Address(RVA = "0x1055F44", Offset = "0x1055F44", VA = "0x1055F44")]
	public static bool NeedRefreshFile()
	{
		return default(bool);
	}

	[Token(Token = "0x6017506")]
	[Address(RVA = "0x10572FC", Offset = "0x10572FC", VA = "0x10572FC")]
	public static void SetOverrideGOPUrlFromVersion(string gop_url)
	{
	}

	[Token(Token = "0x601750C")]
	[Address(RVA = "0x1057AE4", Offset = "0x1057AE4", VA = "0x1057AE4")]
	public static void SetGarenaLoginInfo(bool login, bool hint)
	{
	}

	[Token(Token = "0x6017518")]
	[Address(RVA = "0x1058A30", Offset = "0x1058A30", VA = "0x1058A30")]
	public static bool LocalConfigFireWallOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6017553")]
	[Address(RVA = "0x105D864", Offset = "0x105D864", VA = "0x105D864")]
	private static long _DateTimeToTimeStamp(string timeString)
	{
		return default(long);
	}

	[Token(Token = "0x6017554")]
	[Address(RVA = "0x105D35C", Offset = "0x105D35C", VA = "0x105D35C")]
	private static long _TimeOfDayToMS(string timeString)
	{
		return default(long);
	}

	[Token(Token = "0x60175C7")]
	[Address(RVA = "0x10669D4", Offset = "0x10669D4", VA = "0x10669D4")]
	public static string GetClientIP()
	{
		return null;
	}

	[Token(Token = "0x60175C8")]
	[Address(RVA = "0x1066B50", Offset = "0x1066B50", VA = "0x1066B50")]
	private static string GetLocalIPAddress()
	{
		return null;
	}

	[Token(Token = "0x60175C9")]
	[Address(RVA = "0x1066D20", Offset = "0x1066D20", VA = "0x1066D20")]
	public static void SelectServer(ServerSettingsData region)
	{
	}

	[Token(Token = "0x60175CA")]
	[Address(RVA = "0x1066F30", Offset = "0x1066F30", VA = "0x1066F30")]
	public static void UpdateServerConfigFromHTTPVerGet(string serverAddr, string cdnAddr, bool isIOSReview)
	{
	}

	[Token(Token = "0x60175CB")]
	[Address(RVA = "0x106724C", Offset = "0x106724C", VA = "0x106724C")]
	public static string GetRegion()
	{
		return null;
	}

	[Token(Token = "0x60175CC")]
	[Address(RVA = "0x1067450", Offset = "0x1067450", VA = "0x1067450")]
	private static LocalConfig ReadUrlFromLocalConfig()
	{
		return null;
	}

	[Token(Token = "0x60175CD")]
	[Address(RVA = "0x10678FC", Offset = "0x10678FC", VA = "0x10678FC")]
	private static void SetAppSrc()
	{
	}

	[Token(Token = "0x60175CE")]
	[Address(RVA = "0x10679E8", Offset = "0x10679E8", VA = "0x10679E8")]
	public static void GotoAppSrc()
	{
	}

	[Token(Token = "0x60175CF")]
	[Address(RVA = "0x1067AC0", Offset = "0x1067AC0", VA = "0x1067AC0")]
	public static void Reset()
	{
	}

	[Token(Token = "0x60175D0")]
	[Address(RVA = "0x10689E0", Offset = "0x10689E0", VA = "0x10689E0")]
	public static bool IsRTLLanguage()
	{
		return default(bool);
	}
}
