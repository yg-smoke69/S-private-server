using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x2003159")]
public class UIModelMapOpeningInfo : UIBaseModel, _Attribute
{
	[Token(Token = "0x200315A")]
	public class GameModeSortData
	{
		[Token(Token = "0x4012BF1")]
		[FieldOffset(Offset = "0x8")]
		public uint sort_id;

		[Token(Token = "0x4012BF2")]
		[FieldOffset(Offset = "0xC")]
		public List<MapModeData> mapmode_list;

		[Token(Token = "0x6014B5E")]
		[Address(RVA = "0xE5303C", Offset = "0xE5303C", VA = "0xE5303C")]
		public GameModeSortData()
		{
		}
	}

	[Token(Token = "0x200315B")]
	public struct ModesPickMoreMaps
	{
		[Token(Token = "0x4012BF3")]
		[FieldOffset(Offset = "0x0")]
		public uint GameMode;

		[Token(Token = "0x4012BF4")]
		[FieldOffset(Offset = "0x4")]
		public uint MatchMode;
	}

	[Token(Token = "0x200315C")]
	private sealed class _003CUpdateSelectedMapData_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012BF5")]
		[FieldOffset(Offset = "0x8")]
		internal uint matchMode;

		[Token(Token = "0x4012BF6")]
		[FieldOffset(Offset = "0xC")]
		internal uint gameMode;

		[Token(Token = "0x4012BF7")]
		[FieldOffset(Offset = "0x10")]
		internal uint mapMode;

		[Token(Token = "0x4012BF8")]
		[FieldOffset(Offset = "0x14")]
		internal uint difficty;

		[Token(Token = "0x6014B5F")]
		[Address(RVA = "0xE59F10", Offset = "0xE59F10", VA = "0xE59F10")]
		public _003CUpdateSelectedMapData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014B60")]
		[Address(RVA = "0xE5E418", Offset = "0xE5E418", VA = "0xE5E418")]
		internal bool _003C_003Em__0(MapModeData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6014B61")]
		[Address(RVA = "0xE5E474", Offset = "0xE5E474", VA = "0xE5E474")]
		internal bool _003C_003Em__1(MapModeData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6014B62")]
		[Address(RVA = "0xE5E588", Offset = "0xE5E588", VA = "0xE5E588")]
		internal bool _003C_003Em__2(MapModeData a)
		{
			return default(bool);
		}

		[Token(Token = "0x6014B63")]
		[Address(RVA = "0xE5E69C", Offset = "0xE5E69C", VA = "0xE5E69C")]
		internal bool _003C_003Em__3(MapModeData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200315D")]
	private sealed class _003CIsMapLimitedOpen_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012BF9")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData data;

		[Token(Token = "0x6014B64")]
		[Address(RVA = "0xE5A294", Offset = "0xE5A294", VA = "0xE5A294")]
		public _003CIsMapLimitedOpen_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014B65")]
		[Address(RVA = "0xE5E380", Offset = "0xE5E380", VA = "0xE5E380")]
		internal bool _003C_003Em__0(MapOpeningInfo a)
		{
			return default(bool);
		}

		[Token(Token = "0x6014B66")]
		[Address(RVA = "0xE5E3CC", Offset = "0xE5E3CC", VA = "0xE5E3CC")]
		internal bool _003C_003Em__1(MapOpeningInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200315E")]
	private sealed class _003CGetOpeningInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012BFA")]
		[FieldOffset(Offset = "0x8")]
		internal MapModeData data;

		[Token(Token = "0x6014B67")]
		[Address(RVA = "0xE5A29C", Offset = "0xE5A29C", VA = "0xE5A29C")]
		public _003CGetOpeningInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014B68")]
		[Address(RVA = "0xE5E334", Offset = "0xE5E334", VA = "0xE5E334")]
		internal bool _003C_003Em__0(MapOpeningInfo a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200315F")]
	private sealed class _003CGetMapModeData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012BFB")]
		[FieldOffset(Offset = "0x8")]
		internal uint matchMode;

		[Token(Token = "0x4012BFC")]
		[FieldOffset(Offset = "0xC")]
		internal uint gameMode;

		[Token(Token = "0x4012BFD")]
		[FieldOffset(Offset = "0x10")]
		internal uint mapMode;

		[Token(Token = "0x6014B69")]
		[Address(RVA = "0xE5B0FC", Offset = "0xE5B0FC", VA = "0xE5B0FC")]
		public _003CGetMapModeData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014B6A")]
		[Address(RVA = "0xE5E2D8", Offset = "0xE5E2D8", VA = "0xE5E2D8")]
		internal bool _003C_003Em__0(MapModeData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012BBD")]
	[FieldOffset(Offset = "0x10")]
	private long RegionServerTimeOffset;

	[Token(Token = "0x4012BBE")]
	[FieldOffset(Offset = "0x18")]
	private ulong m_RefreshWinnerEntranceTimeAt;

	[Token(Token = "0x4012BBF")]
	[FieldOffset(Offset = "0x20")]
	private bool m_IsWinnerModeEntranceFree;

	[Token(Token = "0x4012BC0")]
	public const string RANK_GUIDE_KEY = "rank_guide";

	[Token(Token = "0x4012BC1")]
	public const string MEET_RANK_LIMIT_KEY = "rank_limit";

	[Token(Token = "0x4012BC2")]
	[FieldOffset(Offset = "0x24")]
	private RankingLevelLimitDescList m_MatchLevelLimitDescList;

	[Token(Token = "0x4012BC3")]
	[FieldOffset(Offset = "0x28")]
	private ModeLevelLimitDescList m_mode_level_limit_list;

	[Token(Token = "0x4012BC4")]
	[FieldOffset(Offset = "0x2C")]
	private int _003CWinnerModeChipCost_003Ek__BackingField;

	[Token(Token = "0x4012BC5")]
	[FieldOffset(Offset = "0x30")]
	private int _003CWinnerModeDiamondeCost_003Ek__BackingField;

	[Token(Token = "0x4012BC6")]
	[FieldOffset(Offset = "0x34")]
	private int _003CWinnerModeCurrencyType_003Ek__BackingField;

	[Token(Token = "0x4012BC7")]
	[FieldOffset(Offset = "0x38")]
	private List<MapOpeningInfo> m_TotalOpeningInfoList;

	[Token(Token = "0x4012BC8")]
	[FieldOffset(Offset = "0x3C")]
	private float _003CMapRP_003Ek__BackingField;

	[Token(Token = "0x4012BC9")]
	[FieldOffset(Offset = "0x40")]
	private List<MapModeData> m_MapModeList;

	[Token(Token = "0x4012BCA")]
	[FieldOffset(Offset = "0x44")]
	private SortedDictionary<uint, List<MapModeData>> m_SortedMapModeDict;

	[Token(Token = "0x4012BCB")]
	[FieldOffset(Offset = "0x48")]
	private List<MapOpeningInfo> m_NewOpeningInfoList;

	[Token(Token = "0x4012BCC")]
	[FieldOffset(Offset = "0x4C")]
	private Dictionary<uint, List<MapModeData>> m_ModeDictOfRandomMap;

	[Token(Token = "0x4012BCD")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<ModesPickMoreMaps, List<MapModeData>> m_DictModesPickMoreMaps;

	[Token(Token = "0x4012BCE")]
	[FieldOffset(Offset = "0x54")]
	private List<GameModeSortData> m_SortedGameModeData;

	[Token(Token = "0x4012BCF")]
	[FieldOffset(Offset = "0x58")]
	private uint m_CurrentPeriodicMapSelectConfigID;

	[Token(Token = "0x4012BD0")]
	[FieldOffset(Offset = "0x5C")]
	private List<MapOpeningInfo> m_PermanentMapInfoList;

	[Token(Token = "0x4012BD1")]
	[FieldOffset(Offset = "0x60")]
	private List<MapOpeningInfo> m_HintMapInfoList;

	[Token(Token = "0x4012BD2")]
	[FieldOffset(Offset = "0x64")]
	private List<MapOpeningInfo> m_ChampionshipMapList;

	[Token(Token = "0x4012BD3")]
	[FieldOffset(Offset = "0x68")]
	private List<MapOpeningInfo> m_CupMatchMapList;

	[Token(Token = "0x4012BD4")]
	[FieldOffset(Offset = "0x6C")]
	private List<MapModeData> m_TrainingMapList;

	[Token(Token = "0x4012BD5")]
	[FieldOffset(Offset = "0x70")]
	private List<MapOpeningInfo> m_PeriodicRankMapOpeningInfoMapList;

	[Token(Token = "0x4012BD6")]
	[FieldOffset(Offset = "0x74")]
	public List<MapModeData> PeriodicRankMapList;

	[Token(Token = "0x4012BD7")]
	[FieldOffset(Offset = "0x78")]
	private MapOpeningInfo _003CShangrila_003Ek__BackingField;

	[Token(Token = "0x4012BD8")]
	public const uint PropID_OpeningInfoListUpdate = 2u;

	[Token(Token = "0x4012BD9")]
	public const uint PropID_WinnerTakeAllInfoUpdate = 4u;

	[Token(Token = "0x4012BDA")]
	public const uint PropID_UGCMapChanged = 8u;

	[Token(Token = "0x4012BDB")]
	public const uint PropID_BRCSPickedMapChanged = 16u;

	[Token(Token = "0x4012BDC")]
	[FieldOffset(Offset = "0x7C")]
	private MapModeData m_SelectedMapData;

	[Token(Token = "0x4012BDD")]
	[FieldOffset(Offset = "0x80")]
	private MapModeData _003CSelectToDownloadMapMode_003Ek__BackingField;

	[Token(Token = "0x4012BDE")]
	[FieldOffset(Offset = "0x84")]
	public MapModeData CachedUISelectedMapData;

	[Token(Token = "0x4012BDF")]
	[FieldOffset(Offset = "0x88")]
	private UGCMatchMakingInfo m_UGCMatchMakingInfo;

	[Token(Token = "0x4012BE0")]
	[FieldOffset(Offset = "0x8C")]
	private Dictionary<uint, EMapDifficulty> m_CachedMapDifficultyByConfId;

	[Token(Token = "0x4012BE1")]
	[FieldOffset(Offset = "0x90")]
	private int m_CachedPVEMapId;

	[Token(Token = "0x4012BE2")]
	[FieldOffset(Offset = "0x94")]
	public int DefaultPermanentMapIndex;

	[Token(Token = "0x4012BE3")]
	[FieldOffset(Offset = "0x98")]
	public bool m_HasAvailableMapsInited;

	[Token(Token = "0x4012BE4")]
	private const string MAP_HINT_KEY = "map_hint";

	[Token(Token = "0x4012BE5")]
	private const string MAP_PVE_KEY = "pve_map_id";

	[Token(Token = "0x4012BE6")]
	[FieldOffset(Offset = "0x99")]
	private bool _003CIsRequestPending_003Ek__BackingField;

	[Token(Token = "0x4012BE7")]
	[FieldOffset(Offset = "0x9C")]
	private Dictionary<uint, string> m_GameModeNameDict;

	[Token(Token = "0x4012BE8")]
	[FieldOffset(Offset = "0xA0")]
	public List<ModesPickMoreMaps> ModesPickMoreList;

	[Token(Token = "0x4012BE9")]
	[FieldOffset(Offset = "0xA4")]
	private List<uint> m_AvailableMapIdList;

	[Token(Token = "0x4012BEA")]
	[FieldOffset(Offset = "0xA8")]
	private List<uint> m_PreAvailableMapIdList;

	[Token(Token = "0x4012BEB")]
	[FieldOffset(Offset = "0xAC")]
	private List<uint> m_UGCOptionalMapConfigIdArray;

	[Token(Token = "0x4012BEC")]
	[FieldOffset(Offset = "0xB0")]
	private List<uint> m_SkipOptionalMapConfigIdList;

	[Token(Token = "0x4012BED")]
	[FieldOffset(Offset = "0xB4")]
	private List<QuitControlDesc> m_quitControlDescList;

	[Token(Token = "0x4012BEE")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<GameModeSortData> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012BEF")]
	[FieldOffset(Offset = "0x4")]
	private static Func<uint, string> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012BF0")]
	[FieldOffset(Offset = "0x8")]
	private static Func<string, string, string> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x1700158B")]
	public int WinnerModeChipCost
	{
		[Token(Token = "0x6014AD7")]
		[Address(RVA = "0xE4EACC", Offset = "0xE4EACC", VA = "0xE4EACC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014AD8")]
		[Address(RVA = "0xE4EAD4", Offset = "0xE4EAD4", VA = "0xE4EAD4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700158C")]
	public int WinnerModeDiamondeCost
	{
		[Token(Token = "0x6014AD9")]
		[Address(RVA = "0xE4EADC", Offset = "0xE4EADC", VA = "0xE4EADC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014ADA")]
		[Address(RVA = "0xE4EAE4", Offset = "0xE4EAE4", VA = "0xE4EAE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700158D")]
	public int WinnerModeCurrencyType
	{
		[Token(Token = "0x6014ADB")]
		[Address(RVA = "0xE4EAEC", Offset = "0xE4EAEC", VA = "0xE4EAEC")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6014ADC")]
		[Address(RVA = "0xE4EAF4", Offset = "0xE4EAF4", VA = "0xE4EAF4")]
		set
		{
		}
	}

	[Token(Token = "0x1700158E")]
	public DateTime RegionServerTime
	{
		[Token(Token = "0x6014ADD")]
		[Address(RVA = "0xE4EAFC", Offset = "0xE4EAFC", VA = "0xE4EAFC")]
		get
		{
			return default(DateTime);
		}
	}

	[Token(Token = "0x1700158F")]
	public List<MapOpeningInfo> TotalOpeningInfoList
	{
		[Token(Token = "0x6014ADF")]
		[Address(RVA = "0xE4ECE0", Offset = "0xE4ECE0", VA = "0xE4ECE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001590")]
	public float MapRP
	{
		[Token(Token = "0x6014AE0")]
		[Address(RVA = "0xE4ED38", Offset = "0xE4ED38", VA = "0xE4ED38")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6014AE1")]
		[Address(RVA = "0xE4ED40", Offset = "0xE4ED40", VA = "0xE4ED40")]
		private set
		{
		}
	}

	[Token(Token = "0x17001591")]
	public List<MapModeData> MapModeList
	{
		[Token(Token = "0x6014AE2")]
		[Address(RVA = "0xE4ED48", Offset = "0xE4ED48", VA = "0xE4ED48")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001592")]
	public List<MapOpeningInfo> NewOpeningInfoList
	{
		[Token(Token = "0x6014AE4")]
		[Address(RVA = "0xE4EDF8", Offset = "0xE4EDF8", VA = "0xE4EDF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001593")]
	public uint CurrentPeriodicMapSelectConfigID
	{
		[Token(Token = "0x6014AE6")]
		[Address(RVA = "0xE4F4B4", Offset = "0xE4F4B4", VA = "0xE4F4B4")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6014AE7")]
		[Address(RVA = "0xE4F50C", Offset = "0xE4F50C", VA = "0xE4F50C")]
		set
		{
		}
	}

	[Token(Token = "0x17001594")]
	public List<MapOpeningInfo> PermanentMapInfoList
	{
		[Token(Token = "0x6014AE8")]
		[Address(RVA = "0xE4F620", Offset = "0xE4F620", VA = "0xE4F620")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001595")]
	public List<MapOpeningInfo> HintMapInfoList
	{
		[Token(Token = "0x6014AE9")]
		[Address(RVA = "0xE4F678", Offset = "0xE4F678", VA = "0xE4F678")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001596")]
	public List<MapModeData> TrainingMapInfoList
	{
		[Token(Token = "0x6014AEA")]
		[Address(RVA = "0xE4F6D0", Offset = "0xE4F6D0", VA = "0xE4F6D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001597")]
	public MapOpeningInfo Shangrila
	{
		[Token(Token = "0x6014AEB")]
		[Address(RVA = "0xE4F728", Offset = "0xE4F728", VA = "0xE4F728")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014AEC")]
		[Address(RVA = "0xE4F730", Offset = "0xE4F730", VA = "0xE4F730")]
		private set
		{
		}
	}

	[Token(Token = "0x17001598")]
	public MapModeData SelectToDownloadMapMode
	{
		[Token(Token = "0x6014AEE")]
		[Address(RVA = "0xE4FA5C", Offset = "0xE4FA5C", VA = "0xE4FA5C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014AEF")]
		[Address(RVA = "0xE4FA64", Offset = "0xE4FA64", VA = "0xE4FA64")]
		set
		{
		}
	}

	[Token(Token = "0x17001599")]
	public UGCMatchMakingInfo UGCMatchMakingInfo
	{
		[Token(Token = "0x6014AF0")]
		[Address(RVA = "0xE4FA6C", Offset = "0xE4FA6C", VA = "0xE4FA6C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700159A")]
	public bool IsRequestPending
	{
		[Token(Token = "0x6014AF4")]
		[Address(RVA = "0xE4FE48", Offset = "0xE4FE48", VA = "0xE4FE48")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014AF3")]
		[Address(RVA = "0xE4FE40", Offset = "0xE4FE40", VA = "0xE4FE40")]
		private set
		{
		}
	}

	[Token(Token = "0x1700159B")]
	public List<QuitControlDesc> QuitControlDescList
	{
		[Token(Token = "0x6014B4D")]
		[Address(RVA = "0xE5DACC", Offset = "0xE5DACC", VA = "0xE5DACC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014B4E")]
		[Address(RVA = "0xE5DB24", Offset = "0xE5DB24", VA = "0xE5DB24")]
		set
		{
		}
	}

	[Token(Token = "0x6014AD5")]
	[Address(RVA = "0xE4E634", Offset = "0xE4E634", VA = "0xE4E634")]
	public UIModelMapOpeningInfo()
	{
	}

	[Token(Token = "0x6014AD6")]
	[Address(RVA = "0xE4EA74", Offset = "0xE4EA74", VA = "0xE4EA74")]
	public bool IsWinnerModeEntranceFree()
	{
		return default(bool);
	}

	[Token(Token = "0x6014ADE")]
	[Address(RVA = "0xE4EC50", Offset = "0xE4EC50", VA = "0xE4EC50")]
	public static uint MakeOpeningInfoID(uint matchMode, uint mapID, uint gameMode)
	{
		return default(uint);
	}

	[Token(Token = "0x6014AE3")]
	[Address(RVA = "0xE4EDA0", Offset = "0xE4EDA0", VA = "0xE4EDA0")]
	public SortedDictionary<uint, List<MapModeData>> SortedMapModeDict()
	{
		return null;
	}

	[Token(Token = "0x6014AE5")]
	[Address(RVA = "0xE4EE50", Offset = "0xE4EE50", VA = "0xE4EE50")]
	public List<GameModeSortData> SortedGameModeDataList()
	{
		return null;
	}

	[Token(Token = "0x6014AED")]
	[Address(RVA = "0xE4F738", Offset = "0xE4F738", VA = "0xE4F738")]
	public MapModeData SelectedMapData()
	{
		return null;
	}

	[Token(Token = "0x6014AF1")]
	[Address(RVA = "0xE4FAC4", Offset = "0xE4FAC4", VA = "0xE4FAC4")]
	public void UpdateUGCRandomMatchMakingInfo(List<string> CodePool, uint GroupMode, bool isTeamContest, uint[] teamCounts)
	{
	}

	[Token(Token = "0x6014AF2")]
	[Address(RVA = "0xE4FCA8", Offset = "0xE4FCA8", VA = "0xE4FCA8")]
	public void UpdateUGCCertainMapMatchMakingInfo(SceneEditSlotInfo slotInfo)
	{
	}

	[Token(Token = "0x6014AF5")]
	[Address(RVA = "0xE4FE50", Offset = "0xE4FE50", VA = "0xE4FE50", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014AF6")]
	[Address(RVA = "0xE4FEA8", Offset = "0xE4FEA8", VA = "0xE4FEA8", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014AF7")]
	[Address(RVA = "0xE4FFD8", Offset = "0xE4FFD8", VA = "0xE4FFD8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014AF8")]
	[Address(RVA = "0xE5022C", Offset = "0xE5022C", VA = "0xE5022C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014AF9")]
	[Address(RVA = "0xE5031C", Offset = "0xE5031C", VA = "0xE5031C", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6014AFA")]
	[Address(RVA = "0xE504D0", Offset = "0xE504D0", VA = "0xE504D0")]
	public List<MapOpeningInfo> GetPeriodicRankMapAvailableMapList()
	{
		return null;
	}

	[Token(Token = "0x6014AFB")]
	[Address(RVA = "0xE505D8", Offset = "0xE505D8", VA = "0xE505D8")]
	public void RequestMapOpeningInfo()
	{
	}

	[Token(Token = "0x6014AFC")]
	[Address(RVA = "0xE5085C", Offset = "0xE5085C", VA = "0xE5085C")]
	public void UpdateMapOpeningInfo(GameOpeningInfoRes data)
	{
	}

	[Token(Token = "0x6014AFD")]
	[Address(RVA = "0xE55418", Offset = "0xE55418", VA = "0xE55418")]
	public int SortPerioidicMap(MapOpeningInfo a, MapOpeningInfo b)
	{
		return default(int);
	}

	[Token(Token = "0x6014AFE")]
	[Address(RVA = "0xE554D4", Offset = "0xE554D4", VA = "0xE554D4")]
	public int SortPerioidicMap(MapModeData a, MapModeData b)
	{
		return default(int);
	}

	[Token(Token = "0x6014AFF")]
	[Address(RVA = "0xE531AC", Offset = "0xE531AC", VA = "0xE531AC")]
	private RankingLevelLimitDesc GetLevelLimitDesc(JOKABEAPNPP tarGameMode, DGNDKMLMLPM tarMatchMode)
	{
		return null;
	}

	[Token(Token = "0x6014B00")]
	[Address(RVA = "0xE556C4", Offset = "0xE556C4", VA = "0xE556C4")]
	public uint GetModeLimitLevel(JOKABEAPNPP tarGameMode, uint mapId)
	{
		return default(uint);
	}

	[Token(Token = "0x6014B01")]
	[Address(RVA = "0xE52F38", Offset = "0xE52F38", VA = "0xE52F38")]
	private bool IsIgnoreUID(MapOpeningInfo openInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B02")]
	[Address(RVA = "0xE53390", Offset = "0xE53390", VA = "0xE53390")]
	private void ResetLevelEntranceUnlockData()
	{
	}

	[Token(Token = "0x6014B03")]
	[Address(RVA = "0xE558A8", Offset = "0xE558A8", VA = "0xE558A8")]
	public int GetMatchGuestUnlockLevel(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode)
	{
		return default(int);
	}

	[Token(Token = "0x6014B04")]
	[Address(RVA = "0xE55940", Offset = "0xE55940", VA = "0xE55940")]
	public int GetMatchNormalUnlockLevel(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode)
	{
		return default(int);
	}

	[Token(Token = "0x6014B05")]
	[Address(RVA = "0xE559D8", Offset = "0xE559D8", VA = "0xE559D8")]
	public bool IsGuest()
	{
		return default(bool);
	}

	[Token(Token = "0x6014B06")]
	[Address(RVA = "0xE55AE0", Offset = "0xE55AE0", VA = "0xE55AE0")]
	public bool CheckLevelSatisfy(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode, bool showTips = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B07")]
	[Address(RVA = "0xE55EC8", Offset = "0xE55EC8", VA = "0xE55EC8")]
	public bool CheckMapModes(List<MapModeData> maps, bool showTips = true, bool showExtraTips = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B08")]
	[Address(RVA = "0xE53B1C", Offset = "0xE53B1C", VA = "0xE53B1C")]
	public bool CheckMapMode(MapModeData mapData, bool showTips = true, bool showExtraTips = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B09")]
	[Address(RVA = "0xE56AC0", Offset = "0xE56AC0", VA = "0xE56AC0")]
	public int GetGuestRegisterNeedTime(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode)
	{
		return default(int);
	}

	[Token(Token = "0x6014B0A")]
	[Address(RVA = "0xE56B58", Offset = "0xE56B58", VA = "0xE56B58")]
	public int GetNormalRegisterNeedTime(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode)
	{
		return default(int);
	}

	[Token(Token = "0x6014B0B")]
	[Address(RVA = "0xE560B0", Offset = "0xE560B0", VA = "0xE560B0")]
	public bool CheckRegisterTimeSatisfy(JOKABEAPNPP gameMode, DGNDKMLMLPM matchMode, bool showTips)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B0C")]
	[Address(RVA = "0xE52FE0", Offset = "0xE52FE0", VA = "0xE52FE0")]
	private void SaveModeOfRandomMap(MapOpeningInfo mapOpening)
	{
	}

	[Token(Token = "0x6014B0D")]
	[Address(RVA = "0xE56BF0", Offset = "0xE56BF0", VA = "0xE56BF0")]
	private bool IsLegalMatchMode(uint matchModeId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B0E")]
	[Address(RVA = "0xE56C74", Offset = "0xE56C74", VA = "0xE56C74")]
	public bool NeedPickMoreMaps(uint gameMode, uint matchMode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B0F")]
	[Address(RVA = "0xE552F0", Offset = "0xE552F0", VA = "0xE552F0")]
	public void SetMapsPickedMore(uint gameMode, uint matchMode, List<MapModeData> modes)
	{
	}

	[Token(Token = "0x6014B10")]
	[Address(RVA = "0xE5353C", Offset = "0xE5353C", VA = "0xE5353C")]
	public List<MapModeData> GetMapsPickedMore(uint gameMode, uint matchMode)
	{
		return null;
	}

	[Token(Token = "0x6014B11")]
	[Address(RVA = "0xE56E98", Offset = "0xE56E98", VA = "0xE56E98")]
	public void RefreshDownloadMapsPickedMore(uint gameMode, uint matchMode)
	{
	}

	[Token(Token = "0x6014B12")]
	[Address(RVA = "0xE571A0", Offset = "0xE571A0", VA = "0xE571A0")]
	public uint[] GetRandomMapIds(uint gameMode, uint matchMode, bool ingoreNotInOpenTimeMap = false)
	{
		return null;
	}

	[Token(Token = "0x6014B13")]
	[Address(RVA = "0xE57680", Offset = "0xE57680", VA = "0xE57680")]
	public bool IsInMapOpeingPeriod(MapOpeningInfo mapInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B14")]
	[Address(RVA = "0xE566AC", Offset = "0xE566AC", VA = "0xE566AC")]
	public bool IsMapOpening(uint map_id, uint game_mode, uint match_mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B15")]
	[Address(RVA = "0xE57A90", Offset = "0xE57A90", VA = "0xE57A90")]
	public bool IsGameModeOpening(uint game_mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B16")]
	[Address(RVA = "0xE57BF4", Offset = "0xE57BF4", VA = "0xE57BF4")]
	public MapOpeningInfo GetOpeningMapByGameMode(uint gameMode)
	{
		return null;
	}

	[Token(Token = "0x6014B17")]
	[Address(RVA = "0xE57E44", Offset = "0xE57E44", VA = "0xE57E44")]
	public List<MapModeData> GetMapModeListByGameMode(uint gameMode, uint matchMode)
	{
		return null;
	}

	[Token(Token = "0x6014B18")]
	[Address(RVA = "0xE580FC", Offset = "0xE580FC", VA = "0xE580FC")]
	public List<MapModeData> GetMapModeListByMatchMode(uint matchMode)
	{
		return null;
	}

	[Token(Token = "0x6014B19")]
	[Address(RVA = "0xE5837C", Offset = "0xE5837C", VA = "0xE5837C")]
	public uint[] GetPlayersLimits(uint map_id, uint game_mode, uint match_mode)
	{
		return null;
	}

	[Token(Token = "0x6014B1A")]
	[Address(RVA = "0xE585A4", Offset = "0xE585A4", VA = "0xE585A4")]
	public uint GetMaxPlayerLimit(uint map_id, uint game_mode, uint match_mode)
	{
		return default(uint);
	}

	[Token(Token = "0x6014B1B")]
	[Address(RVA = "0xE586B8", Offset = "0xE586B8", VA = "0xE586B8")]
	public HHDIPHFOBFO GetSelectedGameModeMaxGroupMode()
	{
		return default(HHDIPHFOBFO);
	}

	[Token(Token = "0x6014B1C")]
	[Address(RVA = "0xE5780C", Offset = "0xE5780C", VA = "0xE5780C")]
	public bool CheckMapIsOpening(MapOpeningInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B1D")]
	[Address(RVA = "0xE58818", Offset = "0xE58818", VA = "0xE58818")]
	public bool CheckMapIsOpeningInToday(MapOpeningInfo info)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B1E")]
	[Address(RVA = "0xE589C8", Offset = "0xE589C8", VA = "0xE589C8")]
	public int GetMapOpeningLeftTime(MapOpeningInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x6014B1F")]
	[Address(RVA = "0xE58B78", Offset = "0xE58B78", VA = "0xE58B78")]
	public int GetNextMapOpenTime(MapOpeningInfo info)
	{
		return default(int);
	}

	[Token(Token = "0x6014B20")]
	[Address(RVA = "0xE58ED4", Offset = "0xE58ED4", VA = "0xE58ED4")]
	public MapOpeningInfo GetNewOpeningMapInfo()
	{
		return null;
	}

	[Token(Token = "0x6014B21")]
	[Address(RVA = "0xE590BC", Offset = "0xE590BC", VA = "0xE590BC")]
	public string GetMatchModeString(uint matchMode)
	{
		return null;
	}

	[Token(Token = "0x6014B22")]
	[Address(RVA = "0xE59470", Offset = "0xE59470", VA = "0xE59470")]
	public string GetGameModeString(uint gMode)
	{
		return null;
	}

	[Token(Token = "0x6014B23")]
	[Address(RVA = "0xE594DC", Offset = "0xE594DC", VA = "0xE594DC")]
	public string GetGameModeStringLobbyOnly(uint gMode)
	{
		return null;
	}

	[Token(Token = "0x6014B24")]
	[Address(RVA = "0xE59630", Offset = "0xE59630", VA = "0xE59630")]
	public string GetMapModeString(uint mapMode, uint matchMode = 0u)
	{
		return null;
	}

	[Token(Token = "0x6014B25")]
	[Address(RVA = "0xE596B8", Offset = "0xE596B8", VA = "0xE596B8")]
	public string GetMapBgSpriteName(MapModeData data)
	{
		return null;
	}

	[Token(Token = "0x6014B26")]
	[Address(RVA = "0xE5986C", Offset = "0xE5986C", VA = "0xE5986C")]
	public void SetDefaultMap()
	{
	}

	[Token(Token = "0x6014B27")]
	[Address(RVA = "0xE4F7A8", Offset = "0xE4F7A8", VA = "0xE4F7A8")]
	public MapModeData GetDefaultMap()
	{
		return null;
	}

	[Token(Token = "0x6014B28")]
	[Address(RVA = "0xE59948", Offset = "0xE59948", VA = "0xE59948")]
	public void UpdateSelectPeriodicMapData(MapModeData data)
	{
	}

	[Token(Token = "0x6014B29")]
	[Address(RVA = "0xE599B0", Offset = "0xE599B0", VA = "0xE599B0")]
	public void UpdateSelectedMapData(uint matchMode, uint gameMode, uint mapMode, uint difficty, List<uint> mapids)
	{
	}

	[Token(Token = "0x6014B2A")]
	[Address(RVA = "0xE53044", Offset = "0xE53044", VA = "0xE53044")]
	private void UpdateLevelVisualStyle()
	{
	}

	[Token(Token = "0x6014B2B")]
	[Address(RVA = "0xE5A0A4", Offset = "0xE5A0A4", VA = "0xE5A0A4")]
	public bool IsMapLimitedOpen(MapModeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B2C")]
	[Address(RVA = "0xE5697C", Offset = "0xE5697C", VA = "0xE5697C")]
	public MapOpeningInfo GetOpeningInfo(MapModeData data)
	{
		return null;
	}

	[Token(Token = "0x6014B2D")]
	[Address(RVA = "0xE5A2A4", Offset = "0xE5A2A4", VA = "0xE5A2A4")]
	public MapOpeningInfo GetChampionshipMapByType(uint championshipType)
	{
		return null;
	}

	[Token(Token = "0x6014B2E")]
	[Address(RVA = "0xE5A884", Offset = "0xE5A884", VA = "0xE5A884")]
	public MapOpeningInfo GetCupMatchMapByType(int key)
	{
		return null;
	}

	[Token(Token = "0x6014B2F")]
	[Address(RVA = "0xE52D54", Offset = "0xE52D54", VA = "0xE52D54")]
	public bool IsChampionshipMode(uint match_mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B30")]
	[Address(RVA = "0xE52E34", Offset = "0xE52E34", VA = "0xE52E34")]
	public bool IsPeriodicMode(uint match_mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B31")]
	[Address(RVA = "0xE52DC4", Offset = "0xE52DC4", VA = "0xE52DC4")]
	public bool IsCupMatchMode(uint match_mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B32")]
	[Address(RVA = "0xE52EA4", Offset = "0xE52EA4", VA = "0xE52EA4")]
	public bool IsTrainingMode(MapOpeningInfo map_info)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B33")]
	[Address(RVA = "0xE5ADE8", Offset = "0xE5ADE8", VA = "0xE5ADE8")]
	public static bool IsRankingMatchMode(uint match_mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B34")]
	[Address(RVA = "0xE5AE54", Offset = "0xE5AE54", VA = "0xE5AE54")]
	public static int MapComparison(MapModeData a, MapModeData b)
	{
		return default(int);
	}

	[Token(Token = "0x6014B35")]
	[Address(RVA = "0xE59F18", Offset = "0xE59F18", VA = "0xE59F18")]
	public MapModeData GetMapModeData(uint matchMode, uint gameMode, uint mapMode)
	{
		return null;
	}

	[Token(Token = "0x6014B36")]
	[Address(RVA = "0xE5B104", Offset = "0xE5B104", VA = "0xE5B104")]
	public MapModeData GetPVEMapModeDataByConfigID(uint confId)
	{
		return null;
	}

	[Token(Token = "0x6014B37")]
	[Address(RVA = "0xE5B1A0", Offset = "0xE5B1A0", VA = "0xE5B1A0")]
	public void SetCachedPVEMapDifficulty(uint confId, EMapDifficulty difficulty)
	{
	}

	[Token(Token = "0x6014B38")]
	[Address(RVA = "0xE5B288", Offset = "0xE5B288", VA = "0xE5B288")]
	public void SavePVEMapDifficulty()
	{
	}

	[Token(Token = "0x6014B39")]
	[Address(RVA = "0xE5B504", Offset = "0xE5B504", VA = "0xE5B504")]
	public int GetPVEMapDifficultyByConfigID(uint confId)
	{
		return default(int);
	}

	[Token(Token = "0x6014B3A")]
	[Address(RVA = "0xE5B718", Offset = "0xE5B718", VA = "0xE5B718")]
	public void SetCachedPVEMapID(MapModeData mapdata)
	{
	}

	[Token(Token = "0x6014B3B")]
	[Address(RVA = "0xE5B794", Offset = "0xE5B794", VA = "0xE5B794")]
	public void SavePVEMapID()
	{
	}

	[Token(Token = "0x6014B3C")]
	[Address(RVA = "0xE5B880", Offset = "0xE5B880", VA = "0xE5B880")]
	public int GetSavedPVEMapID()
	{
		return default(int);
	}

	[Token(Token = "0x6014B3D")]
	[Address(RVA = "0xE5B96C", Offset = "0xE5B96C", VA = "0xE5B96C")]
	public bool CanChangePVEMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6014B3E")]
	[Address(RVA = "0xE5BAA0", Offset = "0xE5BAA0", VA = "0xE5BAA0")]
	public bool NeedShowMapHint()
	{
		return default(bool);
	}

	[Token(Token = "0x6014B3F")]
	[Address(RVA = "0xE5BC74", Offset = "0xE5BC74", VA = "0xE5BC74")]
	public void SetMapShowedFlag(bool is_showed)
	{
	}

	[Token(Token = "0x6014B40")]
	[Address(RVA = "0xE5BD60", Offset = "0xE5BD60", VA = "0xE5BD60")]
	public bool IsMapDataAvailable(bool retry)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B41")]
	[Address(RVA = "0xE5BE48", Offset = "0xE5BE48", VA = "0xE5BE48")]
	public void GetWinnerTakesAllInfo()
	{
	}

	[Token(Token = "0x6014B42")]
	[Address(RVA = "0xE5C128", Offset = "0xE5C128", VA = "0xE5C128")]
	public string GetGameModeName(MapModeData data)
	{
		return null;
	}

	[Token(Token = "0x6014B43")]
	[Address(RVA = "0xE5C1D8", Offset = "0xE5C1D8", VA = "0xE5C1D8")]
	public bool IsUGCOptionalMapConfigId(uint configId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B44")]
	[Address(RVA = "0xE5C428", Offset = "0xE5C428", VA = "0xE5C428")]
	public bool CheckAndRequestDownloadMapRes(uint map, uint mode, string message = "")
	{
		return default(bool);
	}

	[Token(Token = "0x6014B45")]
	[Address(RVA = "0xE53644", Offset = "0xE53644", VA = "0xE53644")]
	public List<ResourceID> NeedDownloadMapRes(uint mapConfigID, bool includeMode = false, bool includeModeRes = true)
	{
		return null;
	}

	[Token(Token = "0x6014B46")]
	[Address(RVA = "0xE5C5E0", Offset = "0xE5C5E0", VA = "0xE5C5E0")]
	public List<ResourceID> NeedDownloadMapRes(uint map_mode, uint game_mode, bool includeMode = false, bool includeModeRes = true)
	{
		return null;
	}

	[Token(Token = "0x6014B47")]
	[Address(RVA = "0xE5CAC4", Offset = "0xE5CAC4", VA = "0xE5CAC4")]
	public uint[] GetAvailableMapIdArray()
	{
		return null;
	}

	[Token(Token = "0x6014B48")]
	[Address(RVA = "0xE5CBA0", Offset = "0xE5CBA0", VA = "0xE5CBA0")]
	public void RefreshAvailableMapIdArray()
	{
	}

	[Token(Token = "0x6014B49")]
	[Address(RVA = "0xE5D688", Offset = "0xE5D688", VA = "0xE5D688")]
	public bool IsMapAvailable(uint mapID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B4A")]
	[Address(RVA = "0xE5D770", Offset = "0xE5D770", VA = "0xE5D770", Slot = "14")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6014B4B")]
	[Address(RVA = "0xE5D9A8", Offset = "0xE5D9A8", VA = "0xE5D9A8", Slot = "15")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6014B4C")]
	[Address(RVA = "0xE5DA3C", Offset = "0xE5DA3C", VA = "0xE5DA3C")]
	public bool IsClassicMode(MapModeData data)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B4F")]
	[Address(RVA = "0xE5DB84", Offset = "0xE5DB84", VA = "0xE5DB84")]
	public void SetMapDelayExitDesc(CSQuitControlDescRes desc)
	{
	}

	[Token(Token = "0x6014B50")]
	[Address(RVA = "0xE5DC78", Offset = "0xE5DC78", VA = "0xE5DC78")]
	public void SetMapRP(RankingMatchParam data)
	{
	}

	[Token(Token = "0x6014B51")]
	[Address(RVA = "0xE5A82C", Offset = "0xE5A82C", VA = "0xE5A82C")]
	public long GetRegionServerTimeOffset()
	{
		return default(long);
	}

	[Token(Token = "0x6014B52")]
	[Address(RVA = "0xE5DCF0", Offset = "0xE5DCF0", VA = "0xE5DCF0")]
	public bool DownloadMapModeIfNeed([Optional] MapModeData mapModeData)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B53")]
	[Address(RVA = "0xE5C688", Offset = "0xE5C688", VA = "0xE5C688")]
	public void TryDownloadMapRes(List<ResourceID> needDownloadRes, string mapName)
	{
	}

	[Token(Token = "0x6014B54")]
	[Address(RVA = "0xE5DEE4", Offset = "0xE5DEE4", VA = "0xE5DEE4")]
	private bool _003CGetPeriodicRankMapAvailableMapList_003Em__0(MapOpeningInfo x)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B55")]
	[Address(RVA = "0xE5DEE8", Offset = "0xE5DEE8", VA = "0xE5DEE8")]
	private static int _003CUpdateMapOpeningInfo_003Em__1(GameModeSortData a, GameModeSortData b)
	{
		return default(int);
	}

	[Token(Token = "0x6014B56")]
	[Address(RVA = "0xE5DF30", Offset = "0xE5DF30", VA = "0xE5DF30")]
	private bool _003CUpdateLevelVisualStyle_003Em__2(MapModeData a)
	{
		return default(bool);
	}

	[Token(Token = "0x6014B57")]
	[Address(RVA = "0xE5DFCC", Offset = "0xE5DFCC", VA = "0xE5DFCC")]
	private void _003CGetWinnerTakesAllInfo_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014B58")]
	[Address(RVA = "0xE5E184", Offset = "0xE5E184", VA = "0xE5E184")]
	private static string _003CRefreshAvailableMapIdArray_003Em__4(uint i)
	{
		return null;
	}

	[Token(Token = "0x6014B59")]
	[Address(RVA = "0xE5E21C", Offset = "0xE5E21C", VA = "0xE5E21C")]
	private static string _003CRefreshAvailableMapIdArray_003Em__5(string s1, string s2)
	{
		return null;
	}

	[Token(Token = "0x6014B5A")]
	[Address(RVA = "0xE5E2B8", Offset = "0xE5E2B8", VA = "0xE5E2B8")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014B5B")]
	[Address(RVA = "0xE5E2C0", Offset = "0xE5E2C0", VA = "0xE5E2C0")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}

	[Token(Token = "0x6014B5C")]
	[Address(RVA = "0xE5E2C8", Offset = "0xE5E2C8", VA = "0xE5E2C8")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014B5D")]
	[Address(RVA = "0xE5E2D0", Offset = "0xE5E2D0", VA = "0xE5E2D0")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
