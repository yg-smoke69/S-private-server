using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002FD5")]
public class CSLadderSeasonStatsInfo
{
	[Token(Token = "0x4012352")]
	[FieldOffset(Offset = "0x8")]
	public uint GamesPlayed;

	[Token(Token = "0x4012353")]
	[FieldOffset(Offset = "0xC")]
	public uint Wins;

	[Token(Token = "0x4012354")]
	[FieldOffset(Offset = "0x10")]
	public uint Deaths;

	[Token(Token = "0x4012355")]
	[FieldOffset(Offset = "0x14")]
	public uint Assists;

	[Token(Token = "0x4012356")]
	[FieldOffset(Offset = "0x18")]
	public uint MvpCount;

	[Token(Token = "0x4012357")]
	[FieldOffset(Offset = "0x1C")]
	public uint Kills;

	[Token(Token = "0x4012358")]
	[FieldOffset(Offset = "0x20")]
	public uint DoubleKills;

	[Token(Token = "0x4012359")]
	[FieldOffset(Offset = "0x24")]
	public uint TripleKills;

	[Token(Token = "0x401235A")]
	[FieldOffset(Offset = "0x28")]
	public uint FourKills;

	[Token(Token = "0x401235B")]
	[FieldOffset(Offset = "0x2C")]
	public uint Damages;

	[Token(Token = "0x401235C")]
	[FieldOffset(Offset = "0x30")]
	public uint HeadShotKills;

	[Token(Token = "0x401235D")]
	[FieldOffset(Offset = "0x34")]
	public uint KnockDowns;

	[Token(Token = "0x401235E")]
	[FieldOffset(Offset = "0x38")]
	public uint Revivals;

	[Token(Token = "0x6013FC4")]
	[Address(RVA = "0x1820CE4", Offset = "0x1820CE4", VA = "0x1820CE4")]
	public CSLadderSeasonStatsInfo()
	{
	}
}
