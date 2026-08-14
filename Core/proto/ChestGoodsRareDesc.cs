using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A9D")]
public class ChestGoodsRareDesc
{
	[Token(Token = "0x400A6B9")]
	[FieldOffset(Offset = "0x8")]
	public uint jackpot;

	[Token(Token = "0x400A6BA")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.AwardType reward_item_type;

	[Token(Token = "0x400A6BB")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x400A6BC")]
	[FieldOffset(Offset = "0x14")]
	public uint item_num;

	[Token(Token = "0x400A6BD")]
	[FieldOffset(Offset = "0x18")]
	public bool must_drop_item;

	[Token(Token = "0x400A6BE")]
	[FieldOffset(Offset = "0x1C")]
	public ELottery.RareType rare_item;

	[Token(Token = "0x400A6BF")]
	[FieldOffset(Offset = "0x20")]
	public bool first_reward_item;

	[Token(Token = "0x400A6C0")]
	[FieldOffset(Offset = "0x24")]
	public uint drop_limit;

	[Token(Token = "0x400A6C1")]
	[FieldOffset(Offset = "0x28")]
	public uint first_reward_probability;

	[Token(Token = "0x400A6C2")]
	[FieldOffset(Offset = "0x2C")]
	public uint base_probability;

	[Token(Token = "0x400A6C3")]
	[FieldOffset(Offset = "0x30")]
	public uint second_level_probability;

	[Token(Token = "0x400A6C4")]
	[FieldOffset(Offset = "0x34")]
	public uint third_level_probability;

	[Token(Token = "0x400A6C5")]
	[FieldOffset(Offset = "0x38")]
	public uint repeat_change_item_id;

	[Token(Token = "0x400A6C6")]
	[FieldOffset(Offset = "0x3C")]
	public uint repeat_change_item_num;

	[Token(Token = "0x400A6C7")]
	[FieldOffset(Offset = "0x40")]
	public uint reward_level;

	[Token(Token = "0x400A6C8")]
	[FieldOffset(Offset = "0x44")]
	public EInventory.AwardType repeat_change_item_type;

	[Token(Token = "0x400A6C9")]
	[FieldOffset(Offset = "0x48")]
	public uint turntable_props_type;

	[Token(Token = "0x400A6CA")]
	[FieldOffset(Offset = "0x4C")]
	public float drop_up_ratio;

	[Token(Token = "0x400A6CB")]
	[FieldOffset(Offset = "0x50")]
	public bool epbadge_switch;

	[Token(Token = "0x400A6CC")]
	[FieldOffset(Offset = "0x54")]
	public uint veteran_probability;

	[Token(Token = "0x400A6CD")]
	[FieldOffset(Offset = "0x58")]
	public uint id;

	[Token(Token = "0x400A6CE")]
	[FieldOffset(Offset = "0x5C")]
	public float base_probability_ratio_a;

	[Token(Token = "0x400A6CF")]
	[FieldOffset(Offset = "0x60")]
	public float base_probability_ratio_b;

	[Token(Token = "0x400A6D0")]
	[FieldOffset(Offset = "0x64")]
	public float base_probability_ratio_c;

	[Token(Token = "0x400A6D1")]
	[FieldOffset(Offset = "0x68")]
	public float base_probability_ratio_d;

	[Token(Token = "0x400A6D2")]
	[FieldOffset(Offset = "0x6C")]
	public float base_probability_ratio_e;

	[Token(Token = "0x400A6D3")]
	[FieldOffset(Offset = "0x70")]
	public float base_probability_ratio_f;

	[Token(Token = "0x400A6D4")]
	[FieldOffset(Offset = "0x74")]
	public float base_probability_ratio_g;

	[Token(Token = "0x400A6D5")]
	[FieldOffset(Offset = "0x78")]
	public float base_probability_ratio_h;

	[Token(Token = "0x400A6D6")]
	[FieldOffset(Offset = "0x7C")]
	public uint item_duration;

	[Token(Token = "0x400A6D7")]
	[FieldOffset(Offset = "0x80")]
	public float base_probability_ratio_a2;

	[Token(Token = "0x400A6D8")]
	[FieldOffset(Offset = "0x84")]
	public float base_probability_ratio_b2;

	[Token(Token = "0x400A6D9")]
	[FieldOffset(Offset = "0x88")]
	public float base_probability_ratio_c2;

	[Token(Token = "0x400A6DA")]
	[FieldOffset(Offset = "0x8C")]
	public float base_probability_ratio_d2;

	[Token(Token = "0x400A6DB")]
	[FieldOffset(Offset = "0x90")]
	public float base_probability_ratio_e2;

	[Token(Token = "0x400A6DC")]
	[FieldOffset(Offset = "0x94")]
	public float base_probability_ratio_f2;

	[Token(Token = "0x400A6DD")]
	[FieldOffset(Offset = "0x98")]
	public float base_probability_ratio_g2;

	[Token(Token = "0x400A6DE")]
	[FieldOffset(Offset = "0x9C")]
	public float base_probability_ratio_h2;

	[Token(Token = "0x400A6DF")]
	[FieldOffset(Offset = "0xA0")]
	public uint fourth_level_probability;

	[Token(Token = "0x400A6E0")]
	[FieldOffset(Offset = "0xA4")]
	public uint fifth_level_probability;

	[Token(Token = "0x400A6E1")]
	[FieldOffset(Offset = "0xA8")]
	public bool token_flag;

	[Token(Token = "0x400A6E2")]
	[FieldOffset(Offset = "0xA9")]
	public bool un_quick_selection;

	[Token(Token = "0x400A6E3")]
	[FieldOffset(Offset = "0xAC")]
	public float voucher_probability_ratio;

	[Token(Token = "0x60080FA")]
	[Address(RVA = "0x309B580", Offset = "0x309B580", VA = "0x309B580")]
	public ChestGoodsRareDesc()
	{
	}
}
