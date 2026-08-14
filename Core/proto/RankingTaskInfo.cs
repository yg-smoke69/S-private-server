using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001990")]
public class RankingTaskInfo
{
	[Token(Token = "0x400A019")]
	[FieldOffset(Offset = "0x8")]
	public RankingTaskCdtDesc task_desc;

	[Token(Token = "0x400A01A")]
	[FieldOffset(Offset = "0xC")]
	public ERankingTask.State state;

	[Token(Token = "0x400A01B")]
	[FieldOffset(Offset = "0x10")]
	public uint data;

	[Token(Token = "0x6007FEB")]
	[Address(RVA = "0x33E0E98", Offset = "0x33E0E98", VA = "0x33E0E98")]
	public RankingTaskInfo()
	{
	}
}
