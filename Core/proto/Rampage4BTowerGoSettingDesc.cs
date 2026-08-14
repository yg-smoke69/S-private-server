using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C0F")]
public class Rampage4BTowerGoSettingDesc
{
	[Token(Token = "0x400B084")]
	[FieldOffset(Offset = "0x8")]
	public uint hyper_per_move;

	[Token(Token = "0x400B085")]
	[FieldOffset(Offset = "0xC")]
	public AwardDesc box_award;

	[Token(Token = "0x400B086")]
	[FieldOffset(Offset = "0x10")]
	public uint double_buff_weight;

	[Token(Token = "0x400B087")]
	[FieldOffset(Offset = "0x14")]
	public uint triple_buff_weight;

	[Token(Token = "0x400B088")]
	[FieldOffset(Offset = "0x18")]
	public uint quadra_buff_weight;

	[Token(Token = "0x400B089")]
	[FieldOffset(Offset = "0x20")]
	public long buff_time;

	[Token(Token = "0x400B08A")]
	[FieldOffset(Offset = "0x28")]
	public uint book_token_id;

	[Token(Token = "0x400B08B")]
	[FieldOffset(Offset = "0x2C")]
	public uint book_token_type;

	[Token(Token = "0x400B08C")]
	[FieldOffset(Offset = "0x30")]
	public uint book_token_num1;

	[Token(Token = "0x400B08D")]
	[FieldOffset(Offset = "0x34")]
	public uint book_token_num1_weight;

	[Token(Token = "0x400B08E")]
	[FieldOffset(Offset = "0x38")]
	public uint book_token_num2;

	[Token(Token = "0x400B08F")]
	[FieldOffset(Offset = "0x3C")]
	public uint book_token_num2_weight;

	[Token(Token = "0x400B090")]
	[FieldOffset(Offset = "0x40")]
	public uint book_token_num3;

	[Token(Token = "0x400B091")]
	[FieldOffset(Offset = "0x44")]
	public uint book_token_num3_weight;

	[Token(Token = "0x400B092")]
	[FieldOffset(Offset = "0x48")]
	public AwardDesc boss1_award;

	[Token(Token = "0x400B093")]
	[FieldOffset(Offset = "0x4C")]
	public AwardDesc boss2_award;

	[Token(Token = "0x400B094")]
	[FieldOffset(Offset = "0x50")]
	public AwardDesc boss3_award;

	[Token(Token = "0x400B095")]
	[FieldOffset(Offset = "0x54")]
	public uint max_hyper_value_per_day;

	[Token(Token = "0x6008269")]
	[Address(RVA = "0x33E03D4", Offset = "0x33E03D4", VA = "0x33E03D4")]
	public Rampage4BTowerGoSettingDesc()
	{
	}
}
