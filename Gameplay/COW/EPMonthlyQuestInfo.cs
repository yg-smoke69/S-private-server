using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DD0")]
public class EPMonthlyQuestInfo
{
	[Token(Token = "0x401196F")]
	[FieldOffset(Offset = "0x8")]
	public EPMonthlyQuestData monthlyQuestData;

	[Token(Token = "0x4011970")]
	[FieldOffset(Offset = "0xC")]
	public ChallengeStatus status;

	[Token(Token = "0x6013354")]
	[Address(RVA = "0x2518600", Offset = "0x2518600", VA = "0x2518600")]
	public EPMonthlyQuestInfo()
	{
	}
}
