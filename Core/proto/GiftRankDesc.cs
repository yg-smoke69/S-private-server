using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AA8")]
public class GiftRankDesc
{
	[Token(Token = "0x400A786")]
	[FieldOffset(Offset = "0x8")]
	public uint rank_id;

	[Token(Token = "0x400A787")]
	[FieldOffset(Offset = "0xC")]
	public string rank_name;

	[Token(Token = "0x400A788")]
	[FieldOffset(Offset = "0x10")]
	public string open_time;

	[Token(Token = "0x400A789")]
	[FieldOffset(Offset = "0x14")]
	public string close_time;

	[Token(Token = "0x400A78A")]
	[FieldOffset(Offset = "0x18")]
	public bool is_time_show;

	[Token(Token = "0x400A78B")]
	[FieldOffset(Offset = "0x1C")]
	public uint giver_item_id;

	[Token(Token = "0x400A78C")]
	[FieldOffset(Offset = "0x20")]
	public uint receiver_item_id;

	[Token(Token = "0x400A78D")]
	[FieldOffset(Offset = "0x24")]
	public uint gift_ratio;

	[Token(Token = "0x6008105")]
	[Address(RVA = "0x30A2410", Offset = "0x30A2410", VA = "0x30A2410")]
	public GiftRankDesc()
	{
	}
}
