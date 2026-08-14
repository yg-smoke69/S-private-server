using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017AA")]
public class TeamSeasonStats
{
	[Token(Token = "0x4009B0C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009B0D")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B0E")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009B0F")]
	[FieldOffset(Offset = "0x18")]
	public uint kills;

	[Token(Token = "0x4009B10")]
	[FieldOffset(Offset = "0x1C")]
	public uint score;

	[Token(Token = "0x4009B11")]
	[FieldOffset(Offset = "0x20")]
	public uint pos;

	[Token(Token = "0x6007E04")]
	[Address(RVA = "0x33E3608", Offset = "0x33E3608", VA = "0x33E3608")]
	public TeamSeasonStats()
	{
	}
}
