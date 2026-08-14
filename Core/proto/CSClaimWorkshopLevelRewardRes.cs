using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001904")]
public class CSClaimWorkshopLevelRewardRes
{
	[Token(Token = "0x4009E8D")]
	[FieldOffset(Offset = "0x8")]
	public List<WorkshopLevelReward> rewards;

	[Token(Token = "0x6007F5D")]
	[Address(RVA = "0x317E9A8", Offset = "0x317E9A8", VA = "0x317E9A8")]
	public CSClaimWorkshopLevelRewardRes()
	{
	}
}
