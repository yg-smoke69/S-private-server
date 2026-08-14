using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20031D8")]
public class UIModelProfile : UIBaseModel
{
	[Token(Token = "0x20031D9")]
	private sealed class _003CRequestBattleTag_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012FB7")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x4012FB8")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150B4")]
		[Address(RVA = "0x3133040", Offset = "0x3133040", VA = "0x3133040")]
		public _003CRequestBattleTag_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60150B5")]
		[Address(RVA = "0x313769C", Offset = "0x313769C", VA = "0x313769C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031DA")]
	private sealed class _003CRequestShowBoardOnly_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012FB9")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x4012FBA")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150B6")]
		[Address(RVA = "0x3133480", Offset = "0x3133480", VA = "0x3133480")]
		public _003CRequestShowBoardOnly_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60150B7")]
		[Address(RVA = "0x3138FE0", Offset = "0x3138FE0", VA = "0x3138FE0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031DB")]
	private sealed class _003CRequestShowBoardData_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012FBB")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x4012FBC")]
		[FieldOffset(Offset = "0x10")]
		internal bool refreshavatar;

		[Token(Token = "0x4012FBD")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150B8")]
		[Address(RVA = "0x3133AC0", Offset = "0x3133AC0", VA = "0x3133AC0")]
		public _003CRequestShowBoardData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60150B9")]
		[Address(RVA = "0x3138950", Offset = "0x3138950", VA = "0x3138950")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031DC")]
	private sealed class _003CRequestPlayerBriefInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012FBE")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x4012FBF")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150BA")]
		[Address(RVA = "0x3133F24", Offset = "0x3133F24", VA = "0x3133F24")]
		public _003CRequestPlayerBriefInfo_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x60150BB")]
		[Address(RVA = "0x31383F0", Offset = "0x31383F0", VA = "0x31383F0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031DD")]
	private sealed class _003CRequestPersonalInfo_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012FC0")]
		[FieldOffset(Offset = "0x8")]
		internal ulong account_id;

		[Token(Token = "0x4012FC1")]
		[FieldOffset(Offset = "0x10")]
		internal Action callback;

		[Token(Token = "0x4012FC2")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150BC")]
		[Address(RVA = "0x31344E0", Offset = "0x31344E0", VA = "0x31344E0")]
		public _003CRequestPersonalInfo_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x60150BD")]
		[Address(RVA = "0x3137FE0", Offset = "0x3137FE0", VA = "0x3137FE0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031DE")]
	private sealed class _003CRequestPlayerHeroicMarkInfo_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012FC3")]
		[FieldOffset(Offset = "0x8")]
		internal bool IsLocalUser;

		[Token(Token = "0x4012FC4")]
		[FieldOffset(Offset = "0x10")]
		internal ulong account_id;

		[Token(Token = "0x4012FC5")]
		[FieldOffset(Offset = "0x18")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150BE")]
		[Address(RVA = "0x31345F0", Offset = "0x31345F0", VA = "0x31345F0")]
		public _003CRequestPlayerHeroicMarkInfo_003Ec__AnonStorey5()
		{
		}
	}

	[Token(Token = "0x20031DF")]
	private sealed class _003CRequestPersonalData_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012FC6")]
		[FieldOffset(Offset = "0x8")]
		internal uint matchMode;

		[Token(Token = "0x4012FC7")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150BF")]
		[Address(RVA = "0x3135008", Offset = "0x3135008", VA = "0x3135008")]
		public _003CRequestPersonalData_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x60150C0")]
		[Address(RVA = "0x3137AAC", Offset = "0x3137AAC", VA = "0x3137AAC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031E0")]
	private sealed class _003CRequestSetPesonalSetting_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012FC8")]
		[FieldOffset(Offset = "0x8")]
		internal bool refreshbattle;

		[Token(Token = "0x4012FC9")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150C1")]
		[Address(RVA = "0x3135270", Offset = "0x3135270", VA = "0x3135270")]
		public _003CRequestSetPesonalSetting_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x60150C2")]
		[Address(RVA = "0x3138708", Offset = "0x3138708", VA = "0x3138708")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x20031E1")]
	private sealed class _003CRequestLoadingPlayerInfoSetting_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012FCA")]
		[FieldOffset(Offset = "0x8")]
		internal uint[] choiceArray;

		[Token(Token = "0x4012FCB")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelProfile _0024this;

		[Token(Token = "0x60150C3")]
		[Address(RVA = "0x3135674", Offset = "0x3135674", VA = "0x3135674")]
		public _003CRequestLoadingPlayerInfoSetting_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x60150C4")]
		[Address(RVA = "0x3137988", Offset = "0x3137988", VA = "0x3137988")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4012F8D")]
	[FieldOffset(Offset = "0xC")]
	private List<MatchRecordPersonal> m_HistoryRecordList;

	[Token(Token = "0x4012F8E")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<uint, Dictionary<uint, PersonalRecordData>> m_MatchModeDict;

	[Token(Token = "0x4012F8F")]
	[FieldOffset(Offset = "0x14")]
	private Dictionary<ulong, PersonalLiveTvData> m_ShowLiveTvInfoDic;

	[Token(Token = "0x4012F90")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<ulong, CDTimeData> m_RequestLiveInfoCDDict;

	[Token(Token = "0x4012F91")]
	[FieldOffset(Offset = "0x1C")]
	private Dictionary<int, ulong> m_CDDic;

	[Token(Token = "0x4012F92")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<ulong, ulong> m_PlayerBriefInfoCDDict;

	[Token(Token = "0x4012F93")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<ulong, AccountBriefInfo> m_PlayerBriefInfoDict;

	[Token(Token = "0x4012F94")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<ulong, ulong> m_AccoutDic;

	[Token(Token = "0x4012F95")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<ulong, ulong> m_BattleTagDic;

	[Token(Token = "0x4012F96")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<ulong, AccountPersonalShowInfo> m_PersonShowinfoDic;

	[Token(Token = "0x4012F97")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<ulong, CSGetBattleTagRes> m_PersonBattleTagRes;

	[Token(Token = "0x4012F98")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<ulong, List<IntimacyState>> m_PersonalIntimacyDic;

	[Token(Token = "0x4012F99")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<ulong, ulong> m_RequestIntimcyCDDict;

	[Token(Token = "0x4012F9A")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<ulong, ulong> m_PlayerHeroicMarkInfoCDDict;

	[Token(Token = "0x4012F9B")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<ulong, CSGetHeroicInfoRes> m_PlayerHeroicMarkInfoDict;

	[Token(Token = "0x4012F9C")]
	[FieldOffset(Offset = "0x48")]
	public List<uint> ListLoadingPregameInfo;

	[Token(Token = "0x4012F9D")]
	public const int MaxCountOfLoadingPlayerInfo = 3;

	[Token(Token = "0x4012F9E")]
	private const int m_CDSecond = 300;

	[Token(Token = "0x4012F9F")]
	private const int m_PersonSecond = 7;

	[Token(Token = "0x4012FA0")]
	private const int m_BriefInfoSecond = 1800;

	[Token(Token = "0x4012FA1")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_diamond;

	[Token(Token = "0x4012FA2")]
	public const int PropID_GetProfileSuccess = 1;

	[Token(Token = "0x4012FA3")]
	public const int PropID_GetProfileFail = 2;

	[Token(Token = "0x4012FA4")]
	public const int PropID_GetHistorystats = 4;

	[Token(Token = "0x4012FA5")]
	public const int PropID_GetShowBoardDataSuccess = 8;

	[Token(Token = "0x4012FA6")]
	public const int PropID_GetLiveTvDataSuccess = 16;

	[Token(Token = "0x4012FA7")]
	public const int PropID_GetShowBoardAvatarDataSuccess = 32;

	[Token(Token = "0x4012FA8")]
	public const int PropID_GetPersonalSettingSuccess = 64;

	[Token(Token = "0x4012FA9")]
	public const int PropID_GetPersonalBattleTagSuccess = 128;

	[Token(Token = "0x4012FAA")]
	public const int PropID_GetPlayerBriefInfoSuccess = 256;

	[Token(Token = "0x4012FAB")]
	public const int PropID_GetPlayerRelationShipSuccess = 512;

	[Token(Token = "0x4012FAC")]
	public const int PropID_GetPlayerBattleTag = 1024;

	[Token(Token = "0x4012FAD")]
	public const int PropID_GetPlayerHeroicMarkInfoSuccess = 2048;

	[Token(Token = "0x4012FAE")]
	public const int PropID_SetLoadingShowPlayerInfoChoice = 4096;

	[Token(Token = "0x4012FAF")]
	[FieldOffset(Offset = "0x50")]
	public string DefaultSex;

	[Token(Token = "0x4012FB0")]
	[FieldOffset(Offset = "0x54")]
	public string DefaultShow;

	[Token(Token = "0x4012FB1")]
	[FieldOffset(Offset = "0x58")]
	public string DefaultOnLineTime;

	[Token(Token = "0x4012FB2")]
	[FieldOffset(Offset = "0x5C")]
	public string DefaultActiveTime;

	[Token(Token = "0x4012FB3")]
	[FieldOffset(Offset = "0x60")]
	public string DefaultModePrefer;

	[Token(Token = "0x4012FB4")]
	[FieldOffset(Offset = "0x64")]
	public string DefaultSignature;

	[Token(Token = "0x4012FB5")]
	private const string KEY_ENTERED_PROFILE_SETTING_TAB_LOADINGINFO = "ENTERED_PROFILE_SETTING_TAB_LOADINGINFO";

	[Token(Token = "0x4012FB6")]
	[FieldOffset(Offset = "0x0")]
	private static Func<uint, uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x1700162E")]
	public List<MatchRecordPersonal> HistoryRecordList
	{
		[Token(Token = "0x601508E")]
		[Address(RVA = "0x31327F4", Offset = "0x31327F4", VA = "0x31327F4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6015089")]
	[Address(RVA = "0x3131B90", Offset = "0x3131B90", VA = "0x3131B90")]
	public UIModelProfile()
	{
	}

	[Token(Token = "0x601508A")]
	[Address(RVA = "0x3131EE4", Offset = "0x3131EE4", VA = "0x3131EE4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601508B")]
	[Address(RVA = "0x3131F3C", Offset = "0x3131F3C", VA = "0x3131F3C", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x601508C")]
	[Address(RVA = "0x3132080", Offset = "0x3132080", VA = "0x3132080", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601508D")]
	[Address(RVA = "0x31324E0", Offset = "0x31324E0", VA = "0x31324E0", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x601508F")]
	[Address(RVA = "0x313284C", Offset = "0x313284C", VA = "0x313284C")]
	public void ProcessDiamondCost(DiamondCostRes res)
	{
	}

	[Token(Token = "0x6015090")]
	[Address(RVA = "0x31328B8", Offset = "0x31328B8", VA = "0x31328B8")]
	public uint GetDiamondCost()
	{
		return default(uint);
	}

	[Token(Token = "0x6015091")]
	[Address(RVA = "0x3132910", Offset = "0x3132910", VA = "0x3132910")]
	public Dictionary<uint, PersonalRecordData> GetPersonalRecordDict(uint matchMode)
	{
		return null;
	}

	[Token(Token = "0x6015092")]
	[Address(RVA = "0x31329F8", Offset = "0x31329F8", VA = "0x31329F8")]
	public void ForeRefreshAvatar()
	{
	}

	[Token(Token = "0x6015093")]
	[Address(RVA = "0x3132AC0", Offset = "0x3132AC0", VA = "0x3132AC0")]
	public CSGetBattleTagRes GetBattleTag(ulong account_id)
	{
		return null;
	}

	[Token(Token = "0x6015094")]
	[Address(RVA = "0x3132BBC", Offset = "0x3132BBC", VA = "0x3132BBC")]
	public void RequestBattleTag(ulong account_id, bool force = false)
	{
	}

	[Token(Token = "0x6015095")]
	[Address(RVA = "0x3133048", Offset = "0x3133048", VA = "0x3133048")]
	public void RequestShowBoardOnly(ulong account_id = 0uL)
	{
	}

	[Token(Token = "0x6015096")]
	[Address(RVA = "0x3133488", Offset = "0x3133488", VA = "0x3133488")]
	public void RequestShowBoardData(ulong account_id = 0uL, bool refreshavatar = false, bool silence = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6015097")]
	[Address(RVA = "0x3133AC8", Offset = "0x3133AC8", VA = "0x3133AC8")]
	public void RequestPlayerBriefInfo(ulong account_id)
	{
	}

	[Token(Token = "0x6015098")]
	[Address(RVA = "0x3133F2C", Offset = "0x3133F2C", VA = "0x3133F2C")]
	public AccountBriefInfo GetPlayerBriefInfo(ulong id)
	{
		return null;
	}

	[Token(Token = "0x6015099")]
	[Address(RVA = "0x313402C", Offset = "0x313402C", VA = "0x313402C")]
	public void RequestPersonalInfo(ulong account_id = 0uL, [Optional] Action callback)
	{
	}

	[Token(Token = "0x601509A")]
	[Address(RVA = "0x31344E8", Offset = "0x31344E8", VA = "0x31344E8")]
	public void RequestPlayerHeroicMarkInfo(ulong account_id)
	{
	}

	[Token(Token = "0x601509B")]
	[Address(RVA = "0x31345F8", Offset = "0x31345F8", VA = "0x31345F8")]
	public CSGetHeroicInfoRes GetPlayerHeroicMarkInfo(ulong account_id)
	{
		return null;
	}

	[Token(Token = "0x601509C")]
	[Address(RVA = "0x31346F8", Offset = "0x31346F8", VA = "0x31346F8")]
	public void RequestAllRelationshipStateInfo(ulong accid, bool force = false)
	{
	}

	[Token(Token = "0x601509D")]
	[Address(RVA = "0x31348DC", Offset = "0x31348DC", VA = "0x31348DC")]
	public List<IntimacyState> GetRelationShipInfo(ulong accid)
	{
		return null;
	}

	[Token(Token = "0x601509E")]
	[Address(RVA = "0x31349D8", Offset = "0x31349D8", VA = "0x31349D8")]
	public AccountPersonalShowInfo GetPersonalShowData(ulong id)
	{
		return null;
	}

	[Token(Token = "0x601509F")]
	[Address(RVA = "0x3134AD8", Offset = "0x3134AD8", VA = "0x3134AD8")]
	public AccountPrefers GetPersonalAccountPrefers(ulong id)
	{
		return null;
	}

	[Token(Token = "0x60150A0")]
	[Address(RVA = "0x3134B7C", Offset = "0x3134B7C", VA = "0x3134B7C")]
	public PersonalLiveTvData GetPersonalLiveTvData(ulong id)
	{
		return null;
	}

	[Token(Token = "0x60150A1")]
	[Address(RVA = "0x3134C7C", Offset = "0x3134C7C", VA = "0x3134C7C")]
	public void RequestPersonalData(uint type, ulong account_id = 0uL)
	{
	}

	[Token(Token = "0x60150A2")]
	[Address(RVA = "0x3135010", Offset = "0x3135010", VA = "0x3135010")]
	public void RequestSetPesonalSetting(CSUpdateSocialBasicInfoReq req, bool refreshbattle = false)
	{
	}

	[Token(Token = "0x60150A3")]
	[Address(RVA = "0x3135278", Offset = "0x3135278", VA = "0x3135278")]
	public void RequestLoadingPlayerInfoSetting()
	{
	}

	[Token(Token = "0x60150A4")]
	[Address(RVA = "0x313567C", Offset = "0x313567C", VA = "0x313567C")]
	public void RequestHistoryRecord(ulong account_id = 0uL)
	{
	}

	[Token(Token = "0x60150A5")]
	[Address(RVA = "0x3135A60", Offset = "0x3135A60", VA = "0x3135A60")]
	public void ClearMatchModeCache()
	{
	}

	[Token(Token = "0x60150A6")]
	[Address(RVA = "0x3135B20", Offset = "0x3135B20", VA = "0x3135B20")]
	private PersonalRecordData AccountInfo2PersonalRecord(AccountInfoWithStatsToClient acInfo, uint type)
	{
		return null;
	}

	[Token(Token = "0x60150A7")]
	[Address(RVA = "0x3136190", Offset = "0x3136190", VA = "0x3136190")]
	public void RefreshSelfShows(uint[] shows)
	{
	}

	[Token(Token = "0x60150A8")]
	[Address(RVA = "0x3136368", Offset = "0x3136368", VA = "0x3136368")]
	public void SetPlayerInfoTypeOnLoading(uint[] listDataType)
	{
	}

	[Token(Token = "0x60150A9")]
	[Address(RVA = "0x3136558", Offset = "0x3136558", VA = "0x3136558")]
	public bool IsShowPlayerInfoTypeOnLoading(proto.EAccount.Choices eDataType)
	{
		return default(bool);
	}

	[Token(Token = "0x60150AA")]
	[Address(RVA = "0x3136620", Offset = "0x3136620", VA = "0x3136620")]
	public bool SetShowPlayerInfoTypeOnLoading(proto.EAccount.Choices eDataType, bool show)
	{
		return default(bool);
	}

	[Token(Token = "0x60150AB")]
	[Address(RVA = "0x3136910", Offset = "0x3136910", VA = "0x3136910")]
	public void GetCSRankLoadingPlayerInfoByType(uint choiceType, StatsInfo statsInfo, out string strTitle, out string strVal)
	{
	}

	[Token(Token = "0x60150AC")]
	[Address(RVA = "0x3136D9C", Offset = "0x3136D9C", VA = "0x3136D9C")]
	private string ModifyThousandData(uint data)
	{
		return null;
	}

	[Token(Token = "0x60150AD")]
	[Address(RVA = "0x3136F00", Offset = "0x3136F00", VA = "0x3136F00")]
	public bool HaveEnteredProfileSettingTabLoadingInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x60150AE")]
	[Address(RVA = "0x31370E4", Offset = "0x31370E4", VA = "0x31370E4")]
	public void EnterProfileSettingTabLoadingInfo()
	{
	}

	[Token(Token = "0x60150AF")]
	[Address(RVA = "0x3137304", Offset = "0x3137304", VA = "0x3137304")]
	private static uint _003CRequestLoadingPlayerInfoSetting_003Em__0(uint e)
	{
		return default(uint);
	}

	[Token(Token = "0x60150B0")]
	[Address(RVA = "0x3137308", Offset = "0x3137308", VA = "0x3137308")]
	private void _003CRequestHistoryRecord_003Em__1(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x60150B1")]
	[Address(RVA = "0x3137684", Offset = "0x3137684", VA = "0x3137684")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60150B2")]
	[Address(RVA = "0x313768C", Offset = "0x313768C", VA = "0x313768C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x60150B3")]
	[Address(RVA = "0x3137694", Offset = "0x3137694", VA = "0x3137694")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
