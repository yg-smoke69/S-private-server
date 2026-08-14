using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A84")]
public class EPDailyRewardStatus
{
	[Token(Token = "0x400A619")]
	[FieldOffset(Offset = "0x8")]
	public List<EPDailyProcessRewardStatus> daily_reward_status;

	[Token(Token = "0x60080E1")]
	[Address(RVA = "0x309F4A0", Offset = "0x309F4A0", VA = "0x309F4A0")]
	public EPDailyRewardStatus()
	{
	}
}
