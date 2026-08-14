using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20030F8")]
public class UIModelLobbyAds : UIBaseModel
{
	[Token(Token = "0x20030F9")]
	public class AdInfo : _Attribute
	{
		[Token(Token = "0x40129FB")]
		[FieldOffset(Offset = "0x8")]
		public string url;

		[Token(Token = "0x40129FC")]
		[FieldOffset(Offset = "0xC")]
		public uint goPos;

		[Token(Token = "0x40129FD")]
		[FieldOffset(Offset = "0x10")]
		public string goSubPos;

		[Token(Token = "0x40129FE")]
		[FieldOffset(Offset = "0x14")]
		public uint sortId;

		[Token(Token = "0x40129FF")]
		[FieldOffset(Offset = "0x18")]
		public uint optGroupId;

		[Token(Token = "0x4012A00")]
		[FieldOffset(Offset = "0x1C")]
		public uint optActivityId;

		[Token(Token = "0x4012A01")]
		[FieldOffset(Offset = "0x20")]
		public uint optAnnouncementId;

		[Token(Token = "0x4012A02")]
		[FieldOffset(Offset = "0x24")]
		public uint optCountdownStyle;

		[Token(Token = "0x4012A03")]
		[FieldOffset(Offset = "0x28")]
		public ulong optStartTime;

		[Token(Token = "0x4012A04")]
		[FieldOffset(Offset = "0x30")]
		public ulong optEndTime;

		[Token(Token = "0x4012A05")]
		[FieldOffset(Offset = "0x38")]
		public string lastNum;

		[Token(Token = "0x4012A06")]
		[FieldOffset(Offset = "0x3C")]
		public object source;

		[Token(Token = "0x17001565")]
		public uint ID
		{
			[Token(Token = "0x6014867")]
			[Address(RVA = "0x328C5D4", Offset = "0x328C5D4", VA = "0x328C5D4")]
			get
			{
				return default(uint);
			}
		}

		[Token(Token = "0x6014862")]
		[Address(RVA = "0x328A4F8", Offset = "0x328A4F8", VA = "0x328A4F8")]
		public AdInfo(AnnoucementInfo info, bool IsNewAnnouncement = false)
		{
		}

		[Token(Token = "0x6014863")]
		[Address(RVA = "0x328A97C", Offset = "0x328A97C", VA = "0x328A97C")]
		public AdInfo(ActivityGroupDesc group)
		{
		}

		[Token(Token = "0x6014864")]
		[Address(RVA = "0x328AEBC", Offset = "0x328AEBC", VA = "0x328AEBC")]
		public AdInfo(AdvertDesc advert)
		{
		}

		[Token(Token = "0x6014865")]
		[Address(RVA = "0x328C42C", Offset = "0x328C42C", VA = "0x328C42C")]
		public AdInfo(string cdnUrl, uint inGoPos, string inGoPosParam, uint inSortId)
		{
		}

		[Token(Token = "0x6014866")]
		[Address(RVA = "0x328C4F4", Offset = "0x328C4F4", VA = "0x328C4F4")]
		public AdInfo(BermudaIntroDesc info)
		{
		}

		[Token(Token = "0x6014868")]
		[Address(RVA = "0x328C638", Offset = "0x328C638", VA = "0x328C638", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Token(Token = "0x6014869")]
		[Address(RVA = "0x328C790", Offset = "0x328C790", VA = "0x328C790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Token(Token = "0x601486A")]
		[Address(RVA = "0x328C7F0", Offset = "0x328C7F0", VA = "0x328C7F0", Slot = "4")]
		public int CompareTo(AdInfo other)
		{
			return default(int);
		}

		[Token(Token = "0x601486B")]
		[Address(RVA = "0x328C894", Offset = "0x328C894", VA = "0x328C894")]
		public bool _003C_003EiFixBaseProxy_Equals(object P0)
		{
			return default(bool);
		}

		[Token(Token = "0x601486C")]
		[Address(RVA = "0x328C89C", Offset = "0x328C89C", VA = "0x328C89C")]
		public int _003C_003EiFixBaseProxy_GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x40129F1")]
	[FieldOffset(Offset = "0xC")]
	private List<AdInfo> m_AnnouncementAdList;

	[Token(Token = "0x40129F2")]
	[FieldOffset(Offset = "0x10")]
	private List<AdInfo> m_EventAdList;

	[Token(Token = "0x40129F3")]
	[FieldOffset(Offset = "0x14")]
	private List<AdInfo> m_CDNAdList;

	[Token(Token = "0x40129F4")]
	[FieldOffset(Offset = "0x18")]
	private List<AdInfo> m_AllAdList;

	[Token(Token = "0x40129F5")]
	public const int PropID_UpdateLobbyAds = 2;

	[Token(Token = "0x40129F6")]
	private const string LOBBYEXTRAADS_ID_NEW = "LobbyExtraAds{0}";

	[Token(Token = "0x40129F7")]
	private const string LOBBYEXTRAADS_CLICKED = "LobbyExtraAdsClicked{0}";

	[Token(Token = "0x40129F8")]
	private const string LOBBYEXTRAADS_ACCOUNT_CLICKED = "LobbyExtraAdsClicked{0}{1}";

	[Token(Token = "0x40129F9")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<AdInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40129FA")]
	[FieldOffset(Offset = "0x4")]
	private static Comparison<AdvertDesc> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17001564")]
	public List<AdInfo> AdList
	{
		[Token(Token = "0x601484E")]
		[Address(RVA = "0x3289EF8", Offset = "0x3289EF8", VA = "0x3289EF8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x601484B")]
	[Address(RVA = "0x3289B9C", Offset = "0x3289B9C", VA = "0x3289B9C")]
	public UIModelLobbyAds()
	{
	}

	[Token(Token = "0x601484C")]
	[Address(RVA = "0x3289C9C", Offset = "0x3289C9C", VA = "0x3289C9C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601484D")]
	[Address(RVA = "0x3289DD0", Offset = "0x3289DD0", VA = "0x3289DD0", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x601484F")]
	[Address(RVA = "0x328A110", Offset = "0x328A110", VA = "0x328A110")]
	private void UpdateAnnouncementAdList(object[] data)
	{
	}

	[Token(Token = "0x6014850")]
	[Address(RVA = "0x328A178", Offset = "0x328A178", VA = "0x328A178")]
	public void UpdateAnnouncementAdList()
	{
	}

	[Token(Token = "0x6014851")]
	[Address(RVA = "0x328A670", Offset = "0x328A670", VA = "0x328A670")]
	public void UpdateEventAdList()
	{
	}

	[Token(Token = "0x6014852")]
	[Address(RVA = "0x328AB4C", Offset = "0x328AB4C", VA = "0x328AB4C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014853")]
	[Address(RVA = "0x328ABA4", Offset = "0x328ABA4", VA = "0x328ABA4")]
	public void GetLobbyAdRes()
	{
	}

	[Token(Token = "0x6014854")]
	[Address(RVA = "0x328B050", Offset = "0x328B050", VA = "0x328B050")]
	public List<AdvertDesc> GetLobbyExtraAdRes()
	{
		return null;
	}

	[Token(Token = "0x6014855")]
	[Address(RVA = "0x328B340", Offset = "0x328B340", VA = "0x328B340")]
	public bool IsLobbyExtraAdsNewID(uint cdnID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014856")]
	[Address(RVA = "0x328B494", Offset = "0x328B494", VA = "0x328B494")]
	public bool IsLobbyExtraAdsUnClicked(int extraIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6014857")]
	[Address(RVA = "0x328B5F8", Offset = "0x328B5F8", VA = "0x328B5F8")]
	public bool IsLobbyExtraAdsUnClicked(ulong accountID, uint cdnID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014858")]
	[Address(RVA = "0x328B794", Offset = "0x328B794", VA = "0x328B794")]
	public bool IsExtraAdTimeOut(uint cdnID)
	{
		return default(bool);
	}

	[Token(Token = "0x6014859")]
	[Address(RVA = "0x328BDE4", Offset = "0x328BDE4", VA = "0x328BDE4")]
	public void SetExtraAdPrefNewID(uint cdnID, ulong value = 0uL)
	{
	}

	[Token(Token = "0x601485A")]
	[Address(RVA = "0x328BFA4", Offset = "0x328BFA4", VA = "0x328BFA4")]
	public void SetExtraAdClicked(int extraIdx)
	{
	}

	[Token(Token = "0x601485B")]
	[Address(RVA = "0x328C0F8", Offset = "0x328C0F8", VA = "0x328C0F8")]
	public void SetExtraAdClicked(ulong accountID, uint cdnID)
	{
	}

	[Token(Token = "0x601485C")]
	[Address(RVA = "0x328BC54", Offset = "0x328BC54", VA = "0x328BC54")]
	public ulong GetExtraAdPrefValue(uint cdnID)
	{
		return default(ulong);
	}

	[Token(Token = "0x601485D")]
	[Address(RVA = "0x328C284", Offset = "0x328C284", VA = "0x328C284")]
	public bool IsExtraAdLastDay(uint endTimeStamp)
	{
		return default(bool);
	}

	[Token(Token = "0x601485E")]
	[Address(RVA = "0x328C378", Offset = "0x328C378", VA = "0x328C378")]
	private static int _003Cget_AdList_003Em__0(AdInfo x, AdInfo y)
	{
		return default(int);
	}

	[Token(Token = "0x601485F")]
	[Address(RVA = "0x328C3C0", Offset = "0x328C3C0", VA = "0x328C3C0")]
	private static int _003CGetLobbyExtraAdRes_003Em__1(AdvertDesc a, AdvertDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014860")]
	[Address(RVA = "0x328C41C", Offset = "0x328C41C", VA = "0x328C41C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014861")]
	[Address(RVA = "0x328C424", Offset = "0x328C424", VA = "0x328C424")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}
}
