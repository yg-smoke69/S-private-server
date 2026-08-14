using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200325D")]
internal class AccTeamData
{
	[Token(Token = "0x401329B")]
	[FieldOffset(Offset = "0x8")]
	public byte scTeamId;

	[Token(Token = "0x401329C")]
	[FieldOffset(Offset = "0xC")]
	public string teamName;

	[Token(Token = "0x401329D")]
	[FieldOffset(Offset = "0x10")]
	public string teamNameAbbr;

	[Token(Token = "0x401329E")]
	[FieldOffset(Offset = "0x14")]
	public uint liveCount;

	[Token(Token = "0x401329F")]
	[FieldOffset(Offset = "0x18")]
	public uint teamIcon;

	[Token(Token = "0x40132A0")]
	[FieldOffset(Offset = "0x1C")]
	public Color color;

	[Token(Token = "0x40132A1")]
	[FieldOffset(Offset = "0x2C")]
	public uint score;

	[Token(Token = "0x40132A2")]
	[FieldOffset(Offset = "0x30")]
	public uint rank;

	[Token(Token = "0x40132A3")]
	[FieldOffset(Offset = "0x34")]
	public uint prevrank;

	[Token(Token = "0x40132A4")]
	[FieldOffset(Offset = "0x38")]
	public uint killCnt;

	[Token(Token = "0x60153D1")]
	[Address(RVA = "0x14B7F14", Offset = "0x14B7F14", VA = "0x14B7F14")]
	public AccTeamData()
	{
	}
}
