using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BE4")]
public class LimitedChestGoodsRareDesc
{
	[Token(Token = "0x400AF7B")]
	[FieldOffset(Offset = "0x8")]
	public uint jackpot;

	[Token(Token = "0x400AF7C")]
	[FieldOffset(Offset = "0xC")]
	public EInventory.AwardType reward_item_type;

	[Token(Token = "0x400AF7D")]
	[FieldOffset(Offset = "0x10")]
	public uint item_id;

	[Token(Token = "0x400AF7E")]
	[FieldOffset(Offset = "0x14")]
	public uint item_num;

	[Token(Token = "0x400AF7F")]
	[FieldOffset(Offset = "0x18")]
	public uint item_duration;

	[Token(Token = "0x400AF80")]
	[FieldOffset(Offset = "0x1C")]
	public ELottery.RareType rare_item;

	[Token(Token = "0x400AF81")]
	[FieldOffset(Offset = "0x20")]
	public uint repeat_change_item_id;

	[Token(Token = "0x400AF82")]
	[FieldOffset(Offset = "0x24")]
	public uint repeat_change_item_num;

	[Token(Token = "0x400AF83")]
	[FieldOffset(Offset = "0x28")]
	public EInventory.AwardType repeat_change_item_type;

	[Token(Token = "0x400AF84")]
	[FieldOffset(Offset = "0x2C")]
	public uint reward_level;

	[Token(Token = "0x400AF85")]
	[FieldOffset(Offset = "0x30")]
	public float drop_up_ratio;

	[Token(Token = "0x400AF86")]
	[FieldOffset(Offset = "0x34")]
	public bool epbadge_switch;

	[Token(Token = "0x400AF87")]
	[FieldOffset(Offset = "0x38")]
	public uint id;

	[Token(Token = "0x400AF88")]
	[FieldOffset(Offset = "0x3C")]
	public uint base_probability;

	[Token(Token = "0x400AF89")]
	[FieldOffset(Offset = "0x40")]
	public float base_probability_ratio_a;

	[Token(Token = "0x400AF8A")]
	[FieldOffset(Offset = "0x44")]
	public float base_probability_ratio_b;

	[Token(Token = "0x400AF8B")]
	[FieldOffset(Offset = "0x48")]
	public float base_probability_ratio_c;

	[Token(Token = "0x400AF8C")]
	[FieldOffset(Offset = "0x4C")]
	public float base_probability_ratio_d;

	[Token(Token = "0x400AF8D")]
	[FieldOffset(Offset = "0x50")]
	public float base_probability_ratio_e;

	[Token(Token = "0x400AF8E")]
	[FieldOffset(Offset = "0x54")]
	public float base_probability_ratio_f;

	[Token(Token = "0x400AF8F")]
	[FieldOffset(Offset = "0x58")]
	public float base_probability_ratio_g;

	[Token(Token = "0x400AF90")]
	[FieldOffset(Offset = "0x5C")]
	public float base_probability_ratio_h;

	[Token(Token = "0x400AF91")]
	[FieldOffset(Offset = "0x60")]
	public float base_probability_ratio_a2;

	[Token(Token = "0x400AF92")]
	[FieldOffset(Offset = "0x64")]
	public float base_probability_ratio_b2;

	[Token(Token = "0x400AF93")]
	[FieldOffset(Offset = "0x68")]
	public float base_probability_ratio_c2;

	[Token(Token = "0x400AF94")]
	[FieldOffset(Offset = "0x6C")]
	public float base_probability_ratio_d2;

	[Token(Token = "0x400AF95")]
	[FieldOffset(Offset = "0x70")]
	public float base_probability_ratio_e2;

	[Token(Token = "0x400AF96")]
	[FieldOffset(Offset = "0x74")]
	public float base_probability_ratio_f2;

	[Token(Token = "0x400AF97")]
	[FieldOffset(Offset = "0x78")]
	public float base_probability_ratio_g2;

	[Token(Token = "0x400AF98")]
	[FieldOffset(Offset = "0x7C")]
	public float base_probability_ratio_h2;

	[Token(Token = "0x600823F")]
	[Address(RVA = "0x30A48B8", Offset = "0x30A48B8", VA = "0x30A48B8")]
	public LimitedChestGoodsRareDesc()
	{
	}
}
