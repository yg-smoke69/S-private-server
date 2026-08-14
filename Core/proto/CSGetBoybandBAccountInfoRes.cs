using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001957")]
public class CSGetBoybandBAccountInfoRes
{
	[Token(Token = "0x4009F76")]
	[FieldOffset(Offset = "0x8")]
	public List<BoybandBTradingCardInfo> trading_card_info;

	[Token(Token = "0x4009F77")]
	[FieldOffset(Offset = "0xC")]
	public List<BoybandBSuitsRewardsInfo> suits_reward_infos;

	[Token(Token = "0x6007FB0")]
	[Address(RVA = "0x318299C", Offset = "0x318299C", VA = "0x318299C")]
	public CSGetBoybandBAccountInfoRes()
	{
	}
}
