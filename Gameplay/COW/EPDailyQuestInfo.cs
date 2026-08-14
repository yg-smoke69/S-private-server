using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DCE")]
public class EPDailyQuestInfo
{
	[Token(Token = "0x4011969")]
	[FieldOffset(Offset = "0x8")]
	public EPDailyQuestData dailyQuestData;

	[Token(Token = "0x401196A")]
	[FieldOffset(Offset = "0xC")]
	public ChallengeStatus status;

	[Token(Token = "0x401196B")]
	[FieldOffset(Offset = "0x10")]
	public bool isNewFinish;

	[Token(Token = "0x6013352")]
	[Address(RVA = "0x1C9E780", Offset = "0x1C9E780", VA = "0x1C9E780")]
	public EPDailyQuestInfo()
	{
	}
}
