using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DD1")]
public class EPWeeklyRewardInfo
{
	[Token(Token = "0x4011971")]
	[FieldOffset(Offset = "0x8")]
	public EPWeeklyQuestRewardData weeklyQuestRewardData;

	[Token(Token = "0x4011972")]
	[FieldOffset(Offset = "0xC")]
	public EPProcess_Status status;

	[Token(Token = "0x6013355")]
	[Address(RVA = "0x2520BFC", Offset = "0x2520BFC", VA = "0x2520BFC")]
	public EPWeeklyRewardInfo()
	{
	}
}
