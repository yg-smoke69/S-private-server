using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001454")]
public class ESchedule
{
	[Token(Token = "0x2001455")]
	public enum TaskType
	{
		[Token(Token = "0x4008D4B")]
		TaskType_NONE,
		[Token(Token = "0x4008D4C")]
		TaskType_RANKING_SeasonTopAward,
		[Token(Token = "0x4008D4D")]
		TaskType_CHAMPIONSHIP_CleanLeaderboard,
		[Token(Token = "0x4008D4E")]
		TaskType_LIMITEDEVENT_BooyahLeaderboardAward,
		[Token(Token = "0x4008D4F")]
		TaskType_RANKING_CleanLeaderboard,
		[Token(Token = "0x4008D50")]
		TaskType_CSRANKING_CleanLeaderboard,
		[Token(Token = "0x4008D51")]
		TaskType_CSRANKING_SeasonTopAward,
		[Token(Token = "0x4008D52")]
		TaskType_MAX
	}

	[Token(Token = "0x2001456")]
	public enum TaskStatus
	{
		[Token(Token = "0x4008D54")]
		TaskStatus_NONE,
		[Token(Token = "0x4008D55")]
		TaskStatus_WAIT,
		[Token(Token = "0x4008D56")]
		TaskStatus_EXEC,
		[Token(Token = "0x4008D57")]
		TaskStatus_SUCC,
		[Token(Token = "0x4008D58")]
		TaskStatus_FAIL
	}

	[Token(Token = "0x6007AFE")]
	[Address(RVA = "0x309F8E4", Offset = "0x309F8E4", VA = "0x309F8E4")]
	public ESchedule()
	{
	}
}
