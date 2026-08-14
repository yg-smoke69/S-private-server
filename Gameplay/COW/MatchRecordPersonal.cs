using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031E4")]
public class MatchRecordPersonal
{
	[Token(Token = "0x4012FE7")]
	[FieldOffset(Offset = "0x8")]
	public uint Ranking;

	[Token(Token = "0x4012FE8")]
	[FieldOffset(Offset = "0x10")]
	public ulong MatchID;

	[Token(Token = "0x4012FE9")]
	[FieldOffset(Offset = "0x18")]
	public uint MatchMode;

	[Token(Token = "0x4012FEA")]
	[FieldOffset(Offset = "0x1C")]
	public uint GameMode;

	[Token(Token = "0x4012FEB")]
	[FieldOffset(Offset = "0x20")]
	public uint MapID;

	[Token(Token = "0x4012FEC")]
	[FieldOffset(Offset = "0x24")]
	public uint GroupMode;

	[Token(Token = "0x4012FED")]
	[FieldOffset(Offset = "0x28")]
	public uint TotalRanking;

	[Token(Token = "0x4012FEE")]
	[FieldOffset(Offset = "0x2C")]
	public int Rating;

	[Token(Token = "0x4012FEF")]
	[FieldOffset(Offset = "0x30")]
	public int DeltaRating;

	[Token(Token = "0x4012FF0")]
	[FieldOffset(Offset = "0x34")]
	public uint Kills;

	[Token(Token = "0x4012FF1")]
	[FieldOffset(Offset = "0x38")]
	public ulong EndMatchTimeStamp;

	[Token(Token = "0x4012FF2")]
	[FieldOffset(Offset = "0x40")]
	public uint Revive;

	[Token(Token = "0x4012FF3")]
	[FieldOffset(Offset = "0x44")]
	public uint Knockdown;

	[Token(Token = "0x4012FF4")]
	[FieldOffset(Offset = "0x48")]
	public uint Healing;

	[Token(Token = "0x4012FF5")]
	[FieldOffset(Offset = "0x4C")]
	public uint Resurrect;

	[Token(Token = "0x4012FF6")]
	[FieldOffset(Offset = "0x50")]
	public uint SurvivalTime;

	[Token(Token = "0x4012FF7")]
	[FieldOffset(Offset = "0x54")]
	public uint HeadShoot;

	[Token(Token = "0x4012FF8")]
	[FieldOffset(Offset = "0x58")]
	public uint Damage;

	[Token(Token = "0x4012FF9")]
	[FieldOffset(Offset = "0x5C")]
	public bool IsAlive;

	[Token(Token = "0x4012FFA")]
	[FieldOffset(Offset = "0x60")]
	public uint Deaths;

	[Token(Token = "0x4012FFB")]
	[FieldOffset(Offset = "0x64")]
	public uint Arms;

	[Token(Token = "0x4012FFC")]
	[FieldOffset(Offset = "0x68")]
	public AchievementData AchvData;

	[Token(Token = "0x4012FFD")]
	[FieldOffset(Offset = "0x6C")]
	public List<TeammateStats> TeammateList;

	[Token(Token = "0x4012FFE")]
	[FieldOffset(Offset = "0x70")]
	public uint championshipType;

	[Token(Token = "0x4012FFF")]
	[FieldOffset(Offset = "0x74")]
	public MatchStats mystats;

	[Token(Token = "0x4013000")]
	[FieldOffset(Offset = "0x78")]
	public WerewolvesInfo werewolvesInfo;

	[Token(Token = "0x1700162F")]
	public string MapName
	{
		[Token(Token = "0x60150C8")]
		[Address(RVA = "0x1544798", Offset = "0x1544798", VA = "0x1544798")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60150C7")]
	[Address(RVA = "0x15444D4", Offset = "0x15444D4", VA = "0x15444D4")]
	public MatchRecordPersonal(MatchAccountStats matchAccountStats)
	{
	}
}
