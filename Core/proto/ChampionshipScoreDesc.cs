using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AF6")]
public class ChampionshipScoreDesc
{
	[Token(Token = "0x400A999")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x400A99A")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x400A99B")]
	[FieldOffset(Offset = "0x10")]
	public uint rank_point;

	[Token(Token = "0x400A99C")]
	[FieldOffset(Offset = "0x14")]
	public uint game_mode;

	[Token(Token = "0x6008151")]
	[Address(RVA = "0x309AFE4", Offset = "0x309AFE4", VA = "0x309AFE4")]
	public ChampionshipScoreDesc()
	{
	}
}
