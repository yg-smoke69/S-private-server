using COW.GamePlay;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002839")]
internal class InstantKillPlayerData
{
	[Token(Token = "0x400F82A")]
	[FieldOffset(Offset = "0x8")]
	public string NickName;

	[Token(Token = "0x400F82B")]
	[FieldOffset(Offset = "0x10")]
	public IHAAMHPPLMG playerID;

	[Token(Token = "0x400F82C")]
	[FieldOffset(Offset = "0x28")]
	public ulong UserID;

	[Token(Token = "0x600FB01")]
	[Address(RVA = "0x2C80980", Offset = "0x2C80980", VA = "0x2C80980")]
	public InstantKillPlayerData(string name, IHAAMHPPLMG id, ulong userID = 0uL)
	{
	}
}
