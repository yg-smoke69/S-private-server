using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A70")]
public class GameExpBonusDesc
{
	[Token(Token = "0x400A581")]
	[FieldOffset(Offset = "0x8")]
	public uint match_mode;

	[Token(Token = "0x400A582")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A583")]
	[FieldOffset(Offset = "0x10")]
	public uint level;

	[Token(Token = "0x400A584")]
	[FieldOffset(Offset = "0x14")]
	public float bonus_exp_ratio;

	[Token(Token = "0x400A585")]
	[FieldOffset(Offset = "0x18")]
	public uint bonus_exp_limit;

	[Token(Token = "0x60080CD")]
	[Address(RVA = "0x30A1984", Offset = "0x30A1984", VA = "0x30A1984")]
	public GameExpBonusDesc()
	{
	}
}
