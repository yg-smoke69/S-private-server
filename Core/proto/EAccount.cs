using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20012E0")]
public class EAccount
{
	[Token(Token = "0x20012E1")]
	public enum PlatformType
	{
		[Token(Token = "0x400853F")]
		PlatformType_VISITOR = 0,
		[Token(Token = "0x4008540")]
		PlatformType_GAS = 1,
		[Token(Token = "0x4008541")]
		PlatformType_BEETALK = 2,
		[Token(Token = "0x4008542")]
		PlatformType_GAFACEBOOK = 3,
		[Token(Token = "0x4008543")]
		PlatformType_GAGUEST = 4,
		[Token(Token = "0x4008544")]
		PlatformType_VK = 5,
		[Token(Token = "0x4008545")]
		PlatformType_FACEBOOK = 6,
		[Token(Token = "0x4008546")]
		PlatformType_HUAWEI = 7,
		[Token(Token = "0x4008547")]
		PlatformType_GOOGLE = 8,
		[Token(Token = "0x4008548")]
		PlatformType_WECHAT = 9,
		[Token(Token = "0x4008549")]
		PlatformType_APPLE = 10,
		[Token(Token = "0x400854A")]
		PlatformType_TWITTER = 11,
		[Token(Token = "0x400854B")]
		PlatformType_DELETE = 100,
		[Token(Token = "0x400854C")]
		PlatformType_CHANGE_ACCOUNT = 101
	}

	[Token(Token = "0x20012E2")]
	public enum BlacklistOpType
	{
		[Token(Token = "0x400854E")]
		BlacklistOpType_NONE,
		[Token(Token = "0x400854F")]
		BlacklistOpType_BAN_ACCOUNT,
		[Token(Token = "0x4008550")]
		BlacklistOpType_BAN_DEVICE,
		[Token(Token = "0x4008551")]
		BlacklistOpType_UNBAN_ACCOUNT,
		[Token(Token = "0x4008552")]
		BlacklistOpType_UNBAN_DEVICE
	}

	[Token(Token = "0x20012E3")]
	public enum Role
	{
		[Token(Token = "0x4008554")]
		Role_NONE = 0,
		[Token(Token = "0x4008555")]
		Role_GM = 1,
		[Token(Token = "0x4008556")]
		Role_CONTESTANT = 2,
		[Token(Token = "0x4008557")]
		Role_STREAMER = 4,
		[Token(Token = "0x4008558")]
		Role_REPLAY = 8,
		[Token(Token = "0x4008559")]
		Role_ROOMMASTER = 0x10,
		[Token(Token = "0x400855A")]
		Role_ROOMPARTNER = 0x20,
		[Token(Token = "0x400855B")]
		Role_PERSONAGE = 0x40,
		[Token(Token = "0x400855C")]
		Role_COMPANY = 0x80,
		[Token(Token = "0x400855D")]
		Role_PREPARATION = 0x100,
		[Token(Token = "0x400855E")]
		Role_UGC = 0x200
	}

	[Token(Token = "0x20012E4")]
	public enum BanReason
	{
		[Token(Token = "0x4008560")]
		BanReason_UNKNOWN,
		[Token(Token = "0x4008561")]
		BanReason_IN_GAME_AUTO,
		[Token(Token = "0x4008562")]
		BanReason_REFUND,
		[Token(Token = "0x4008563")]
		BanReason_OTHERS,
		[Token(Token = "0x4008564")]
		BanReason_SKINMOD
	}

	[Token(Token = "0x20012E5")]
	public enum NewsType
	{
		[Token(Token = "0x4008566")]
		NewsType_NONE,
		[Token(Token = "0x4008567")]
		NewsType_RANK,
		[Token(Token = "0x4008568")]
		NewsType_LOTTERY,
		[Token(Token = "0x4008569")]
		NewsType_PURCHASE,
		[Token(Token = "0x400856A")]
		NewsType_TREASUREBOX,
		[Token(Token = "0x400856B")]
		NewsType_ELITEPASS,
		[Token(Token = "0x400856C")]
		NewsType_EXCHANGESTORE,
		[Token(Token = "0x400856D")]
		NewsType_BUNDLE,
		[Token(Token = "0x400856E")]
		NewsType_LOTTERYSPECIALEXCHANGE,
		[Token(Token = "0x400856F")]
		NewsType_OTHERS
	}

	[Token(Token = "0x20012E6")]
	public enum WarmGameType
	{
		[Token(Token = "0x4008571")]
		WarmGameType_NONE,
		[Token(Token = "0x4008572")]
		WarmGameType_FIRSTRECHARGE,
		[Token(Token = "0x4008573")]
		WarmGameType_BOTPOINT
	}

	[Token(Token = "0x20012E7")]
	public enum DownloadType
	{
		[Token(Token = "0x4008575")]
		DownloadType_NONE,
		[Token(Token = "0x4008576")]
		DownloadType_INSTANTGAME,
		[Token(Token = "0x4008577")]
		DownloadType_IOS,
		[Token(Token = "0x4008578")]
		DownloadType_HUAWEI,
		[Token(Token = "0x4008579")]
		DownloadType_XIAOMI,
		[Token(Token = "0x400857A")]
		DownloadType_SAMSUNG
	}

	[Token(Token = "0x20012E8")]
	public enum LoginType
	{
		[Token(Token = "0x400857C")]
		LoginType_NORMAL,
		[Token(Token = "0x400857D")]
		LoginType_DEBUG_ACCOUNT_ID,
		[Token(Token = "0x400857E")]
		LoginType_DEBUG_NICKNAME
	}

	[Token(Token = "0x20012E9")]
	public enum CBSwitchStatus
	{
		[Token(Token = "0x4008580")]
		CBSwitchStatus_NONE,
		[Token(Token = "0x4008581")]
		CBSwitchStatus_CHECK_KEY,
		[Token(Token = "0x4008582")]
		CBSwitchStatus_DONT_CHECK_KEY,
		[Token(Token = "0x4008583")]
		CBSwitchStatus_DISABLE_MAX_LOGIN
	}

	[Token(Token = "0x20012EA")]
	public enum TrialSwitchStatus
	{
		[Token(Token = "0x4008585")]
		TrialSwitchStatus_NONE,
		[Token(Token = "0x4008586")]
		TrialSwitchStatus_CHECK_KEY,
		[Token(Token = "0x4008587")]
		TrialSwitchStatus_DONT_CHECK_KEY
	}

	[Token(Token = "0x20012EB")]
	public enum NewbieChoice
	{
		[Token(Token = "0x4008589")]
		NewbieChoice_NONE = 0,
		[Token(Token = "0x400858A")]
		NewbieChoice_NEW_PLAYER = 1,
		[Token(Token = "0x400858B")]
		NewbieChoice_FPS_PLAYER = 2,
		[Token(Token = "0x400858C")]
		NewbieChoice_VETERAN = 3,
		[Token(Token = "0x400858D")]
		NewbieChoice_NEEDMOREINFO = 99
	}

	[Token(Token = "0x20012EC")]
	public enum Prefers
	{
		[Token(Token = "0x400858F")]
		Prefers_NONE = 0,
		[Token(Token = "0x4008590")]
		Prefers_DISPLAY_PREGAME_INFO = 1,
		[Token(Token = "0x4008591")]
		Prefers_SHOW_KD = 2,
		[Token(Token = "0x4008592")]
		Prefers_HIDE_MY_LOBBY = 4
	}

	[Token(Token = "0x20012ED")]
	public enum ChoicesType
	{
		[Token(Token = "0x4008594")]
		ChoicesType_NONE,
		[Token(Token = "0x4008595")]
		ChoicesType_PREGAMESHOW_SHOW_CS_STATS
	}

	[Token(Token = "0x20012EE")]
	public enum Choices
	{
		[Token(Token = "0x4008597")]
		Choices_NONE,
		[Token(Token = "0x4008598")]
		Choices_CS_SHOW_STATS_WINS,
		[Token(Token = "0x4008599")]
		Choices_CS_SHOW_STATS_MVP_COUNT,
		[Token(Token = "0x400859A")]
		Choices_CS_SHOW_STATS_KILLS,
		[Token(Token = "0x400859B")]
		Choices_CS_SHOW_STATS_AVG_DAMAGE,
		[Token(Token = "0x400859C")]
		Choices_CS_SHOW_STATS_KDA,
		[Token(Token = "0x400859D")]
		Choices_CS_SHOW_STATS_TRI_KILLS,
		[Token(Token = "0x400859E")]
		Choices_CS_SHOW_STATS_FOUR_KILLS,
		[Token(Token = "0x400859F")]
		Choices_CS_SHOW_STATS_HEAD_SHOT
	}

	[Token(Token = "0x20012EF")]
	public enum MatchMakingSwitchType
	{
		[Token(Token = "0x40085A1")]
		MatchMakingSwitchType_NONE,
		[Token(Token = "0x40085A2")]
		MatchMakingSwitchType_LOADING,
		[Token(Token = "0x40085A3")]
		MatchMakingSwitchType_MAX_LOBBY
	}

	[Token(Token = "0x20012F0")]
	public enum BanType
	{
		[Token(Token = "0x40085A5")]
		BanType_NONE,
		[Token(Token = "0x40085A6")]
		BanType_RANKING,
		[Token(Token = "0x40085A7")]
		BanType_GROUP
	}

	[Token(Token = "0x20012F1")]
	public enum PlayerProficiencyType
	{
		[Token(Token = "0x40085A9")]
		PlayerProficiencyType_NONE,
		[Token(Token = "0x40085AA")]
		PlayerProficiencyType_NEWPLAYER,
		[Token(Token = "0x40085AB")]
		PlayerProficiencyType_VETERAN
	}

	[Token(Token = "0x6007A3F")]
	[Address(RVA = "0x309F238", Offset = "0x309F238", VA = "0x309F238")]
	public EAccount()
	{
	}
}
