using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002FD4")]
public class UIModelCredit : UIBaseModel
{
	[Token(Token = "0x4012346")]
	public const uint PropID_GetCreditScoreChangeFinish = 1u;

	[Token(Token = "0x4012347")]
	public const uint PropID_ClaimCreditScoreWeeklyRewards = 2u;

	[Token(Token = "0x4012348")]
	public const uint PropID_CreditScoreDecreased = 4u;

	[Token(Token = "0x4012349")]
	public const uint PropID_CreditPunishMentUpdate = 8u;

	[Token(Token = "0x401234A")]
	public const uint PropID_CreditScoreUpdate = 16u;

	[Token(Token = "0x401234B")]
	[FieldOffset(Offset = "0xC")]
	private CSGetCreditScoreDescRes m_CreditScoreDesc;

	[Token(Token = "0x401234C")]
	[FieldOffset(Offset = "0x10")]
	private CSGetCreditScoreInfoRes m_CreditScoreInfo;

	[Token(Token = "0x401234D")]
	[FieldOffset(Offset = "0x14")]
	public bool IsFirstLogin;

	[Token(Token = "0x401234E")]
	[FieldOffset(Offset = "0x18")]
	public uint CurCreditScore;

	[Token(Token = "0x401234F")]
	[FieldOffset(Offset = "0x1C")]
	public int CreditDeltScore;

	[Token(Token = "0x4012350")]
	[FieldOffset(Offset = "0x20")]
	public bool HasNewTip;

	[Token(Token = "0x4012351")]
	[FieldOffset(Offset = "0x28")]
	public long TimeStamp;

	[Token(Token = "0x6013FB3")]
	[Address(RVA = "0x31E2234", Offset = "0x31E2234", VA = "0x31E2234")]
	public UIModelCredit()
	{
	}

	[Token(Token = "0x6013FB4")]
	[Address(RVA = "0x31E22B8", Offset = "0x31E22B8", VA = "0x31E22B8", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013FB5")]
	[Address(RVA = "0x31E2310", Offset = "0x31E2310", VA = "0x31E2310", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013FB6")]
	[Address(RVA = "0x31E2394", Offset = "0x31E2394", VA = "0x31E2394")]
	public CSGetCreditScoreDescRes GetCreditScoreDesc()
	{
		return null;
	}

	[Token(Token = "0x6013FB7")]
	[Address(RVA = "0x31E23EC", Offset = "0x31E23EC", VA = "0x31E23EC")]
	public CSGetCreditScoreInfoRes GetCreditScoreInfo()
	{
		return null;
	}

	[Token(Token = "0x6013FB8")]
	[Address(RVA = "0x31E2444", Offset = "0x31E2444", VA = "0x31E2444")]
	public bool GetCreditSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x6013FB9")]
	[Address(RVA = "0x31E24C4", Offset = "0x31E24C4", VA = "0x31E24C4")]
	public CreditReduceDesc GetCreditReduceDescByRuleID(uint ruleID)
	{
		return null;
	}

	[Token(Token = "0x6013FBA")]
	[Address(RVA = "0x31E2690", Offset = "0x31E2690", VA = "0x31E2690")]
	public void RequestGetCreditScoreDesc(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6013FBB")]
	[Address(RVA = "0x31E2904", Offset = "0x31E2904", VA = "0x31E2904")]
	public void RequestGetCreditScoreInfo()
	{
	}

	[Token(Token = "0x6013FBC")]
	[Address(RVA = "0x31E2BD4", Offset = "0x31E2BD4", VA = "0x31E2BD4")]
	public void RequestGetCreditScoreChangeInfo()
	{
	}

	[Token(Token = "0x6013FBD")]
	[Address(RVA = "0x31E2E38", Offset = "0x31E2E38", VA = "0x31E2E38")]
	public void RequestClaimCreditScoreWeeklyRewards()
	{
	}

	[Token(Token = "0x6013FBE")]
	[Address(RVA = "0x31E309C", Offset = "0x31E309C", VA = "0x31E309C")]
	public void UpdateCredit(uint credit_score, int credit_score_delta, long change_time_stamp)
	{
	}

	[Token(Token = "0x6013FBF")]
	[Address(RVA = "0x31E37A8", Offset = "0x31E37A8", VA = "0x31E37A8")]
	private void _003CRequestGetCreditScoreDesc_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013FC0")]
	[Address(RVA = "0x31E38A8", Offset = "0x31E38A8", VA = "0x31E38A8")]
	private void _003CRequestGetCreditScoreInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013FC1")]
	[Address(RVA = "0x31E3A24", Offset = "0x31E3A24", VA = "0x31E3A24")]
	private void _003CRequestGetCreditScoreChangeInfo_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013FC2")]
	[Address(RVA = "0x31E3C30", Offset = "0x31E3C30", VA = "0x31E3C30")]
	private void _003CRequestClaimCreditScoreWeeklyRewards_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013FC3")]
	[Address(RVA = "0x31E3E7C", Offset = "0x31E3E7C", VA = "0x31E3E7C")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
