using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013EC")]
public class QuestIDs
{
	[Token(Token = "0x4008B82")]
	[FieldOffset(Offset = "0x8")]
	public uint[] questIDs;

	[Token(Token = "0x4008B83")]
	[FieldOffset(Offset = "0xC")]
	public uint[] dailyQuestIDs;

	[Token(Token = "0x4008B84")]
	[FieldOffset(Offset = "0x10")]
	public uint daily_quest_completed_cnt;

	[Token(Token = "0x4008B85")]
	[FieldOffset(Offset = "0x14")]
	public uint daily_quest_today_cnt;

	[Token(Token = "0x4008B86")]
	[FieldOffset(Offset = "0x18")]
	public uint quest_completed_cnt;

	[Token(Token = "0x6007ACD")]
	[Address(RVA = "0x33E03A4", Offset = "0x33E03A4", VA = "0x33E03A4")]
	public QuestIDs()
	{
	}
}
