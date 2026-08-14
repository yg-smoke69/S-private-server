using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002243")]
public struct TeamTotalStats
{
	[Token(Token = "0x400D625")]
	[FieldOffset(Offset = "0x0")]
	public int TotalKonckDown;

	[Token(Token = "0x400D626")]
	[FieldOffset(Offset = "0x4")]
	public int TotalHealing;

	[Token(Token = "0x400D627")]
	[FieldOffset(Offset = "0x8")]
	public int TotalRevival;

	[Token(Token = "0x400D628")]
	[FieldOffset(Offset = "0xC")]
	public int TotalResurrect;

	[Token(Token = "0x400D629")]
	[FieldOffset(Offset = "0x10")]
	public int TotalDamage;

	[Token(Token = "0x400D62A")]
	[FieldOffset(Offset = "0x14")]
	public int TotalEscortTime;
}
