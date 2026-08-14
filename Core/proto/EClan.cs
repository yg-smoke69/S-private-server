using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013A6")]
public class EClan
{
	[Token(Token = "0x20013A7")]
	public enum MemberType
	{
		[Token(Token = "0x4008A5F")]
		MemberType_NONE,
		[Token(Token = "0x4008A60")]
		MemberType_NORMAL_MEMBER,
		[Token(Token = "0x4008A61")]
		MemberType_VICE_CAPTAIN,
		[Token(Token = "0x4008A62")]
		MemberType_CAPTAIN,
		[Token(Token = "0x4008A63")]
		MemberType_DEPUTY_CAPTAIN
	}

	[Token(Token = "0x20013A8")]
	public enum EntryType
	{
		[Token(Token = "0x4008A65")]
		EntryType_NONE,
		[Token(Token = "0x4008A66")]
		EntryType_MANUALLY,
		[Token(Token = "0x4008A67")]
		EntryType_AUTO
	}

	[Token(Token = "0x20013A9")]
	public enum ClanUserChangeType
	{
		[Token(Token = "0x4008A69")]
		ClanUserChangeType_NONE,
		[Token(Token = "0x4008A6A")]
		ClanUserChangeType_REQUEST,
		[Token(Token = "0x4008A6B")]
		ClanUserChangeType_APPROVE_APPLICATION,
		[Token(Token = "0x4008A6C")]
		ClanUserChangeType_INVITE,
		[Token(Token = "0x4008A6D")]
		ClanUserChangeType_APPROVE_INVITATION,
		[Token(Token = "0x4008A6E")]
		ClanUserChangeType_CHANGE_MEMBER_TYPE,
		[Token(Token = "0x4008A6F")]
		ClanUserChangeType_REASSIGN_CAPTAIN,
		[Token(Token = "0x4008A70")]
		ClanUserChangeType_REMOVE,
		[Token(Token = "0x4008A71")]
		ClanUserChangeType_QUIT,
		[Token(Token = "0x4008A72")]
		ClanUserChangeType_REQUEST_AUTO,
		[Token(Token = "0x4008A73")]
		ClanUserChangeType_ADMIN_CHANGE_MEMBER_TYPE,
		[Token(Token = "0x4008A74")]
		ClanUserChangeType_ASSIGN_AGENT,
		[Token(Token = "0x4008A75")]
		ClanUserChangeType_DISMISS_AGENT,
		[Token(Token = "0x4008A76")]
		ClanUserChangeType_APPLY_AGENT,
		[Token(Token = "0x4008A77")]
		ClanUserChangeType_APPLY_AGENT_SUCCESS,
		[Token(Token = "0x4008A78")]
		ClanUserChangeType_CANCEL_OVERTIME_AGENT,
		[Token(Token = "0x4008A79")]
		ClanUserChangeType_JOIN_BY_CLAN_WAR_RECRUIT,
		[Token(Token = "0x4008A7A")]
		ClanUserChangeType_QUIT_BY_CLAN_WAR_RECRUIT
	}

	[Token(Token = "0x20013AA")]
	public enum ClanMainType
	{
		[Token(Token = "0x4008A7C")]
		ClanMainType_NONE,
		[Token(Token = "0x4008A7D")]
		ClanMainType_REGION,
		[Token(Token = "0x4008A7E")]
		ClanMainType_AREA,
		[Token(Token = "0x4008A7F")]
		ClanMainType_PLAY_STYLE
	}

	[Token(Token = "0x20013AB")]
	public enum ClanHonorType
	{
		[Token(Token = "0x4008A81")]
		ClanHonorType_NONE,
		[Token(Token = "0x4008A82")]
		ClanHonorType_MATCH,
		[Token(Token = "0x4008A83")]
		ClanHonorType_SAME_TEAM,
		[Token(Token = "0x4008A84")]
		ClanHonorType_TOP_UP
	}

	[Token(Token = "0x20013AC")]
	public enum ClanSignInRewardStatus
	{
		[Token(Token = "0x4008A86")]
		ClanSignInRewardStatus_NOT_SIGNED,
		[Token(Token = "0x4008A87")]
		ClanSignInRewardStatus_SIGNED,
		[Token(Token = "0x4008A88")]
		ClanSignInRewardStatus_CLAIMED
	}

	[Token(Token = "0x20013AD")]
	public enum RacePointsGainType
	{
		[Token(Token = "0x4008A8A")]
		RacePointsGainType_NONE,
		[Token(Token = "0x4008A8B")]
		RacePointsGainType_MATCH,
		[Token(Token = "0x4008A8C")]
		RacePointsGainType_SAME_TEAM
	}

	[Token(Token = "0x20013AE")]
	public enum PlayerRacePointChangeType
	{
		[Token(Token = "0x4008A8E")]
		PlayerRacePointChangeType_NONE,
		[Token(Token = "0x4008A8F")]
		PlayerRacePointChangeType_MATCH,
		[Token(Token = "0x4008A90")]
		PlayerRacePointChangeType_PLAYER_LEAVES,
		[Token(Token = "0x4008A91")]
		PlayerRacePointChangeType_EXCHANGE
	}

	[Token(Token = "0x20013AF")]
	public enum NewsType
	{
		[Token(Token = "0x4008A93")]
		NewsType_NONE,
		[Token(Token = "0x4008A94")]
		NewsType_JOIN,
		[Token(Token = "0x4008A95")]
		NewsType_CHANGE_TYPE,
		[Token(Token = "0x4008A96")]
		NewsType_EP_BUNDLE,
		[Token(Token = "0x4008A97")]
		NewsType_IAP,
		[Token(Token = "0x4008A98")]
		NewsType_LEVEL_UP,
		[Token(Token = "0x4008A99")]
		NewsType_OTHERS,
		[Token(Token = "0x4008A9A")]
		NewsType_BIG_LUCKY_BAG,
		[Token(Token = "0x4008A9B")]
		NewsType_CSRANKING_DIAMOND,
		[Token(Token = "0x4008A9C")]
		NewsType_CSRANKING_GRANDMASTER,
		[Token(Token = "0x4008A9D")]
		NewsType_RANKING_DIAMOND,
		[Token(Token = "0x4008A9E")]
		NewsType_RANKING_GRANDMASTER,
		[Token(Token = "0x4008A9F")]
		NewsType_WEEKLY_MEMBERSHIP,
		[Token(Token = "0x4008AA0")]
		NewsType_MONTHLY_MEMBERSHIP,
		[Token(Token = "0x4008AA1")]
		NewsType_TOPUP,
		[Token(Token = "0x4008AA2")]
		NewsType_SPECIAL_OFFER,
		[Token(Token = "0x4008AA3")]
		NewsType_GROWUP_BUNDLE
	}

	[Token(Token = "0x20013B0")]
	public enum CreateLuckyBagEventType
	{
		[Token(Token = "0x4008AA5")]
		CreateLuckyBagEventType_NONE,
		[Token(Token = "0x4008AA6")]
		CreateLuckyBagEventType_EPBUNDLE,
		[Token(Token = "0x4008AA7")]
		CreateLuckyBagEventType_IAP,
		[Token(Token = "0x4008AA8")]
		CreateLuckyBagEventType_CSRANKING_END_MATCH,
		[Token(Token = "0x4008AA9")]
		CreateLuckyBagEventType_RANKING_END_MATCH,
		[Token(Token = "0x4008AAA")]
		CreateLuckyBagEventType_SUBSCRIPTE_MEMBERSHIP,
		[Token(Token = "0x4008AAB")]
		CreateLuckyBagEventType_TOPUP,
		[Token(Token = "0x4008AAC")]
		CreateLuckyBagEventType_SPECIAL_OFFER,
		[Token(Token = "0x4008AAD")]
		CreateLuckyBagEventType_GROWUP_BUNDLE
	}

	[Token(Token = "0x20013B1")]
	public enum CreateLuckyBagCdtType
	{
		[Token(Token = "0x4008AAF")]
		CreateLuckyBagCdtType_NONE = 0,
		[Token(Token = "0x4008AB0")]
		CreateLuckyBagCdtType_EPBUNDLE = 1,
		[Token(Token = "0x4008AB1")]
		CreateLuckyBagCdtType_IAP = 2,
		[Token(Token = "0x4008AB2")]
		CreateLuckyBagCdtType_CSRANKING_DIAMOND = 3,
		[Token(Token = "0x4008AB3")]
		CreateLuckyBagCdtType_CSRANKING_GRANDMASTER = 4,
		[Token(Token = "0x4008AB4")]
		CreateLuckyBagCdtType_RANKING_DIAMOND = 5,
		[Token(Token = "0x4008AB5")]
		CreateLuckyBagCdtType_RANKING_GRANDMASTER = 6,
		[Token(Token = "0x4008AB6")]
		CreateLuckyBagCdtType_WEEKLY_MEMBERSHIP = 7,
		[Token(Token = "0x4008AB7")]
		CreateLuckyBagCdtType_MONTHLY_MEMBERSHIP = 8,
		[Token(Token = "0x4008AB8")]
		CreateLuckyBagCdtType_CREATE_BIG_LUCKY_BAG = 999,
		[Token(Token = "0x4008AB9")]
		CreateLuckyBagCdtType_TOPUP = 9,
		[Token(Token = "0x4008ABA")]
		CreateLuckyBagCdtType_SPECIAL_OFFER = 10,
		[Token(Token = "0x4008ABB")]
		CreateLuckyBagCdtType_GROWUP_BUNDLE = 11
	}

	[Token(Token = "0x20013B2")]
	public enum LuckyBagType
	{
		[Token(Token = "0x4008ABD")]
		LuckyBagType_NONE,
		[Token(Token = "0x4008ABE")]
		LuckyBagType_SMALL,
		[Token(Token = "0x4008ABF")]
		LuckyBagType_BIG
	}

	[Token(Token = "0x20013B3")]
	public enum ClanWarPhaseType
	{
		[Token(Token = "0x4008AC1")]
		ClanWarPhaseType_NONE,
		[Token(Token = "0x4008AC2")]
		ClanWarPhaseType_PREVIEW,
		[Token(Token = "0x4008AC3")]
		ClanWarPhaseType_PREPARE,
		[Token(Token = "0x4008AC4")]
		ClanWarPhaseType_MATCHMAKING,
		[Token(Token = "0x4008AC5")]
		ClanWarPhaseType_END
	}

	[Token(Token = "0x20013B4")]
	public enum ClanWarMemberType
	{
		[Token(Token = "0x4008AC7")]
		ClanWarMemberType_NONE,
		[Token(Token = "0x4008AC8")]
		ClanWarMemberType_NORMAL_MEMBER,
		[Token(Token = "0x4008AC9")]
		ClanWarMemberType_CAPTAIN
	}

	[Token(Token = "0x20013B5")]
	public enum ClanWarMemberChangeType
	{
		[Token(Token = "0x4008ACB")]
		ClanWarMemberChangeType_NONE,
		[Token(Token = "0x4008ACC")]
		ClanWarMemberChangeType_JOIN,
		[Token(Token = "0x4008ACD")]
		ClanWarMemberChangeType_INVITE,
		[Token(Token = "0x4008ACE")]
		ClanWarMemberChangeType_APPROVE_INVITATION,
		[Token(Token = "0x4008ACF")]
		ClanWarMemberChangeType_REMOVE,
		[Token(Token = "0x4008AD0")]
		ClanWarMemberChangeType_QUIT,
		[Token(Token = "0x4008AD1")]
		ClanWarMemberChangeType_APPOINT_CAPTAIN
	}

	[Token(Token = "0x20013B6")]
	public enum ClanBadgeTriggerType
	{
		[Token(Token = "0x4008AD3")]
		ClanBadgeTriggerType_NONE,
		[Token(Token = "0x4008AD4")]
		ClanBadgeTriggerType_LEVEL_UP,
		[Token(Token = "0x4008AD5")]
		ClanBadgeTriggerType_ITEM_EXCHANGE
	}

	[Token(Token = "0x6007AA1")]
	[Address(RVA = "0x309F288", Offset = "0x309F288", VA = "0x309F288")]
	public EClan()
	{
	}
}
