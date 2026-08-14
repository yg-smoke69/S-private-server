using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A49")]
public class RankingAwardExhibitDesc
{
	[Token(Token = "0x400A4A6")]
	[FieldOffset(Offset = "0x8")]
	public uint module;

	[Token(Token = "0x400A4A7")]
	[FieldOffset(Offset = "0xC")]
	public uint[] id_award_exhibit;

	[Token(Token = "0x60080A1")]
	[Address(RVA = "0x33E0AF4", Offset = "0x33E0AF4", VA = "0x33E0AF4")]
	public RankingAwardExhibitDesc()
	{
	}
}
