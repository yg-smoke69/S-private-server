using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001649")]
public class CSGetClanLuckyBagInfoRes
{
	[Token(Token = "0x40095C5")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanLuckyBag> lucky_bags;

	[Token(Token = "0x40095C6")]
	[FieldOffset(Offset = "0xC")]
	public List<LuckyBagDraw> draws;

	[Token(Token = "0x40095C7")]
	[FieldOffset(Offset = "0x10")]
	public List<ClanLuckyBag> big_lucky_bags;

	[Token(Token = "0x40095C8")]
	[FieldOffset(Offset = "0x14")]
	public List<LuckyBagDraw> drew_big_lucky_bags;

	[Token(Token = "0x40095C9")]
	[FieldOffset(Offset = "0x18")]
	public uint total_points;

	[Token(Token = "0x40095CA")]
	[FieldOffset(Offset = "0x20")]
	public long countdown_to_this_cycle;

	[Token(Token = "0x40095CB")]
	[FieldOffset(Offset = "0x28")]
	public bool is_reach_max_draw_num;

	[Token(Token = "0x40095CC")]
	[FieldOffset(Offset = "0x2C")]
	public uint batch_draw_lucky_bag_max_counts;

	[Token(Token = "0x6007C93")]
	[Address(RVA = "0x318302C", Offset = "0x318302C", VA = "0x318302C")]
	public CSGetClanLuckyBagInfoRes()
	{
	}
}
