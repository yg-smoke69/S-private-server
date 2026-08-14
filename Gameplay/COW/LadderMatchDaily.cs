using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030CA")]
public class LadderMatchDaily
{
	[Token(Token = "0x40128E0")]
	[FieldOffset(Offset = "0x8")]
	public uint firstWinRank;

	[Token(Token = "0x40128E1")]
	[FieldOffset(Offset = "0xC")]
	public uint firstWinKill;

	[Token(Token = "0x40128E2")]
	[FieldOffset(Offset = "0x10")]
	public float extratBonusRate;

	[Token(Token = "0x6014718")]
	[Address(RVA = "0x1EF16BC", Offset = "0x1EF16BC", VA = "0x1EF16BC")]
	public LadderMatchDaily()
	{
	}
}
