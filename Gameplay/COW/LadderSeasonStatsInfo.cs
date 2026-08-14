using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030CE")]
public class LadderSeasonStatsInfo
{
	[Token(Token = "0x40128F0")]
	[FieldOffset(Offset = "0x8")]
	public uint GamesPlayed;

	[Token(Token = "0x40128F1")]
	[FieldOffset(Offset = "0xC")]
	public uint MaxRank;

	[Token(Token = "0x40128F2")]
	[FieldOffset(Offset = "0x10")]
	public uint MaxRankPoint;

	[Token(Token = "0x40128F3")]
	[FieldOffset(Offset = "0x14")]
	public uint Wins;

	[Token(Token = "0x40128F4")]
	[FieldOffset(Offset = "0x18")]
	public uint Top10PercentTimes;

	[Token(Token = "0x40128F5")]
	[FieldOffset(Offset = "0x1C")]
	public uint Top50PercentTimes;

	[Token(Token = "0x40128F6")]
	[FieldOffset(Offset = "0x20")]
	public uint SurvivalTime;

	[Token(Token = "0x40128F7")]
	[FieldOffset(Offset = "0x24")]
	public uint MovingDistance;

	[Token(Token = "0x40128F8")]
	[FieldOffset(Offset = "0x28")]
	public uint Kills;

	[Token(Token = "0x40128F9")]
	[FieldOffset(Offset = "0x2C")]
	public uint Damage;

	[Token(Token = "0x40128FA")]
	[FieldOffset(Offset = "0x30")]
	public uint GameMostKill;

	[Token(Token = "0x40128FB")]
	[FieldOffset(Offset = "0x34")]
	public uint GameMostDamage;

	[Token(Token = "0x40128FC")]
	[FieldOffset(Offset = "0x38")]
	public uint HeadShotKill;

	[Token(Token = "0x40128FD")]
	[FieldOffset(Offset = "0x3C")]
	public uint Revivals;

	[Token(Token = "0x601471C")]
	[Address(RVA = "0x1EF71B0", Offset = "0x1EF71B0", VA = "0x1EF71B0")]
	public LadderSeasonStatsInfo()
	{
	}
}
