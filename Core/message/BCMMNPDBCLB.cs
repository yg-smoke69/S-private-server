using Il2CppDummyDll;

namespace message;

[Token(Token = "0x2000DB2")]
public enum BCMMNPDBCLB : uint
{
	[Token(Token = "0x400719B")]
	EDMMMatchPhase_Prepare = 1u,
	[Token(Token = "0x400719C")]
	EDMMMatchPhase_Fight,
	[Token(Token = "0x400719D")]
	EDMMMatchPhase_Fever,
	[Token(Token = "0x400719E")]
	EDMMMatchPhase_Post
}
