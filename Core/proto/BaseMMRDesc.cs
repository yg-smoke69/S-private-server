using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A3D")]
public class BaseMMRDesc
{
	[Token(Token = "0x400A451")]
	[FieldOffset(Offset = "0x8")]
	public uint player_max_mmr;

	[Token(Token = "0x400A452")]
	[FieldOffset(Offset = "0xC")]
	public uint player_min_mmr;

	[Token(Token = "0x400A453")]
	[FieldOffset(Offset = "0x10")]
	public uint new_player_default_mmr;

	[Token(Token = "0x400A454")]
	[FieldOffset(Offset = "0x14")]
	public int drop_match_punish_mmr;

	[Token(Token = "0x400A455")]
	[FieldOffset(Offset = "0x18")]
	public uint bot_point;

	[Token(Token = "0x400A456")]
	[FieldOffset(Offset = "0x1C")]
	public uint none_bot_mmr_separate;

	[Token(Token = "0x400A457")]
	[FieldOffset(Offset = "0x20")]
	public uint game_mode;

	[Token(Token = "0x400A458")]
	[FieldOffset(Offset = "0x24")]
	public bool use_new_rule;

	[Token(Token = "0x400A459")]
	[FieldOffset(Offset = "0x25")]
	public bool use_new_bot_rule;

	[Token(Token = "0x400A45A")]
	[FieldOffset(Offset = "0x28")]
	public uint fps_player_default_mmr;

	[Token(Token = "0x400A45B")]
	[FieldOffset(Offset = "0x2C")]
	public uint veteran_default_mmr;

	[Token(Token = "0x400A45C")]
	[FieldOffset(Offset = "0x30")]
	public uint bot_point_max_mmr;

	[Token(Token = "0x6008095")]
	[Address(RVA = "0x317B714", Offset = "0x317B714", VA = "0x317B714")]
	public BaseMMRDesc()
	{
	}
}
