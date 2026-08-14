using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001386")]
public class EProfile
{
	[Token(Token = "0x2001387")]
	public enum TaskState
	{
		[Token(Token = "0x40089C9")]
		TaskState_RECEIVED,
		[Token(Token = "0x40089CA")]
		TaskState_FINISHED,
		[Token(Token = "0x40089CB")]
		TaskState_AWARDED
	}

	[Token(Token = "0x2001388")]
	public enum TaskType
	{
		[Token(Token = "0x40089CD")]
		TaskType_NONE,
		[Token(Token = "0x40089CE")]
		TaskType_MOVE_DISTANCE,
		[Token(Token = "0x40089CF")]
		TaskType_KILL,
		[Token(Token = "0x40089D0")]
		TaskType_WIN,
		[Token(Token = "0x40089D1")]
		TaskType_GROUP_WITH_FRIEND,
		[Token(Token = "0x40089D2")]
		TaskType_TASK_FINISHED_CUMU,
		[Token(Token = "0x40089D3")]
		TaskType_ITEM_COLLECT,
		[Token(Token = "0x40089D4")]
		TaskType_WEAPON_DAMAGE,
		[Token(Token = "0x40089D5")]
		TaskType_WEAPON_KILL,
		[Token(Token = "0x40089D6")]
		TaskType_REVIVAL_COUNT,
		[Token(Token = "0x40089D7")]
		TaskType_WEAPON_TYPE_KILL,
		[Token(Token = "0x40089D8")]
		TaskType_LOW_HP_KILL,
		[Token(Token = "0x40089D9")]
		TaskType_CS_ACHIEVED_KILL,
		[Token(Token = "0x40089DA")]
		TaskType_THROWING_COUNT
	}

	[Token(Token = "0x2001389")]
	public enum DispatchLine
	{
		[Token(Token = "0x40089DC")]
		DispatchLine_NONE,
		[Token(Token = "0x40089DD")]
		DispatchLine_FIRST,
		[Token(Token = "0x40089DE")]
		DispatchLine_SECOND,
		[Token(Token = "0x40089DF")]
		DispatchLine_THIRD,
		[Token(Token = "0x40089E0")]
		DispatchLine_FOURTH
	}

	[Token(Token = "0x200138A")]
	public enum DispatchQuestState
	{
		[Token(Token = "0x40089E2")]
		DispatchQuestState_NONE,
		[Token(Token = "0x40089E3")]
		DispatchQuestState_PROCESSING,
		[Token(Token = "0x40089E4")]
		DispatchQuestState_FINISHED
	}

	[Token(Token = "0x200138B")]
	public enum UnlockType
	{
		[Token(Token = "0x40089E6")]
		UnlockType_NONE,
		[Token(Token = "0x40089E7")]
		UnlockType_LINK
	}

	[Token(Token = "0x6007A87")]
	[Address(RVA = "0x309F8B4", Offset = "0x309F8B4", VA = "0x309F8B4")]
	public EProfile()
	{
	}
}
