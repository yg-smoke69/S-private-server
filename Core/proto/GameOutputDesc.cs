using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A41")]
public class GameOutputDesc
{
	[Token(Token = "0x400A468")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400A469")]
	[FieldOffset(Offset = "0xC")]
	public uint time_limit_gp;

	[Token(Token = "0x400A46A")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_factor_gp;

	[Token(Token = "0x400A46B")]
	[FieldOffset(Offset = "0x14")]
	public uint mode_factor_gp;

	[Token(Token = "0x400A46C")]
	[FieldOffset(Offset = "0x18")]
	public uint chicken_factor_gp;

	[Token(Token = "0x400A46D")]
	[FieldOffset(Offset = "0x1C")]
	public uint time_limit_xp;

	[Token(Token = "0x400A46E")]
	[FieldOffset(Offset = "0x20")]
	public uint rank_factor_xp;

	[Token(Token = "0x400A46F")]
	[FieldOffset(Offset = "0x24")]
	public uint mode_factor_xp;

	[Token(Token = "0x400A470")]
	[FieldOffset(Offset = "0x28")]
	public uint chicken_factor_xp;

	[Token(Token = "0x400A471")]
	[FieldOffset(Offset = "0x2C")]
	public uint game_mode;

	[Token(Token = "0x400A472")]
	[FieldOffset(Offset = "0x30")]
	public uint map_id;

	[Token(Token = "0x6008099")]
	[Address(RVA = "0x30A1C90", Offset = "0x30A1C90", VA = "0x30A1C90")]
	public GameOutputDesc()
	{
	}
}
