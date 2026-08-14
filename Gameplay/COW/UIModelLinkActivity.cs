using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x20030F1")]
public class UIModelLinkActivity : UIBaseModel
{
	[Token(Token = "0x20030F2")]
	private sealed class _003CAutoOpenBundle_003Ec__AnonStorey0
	{
		[Token(Token = "0x40129DD")]
		[FieldOffset(Offset = "0x8")]
		internal bool isBatchOpen;

		[Token(Token = "0x40129DE")]
		[FieldOffset(Offset = "0xC")]
		internal Action<List<CommonRewardItemInfo>, string> callBack;

		[Token(Token = "0x40129DF")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x601482D")]
		[Address(RVA = "0x3286C8C", Offset = "0x3286C8C", VA = "0x3286C8C")]
		public _003CAutoOpenBundle_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601482E")]
		[Address(RVA = "0x32872A0", Offset = "0x32872A0", VA = "0x32872A0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601482F")]
		[Address(RVA = "0x3287C90", Offset = "0x3287C90", VA = "0x3287C90")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x20030F3")]
	private sealed class _003CSendServerRequest_003Ec__AnonStorey1<T> where T : class
	{
		[Token(Token = "0x40129E0")]
		[FieldOffset(Offset = "0x0")]
		internal Action<T> callback;

		[Token(Token = "0x6014830")]
		public _003CSendServerRequest_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014831")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20030F4")]
	private sealed class _003CSendServerRequestByParam_003Ec__AnonStorey2<T> where T : class
	{
		[Token(Token = "0x40129E1")]
		[FieldOffset(Offset = "0x0")]
		internal Action<T> callback;

		[Token(Token = "0x6014832")]
		public _003CSendServerRequestByParam_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014833")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x40129D2")]
	public const uint PropID_LinkActivityInfo = 1u;

	[Token(Token = "0x40129D3")]
	public const uint PropID_LinkActivityReward = 2u;

	[Token(Token = "0x40129D4")]
	public const uint PropID_LinkEquipSet = 4u;

	[Token(Token = "0x40129D5")]
	public const uint PropID_LinkPVEOpen = 8u;

	[Token(Token = "0x40129D6")]
	private const string TipPrefKey = "LinkActivityProcess";

	[Token(Token = "0x40129D7")]
	private const string TipPrefEntryKey = "LinkActivityProcessEntry";

	[Token(Token = "0x40129D8")]
	[FieldOffset(Offset = "0xC")]
	private CSGetLinkageActivityInfoRes m_State;

	[Token(Token = "0x40129D9")]
	[FieldOffset(Offset = "0x10")]
	public int RefreshHour;

	[Token(Token = "0x40129DA")]
	[FieldOffset(Offset = "0x14")]
	public int EquipSetsId;

	[Token(Token = "0x40129DB")]
	[FieldOffset(Offset = "0x18")]
	private List<CommonRewardItemInfo> m_PVEPorcessBatchReward;

	[Token(Token = "0x40129DC")]
	[FieldOffset(Offset = "0x1C")]
	private int BatchClaimPorcessIDCount;

	[Token(Token = "0x17001557")]
	public bool HasInfo
	{
		[Token(Token = "0x601480D")]
		[Address(RVA = "0x32859A0", Offset = "0x32859A0", VA = "0x32859A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001558")]
	public uint Day
	{
		[Token(Token = "0x601480E")]
		[Address(RVA = "0x3285A04", Offset = "0x3285A04", VA = "0x3285A04")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x17001559")]
	public uint ActivityId
	{
		[Token(Token = "0x601480F")]
		[Address(RVA = "0x3285A74", Offset = "0x3285A74", VA = "0x3285A74")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700155A")]
	public ELinkage.ActivityType ActivityType
	{
		[Token(Token = "0x6014810")]
		[Address(RVA = "0x3285AE4", Offset = "0x3285AE4", VA = "0x3285AE4")]
		get
		{
			return default(ELinkage.ActivityType);
		}
	}

	[Token(Token = "0x1700155B")]
	public uint TodayData
	{
		[Token(Token = "0x6014811")]
		[Address(RVA = "0x3285B54", Offset = "0x3285B54", VA = "0x3285B54")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700155C")]
	public uint TotalData
	{
		[Token(Token = "0x6014812")]
		[Address(RVA = "0x3285BC4", Offset = "0x3285BC4", VA = "0x3285BC4")]
		get
		{
			return default(uint);
		}
	}

	[Token(Token = "0x1700155D")]
	public bool IsFinished
	{
		[Token(Token = "0x6014813")]
		[Address(RVA = "0x3285C34", Offset = "0x3285C34", VA = "0x3285C34")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700155E")]
	public bool IsRewarded
	{
		[Token(Token = "0x6014814")]
		[Address(RVA = "0x3285CAC", Offset = "0x3285CAC", VA = "0x3285CAC")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700155F")]
	public bool HasActivity
	{
		[Token(Token = "0x6014815")]
		[Address(RVA = "0x3285D28", Offset = "0x3285D28", VA = "0x3285D28")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001560")]
	public long RegionServerTimeOffset
	{
		[Token(Token = "0x6014816")]
		[Address(RVA = "0x3285DA0", Offset = "0x3285DA0", VA = "0x3285DA0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17001561")]
	public List<LinkageProcessRewards> ProcessRewardsStatus
	{
		[Token(Token = "0x6014817")]
		[Address(RVA = "0x3285E10", Offset = "0x3285E10", VA = "0x3285E10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001562")]
	public ulong CurEPCount
	{
		[Token(Token = "0x6014818")]
		[Address(RVA = "0x3285E80", Offset = "0x3285E80", VA = "0x3285E80")]
		get
		{
			return default(ulong);
		}
	}

	[Token(Token = "0x17001563")]
	public string CDNUrl
	{
		[Token(Token = "0x6014819")]
		[Address(RVA = "0x3285EF0", Offset = "0x3285EF0", VA = "0x3285EF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601480B")]
	[Address(RVA = "0x32858B4", Offset = "0x32858B4", VA = "0x32858B4")]
	public UIModelLinkActivity()
	{
	}

	[Token(Token = "0x601480C")]
	[Address(RVA = "0x3285948", Offset = "0x3285948", VA = "0x3285948", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601481A")]
	[Address(RVA = "0x3285F60", Offset = "0x3285F60", VA = "0x3285F60")]
	public DateTime GetRegionServerDateTime()
	{
		return default(DateTime);
	}

	[Token(Token = "0x601481B")]
	[Address(RVA = "0x328605C", Offset = "0x328605C", VA = "0x328605C")]
	public int GetHoursForNextUpdate()
	{
		return default(int);
	}

	[Token(Token = "0x601481C")]
	[Address(RVA = "0x32860FC", Offset = "0x32860FC", VA = "0x32860FC")]
	public LinkActivityData GetActivityData()
	{
		return null;
	}

	[Token(Token = "0x601481D")]
	public T GetActivityDetailData<T>() where T : LinkActivityDetailData
	{
		return null;
	}

	[Token(Token = "0x601481E")]
	[Address(RVA = "0x3286240", Offset = "0x3286240", VA = "0x3286240")]
	public void GetLinkActivityInfoFromServer(uint httpOp = 0u, bool updateEntryTick = true)
	{
	}

	[Token(Token = "0x601481F")]
	[Address(RVA = "0x32862B0", Offset = "0x32862B0", VA = "0x32862B0")]
	public void ClaimReward()
	{
	}

	[Token(Token = "0x6014820")]
	[Address(RVA = "0x3286304", Offset = "0x3286304", VA = "0x3286304")]
	public void ClaimOpenGame()
	{
	}

	[Token(Token = "0x6014821")]
	[Address(RVA = "0x3286410", Offset = "0x3286410", VA = "0x3286410")]
	public void ClaimPVEProcessReward(uint processID, bool isBatchClaim, [Optional] Action<List<CommonRewardItemInfo>, string> callBack)
	{
	}

	[Token(Token = "0x6014822")]
	[Address(RVA = "0x32864FC", Offset = "0x32864FC", VA = "0x32864FC")]
	public void BatchClaimPVEProcessReward(List<uint> processIDs)
	{
	}

	[Token(Token = "0x6014823")]
	[Address(RVA = "0x3286780", Offset = "0x3286780", VA = "0x3286780")]
	private void OnTreasureBatchOpenCallback(List<CommonRewardItemInfo> list, string hint)
	{
	}

	[Token(Token = "0x6014824")]
	[Address(RVA = "0x32869EC", Offset = "0x32869EC", VA = "0x32869EC")]
	public void AutoOpenBundle(uint item_id, bool isBatchOpen, [Optional] Action<List<CommonRewardItemInfo>, string> callBack)
	{
	}

	[Token(Token = "0x6014825")]
	private void SendServerRequest<T>(ServiceMessageTypeHTTP cmd, Action<T> callback, uint httpOp = 0u) where T : class
	{
	}

	[Token(Token = "0x6014826")]
	private void SendServerRequestByParam<T>(ServiceMessageTypeHTTP cmd, [Optional] Action<T> callback, [Optional] object param, uint httpOp = 0u) where T : class
	{
	}

	[Token(Token = "0x6014827")]
	[Address(RVA = "0x3286C94", Offset = "0x3286C94", VA = "0x3286C94")]
	public void GetLinkEquipSetInfoFromServer(uint httpOp = 0u, bool updateEntryTick = true)
	{
	}

	[Token(Token = "0x6014828")]
	[Address(RVA = "0x3286DB4", Offset = "0x3286DB4", VA = "0x3286DB4")]
	private void SetTips(bool updateEntryTick)
	{
	}

	[Token(Token = "0x6014829")]
	[Address(RVA = "0x3286E48", Offset = "0x3286E48", VA = "0x3286E48")]
	private void UpdateTipToday(ETipsType type)
	{
	}

	[Token(Token = "0x601482A")]
	[Address(RVA = "0x3287010", Offset = "0x3287010", VA = "0x3287010")]
	private string GetPrefKey(ETipsType type)
	{
		return null;
	}

	[Token(Token = "0x601482B")]
	[Address(RVA = "0x32870E0", Offset = "0x32870E0", VA = "0x32870E0")]
	public void OnClearTipToday(ETipsType type)
	{
	}

	[Token(Token = "0x601482C")]
	[Address(RVA = "0x32871F0", Offset = "0x32871F0", VA = "0x32871F0")]
	private void _003CGetLinkEquipSetInfoFromServer_003Em__0(CSGetLinkEquipSetRes data)
	{
	}
}
