using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200325F")]
internal class ResultTeamData
{
	[Token(Token = "0x40132A8")]
	[FieldOffset(Offset = "0x8")]
	public byte id;

	[Token(Token = "0x40132A9")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x40132AA")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40132AB")]
	[FieldOffset(Offset = "0x14")]
	public uint icon;

	[Token(Token = "0x40132AC")]
	[FieldOffset(Offset = "0x18")]
	public uint killCount;

	[Token(Token = "0x40132AD")]
	[FieldOffset(Offset = "0x1C")]
	public uint killScore;

	[Token(Token = "0x40132AE")]
	[FieldOffset(Offset = "0x20")]
	public uint rankScore;

	[Token(Token = "0x40132AF")]
	[FieldOffset(Offset = "0x24")]
	public uint totalScore;

	[Token(Token = "0x40132B0")]
	[FieldOffset(Offset = "0x28")]
	public uint winNum;

	[Token(Token = "0x40132B1")]
	[FieldOffset(Offset = "0x2C")]
	public List<ResultPlayerData> players;

	[Token(Token = "0x60153D3")]
	[Address(RVA = "0x2408CA8", Offset = "0x2408CA8", VA = "0x2408CA8")]
	public ResultTeamData()
	{
	}
}
