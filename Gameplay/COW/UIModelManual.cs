using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003142")]
internal class UIModelManual : UIBaseModel
{
	[Token(Token = "0x2003143")]
	public class CheckManualRedDot
	{
		[Token(Token = "0x4012B73")]
		[FieldOffset(Offset = "0x8")]
		public UIManualMainTabController.EMainTab m_MainTab;

		[Token(Token = "0x4012B74")]
		[FieldOffset(Offset = "0xC")]
		public int m_SubTab;

		[Token(Token = "0x4012B75")]
		[FieldOffset(Offset = "0x10")]
		public int m_Page;

		[Token(Token = "0x4012B76")]
		[FieldOffset(Offset = "0x14")]
		public int m_Count;

		[Token(Token = "0x4012B77")]
		[FieldOffset(Offset = "0x18")]
		private int _003CIndex_003Ek__BackingField;

		[Token(Token = "0x1700158A")]
		public int Index
		{
			[Token(Token = "0x6014A9C")]
			[Address(RVA = "0xE4C30C", Offset = "0xE4C30C", VA = "0xE4C30C")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6014A9B")]
			[Address(RVA = "0xE4E2A4", Offset = "0xE4E2A4", VA = "0xE4E2A4")]
			private set
			{
			}
		}

		[Token(Token = "0x6014A9A")]
		[Address(RVA = "0xE4D68C", Offset = "0xE4D68C", VA = "0xE4D68C")]
		public CheckManualRedDot()
		{
		}

		[Token(Token = "0x6014A9D")]
		[Address(RVA = "0xE4D694", Offset = "0xE4D694", VA = "0xE4D694")]
		public void CalcIndex()
		{
		}

		[Token(Token = "0x6014A9E")]
		[Address(RVA = "0xE4E2AC", Offset = "0xE4E2AC", VA = "0xE4E2AC")]
		public static int CalcIndex(UIManualMainTabController.EMainTab tab, int subTab, int page)
		{
			return default(int);
		}

		[Token(Token = "0x6014A9F")]
		[Address(RVA = "0xE4E330", Offset = "0xE4E330", VA = "0xE4E330", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AA0")]
		[Address(RVA = "0xE4E514", Offset = "0xE4E514", VA = "0xE4E514", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x6014AA1")]
		[Address(RVA = "0xE4C538", Offset = "0xE4C538", VA = "0xE4C538")]
		public static bool operator ==(CheckManualRedDot x, CheckManualRedDot y)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AA2")]
		[Address(RVA = "0xE4E590", Offset = "0xE4E590", VA = "0xE4E590")]
		public static bool operator !=(CheckManualRedDot x, CheckManualRedDot y)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AA3")]
		[Address(RVA = "0xE4E624", Offset = "0xE4E624", VA = "0xE4E624")]
		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AA4")]
		[Address(RVA = "0xE4E62C", Offset = "0xE4E62C", VA = "0xE4E62C")]
		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2003144")]
	private sealed class _003CRequestCollectInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x2003145")]
		private sealed class _003CRequestCollectInfo_003Ec__AnonStorey1
		{
			[Token(Token = "0x4012B7B")]
			[FieldOffset(Offset = "0x8")]
			internal CheckManualRedDot checkData;

			[Token(Token = "0x4012B7C")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestCollectInfo_003Ec__AnonStorey0 _003C_003Ef__ref_00240;

			[Token(Token = "0x6014AA7")]
			[Address(RVA = "0xE4D684", Offset = "0xE4D684", VA = "0xE4D684")]
			public _003CRequestCollectInfo_003Ec__AnonStorey1()
			{
			}

			[Token(Token = "0x6014AA8")]
			[Address(RVA = "0xE4D6FC", Offset = "0xE4D6FC", VA = "0xE4D6FC")]
			internal bool _003C_003Em__0(CheckManualRedDot temp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4012B78")]
		[FieldOffset(Offset = "0x8")]
		internal bool callFromMatchAfter;

		[Token(Token = "0x4012B79")]
		[FieldOffset(Offset = "0x9")]
		internal bool preload;

		[Token(Token = "0x4012B7A")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x6014AA5")]
		[Address(RVA = "0xE4CD80", Offset = "0xE4CD80", VA = "0xE4CD80")]
		public _003CRequestCollectInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014AA6")]
		[Address(RVA = "0xE4CD88", Offset = "0xE4CD88", VA = "0xE4CD88")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003146")]
	private sealed class _003CRequestAllWeaponRewardStates_003Ec__AnonStorey3
	{
		[Token(Token = "0x2003147")]
		private sealed class _003CRequestAllWeaponRewardStates_003Ec__AnonStorey2
		{
			[Token(Token = "0x4012B80")]
			[FieldOffset(Offset = "0x8")]
			internal ManualWeaponReward reward;

			[Token(Token = "0x4012B81")]
			[FieldOffset(Offset = "0xC")]
			internal _003CRequestAllWeaponRewardStates_003Ec__AnonStorey3 _003C_003Ef__ref_00243;

			[Token(Token = "0x6014AAC")]
			[Address(RVA = "0xE4CC98", Offset = "0xE4CC98", VA = "0xE4CC98")]
			public _003CRequestAllWeaponRewardStates_003Ec__AnonStorey2()
			{
			}

			[Token(Token = "0x6014AAD")]
			[Address(RVA = "0xE4CD34", Offset = "0xE4CD34", VA = "0xE4CD34")]
			internal bool _003C_003Em__0(ManualWeaponReward temp)
			{
				return default(bool);
			}
		}

		[Token(Token = "0x4012B7D")]
		[FieldOffset(Offset = "0x8")]
		internal bool preload;

		[Token(Token = "0x4012B7E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x4012B7F")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<CSVBaseData, ManualWeaponRewardData> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014AA9")]
		[Address(RVA = "0xE4C740", Offset = "0xE4C740", VA = "0xE4C740")]
		public _003CRequestAllWeaponRewardStates_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014AAA")]
		[Address(RVA = "0xE4C748", Offset = "0xE4C748", VA = "0xE4C748")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014AAB")]
		[Address(RVA = "0xE4CCA0", Offset = "0xE4CCA0", VA = "0xE4CCA0")]
		private static ManualWeaponRewardData _003C_003Em__1(CSVBaseData temp)
		{
			return null;
		}
	}

	[Token(Token = "0x2003148")]
	private sealed class _003CRequestAllMapRewardStates_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012B82")]
		[FieldOffset(Offset = "0x8")]
		internal bool preload;

		[Token(Token = "0x4012B83")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x6014AAE")]
		[Address(RVA = "0xE4C5CC", Offset = "0xE4C5CC", VA = "0xE4C5CC")]
		public _003CRequestAllMapRewardStates_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014AAF")]
		[Address(RVA = "0xE4C5D4", Offset = "0xE4C5D4", VA = "0xE4C5D4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003149")]
	private sealed class _003CRequestWeaponReward_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012B84")]
		[FieldOffset(Offset = "0x8")]
		internal uint quantity;

		[Token(Token = "0x4012B85")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x4012B86")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4012B87")]
		[FieldOffset(Offset = "0x4")]
		private static Action _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6014AB0")]
		[Address(RVA = "0xE4DC34", Offset = "0xE4DC34", VA = "0xE4DC34")]
		public _003CRequestWeaponReward_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014AB1")]
		[Address(RVA = "0xE4DC3C", Offset = "0xE4DC3C", VA = "0xE4DC3C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014AB2")]
		[Address(RVA = "0xE4E1A4", Offset = "0xE4E1A4", VA = "0xE4E1A4")]
		internal bool _003C_003Em__1(ManualWeaponReward temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AB3")]
		[Address(RVA = "0xE4E1DC", Offset = "0xE4E1DC", VA = "0xE4E1DC")]
		private static CommonRewardItemInfo _003C_003Em__2(BaseItemInfo item)
		{
			return null;
		}

		[Token(Token = "0x6014AB4")]
		[Address(RVA = "0xE4E1E4", Offset = "0xE4E1E4", VA = "0xE4E1E4")]
		private static void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x200314A")]
	private sealed class _003CRequestMapReward_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012B88")]
		[FieldOffset(Offset = "0x8")]
		internal uint mapId;

		[Token(Token = "0x4012B89")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x6014AB5")]
		[Address(RVA = "0xE4D70C", Offset = "0xE4D70C", VA = "0xE4D70C")]
		public _003CRequestMapReward_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014AB6")]
		[Address(RVA = "0xE4D714", Offset = "0xE4D714", VA = "0xE4D714")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014AB7")]
		[Address(RVA = "0xE4DBFC", Offset = "0xE4DBFC", VA = "0xE4DBFC")]
		internal bool _003C_003Em__1(proto.ManualMapReward e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200314B")]
	private sealed class _003CAddUnlockIdLocal_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012B8A")]
		[FieldOffset(Offset = "0x8")]
		internal uint evtID;

		[Token(Token = "0x6014AB8")]
		[Address(RVA = "0xE4C248", Offset = "0xE4C248", VA = "0xE4C248")]
		public _003CAddUnlockIdLocal_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6014AB9")]
		[Address(RVA = "0xE4C250", Offset = "0xE4C250", VA = "0xE4C250")]
		internal bool _003C_003Em__0(uint temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200314C")]
	private sealed class _003CGetManualDescList_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012B8B")]
		[FieldOffset(Offset = "0x8")]
		internal EManual.EventType evtType;

		[Token(Token = "0x6014ABA")]
		[Address(RVA = "0xE4C354", Offset = "0xE4C354", VA = "0xE4C354")]
		public _003CGetManualDescList_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6014ABB")]
		[Address(RVA = "0xE4C35C", Offset = "0xE4C35C", VA = "0xE4C35C")]
		internal bool _003C_003Em__0(ManualChallenge e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200314D")]
	private sealed class _003CGetUnlockMapDatas_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012B8C")]
		[FieldOffset(Offset = "0x8")]
		internal uint it;

		[Token(Token = "0x6014ABC")]
		[Address(RVA = "0xE4C47C", Offset = "0xE4C47C", VA = "0xE4C47C")]
		public _003CGetUnlockMapDatas_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6014ABD")]
		[Address(RVA = "0xE4C484", Offset = "0xE4C484", VA = "0xE4C484")]
		internal bool _003C_003Em__0(ManualMapData itm)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200314E")]
	private sealed class _003CGetMapDebrisRewardNumber_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012B8D")]
		[FieldOffset(Offset = "0x8")]
		internal uint mapId;

		[Token(Token = "0x6014ABE")]
		[Address(RVA = "0xE4C394", Offset = "0xE4C394", VA = "0xE4C394")]
		public _003CGetMapDebrisRewardNumber_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6014ABF")]
		[Address(RVA = "0xE4C39C", Offset = "0xE4C39C", VA = "0xE4C39C")]
		internal bool _003C_003Em__0(ManualMapData e)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AC0")]
		[Address(RVA = "0xE4C3D4", Offset = "0xE4C3D4", VA = "0xE4C3D4")]
		internal bool _003C_003Em__1(ManualChallenge e)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AC1")]
		[Address(RVA = "0xE4C40C", Offset = "0xE4C40C", VA = "0xE4C40C")]
		internal bool _003C_003Em__2(proto.ManualMapReward e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200314F")]
	private sealed class _003CReadNewUnlockEvent_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4012B8E")]
		[FieldOffset(Offset = "0x8")]
		internal uint evtId;

		[Token(Token = "0x4012B8F")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x6014AC2")]
		[Address(RVA = "0xE4C4EC", Offset = "0xE4C4EC", VA = "0xE4C4EC")]
		public _003CReadNewUnlockEvent_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6014AC3")]
		[Address(RVA = "0xE4C4F4", Offset = "0xE4C4F4", VA = "0xE4C4F4")]
		internal bool _003C_003Em__0(CheckManualRedDot temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003150")]
	private sealed class _003CIsNewUnlockEvent_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4012B90")]
		[FieldOffset(Offset = "0x8")]
		internal uint evtId;

		[Token(Token = "0x6014AC4")]
		[Address(RVA = "0xE4C4BC", Offset = "0xE4C4BC", VA = "0xE4C4BC")]
		public _003CIsNewUnlockEvent_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6014AC5")]
		[Address(RVA = "0xE4C4C4", Offset = "0xE4C4C4", VA = "0xE4C4C4")]
		internal bool _003C_003Em__0(uint temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6014AC6")]
		[Address(RVA = "0xE4C4D8", Offset = "0xE4C4D8", VA = "0xE4C4D8")]
		internal bool _003C_003Em__1(uint temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003151")]
	private sealed class _003CCalcWeaponSubTabNewIconNumber_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4012B91")]
		[FieldOffset(Offset = "0x8")]
		internal uint subTitleId;

		[Token(Token = "0x4012B92")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelManual _0024this;

		[Token(Token = "0x6014AC7")]
		[Address(RVA = "0xE4C264", Offset = "0xE4C264", VA = "0xE4C264")]
		public _003CCalcWeaponSubTabNewIconNumber_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6014AC8")]
		[Address(RVA = "0xE4C26C", Offset = "0xE4C26C", VA = "0xE4C26C")]
		internal bool _003C_003Em__0(ManualWeaponData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003152")]
	private sealed class _003CGetMapSubTabIndex_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4012B93")]
		[FieldOffset(Offset = "0x8")]
		internal EManual.EventType type;

		[Token(Token = "0x6014AC9")]
		[Address(RVA = "0xE4C444", Offset = "0xE4C444", VA = "0xE4C444")]
		public _003CGetMapSubTabIndex_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6014ACA")]
		[Address(RVA = "0xE4C44C", Offset = "0xE4C44C", VA = "0xE4C44C")]
		internal bool _003C_003Em__0(uint temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003153")]
	private sealed class _003CGetMapSubTabIndex_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4012B94")]
		[FieldOffset(Offset = "0x8")]
		internal EManual.EventType type;

		[Token(Token = "0x6014ACB")]
		[Address(RVA = "0xE4C460", Offset = "0xE4C460", VA = "0xE4C460")]
		public _003CGetMapSubTabIndex_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6014ACC")]
		[Address(RVA = "0xE4C468", Offset = "0xE4C468", VA = "0xE4C468")]
		internal bool _003C_003Em__0(uint temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003154")]
	private sealed class _003CExistRedDotInPreviousContext_003Ec__AnonStorey10
	{
		[Token(Token = "0x4012B95")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x6014ACD")]
		[Address(RVA = "0xE4C314", Offset = "0xE4C314", VA = "0xE4C314")]
		public _003CExistRedDotInPreviousContext_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6014ACE")]
		[Address(RVA = "0xE4C31C", Offset = "0xE4C31C", VA = "0xE4C31C")]
		internal bool _003C_003Em__0(CheckManualRedDot temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003155")]
	private sealed class _003CExistRedDotInNextContext_003Ec__AnonStorey11
	{
		[Token(Token = "0x4012B96")]
		[FieldOffset(Offset = "0x8")]
		internal int index;

		[Token(Token = "0x6014ACF")]
		[Address(RVA = "0xE4C2CC", Offset = "0xE4C2CC", VA = "0xE4C2CC")]
		public _003CExistRedDotInNextContext_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6014AD0")]
		[Address(RVA = "0xE4C2D4", Offset = "0xE4C2D4", VA = "0xE4C2D4")]
		internal bool _003C_003Em__0(CheckManualRedDot temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012B58")]
	public const uint PropID_CollectInfo_Update = 2u;

	[Token(Token = "0x4012B59")]
	public const uint PropID_WeaponRewardInfo_Update = 4u;

	[Token(Token = "0x4012B5A")]
	public const uint PropID_MapRewardInfo_Update = 8u;

	[Token(Token = "0x4012B5B")]
	public const uint PropID_GetWeaponReward_Success = 16u;

	[Token(Token = "0x4012B5C")]
	public const uint PropID_GetMapReward_Success = 32u;

	[Token(Token = "0x4012B5D")]
	[FieldOffset(Offset = "0xC")]
	private bool _003CHasGetCollectInfo_003Ek__BackingField;

	[Token(Token = "0x4012B5E")]
	[FieldOffset(Offset = "0xD")]
	private bool _003CHasGetMapRewardStatus_003Ek__BackingField;

	[Token(Token = "0x4012B5F")]
	[FieldOffset(Offset = "0xE")]
	public bool HasReadNewDot;

	[Token(Token = "0x4012B60")]
	[FieldOffset(Offset = "0x10")]
	private List<ManualWeaponReward> m_ManualWeaponRewardStatuses;

	[Token(Token = "0x4012B61")]
	[FieldOffset(Offset = "0x14")]
	private CSGetManualAllMapRewardStatesRes m_MapRewardStates;

	[Token(Token = "0x4012B62")]
	[FieldOffset(Offset = "0x18")]
	private List<uint> m_UnlockEvtIds;

	[Token(Token = "0x4012B63")]
	[FieldOffset(Offset = "0x1C")]
	private List<uint> m_UnReadUnlockEvtIds;

	[Token(Token = "0x4012B64")]
	[FieldOffset(Offset = "0x20")]
	private List<uint> m_NewUnlockEventIdsAfterMatch;

	[Token(Token = "0x4012B65")]
	[FieldOffset(Offset = "0x24")]
	private List<ManualChallenge> m_CfgList;

	[Token(Token = "0x4012B66")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, ManualChallenge> m_ManulDescDict;

	[Token(Token = "0x4012B67")]
	[FieldOffset(Offset = "0x2C")]
	private List<uint> m_LastUnlockEventList;

	[Token(Token = "0x4012B68")]
	[FieldOffset(Offset = "0x30")]
	private WaitingResponseHandler m_WaitingHandler;

	[Token(Token = "0x4012B69")]
	[FieldOffset(Offset = "0x34")]
	private bool m_PreloadedCollectInfo;

	[Token(Token = "0x4012B6A")]
	[FieldOffset(Offset = "0x35")]
	private bool m_PreloadWeaponReward;

	[Token(Token = "0x4012B6B")]
	[FieldOffset(Offset = "0x36")]
	private bool m_PreloadMapRewards;

	[Token(Token = "0x4012B6C")]
	[FieldOffset(Offset = "0x38")]
	private List<CheckManualRedDot> m_CheckList;

	[Token(Token = "0x4012B6D")]
	[FieldOffset(Offset = "0x3C")]
	private List<uint> m_MapSubTabs;

	[Token(Token = "0x4012B6E")]
	[FieldOffset(Offset = "0x0")]
	private static Func<ManualChallenge, uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012B6F")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<CSVBaseData, ManualMapData> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012B70")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<CSVBaseData, ManualWeaponData> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012B71")]
	[FieldOffset(Offset = "0xC")]
	private static Comparison<CheckManualRedDot> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4012B72")]
	[FieldOffset(Offset = "0x10")]
	private static Comparison<CheckManualRedDot> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x17001585")]
	public bool HasGetCollectInfo
	{
		[Token(Token = "0x6014A65")]
		[Address(RVA = "0x2FE3DF0", Offset = "0x2FE3DF0", VA = "0x2FE3DF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014A64")]
		[Address(RVA = "0x2FE3DE8", Offset = "0x2FE3DE8", VA = "0x2FE3DE8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001586")]
	public bool HasGetMapRewardStatus
	{
		[Token(Token = "0x6014A67")]
		[Address(RVA = "0x2FE3E00", Offset = "0x2FE3E00", VA = "0x2FE3E00")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6014A66")]
		[Address(RVA = "0x2FE3DF8", Offset = "0x2FE3DF8", VA = "0x2FE3DF8")]
		private set
		{
		}
	}

	[Token(Token = "0x17001587")]
	public List<ManualWeaponReward> ManualWeaponRewardStatuses
	{
		[Token(Token = "0x6014A68")]
		[Address(RVA = "0x2FE3E08", Offset = "0x2FE3E08", VA = "0x2FE3E08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001588")]
	public CSGetManualAllMapRewardStatesRes MapRewardStates
	{
		[Token(Token = "0x6014A69")]
		[Address(RVA = "0x2FE3E60", Offset = "0x2FE3E60", VA = "0x2FE3E60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001589")]
	public List<uint> NewUnlockEvenIdsAfterMatch
	{
		[Token(Token = "0x6014A6A")]
		[Address(RVA = "0x2FE3EB8", Offset = "0x2FE3EB8", VA = "0x2FE3EB8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6014A63")]
	[Address(RVA = "0x2FE3B1C", Offset = "0x2FE3B1C", VA = "0x2FE3B1C")]
	public UIModelManual()
	{
	}

	[Token(Token = "0x6014A6B")]
	[Address(RVA = "0x2FE3F10", Offset = "0x2FE3F10", VA = "0x2FE3F10", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014A6C")]
	[Address(RVA = "0x2FE3F68", Offset = "0x2FE3F68", VA = "0x2FE3F68", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014A6D")]
	[Address(RVA = "0x2FE41F4", Offset = "0x2FE41F4", VA = "0x2FE41F4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014A6E")]
	[Address(RVA = "0x2FE42FC", Offset = "0x2FE42FC", VA = "0x2FE42FC")]
	public void ClearOldData()
	{
	}

	[Token(Token = "0x6014A6F")]
	[Address(RVA = "0x2FE447C", Offset = "0x2FE447C", VA = "0x2FE447C")]
	private void OnCollectInfo()
	{
	}

	[Token(Token = "0x6014A70")]
	[Address(RVA = "0x2FE474C", Offset = "0x2FE474C", VA = "0x2FE474C")]
	public void RequestCollectInfo(bool callFromMatchAfter = false, bool preload = false, bool silence = false)
	{
	}

	[Token(Token = "0x6014A71")]
	[Address(RVA = "0x2FE4AC4", Offset = "0x2FE4AC4", VA = "0x2FE4AC4")]
	private void OnGetAllWeaponRewardStates()
	{
	}

	[Token(Token = "0x6014A72")]
	[Address(RVA = "0x2FE4CB8", Offset = "0x2FE4CB8", VA = "0x2FE4CB8")]
	public void RequestAllWeaponRewardStates(bool preload = false, bool silence = false)
	{
	}

	[Token(Token = "0x6014A73")]
	[Address(RVA = "0x2FE4FD4", Offset = "0x2FE4FD4", VA = "0x2FE4FD4")]
	private void OnGetAllMapRewardStates()
	{
	}

	[Token(Token = "0x6014A74")]
	[Address(RVA = "0x2FE511C", Offset = "0x2FE511C", VA = "0x2FE511C")]
	public void RequestAllMapRewardStates(bool preload = false, bool silence = false)
	{
	}

	[Token(Token = "0x6014A75")]
	[Address(RVA = "0x2FE547C", Offset = "0x2FE547C", VA = "0x2FE547C")]
	public void RequestWeaponReward(uint quantity)
	{
	}

	[Token(Token = "0x6014A76")]
	[Address(RVA = "0x2FE5868", Offset = "0x2FE5868", VA = "0x2FE5868")]
	public void RequestMapReward(uint mapId)
	{
	}

	[Token(Token = "0x6014A77")]
	[Address(RVA = "0x2FE5C54", Offset = "0x2FE5C54", VA = "0x2FE5C54")]
	public List<uint> GetUnlockIds(EManual.EventType type)
	{
		return null;
	}

	[Token(Token = "0x6014A78")]
	[Address(RVA = "0x2FE5FB8", Offset = "0x2FE5FB8", VA = "0x2FE5FB8")]
	public bool AddUnlockIdLocal(uint evtID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A79")]
	[Address(RVA = "0x2FE6144", Offset = "0x2FE6144", VA = "0x2FE6144")]
	public ManualChallenge GetLockedChallengeByParam1(uint par1, EManual.EventType type = EManual.EventType.EventType_NONE)
	{
		return null;
	}

	[Token(Token = "0x6014A7A")]
	[Address(RVA = "0x2FE6334", Offset = "0x2FE6334", VA = "0x2FE6334")]
	public ManualChallenge GetLockedChallengeByParam2(uint par2, EManual.EventType type = EManual.EventType.EventType_NONE)
	{
		return null;
	}

	[Token(Token = "0x6014A7B")]
	[Address(RVA = "0x2FE5EA4", Offset = "0x2FE5EA4", VA = "0x2FE5EA4")]
	public ManualChallenge GetManualDescById(uint evtId)
	{
		return null;
	}

	[Token(Token = "0x6014A7C")]
	[Address(RVA = "0x2FE6524", Offset = "0x2FE6524", VA = "0x2FE6524")]
	public List<ManualChallenge> GetManualDescList(EManual.EventType evtType)
	{
		return null;
	}

	[Token(Token = "0x6014A7D")]
	[Address(RVA = "0x2FE3FF4", Offset = "0x2FE3FF4", VA = "0x2FE3FF4")]
	private void InitManualDesc()
	{
	}

	[Token(Token = "0x6014A7E")]
	[Address(RVA = "0x2FE4C0C", Offset = "0x2FE4C0C", VA = "0x2FE4C0C")]
	public int CalcRedDotNumber(UIManualDataBase.Type category)
	{
		return default(int);
	}

	[Token(Token = "0x6014A7F")]
	[Address(RVA = "0x2FE6C04", Offset = "0x2FE6C04", VA = "0x2FE6C04")]
	private EManual.EventType CovertToEventType(UIManualDataBase.Type subTabType)
	{
		return default(EManual.EventType);
	}

	[Token(Token = "0x6014A80")]
	[Address(RVA = "0x2FE6698", Offset = "0x2FE6698", VA = "0x2FE6698")]
	public ManualWeaponReward GetWeaponRewardFinishStatus()
	{
		return null;
	}

	[Token(Token = "0x6014A81")]
	[Address(RVA = "0x2FE6C8C", Offset = "0x2FE6C8C", VA = "0x2FE6C8C")]
	public int GetUnlockWeaponsCount()
	{
		return default(int);
	}

	[Token(Token = "0x6014A82")]
	[Address(RVA = "0x2FE6D50", Offset = "0x2FE6D50", VA = "0x2FE6D50")]
	public List<ManualMapData> GetUnlockMapDatas()
	{
		return null;
	}

	[Token(Token = "0x6014A83")]
	[Address(RVA = "0x2FE67A0", Offset = "0x2FE67A0", VA = "0x2FE67A0")]
	public int GetMapDebrisRewardNumber(uint mapId)
	{
		return default(int);
	}

	[Token(Token = "0x6014A84")]
	[Address(RVA = "0x2FE7240", Offset = "0x2FE7240", VA = "0x2FE7240")]
	public void ReadNewUnlockEvent(uint evtId)
	{
	}

	[Token(Token = "0x6014A85")]
	[Address(RVA = "0x2FE74E8", Offset = "0x2FE74E8", VA = "0x2FE74E8")]
	public bool IsNewUnlockEvent(uint evtId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A86")]
	[Address(RVA = "0x2FE460C", Offset = "0x2FE460C", VA = "0x2FE460C")]
	public int CalcMainTabNewIconNumberMap()
	{
		return default(int);
	}

	[Token(Token = "0x6014A87")]
	[Address(RVA = "0x2FE46D4", Offset = "0x2FE46D4", VA = "0x2FE46D4")]
	public int CalcNewIconNumber(UIManualDataBase.Type category)
	{
		return default(int);
	}

	[Token(Token = "0x6014A88")]
	[Address(RVA = "0x2FE76C0", Offset = "0x2FE76C0", VA = "0x2FE76C0")]
	public int CalcNewIconNumber(EManual.EventType evtType)
	{
		return default(int);
	}

	[Token(Token = "0x6014A89")]
	[Address(RVA = "0x2FE7838", Offset = "0x2FE7838", VA = "0x2FE7838")]
	public int CalcWeaponSubTabNewIconNumber(uint subTitleId)
	{
		return default(int);
	}

	[Token(Token = "0x6014A8A")]
	[Address(RVA = "0x2FE7AD8", Offset = "0x2FE7AD8", VA = "0x2FE7AD8")]
	public int GetMapSubTabIndex(UIManualDataBase.Type dataType)
	{
		return default(int);
	}

	[Token(Token = "0x6014A8B")]
	[Address(RVA = "0x2FE7C2C", Offset = "0x2FE7C2C", VA = "0x2FE7C2C")]
	public int GetMapSubTabIndex(EManual.EventType type)
	{
		return default(int);
	}

	[Token(Token = "0x6014A8C")]
	[Address(RVA = "0x2FE7D70", Offset = "0x2FE7D70", VA = "0x2FE7D70")]
	private int GetSubTab(EManual.EventType type, int subTab)
	{
		return default(int);
	}

	[Token(Token = "0x6014A8D")]
	[Address(RVA = "0x2FE7E0C", Offset = "0x2FE7E0C", VA = "0x2FE7E0C")]
	private CheckManualRedDot GetItemPosInPage(uint eventId)
	{
		return null;
	}

	[Token(Token = "0x6014A8E")]
	[Address(RVA = "0x2FE7F48", Offset = "0x2FE7F48", VA = "0x2FE7F48")]
	private UIManualMainTabController.EMainTab GetItemPosInPage(uint eventId, out int subTab, out int page)
	{
		return default(UIManualMainTabController.EMainTab);
	}

	[Token(Token = "0x6014A8F")]
	[Address(RVA = "0x2FE8194", Offset = "0x2FE8194", VA = "0x2FE8194")]
	private UIManualMainTabController.EMainTab GetMainTab(EManual.EventType type)
	{
		return default(UIManualMainTabController.EMainTab);
	}

	[Token(Token = "0x6014A90")]
	[Address(RVA = "0x2FE8200", Offset = "0x2FE8200", VA = "0x2FE8200")]
	public bool ExistRedDotInPreviousContext(UIManualDataBase.Type dataType, int subTab, int page)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A91")]
	[Address(RVA = "0x2FE8500", Offset = "0x2FE8500", VA = "0x2FE8500")]
	public bool ExistRedDotInNextContext(UIManualDataBase.Type dataType, int subTab, int page)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A92")]
	[Address(RVA = "0x2FE8828", Offset = "0x2FE8828", VA = "0x2FE8828")]
	private static uint _003CInitManualDesc_003Em__0(ManualChallenge key)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A93")]
	[Address(RVA = "0x2FE884C", Offset = "0x2FE884C", VA = "0x2FE884C")]
	private bool _003CGetWeaponRewardFinishStatus_003Em__1(ManualWeaponReward temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A94")]
	[Address(RVA = "0x2FE889C", Offset = "0x2FE889C", VA = "0x2FE889C")]
	private static ManualMapData _003CGetUnlockMapDatas_003Em__2(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x6014A95")]
	[Address(RVA = "0x2FE8930", Offset = "0x2FE8930", VA = "0x2FE8930")]
	private static ManualWeaponData _003CCalcWeaponSubTabNewIconNumber_003Em__3(CSVBaseData temp)
	{
		return null;
	}

	[Token(Token = "0x6014A96")]
	[Address(RVA = "0x2FE89C4", Offset = "0x2FE89C4", VA = "0x2FE89C4")]
	private static int _003CExistRedDotInPreviousContext_003Em__4(CheckManualRedDot x, CheckManualRedDot y)
	{
		return default(int);
	}

	[Token(Token = "0x6014A97")]
	[Address(RVA = "0x2FE8A18", Offset = "0x2FE8A18", VA = "0x2FE8A18")]
	private static int _003CExistRedDotInNextContext_003Em__5(CheckManualRedDot x, CheckManualRedDot y)
	{
		return default(int);
	}

	[Token(Token = "0x6014A98")]
	[Address(RVA = "0x2FE8A6C", Offset = "0x2FE8A6C", VA = "0x2FE8A6C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014A99")]
	[Address(RVA = "0x2FE8A74", Offset = "0x2FE8A74", VA = "0x2FE8A74")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
