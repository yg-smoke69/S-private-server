using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A2E")]
public class ClanLuckyBagConfigDesc
{
	[Token(Token = "0x400A3F7")]
	[FieldOffset(Offset = "0x8")]
	public uint effective_hours;

	[Token(Token = "0x400A3F8")]
	[FieldOffset(Offset = "0xC")]
	public uint max_draw_num_per_day;

	[Token(Token = "0x400A3F9")]
	[FieldOffset(Offset = "0x10")]
	public uint max_bags_per_clan;

	[Token(Token = "0x400A3FA")]
	[FieldOffset(Offset = "0x14")]
	public uint freeze_time;

	[Token(Token = "0x400A3FB")]
	[FieldOffset(Offset = "0x18")]
	public uint batch_draw_lucky_bag_max_counts;

	[Token(Token = "0x6008086")]
	[Address(RVA = "0x309BC94", Offset = "0x309BC94", VA = "0x309BC94")]
	public ClanLuckyBagConfigDesc()
	{
	}
}
