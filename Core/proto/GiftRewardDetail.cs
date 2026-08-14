using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200174B")]
public class GiftRewardDetail
{
	[Token(Token = "0x40099D3")]
	[FieldOffset(Offset = "0x8")]
	public EStore.GiftRankType gift_rank_type;

	[Token(Token = "0x40099D4")]
	[FieldOffset(Offset = "0xC")]
	public List<GiftRewardDesc> gift_rewards;

	[Token(Token = "0x6007DA5")]
	[Address(RVA = "0x30A2568", Offset = "0x30A2568", VA = "0x30A2568")]
	public GiftRewardDetail()
	{
	}
}
