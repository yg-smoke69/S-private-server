using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015ED")]
public class CSGetNewPlayerRewardsListRes
{
	[Token(Token = "0x4009497")]
	[FieldOffset(Offset = "0x8")]
	public List<NewPlayerRewardItem> rewards;

	[Token(Token = "0x4009498")]
	[FieldOffset(Offset = "0x10")]
	public ulong expire_time;

	[Token(Token = "0x6007C37")]
	[Address(RVA = "0x3188150", Offset = "0x3188150", VA = "0x3188150")]
	public CSGetNewPlayerRewardsListRes()
	{
	}
}
