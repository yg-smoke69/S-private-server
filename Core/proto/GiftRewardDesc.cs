using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA9")]
public class GiftRewardDesc
{
	[Token(Token = "0x400A78E")]
	[FieldOffset(Offset = "0x8")]
	public EStore.GiftRankType rank_tab_id;

	[Token(Token = "0x400A78F")]
	[FieldOffset(Offset = "0xC")]
	public uint gift_item_num;

	[Token(Token = "0x400A790")]
	[FieldOffset(Offset = "0x10")]
	public EInventory.AwardType reward_item_type;

	[Token(Token = "0x400A791")]
	[FieldOffset(Offset = "0x14")]
	public string reward_item_name;

	[Token(Token = "0x400A792")]
	[FieldOffset(Offset = "0x18")]
	public uint reward_item_id;

	[Token(Token = "0x400A793")]
	[FieldOffset(Offset = "0x1C")]
	public uint reward_item_num;

	[Token(Token = "0x400A794")]
	[FieldOffset(Offset = "0x20")]
	public uint award_time;

	[Token(Token = "0x6008106")]
	[Address(RVA = "0x30A24C8", Offset = "0x30A24C8", VA = "0x30A24C8")]
	public GiftRewardDesc()
	{
	}
}
