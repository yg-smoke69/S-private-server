using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B23")]
public class CSRankingAwardExhibitDesc
{
	[Token(Token = "0x400AA96")]
	[FieldOffset(Offset = "0x8")]
	public uint module;

	[Token(Token = "0x400AA97")]
	[FieldOffset(Offset = "0xC")]
	public uint[] id_award_exhibit;

	[Token(Token = "0x600817E")]
	[Address(RVA = "0x3098C78", Offset = "0x3098C78", VA = "0x3098C78")]
	public CSRankingAwardExhibitDesc()
	{
	}
}
