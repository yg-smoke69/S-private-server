using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200164E")]
public class CSBatchDrawClanLuckyBagRes
{
	[Token(Token = "0x40095DE")]
	[FieldOffset(Offset = "0x8")]
	public List<DrawClanLuckyBagResultInfo> result_infos;

	[Token(Token = "0x40095DF")]
	[FieldOffset(Offset = "0xC")]
	public uint awarded_points;

	[Token(Token = "0x40095E0")]
	[FieldOffset(Offset = "0x10")]
	public uint total_points;

	[Token(Token = "0x40095E1")]
	[FieldOffset(Offset = "0x14")]
	public AwardData award_datas;

	[Token(Token = "0x40095E2")]
	[FieldOffset(Offset = "0x18")]
	public bool is_double;

	[Token(Token = "0x40095E3")]
	[FieldOffset(Offset = "0x19")]
	public bool is_reach_max_draw_num;

	[Token(Token = "0x40095E4")]
	[FieldOffset(Offset = "0x1C")]
	public uint batch_draw_lucky_bag_max_counts;

	[Token(Token = "0x40095E5")]
	[FieldOffset(Offset = "0x20")]
	public bool is_reach_batch_draw_lucky_bag_max_counts;

	[Token(Token = "0x6007C98")]
	[Address(RVA = "0x317DDEC", Offset = "0x317DDEC", VA = "0x317DDEC")]
	public CSBatchDrawClanLuckyBagRes()
	{
	}
}
