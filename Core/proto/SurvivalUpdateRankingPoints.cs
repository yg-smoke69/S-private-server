using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A48")]
public class SurvivalUpdateRankingPoints
{
	[Token(Token = "0x400A4A2")]
	[FieldOffset(Offset = "0x8")]
	public uint index;

	[Token(Token = "0x400A4A3")]
	[FieldOffset(Offset = "0xC")]
	public int solo;

	[Token(Token = "0x400A4A4")]
	[FieldOffset(Offset = "0x10")]
	public int dual;

	[Token(Token = "0x400A4A5")]
	[FieldOffset(Offset = "0x14")]
	public int squad;

	[Token(Token = "0x60080A0")]
	[Address(RVA = "0x33E3098", Offset = "0x33E3098", VA = "0x33E3098")]
	public SurvivalUpdateRankingPoints()
	{
	}
}
