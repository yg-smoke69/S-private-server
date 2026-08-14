using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002DCD")]
public class EPDailyRewardInfo
{
	[Token(Token = "0x4011967")]
	[FieldOffset(Offset = "0x8")]
	public EPDailyRewardData dailyRewardData;

	[Token(Token = "0x4011968")]
	[FieldOffset(Offset = "0xC")]
	public EPTarget_Status status;

	[Token(Token = "0x6013351")]
	[Address(RVA = "0x1C9EDBC", Offset = "0x1C9EDBC", VA = "0x1C9EDBC")]
	public EPDailyRewardInfo()
	{
	}
}
