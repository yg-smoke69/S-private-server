using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A75")]
public class RankingPointsScaleDesc
{
	[Token(Token = "0x400A598")]
	[FieldOffset(Offset = "0x8")]
	public uint lower_bound;

	[Token(Token = "0x400A599")]
	[FieldOffset(Offset = "0xC")]
	public uint upper_bound;

	[Token(Token = "0x400A59A")]
	[FieldOffset(Offset = "0x10")]
	public bool is_rank_open;

	[Token(Token = "0x400A59B")]
	[FieldOffset(Offset = "0x11")]
	public bool is_battle_open;

	[Token(Token = "0x400A59C")]
	[FieldOffset(Offset = "0x14")]
	public int positive_refer;

	[Token(Token = "0x400A59D")]
	[FieldOffset(Offset = "0x18")]
	public float positive_scale;

	[Token(Token = "0x400A59E")]
	[FieldOffset(Offset = "0x1C")]
	public int negative_refer;

	[Token(Token = "0x400A59F")]
	[FieldOffset(Offset = "0x20")]
	public float negative_scale;

	[Token(Token = "0x60080D2")]
	[Address(RVA = "0x33E0C64", Offset = "0x33E0C64", VA = "0x33E0C64")]
	public RankingPointsScaleDesc()
	{
	}
}
