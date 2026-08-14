using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200132A")]
public class EMail
{
	[Token(Token = "0x200132B")]
	public enum Source
	{
		[Token(Token = "0x4008775")]
		Source_GAME,
		[Token(Token = "0x4008776")]
		Source_ADMIN
	}

	[Token(Token = "0x200132C")]
	public enum ActionType
	{
		[Token(Token = "0x4008778")]
		ActionType_ATTACHMENT,
		[Token(Token = "0x4008779")]
		ActionType_NOTICE,
		[Token(Token = "0x400877A")]
		ActionType_CLAN_INVITE
	}

	[Token(Token = "0x200132D")]
	public enum Type
	{
		[Token(Token = "0x400877C")]
		Type_NONE = 0,
		[Token(Token = "0x400877D")]
		Type_CLAN_INVITE = 1,
		[Token(Token = "0x400877E")]
		Type_CLAN_DISMISS = 2,
		[Token(Token = "0x400877F")]
		Type_CLAN_KICKOUT = 3,
		[Token(Token = "0x4008780")]
		Type_CLAN_REASSIGN_CAPTAIN = 4,
		[Token(Token = "0x4008781")]
		Type_RANKING_SEASON_REWARDS = 5,
		[Token(Token = "0x4008782")]
		Type_RANKING_RANK_LEVEL_REWARDS = 6,
		[Token(Token = "0x4008783")]
		Type_EP_UNLOCK_REWARD = 7,
		[Token(Token = "0x4008784")]
		Type_EP_CHALLENGE_REWARD = 8,
		[Token(Token = "0x4008785")]
		Type_STORE_SEND_GIFT = 9,
		[Token(Token = "0x4008786")]
		Type_GLOBAL_DROPS = 10,
		[Token(Token = "0x4008787")]
		Type_CLAN_RACE_AWARD = 11,
		[Token(Token = "0x4008788")]
		Type_SET_STREAMER = 14,
		[Token(Token = "0x4008789")]
		Type_DEL_STREAMER = 15,
		[Token(Token = "0x400878A")]
		Type_INSTANT_GAME_REWARD = 16,
		[Token(Token = "0x400878B")]
		Type_SUBSCRIPTION_EP = 17,
		[Token(Token = "0x400878C")]
		Type_CHAMPIONSHIP_TEAM_DISMISS = 18,
		[Token(Token = "0x400878D")]
		Type_CHAMPIONSHIP_TEAM_KICKOUT = 19,
		[Token(Token = "0x400878E")]
		Type_CHAMPIONSHIP_TRIAL_REWARDS = 20,
		[Token(Token = "0x400878F")]
		Type_GOP_PURCHASE = 21,
		[Token(Token = "0x4008790")]
		Type_NEWBIE_RETURN = 22,
		[Token(Token = "0x4008791")]
		Type_CLAN_REGION_CHANGE = 23,
		[Token(Token = "0x4008792")]
		Type_VETERAN_RETURN = 24,
		[Token(Token = "0x4008793")]
		Type_RANKING_SEASON_TOP_REWARDS = 25,
		[Token(Token = "0x4008794")]
		Type_NEW_PALYER_UNCLAIM_REWARDS = 26,
		[Token(Token = "0x4008795")]
		Type_FRESH_UNCLAIM_REWARDS = 27,
		[Token(Token = "0x4008796")]
		Type_EP_DAILY_QUEST_UNCLAIM_REWARDS = 28,
		[Token(Token = "0x4008797")]
		Type_CS_RANKING_RANK_LEVEL_REWARDS = 29,
		[Token(Token = "0x4008798")]
		Type_CS_RANKING_SEASON_REWARDS = 30,
		[Token(Token = "0x4008799")]
		Type_CS_RANKING_HANGUP_WARN = 31,
		[Token(Token = "0x400879A")]
		Type_CS_RANKING_HANGUP_BAN = 32,
		[Token(Token = "0x400879B")]
		Type_CLAN_DEPUTY_CAPTAIN_NOTIFY = 33,
		[Token(Token = "0x400879C")]
		Type_LIMITEDEVENT_LEADERBOARD_REWARDS = 34,
		[Token(Token = "0x400879D")]
		Type_INTIMACY_AWARDS = 35,
		[Token(Token = "0x400879E")]
		Type_SKINHACK = 36,
		[Token(Token = "0x400879F")]
		Type_CS_RANKING_SEASON_TOP_REWARDS = 37,
		[Token(Token = "0x40087A0")]
		Type_CLAN_WAR_ACCOUNT_REWARDS = 38,
		[Token(Token = "0x40087A1")]
		Type_VIPCARD_WEEKLY_REWARD = 39,
		[Token(Token = "0x40087A2")]
		Type_VIPCARD_MONTHLY_REWARD = 40,
		[Token(Token = "0x40087A3")]
		Type_VIPCARD_MONTHLY_WEEKLY_REWARD = 41,
		[Token(Token = "0x40087A4")]
		Type_VIPCARD_SVIP_REWARD = 42,
		[Token(Token = "0x40087A5")]
		Type_VIPCARD_SVIP_WEEKLY_REWARD = 43,
		[Token(Token = "0x40087A6")]
		Type_VIPCARD_SVIP_MONTHLY_REWARD = 44,
		[Token(Token = "0x40087A7")]
		Type_VIPCARD_SVIP_MONTHLY_WEEKLY_REWARD = 45,
		[Token(Token = "0x40087A8")]
		Type_MSHOP_RECHARGE_NOTIFY = 46,
		[Token(Token = "0x40087A9")]
		Type_PERIODIC_RANKING_RANK_LEVEL_REWARDS = 47,
		[Token(Token = "0x40087AA")]
		Type_PERIODIC_RANKING_SEASON_REWARDS = 48,
		[Token(Token = "0x40087AB")]
		Type_CHUMMY_INTIMACY_REWARDS = 49,
		[Token(Token = "0x40087AC")]
		Type_LIMITED_EVENT_SETTLE_REWARDS = 50,
		[Token(Token = "0x40087AD")]
		Type_GOOGLE_PLAY_POINT = 51,
		[Token(Token = "0x40087AE")]
		Type_VETERAN_REWARDS = 52,
		[Token(Token = "0x40087AF")]
		Type_ANTIHACK_MATCH_BANNED1 = 53,
		[Token(Token = "0x40087B0")]
		Type_ANTIHACK_MATCH_BANNED2 = 54,
		[Token(Token = "0x40087B1")]
		Type_ANTIHACK_MATCH_BANNED3 = 55,
		[Token(Token = "0x40087B2")]
		Type_WORKSHOP_CODE_BANNED = 57,
		[Token(Token = "0x40087B3")]
		Type_EP_DAILY_PROCESS_UNCLAIM_REWARDS = 58
	}

	[Token(Token = "0x200132E")]
	public enum Status
	{
		[Token(Token = "0x40087B5")]
		Status_INIT,
		[Token(Token = "0x40087B6")]
		Status_PROCESSED,
		[Token(Token = "0x40087B7")]
		Status_DELETED
	}

	[Token(Token = "0x200132F")]
	public enum ReportMailType
	{
		[Token(Token = "0x40087B9")]
		ReportMailType_NONE,
		[Token(Token = "0x40087BA")]
		ReportMailType_REPORTER_FEEDBACK,
		[Token(Token = "0x40087BB")]
		ReportMailType_OFFENDER_PUNISH
	}

	[Token(Token = "0x6007A52")]
	[Address(RVA = "0x309F338", Offset = "0x309F338", VA = "0x309F338")]
	public EMail()
	{
	}
}
