using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200175C")]
public class CSGetMysteryPoolInfoRes
{
	[Token(Token = "0x4009A0F")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009A10")]
	[FieldOffset(Offset = "0x10")]
	public List<MysteryPoolStoreItem> normal_reward_list;

	[Token(Token = "0x4009A11")]
	[FieldOffset(Offset = "0x14")]
	public MysteryPoolStoreItem super_reward;

	[Token(Token = "0x4009A12")]
	[FieldOffset(Offset = "0x18")]
	public List<ClientMysteryShopSwitchDesc> pool_desc_list;

	[Token(Token = "0x6007DB6")]
	[Address(RVA = "0x3187EBC", Offset = "0x3187EBC", VA = "0x3187EBC")]
	public CSGetMysteryPoolInfoRes()
	{
	}
}
