using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200173C")]
public class CSGetGiftRankDescRes
{
	[Token(Token = "0x40099AC")]
	[FieldOffset(Offset = "0x8")]
	public ClientGiftRankDesc gift_rank_desc;

	[Token(Token = "0x40099AD")]
	[FieldOffset(Offset = "0xC")]
	public List<GiftRewardDetail> gift_reward_detail;

	[Token(Token = "0x6007D96")]
	[Address(RVA = "0x31859D4", Offset = "0x31859D4", VA = "0x31859D4")]
	public CSGetGiftRankDescRes()
	{
	}
}
