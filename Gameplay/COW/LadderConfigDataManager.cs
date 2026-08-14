using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;
using proto;

namespace COW;

[Token(Token = "0x2002DE7")]
public class LadderConfigDataManager : SingletonModule<LadderConfigDataManager>
{
	[Token(Token = "0x2002DE8")]
	public enum RankEffectInGroup
	{
		[Token(Token = "0x40119D8")]
		Hide,
		[Token(Token = "0x40119D9")]
		Low,
		[Token(Token = "0x40119DA")]
		High
	}

	[Token(Token = "0x2002DE9")]
	private sealed class _003CGetPeriodicDataIconNameByRank_003Ec__AnonStorey0
	{
		[Token(Token = "0x40119DB")]
		[FieldOffset(Offset = "0x8")]
		internal int rank;

		[Token(Token = "0x601340E")]
		[Address(RVA = "0x1EEC054", Offset = "0x1EEC054", VA = "0x1EEC054")]
		public _003CGetPeriodicDataIconNameByRank_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601340F")]
		[Address(RVA = "0x1EF1504", Offset = "0x1EF1504", VA = "0x1EF1504")]
		internal bool _003C_003Em__0(LadderLevelData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DEA")]
	private sealed class _003CGetCSLevelDataIconNameByRank_003Ec__AnonStorey1
	{
		[Token(Token = "0x40119DC")]
		[FieldOffset(Offset = "0x8")]
		internal int rank;

		[Token(Token = "0x6013410")]
		[Address(RVA = "0x1EEC470", Offset = "0x1EEC470", VA = "0x1EEC470")]
		public _003CGetCSLevelDataIconNameByRank_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013411")]
		[Address(RVA = "0x1EF1254", Offset = "0x1EF1254", VA = "0x1EF1254")]
		internal bool _003C_003Em__0(LadderLevelData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DEB")]
	private sealed class _003CGetExhibitLevelData_003Ec__AnonStorey2
	{
		[Token(Token = "0x40119DD")]
		[FieldOffset(Offset = "0x8")]
		internal List<int> rankIDList;

		[Token(Token = "0x6013412")]
		[Address(RVA = "0x1EECE38", Offset = "0x1EECE38", VA = "0x1EECE38")]
		public _003CGetExhibitLevelData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013413")]
		[Address(RVA = "0x1EF12C4", Offset = "0x1EF12C4", VA = "0x1EF12C4")]
		internal bool _003C_003Em__0(LadderLevelData s)
		{
			return default(bool);
		}

		[Token(Token = "0x6013414")]
		[Address(RVA = "0x1EF1358", Offset = "0x1EF1358", VA = "0x1EF1358")]
		internal bool _003C_003Em__1(LadderLevelData s)
		{
			return default(bool);
		}

		[Token(Token = "0x6013415")]
		[Address(RVA = "0x1EF13EC", Offset = "0x1EF13EC", VA = "0x1EF13EC")]
		internal bool _003C_003Em__2(LadderLevelData s)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DEC")]
	private sealed class _003CGetUnlockRewardLevelData_003Ec__AnonStorey3
	{
		[Token(Token = "0x40119DE")]
		[FieldOffset(Offset = "0x8")]
		internal uint seasonResetRank;

		[Token(Token = "0x40119DF")]
		[FieldOffset(Offset = "0xC")]
		internal uint rankMasterLevel;

		[Token(Token = "0x6013416")]
		[Address(RVA = "0x1EED31C", Offset = "0x1EED31C", VA = "0x1EED31C")]
		public _003CGetUnlockRewardLevelData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6013417")]
		[Address(RVA = "0x1EF15B4", Offset = "0x1EF15B4", VA = "0x1EF15B4")]
		internal bool _003C_003Em__0(LadderLevelData data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DED")]
	private sealed class _003CGetRankCardDataByID_003Ec__AnonStorey4
	{
		[Token(Token = "0x40119E0")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6013418")]
		[Address(RVA = "0x1EEDC80", Offset = "0x1EEDC80", VA = "0x1EEDC80")]
		public _003CGetRankCardDataByID_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6013419")]
		[Address(RVA = "0x1EF153C", Offset = "0x1EF153C", VA = "0x1EF153C")]
		internal bool _003C_003Em__0(RankCardData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DEE")]
	private sealed class _003CIsRankCardLevelMeetRequirement_003Ec__AnonStorey5
	{
		[Token(Token = "0x40119E1")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x601341A")]
		[Address(RVA = "0x1EEE2AC", Offset = "0x1EEE2AC", VA = "0x1EEE2AC")]
		public _003CIsRankCardLevelMeetRequirement_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x601341B")]
		[Address(RVA = "0x1EF167C", Offset = "0x1EF167C", VA = "0x1EF167C")]
		internal bool _003C_003Em__0(RankCardData t)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DEF")]
	private sealed class _003CGetPeakRankData_003Ec__AnonStorey6
	{
		[Token(Token = "0x40119E2")]
		[FieldOffset(Offset = "0x8")]
		internal DGNDKMLMLPM rankType;

		[Token(Token = "0x40119E3")]
		[FieldOffset(Offset = "0xC")]
		internal int rankMasterLevel;

		[Token(Token = "0x601341C")]
		[Address(RVA = "0x1EEE56C", Offset = "0x1EEE56C", VA = "0x1EEE56C")]
		public _003CGetPeakRankData_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x601341D")]
		[Address(RVA = "0x1EF1480", Offset = "0x1EF1480", VA = "0x1EF1480")]
		internal bool _003C_003Em__0(PeakRankData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DF0")]
	private sealed class _003CGetPeakRankList_003Ec__AnonStorey7
	{
		[Token(Token = "0x40119E4")]
		[FieldOffset(Offset = "0x8")]
		internal DGNDKMLMLPM rankType;

		[Token(Token = "0x601341E")]
		[Address(RVA = "0x1EEE6F4", Offset = "0x1EEE6F4", VA = "0x1EEE6F4")]
		public _003CGetPeakRankList_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x601341F")]
		[Address(RVA = "0x1EF14CC", Offset = "0x1EF14CC", VA = "0x1EF14CC")]
		internal bool _003C_003Em__0(PeakRankData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DF1")]
	private sealed class _003CGetRankingSeasonInfo_003Ec__AnonStorey8
	{
		[Token(Token = "0x40119E5")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x6013420")]
		[Address(RVA = "0x1EEFFF8", Offset = "0x1EEFFF8", VA = "0x1EEFFF8")]
		public _003CGetRankingSeasonInfo_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6013421")]
		[Address(RVA = "0x1EF157C", Offset = "0x1EF157C", VA = "0x1EF157C")]
		internal bool _003C_003Em__0(RankingSeasonInfoData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002DF2")]
	private sealed class _003CGetCSRankingSeasonInfo_003Ec__AnonStorey9
	{
		[Token(Token = "0x40119E6")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x6013422")]
		[Address(RVA = "0x1EF0144", Offset = "0x1EF0144", VA = "0x1EF0144")]
		public _003CGetCSRankingSeasonInfo_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6013423")]
		[Address(RVA = "0x1EF128C", Offset = "0x1EF128C", VA = "0x1EF128C")]
		internal bool _003C_003Em__0(CSRankingSeasonInfoData x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x40119C0")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, LadderLevelData> m_LadderLevelDataDict;

	[Token(Token = "0x40119C1")]
	[FieldOffset(Offset = "0x10")]
	private List<RankCardData> m_RankingCardList;

	[Token(Token = "0x40119C2")]
	[FieldOffset(Offset = "0x14")]
	private List<PeakRankData> m_PeakRankList;

	[Token(Token = "0x40119C3")]
	[FieldOffset(Offset = "0x18")]
	private List<RankBRStarScoreData> m_RankBRStarScoreList;

	[Token(Token = "0x40119C4")]
	[FieldOffset(Offset = "0x1C")]
	private List<RankingSeasonInfoData> m_RankingSeasonInfo;

	[Token(Token = "0x40119C5")]
	[FieldOffset(Offset = "0x20")]
	private List<CSRankingSeasonInfoData> m_CSRankingSeasonInfo;

	[Token(Token = "0x40119C6")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, HeroicMarkData> m_HeroicMarkBRMap;

	[Token(Token = "0x40119C7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, HeroicMarkData> m_HeroicMarkCSMap;

	[Token(Token = "0x40119C8")]
	[FieldOffset(Offset = "0x2C")]
	private int m_MaxLadderRank;

	[Token(Token = "0x40119C9")]
	[FieldOffset(Offset = "0x30")]
	private List<LadderLevelData> m_CSLadderLevelDataList;

	[Token(Token = "0x40119CA")]
	[FieldOffset(Offset = "0x34")]
	private List<LadderLevelData> m_PeriodicLadderLevelDataList;

	[Token(Token = "0x40119CB")]
	[FieldOffset(Offset = "0x38")]
	private int m_CSFirstNoRewardRank;

	[Token(Token = "0x40119CC")]
	[FieldOffset(Offset = "0x3C")]
	private int m_BRFirstNoRewardRank;

	[Token(Token = "0x40119CD")]
	[FieldOffset(Offset = "0x40")]
	private int m_PeriodicFirstNoRewardRank;

	[Token(Token = "0x40119CE")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<LadderLevelData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40119CF")]
	[FieldOffset(Offset = "0x4")]
	private static Predicate<LadderLevelData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x40119D0")]
	[FieldOffset(Offset = "0x8")]
	private static Predicate<LadderLevelData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x40119D1")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<LadderLevelData> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x40119D2")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<LadderLevelData> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x40119D3")]
	[FieldOffset(Offset = "0x14")]
	private static Comparison<LadderLevelData> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x40119D4")]
	[FieldOffset(Offset = "0x18")]
	private static Predicate<RankCardData> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x40119D5")]
	[FieldOffset(Offset = "0x1C")]
	private static Predicate<RankCardData> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x40119D6")]
	[FieldOffset(Offset = "0x20")]
	private static Comparison<PeakRankData> _003C_003Ef__am_0024cache8;

	[Token(Token = "0x170013F3")]
	public int CSFirstNoRewardRank
	{
		[Token(Token = "0x60133CE")]
		[Address(RVA = "0x1EE93C0", Offset = "0x1EE93C0", VA = "0x1EE93C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013F4")]
	public int BRFirstNoRewardRank
	{
		[Token(Token = "0x60133CF")]
		[Address(RVA = "0x1EE9418", Offset = "0x1EE9418", VA = "0x1EE9418")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013F5")]
	public int PeriodicFirstNoRewardRank
	{
		[Token(Token = "0x60133D0")]
		[Address(RVA = "0x1EE9470", Offset = "0x1EE9470", VA = "0x1EE9470")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170013F6")]
	public int MaxLadderRank
	{
		[Token(Token = "0x60133D1")]
		[Address(RVA = "0x1EE94C8", Offset = "0x1EE94C8", VA = "0x1EE94C8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60133CD")]
	[Address(RVA = "0x1EE9150", Offset = "0x1EE9150", VA = "0x1EE9150")]
	public LadderConfigDataManager()
	{
	}

	[Token(Token = "0x60133D2")]
	[Address(RVA = "0x1EE9520", Offset = "0x1EE9520", VA = "0x1EE9520", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x60133D3")]
	[Address(RVA = "0x1EEACC0", Offset = "0x1EEACC0", VA = "0x1EEACC0")]
	public void UpdateRewards(Dictionary<uint, RankAwardsDesc> seasonAwards)
	{
	}

	[Token(Token = "0x60133D4")]
	[Address(RVA = "0x1EEB0E8", Offset = "0x1EEB0E8", VA = "0x1EEB0E8")]
	public void InitCSFirstNoRewardRank()
	{
	}

	[Token(Token = "0x60133D5")]
	[Address(RVA = "0x1EEAB60", Offset = "0x1EEAB60", VA = "0x1EEAB60")]
	public void InitBRFirstNoRewardRank()
	{
	}

	[Token(Token = "0x60133D6")]
	[Address(RVA = "0x1EEB7A4", Offset = "0x1EEB7A4", VA = "0x1EEB7A4")]
	public void InitPeriodicFirstNoRewardRank()
	{
	}

	[Token(Token = "0x60133D7")]
	[Address(RVA = "0x1EEBCB8", Offset = "0x1EEBCB8", VA = "0x1EEBCB8", Slot = "7")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x60133D8")]
	[Address(RVA = "0x1EEBE1C", Offset = "0x1EEBE1C", VA = "0x1EEBE1C")]
	public string GetPeriodicDataIconNameByRank(int rank)
	{
		return null;
	}

	[Token(Token = "0x60133D9")]
	[Address(RVA = "0x1EEC05C", Offset = "0x1EEC05C", VA = "0x1EEC05C")]
	public string GetBRLevelDataIconNameByRank(int rank)
	{
		return null;
	}

	[Token(Token = "0x60133DA")]
	[Address(RVA = "0x1EEC238", Offset = "0x1EEC238", VA = "0x1EEC238")]
	public string GetCSLevelDataIconNameByRank(int rank)
	{
		return null;
	}

	[Token(Token = "0x60133DB")]
	[Address(RVA = "0x1EEC478", Offset = "0x1EEC478", VA = "0x1EEC478")]
	public LadderLevelData GetLevelDataByRank(int rank)
	{
		return null;
	}

	[Token(Token = "0x60133DC")]
	[Address(RVA = "0x1EEC56C", Offset = "0x1EEC56C", VA = "0x1EEC56C")]
	public LadderLevelData GetNextLevelDataByRank(int rank)
	{
		return null;
	}

	[Token(Token = "0x60133DD")]
	[Address(RVA = "0x1EEC67C", Offset = "0x1EEC67C", VA = "0x1EEC67C")]
	public bool IsMaxRankLevel(int rank)
	{
		return default(bool);
	}

	[Token(Token = "0x60133DE")]
	[Address(RVA = "0x1EEC6F0", Offset = "0x1EEC6F0", VA = "0x1EEC6F0")]
	public Dictionary<int, List<BaseItemInfo>> GetRankResetAwards(List<int> resetRanks, DGNDKMLMLPM matchMode)
	{
		return null;
	}

	[Token(Token = "0x60133DF")]
	[Address(RVA = "0x1EECB24", Offset = "0x1EECB24", VA = "0x1EECB24")]
	public List<LadderLevelData> GetExhibitLevelData(DGNDKMLMLPM matchmode, uint[] exhitbitRanks)
	{
		return null;
	}

	[Token(Token = "0x60133E0")]
	[Address(RVA = "0x1EEB5F8", Offset = "0x1EEB5F8", VA = "0x1EEB5F8")]
	public List<LadderLevelData> GetAllLevelData()
	{
		return null;
	}

	[Token(Token = "0x60133E1")]
	[Address(RVA = "0x1EECE40", Offset = "0x1EECE40", VA = "0x1EECE40")]
	public List<BaseItemInfo> GetUnlockRewardLevelData(DGNDKMLMLPM matchMode, uint seasonResetRank, uint rankMasterLevel = 20u)
	{
		return null;
	}

	[Token(Token = "0x60133E2")]
	[Address(RVA = "0x1EEB24C", Offset = "0x1EEB24C", VA = "0x1EEB24C")]
	public List<LadderLevelData> GetAllCSLevelData()
	{
		return null;
	}

	[Token(Token = "0x60133E3")]
	[Address(RVA = "0x1EEB904", Offset = "0x1EEB904", VA = "0x1EEB904")]
	public List<LadderLevelData> GetAllPeriodicLevelData()
	{
		return null;
	}

	[Token(Token = "0x60133E4")]
	[Address(RVA = "0x1EEDB00", Offset = "0x1EEDB00", VA = "0x1EEDB00")]
	public RankCardData GetRankCardDataByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x60133E5")]
	[Address(RVA = "0x1EEDC88", Offset = "0x1EEDC88", VA = "0x1EEDC88")]
	public List<RankCardData> GetRankCardDataList()
	{
		return null;
	}

	[Token(Token = "0x60133E6")]
	[Address(RVA = "0x1EEDD54", Offset = "0x1EEDD54", VA = "0x1EEDD54")]
	public List<RankCardData> GetRankTimesRpConfigDataList()
	{
		return null;
	}

	[Token(Token = "0x60133E7")]
	[Address(RVA = "0x1EEDED8", Offset = "0x1EEDED8", VA = "0x1EEDED8")]
	public List<RankCardData> GetRankNoDeductCardConfigDataList()
	{
		return null;
	}

	[Token(Token = "0x60133E8")]
	[Address(RVA = "0x1EEE05C", Offset = "0x1EEE05C", VA = "0x1EEE05C")]
	public bool IsRankCardLevelMeetRequirement(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60133E9")]
	[Address(RVA = "0x1EEE2B4", Offset = "0x1EEE2B4", VA = "0x1EEE2B4")]
	public PeakRankData GetPeakRankData(DGNDKMLMLPM rankType = DGNDKMLMLPM.EMATCHMODE_RANKING, int rankMasterLevel = 0)
	{
		return null;
	}

	[Token(Token = "0x60133EA")]
	[Address(RVA = "0x1EEE574", Offset = "0x1EEE574", VA = "0x1EEE574")]
	public List<PeakRankData> GetPeakRankList(DGNDKMLMLPM rankType = DGNDKMLMLPM.EMATCHMODE_RANKING)
	{
		return null;
	}

	[Token(Token = "0x60133EB")]
	[Address(RVA = "0x1EEE6FC", Offset = "0x1EEE6FC", VA = "0x1EEE6FC")]
	public ERankCardType GetRankCardTypeById(int id)
	{
		return default(ERankCardType);
	}

	[Token(Token = "0x60133EC")]
	[Address(RVA = "0x1EEE8BC", Offset = "0x1EEE8BC", VA = "0x1EEE8BC")]
	public bool DoesRankBRHasStar(int rank)
	{
		return default(bool);
	}

	[Token(Token = "0x60133ED")]
	[Address(RVA = "0x1EEEA78", Offset = "0x1EEEA78", VA = "0x1EEEA78")]
	public ResourceID GetRankBRStarColorSprite(int rank)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60133EE")]
	[Address(RVA = "0x1EEEC68", Offset = "0x1EEEC68", VA = "0x1EEEC68")]
	private RankBRStarScoreData GetRankBRStarScoreData(int rank, int rankingPoint)
	{
		return null;
	}

	[Token(Token = "0x60133EF")]
	[Address(RVA = "0x1EEEF10", Offset = "0x1EEEF10", VA = "0x1EEEF10")]
	public uint GetRankBRStar(int rank, int rankingPoint)
	{
		return default(uint);
	}

	[Token(Token = "0x60133F0")]
	[Address(RVA = "0x1EEEFA8", Offset = "0x1EEEFA8", VA = "0x1EEEFA8")]
	public void GetRankBRStarBound(int rank, int rankingPoint, out int lowerBound, out int upperBound)
	{
	}

	[Token(Token = "0x60133F1")]
	[Address(RVA = "0x1EEF054", Offset = "0x1EEF054", VA = "0x1EEF054")]
	public uint[] GetRankBRStarLowerBounds(int rank)
	{
		return null;
	}

	[Token(Token = "0x60133F2")]
	[Address(RVA = "0x1EEF284", Offset = "0x1EEF284", VA = "0x1EEF284")]
	public int GetCSRankByRankPoint(int rankpoint)
	{
		return default(int);
	}

	[Token(Token = "0x60133F3")]
	[Address(RVA = "0x1EED324", Offset = "0x1EED324", VA = "0x1EED324")]
	public CSRankData GetCSRankDataByRank(int rankLevel)
	{
		return null;
	}

	[Token(Token = "0x60133F4")]
	[Address(RVA = "0x1EED6D4", Offset = "0x1EED6D4", VA = "0x1EED6D4")]
	public PeriodicRankData GetPeriodicRankDataByRank(int rankLevel)
	{
		return null;
	}

	[Token(Token = "0x60133F5")]
	[Address(RVA = "0x1EEF498", Offset = "0x1EEF498", VA = "0x1EEF498")]
	public int GetPeriodicRankStarCount(int rankLevel, int rankPoint)
	{
		return default(int);
	}

	[Token(Token = "0x60133F6")]
	[Address(RVA = "0x1EEF850", Offset = "0x1EEF850", VA = "0x1EEF850")]
	public int GetCSRankStarCount(int rankLevel, int rankPoint)
	{
		return default(int);
	}

	[Token(Token = "0x60133F7")]
	[Address(RVA = "0x1EEFA40", Offset = "0x1EEFA40", VA = "0x1EEFA40")]
	public uint GetCSMaxRankLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x60133F8")]
	[Address(RVA = "0x1EEF9D8", Offset = "0x1EEF9D8", VA = "0x1EEF9D8")]
	public uint GetCSHeroicRankLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x60133F9")]
	[Address(RVA = "0x1EEFC8C", Offset = "0x1EEFC8C", VA = "0x1EEFC8C")]
	public uint GetCSHeroicRankUpStar()
	{
		return default(uint);
	}

	[Token(Token = "0x60133FA")]
	[Address(RVA = "0x1EEFDC0", Offset = "0x1EEFDC0", VA = "0x1EEFDC0")]
	public uint GetCSHeroicRankLowerBound()
	{
		return default(uint);
	}

	[Token(Token = "0x60133FB")]
	[Address(RVA = "0x1EEFE3C", Offset = "0x1EEFE3C", VA = "0x1EEFE3C")]
	public bool HaveReachedCSHeroicRankLevel(uint level)
	{
		return default(bool);
	}

	[Token(Token = "0x60133FC")]
	[Address(RVA = "0x1EEF56C", Offset = "0x1EEF56C", VA = "0x1EEF56C")]
	public uint GetPeriodicMaxRankLevel()
	{
		return default(uint);
	}

	[Token(Token = "0x60133FD")]
	[Address(RVA = "0x1EEFEB4", Offset = "0x1EEFEB4", VA = "0x1EEFEB4")]
	public RankingSeasonInfoData GetRankingSeasonInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x60133FE")]
	[Address(RVA = "0x1EF0000", Offset = "0x1EF0000", VA = "0x1EF0000")]
	public CSRankingSeasonInfoData GetCSRankingSeasonInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x60133FF")]
	[Address(RVA = "0x1EF014C", Offset = "0x1EF014C", VA = "0x1EF014C")]
	public int GetStarNumByRankAndRankPoint(int rank, int rankpoint)
	{
		return default(int);
	}

	[Token(Token = "0x6013400")]
	[Address(RVA = "0x1EF01EC", Offset = "0x1EF01EC", VA = "0x1EF01EC")]
	public ResourceID GetFullScreenAnimationResIdByRank(int rank, DGNDKMLMLPM matchMode)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6013401")]
	[Address(RVA = "0x1EF0498", Offset = "0x1EF0498", VA = "0x1EF0498")]
	public string GetFullScreenAnimationClipNameByRank(int rank, DGNDKMLMLPM matchMode)
	{
		return null;
	}

	[Token(Token = "0x6013402")]
	[Address(RVA = "0x1EF0728", Offset = "0x1EF0728", VA = "0x1EF0728")]
	public RankEffectInGroup GetRankEffectInGroup(uint rank, uint peak_rank_pos, uint type)
	{
		return default(RankEffectInGroup);
	}

	[Token(Token = "0x6013403")]
	[Address(RVA = "0x1EF0968", Offset = "0x1EF0968", VA = "0x1EF0968")]
	public HeroicMarkData GetHeroicMarkData(EHeroicMarkType t, uint val)
	{
		return null;
	}

	[Token(Token = "0x6013404")]
	[Address(RVA = "0x1EF0A88", Offset = "0x1EF0A88", VA = "0x1EF0A88")]
	public GameObject SetHeroicEffect(ResourceID resID, Transform trans, int depth)
	{
		return null;
	}

	[Token(Token = "0x6013405")]
	[Address(RVA = "0x1EF0F10", Offset = "0x1EF0F10", VA = "0x1EF0F10")]
	private static bool _003CInitCSFirstNoRewardRank_003Em__0(LadderLevelData t)
	{
		return default(bool);
	}

	[Token(Token = "0x6013406")]
	[Address(RVA = "0x1EF0FA8", Offset = "0x1EF0FA8", VA = "0x1EF0FA8")]
	private static bool _003CInitBRFirstNoRewardRank_003Em__1(LadderLevelData t)
	{
		return default(bool);
	}

	[Token(Token = "0x6013407")]
	[Address(RVA = "0x1EF1040", Offset = "0x1EF1040", VA = "0x1EF1040")]
	private static bool _003CInitPeriodicFirstNoRewardRank_003Em__2(LadderLevelData t)
	{
		return default(bool);
	}

	[Token(Token = "0x6013408")]
	[Address(RVA = "0x1EF10D8", Offset = "0x1EF10D8", VA = "0x1EF10D8")]
	private static int _003CGetAllLevelData_003Em__3(LadderLevelData a, LadderLevelData b)
	{
		return default(int);
	}

	[Token(Token = "0x6013409")]
	[Address(RVA = "0x1EF1120", Offset = "0x1EF1120", VA = "0x1EF1120")]
	private static int _003CGetAllCSLevelData_003Em__4(LadderLevelData a, LadderLevelData b)
	{
		return default(int);
	}

	[Token(Token = "0x601340A")]
	[Address(RVA = "0x1EF1168", Offset = "0x1EF1168", VA = "0x1EF1168")]
	private static int _003CGetAllPeriodicLevelData_003Em__5(LadderLevelData a, LadderLevelData b)
	{
		return default(int);
	}

	[Token(Token = "0x601340B")]
	[Address(RVA = "0x1EF11B0", Offset = "0x1EF11B0", VA = "0x1EF11B0")]
	private static bool _003CGetRankTimesRpConfigDataList_003Em__6(RankCardData t)
	{
		return default(bool);
	}

	[Token(Token = "0x601340C")]
	[Address(RVA = "0x1EF11E0", Offset = "0x1EF11E0", VA = "0x1EF11E0")]
	private static bool _003CGetRankNoDeductCardConfigDataList_003Em__7(RankCardData t)
	{
		return default(bool);
	}

	[Token(Token = "0x601340D")]
	[Address(RVA = "0x1EF120C", Offset = "0x1EF120C", VA = "0x1EF120C")]
	private static int _003CGetPeakRankData_003Em__8(PeakRankData a, PeakRankData b)
	{
		return default(int);
	}
}
