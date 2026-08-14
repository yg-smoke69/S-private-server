using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E8")]
public class ECreditScore
{
	[Token(Token = "0x20014E9")]
	public enum CreditCdtType
	{
		[Token(Token = "0x4009031")]
		CreditCdtType_NONE,
		[Token(Token = "0x4009032")]
		CreditCdtType_RANK_NO_SCORE,
		[Token(Token = "0x4009033")]
		CreditCdtType_BAN_GAME,
		[Token(Token = "0x4009034")]
		CreditCdtType_BAN_ROOM,
		[Token(Token = "0x4009035")]
		CreditCdtType_BAN_CUP_CHAMPIONSHIP
	}

	[Token(Token = "0x20014EA")]
	public enum ReportType
	{
		[Token(Token = "0x4009037")]
		ReportType_NONE,
		[Token(Token = "0x4009038")]
		ReportType_HANG_UP,
		[Token(Token = "0x4009039")]
		ReportType_LEAVING,
		[Token(Token = "0x400903A")]
		ReportType_POISON_SUICIDE,
		[Token(Token = "0x400903B")]
		ReportType_UNCOOPERATIVE,
		[Token(Token = "0x400903C")]
		ReportType_TEAMING,
		[Token(Token = "0x400903D")]
		ReportType_IMPROPER_NAME,
		[Token(Token = "0x400903E")]
		ReportType_IMPROPER_SPEECH,
		[Token(Token = "0x400903F")]
		ReportType_HACKER
	}

	[Token(Token = "0x20014EB")]
	public enum AwardType
	{
		[Token(Token = "0x4009041")]
		AwardType_NONE,
		[Token(Token = "0x4009042")]
		AwardType_WEEKLY,
		[Token(Token = "0x4009043")]
		AwardType_DAILY
	}

	[Token(Token = "0x20014EC")]
	public enum RewardState
	{
		[Token(Token = "0x4009045")]
		RewardState_INVALID,
		[Token(Token = "0x4009046")]
		RewardState_UNCLAIMED,
		[Token(Token = "0x4009047")]
		RewardState_CLAIMED
	}

	[Token(Token = "0x6007B3C")]
	[Address(RVA = "0x309F2A8", Offset = "0x309F2A8", VA = "0x309F2A8")]
	public ECreditScore()
	{
	}
}
