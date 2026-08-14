using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016D5")]
public class CSLotteryRes
{
	[Token(Token = "0x4009768")]
	[FieldOffset(Offset = "0x8")]
	public List<ExchangedAward> lottery_goods;

	[Token(Token = "0x4009769")]
	[FieldOffset(Offset = "0xC")]
	public List<ExchangedAward> reward_goods;

	[Token(Token = "0x400976A")]
	[FieldOffset(Offset = "0x10")]
	public List<ExchangedAward> extra_one_goods;

	[Token(Token = "0x400976B")]
	[FieldOffset(Offset = "0x14")]
	public uint lottery_count_weekly;

	[Token(Token = "0x400976C")]
	[FieldOffset(Offset = "0x18")]
	public long next_free_time;

	[Token(Token = "0x400976D")]
	[FieldOffset(Offset = "0x20")]
	public uint limit_purchase_count_one;

	[Token(Token = "0x400976E")]
	[FieldOffset(Offset = "0x24")]
	public uint limit_purchase_count_ten;

	[Token(Token = "0x400976F")]
	[FieldOffset(Offset = "0x28")]
	public uint not_got_num;

	[Token(Token = "0x4009770")]
	[FieldOffset(Offset = "0x2C")]
	public uint first_draw_reward_num;

	[Token(Token = "0x4009771")]
	[FieldOffset(Offset = "0x30")]
	public List<ExchangeItemNum> exchange_item_num;

	[Token(Token = "0x4009772")]
	[FieldOffset(Offset = "0x34")]
	public bool has_big_reward;

	[Token(Token = "0x4009773")]
	[FieldOffset(Offset = "0x38")]
	public uint[] act_goods_ids;

	[Token(Token = "0x4009774")]
	[FieldOffset(Offset = "0x3C")]
	public uint act_progress;

	[Token(Token = "0x4009775")]
	[FieldOffset(Offset = "0x40")]
	public uint energy_gacha_buff_display_one;

	[Token(Token = "0x4009776")]
	[FieldOffset(Offset = "0x44")]
	public uint energy_gacha_buff_display_ten;

	[Token(Token = "0x6007D2F")]
	[Address(RVA = "0x30977B8", Offset = "0x30977B8", VA = "0x30977B8")]
	public CSLotteryRes()
	{
	}
}
