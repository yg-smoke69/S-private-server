using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012F9")]
public class EActivity
{
	[Token(Token = "0x20012FA")]
	public enum Event
	{
		[Token(Token = "0x40085BD")]
		Event_NONE,
		[Token(Token = "0x40085BE")]
		Event_ENDMATCH,
		[Token(Token = "0x40085BF")]
		Event_LOGIN,
		[Token(Token = "0x40085C0")]
		Event_RECHARGE,
		[Token(Token = "0x40085C1")]
		Event_EXCHANGE,
		[Token(Token = "0x40085C2")]
		Event_SHARE,
		[Token(Token = "0x40085C3")]
		Event_BIND,
		[Token(Token = "0x40085C4")]
		Event_EP,
		[Token(Token = "0x40085C5")]
		Event_LEVEL_UP,
		[Token(Token = "0x40085C6")]
		Event_GEM_CONSUMPTION,
		[Token(Token = "0x40085C7")]
		Event_SEND_GIFT,
		[Token(Token = "0x40085C8")]
		Event_RETURNER,
		[Token(Token = "0x40085C9")]
		Event_RETURN_INVITER,
		[Token(Token = "0x40085CA")]
		Event_OPTIONAL_HOTFIX,
		[Token(Token = "0x40085CB")]
		Event_REBATE_CARD,
		[Token(Token = "0x40085CC")]
		Event_WATCH_AD,
		[Token(Token = "0x40085CD")]
		Event_CHECK_CLAN,
		[Token(Token = "0x40085CE")]
		Event_PRELOGIN,
		[Token(Token = "0x40085CF")]
		Event_GAIN_BADGE,
		[Token(Token = "0x40085D0")]
		Event_GOOGLE_ENGAGEMENT_REWARDS,
		[Token(Token = "0x40085D1")]
		Event_WATCH_AD_AFTER_MATCH,
		[Token(Token = "0x40085D2")]
		Event_LOTTERY,
		[Token(Token = "0x40085D3")]
		Event_AVATAR_LEVEL_UP,
		[Token(Token = "0x40085D4")]
		Event_UNLOCKED_SKILL_SLOT,
		[Token(Token = "0x40085D5")]
		Event_EQUIP_CLOTHES,
		[Token(Token = "0x40085D6")]
		Event_EQUIP_COLLECTION,
		[Token(Token = "0x40085D7")]
		Event_OPTIONAL_HOTFIX_VOICE,
		[Token(Token = "0x40085D8")]
		Event_OPTIONAL_MAP,
		[Token(Token = "0x40085D9")]
		Event_LIMITED_EVENT_STORE_PURCHASE,
		[Token(Token = "0x40085DA")]
		Event_ATTENDANCE_SIGNIN,
		[Token(Token = "0x40085DB")]
		Event_OPTIONAL_MAP_BERMUDA,
		[Token(Token = "0x40085DC")]
		Event_LIMITED_EVENT_RETURNER,
		[Token(Token = "0x40085DD")]
		Event_LIMITED_EVENT_RETURN_INVITER,
		[Token(Token = "0x40085DE")]
		Event_OPTIONAL_CUT_SCENE,
		[Token(Token = "0x40085DF")]
		Event_OPTIONAL_DOWNLOAD,
		[Token(Token = "0x40085E0")]
		Event_UGC_MAP,
		[Token(Token = "0x40085E1")]
		Event_UGC_SHARE,
		[Token(Token = "0x40085E2")]
		Event_SECRET_MISSION_CODE_EXCHANGED,
		[Token(Token = "0x40085E3")]
		Event_SECRET_MISSION_EXCHANGE_CODE
	}

	[Token(Token = "0x20012FB")]
	public enum PreConditionType
	{
		[Token(Token = "0x40085E5")]
		PreConditionType_NONE,
		[Token(Token = "0x40085E6")]
		PreConditionType_GROUPMODE,
		[Token(Token = "0x40085E7")]
		PreConditionType_RANK,
		[Token(Token = "0x40085E8")]
		PreConditionType_MATCHMODE,
		[Token(Token = "0x40085E9")]
		PreConditionType_GAMEMODE,
		[Token(Token = "0x40085EA")]
		PreConditionType_MAPID,
		[Token(Token = "0x40085EB")]
		PreConditionType_AVATAR,
		[Token(Token = "0x40085EC")]
		PreConditionType_CLOTHESID,
		[Token(Token = "0x40085ED")]
		PreConditionType_REBATECARDID,
		[Token(Token = "0x40085EE")]
		PreConditionType_Client_Version,
		[Token(Token = "0x40085EF")]
		PreConditionType_LOADOUT,
		[Token(Token = "0x40085F0")]
		PreConditionType_LOTTERY_TYPE,
		[Token(Token = "0x40085F1")]
		PreConditionType_WP_TYPE_PICK_UP,
		[Token(Token = "0x40085F2")]
		PreConditionType_LOCATION_KILL,
		[Token(Token = "0x40085F3")]
		PreConditionType_CERTAIN_WP_KILL,
		[Token(Token = "0x40085F4")]
		PreConditionType_LIMITED_EVENT_RAMPAGE,
		[Token(Token = "0x40085F5")]
		PreConditionType_MATCHSTATS_ITEM_ID,
		[Token(Token = "0x40085F6")]
		PreConditionType_KILLS,
		[Token(Token = "0x40085F7")]
		PreConditionType_SINGLE_GAME_SURVIVAL,
		[Token(Token = "0x40085F8")]
		PreConditionType_BRING_PET,
		[Token(Token = "0x40085F9")]
		PreConditionType_SINGLE_GAME_RESTORE,
		[Token(Token = "0x40085FA")]
		PreConditionType_SINGLE_GAME_BE_RESTORED,
		[Token(Token = "0x40085FB")]
		PreConditionType_GROUP_WITH_CONFIDANT,
		[Token(Token = "0x40085FC")]
		PreConditionType_GROUP_WITH_MENTOR,
		[Token(Token = "0x40085FD")]
		PreConditionType_GROUP_WITH_STUDENT,
		[Token(Token = "0x40085FE")]
		PreConditionType_GAMEMISSION,
		[Token(Token = "0x40085FF")]
		PreConditionType_SECRET_MISSION,
		[Token(Token = "0x4008600")]
		PreConditionType_GROUP_WITH_FRIEND
	}

	[Token(Token = "0x20012FC")]
	public enum ConditionType
	{
		[Token(Token = "0x4008602")]
		ConditionType_NONE = 0,
		[Token(Token = "0x4008603")]
		ConditionType_PLAY = 1,
		[Token(Token = "0x4008604")]
		ConditionType_KILL = 2,
		[Token(Token = "0x4008605")]
		ConditionType_ONLINEMINITES = 3,
		[Token(Token = "0x4008606")]
		ConditionType_GAMEMINITES = 4,
		[Token(Token = "0x4008607")]
		ConditionType_ANYDAYLOGIN = 5,
		[Token(Token = "0x4008608")]
		ConditionType_RECHARGECUMU = 6,
		[Token(Token = "0x4008609")]
		ConditionType_EXCHANGE = 7,
		[Token(Token = "0x400860A")]
		ConditionType_SHARECUMU = 8,
		[Token(Token = "0x400860B")]
		ConditionType_BIND = 9,
		[Token(Token = "0x400860C")]
		ConditionType_EP = 10,
		[Token(Token = "0x400860D")]
		ConditionType_LEVEL_UP = 11,
		[Token(Token = "0x400860E")]
		ConditionType_SEND_GIFT = 12,
		[Token(Token = "0x400860F")]
		ConditionType_GROUP_WITH_FRIEND = 14,
		[Token(Token = "0x4008610")]
		ConditionType_GEMSCONSUMECUMU = 15,
		[Token(Token = "0x4008611")]
		ConditionType_RETURNER = 16,
		[Token(Token = "0x4008612")]
		ConditionType_RETURN_INVITER = 17,
		[Token(Token = "0x4008613")]
		ConditionType_OPTIONAL_HOTFIX = 18,
		[Token(Token = "0x4008614")]
		ConditionType_REBATE_CARD = 19,
		[Token(Token = "0x4008615")]
		ConditionType_CHECK_CLAN = 21,
		[Token(Token = "0x4008616")]
		ConditionType_WATCH_AD = 22,
		[Token(Token = "0x4008617")]
		ConditionType_PRELOGIN = 23,
		[Token(Token = "0x4008618")]
		ConditionType_GAIN_BADGE = 24,
		[Token(Token = "0x4008619")]
		ConditionType_SIT_ON_THRONE = 25,
		[Token(Token = "0x400861A")]
		ConditionType_GOOGLE_ENGAGEMENT_REWARDS = 26,
		[Token(Token = "0x400861B")]
		ConditionType_GROUP_WITH_CLAN_MEMBER = 27,
		[Token(Token = "0x400861C")]
		ConditionType_WATCH_AD_AFTER_MATCH = 28,
		[Token(Token = "0x400861D")]
		ConditionType_LOTTERY_CNT = 29,
		[Token(Token = "0x400861E")]
		ConditionType_WIN = 30,
		[Token(Token = "0x400861F")]
		ConditionType_REVIVAL = 31,
		[Token(Token = "0x4008620")]
		ConditionType_RANKING_LEVEL_UP = 32,
		[Token(Token = "0x4008621")]
		ConditionType_LOADOUT = 33,
		[Token(Token = "0x4008622")]
		ConditionType_AVATAR_LEVEL_UP = 34,
		[Token(Token = "0x4008623")]
		ConditionType_UNLOCKED_SKILL_SLOT = 35,
		[Token(Token = "0x4008624")]
		ConditionType_EQUIP_CLOTHES = 36,
		[Token(Token = "0x4008625")]
		ConditionType_EQUIP_COLLECTION = 37,
		[Token(Token = "0x4008626")]
		ConditionType_EP_CHALLENGE = 38,
		[Token(Token = "0x4008627")]
		ConditionType_OPTIONAL_HOTFIX_VOICE = 39,
		[Token(Token = "0x4008628")]
		ConditionType_EMOTE_USE = 40,
		[Token(Token = "0x4008629")]
		ConditionType_LOADOUT_USE = 41,
		[Token(Token = "0x400862A")]
		ConditionType_TEAMMATE_SAVE = 42,
		[Token(Token = "0x400862B")]
		ConditionType_VEHICLE_DESTROY = 43,
		[Token(Token = "0x400862C")]
		ConditionType_DAMAGE_IN_MATCH = 44,
		[Token(Token = "0x400862D")]
		ConditionType_MOVING_DISTANCE = 45,
		[Token(Token = "0x400862E")]
		ConditionType_PAINT_USE = 46,
		[Token(Token = "0x400862F")]
		ConditionType_DIFF_WP_USE = 47,
		[Token(Token = "0x4008630")]
		ConditionType_MEET_CERTAIN_RANK = 48,
		[Token(Token = "0x4008631")]
		ConditionType_OPTIONAL_MAP = 49,
		[Token(Token = "0x4008632")]
		ConditionType_LIMITED_EVENT_STORE_PURCHASE = 50,
		[Token(Token = "0x4008633")]
		ConditionType_ATTENDANCE_SIGNIN = 51,
		[Token(Token = "0x4008634")]
		ConditionType_MATCHSTATS_ITEM_NUM = 52,
		[Token(Token = "0x4008635")]
		ConditionType_HEADSHOT = 53,
		[Token(Token = "0x4008636")]
		ConditionType_CERTAIN_WP_KILLS = 54,
		[Token(Token = "0x4008637")]
		ConditionType_OPTIONAL_MAP_BERMUDA = 55,
		[Token(Token = "0x4008638")]
		ConditionType_RESTORE = 57,
		[Token(Token = "0x4008639")]
		ConditionType_BE_RESTORED = 58,
		[Token(Token = "0x400863A")]
		ConditionType_NPC_INTERACTION = 59,
		[Token(Token = "0x400863B")]
		ConditionType_NPC_PHOTO = 60,
		[Token(Token = "0x400863C")]
		ConditionType_LIMITED_EVENT_RETURNER = 61,
		[Token(Token = "0x400863D")]
		ConditionType_LIMITED_EVENT_RETURN_INVITER = 62,
		[Token(Token = "0x400863E")]
		ConditionType_GROUP_WITH_MENTOR = 63,
		[Token(Token = "0x400863F")]
		ConditionType_ICE_WALL_USE = 64,
		[Token(Token = "0x4008640")]
		ConditionType_CS_SHOP_COST = 65,
		[Token(Token = "0x4008641")]
		ConditionType_OPTIONAL_CUT_SCENE = 66,
		[Token(Token = "0x4008642")]
		ConditionType_OPTIONAL_DOWNLOAD = 67,
		[Token(Token = "0x4008643")]
		ConditionType_GAMEMISSION_GET = 68,
		[Token(Token = "0x4008644")]
		ConditionType_GAMEMISSION_FINISH = 69,
		[Token(Token = "0x4008645")]
		ConditionType_VENDING_MACHINE = 70,
		[Token(Token = "0x4008646")]
		ConditionType_ACTIVE_SKILL = 71,
		[Token(Token = "0x4008647")]
		ConditionType_RESURRECTION_POINT_REVIVE_TEAMMATES = 72,
		[Token(Token = "0x4008648")]
		ConditionType_SECRET_MISSION_CODE_EXCHANGED = 73,
		[Token(Token = "0x4008649")]
		ConditionType_SECRET_MISSION_EXCHANGE_CODE = 74,
		[Token(Token = "0x400864A")]
		ConditionType_UGC_PUBLISH_MAPS_COUNT = 100,
		[Token(Token = "0x400864B")]
		ConditionType_UGC_FORWARD_MAPS_COUNT = 101,
		[Token(Token = "0x400864C")]
		ConditionType_UGC_SUBSCRIBE_MAPS_COUNT = 102,
		[Token(Token = "0x400864D")]
		ConditionType_UGC_LIKE_MAPS_COUNT = 103,
		[Token(Token = "0x400864E")]
		ConditionType_UGC_CREATE_ROOM_PLAY_COUNT = 104,
		[Token(Token = "0x400864F")]
		ConditionType_UGC_MAPS_BE_PLAYED_COUNT = 105,
		[Token(Token = "0x4008650")]
		ConditionType_UGC_MAPS_BE_LIKED_COUNT = 106,
		[Token(Token = "0x4008651")]
		ConditionType_UGC_MAPS_BE_SUBSCRIBED_COUNT = 107,
		[Token(Token = "0x4008652")]
		ConditionType_UGC_MAPS_WIN_COUNT = 108
	}

	[Token(Token = "0x20012FD")]
	public enum CircleType
	{
		[Token(Token = "0x4008654")]
		CircleType_NONE,
		[Token(Token = "0x4008655")]
		CircleType_DAILY,
		[Token(Token = "0x4008656")]
		CircleType_WEEKLY,
		[Token(Token = "0x4008657")]
		CircleType_MONTHLY,
		[Token(Token = "0x4008658")]
		CircleType_REPEAT
	}

	[Token(Token = "0x20012FE")]
	public enum State
	{
		[Token(Token = "0x400865A")]
		State_RECEIVED,
		[Token(Token = "0x400865B")]
		State_FINISHED,
		[Token(Token = "0x400865C")]
		State_AWARDED,
		[Token(Token = "0x400865D")]
		State_UNRECEIVED
	}

	[Token(Token = "0x20012FF")]
	public enum ActivityType
	{
		[Token(Token = "0x400865F")]
		ActivityType_NORMAL = 0,
		[Token(Token = "0x4008660")]
		ActivityType_FIRSTRECHARGE = 1,
		[Token(Token = "0x4008661")]
		ActivityType_EXCHANGE = 2,
		[Token(Token = "0x4008662")]
		ActivityType_SHARE = 3,
		[Token(Token = "0x4008663")]
		ActivityType_BIND = 4,
		[Token(Token = "0x4008664")]
		ActivityType_FESTIVAL = 5,
		[Token(Token = "0x4008665")]
		ActivityType_RETURNER = 6,
		[Token(Token = "0x4008666")]
		ActivityType_RETURN_INVITER = 7,
		[Token(Token = "0x4008667")]
		ActivityType_WATCH_AD = 8,
		[Token(Token = "0x4008668")]
		ActivityType_OPTIONAL_HOTFIX = 9,
		[Token(Token = "0x4008669")]
		ActivityType_CDN_SHOW = 10,
		[Token(Token = "0x400866A")]
		ActivityType_ANNOUNCE_SHOW = 11,
		[Token(Token = "0x400866B")]
		ActivityType_PRELOGIN = 12,
		[Token(Token = "0x400866C")]
		ActivityType_LIMITED_TIME_RECHARGE = 13,
		[Token(Token = "0x400866D")]
		ActivityType_MONTHLY_RECHARGE = 14,
		[Token(Token = "0x400866E")]
		ActivityType_MONTHLY_REBATE = 15,
		[Token(Token = "0x400866F")]
		ActivityType_WEEKLY_REBATE = 16,
		[Token(Token = "0x4008670")]
		ActivityType_GOOGLE_ENGAGEMENT_REWARDS = 17,
		[Token(Token = "0x4008671")]
		ActivityType_WATCH_AD_AFTER_MATCH = 18,
		[Token(Token = "0x4008672")]
		ActivityType_SECOND_RECHARGE = 19,
		[Token(Token = "0x4008673")]
		ActivityType_OVERVIEW = 20,
		[Token(Token = "0x4008674")]
		ActivityType_NAVIGATION = 21,
		[Token(Token = "0x4008675")]
		ActivityType_ACTIVENESS = 22,
		[Token(Token = "0x4008676")]
		ActivityType_OPTIONAL_HOTFIX_VOICE = 23,
		[Token(Token = "0x4008677")]
		ActivityType_OPTIONAL_MAP = 24,
		[Token(Token = "0x4008678")]
		ActivityType_EASTER = 25,
		[Token(Token = "0x4008679")]
		ActivityType_LIMITED_EVENT1 = 26,
		[Token(Token = "0x400867A")]
		ActivityType_LIMITED_EVENT2 = 27,
		[Token(Token = "0x400867B")]
		ActivityType_LIMITED_EVENT3 = 28,
		[Token(Token = "0x400867C")]
		ActivityType_LIMITED_EVENT4 = 29,
		[Token(Token = "0x400867D")]
		ActivityType_LIMITED_EVENT5 = 30,
		[Token(Token = "0x400867E")]
		ActivityType_OPTIONAL_MAP_BERMUDA = 31,
		[Token(Token = "0x400867F")]
		ActivityType_LIMITED_EVENT_BOOYAH = 32,
		[Token(Token = "0x4008680")]
		ActivityType_LIMITED_EVENT_BOUNTY = 33,
		[Token(Token = "0x4008681")]
		ActivityType_LIMITED_EVENT_MEGAPUNCH = 34,
		[Token(Token = "0x4008682")]
		ActivityType_CDN_SCROLLVIEW_SHOW = 35,
		[Token(Token = "0x4008683")]
		ActivityType_TOPUP_EVENT_NEW = 36,
		[Token(Token = "0x4008684")]
		ActivityType_OPTIONAL_CUT_SCENE = 37,
		[Token(Token = "0x4008685")]
		ActivityType_OPTIONAL_DOWNLOAD = 38,
		[Token(Token = "0x4008686")]
		ActivityType_FLASH_GEM_DAILY_ACTIVE = 39,
		[Token(Token = "0x4008687")]
		ActivityType_FLASH_GEM_LONG_TERM_ACTIVE = 40,
		[Token(Token = "0x4008688")]
		ActivityType_FLASH_GEM_SECRET_MISSION = 41,
		[Token(Token = "0x4008689")]
		ActivityType_FLASH_GEM_RECHARGE = 42,
		[Token(Token = "0x400868A")]
		ActivityType_LIMITED_EVENT_BERMUDA = 1000,
		[Token(Token = "0x400868B")]
		ActivityType_PICKONEFROMN = 1001,
		[Token(Token = "0x400868C")]
		ActivityType_LIMITED_EVENT_PEAKDAY = 1002,
		[Token(Token = "0x400868D")]
		ActivityType_LIMITED_EVENT_SIGNIN = 1003,
		[Token(Token = "0x400868E")]
		ActivityType_LIMITED_EVENT_DAILY = 1004,
		[Token(Token = "0x400868F")]
		ActivityType_LIMITED_EVENT_SILENT = 1005,
		[Token(Token = "0x4008690")]
		ActivityType_PASSIVE = 2000
	}

	[Token(Token = "0x2001300")]
	public enum SubType
	{
		[Token(Token = "0x4008692")]
		SubType_NONE = 0,
		[Token(Token = "0x4008693")]
		SubType_LIMITED_EVENT_GOLIATH = 1000,
		[Token(Token = "0x4008694")]
		SubType_MINIGAME_MONOPOLY = 1001,
		[Token(Token = "0x4008695")]
		SubType_LIMITED_EVENT_MVP = 1002,
		[Token(Token = "0x4008696")]
		SubType_LIMITED_EVENT_FFWS = 1003,
		[Token(Token = "0x4008697")]
		SubType_LIMITED_EVENT_SUPERFIGHTER = 1004,
		[Token(Token = "0x4008698")]
		SubType_LIMITED_EVENT_SUPERCAR = 1005,
		[Token(Token = "0x4008699")]
		SubType_LIMITED_EVENT_SUTORITO = 1006,
		[Token(Token = "0x400869A")]
		SubType_LIMITED_EVENT_FOURSYMBOLS = 1007,
		[Token(Token = "0x400869B")]
		SubType_LIMITED_EVENT_FOURSYMBOLS_AZURE_DRAGON = 1008,
		[Token(Token = "0x400869C")]
		SubType_LIMITED_EVENT_FOURSYMBOLS_WHITE_TIGER = 1009,
		[Token(Token = "0x400869D")]
		SubType_LIMITED_EVENT_FOURSYMBOLS_BLACK_TORTOISE = 1010,
		[Token(Token = "0x400869E")]
		SubType_LIMITED_EVENT_FOURSYMBOLS_VERMILLION_BIRD = 1011,
		[Token(Token = "0x400869F")]
		SubType_LIMITED_EVENT_MUSICFEST = 1012,
		[Token(Token = "0x40086A0")]
		SubType_LIMITED_EVENT_MOCOMONTH = 1013,
		[Token(Token = "0x40086A1")]
		SubType_LIMITED_EVENT_BOOYAHDAY21 = 1014,
		[Token(Token = "0x40086A2")]
		SubType_LIMITED_EVENT_BIS = 1015,
		[Token(Token = "0x40086A3")]
		Subtype_LIMITED_EVENT_FFWS03 = 1016,
		[Token(Token = "0x40086A4")]
		Subtype_CUSTOM_EVENT = 1017,
		[Token(Token = "0x40086A5")]
		Subtype_LIMITED_RETURNER = 1018,
		[Token(Token = "0x40086A6")]
		Subtype_LIMITED_RETURN_INVITER = 1019,
		[Token(Token = "0x40086A7")]
		SubType_LIMITED_EVENT_WINTERFEST21B = 1020,
		[Token(Token = "0x40086A8")]
		Subtype_LIMITED_EVENT_JUMPSUIT = 1021,
		[Token(Token = "0x40086A9")]
		Subtype_LIMITED_EVENT_HOODEDKILLERB = 1022,
		[Token(Token = "0x40086AA")]
		Subtype_LIMITED_EVENT_HURRICANEB = 1023,
		[Token(Token = "0x40086AB")]
		Subtype_LIMITED_EVENT_BOYBANDB = 1024,
		[Token(Token = "0x40086AC")]
		Subtype_LIMITED_EVENT_RAMPAGE4B = 1025,
		[Token(Token = "0x40086AD")]
		Subtype_LIMITED_EVENT_DIGITALUNIVERSEB_CHARACTER = 1026,
		[Token(Token = "0x40086AE")]
		Subtype_LIMITED_EVENT_DIGITALUNIVERSEB_MAP = 1027,
		[Token(Token = "0x40086AF")]
		Subtype_LIMITED_EVENT_DIGITALUNIVERSEB_EVENT = 1028,
		[Token(Token = "0x40086B0")]
		Subtype_LIMITED_EVENT_DIGITALUNIVERSEB = 1029,
		[Token(Token = "0x40086B1")]
		Subtype_LIMITED_EVENT_DIGITALUNIVERSEB_CLOTH = 1030,
		[Token(Token = "0x40086B2")]
		Subtype_LIMITED_EVENT_DIGITALUNIVERSEB_COLLECTION = 1031,
		[Token(Token = "0x40086B3")]
		SubType_SECRET_MISSION_CODE_EXCHANGED = 2001,
		[Token(Token = "0x40086B4")]
		SubType_SECRET_MISSION_EXCHANGE_CODE = 2002
	}

	[Token(Token = "0x2001301")]
	public enum TabType
	{
		[Token(Token = "0x40086B6")]
		TabType_NONE,
		[Token(Token = "0x40086B7")]
		TabType_NORMAL,
		[Token(Token = "0x40086B8")]
		TabType_FESTIVAL1,
		[Token(Token = "0x40086B9")]
		TabType_FESTIVAL2,
		[Token(Token = "0x40086BA")]
		TabType_GW1,
		[Token(Token = "0x40086BB")]
		TabType_GW2,
		[Token(Token = "0x40086BC")]
		TabType_LARGE_FESTIVAL,
		[Token(Token = "0x40086BD")]
		TabType_ACTIVENESS
	}

	[Token(Token = "0x2001302")]
	public enum Operation
	{
		[Token(Token = "0x40086BF")]
		Operation_NONE,
		[Token(Token = "0x40086C0")]
		Operation_RECEIVE,
		[Token(Token = "0x40086C1")]
		Operation_CANCEL
	}

	[Token(Token = "0x2001303")]
	public enum BingoActivityRewardsState
	{
		[Token(Token = "0x40086C3")]
		BingoActivityRewardsState_INIT,
		[Token(Token = "0x40086C4")]
		BingoActivityRewardsState_AWARDED
	}

	[Token(Token = "0x2001304")]
	public enum BingoActivityLevel
	{
		[Token(Token = "0x40086C6")]
		BingoActivityLevel_NONE,
		[Token(Token = "0x40086C7")]
		BingoActivityLevel_LOW,
		[Token(Token = "0x40086C8")]
		BingoActivityState_MEDIUM,
		[Token(Token = "0x40086C9")]
		BingoActivityState_HIGH
	}

	[Token(Token = "0x2001305")]
	public enum EventMissionType
	{
		[Token(Token = "0x40086CB")]
		EventMissionType_NONE,
		[Token(Token = "0x40086CC")]
		EventMissionType_ACT_LOTTERY,
		[Token(Token = "0x40086CD")]
		EventMissionType_GAME_MODE
	}

	[Token(Token = "0x2001306")]
	public enum Platform
	{
		[Token(Token = "0x40086CF")]
		Platform_NONE,
		[Token(Token = "0x40086D0")]
		Platform_GP,
		[Token(Token = "0x40086D1")]
		Platform_IOS,
		[Token(Token = "0x40086D2")]
		Platform_HUAWEI,
		[Token(Token = "0x40086D3")]
		Platform_XIAOMI
	}

	[Token(Token = "0x6007A46")]
	[Address(RVA = "0x309F240", Offset = "0x309F240", VA = "0x309F240")]
	public EActivity()
	{
	}
}
