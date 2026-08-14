using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200318D")]
public class UIModelMysteryMall : UIBaseModel
{
	[Token(Token = "0x200318E")]
	public enum ELuckyDrawFrom
	{
		[Token(Token = "0x4012D72")]
		DEFAULT,
		[Token(Token = "0x4012D73")]
		ENTRANCE,
		[Token(Token = "0x4012D74")]
		BUYBUTTON,
		[Token(Token = "0x4012D75")]
		ADVERTISE,
		[Token(Token = "0x4012D76")]
		PAYMENTDIAMONDEVENT
	}

	[Token(Token = "0x200318F")]
	public class DiscountShow
	{
		[Token(Token = "0x4012D77")]
		[FieldOffset(Offset = "0x8")]
		public Color topColor;

		[Token(Token = "0x4012D78")]
		[FieldOffset(Offset = "0x18")]
		public Color bottomColor;

		[Token(Token = "0x4012D79")]
		[FieldOffset(Offset = "0x28")]
		public Color tabColor;

		[Token(Token = "0x4012D7A")]
		[FieldOffset(Offset = "0x38")]
		public Color vfxColor;

		[Token(Token = "0x6014D5F")]
		[Address(RVA = "0x177A1D0", Offset = "0x177A1D0", VA = "0x177A1D0")]
		public DiscountShow(uint topColor, uint bottomColor, uint tabColor, uint vfxColor)
		{
		}
	}

	[Token(Token = "0x2003190")]
	private sealed class _003CGetMysteryMallDescById_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012D7B")]
		[FieldOffset(Offset = "0x8")]
		internal uint shopId;

		[Token(Token = "0x6014D60")]
		[Address(RVA = "0x177AE58", Offset = "0x177AE58", VA = "0x177AE58")]
		public _003CGetMysteryMallDescById_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014D61")]
		[Address(RVA = "0x177DD8C", Offset = "0x177DD8C", VA = "0x177DD8C")]
		internal bool _003C_003Em__0(MysteryShopExpressionDesc value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003191")]
	private sealed class _003CSetMysteryMallDescById_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012D7C")]
		[FieldOffset(Offset = "0x8")]
		internal uint shopId;

		[Token(Token = "0x6014D62")]
		[Address(RVA = "0x177B404", Offset = "0x177B404", VA = "0x177B404")]
		public _003CSetMysteryMallDescById_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014D63")]
		[Address(RVA = "0x177F588", Offset = "0x177F588", VA = "0x177F588")]
		internal bool _003C_003Em__0(MysteryShopExpressionDesc value)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003192")]
	private sealed class _003CRequestGetAllMysteryMallInfo_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012D7D")]
		[FieldOffset(Offset = "0x8")]
		internal bool isLobbyEnter;

		[Token(Token = "0x4012D7E")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMysteryMall _0024this;

		[Token(Token = "0x6014D64")]
		[Address(RVA = "0x177C654", Offset = "0x177C654", VA = "0x177C654")]
		public _003CRequestGetAllMysteryMallInfo_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014D65")]
		[Address(RVA = "0x177DDC4", Offset = "0x177DDC4", VA = "0x177DDC4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003193")]
	private sealed class _003CRequestGetMysteryMallInfo_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012D7F")]
		[FieldOffset(Offset = "0x8")]
		internal uint shopId;

		[Token(Token = "0x4012D80")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMysteryMall _0024this;

		[Token(Token = "0x6014D66")]
		[Address(RVA = "0x177C958", Offset = "0x177C958", VA = "0x177C958")]
		public _003CRequestGetMysteryMallInfo_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014D67")]
		[Address(RVA = "0x177E120", Offset = "0x177E120", VA = "0x177E120")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003194")]
	private sealed class _003CRequestPurchaseMysteryItem_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012D81")]
		[FieldOffset(Offset = "0x8")]
		internal MysteryPoolStoreItem storeDesc;

		[Token(Token = "0x4012D82")]
		[FieldOffset(Offset = "0xC")]
		internal uint cnt;

		[Token(Token = "0x4012D83")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMysteryMall _0024this;

		[Token(Token = "0x6014D68")]
		[Address(RVA = "0x177D074", Offset = "0x177D074", VA = "0x177D074")]
		public _003CRequestPurchaseMysteryItem_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014D69")]
		[Address(RVA = "0x177EBF0", Offset = "0x177EBF0", VA = "0x177EBF0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003195")]
	private sealed class _003CRequestMysteryMallLuckyDraw_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012D84")]
		[FieldOffset(Offset = "0x8")]
		internal CSGetMysteryLuckyDrawReq req;

		[Token(Token = "0x4012D85")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMysteryMall _0024this;

		[Token(Token = "0x6014D6A")]
		[Address(RVA = "0x177D3A4", Offset = "0x177D3A4", VA = "0x177D3A4")]
		public _003CRequestMysteryMallLuckyDraw_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014D6B")]
		[Address(RVA = "0x177E9F4", Offset = "0x177E9F4", VA = "0x177E9F4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003196")]
	private sealed class _003CRequestGetMysteryPool_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012D86")]
		[FieldOffset(Offset = "0x8")]
		internal uint poolId;

		[Token(Token = "0x4012D87")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMysteryMall _0024this;

		[Token(Token = "0x6014D6C")]
		[Address(RVA = "0x177D73C", Offset = "0x177D73C", VA = "0x177D73C")]
		public _003CRequestGetMysteryPool_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014D6D")]
		[Address(RVA = "0x177E2B0", Offset = "0x177E2B0", VA = "0x177E2B0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x4012D5E")]
	public const int PropID_RefreshMysteryPoolSwitch = 2;

	[Token(Token = "0x4012D5F")]
	public const int PropID_GetMysteryLuckyDraw = 4;

	[Token(Token = "0x4012D60")]
	public const int PropID_GetMysteryPoolInfo = 8;

	[Token(Token = "0x4012D61")]
	public const int PropID_RefreshMysteryMall = 16;

	[Token(Token = "0x4012D62")]
	public const int PropID_RefreshMysteryMallInfo = 32;

	[Token(Token = "0x4012D63")]
	public const int PropID_GetMysteryShopProbability = 64;

	[Token(Token = "0x4012D64")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, uint> m_LastPoolIdDict;

	[Token(Token = "0x4012D65")]
	[FieldOffset(Offset = "0x10")]
	private ELuckyDrawFrom m_LuckyDrawFrom;

	[Token(Token = "0x4012D66")]
	private const int MAX_MALL_COUNT = 3;

	[Token(Token = "0x4012D67")]
	[FieldOffset(Offset = "0x14")]
	private List<MysteryShopExpressionDesc> m_MysteryMallDescList;

	[Token(Token = "0x4012D68")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<uint, CSGetMysteryShopInfoRes> m_MysteryMallInfoDict;

	[Token(Token = "0x4012D69")]
	[FieldOffset(Offset = "0x1C")]
	private MysteryShopExpressionDesc m_MysteryMallDesc;

	[Token(Token = "0x4012D6A")]
	[FieldOffset(Offset = "0x20")]
	private CSGetMysteryShopInfoRes m_MysteryMallInfo;

	[Token(Token = "0x4012D6B")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<uint, CSGetMysteryPoolInfoRes> m_MysteryPoolInfoDict;

	[Token(Token = "0x4012D6C")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, ClientMysteryShopSwitchDesc> m_MysetryPoolDescDict;

	[Token(Token = "0x4012D6D")]
	private const string m_NewTipsKey = "MysteryMallLobbyNewTips";

	[Token(Token = "0x4012D6E")]
	private const uint EP_ITEM_ID = 803000000u;

	[Token(Token = "0x4012D6F")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, DiscountShow> m_DiscoutShowDict;

	[Token(Token = "0x4012D70")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<MysteryShopExpressionDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x170015E9")]
	public ELuckyDrawFrom LuckyDrawFrom
	{
		[Token(Token = "0x6014D34")]
		[Address(RVA = "0x1779F1C", Offset = "0x1779F1C", VA = "0x1779F1C")]
		get
		{
			return default(ELuckyDrawFrom);
		}
		[Token(Token = "0x6014D35")]
		[Address(RVA = "0x1779F74", Offset = "0x1779F74", VA = "0x1779F74")]
		set
		{
		}
	}

	[Token(Token = "0x6014D30")]
	[Address(RVA = "0x1779B48", Offset = "0x1779B48", VA = "0x1779B48")]
	public UIModelMysteryMall()
	{
	}

	[Token(Token = "0x6014D31")]
	[Address(RVA = "0x1779CD0", Offset = "0x1779CD0", VA = "0x1779CD0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6014D32")]
	[Address(RVA = "0x1779D28", Offset = "0x1779D28", VA = "0x1779D28")]
	public uint GetLastSelectPoolIdByShopId(uint shopId)
	{
		return default(uint);
	}

	[Token(Token = "0x6014D33")]
	[Address(RVA = "0x1779E34", Offset = "0x1779E34", VA = "0x1779E34")]
	public void SetLastSelectPoolIdByShopId(uint shopId, uint poolId)
	{
	}

	[Token(Token = "0x6014D36")]
	[Address(RVA = "0x1779FD4", Offset = "0x1779FD4", VA = "0x1779FD4", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6014D37")]
	[Address(RVA = "0x177A280", Offset = "0x177A280", VA = "0x177A280")]
	public DiscountShow GetDiscountShow()
	{
		return null;
	}

	[Token(Token = "0x6014D38")]
	[Address(RVA = "0x177A37C", Offset = "0x177A37C", VA = "0x177A37C")]
	public uint GetMyLuckyNum()
	{
		return default(uint);
	}

	[Token(Token = "0x6014D39")]
	[Address(RVA = "0x177A4D4", Offset = "0x177A4D4", VA = "0x177A4D4")]
	public MysteryShopExpressionDesc GetMysteryMallDesc()
	{
		return null;
	}

	[Token(Token = "0x6014D3A")]
	[Address(RVA = "0x177A52C", Offset = "0x177A52C", VA = "0x177A52C")]
	public void SetMysteryMallDesc(MysteryShopExpressionDesc desc)
	{
	}

	[Token(Token = "0x6014D3B")]
	[Address(RVA = "0x177A618", Offset = "0x177A618", VA = "0x177A618")]
	private bool IsThisMallBetweenStartEndTime(MysteryShopExpressionDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D3C")]
	[Address(RVA = "0x177A74C", Offset = "0x177A74C", VA = "0x177A74C")]
	public bool HasMysteryMall()
	{
		return default(bool);
	}

	[Token(Token = "0x6014D3D")]
	[Address(RVA = "0x177AAFC", Offset = "0x177AAFC", VA = "0x177AAFC")]
	public List<MysteryShopExpressionDesc> GetCurMallDescList()
	{
		return null;
	}

	[Token(Token = "0x6014D3E")]
	[Address(RVA = "0x177AD14", Offset = "0x177AD14", VA = "0x177AD14")]
	public MysteryShopExpressionDesc GetMysteryMallDescById(uint shopId)
	{
		return null;
	}

	[Token(Token = "0x6014D3F")]
	[Address(RVA = "0x177AE60", Offset = "0x177AE60", VA = "0x177AE60")]
	public bool HasCurrentMysteryMall()
	{
		return default(bool);
	}

	[Token(Token = "0x6014D40")]
	[Address(RVA = "0x177A3EC", Offset = "0x177A3EC", VA = "0x177A3EC")]
	public CSGetMysteryShopInfoRes GetMysteryMallInfo()
	{
		return null;
	}

	[Token(Token = "0x6014D41")]
	[Address(RVA = "0x177AED4", Offset = "0x177AED4", VA = "0x177AED4")]
	public CSGetMysteryShopInfoRes GetMysteryShopInfoResById(uint shopId)
	{
		return null;
	}

	[Token(Token = "0x6014D42")]
	[Address(RVA = "0x177AFB8", Offset = "0x177AFB8", VA = "0x177AFB8")]
	public bool IsSupperRewardAndSwitchPool(uint itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D43")]
	[Address(RVA = "0x177B2AC", Offset = "0x177B2AC", VA = "0x177B2AC")]
	public void SetMysteryMallDescById(uint shopId)
	{
	}

	[Token(Token = "0x6014D44")]
	[Address(RVA = "0x177B40C", Offset = "0x177B40C", VA = "0x177B40C")]
	public void SaveCurrentPhaseShopIdList()
	{
	}

	[Token(Token = "0x6014D45")]
	[Address(RVA = "0x177B75C", Offset = "0x177B75C", VA = "0x177B75C")]
	public bool IsShowNewTips()
	{
		return default(bool);
	}

	[Token(Token = "0x6014D46")]
	[Address(RVA = "0x177B8AC", Offset = "0x177B8AC", VA = "0x177B8AC")]
	public ulong GetTheLatestEndTimestamp()
	{
		return default(ulong);
	}

	[Token(Token = "0x6014D47")]
	[Address(RVA = "0x177B51C", Offset = "0x177B51C", VA = "0x177B51C")]
	public ulong GetTheLatestStartTimestamp()
	{
		return default(ulong);
	}

	[Token(Token = "0x6014D48")]
	[Address(RVA = "0x177A824", Offset = "0x177A824", VA = "0x177A824")]
	public MysteryShopExpressionDesc GetMallDescByPriority()
	{
		return null;
	}

	[Token(Token = "0x6014D49")]
	[Address(RVA = "0x177BAEC", Offset = "0x177BAEC", VA = "0x177BAEC")]
	public void SetMysteryMallDescList(CSGetMysteryExpressionRes res)
	{
	}

	[Token(Token = "0x6014D4A")]
	[Address(RVA = "0x177B110", Offset = "0x177B110", VA = "0x177B110")]
	public CSGetMysteryPoolInfoRes GetMysteryPoolInfoById(uint poolId)
	{
		return null;
	}

	[Token(Token = "0x6014D4B")]
	[Address(RVA = "0x177BC80", Offset = "0x177BC80", VA = "0x177BC80")]
	public ClientMysteryShopSwitchDesc GetMysteryPoolDescById(uint poolId)
	{
		return null;
	}

	[Token(Token = "0x6014D4C")]
	[Address(RVA = "0x177B1F8", Offset = "0x177B1F8", VA = "0x177B1F8")]
	public uint GetAnotherPoolId(uint curPoolId)
	{
		return default(uint);
	}

	[Token(Token = "0x6014D4D")]
	[Address(RVA = "0x177BD68", Offset = "0x177BD68", VA = "0x177BD68", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014D4E")]
	[Address(RVA = "0x177BDC4", Offset = "0x177BDC4", VA = "0x177BDC4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014D4F")]
	[Address(RVA = "0x177BF24", Offset = "0x177BF24", VA = "0x177BF24")]
	public void SortPoolItemNormalListById(uint poolId)
	{
	}

	[Token(Token = "0x6014D50")]
	[Address(RVA = "0x177C100", Offset = "0x177C100", VA = "0x177C100")]
	public bool CheckIsShowOwnTitle(uint itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014D51")]
	[Address(RVA = "0x177C390", Offset = "0x177C390", VA = "0x177C390")]
	public void RequestGetAllMysteryMallInfo(bool isLobbyEnter = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014D52")]
	[Address(RVA = "0x177C65C", Offset = "0x177C65C", VA = "0x177C65C")]
	public void RequestGetMysteryMallInfo(uint shopId, bool silence = false)
	{
	}

	[Token(Token = "0x6014D53")]
	[Address(RVA = "0x177C960", Offset = "0x177C960", VA = "0x177C960")]
	public void RequestPurchaseAnotherPool()
	{
	}

	[Token(Token = "0x6014D54")]
	[Address(RVA = "0x177CC88", Offset = "0x177CC88", VA = "0x177CC88")]
	public void RequestPurchaseMysteryItem(MysteryPoolStoreItem storeDesc, uint cnt)
	{
	}

	[Token(Token = "0x6014D55")]
	[Address(RVA = "0x177D07C", Offset = "0x177D07C", VA = "0x177D07C")]
	public void RequestMysteryMallLuckyDraw()
	{
	}

	[Token(Token = "0x6014D56")]
	[Address(RVA = "0x177D3AC", Offset = "0x177D3AC", VA = "0x177D3AC")]
	public void RequestGetMysteryPool(uint poolId)
	{
	}

	[Token(Token = "0x6014D57")]
	[Address(RVA = "0x177D744", Offset = "0x177D744", VA = "0x177D744")]
	public void RequestGetMysteryShopProbability()
	{
	}

	[Token(Token = "0x6014D58")]
	[Address(RVA = "0x177D990", Offset = "0x177D990", VA = "0x177D990")]
	private static int _003CSetMysteryMallDescList_003Em__0(MysteryShopExpressionDesc desc1, MysteryShopExpressionDesc desc2)
	{
		return default(int);
	}

	[Token(Token = "0x6014D59")]
	[Address(RVA = "0x177DA00", Offset = "0x177DA00", VA = "0x177DA00")]
	private int _003CSortPoolItemNormalListById_003Em__1(MysteryPoolStoreItem x, MysteryPoolStoreItem y)
	{
		return default(int);
	}

	[Token(Token = "0x6014D5A")]
	[Address(RVA = "0x177DB44", Offset = "0x177DB44", VA = "0x177DB44")]
	private void _003CRequestPurchaseAnotherPool_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014D5B")]
	[Address(RVA = "0x177DBEC", Offset = "0x177DBEC", VA = "0x177DBEC")]
	private void _003CRequestGetMysteryShopProbability_003Em__3(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x6014D5C")]
	[Address(RVA = "0x177DD74", Offset = "0x177DD74", VA = "0x177DD74")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6014D5D")]
	[Address(RVA = "0x177DD7C", Offset = "0x177DD7C", VA = "0x177DD7C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6014D5E")]
	[Address(RVA = "0x177DD84", Offset = "0x177DD84", VA = "0x177DD84")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
