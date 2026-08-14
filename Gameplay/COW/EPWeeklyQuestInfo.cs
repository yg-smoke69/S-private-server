using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DCF")]
public class EPWeeklyQuestInfo
{
	[Token(Token = "0x401196C")]
	[FieldOffset(Offset = "0x8")]
	public EPWeeklyQuestData weeklyQuestData;

	[Token(Token = "0x401196D")]
	[FieldOffset(Offset = "0xC")]
	public ChallengeStatus status;

	[Token(Token = "0x401196E")]
	[FieldOffset(Offset = "0x10")]
	public bool isLock;

	[Token(Token = "0x6013353")]
	[Address(RVA = "0x2520098", Offset = "0x2520098", VA = "0x2520098")]
	public EPWeeklyQuestInfo()
	{
	}
}
