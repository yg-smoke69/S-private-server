using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002F9B")]
public class UIModelClanRace : UIBaseModel
{
	[Token(Token = "0x2002F9C")]
	private sealed class _003CRequestClanInfo_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012272")]
		[FieldOffset(Offset = "0x8")]
		internal Action onFinish;

		[Token(Token = "0x4012273")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClanRace _0024this;

		[Token(Token = "0x6013E7C")]
		[Address(RVA = "0x3410774", Offset = "0x3410774", VA = "0x3410774")]
		public _003CRequestClanInfo_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6013E7D")]
		[Address(RVA = "0x34131FC", Offset = "0x34131FC", VA = "0x34131FC")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2002F9D")]
	private sealed class _003CHasClaimIndividualItem_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012274")]
		[FieldOffset(Offset = "0x8")]
		internal uint stage;

		[Token(Token = "0x6013E7E")]
		[Address(RVA = "0x34110C4", Offset = "0x34110C4", VA = "0x34110C4")]
		public _003CHasClaimIndividualItem_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6013E7F")]
		[Address(RVA = "0x34131C4", Offset = "0x34131C4", VA = "0x34131C4")]
		internal bool _003C_003Em__0(RaceAwardExchange temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002F9E")]
	private sealed class _003CExchangeAwardWithRP_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012275")]
		[FieldOffset(Offset = "0x8")]
		internal uint stage;

		[Token(Token = "0x4012276")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelClanRace _0024this;

		[Token(Token = "0x6013E80")]
		[Address(RVA = "0x3412280", Offset = "0x3412280", VA = "0x3412280")]
		public _003CExchangeAwardWithRP_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6013E81")]
		[Address(RVA = "0x3412B3C", Offset = "0x3412B3C", VA = "0x3412B3C")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6013E82")]
		[Address(RVA = "0x3413154", Offset = "0x3413154", VA = "0x3413154")]
		internal bool _003C_003Em__1(ClanRaceRewardsDesc temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6013E83")]
		[Address(RVA = "0x341318C", Offset = "0x341318C", VA = "0x341318C")]
		internal bool _003C_003Em__2(RaceAwardExchange temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012267")]
	public const uint PropID_GetClanRaceInfo = 2u;

	[Token(Token = "0x4012268")]
	public const uint PropID_ClaimClanRaceAward = 4u;

	[Token(Token = "0x4012269")]
	public const uint PropID_ExchangeAwardWithRP = 8u;

	[Token(Token = "0x401226A")]
	public const uint PropID_ClaimClanAwardError_NoPermission = 16u;

	[Token(Token = "0x401226B")]
	public const uint PropID_ClaimClanAwardError_AlreadyClaimed = 32u;

	[Token(Token = "0x401226C")]
	public const uint PropID_GetClanRaceInfoNoCalculate = 64u;

	[Token(Token = "0x401226D")]
	[FieldOffset(Offset = "0xC")]
	private bool m_HasCalculateExInfo;

	[Token(Token = "0x401226E")]
	[FieldOffset(Offset = "0xD")]
	private bool _003Cm_HasShowLobbyIconAnimSinceLogin_003Ek__BackingField;

	[Token(Token = "0x401226F")]
	[FieldOffset(Offset = "0xE")]
	private bool _003Cm_HasGetClanRaceInfoSinceLogin_003Ek__BackingField;

	[Token(Token = "0x4012270")]
	[FieldOffset(Offset = "0x10")]
	private CSGetClanRaceInfoRes _003Cm_ClanRaceInfo_003Ek__BackingField;

	[Token(Token = "0x4012271")]
	[FieldOffset(Offset = "0x14")]
	private WaitingResponseHandler m_WaitingHandler;

	[Token(Token = "0x170014AD")]
	public bool m_HasShowLobbyIconAnimSinceLogin
	{
		[Token(Token = "0x6013E5F")]
		[Address(RVA = "0x3410084", Offset = "0x3410084", VA = "0x3410084")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013E5E")]
		[Address(RVA = "0x341007C", Offset = "0x341007C", VA = "0x341007C")]
		set
		{
		}
	}

	[Token(Token = "0x170014AE")]
	public bool m_HasGetClanRaceInfoSinceLogin
	{
		[Token(Token = "0x6013E61")]
		[Address(RVA = "0x3410094", Offset = "0x3410094", VA = "0x3410094")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6013E60")]
		[Address(RVA = "0x341008C", Offset = "0x341008C", VA = "0x341008C")]
		private set
		{
		}
	}

	[Token(Token = "0x170014AF")]
	public CSGetClanRaceInfoRes m_ClanRaceInfo
	{
		[Token(Token = "0x6013E63")]
		[Address(RVA = "0x34100A4", Offset = "0x34100A4", VA = "0x34100A4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013E62")]
		[Address(RVA = "0x341009C", Offset = "0x341009C", VA = "0x341009C")]
		private set
		{
		}
	}

	[Token(Token = "0x6013E5D")]
	[Address(RVA = "0x340FFD4", Offset = "0x340FFD4", VA = "0x340FFD4")]
	public UIModelClanRace()
	{
	}

	[Token(Token = "0x6013E64")]
	[Address(RVA = "0x34100AC", Offset = "0x34100AC", VA = "0x34100AC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013E65")]
	[Address(RVA = "0x3410104", Offset = "0x3410104", VA = "0x3410104", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6013E66")]
	[Address(RVA = "0x3410188", Offset = "0x3410188", VA = "0x3410188", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013E67")]
	[Address(RVA = "0x3410228", Offset = "0x3410228", VA = "0x3410228")]
	public void ResetClanRaceInfo()
	{
	}

	[Token(Token = "0x6013E68")]
	[Address(RVA = "0x3410330", Offset = "0x3410330", VA = "0x3410330")]
	public void GetClanRaceInfoNoCalculate()
	{
	}

	[Token(Token = "0x6013E69")]
	[Address(RVA = "0x3410408", Offset = "0x3410408", VA = "0x3410408")]
	private void RequestClanInfo(Action onFinish)
	{
	}

	[Token(Token = "0x6013E6A")]
	[Address(RVA = "0x341077C", Offset = "0x341077C", VA = "0x341077C")]
	public void GetClanRaceInfo(bool forceUpdate = true)
	{
	}

	[Token(Token = "0x6013E6B")]
	[Address(RVA = "0x341087C", Offset = "0x341087C", VA = "0x341087C")]
	private void OnGetClanRaceInfo()
	{
	}

	[Token(Token = "0x6013E6C")]
	[Address(RVA = "0x3410F04", Offset = "0x3410F04", VA = "0x3410F04")]
	public bool HasClaimIndividualItem(uint stage)
	{
		return default(bool);
	}

	[Token(Token = "0x6013E6D")]
	[Address(RVA = "0x3410B6C", Offset = "0x3410B6C", VA = "0x3410B6C")]
	public bool CanClaimClanItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6013E6E")]
	[Address(RVA = "0x3411204", Offset = "0x3411204", VA = "0x3411204")]
	public void SetCloseRace()
	{
	}

	[Token(Token = "0x6013E6F")]
	[Address(RVA = "0x34112F0", Offset = "0x34112F0", VA = "0x34112F0")]
	public ulong GetOpenEndTime()
	{
		return default(ulong);
	}

	[Token(Token = "0x6013E70")]
	[Address(RVA = "0x3411378", Offset = "0x3411378", VA = "0x3411378")]
	public string GetWeekTimeFormat()
	{
		return null;
	}

	[Token(Token = "0x6013E71")]
	[Address(RVA = "0x34114A4", Offset = "0x34114A4", VA = "0x34114A4")]
	public string GetShortKeyByDayOfWeek(DayOfWeek day)
	{
		return null;
	}

	[Token(Token = "0x6013E72")]
	[Address(RVA = "0x34110CC", Offset = "0x34110CC", VA = "0x34110CC")]
	public bool GetClaimState(ulong time)
	{
		return default(bool);
	}

	[Token(Token = "0x6013E73")]
	[Address(RVA = "0x3411628", Offset = "0x3411628", VA = "0x3411628")]
	public void ClaimClanRaceAward()
	{
	}

	[Token(Token = "0x6013E74")]
	[Address(RVA = "0x3411C28", Offset = "0x3411C28", VA = "0x3411C28")]
	private bool ContainsAttachment()
	{
		return default(bool);
	}

	[Token(Token = "0x6013E75")]
	[Address(RVA = "0x3410DD4", Offset = "0x3410DD4", VA = "0x3410DD4")]
	public uint GetMyPoints()
	{
		return default(uint);
	}

	[Token(Token = "0x6013E76")]
	[Address(RVA = "0x3411E04", Offset = "0x3411E04", VA = "0x3411E04")]
	public void ExchangeAwardWithRP(uint stage)
	{
	}

	[Token(Token = "0x6013E77")]
	[Address(RVA = "0x3412288", Offset = "0x3412288", VA = "0x3412288")]
	private int ChangeTipsNum(int delta = -1)
	{
		return default(int);
	}

	[Token(Token = "0x6013E78")]
	[Address(RVA = "0x341239C", Offset = "0x341239C", VA = "0x341239C")]
	private void _003CGetClanRaceInfoNoCalculate_003Em__0()
	{
	}

	[Token(Token = "0x6013E79")]
	[Address(RVA = "0x341241C", Offset = "0x341241C", VA = "0x341241C")]
	private void _003CClaimClanRaceAward_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6013E7A")]
	[Address(RVA = "0x3412B2C", Offset = "0x3412B2C", VA = "0x3412B2C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6013E7B")]
	[Address(RVA = "0x3412B34", Offset = "0x3412B34", VA = "0x3412B34")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
