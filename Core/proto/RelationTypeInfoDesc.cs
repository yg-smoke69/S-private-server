using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ACB")]
public class RelationTypeInfoDesc
{
	[Token(Token = "0x400A8AF")]
	[FieldOffset(Offset = "0x8")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x400A8B0")]
	[FieldOffset(Offset = "0xC")]
	public uint relation_item_id;

	[Token(Token = "0x400A8B1")]
	[FieldOffset(Offset = "0x10")]
	public uint reject_countdown;

	[Token(Token = "0x400A8B2")]
	[FieldOffset(Offset = "0x14")]
	public uint relation_break_up_cd;

	[Token(Token = "0x400A8B3")]
	[FieldOffset(Offset = "0x18")]
	public uint relation_break_up_countdown;

	[Token(Token = "0x400A8B4")]
	[FieldOffset(Offset = "0x1C")]
	public float item_intimacy_diamond_rate;

	[Token(Token = "0x400A8B5")]
	[FieldOffset(Offset = "0x20")]
	public float item_intimacy_coin_rate;

	[Token(Token = "0x400A8B6")]
	[FieldOffset(Offset = "0x24")]
	public uint intimacy_week_max;

	[Token(Token = "0x400A8B7")]
	[FieldOffset(Offset = "0x28")]
	public uint relation_friend_max;

	[Token(Token = "0x6008128")]
	[Address(RVA = "0x33E1724", Offset = "0x33E1724", VA = "0x33E1724")]
	public RelationTypeInfoDesc()
	{
	}
}
