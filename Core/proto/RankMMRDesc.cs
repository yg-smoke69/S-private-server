using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A3A")]
public class RankMMRDesc
{
	[Token(Token = "0x400A42F")]
	[FieldOffset(Offset = "0x8")]
	public uint rank_percent_start;

	[Token(Token = "0x400A430")]
	[FieldOffset(Offset = "0xC")]
	public uint rank_percent_end;

	[Token(Token = "0x400A431")]
	[FieldOffset(Offset = "0x10")]
	public int mmr_delta;

	[Token(Token = "0x400A432")]
	[FieldOffset(Offset = "0x14")]
	public uint con_win_cnt;

	[Token(Token = "0x400A433")]
	[FieldOffset(Offset = "0x18")]
	public int con_win_mmr;

	[Token(Token = "0x400A434")]
	[FieldOffset(Offset = "0x1C")]
	public int bot_point_percent;

	[Token(Token = "0x400A435")]
	[FieldOffset(Offset = "0x20")]
	public uint game_mode;

	[Token(Token = "0x400A436")]
	[FieldOffset(Offset = "0x24")]
	public uint map_id;

	[Token(Token = "0x400A437")]
	[FieldOffset(Offset = "0x28")]
	public uint mmr_start;

	[Token(Token = "0x400A438")]
	[FieldOffset(Offset = "0x2C")]
	public uint mmr_end;

	[Token(Token = "0x400A439")]
	[FieldOffset(Offset = "0x30")]
	public int rank_point_add_lower;

	[Token(Token = "0x400A43A")]
	[FieldOffset(Offset = "0x34")]
	public int rank_point_add_upper;

	[Token(Token = "0x400A43B")]
	[FieldOffset(Offset = "0x38")]
	public int bot_point;

	[Token(Token = "0x400A43C")]
	[FieldOffset(Offset = "0x3C")]
	public uint cs_mvp_bot_point_const;

	[Token(Token = "0x400A43D")]
	[FieldOffset(Offset = "0x40")]
	public int ingame_bot_point;

	[Token(Token = "0x6008092")]
	[Address(RVA = "0x33E09A0", Offset = "0x33E09A0", VA = "0x33E09A0")]
	public RankMMRDesc()
	{
	}
}
