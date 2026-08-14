using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012C1")]
public class EInventory
{
	[Token(Token = "0x20012C2")]
	public enum ItemType
	{
		[Token(Token = "0x40083A9")]
		ItemType_NONE = 0,
		[Token(Token = "0x40083AA")]
		ItemType_AVATAR = 1,
		[Token(Token = "0x40083AB")]
		ItemType_CLOTHES = 2,
		[Token(Token = "0x40083AC")]
		ItemType_LIMITEDCARD = 3,
		[Token(Token = "0x40083AD")]
		ItemType_TREASUREBOX = 4,
		[Token(Token = "0x40083AE")]
		ItemType_LOADOUTBOX = 5,
		[Token(Token = "0x40083AF")]
		ItemType_ROOMCARD = 6,
		[Token(Token = "0x40083B0")]
		ItemType_BUNDLE = 7,
		[Token(Token = "0x40083B1")]
		ItemType_DEBRIS = 8,
		[Token(Token = "0x40083B2")]
		ItemType_COLLECTION = 9,
		[Token(Token = "0x40083B3")]
		ItemType_VIRTUAL = 10,
		[Token(Token = "0x40083B4")]
		ItemType_BONUSCARD = 11,
		[Token(Token = "0x40083B5")]
		ItemType_STICKER = 12,
		[Token(Token = "0x40083B6")]
		ItemType_PET = 13,
		[Token(Token = "0x40083B7")]
		ItemType_BATTLEFLAG = 14,
		[Token(Token = "0x40083B8")]
		ItemType_EP_DEBRIS = 15,
		[Token(Token = "0x40083B9")]
		ItemType_OPTIONAL_BUNDLE = 17,
		[Token(Token = "0x40083BA")]
		ItemType_HYPERBOOK = 18
	}

	[Token(Token = "0x20012C3")]
	public enum ItemSubType
	{
		[Token(Token = "0x40083BC")]
		ItemSubType_NONE = 0,
		[Token(Token = "0x40083BD")]
		ItemSubType_LOTTERYTOKEN = 2,
		[Token(Token = "0x40083BE")]
		ItemSubType_ELITEPASS = 3,
		[Token(Token = "0x40083BF")]
		ItemSubType_VOUCHER = 4,
		[Token(Token = "0x40083C0")]
		ItemSubType_RENAMECARD = 5,
		[Token(Token = "0x40083C1")]
		ItemSubType_REDENVELOPE = 6,
		[Token(Token = "0x40083C2")]
		ItemSubType_PETFOOD = 7,
		[Token(Token = "0x40083C3")]
		ItemSubType_FORGECURRENCY = 8,
		[Token(Token = "0x40083C4")]
		ItemSubType_PETACTION = 9,
		[Token(Token = "0x40083C5")]
		ItemSubType_PETSKIN = 10,
		[Token(Token = "0x40083C6")]
		ItemSubType_REVIVETOKEN = 11,
		[Token(Token = "0x40083C7")]
		ItemSubType_AVATARLEVELCARD = 12,
		[Token(Token = "0x40083C8")]
		ItemSubType_CHIP = 13,
		[Token(Token = "0x40083C9")]
		ItemSubType_GUILD_TOKEN = 14,
		[Token(Token = "0x40083CA")]
		ItemSubType_PETSKILL = 15,
		[Token(Token = "0x40083CB")]
		ItemSubType_CRATE = 16,
		[Token(Token = "0x40083CC")]
		ItemSubType_GENERAL_DEBRIS = 17,
		[Token(Token = "0x40083CD")]
		ItemSubType_LIMITED_EVENT_POINTS = 18,
		[Token(Token = "0x40083CE")]
		ItemSubType_TIME_LIMITED_LOTTERYTOKEN = 19,
		[Token(Token = "0x40083CF")]
		ItemSubType_LIMITED_EVENT_BOUNTY_TOKEN = 20,
		[Token(Token = "0x40083D0")]
		ItemSubType_TRAINING_TOKEN = 21,
		[Token(Token = "0x40083D1")]
		ItemSubType_ROOMCARD_NORMAL = 22,
		[Token(Token = "0x40083D2")]
		ItemSubType_ROOMCARD_ADVANCED = 23,
		[Token(Token = "0x40083D3")]
		ItemSubType_ROOMCARD_WEREWOLVES = 24,
		[Token(Token = "0x40083D4")]
		ItemSubType_ROOMCARD_WORKSHOP = 25,
		[Token(Token = "0x40083D5")]
		ItemSubType_ROOMCARD_RUSHING_PETS = 26,
		[Token(Token = "0x40083D6")]
		ItemSubType_VIPCARD_RESIGN_CARD = 27,
		[Token(Token = "0x40083D7")]
		ItemSubType_ROOMCARD_WORKSHOP_FREE = 28,
		[Token(Token = "0x40083D8")]
		ItemSubType_FLASH_GEM = 29,
		[Token(Token = "0x40083D9")]
		ItemSubType_KEEP_SCORE_CARD = 30,
		[Token(Token = "0x40083DA")]
		ItemSubType_DOUBLE_BONUS_CARD = 31
	}

	[Token(Token = "0x20012C4")]
	public enum CollectionType
	{
		[Token(Token = "0x40083DC")]
		CollectionType_NONE,
		[Token(Token = "0x40083DD")]
		CollectionType_BANNER,
		[Token(Token = "0x40083DE")]
		CollectionType_HEADPIC,
		[Token(Token = "0x40083DF")]
		CollectionType_LOOTBOX,
		[Token(Token = "0x40083E0")]
		CollectionType_GAMEBAG,
		[Token(Token = "0x40083E1")]
		CollectionType_PARACHUTE,
		[Token(Token = "0x40083E2")]
		CollectionType_SKATE,
		[Token(Token = "0x40083E3")]
		CollectionType_WEAPON_SKIN,
		[Token(Token = "0x40083E4")]
		CollectionType_VIHICLE_SKIN,
		[Token(Token = "0x40083E5")]
		CollectionType_EMOTE,
		[Token(Token = "0x40083E6")]
		CollectionType_PIN,
		[Token(Token = "0x40083E7")]
		CollectionType_Flight,
		[Token(Token = "0x40083E8")]
		CollectionType_GROUPANIM,
		[Token(Token = "0x40083E9")]
		CollectionType_MUSIC,
		[Token(Token = "0x40083EA")]
		CollectionType_TRANSFORM_EMOTE
	}

	[Token(Token = "0x20012C5")]
	public enum ClothesType
	{
		[Token(Token = "0x40083EC")]
		ClothesType_NONE = 0,
		[Token(Token = "0x40083ED")]
		ClothesType_HEAD = 1,
		[Token(Token = "0x40083EE")]
		ClothesType_GLOVE = 2,
		[Token(Token = "0x40083EF")]
		ClothesType_COAT = 3,
		[Token(Token = "0x40083F0")]
		ClothesType_PANTS = 4,
		[Token(Token = "0x40083F1")]
		ClothesType_SHOE = 5,
		[Token(Token = "0x40083F2")]
		ClothesType_WAIST = 6,
		[Token(Token = "0x40083F3")]
		ClothesType_EYE = 7,
		[Token(Token = "0x40083F4")]
		ClothesType_FACE = 8,
		[Token(Token = "0x40083F5")]
		ClothesType_PARACHUTE = 9,
		[Token(Token = "0x40083F6")]
		ClothesType_PARACHUTE_BAG = 10,
		[Token(Token = "0x40083F7")]
		ClothesType_HAIR = 11,
		[Token(Token = "0x40083F8")]
		ClothesType_SET = 12,
		[Token(Token = "0x40083F9")]
		ClothesType_HEAD_ADDITIVE = 14
	}

	[Token(Token = "0x20012C6")]
	public enum GenderType
	{
		[Token(Token = "0x40083FB")]
		GenderType_NONE,
		[Token(Token = "0x40083FC")]
		GenderType_WOMAN,
		[Token(Token = "0x40083FD")]
		GenderType_MAN
	}

	[Token(Token = "0x20012C7")]
	public enum AwardType
	{
		[Token(Token = "0x40083FF")]
		AwardType_NONE,
		[Token(Token = "0x4008400")]
		AwardType_ITEM,
		[Token(Token = "0x4008401")]
		AwardType_COINS,
		[Token(Token = "0x4008402")]
		AwardType_GEMS,
		[Token(Token = "0x4008403")]
		AwardType_SKILL,
		[Token(Token = "0x4008404")]
		AwardType_EXP,
		[Token(Token = "0x4008405")]
		AwardType_ACTIVENESS,
		[Token(Token = "0x4008406")]
		AwardType_ACCELERATORS,
		[Token(Token = "0x4008407")]
		AwardType_LIMITED_EVENT_BADGE,
		[Token(Token = "0x4008408")]
		AwardType_CREATE_UGC_ROOM_TIMES
	}

	[Token(Token = "0x20012C8")]
	public enum CurrencyType
	{
		[Token(Token = "0x400840A")]
		CurrencyType_NONE,
		[Token(Token = "0x400840B")]
		CurrencyType_COINS,
		[Token(Token = "0x400840C")]
		CurrencyType_GEMS
	}

	[Token(Token = "0x20012C9")]
	public enum LimitedCardType
	{
		[Token(Token = "0x400840E")]
		LimitedCardType_NONE,
		[Token(Token = "0x400840F")]
		LimitedCardType_ITEM_TIME,
		[Token(Token = "0x4008410")]
		LimitedCardType_ITEM_NUM,
		[Token(Token = "0x4008411")]
		LimitedCardType_DISCOUNT
	}

	[Token(Token = "0x20012CA")]
	public enum LoadoutType
	{
		[Token(Token = "0x4008413")]
		LoadoutType_NONE,
		[Token(Token = "0x4008414")]
		LoadoutType_OLD,
		[Token(Token = "0x4008415")]
		LoadoutType_NEW
	}

	[Token(Token = "0x20012CB")]
	public enum BonusCardType
	{
		[Token(Token = "0x4008417")]
		BonusCardType_NONE,
		[Token(Token = "0x4008418")]
		BonusCardType_GOLD,
		[Token(Token = "0x4008419")]
		BonusCardType_EXP,
		[Token(Token = "0x400841A")]
		BonusCardType_EPDEBRIS,
		[Token(Token = "0x400841B")]
		BonusCardType_MENTORING_INTIMACY
	}

	[Token(Token = "0x20012CC")]
	public enum VoucherType
	{
		[Token(Token = "0x400841D")]
		VoucherType_NONE,
		[Token(Token = "0x400841E")]
		VoucherType_COINS,
		[Token(Token = "0x400841F")]
		VoucherType_GEMS
	}

	[Token(Token = "0x20012CD")]
	public enum TransReason
	{
		[Token(Token = "0x4008421")]
		TransReason_NONE,
		[Token(Token = "0x4008422")]
		TransReason_USECARD,
		[Token(Token = "0x4008423")]
		TransReason_PURCHASE,
		[Token(Token = "0x4008424")]
		TransReason_TREASUREBOX,
		[Token(Token = "0x4008425")]
		TransReason_LOADOUT,
		[Token(Token = "0x4008426")]
		TransReason_MATCH,
		[Token(Token = "0x4008427")]
		TransReason_CBT_GIFTS,
		[Token(Token = "0x4008428")]
		TransReason_ATTENDANCE,
		[Token(Token = "0x4008429")]
		TransReason_NEWPLAYERSIGNIN,
		[Token(Token = "0x400842A")]
		TransReason_ACTIVITY,
		[Token(Token = "0x400842B")]
		TransReason_LEVEL_REWARD,
		[Token(Token = "0x400842C")]
		TransReason_MAIL_ATTACHMENT,
		[Token(Token = "0x400842D")]
		TransReason_TOPUP,
		[Token(Token = "0x400842E")]
		TransReason_CLAN,
		[Token(Token = "0x400842F")]
		TransReason_ADMIN,
		[Token(Token = "0x4008430")]
		TransReason_BUNDLE,
		[Token(Token = "0x4008431")]
		TransReason_EXTERNAL_CALL,
		[Token(Token = "0x4008432")]
		TransReason_UNLOCK_PROFIILE,
		[Token(Token = "0x4008433")]
		TransReason_UNLOCK_PROFIILE_REWARD,
		[Token(Token = "0x4008434")]
		TransReason_RENAME,
		[Token(Token = "0x4008435")]
		TransReason_REISSUE,
		[Token(Token = "0x4008436")]
		TransReason_RANK_REWARD,
		[Token(Token = "0x4008437")]
		TransReason_SEASON_REWARD,
		[Token(Token = "0x4008438")]
		TransReason_EPPURCHASE,
		[Token(Token = "0x4008439")]
		TransReason_EPUNLOCK,
		[Token(Token = "0x400843A")]
		TransReason_EPPURCHASE_BADGE,
		[Token(Token = "0x400843B")]
		TransReason_EPCHALLENGE,
		[Token(Token = "0x400843C")]
		TransReason_LOTTERY,
		[Token(Token = "0x400843D")]
		TransReason_LOTTERY_EXTRA_REWARD,
		[Token(Token = "0x400843E")]
		TransReason_UNLOCK_SKILL_SLOT,
		[Token(Token = "0x400843F")]
		TransReason_SEND_GIFT,
		[Token(Token = "0x4008440")]
		TransReason_EPPURCHASE_BUNDLE,
		[Token(Token = "0x4008441")]
		TransReason_EXCHANGESTORE_PURCHASE,
		[Token(Token = "0x4008442")]
		TransReason_CARD,
		[Token(Token = "0x4008443")]
		TransReason_IAPPURCHASE,
		[Token(Token = "0x4008444")]
		TransReason_VETERAN_RETURN,
		[Token(Token = "0x4008445")]
		TransReason_ROOMCARD,
		[Token(Token = "0x4008446")]
		TransReason_CLAN_SIGN_IN,
		[Token(Token = "0x4008447")]
		TransReason_EPPREORDER,
		[Token(Token = "0x4008448")]
		TransReason_CLAN_RACE_UNLOCK,
		[Token(Token = "0x4008449")]
		TransReason_CLAN_RACE_ALL_MEMBER,
		[Token(Token = "0x400844A")]
		TransReason_GIFT_RANK_REWARD,
		[Token(Token = "0x400844B")]
		TransReason_LOTTERY_SPECIAL_EXCHANGE,
		[Token(Token = "0x400844C")]
		TransReason_CHAT_ITEMS,
		[Token(Token = "0x400844D")]
		TransReason_PET_RENAME,
		[Token(Token = "0x400844E")]
		TransReason_FEED_PET,
		[Token(Token = "0x400844F")]
		TransReason_PVE_CARD,
		[Token(Token = "0x4008450")]
		TransReason_DISCOUNTSTORE_PURCHASE,
		[Token(Token = "0x4008451")]
		TransReason_PET_LEVEL_UP,
		[Token(Token = "0x4008452")]
		TransReason_PAY_BUNDLE_WINDOW_PURCHASE,
		[Token(Token = "0x4008453")]
		TransReason_FESTIVAL_ATTENDANCE,
		[Token(Token = "0x4008454")]
		TransReason_AVATAR_LEVEL_CARD,
		[Token(Token = "0x4008455")]
		TransReason_FINISH_BINGO_ACTIVITY,
		[Token(Token = "0x4008456")]
		TransReason_BINGO_ACTIVITY_REWARDS,
		[Token(Token = "0x4008457")]
		TransReason_CLAN_LUCKY_BAG,
		[Token(Token = "0x4008458")]
		TransReason_EPSUBSCRIPTION,
		[Token(Token = "0x4008459")]
		TransReason_REBATESUBSCRIPTION,
		[Token(Token = "0x400845A")]
		TransReason_MANUAL_WEAPON,
		[Token(Token = "0x400845B")]
		TransReason_MANUAL_MAP,
		[Token(Token = "0x400845C")]
		TransReason_MYSTERY_BONUS,
		[Token(Token = "0x400845D")]
		TransReason_INSTALLMENT_PURCHASE,
		[Token(Token = "0x400845E")]
		TransReason_LOTTERY_DROPUP_BUFF,
		[Token(Token = "0x400845F")]
		TransReason_BOX_REWARD,
		[Token(Token = "0x4008460")]
		TransReason_FRESH_ACTIVITY,
		[Token(Token = "0x4008461")]
		TransReason_INSTALLMENT_MODIFY_ITEMS,
		[Token(Token = "0x4008462")]
		TransReason_LINKAGE_ACTIVITY,
		[Token(Token = "0x4008463")]
		TransReason_SWAP_ACCOUNTS,
		[Token(Token = "0x4008464")]
		TransReason_SUBSCRIPTION_BONUS,
		[Token(Token = "0x4008465")]
		TransReason_SUBSCRIPTION,
		[Token(Token = "0x4008466")]
		TransReason_EPTREASUREBOX,
		[Token(Token = "0x4008467")]
		TransReason_VETERAN_TASK,
		[Token(Token = "0x4008468")]
		TransReason_OFFER_PURCHASE,
		[Token(Token = "0x4008469")]
		TransReason_PROFILE_AWAKEN_TASK_REWARDS,
		[Token(Token = "0x400846A")]
		TransReason_NEW_PALAYER_LEVEL_UP_TASK,
		[Token(Token = "0x400846B")]
		TransReason_TRANSFORM_GENERAL_DEBRIS,
		[Token(Token = "0x400846C")]
		TransReason_CS_RANK_REWARD,
		[Token(Token = "0x400846D")]
		TransReason_EP_DEBRIS,
		[Token(Token = "0x400846E")]
		TransReason_CC_LIVE_REWARDS,
		[Token(Token = "0x400846F")]
		TransReason_CC_GUESS_REWARDS,
		[Token(Token = "0x4008470")]
		TransReason_CC_SUPPORT_REWARDS,
		[Token(Token = "0x4008471")]
		TransReason_CC_SUPPORT_PRIX,
		[Token(Token = "0x4008472")]
		TransReason_LIMITED_EVENT_STORE_PURCHASE,
		[Token(Token = "0x4008473")]
		TransReason_LIMITED_EVENT_CLAIM_NODE_REWARD,
		[Token(Token = "0x4008474")]
		TransReason_MYSTERY_STORE_PURCHASE,
		[Token(Token = "0x4008475")]
		TransReason_MYSTERY_STORE_UNLOCK_POOL,
		[Token(Token = "0x4008476")]
		TransReason_DISPATCH_QUEST_REWARD,
		[Token(Token = "0x4008477")]
		TransReason_LIMITED_EVENT_ACCELERATE_CASHPRINTER,
		[Token(Token = "0x4008478")]
		TransReason_PAYLEVELREWARD,
		[Token(Token = "0x4008479")]
		TransReason_LIMITED_EVENT_MONEY_HEIST_HELP,
		[Token(Token = "0x400847A")]
		TransReason_LIMITED_EVENT_MONEY_HEIST_REWARDS,
		[Token(Token = "0x400847B")]
		TransReason_PETREISSUE,
		[Token(Token = "0x400847C")]
		TransReason_ROLE_DEBRIS_PURCHASE,
		[Token(Token = "0x400847D")]
		TransReason_UPGRADE_WEAPON_SKIN,
		[Token(Token = "0x400847E")]
		TransReason_LIMITED_EVENT_BOOYAH_DAY_SIGN,
		[Token(Token = "0x400847F")]
		TransReason_MINI_GAME,
		[Token(Token = "0x4008480")]
		TransReason_LIMITED_EVENT_BOOYAH_DAY_PROCESS,
		[Token(Token = "0x4008481")]
		TransReason_LIMITED_EVENT_BERMUDA_PROGRESS,
		[Token(Token = "0x4008482")]
		TransReason_EP_WEEKLY_PROCESS_REWARDS,
		[Token(Token = "0x4008483")]
		TransReason_COMPLETION_GACHA_BACKPACK,
		[Token(Token = "0x4008484")]
		TransReason_LIMITED_EVENT_MVP_PROCESS,
		[Token(Token = "0x4008485")]
		TransReason_LIMITED_EVENT_GOLIATH_REWARD,
		[Token(Token = "0x4008486")]
		TransReason_INTIMACY_RANK_AWARD,
		[Token(Token = "0x4008487")]
		TransReason_INTIMACY_CREATE_SPECIAL_RELATION,
		[Token(Token = "0x4008488")]
		TransReason_LIMITED_EVENT_SUPERFIGHTER_CONSUME,
		[Token(Token = "0x4008489")]
		TransReason_LIMITED_EVENT_SUPERFIGHTER_REWARD,
		[Token(Token = "0x400848A")]
		TransReason_LIMITED_EVENT_SUPERCAR,
		[Token(Token = "0x400848B")]
		TransReason_LIMITED_EVENT_FFWS,
		[Token(Token = "0x400848C")]
		TransReason_OPTIONAL_BUNDLE,
		[Token(Token = "0x400848D")]
		TransReason_AVATAR_AWAKEN_COMIC,
		[Token(Token = "0x400848E")]
		TransReason_GET_AWAKEN_AVATAR,
		[Token(Token = "0x400848F")]
		TransReason_REFRESH_AWAKEN_TASK,
		[Token(Token = "0x4008490")]
		TransReason_LIMITED_EVENT_SUTORITO_CONSUME,
		[Token(Token = "0x4008491")]
		TransReason_LIMITED_EVENT_SUTORITO_REWARD,
		[Token(Token = "0x4008492")]
		TransReason_LIMITED_EVENT_FOURSYMBOLS_ROAD,
		[Token(Token = "0x4008493")]
		TransReason_CUP_CLAIM_REWARDS,
		[Token(Token = "0x4008494")]
		TransReason_LUCKY_WHEEL_REFRESH,
		[Token(Token = "0x4008495")]
		TransReason_LUCKY_WHEEL_PURCHASE,
		[Token(Token = "0x4008496")]
		TransReason_CUP_USE_TICKET,
		[Token(Token = "0x4008497")]
		TransReason_LIMITED_EVENT_FOURSYMBOLS_SIGNIN,
		[Token(Token = "0x4008498")]
		TransReason_LIMITED_EVENT_FOURSYMBOLS_CLAIM_ACCUMULATIVE_AWARD,
		[Token(Token = "0x4008499")]
		TransReason_LIMITED_EVENT_MUSICFEST_USE_TOKEN,
		[Token(Token = "0x400849A")]
		TransReason_LIMITED_EVENT_MUSICFEST_SEND_TOKEN,
		[Token(Token = "0x400849B")]
		TransReason_LIMITED_EVENT_MUSICFEST_RECEIVE_TOKEN,
		[Token(Token = "0x400849C")]
		TransReason_LIMITED_EVENT_MUSICFEST_PUZZLE_PROGRESS_REWARD,
		[Token(Token = "0x400849D")]
		TransReason_LIMITED_EVENT_MUSICFEST_PUZZLE_RANGE_REWARD,
		[Token(Token = "0x400849E")]
		TransReason_LIMITED_EVENT_MUSICFEST_CARD_REWARD,
		[Token(Token = "0x400849F")]
		TransReason_LIMITED_EVENT_MOCO_MONTH_GAME,
		[Token(Token = "0x40084A0")]
		TransReason_WORKSHOP_UNLOCK_SLOT,
		[Token(Token = "0x40084A1")]
		TransReason_CLAN_WAR_TEAM_REWARD,
		[Token(Token = "0x40084A2")]
		TransReason_CLAN_WAR_PERSONAL_REWARD,
		[Token(Token = "0x40084A3")]
		TransReason_VIPCARD_INIT_REWARD,
		[Token(Token = "0x40084A4")]
		TransReason_VIPCARD_DAILY_REWARD,
		[Token(Token = "0x40084A5")]
		TransReason_VIPCARD_STORE_PURCHASE,
		[Token(Token = "0x40084A6")]
		TransReason_LIMITED_EVENT_BOOYAHDAY21_PROCESS,
		[Token(Token = "0x40084A7")]
		TransReason_CUSTOM_EVENT_PROCESS,
		[Token(Token = "0x40084A8")]
		TransReason_CLAN_BADGE,
		[Token(Token = "0x40084A9")]
		TransReason_VIPCARD_RETURN_GEMS,
		[Token(Token = "0x40084AA")]
		TransReason_LIMITED_EVENT_FFWS03,
		[Token(Token = "0x40084AB")]
		TransReason_VIPCARD_RESIGN_DAILY_REWARD,
		[Token(Token = "0x40084AC")]
		TransReason_POOL_LEADERBOARD_CLAIM_AWARDS,
		[Token(Token = "0x40084AD")]
		TransReason_LIMITED_CHEST,
		[Token(Token = "0x40084AE")]
		TransReason_LIMITED_EVENT_JUMPSUIT,
		[Token(Token = "0x40084AF")]
		TransReason_LIMITED_EVENT_WINTERFEST21B,
		[Token(Token = "0x40084B0")]
		TransReason_CHUMMY_CLAIM_INTIMACY_AWARDS,
		[Token(Token = "0x40084B1")]
		TransReason_PERIODIC_RANK_REWARD,
		[Token(Token = "0x40084B2")]
		TransReason_UNLOCK_FITTING_SLOT,
		[Token(Token = "0x40084B3")]
		TransReason_LIMITED_EVENT_HURRICANEB,
		[Token(Token = "0x40084B4")]
		TransReason_LIMITED_EVENT_HOODEDKILLERB,
		[Token(Token = "0x40084B5")]
		TransReason_LIMITED_EVENT_EP,
		[Token(Token = "0x40084B6")]
		TransReason_QUICK_PURCHASE,
		[Token(Token = "0x40084B7")]
		TransReason_LIMITED_EVENT_BOYBANDB,
		[Token(Token = "0x40084B8")]
		TransReason_CUSTOM_EVENT_STORE,
		[Token(Token = "0x40084B9")]
		TransReason_CREDIT_SCORE_REWARD,
		[Token(Token = "0x40084BA")]
		TransReason_UPDATE_EXCHANGE_LINK,
		[Token(Token = "0x40084BB")]
		TransReason_CLAIM_LINK_PROFILE,
		[Token(Token = "0x40084BC")]
		TransReason_LIMITED_EVENT_RAMPAGE4B,
		[Token(Token = "0x40084BD")]
		TransReason_HYPER_BOOK_UNLOCK,
		[Token(Token = "0x40084BE")]
		TransReason_HYPER_BOOK_SPIN,
		[Token(Token = "0x40084BF")]
		TransReason_NEWBIE_GUIDE,
		[Token(Token = "0x40084C0")]
		TransReason_RANK_RESET_REWARD,
		[Token(Token = "0x40084C1")]
		TransReason_CS_RANK_RESET_REWARD,
		[Token(Token = "0x40084C2")]
		TransReason_PERIODIC_RANK_RESET_REWARD,
		[Token(Token = "0x40084C3")]
		TransReason_RANKINGTASK,
		[Token(Token = "0x40084C4")]
		TransReason_WEAPON_SKIN_UPGRADE_TOKEN_EXCHANGE,
		[Token(Token = "0x40084C5")]
		TransReason_ROOM_WORKSHOP_LOADING_TIMEOUT,
		[Token(Token = "0x40084C6")]
		TransReason_EP_DAILY_PROCESS_REWARDS,
		[Token(Token = "0x40084C7")]
		TransReason_FLASHSTORE_PURCHASE,
		[Token(Token = "0x40084C8")]
		TransReason_AUTO_EXCHANGE,
		[Token(Token = "0x40084C9")]
		TransReason_WORKSHOP_LEVEL_REWARD,
		[Token(Token = "0x40084CA")]
		TransReason_LIMITED_EVENT_DIGITALUNIVERSEB_STARCRAFT,
		[Token(Token = "0x40084CB")]
		TransReason_LIMITED_EVENT_DIGITALUNIVERSEB
	}

	[Token(Token = "0x20012CE")]
	public enum DeleteReason
	{
		[Token(Token = "0x40084CD")]
		DeleteReason_NONE,
		[Token(Token = "0x40084CE")]
		DeleteReason_ZERO_CNT,
		[Token(Token = "0x40084CF")]
		DeleteReason_OUT_EXPIRE,
		[Token(Token = "0x40084D0")]
		DeleteReason_NO_ITEM_ID
	}

	[Token(Token = "0x20012CF")]
	public enum ClanTransSubReason
	{
		[Token(Token = "0x40084D2")]
		ClanTransSubReason_NONE,
		[Token(Token = "0x40084D3")]
		ClanTransSubReason_CREATE,
		[Token(Token = "0x40084D4")]
		ClanTransSubReason_EXPAND,
		[Token(Token = "0x40084D5")]
		ClanTransSubReason_CLAN_RENAME
	}

	[Token(Token = "0x20012D0")]
	public enum ItemStatus
	{
		[Token(Token = "0x40084D7")]
		ItemStatus_NONE,
		[Token(Token = "0x40084D8")]
		ItemStatus_PERMANENT,
		[Token(Token = "0x40084D9")]
		ItemStatus_INEXPIRE,
		[Token(Token = "0x40084DA")]
		ItemStatus_OUTEXPIRE
	}

	[Token(Token = "0x20012D1")]
	public enum InstallmentStatus
	{
		[Token(Token = "0x40084DC")]
		InstallmentStatus_NONE,
		[Token(Token = "0x40084DD")]
		InstallmentStatus_INSTALLMENT,
		[Token(Token = "0x40084DE")]
		InstallmentStatus_LOCK
	}

	[Token(Token = "0x20012D2")]
	public enum InstallmentType
	{
		[Token(Token = "0x40084E0")]
		InstallmentType_NONE,
		[Token(Token = "0x40084E1")]
		InstallmentType_WEEK,
		[Token(Token = "0x40084E2")]
		InstallmentType_MONTH,
		[Token(Token = "0x40084E3")]
		InstallmentType_QUARTER
	}

	[Token(Token = "0x20012D3")]
	public enum StoreTag
	{
		[Token(Token = "0x40084E5")]
		StoreTag_NONE,
		[Token(Token = "0x40084E6")]
		StoreTag_DISCOUNT,
		[Token(Token = "0x40084E7")]
		StoreTag_HOT,
		[Token(Token = "0x40084E8")]
		StoreTag_NEW,
		[Token(Token = "0x40084E9")]
		StoreTag_LIMITEDTIME,
		[Token(Token = "0x40084EA")]
		StoreTag_PURCHASELIMITED,
		[Token(Token = "0x40084EB")]
		StoreTag_EARLY_ACCESS,
		[Token(Token = "0x40084EC")]
		StoreTag_DISPLAY_LEFTTIME
	}

	[Token(Token = "0x20012D4")]
	public enum TopupTxnType
	{
		[Token(Token = "0x40084EE")]
		TopupTxnType_NONE,
		[Token(Token = "0x40084EF")]
		TopupTxnType_INGAME,
		[Token(Token = "0x40084F0")]
		TopupTxnType_MSHOP,
		[Token(Token = "0x40084F1")]
		TopupTxnType_ADMIN,
		[Token(Token = "0x40084F2")]
		TopupTxnType_PROMO,
		[Token(Token = "0x40084F3")]
		TopupTxnType_REBATE
	}

	[Token(Token = "0x20012D5")]
	public enum RareType
	{
		[Token(Token = "0x40084F5")]
		RareType_NONE,
		[Token(Token = "0x40084F6")]
		RareType_White,
		[Token(Token = "0x40084F7")]
		RareType_Green,
		[Token(Token = "0x40084F8")]
		RareType_Blue,
		[Token(Token = "0x40084F9")]
		RareType_Purple,
		[Token(Token = "0x40084FA")]
		RareType_Orange,
		[Token(Token = "0x40084FB")]
		RareType_Card,
		[Token(Token = "0x40084FC")]
		RareType_Red,
		[Token(Token = "0x40084FD")]
		RareType_Purple_Plus,
		[Token(Token = "0x40084FE")]
		RareType_Oranage_Plus
	}

	[Token(Token = "0x20012D6")]
	public enum EPCardErrorType
	{
		[Token(Token = "0x4008500")]
		EPCardErrorType_NONE,
		[Token(Token = "0x4008501")]
		EPCardErrorType_DISABLE,
		[Token(Token = "0x4008502")]
		EPCardErrorType_NO_RETURN,
		[Token(Token = "0x4008503")]
		EPCardErrorType_ACTIVE
	}

	[Token(Token = "0x20012D7")]
	public enum StorePromotionType
	{
		[Token(Token = "0x4008505")]
		StorePromotionType_NORMAL,
		[Token(Token = "0x4008506")]
		StorePromotionType_DISCOUNT
	}

	[Token(Token = "0x20012D8")]
	public enum ItemSourceType
	{
		[Token(Token = "0x4008508")]
		ItemSourceType_DEFAULT = 0,
		[Token(Token = "0x4008509")]
		ItemSourceType_BUNDLE = 1,
		[Token(Token = "0x400850A")]
		ItemSourceType_GIFTMAIL = 2,
		[Token(Token = "0x400850B")]
		ItemSourceType_WEBPAGE = 3,
		[Token(Token = "0x400850C")]
		ItemSourceType_STORE = 4,
		[Token(Token = "0x400850D")]
		ItemSourceType_ACTIVITY = 5,
		[Token(Token = "0x400850E")]
		ItemSourceType_LOTTERY = 6,
		[Token(Token = "0x400850F")]
		ItemSourceType_BACKPACK = 7,
		[Token(Token = "0x4008510")]
		ItemSourceType_TREASUREBOX = 8,
		[Token(Token = "0x4008511")]
		ItemSourceType_FRESH_ACTIVITY = 9,
		[Token(Token = "0x4008512")]
		ItemSourceType_LINKAGE_ACTIVITY = 10,
		[Token(Token = "0x4008513")]
		ItemSourceType_PROFILE = 11,
		[Token(Token = "0x4008514")]
		ItemSourceType_COMPETITION = 12,
		[Token(Token = "0x4008515")]
		ItemSourceType_MYSTERYSHOP = 13,
		[Token(Token = "0x4008516")]
		ItemSourceType_LIMITED_EVENT = 14,
		[Token(Token = "0x4008517")]
		ItemSourceType_INTIMACY = 15,
		[Token(Token = "0x4008518")]
		ItemSourceType_OPTIONAL_BUNDLE = 17,
		[Token(Token = "0x4008519")]
		ItemSourceType_LUCKYWHEEL = 18,
		[Token(Token = "0x400851A")]
		ItemSourceType_VIPCARD = 19,
		[Token(Token = "0x400851B")]
		ItemSourceType_POOL_LEADERBOARD = 20,
		[Token(Token = "0x400851C")]
		ItemSourceType_LIMITED_CHEST = 21,
		[Token(Token = "0x400851D")]
		ItemSourceType_CREDIT_SCORE = 22
	}

	[Token(Token = "0x20012D9")]
	public enum MaterialItemType
	{
		[Token(Token = "0x400851F")]
		MaterialItemType_NONE,
		[Token(Token = "0x4008520")]
		MaterialItemType_ITEMS,
		[Token(Token = "0x4008521")]
		MaterialItemType_COINS,
		[Token(Token = "0x4008522")]
		MaterialItemType_GEMS
	}

	[Token(Token = "0x20012DA")]
	public enum TopupEvent
	{
		[Token(Token = "0x4008524")]
		TopupEvent_NONE,
		[Token(Token = "0x4008525")]
		TopupEvent_MYSTERY_BONUS,
		[Token(Token = "0x4008526")]
		TopupEvent_DIAMOND_SPEND
	}

	[Token(Token = "0x20012DB")]
	public enum MysterySwitchActivateReason
	{
		[Token(Token = "0x4008528")]
		MysterySwitchActivateReason_NONE,
		[Token(Token = "0x4008529")]
		MysterySwitchActivateReason_COSTGEMS,
		[Token(Token = "0x400852A")]
		MysterySwitchActivateReason_PURCHASEITEM
	}

	[Token(Token = "0x20012DC")]
	public enum LegendClothCdtType
	{
		[Token(Token = "0x400852C")]
		LegendClothCdtType_NONE,
		[Token(Token = "0x400852D")]
		LegendClothCdtType_Rank
	}

	[Token(Token = "0x20012DD")]
	public enum FittingSlotCdtType
	{
		[Token(Token = "0x400852F")]
		FittingSlotCdtType_NONE,
		[Token(Token = "0x4008530")]
		FittingSlotCdtType_DEFAULT,
		[Token(Token = "0x4008531")]
		FittingSlotCdtType_LEVEL,
		[Token(Token = "0x4008532")]
		FittingSlotCdtType_COINS,
		[Token(Token = "0x4008533")]
		FittingSlotCdtType_GEMS
	}

	[Token(Token = "0x20012DE")]
	public enum AvatarType
	{
		[Token(Token = "0x4008535")]
		AvatarType_NONE,
		[Token(Token = "0x4008536")]
		AvatarType_DEFAULT,
		[Token(Token = "0x4008537")]
		AvatarType_NORMAL,
		[Token(Token = "0x4008538")]
		AvatarType_UNSKILLED,
		[Token(Token = "0x4008539")]
		AvatarType_INVISIBLE
	}

	[Token(Token = "0x20012DF")]
	public enum SlotChooseType
	{
		[Token(Token = "0x400853B")]
		SlotChooseType_NONE,
		[Token(Token = "0x400853C")]
		SlotChooseType_SINGLE,
		[Token(Token = "0x400853D")]
		SlotChooseType_RANDOM
	}

	[Token(Token = "0x6007A3E")]
	[Address(RVA = "0x309F300", Offset = "0x309F300", VA = "0x309F300")]
	public EInventory()
	{
	}
}
