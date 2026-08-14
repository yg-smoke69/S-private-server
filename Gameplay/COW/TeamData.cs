using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200325B")]
internal class TeamData
{
	[Token(Token = "0x401328D")]
	[FieldOffset(Offset = "0x8")]
	public string teamName;

	[Token(Token = "0x401328E")]
	[FieldOffset(Offset = "0xC")]
	public string teamNameAbbr;

	[Token(Token = "0x401328F")]
	[FieldOffset(Offset = "0x10")]
	public byte gsTeamId;

	[Token(Token = "0x4013290")]
	[FieldOffset(Offset = "0x11")]
	public byte scTeamId;

	[Token(Token = "0x4013291")]
	[FieldOffset(Offset = "0x14")]
	public uint teamIcon;

	[Token(Token = "0x4013292")]
	[FieldOffset(Offset = "0x18")]
	public uint winNum;

	[Token(Token = "0x4013293")]
	[FieldOffset(Offset = "0x1C")]
	public List<PlayerData> playerList;

	[Token(Token = "0x60153CF")]
	[Address(RVA = "0x289D800", Offset = "0x289D800", VA = "0x289D800")]
	public TeamData()
	{
	}
}
