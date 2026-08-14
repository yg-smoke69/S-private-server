using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001335")]
public class EMessageQueue
{
	[Token(Token = "0x2001336")]
	public enum Topic
	{
		[Token(Token = "0x4008826")]
		Topic_EndMatch,
		[Token(Token = "0x4008827")]
		Topic_LogoutMatch,
		[Token(Token = "0x4008828")]
		Topic_ActivityTrigger,
		[Token(Token = "0x4008829")]
		Topic_SendMail,
		[Token(Token = "0x400882A")]
		Topic_BatchSendMail,
		[Token(Token = "0x400882B")]
		Topic_ManualUpdate,
		[Token(Token = "0x400882C")]
		Topic_AccountNews,
		[Token(Token = "0x400882D")]
		Topic_EPChallengeTrigger,
		[Token(Token = "0x400882E")]
		Topic_ChampionshipEndMatch,
		[Token(Token = "0x400882F")]
		Topic_FreshActivityTrigger,
		[Token(Token = "0x4008830")]
		Topic_LinkageActivityTrigger,
		[Token(Token = "0x4008831")]
		Topic_VN_EndMatch,
		[Token(Token = "0x4008832")]
		Topic_TH_EndMatch,
		[Token(Token = "0x4008833")]
		Topic_ID_EndMatch,
		[Token(Token = "0x4008834")]
		Topic_TW_EndMatch,
		[Token(Token = "0x4008835")]
		Topic_BR_EndMatch,
		[Token(Token = "0x4008836")]
		Topic_SG_EndMatch,
		[Token(Token = "0x4008837")]
		Topic_US_EndMatch,
		[Token(Token = "0x4008838")]
		Topic_ZA_EndMatch,
		[Token(Token = "0x4008839")]
		Topic_RU_EndMatch,
		[Token(Token = "0x400883A")]
		Topic_EUROPE_EndMatch,
		[Token(Token = "0x400883B")]
		Topic_SAC_EndMatch,
		[Token(Token = "0x400883C")]
		Topic_IND_EndMatch,
		[Token(Token = "0x400883D")]
		Topic_ME_ENdMatch,
		[Token(Token = "0x400883E")]
		Topic_AttendanceTrigger,
		[Token(Token = "0x400883F")]
		Topic_NA_EndMatch,
		[Token(Token = "0x4008840")]
		Topic_AwakenTaskTrigger,
		[Token(Token = "0x4008841")]
		Topic_ReduceCSRankingHangUps,
		[Token(Token = "0x4008842")]
		Topic_SyncEPArchivesInfoTrigger,
		[Token(Token = "0x4008843")]
		Topic_PayLevelTrigger,
		[Token(Token = "0x4008844")]
		Topic_UpdateAccountHackerTagTrigger,
		[Token(Token = "0x4008845")]
		Topic_PK_EndMatch,
		[Token(Token = "0x4008846")]
		Topic_AmendPlayerMmr,
		[Token(Token = "0x4008847")]
		Topic_AddIntimacy,
		[Token(Token = "0x4008848")]
		Topic_UpdateBattleTag,
		[Token(Token = "0x4008849")]
		Topic_StoreIAPTrigger,
		[Token(Token = "0x400884A")]
		Topic_BD_EndMatch,
		[Token(Token = "0x400884B")]
		Topic_CupEndMatch,
		[Token(Token = "0x400884C")]
		Topic_RealTimeUpdateIngameItemsTrigger,
		[Token(Token = "0x400884D")]
		Topic_ClanWarEndMatch,
		[Token(Token = "0x400884E")]
		Topic_WorkshopEndMatch,
		[Token(Token = "0x400884F")]
		Topic_ClanLuckyBagTrigger,
		[Token(Token = "0x4008850")]
		Topic_AddChummyIntimacy,
		[Token(Token = "0x4008851")]
		Topic_SendReportMail,
		[Token(Token = "0x4008852")]
		Topic_SubmitMatchBehavior,
		[Token(Token = "0x4008853")]
		Topic_UpdateMiniGameStats,
		[Token(Token = "0x4008854")]
		Topic_ReportMatchReplayUploadSuss,
		[Token(Token = "0x4008855")]
		Topic_UpdateLimitedEventStats
	}

	[Token(Token = "0x2001337")]
	public enum EndMatchChannel
	{
		[Token(Token = "0x4008857")]
		EndMatchChannel_SubmitMatchStats
	}

	[Token(Token = "0x2001338")]
	public enum LogoutMatchChannel
	{
		[Token(Token = "0x4008859")]
		LogoutMatchChannel_SubmitMatchStats
	}

	[Token(Token = "0x2001339")]
	public enum ActivityChannel
	{
		[Token(Token = "0x400885B")]
		ActivityTriggerChannel_Trigger
	}

	[Token(Token = "0x200133A")]
	public enum SendMailChannel
	{
		[Token(Token = "0x400885D")]
		SendMailChannel_CheckMail
	}

	[Token(Token = "0x200133B")]
	public enum BatchSendMailChannel
	{
		[Token(Token = "0x400885F")]
		BatchSendMailChannel_CheckMail
	}

	[Token(Token = "0x200133C")]
	public enum AmendPlayerMmrChannel
	{
		[Token(Token = "0x4008861")]
		AmendPlayerMmrChannel_Update
	}

	[Token(Token = "0x200133D")]
	public enum ManualChannel
	{
		[Token(Token = "0x4008863")]
		ManualUpdateChannel_Update
	}

	[Token(Token = "0x200133E")]
	public enum AccountNewsChannel
	{
		[Token(Token = "0x4008865")]
		AccountNewsChannel_Update
	}

	[Token(Token = "0x200133F")]
	public enum EPChannel
	{
		[Token(Token = "0x4008867")]
		EPChallengeTriggerChannel_Trigger
	}

	[Token(Token = "0x2001340")]
	public enum ChampionshipChannel
	{
		[Token(Token = "0x4008869")]
		ChampionshipChannel_SubmitChampionshipTeamMatchStats
	}

	[Token(Token = "0x2001341")]
	public enum CupChannel
	{
		[Token(Token = "0x400886B")]
		CupChannel_SubmitCupTeamMatchStats
	}

	[Token(Token = "0x2001342")]
	public enum FreshChannel
	{
		[Token(Token = "0x400886D")]
		FreshActivityTriggerChannel_Trigger
	}

	[Token(Token = "0x2001343")]
	public enum LinkageChannel
	{
		[Token(Token = "0x400886F")]
		LinkageActivityTriggerChannel_Trigger
	}

	[Token(Token = "0x2001344")]
	public enum AttendanceChannel
	{
		[Token(Token = "0x4008871")]
		AttendanceVeteranTaskTriggerChannel_Trigger
	}

	[Token(Token = "0x2001345")]
	public enum ProfileChannel
	{
		[Token(Token = "0x4008873")]
		ProfileChannel_AwakenTaskTrigger
	}

	[Token(Token = "0x2001346")]
	public enum CSRankingMatchChannel
	{
		[Token(Token = "0x4008875")]
		CSRankingMatchChannel_ReduceHangUps
	}

	[Token(Token = "0x2001347")]
	public enum EPArchivesChannel
	{
		[Token(Token = "0x4008877")]
		EPArchivesChannel_Sync
	}

	[Token(Token = "0x2001348")]
	public enum StoreChannel
	{
		[Token(Token = "0x4008879")]
		StoreChannel_PayLevelTrigger,
		[Token(Token = "0x400887A")]
		StoreChannel_IAPStoreTrigger
	}

	[Token(Token = "0x2001349")]
	public enum AccountHackerTagChannel
	{
		[Token(Token = "0x400887C")]
		AccountHackerTagChannel_Update
	}

	[Token(Token = "0x200134A")]
	public enum AddIntimacyChannel
	{
		[Token(Token = "0x400887E")]
		AddIntimacyChannel_Trigger
	}

	[Token(Token = "0x200134B")]
	public enum BattleTagChannel
	{
		[Token(Token = "0x4008880")]
		BattleTagChannel_Update
	}

	[Token(Token = "0x200134C")]
	public enum RealTimeIngameItemsChannel
	{
		[Token(Token = "0x4008882")]
		RealTimeIngameItemsChannel_Update
	}

	[Token(Token = "0x200134D")]
	public enum ClanChannel
	{
		[Token(Token = "0x4008884")]
		ClanChannel_SubmitClanWarTeamMatchStats,
		[Token(Token = "0x4008885")]
		ClanChannel_ClanLuckyBagTrigger
	}

	[Token(Token = "0x200134E")]
	public enum WorkshopChannel
	{
		[Token(Token = "0x4008887")]
		WorkshopChannel_SubmitWorkshopMatchStats
	}

	[Token(Token = "0x200134F")]
	public enum ChummyChannel
	{
		[Token(Token = "0x4008889")]
		ChummyChannel_AddChummyIntimacy
	}

	[Token(Token = "0x2001350")]
	public enum SendReportMailChannel
	{
		[Token(Token = "0x400888B")]
		SendReportMailChannel_SendReportMail
	}

	[Token(Token = "0x2001351")]
	public enum CreditScoreChannel
	{
		[Token(Token = "0x400888D")]
		CreditScoreChannel_SubmitMatchBehavior
	}

	[Token(Token = "0x2001352")]
	public enum MiniGameChannel
	{
		[Token(Token = "0x400888F")]
		MiniGameChannel_UpdateMiniGameStats
	}

	[Token(Token = "0x2001353")]
	public enum LimitedEventChannel
	{
		[Token(Token = "0x4008891")]
		LimitedEventChannel_UpdateLimitedEventStats
	}

	[Token(Token = "0x6007A56")]
	[Address(RVA = "0x309F350", Offset = "0x309F350", VA = "0x309F350")]
	public EMessageQueue()
	{
	}
}
