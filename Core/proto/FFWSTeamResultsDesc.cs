using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B8C")]
public class FFWSTeamResultsDesc
{
	[Token(Token = "0x400AD47")]
	[FieldOffset(Offset = "0x8")]
	public uint team_id;

	[Token(Token = "0x400AD48")]
	[FieldOffset(Offset = "0xC")]
	public uint[] scores;

	[Token(Token = "0x400AD49")]
	[FieldOffset(Offset = "0x10")]
	public bool is_champion;

	[Token(Token = "0x60081E7")]
	[Address(RVA = "0x30A095C", Offset = "0x30A095C", VA = "0x30A095C")]
	public FFWSTeamResultsDesc()
	{
	}
}
