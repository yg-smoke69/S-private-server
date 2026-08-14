using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030CB")]
public struct LatestRankInfo
{
	[Token(Token = "0x40128E3")]
	[FieldOffset(Offset = "0x0")]
	public bool IsRanking;

	[Token(Token = "0x40128E4")]
	[FieldOffset(Offset = "0x4")]
	public uint RankBefore;

	[Token(Token = "0x40128E5")]
	[FieldOffset(Offset = "0x8")]
	public uint RankAfter;

	[Token(Token = "0x40128E6")]
	[FieldOffset(Offset = "0xC")]
	public int PointsBefore;

	[Token(Token = "0x40128E7")]
	[FieldOffset(Offset = "0x10")]
	public int PointsAfter;

	[Token(Token = "0x40128E8")]
	[FieldOffset(Offset = "0x14")]
	public int PeakRankPosBefore;

	[Token(Token = "0x40128E9")]
	[FieldOffset(Offset = "0x18")]
	public int PeakRankPosAfter;

	[Token(Token = "0x40128EA")]
	[FieldOffset(Offset = "0x1C")]
	public int PlayTimes;
}
