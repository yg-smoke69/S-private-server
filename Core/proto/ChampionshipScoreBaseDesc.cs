using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF7")]
public class ChampionshipScoreBaseDesc
{
	[Token(Token = "0x400A99D")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A99E")]
	[FieldOffset(Offset = "0xC")]
	public uint first_ranking_point;

	[Token(Token = "0x400A99F")]
	[FieldOffset(Offset = "0x10")]
	public uint knock_down_points;

	[Token(Token = "0x400A9A0")]
	[FieldOffset(Offset = "0x14")]
	public uint revive_points;

	[Token(Token = "0x400A9A1")]
	[FieldOffset(Offset = "0x18")]
	public uint damage_per_get;

	[Token(Token = "0x400A9A2")]
	[FieldOffset(Offset = "0x1C")]
	public uint damage_score;

	[Token(Token = "0x400A9A3")]
	[FieldOffset(Offset = "0x20")]
	public uint alive_per_get;

	[Token(Token = "0x400A9A4")]
	[FieldOffset(Offset = "0x24")]
	public uint alive_score;

	[Token(Token = "0x400A9A5")]
	[FieldOffset(Offset = "0x28")]
	public float ranking_extra_coins;

	[Token(Token = "0x400A9A6")]
	[FieldOffset(Offset = "0x2C")]
	public float ranking_extra_exps;

	[Token(Token = "0x400A9A7")]
	[FieldOffset(Offset = "0x30")]
	public int birth_island_quit_deduct;

	[Token(Token = "0x400A9A8")]
	[FieldOffset(Offset = "0x34")]
	public uint kill_points;

	[Token(Token = "0x400A9A9")]
	[FieldOffset(Offset = "0x38")]
	public uint game_mode;

	[Token(Token = "0x6008152")]
	[Address(RVA = "0x309AFDC", Offset = "0x309AFDC", VA = "0x309AFDC")]
	public ChampionshipScoreBaseDesc()
	{
	}
}
