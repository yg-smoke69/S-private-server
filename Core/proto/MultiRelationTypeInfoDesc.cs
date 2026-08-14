using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF0")]
public class MultiRelationTypeInfoDesc
{
	[Token(Token = "0x400AFF3")]
	[FieldOffset(Offset = "0x8")]
	public EChummy.MultiRelationType multi_relation_type;

	[Token(Token = "0x400AFF4")]
	[FieldOffset(Offset = "0xC")]
	public uint multi_relation_num;

	[Token(Token = "0x400AFF5")]
	[FieldOffset(Offset = "0x10")]
	public bool if_avatar_open;

	[Token(Token = "0x400AFF6")]
	[FieldOffset(Offset = "0x14")]
	public uint apply_max;

	[Token(Token = "0x400AFF7")]
	[FieldOffset(Offset = "0x18")]
	public uint reject_count_down;

	[Token(Token = "0x400AFF8")]
	[FieldOffset(Offset = "0x1C")]
	public uint relation_breakup_count_down;

	[Token(Token = "0x400AFF9")]
	[FieldOffset(Offset = "0x20")]
	public uint relation_disable_time;

	[Token(Token = "0x400AFFA")]
	[FieldOffset(Offset = "0x24")]
	public float item_intimacy_diamond_rate;

	[Token(Token = "0x400AFFB")]
	[FieldOffset(Offset = "0x28")]
	public float item_intimacy_coin_rate;

	[Token(Token = "0x400AFFC")]
	[FieldOffset(Offset = "0x2C")]
	public float br_rank_point_rate;

	[Token(Token = "0x400AFFD")]
	[FieldOffset(Offset = "0x30")]
	public float cs_rank_point_rate;

	[Token(Token = "0x400AFFE")]
	[FieldOffset(Offset = "0x34")]
	public uint intimacy_week_max;

	[Token(Token = "0x600824B")]
	[Address(RVA = "0x30A91F8", Offset = "0x30A91F8", VA = "0x30A91F8")]
	public MultiRelationTypeInfoDesc()
	{
	}
}
