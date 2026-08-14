using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017BC")]
public class CSGetAccountFreshInfoRes
{
	[Token(Token = "0x4009B47")]
	[FieldOffset(Offset = "0x8")]
	public uint day;

	[Token(Token = "0x4009B48")]
	[FieldOffset(Offset = "0x10")]
	public ulong expire_time;

	[Token(Token = "0x4009B49")]
	[FieldOffset(Offset = "0x18")]
	public List<FreshRewardItem> reward_items;

	[Token(Token = "0x4009B4A")]
	[FieldOffset(Offset = "0x1C")]
	public List<ActivityInfo> activitys;

	[Token(Token = "0x4009B4B")]
	[FieldOffset(Offset = "0x20")]
	public bool[] guide_reward_claimed;

	[Token(Token = "0x6007E16")]
	[Address(RVA = "0x3180AD0", Offset = "0x3180AD0", VA = "0x3180AD0")]
	public CSGetAccountFreshInfoRes()
	{
	}
}
