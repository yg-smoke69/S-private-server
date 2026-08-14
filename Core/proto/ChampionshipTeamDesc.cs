using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF5")]
public class ChampionshipTeamDesc
{
	[Token(Token = "0x400A990")]
	[FieldOffset(Offset = "0x8")]
	public uint player_num_limit;

	[Token(Token = "0x400A991")]
	[FieldOffset(Offset = "0xC")]
	public uint limit_num;

	[Token(Token = "0x400A992")]
	[FieldOffset(Offset = "0x10")]
	public uint clean_time;

	[Token(Token = "0x400A993")]
	[FieldOffset(Offset = "0x14")]
	public uint player_apply_num;

	[Token(Token = "0x400A994")]
	[FieldOffset(Offset = "0x18")]
	public uint team_invite_num;

	[Token(Token = "0x400A995")]
	[FieldOffset(Offset = "0x1C")]
	public uint team_exit_cd;

	[Token(Token = "0x400A996")]
	[FieldOffset(Offset = "0x20")]
	public uint team_join_cd;

	[Token(Token = "0x400A997")]
	[FieldOffset(Offset = "0x24")]
	public uint team_scale_type;

	[Token(Token = "0x400A998")]
	[FieldOffset(Offset = "0x28")]
	public uint player_num_min;

	[Token(Token = "0x6008150")]
	[Address(RVA = "0x309B1BC", Offset = "0x309B1BC", VA = "0x309B1BC")]
	public ChampionshipTeamDesc()
	{
	}
}
