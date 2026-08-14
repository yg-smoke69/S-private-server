using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002F3D")]
public class FastChampionshipTeamInvite : FastMessage
{
	[Token(Token = "0x40120A4")]
	[FieldOffset(Offset = "0x10")]
	public ulong TeamID;

	[Token(Token = "0x40120A5")]
	[FieldOffset(Offset = "0x18")]
	public uint ChampionshipType;

	[Token(Token = "0x40120A6")]
	[FieldOffset(Offset = "0x1C")]
	public uint ChampionshipID;

	[Token(Token = "0x40120A7")]
	[FieldOffset(Offset = "0x20")]
	public uint MemberNum;

	[Token(Token = "0x6013C2F")]
	[Address(RVA = "0xDE4A40", Offset = "0xDE4A40", VA = "0xDE4A40")]
	public FastChampionshipTeamInvite()
	{
	}
}
