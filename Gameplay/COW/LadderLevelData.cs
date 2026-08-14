using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000166")]
public class LadderLevelData
{
	[Token(Token = "0x40008FA")]
	[FieldOffset(Offset = "0x8")]
	public int Rank;

	[Token(Token = "0x40008FB")]
	[FieldOffset(Offset = "0xC")]
	public string RankName;

	[Token(Token = "0x40008FC")]
	[FieldOffset(Offset = "0x10")]
	public int LowerBound;

	[Token(Token = "0x40008FD")]
	[FieldOffset(Offset = "0x14")]
	public int UpperBound;

	[Token(Token = "0x40008FE")]
	[FieldOffset(Offset = "0x18")]
	public List<BaseItemInfo> AchieveAwardItemList;

	[Token(Token = "0x40008FF")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID IconRes;

	[Token(Token = "0x4000900")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID BigIconRes;

	[Token(Token = "0x4000901")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID LobbyIconRes;

	[Token(Token = "0x4000902")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID LadderSeasonRes;

	[Token(Token = "0x4000903")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID FullScreenRankUpRes;

	[Token(Token = "0x4000904")]
	[FieldOffset(Offset = "0x30")]
	public string FullScreenRankUpClipName;

	[Token(Token = "0x4000905")]
	[FieldOffset(Offset = "0x34")]
	public int RankGroup;

	[Token(Token = "0x4000906")]
	[FieldOffset(Offset = "0x38")]
	public int LobbyIconVFX;

	[Token(Token = "0x4000907")]
	[FieldOffset(Offset = "0x3C")]
	public bool IsPlayerLevel;

	[Token(Token = "0x4000908")]
	[FieldOffset(Offset = "0x3D")]
	public bool IsCurrentPlayerRankHigherThenRank;

	[Token(Token = "0x4000909")]
	[FieldOffset(Offset = "0x3E")]
	public bool IsCurrentPlayerRankHigherThenCurrentBigRank;

	[Token(Token = "0x400090A")]
	[FieldOffset(Offset = "0x40")]
	public uint CachedMaxRank;

	[Token(Token = "0x400090B")]
	[FieldOffset(Offset = "0x44")]
	public int RankMasterLevel;

	[Token(Token = "0x400090C")]
	[FieldOffset(Offset = "0x48")]
	public uint RankMasterUpperBound;

	[Token(Token = "0x400090D")]
	[FieldOffset(Offset = "0x4C")]
	public string RankMasterText;

	[Token(Token = "0x400090E")]
	[FieldOffset(Offset = "0x50")]
	public bool IsReachGrandMasterLevel;

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x1EEA8C0", Offset = "0x1EEA8C0", VA = "0x1EEA8C0")]
	public LadderLevelData(RankData rank_data)
	{
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x1EED450", Offset = "0x1EED450", VA = "0x1EED450")]
	public LadderLevelData(CSRankData rank_data)
	{
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0x1EED87C", Offset = "0x1EED87C", VA = "0x1EED87C")]
	public LadderLevelData(PeriodicRankData rank_data)
	{
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x1EEAF28", Offset = "0x1EEAF28", VA = "0x1EEAF28")]
	public void UpdateRewards(List<AwardDesc> levelRewards)
	{
	}
}
