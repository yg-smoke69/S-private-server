using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016E6")]
public class GachaInfo
{
	[Token(Token = "0x400979A")]
	[FieldOffset(Offset = "0x8")]
	public uint chest_id;

	[Token(Token = "0x400979B")]
	[FieldOffset(Offset = "0xC")]
	public uint lottery_count_weekly;

	[Token(Token = "0x400979C")]
	[FieldOffset(Offset = "0x10")]
	public uint[] exchanged_reward_list;

	[Token(Token = "0x400979D")]
	[FieldOffset(Offset = "0x18")]
	public long next_free_time;

	[Token(Token = "0x400979E")]
	[FieldOffset(Offset = "0x20")]
	public uint not_got_num;

	[Token(Token = "0x400979F")]
	[FieldOffset(Offset = "0x24")]
	public uint limit_purchase_count_one;

	[Token(Token = "0x40097A0")]
	[FieldOffset(Offset = "0x28")]
	public uint limit_purchase_count_ten;

	[Token(Token = "0x40097A1")]
	[FieldOffset(Offset = "0x2C")]
	public uint first_draw_reward_num;

	[Token(Token = "0x6007D40")]
	[Address(RVA = "0x30A1770", Offset = "0x30A1770", VA = "0x30A1770")]
	public GachaInfo()
	{
	}
}
