using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20014E0")]
public class BoybandBSuitsRewardsInfos
{
	[Token(Token = "0x4009019")]
	[FieldOffset(Offset = "0x8")]
	public List<BoybandBSuitsRewardsInfo> suits_rewards_infos;

	[Token(Token = "0x6007B35")]
	[Address(RVA = "0x317D380", Offset = "0x317D380", VA = "0x317D380")]
	public BoybandBSuitsRewardsInfos()
	{
	}
}
