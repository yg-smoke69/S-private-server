using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200325C")]
internal class RankingTeamData
{
	[Token(Token = "0x4013294")]
	[FieldOffset(Offset = "0x8")]
	public byte scTeamId;

	[Token(Token = "0x4013295")]
	[FieldOffset(Offset = "0xC")]
	public string teamName;

	[Token(Token = "0x4013296")]
	[FieldOffset(Offset = "0x10")]
	public uint teamIcon;

	[Token(Token = "0x4013297")]
	[FieldOffset(Offset = "0x14")]
	public Color color;

	[Token(Token = "0x4013298")]
	[FieldOffset(Offset = "0x24")]
	public uint liveCount;

	[Token(Token = "0x4013299")]
	[FieldOffset(Offset = "0x28")]
	public uint killCount;

	[Token(Token = "0x401329A")]
	[FieldOffset(Offset = "0x2C")]
	public uint combatLevel;

	[Token(Token = "0x60153D0")]
	[Address(RVA = "0x196E800", Offset = "0x196E800", VA = "0x196E800")]
	public RankingTeamData()
	{
	}
}
