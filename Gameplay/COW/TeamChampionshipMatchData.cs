using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200202E")]
public class TeamChampionshipMatchData
{
	[Token(Token = "0x400CA05")]
	[FieldOffset(Offset = "0x8")]
	public TeamChampionshipMatchStats matchStatus;

	[Token(Token = "0x400CA06")]
	[FieldOffset(Offset = "0xC")]
	public bool isValid;

	[Token(Token = "0x600A34C")]
	[Address(RVA = "0x289A9BC", Offset = "0x289A9BC", VA = "0x289A9BC")]
	public TeamChampionshipMatchData()
	{
	}
}
