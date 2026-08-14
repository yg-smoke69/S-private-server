using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20031E3")]
public class PersonalRecordData
{
	[Token(Token = "0x4012FD2")]
	[FieldOffset(Offset = "0x8")]
	public uint GamesPlayedTimes;

	[Token(Token = "0x4012FD3")]
	[FieldOffset(Offset = "0xC")]
	public uint WinTimes;

	[Token(Token = "0x4012FD4")]
	[FieldOffset(Offset = "0x10")]
	public uint KillTimes;

	[Token(Token = "0x4012FD5")]
	[FieldOffset(Offset = "0x14")]
	public uint DeathTimes;

	[Token(Token = "0x4012FD6")]
	[FieldOffset(Offset = "0x18")]
	public uint TopNTimes;

	[Token(Token = "0x4012FD7")]
	[FieldOffset(Offset = "0x1C")]
	public float TopNRate;

	[Token(Token = "0x4012FD8")]
	[FieldOffset(Offset = "0x20")]
	public float KDRatio;

	[Token(Token = "0x4012FD9")]
	[FieldOffset(Offset = "0x24")]
	public float AVGDistanceTrav;

	[Token(Token = "0x4012FDA")]
	[FieldOffset(Offset = "0x28")]
	public int AVGSurvivalTime;

	[Token(Token = "0x4012FDB")]
	[FieldOffset(Offset = "0x2C")]
	public uint Revives;

	[Token(Token = "0x4012FDC")]
	[FieldOffset(Offset = "0x30")]
	public uint MostKillsInMatch;

	[Token(Token = "0x4012FDD")]
	[FieldOffset(Offset = "0x34")]
	public int AVGDamagePerMatch;

	[Token(Token = "0x4012FDE")]
	[FieldOffset(Offset = "0x38")]
	public uint RoadKillTimes;

	[Token(Token = "0x4012FDF")]
	[FieldOffset(Offset = "0x3C")]
	public uint HeadShotTimes;

	[Token(Token = "0x4012FE0")]
	[FieldOffset(Offset = "0x40")]
	public float HeadShotRatio;

	[Token(Token = "0x4012FE1")]
	[FieldOffset(Offset = "0x44")]
	public uint KnockDownTimes;

	[Token(Token = "0x4012FE2")]
	[FieldOffset(Offset = "0x48")]
	public uint AVGLoots;

	[Token(Token = "0x4012FE3")]
	[FieldOffset(Offset = "0x4C")]
	public uint RankingPoints;

	[Token(Token = "0x4012FE4")]
	[FieldOffset(Offset = "0x50")]
	public float WinRate;

	[Token(Token = "0x4012FE5")]
	[FieldOffset(Offset = "0x54")]
	public float skill;

	[Token(Token = "0x4012FE6")]
	[FieldOffset(Offset = "0x58")]
	public float explore;

	[Token(Token = "0x60150C6")]
	[Address(RVA = "0x1BF9390", Offset = "0x1BF9390", VA = "0x1BF9390")]
	public PersonalRecordData()
	{
	}
}
