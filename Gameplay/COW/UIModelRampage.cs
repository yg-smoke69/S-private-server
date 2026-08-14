using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20031EA")]
public class UIModelRampage : UIBaseModel, _Attribute
{
	[Token(Token = "0x20031EB")]
	public class NotifyArgsPurchase
	{
		[Token(Token = "0x4013021")]
		[FieldOffset(Offset = "0x8")]
		public uint skuID;

		[Token(Token = "0x6015117")]
		[Address(RVA = "0x313DD0C", Offset = "0x313DD0C", VA = "0x313DD0C")]
		public NotifyArgsPurchase()
		{
		}
	}

	[Token(Token = "0x20031EC")]
	private sealed class _003CGetFactionPoints_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013022")]
		[FieldOffset(Offset = "0x8")]
		internal ELimitedEvent.RampageFaction faction;

		[Token(Token = "0x6015118")]
		[Address(RVA = "0x313A874", Offset = "0x313A874", VA = "0x313A874")]
		public _003CGetFactionPoints_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015119")]
		[Address(RVA = "0x313D428", Offset = "0x313D428", VA = "0x313D428")]
		internal bool _003C_003Em__0(RampagePoints e)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031ED")]
	private sealed class _003CGetEventOpenInfo_003Ec__AnonStorey1
	{
		[Token(Token = "0x4013023")]
		[FieldOffset(Offset = "0x8")]
		internal ELimitedEvent.EventState state;

		[Token(Token = "0x601511A")]
		[Address(RVA = "0x313AAEC", Offset = "0x313AAEC", VA = "0x313AAEC")]
		public _003CGetEventOpenInfo_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x601511B")]
		[Address(RVA = "0x313D3F0", Offset = "0x313D3F0", VA = "0x313D3F0")]
		internal bool _003C_003Em__0(BigEventOpenInfoDesc info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031EE")]
	private sealed class _003CGetStoreItemsList_003Ec__AnonStorey2
	{
		[Token(Token = "0x4013024")]
		[FieldOffset(Offset = "0x8")]
		internal uint level;

		[Token(Token = "0x601511C")]
		[Address(RVA = "0x313AC74", Offset = "0x313AC74", VA = "0x313AC74")]
		public _003CGetStoreItemsList_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601511D")]
		[Address(RVA = "0x313D498", Offset = "0x313D498", VA = "0x313D498")]
		internal bool _003C_003Em__0(LimitedEventStore store)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031EF")]
	private sealed class _003CGetRampageRankDesc_003Ec__AnonStorey3
	{
		[Token(Token = "0x4013025")]
		[FieldOffset(Offset = "0x8")]
		internal uint rank;

		[Token(Token = "0x601511E")]
		[Address(RVA = "0x313ADC0", Offset = "0x313ADC0", VA = "0x313ADC0")]
		public _003CGetRampageRankDesc_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601511F")]
		[Address(RVA = "0x313D460", Offset = "0x313D460", VA = "0x313D460")]
		internal bool _003C_003Em__0(RampageRankDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031F0")]
	private sealed class _003CRequestChooseFaction_003Ec__AnonStorey4
	{
		[Token(Token = "0x4013026")]
		[FieldOffset(Offset = "0x8")]
		internal ELimitedEvent.RampageFaction faction;

		[Token(Token = "0x4013027")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelRampage _0024this;

		[Token(Token = "0x6015120")]
		[Address(RVA = "0x313C68C", Offset = "0x313C68C", VA = "0x313C68C")]
		public _003CRequestChooseFaction_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6015121")]
		[Address(RVA = "0x313DD64", Offset = "0x313DD64", VA = "0x313DD64")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x20031F1")]
	private sealed class _003CRequesePurchase_003Ec__AnonStorey5
	{
		[Token(Token = "0x4013028")]
		[FieldOffset(Offset = "0x8")]
		internal BigEventStoreCommodityDesc desc;

		[Token(Token = "0x4013029")]
		[FieldOffset(Offset = "0xC")]
		internal uint cnt;

		[Token(Token = "0x401302A")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelRampage _0024this;

		[Token(Token = "0x6015122")]
		[Address(RVA = "0x313CCD8", Offset = "0x313CCD8", VA = "0x313CCD8")]
		public _003CRequesePurchase_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6015123")]
		[Address(RVA = "0x313D4E4", Offset = "0x313D4E4", VA = "0x313D4E4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015124")]
		[Address(RVA = "0x313DD14", Offset = "0x313DD14", VA = "0x313DD14")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x401300E")]
	public const uint Prop_PlayerInfoUpdate = 2u;

	[Token(Token = "0x401300F")]
	public const uint Prop_PurchaseSuccess = 4u;

	[Token(Token = "0x4013010")]
	public const uint Prop_StoreItemsRefresh = 8u;

	[Token(Token = "0x4013011")]
	public const uint Prop_GetEventStateInfoFinish = 16u;

	[Token(Token = "0x4013012")]
	public const uint Prop_SelfPointsUpdate = 32u;

	[Token(Token = "0x4013013")]
	public const uint Prop_SelfRankUpdate = 64u;

	[Token(Token = "0x4013014")]
	[FieldOffset(Offset = "0xC")]
	private ELimitedEvent.EventState m_EventState;

	[Token(Token = "0x4013015")]
	[FieldOffset(Offset = "0x10")]
	private List<LimitedEventStore> m_StoreList;

	[Token(Token = "0x4013016")]
	[FieldOffset(Offset = "0x14")]
	private List<BigEventOpenInfoDesc> m_EventOpenInfosList;

	[Token(Token = "0x4013017")]
	[FieldOffset(Offset = "0x18")]
	private RampageSettingDesc m_RampageSettingDesc;

	[Token(Token = "0x4013018")]
	[FieldOffset(Offset = "0x1C")]
	private List<RampagePoints> m_RampagePoints;

	[Token(Token = "0x4013019")]
	[FieldOffset(Offset = "0x20")]
	private CSGetPlayerRampageInfoRes m_RampagePlayerInfo;

	[Token(Token = "0x401301A")]
	[FieldOffset(Offset = "0x24")]
	private List<RampageRankDesc> m_RampageRankDesc;

	[Token(Token = "0x401301B")]
	[FieldOffset(Offset = "0x28")]
	public Dictionary<uint, string> FactionNameDict;

	[Token(Token = "0x401301C")]
	[FieldOffset(Offset = "0x2C")]
	private uint m_EvenID;

	[Token(Token = "0x401301D")]
	[FieldOffset(Offset = "0x30")]
	private string m_LobbyRankUpGuide;

	[Token(Token = "0x401301E")]
	[FieldOffset(Offset = "0x34")]
	private string m_StoreRankUpGuide;

	[Token(Token = "0x401301F")]
	[FieldOffset(Offset = "0x38")]
	private string m_LobbyStoreGuide;

	[Token(Token = "0x4013020")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<LimitedEventStore> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001631")]
	public RampageSettingDesc RampageSettingDesc
	{
		[Token(Token = "0x60150EE")]
		[Address(RVA = "0x313A300", Offset = "0x313A300", VA = "0x313A300")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60150E5")]
	[Address(RVA = "0x31398F0", Offset = "0x31398F0", VA = "0x31398F0")]
	public UIModelRampage()
	{
	}

	[Token(Token = "0x60150E6")]
	[Address(RVA = "0x3139C20", Offset = "0x3139C20", VA = "0x3139C20", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60150E7")]
	[Address(RVA = "0x3139C78", Offset = "0x3139C78", VA = "0x3139C78", Slot = "15")]
	public UIBigEventLobbyEnterWndControler GetBigEventLobbyEnterWnd()
	{
		return null;
	}

	[Token(Token = "0x60150E8")]
	[Address(RVA = "0x3139D88", Offset = "0x3139D88", VA = "0x3139D88", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60150E9")]
	[Address(RVA = "0x3139EC8", Offset = "0x3139EC8", VA = "0x3139EC8")]
	public ELimitedEvent.RampageFaction GetSelfSideType()
	{
		return default(ELimitedEvent.RampageFaction);
	}

	[Token(Token = "0x60150EA")]
	[Address(RVA = "0x3139F34", Offset = "0x3139F34", VA = "0x3139F34")]
	public ELimitedEvent.RampageFaction GetOpponentSideType()
	{
		return default(ELimitedEvent.RampageFaction);
	}

	[Token(Token = "0x60150EB")]
	[Address(RVA = "0x3139FA4", Offset = "0x3139FA4", VA = "0x3139FA4")]
	public bool SelfJoinedSide()
	{
		return default(bool);
	}

	[Token(Token = "0x60150EC")]
	[Address(RVA = "0x313A01C", Offset = "0x313A01C", VA = "0x313A01C")]
	public ELimitedEvent.EventState GetEventState()
	{
		return default(ELimitedEvent.EventState);
	}

	[Token(Token = "0x60150ED")]
	[Address(RVA = "0x313A2A8", Offset = "0x313A2A8", VA = "0x313A2A8")]
	public List<LimitedEventStore> GetStoreList()
	{
		return null;
	}

	[Token(Token = "0x60150EF")]
	[Address(RVA = "0x313A358", Offset = "0x313A358", VA = "0x313A358")]
	private void ProcessEventState()
	{
	}

	[Token(Token = "0x60150F0")]
	[Address(RVA = "0x313A4F0", Offset = "0x313A4F0", VA = "0x313A4F0")]
	private void ProcseeEventSettingInfo(CSGetRampageSettingRes res)
	{
	}

	[Token(Token = "0x60150F1")]
	[Address(RVA = "0x313A55C", Offset = "0x313A55C", VA = "0x313A55C")]
	private void ProcessRampagePoints(CSGetProcessRampagePointsRes res)
	{
	}

	[Token(Token = "0x60150F2")]
	[Address(RVA = "0x313A5C8", Offset = "0x313A5C8", VA = "0x313A5C8")]
	private void ProcessRampageRank(CSGetRampageRankRes res)
	{
	}

	[Token(Token = "0x60150F3")]
	[Address(RVA = "0x313A080", Offset = "0x313A080", VA = "0x313A080")]
	private void RefreshEventState()
	{
	}

	[Token(Token = "0x60150F4")]
	[Address(RVA = "0x313A634", Offset = "0x313A634", VA = "0x313A634")]
	public ulong GetSelfPoints()
	{
		return default(ulong);
	}

	[Token(Token = "0x60150F5")]
	[Address(RVA = "0x313A6A8", Offset = "0x313A6A8", VA = "0x313A6A8")]
	public uint GetSelfRank()
	{
		return default(uint);
	}

	[Token(Token = "0x60150F6")]
	[Address(RVA = "0x313A714", Offset = "0x313A714", VA = "0x313A714")]
	public ulong GetFactionPoints(ELimitedEvent.RampageFaction faction)
	{
		return default(ulong);
	}

	[Token(Token = "0x60150F7")]
	[Address(RVA = "0x313A87C", Offset = "0x313A87C", VA = "0x313A87C")]
	public bool SelfFactionWin()
	{
		return default(bool);
	}

	[Token(Token = "0x60150F8")]
	[Address(RVA = "0x313A918", Offset = "0x313A918", VA = "0x313A918")]
	public ELimitedEvent.RampageFaction GetWinFactionType()
	{
		return default(ELimitedEvent.RampageFaction);
	}

	[Token(Token = "0x60150F9")]
	[Address(RVA = "0x313A9A4", Offset = "0x313A9A4", VA = "0x313A9A4")]
	public BigEventOpenInfoDesc GetEventOpenInfo(ELimitedEvent.EventState state)
	{
		return null;
	}

	[Token(Token = "0x60150FA")]
	[Address(RVA = "0x313AAF4", Offset = "0x313AAF4", VA = "0x313AAF4")]
	public List<BigEventStoreCommodityDesc> GetStoreItemsList(uint level)
	{
		return null;
	}

	[Token(Token = "0x60150FB")]
	[Address(RVA = "0x313AC7C", Offset = "0x313AC7C", VA = "0x313AC7C")]
	public RampageRankDesc GetRampageRankDesc(uint rank)
	{
		return null;
	}

	[Token(Token = "0x60150FC")]
	[Address(RVA = "0x313ADC8", Offset = "0x313ADC8", VA = "0x313ADC8")]
	public List<RampageRankDesc> GetAllRampageRankDesc()
	{
		return null;
	}

	[Token(Token = "0x60150FD")]
	[Address(RVA = "0x313AE20", Offset = "0x313AE20", VA = "0x313AE20")]
	public void RampagePointsUpdate(ulong points, uint rank)
	{
	}

	[Token(Token = "0x60150FE")]
	[Address(RVA = "0x313AEE4", Offset = "0x313AEE4", VA = "0x313AEE4")]
	private void UpdateSelfPoints(ulong points)
	{
	}

	[Token(Token = "0x60150FF")]
	[Address(RVA = "0x313AFE0", Offset = "0x313AFE0", VA = "0x313AFE0")]
	private void UpdateSelfRank(uint rank)
	{
	}

	[Token(Token = "0x6015100")]
	[Address(RVA = "0x313B3E4", Offset = "0x313B3E4", VA = "0x313B3E4")]
	private void RefreshRampageTipsNum()
	{
	}

	[Token(Token = "0x6015101")]
	[Address(RVA = "0x313B51C", Offset = "0x313B51C", VA = "0x313B51C")]
	public void UpdateRampagePeakDayAward()
	{
	}

	[Token(Token = "0x6015102")]
	[Address(RVA = "0x313B0E4", Offset = "0x313B0E4", VA = "0x313B0E4")]
	public void SetLobbyRankUpGuide(uint rank)
	{
	}

	[Token(Token = "0x6015103")]
	[Address(RVA = "0x313B1C4", Offset = "0x313B1C4", VA = "0x313B1C4")]
	public void SetStoreRankUpGuide(uint rank)
	{
	}

	[Token(Token = "0x6015104")]
	[Address(RVA = "0x313B878", Offset = "0x313B878", VA = "0x313B878")]
	public void SetLobbyStoreGuide()
	{
	}

	[Token(Token = "0x6015105")]
	[Address(RVA = "0x313B950", Offset = "0x313B950", VA = "0x313B950")]
	public int GetLobbyRankUpGuide()
	{
		return default(int);
	}

	[Token(Token = "0x6015106")]
	[Address(RVA = "0x313BA28", Offset = "0x313BA28", VA = "0x313BA28")]
	public int GetStoreRankUpGuide()
	{
		return default(int);
	}

	[Token(Token = "0x6015107")]
	[Address(RVA = "0x313BB00", Offset = "0x313BB00", VA = "0x313BB00")]
	public int GetLobbyStoreGuide()
	{
		return default(int);
	}

	[Token(Token = "0x6015108")]
	[Address(RVA = "0x313B2A4", Offset = "0x313B2A4", VA = "0x313B2A4")]
	public void RefreshShopTipsNum(int num)
	{
	}

	[Token(Token = "0x6015109")]
	[Address(RVA = "0x313BBD8", Offset = "0x313BBD8", VA = "0x313BBD8")]
	public void RefreshAwardTipsNum(int num)
	{
	}

	[Token(Token = "0x601510A")]
	[Address(RVA = "0x313BD18", Offset = "0x313BD18", VA = "0x313BD18")]
	public void RefreshSignInTipsNum(int num)
	{
	}

	[Token(Token = "0x601510B")]
	[Address(RVA = "0x313B738", Offset = "0x313B738", VA = "0x313B738")]
	public void RefreshPeakDayAwardTipsNum(int num)
	{
	}

	[Token(Token = "0x601510C")]
	[Address(RVA = "0x313BE58", Offset = "0x313BE58", VA = "0x313BE58")]
	public void GetStoreRes(ELimitedEvent.RampageFaction sideType)
	{
	}

	[Token(Token = "0x601510D")]
	[Address(RVA = "0x313C0EC", Offset = "0x313C0EC", VA = "0x313C0EC", Slot = "14")]
	public void OnProcessEventOpenInfo()
	{
	}

	[Token(Token = "0x601510E")]
	[Address(RVA = "0x313C1C4", Offset = "0x313C1C4", VA = "0x313C1C4")]
	public void RequestAccountRampageInfo(uint option = 0u)
	{
	}

	[Token(Token = "0x601510F")]
	[Address(RVA = "0x313C3EC", Offset = "0x313C3EC", VA = "0x313C3EC")]
	public void RequestChooseFaction(ELimitedEvent.RampageFaction faction)
	{
	}

	[Token(Token = "0x6015110")]
	[Address(RVA = "0x313C694", Offset = "0x313C694", VA = "0x313C694")]
	public void RequesePurchase(BigEventStoreCommodityDesc desc, uint cnt = 1u)
	{
	}

	[Token(Token = "0x6015111")]
	[Address(RVA = "0x313CCE0", Offset = "0x313CCE0", VA = "0x313CCE0")]
	public HttpRequest RequestRampageConfig(uint option = 0u)
	{
		return null;
	}

	[Token(Token = "0x6015112")]
	[Address(RVA = "0x313CF08", Offset = "0x313CF08", VA = "0x313CF08")]
	private void _003CGetStoreRes_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015113")]
	[Address(RVA = "0x313D128", Offset = "0x313D128", VA = "0x313D128")]
	private void _003CRequestAccountRampageInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015114")]
	[Address(RVA = "0x313D25C", Offset = "0x313D25C", VA = "0x313D25C")]
	private void _003CRequestRampageConfig_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015115")]
	[Address(RVA = "0x313D378", Offset = "0x313D378", VA = "0x313D378")]
	private static int _003CGetStoreRes_003Em__3(LimitedEventStore a, LimitedEventStore b)
	{
		return default(int);
	}

	[Token(Token = "0x6015116")]
	[Address(RVA = "0x313D3E8", Offset = "0x313D3E8", VA = "0x313D3E8")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
