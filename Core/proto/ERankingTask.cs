using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014F3")]
public class ERankingTask
{
	[Token(Token = "0x20014F4")]
	public enum PreConditionType
	{
		[Token(Token = "0x400905B")]
		PreConditionType_NONE,
		[Token(Token = "0x400905C")]
		PreConditionType_DAMAGE,
		[Token(Token = "0x400905D")]
		PreConditionType_KILLS,
		[Token(Token = "0x400905E")]
		PreConditionType_ASSIST_AND_KILLS,
		[Token(Token = "0x400905F")]
		PreConditionType_SURVIVAL_TIME
	}

	[Token(Token = "0x20014F5")]
	public enum ConditionType
	{
		[Token(Token = "0x4009061")]
		ConditionType_NONE,
		[Token(Token = "0x4009062")]
		ConditionType_SURVIVAL_TIME,
		[Token(Token = "0x4009063")]
		ConditionType_FINISH_ROUNDS_TIMES,
		[Token(Token = "0x4009064")]
		ConditionType_DAMAGE,
		[Token(Token = "0x4009065")]
		ConditionType_ASSIST_AND_KILLS,
		[Token(Token = "0x4009066")]
		ConditionType_KILLS
	}

	[Token(Token = "0x20014F6")]
	public enum State
	{
		[Token(Token = "0x4009068")]
		State_RECEIVED,
		[Token(Token = "0x4009069")]
		State_FINISHED
	}

	[Token(Token = "0x6007B42")]
	[Address(RVA = "0x309F8CC", Offset = "0x309F8CC", VA = "0x309F8CC")]
	public ERankingTask()
	{
	}
}
