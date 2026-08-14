using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2003120")]
public class UIModelMall : UIBaseModel
{
	[Token(Token = "0x2003121")]
	private enum MallItemAnimState
	{
		[Token(Token = "0x4012B04")]
		NO_PLAYED,
		[Token(Token = "0x4012B05")]
		PLAYERD
	}

	[Token(Token = "0x2003122")]
	public class CompareData
	{
		[Token(Token = "0x4012B06")]
		[FieldOffset(Offset = "0x8")]
		public uint m_itemId;

		[Token(Token = "0x4012B07")]
		[FieldOffset(Offset = "0xC")]
		public uint m_sortId;

		[Token(Token = "0x4012B08")]
		[FieldOffset(Offset = "0x10")]
		public bool m_CanPurchase;

		[Token(Token = "0x4012B09")]
		[FieldOffset(Offset = "0x14")]
		public uint m_quality;

		[Token(Token = "0x6014A1E")]
		[Address(RVA = "0x2FD6B74", Offset = "0x2FD6B74", VA = "0x2FD6B74")]
		public CompareData(StoreDesc desc)
		{
		}

		[Token(Token = "0x6014A1F")]
		[Address(RVA = "0x2FD736C", Offset = "0x2FD736C", VA = "0x2FD736C")]
		public CompareData(ExchangeStoreItemDesc desc)
		{
		}
	}

	[Token(Token = "0x2003123")]
	public class StoreDescForBoxSort
	{
		[Token(Token = "0x4012B0A")]
		[FieldOffset(Offset = "0x8")]
		public StoreDesc storeDesc;

		[Token(Token = "0x4012B0B")]
		[FieldOffset(Offset = "0xC")]
		public bool Owned;

		[Token(Token = "0x6014A20")]
		[Address(RVA = "0x2FD8864", Offset = "0x2FD8864", VA = "0x2FD8864")]
		public StoreDescForBoxSort()
		{
		}
	}

	[Token(Token = "0x2003124")]
	public class StoreDescForBundleSort
	{
		[Token(Token = "0x4012B0C")]
		[FieldOffset(Offset = "0x8")]
		public StoreDesc storeDesc;

		[Token(Token = "0x4012B0D")]
		[FieldOffset(Offset = "0xC")]
		public bool Owned;

		[Token(Token = "0x6014A21")]
		[Address(RVA = "0x2FE3B14", Offset = "0x2FE3B14", VA = "0x2FE3B14")]
		public StoreDescForBundleSort()
		{
		}
	}

	[Token(Token = "0x2003125")]
	private sealed class _003CGetStoreRes_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012B0E")]
		[FieldOffset(Offset = "0x8")]
		internal bool refreshByItemInfoWrong;

		[Token(Token = "0x4012B0F")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMall _0024this;

		[Token(Token = "0x4012B10")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<uint, string> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014A22")]
		[Address(RVA = "0x2FCA04C", Offset = "0x2FCA04C", VA = "0x2FCA04C")]
		public _003CGetStoreRes_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6014A23")]
		[Address(RVA = "0x2FDD9F8", Offset = "0x2FDD9F8", VA = "0x2FDD9F8")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014A24")]
		[Address(RVA = "0x2FDE1E8", Offset = "0x2FDE1E8", VA = "0x2FDE1E8")]
		private static string _003C_003Em__1(uint storeID)
		{
			return null;
		}
	}

	[Token(Token = "0x2003126")]
	private sealed class _003CPurchaseDiscountItem_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012B11")]
		[FieldOffset(Offset = "0x8")]
		internal DiscountStoreDesc desc;

		[Token(Token = "0x4012B12")]
		[FieldOffset(Offset = "0xC")]
		internal uint count;

		[Token(Token = "0x4012B13")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A25")]
		[Address(RVA = "0x2FCACF4", Offset = "0x2FCACF4", VA = "0x2FCACF4")]
		public _003CPurchaseDiscountItem_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014A26")]
		[Address(RVA = "0x2FE29E4", Offset = "0x2FE29E4", VA = "0x2FE29E4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003127")]
	private sealed class _003CRequestPurchaseInstallmentItem_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012B14")]
		[FieldOffset(Offset = "0x8")]
		internal bool isRepay;

		[Token(Token = "0x4012B15")]
		[FieldOffset(Offset = "0xC")]
		internal uint itemID;

		[Token(Token = "0x4012B16")]
		[FieldOffset(Offset = "0x10")]
		internal InstallmentStoreDesc itemDesc;

		[Token(Token = "0x4012B17")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A27")]
		[Address(RVA = "0x2FCBDC8", Offset = "0x2FCBDC8", VA = "0x2FCBDC8")]
		public _003CRequestPurchaseInstallmentItem_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014A28")]
		[Address(RVA = "0x2FE33E4", Offset = "0x2FE33E4", VA = "0x2FE33E4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003128")]
	private sealed class _003CRequestTreasureBoxProbability_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012B18")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x4012B19")]
		[FieldOffset(Offset = "0xC")]
		internal WeakReference nextWeakRef;

		[Token(Token = "0x4012B1A")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A29")]
		[Address(RVA = "0x2FCDB90", Offset = "0x2FCDB90", VA = "0x2FCDB90")]
		public _003CRequestTreasureBoxProbability_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014A2A")]
		[Address(RVA = "0x2FE3778", Offset = "0x2FE3778", VA = "0x2FE3778")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003129")]
	private sealed class _003CRequestInGameBonusProbability_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012B1B")]
		[FieldOffset(Offset = "0x8")]
		internal uint Id;

		[Token(Token = "0x4012B1C")]
		[FieldOffset(Offset = "0xC")]
		internal WeakReference nextWeakRef;

		[Token(Token = "0x4012B1D")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A2B")]
		[Address(RVA = "0x2FCE05C", Offset = "0x2FCE05C", VA = "0x2FCE05C")]
		public _003CRequestInGameBonusProbability_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014A2C")]
		[Address(RVA = "0x2FE3120", Offset = "0x2FE3120", VA = "0x2FE3120")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object obj)
		{
		}
	}

	[Token(Token = "0x200312A")]
	private sealed class _003CAddOverrideItem_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012B1E")]
		[FieldOffset(Offset = "0x8")]
		internal StoreDesc item;

		[Token(Token = "0x6014A2D")]
		[Address(RVA = "0x2FCF158", Offset = "0x2FCF158", VA = "0x2FCF158")]
		public _003CAddOverrideItem_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014A2E")]
		[Address(RVA = "0x2FDC988", Offset = "0x2FDC988", VA = "0x2FDC988")]
		internal bool _003C_003Em__0(StoreDesc i)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200312B")]
	private sealed class _003CGetExchangeStoreRes_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012B1F")]
		[FieldOffset(Offset = "0x8")]
		internal bool refreshByItemInfoWrong;

		[Token(Token = "0x4012B20")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMall _0024this;

		[Token(Token = "0x4012B21")]
		[FieldOffset(Offset = "0x0")]
		private static Comparison<ExchangeStore> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014A2F")]
		[Address(RVA = "0x2FD0210", Offset = "0x2FD0210", VA = "0x2FD0210")]
		public _003CGetExchangeStoreRes_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6014A30")]
		[Address(RVA = "0x2FDD2A0", Offset = "0x2FDD2A0", VA = "0x2FDD2A0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014A31")]
		[Address(RVA = "0x2FDD988", Offset = "0x2FDD988", VA = "0x2FDD988")]
		private static int _003C_003Em__1(ExchangeStore a, ExchangeStore b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200312C")]
	private sealed class _003CGetExchangeItemDescBySotreId_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012B22")]
		[FieldOffset(Offset = "0x8")]
		internal uint storeId;

		[Token(Token = "0x6014A32")]
		[Address(RVA = "0x2FD045C", Offset = "0x2FD045C", VA = "0x2FD045C")]
		public _003CGetExchangeItemDescBySotreId_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6014A33")]
		[Address(RVA = "0x2FDD268", Offset = "0x2FDD268", VA = "0x2FDD268")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200312D")]
	private sealed class _003CPurchase_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012B23")]
		[FieldOffset(Offset = "0x8")]
		internal StoreDesc storeDesc;

		[Token(Token = "0x4012B24")]
		[FieldOffset(Offset = "0xC")]
		internal uint itemCount;

		[Token(Token = "0x4012B25")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A34")]
		[Address(RVA = "0x2FD128C", Offset = "0x2FD128C", VA = "0x2FD128C")]
		public _003CPurchase_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x6014A35")]
		[Address(RVA = "0x2FE1818", Offset = "0x2FE1818", VA = "0x2FE1818")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200312E")]
	private sealed class _003COfferPurchase_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012B26")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemId;

		[Token(Token = "0x4012B27")]
		[FieldOffset(Offset = "0xC")]
		internal uint num;

		[Token(Token = "0x4012B28")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A36")]
		[Address(RVA = "0x2FD1D3C", Offset = "0x2FD1D3C", VA = "0x2FD1D3C")]
		public _003COfferPurchase_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6014A37")]
		[Address(RVA = "0x2FDE244", Offset = "0x2FDE244", VA = "0x2FDE244")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x200312F")]
	private sealed class _003CExchange_003Ec__AnonStoreyA
	{
		[Token(Token = "0x4012B29")]
		[FieldOffset(Offset = "0x8")]
		internal ExchangeStoreItemDesc exchangeStoreItem;

		[Token(Token = "0x4012B2A")]
		[FieldOffset(Offset = "0xC")]
		internal uint count;

		[Token(Token = "0x4012B2B")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A38")]
		[Address(RVA = "0x2FD2570", Offset = "0x2FD2570", VA = "0x2FD2570")]
		public _003CExchange_003Ec__AnonStoreyA()
		{
		}

		[Token(Token = "0x6014A39")]
		[Address(RVA = "0x2FDC9D4", Offset = "0x2FDC9D4", VA = "0x2FDC9D4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}
	}

	[Token(Token = "0x2003130")]
	private sealed class _003CShowPurchaseReward_003Ec__AnonStoreyB
	{
		[Token(Token = "0x4012B2C")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemId;

		[Token(Token = "0x4012B2D")]
		[FieldOffset(Offset = "0xC")]
		internal uint count;

		[Token(Token = "0x4012B2E")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A3A")]
		[Address(RVA = "0x2FD2C3C", Offset = "0x2FD2C3C", VA = "0x2FD2C3C")]
		public _003CShowPurchaseReward_003Ec__AnonStoreyB()
		{
		}

		[Token(Token = "0x6014A3B")]
		[Address(RVA = "0x2FE39F0", Offset = "0x2FE39F0", VA = "0x2FE39F0")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6014A3C")]
		[Address(RVA = "0x2FE3A24", Offset = "0x2FE3A24", VA = "0x2FE3A24")]
		internal void _003C_003Em__1()
		{
		}

		[Token(Token = "0x6014A3D")]
		[Address(RVA = "0x2FE3A58", Offset = "0x2FE3A58", VA = "0x2FE3A58")]
		internal void _003C_003Em__2()
		{
		}

		[Token(Token = "0x6014A3E")]
		[Address(RVA = "0x2FE3ACC", Offset = "0x2FE3ACC", VA = "0x2FE3ACC")]
		internal void _003C_003Em__3()
		{
		}
	}

	[Token(Token = "0x2003131")]
	private sealed class _003CFindStoreItemDescById_003Ec__AnonStoreyC
	{
		[Token(Token = "0x4012B2F")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x4012B30")]
		[FieldOffset(Offset = "0xC")]
		internal uint awardTime;

		[Token(Token = "0x6014A3F")]
		[Address(RVA = "0x2FD2DA4", Offset = "0x2FD2DA4", VA = "0x2FD2DA4")]
		public _003CFindStoreItemDescById_003Ec__AnonStoreyC()
		{
		}

		[Token(Token = "0x6014A40")]
		[Address(RVA = "0x2FDD1E4", Offset = "0x2FDD1E4", VA = "0x2FDD1E4")]
		internal bool _003C_003Em__0(StoreDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003132")]
	private sealed class _003CFindStoreItemDescByStoreId_003Ec__AnonStoreyD
	{
		[Token(Token = "0x4012B31")]
		[FieldOffset(Offset = "0x8")]
		internal uint storeId;

		[Token(Token = "0x6014A41")]
		[Address(RVA = "0x2FD2DAC", Offset = "0x2FD2DAC", VA = "0x2FD2DAC")]
		public _003CFindStoreItemDescByStoreId_003Ec__AnonStoreyD()
		{
		}

		[Token(Token = "0x6014A42")]
		[Address(RVA = "0x2FDD230", Offset = "0x2FDD230", VA = "0x2FDD230")]
		internal bool _003C_003Em__0(StoreDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003133")]
	private sealed class _003CFindExchagneItemDescById_003Ec__AnonStoreyE
	{
		[Token(Token = "0x4012B32")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014A43")]
		[Address(RVA = "0x2FD2EF8", Offset = "0x2FD2EF8", VA = "0x2FD2EF8")]
		public _003CFindExchagneItemDescById_003Ec__AnonStoreyE()
		{
		}

		[Token(Token = "0x6014A44")]
		[Address(RVA = "0x2FDD174", Offset = "0x2FDD174", VA = "0x2FDD174")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003134")]
	private sealed class _003CFindExchagneItemDescByCommodityID_003Ec__AnonStoreyF
	{
		[Token(Token = "0x4012B33")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014A45")]
		[Address(RVA = "0x2FD3044", Offset = "0x2FD3044", VA = "0x2FD3044")]
		public _003CFindExchagneItemDescByCommodityID_003Ec__AnonStoreyF()
		{
		}

		[Token(Token = "0x6014A46")]
		[Address(RVA = "0x2FDD13C", Offset = "0x2FDD13C", VA = "0x2FDD13C")]
		internal bool _003C_003Em__0(ExchangeStoreItemDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003135")]
	private sealed class _003CFindDiscountItemDescById_003Ec__AnonStorey10
	{
		[Token(Token = "0x4012B34")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014A47")]
		[Address(RVA = "0x2FD3190", Offset = "0x2FD3190", VA = "0x2FD3190")]
		public _003CFindDiscountItemDescById_003Ec__AnonStorey10()
		{
		}

		[Token(Token = "0x6014A48")]
		[Address(RVA = "0x2FDD0CC", Offset = "0x2FDD0CC", VA = "0x2FDD0CC")]
		internal bool _003C_003Em__0(DiscountStoreDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003136")]
	private sealed class _003CFindDiscountItemDescByStoreId_003Ec__AnonStorey11
	{
		[Token(Token = "0x4012B35")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014A49")]
		[Address(RVA = "0x2FD327C", Offset = "0x2FD327C", VA = "0x2FD327C")]
		public _003CFindDiscountItemDescByStoreId_003Ec__AnonStorey11()
		{
		}

		[Token(Token = "0x6014A4A")]
		[Address(RVA = "0x2FDD104", Offset = "0x2FDD104", VA = "0x2FDD104")]
		internal bool _003C_003Em__0(DiscountStoreDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003137")]
	private sealed class _003CFindInstallmentItemDescById_003Ec__AnonStorey12
	{
		[Token(Token = "0x4012B36")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014A4B")]
		[Address(RVA = "0x2FD3284", Offset = "0x2FD3284", VA = "0x2FD3284")]
		public _003CFindInstallmentItemDescById_003Ec__AnonStorey12()
		{
		}

		[Token(Token = "0x6014A4C")]
		[Address(RVA = "0x2FDD1AC", Offset = "0x2FDD1AC", VA = "0x2FDD1AC")]
		internal bool _003C_003Em__0(InstallmentStoreDesc desc)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003138")]
	private sealed class _003COpenGrate_003Ec__AnonStorey13
	{
		[Token(Token = "0x4012B37")]
		[FieldOffset(Offset = "0x8")]
		internal UICommonRewardWndController.WndStyleEnum wndStyle;

		[Token(Token = "0x4012B38")]
		[FieldOffset(Offset = "0xC")]
		internal uint item_id;

		[Token(Token = "0x4012B39")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x4012B3A")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<CommonRewardItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014A4D")]
		[Address(RVA = "0x2FD3DFC", Offset = "0x2FD3DFC", VA = "0x2FD3DFC")]
		public _003COpenGrate_003Ec__AnonStorey13()
		{
		}

		[Token(Token = "0x6014A4E")]
		[Address(RVA = "0x2FDF2F0", Offset = "0x2FDF2F0", VA = "0x2FDF2F0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014A4F")]
		[Address(RVA = "0x2FDFC30", Offset = "0x2FDFC30", VA = "0x2FDFC30")]
		private static CommonRewardItemInfo _003C_003Em__1(CommonRewardItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003139")]
	private sealed class _003COpenOptionalBundle_003Ec__AnonStorey14
	{
		[Token(Token = "0x4012B3B")]
		[FieldOffset(Offset = "0x8")]
		internal uint item_id;

		[Token(Token = "0x4012B3C")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A50")]
		[Address(RVA = "0x2FD460C", Offset = "0x2FD460C", VA = "0x2FD460C")]
		public _003COpenOptionalBundle_003Ec__AnonStorey14()
		{
		}

		[Token(Token = "0x6014A51")]
		[Address(RVA = "0x2FDFC34", Offset = "0x2FDFC34", VA = "0x2FDFC34")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x200313A")]
	private sealed class _003CPickOptionalBundle_003Ec__AnonStorey15
	{
		[Token(Token = "0x4012B3D")]
		[FieldOffset(Offset = "0x8")]
		internal UICommonRewardWndController.WndStyleEnum wndStyle;

		[Token(Token = "0x4012B3E")]
		[FieldOffset(Offset = "0xC")]
		internal uint item_id;

		[Token(Token = "0x4012B3F")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x4012B40")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014A52")]
		[Address(RVA = "0x2FD4BD8", Offset = "0x2FD4BD8", VA = "0x2FD4BD8")]
		public _003CPickOptionalBundle_003Ec__AnonStorey15()
		{
		}

		[Token(Token = "0x6014A53")]
		[Address(RVA = "0x2FDFC68", Offset = "0x2FDFC68", VA = "0x2FDFC68")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014A54")]
		[Address(RVA = "0x2FE0A38", Offset = "0x2FE0A38", VA = "0x2FE0A38")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x200313B")]
	private sealed class _003CPickOptionalBundle_003Ec__AnonStorey16
	{
		[Token(Token = "0x4012B41")]
		[FieldOffset(Offset = "0x8")]
		internal UICommonRewardWndController.WndStyleEnum wndStyle;

		[Token(Token = "0x4012B42")]
		[FieldOffset(Offset = "0xC")]
		internal uint item_id;

		[Token(Token = "0x4012B43")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelMall _0024this;

		[Token(Token = "0x4012B44")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014A55")]
		[Address(RVA = "0x2FD4ED8", Offset = "0x2FD4ED8", VA = "0x2FD4ED8")]
		public _003CPickOptionalBundle_003Ec__AnonStorey16()
		{
		}

		[Token(Token = "0x6014A56")]
		[Address(RVA = "0x2FE0A40", Offset = "0x2FE0A40", VA = "0x2FE0A40")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014A57")]
		[Address(RVA = "0x2FE1810", Offset = "0x2FE1810", VA = "0x2FE1810")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x200313C")]
	private sealed class _003COpenBundle_003Ec__AnonStorey17
	{
		[Token(Token = "0x4012B45")]
		[FieldOffset(Offset = "0x8")]
		internal UICommonRewardWndController.WndStyleEnum wndStyle;

		[Token(Token = "0x4012B46")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelMall _0024this;

		[Token(Token = "0x4012B47")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014A58")]
		[Address(RVA = "0x2FD580C", Offset = "0x2FD580C", VA = "0x2FD580C")]
		public _003COpenBundle_003Ec__AnonStorey17()
		{
		}

		[Token(Token = "0x6014A59")]
		[Address(RVA = "0x2FDE558", Offset = "0x2FDE558", VA = "0x2FDE558")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6014A5A")]
		[Address(RVA = "0x2FDF2E8", Offset = "0x2FDF2E8", VA = "0x2FDF2E8")]
		private static CommonRewardItemInfo _003C_003Em__1(BaseItemInfo item)
		{
			return null;
		}
	}

	[Token(Token = "0x200313D")]
	private sealed class _003CMallItemIsSoldOut_003Ec__AnonStorey18
	{
		[Token(Token = "0x4012B48")]
		[FieldOffset(Offset = "0x8")]
		internal uint itemID;

		[Token(Token = "0x6014A5B")]
		[Address(RVA = "0x2FD5D0C", Offset = "0x2FD5D0C", VA = "0x2FD5D0C")]
		public _003CMallItemIsSoldOut_003Ec__AnonStorey18()
		{
		}

		[Token(Token = "0x6014A5C")]
		[Address(RVA = "0x2FDE20C", Offset = "0x2FDE20C", VA = "0x2FDE20C")]
		internal bool _003C_003Em__0(StoreDesc info)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200313E")]
	private sealed class _003CPurchaseAvatarDebrisCallback_003Ec__AnonStorey19
	{
		[Token(Token = "0x4012B49")]
		[FieldOffset(Offset = "0x8")]
		internal Action Callback;

		[Token(Token = "0x6014A5D")]
		[Address(RVA = "0x2FDBE7C", Offset = "0x2FDBE7C", VA = "0x2FDBE7C")]
		public _003CPurchaseAvatarDebrisCallback_003Ec__AnonStorey19()
		{
		}

		[Token(Token = "0x6014A5E")]
		[Address(RVA = "0x2FE28E0", Offset = "0x2FE28E0", VA = "0x2FE28E0")]
		internal void _003C_003Em__0(HttpErrorCode errerCode, object res)
		{
		}
	}

	[Token(Token = "0x200313F")]
	private sealed class _003CPurchaseAvatarDebris_003Ec__AnonStorey1A
	{
		[Token(Token = "0x4012B4A")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x4012B4B")]
		[FieldOffset(Offset = "0xC")]
		internal uint itemCount;

		[Token(Token = "0x4012B4C")]
		[FieldOffset(Offset = "0x10")]
		internal uint itemInterval;

		[Token(Token = "0x4012B4D")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelMall _0024this;

		[Token(Token = "0x6014A5F")]
		[Address(RVA = "0x2FDC298", Offset = "0x2FDC298", VA = "0x2FDC298")]
		public _003CPurchaseAvatarDebris_003Ec__AnonStorey1A()
		{
		}

		[Token(Token = "0x6014A60")]
		[Address(RVA = "0x2FE2698", Offset = "0x2FE2698", VA = "0x2FE2698")]
		internal void _003C_003Em__0(HttpErrorCode errerCode, object res)
		{
		}
	}

	[Token(Token = "0x4012AC7")]
	[FieldOffset(Offset = "0xC")]
	private List<AdItemInfo> m_AdsItemList;

	[Token(Token = "0x4012AC8")]
	[FieldOffset(Offset = "0x10")]
	private List<StoreDesc> m_StoreItemList;

	[Token(Token = "0x4012AC9")]
	[FieldOffset(Offset = "0x14")]
	private SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<StoreDesc>> m_StoreItemsDict;

	[Token(Token = "0x4012ACA")]
	[FieldOffset(Offset = "0x18")]
	private SortedDictionary<UIModelAvatarBase.EWardrobeType, List<StoreDesc>> m_StoreClothDict;

	[Token(Token = "0x4012ACB")]
	[FieldOffset(Offset = "0x1C")]
	private SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<StoreDesc>> m_StoreCollectionDict;

	[Token(Token = "0x4012ACC")]
	[FieldOffset(Offset = "0x20")]
	private SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<StoreDesc>> m_StoreCharacterDict;

	[Token(Token = "0x4012ACD")]
	[FieldOffset(Offset = "0x24")]
	private List<StoreDesc> m_StoreNewItemList;

	[Token(Token = "0x4012ACE")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<uint, List<StoreDesc>> m_StoreWeaponDict;

	[Token(Token = "0x4012ACF")]
	[FieldOffset(Offset = "0x2C")]
	private Dictionary<uint, List<StoreDesc>> m_StorePetDict;

	[Token(Token = "0x4012AD0")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<uint, List<StoreDesc>> m_StoreBoxDict;

	[Token(Token = "0x4012AD1")]
	[FieldOffset(Offset = "0x34")]
	private Dictionary<uint, List<ExchangeStoreItemDesc>> m_ExchangeStoreItemIdDict;

	[Token(Token = "0x4012AD2")]
	[FieldOffset(Offset = "0x38")]
	private Dictionary<uint, List<ExchangeStoreItemDesc>> m_ExchangeStorePreviousSeasonItemIdDict;

	[Token(Token = "0x4012AD3")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, ExchangeStoreDesc> m_ExchangeStoreDict;

	[Token(Token = "0x4012AD4")]
	[FieldOffset(Offset = "0x40")]
	private List<ExchangeStoreItemDesc> m_ExchangeStoreItemList;

	[Token(Token = "0x4012AD5")]
	[FieldOffset(Offset = "0x44")]
	private Dictionary<uint, ExchangeStoreDesc> m_ExchangeStoreBoxDict;

	[Token(Token = "0x4012AD6")]
	[FieldOffset(Offset = "0x48")]
	public Dictionary<uint, CSGetTreasureBoxPRRes> m_TreasureBoxProbabilityDict;

	[Token(Token = "0x4012AD7")]
	[FieldOffset(Offset = "0x4C")]
	public Dictionary<uint, CSGetInGameBonusPRRes> m_InGameBonusProbabilityDict;

	[Token(Token = "0x4012AD8")]
	[FieldOffset(Offset = "0x50")]
	public List<DiscountStoreDesc> m_StoreDiscountItemList;

	[Token(Token = "0x4012AD9")]
	[FieldOffset(Offset = "0x54")]
	private List<InstallmentStoreDesc> m_StoreInstallmentItemList;

	[Token(Token = "0x4012ADA")]
	[FieldOffset(Offset = "0x58")]
	private List<InstallmentStoreDesc> m_AllInstallmentItemList;

	[Token(Token = "0x4012ADB")]
	[FieldOffset(Offset = "0x5C")]
	private Dictionary<uint, AvatarDebrisInfo> m_AvatarDebrisInfoDict;

	[Token(Token = "0x4012ADC")]
	[FieldOffset(Offset = "0x60")]
	private List<RankExchangeDisplayDesc> m_RankExchangeStoreDisplayItemList;

	[Token(Token = "0x4012ADD")]
	[FieldOffset(Offset = "0x64")]
	private Dictionary<uint, RankExchangeLimitItemDesc> m_RankExchangeStoreCurrentSeasonItemDict;

	[Token(Token = "0x4012ADE")]
	[FieldOffset(Offset = "0x68")]
	private Dictionary<uint, RankExchangeLimitItemDesc> m_RankExchangeStorePreviousSeasonItemDict;

	[Token(Token = "0x4012ADF")]
	[FieldOffset(Offset = "0x6C")]
	public Dictionary<int, OtherChannelInfo> OtherChannelInfo;

	[Token(Token = "0x4012AE0")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<uint, Dictionary<uint, StoreTableDesc>> m_MallTabInfoDict;

	[Token(Token = "0x4012AE1")]
	public const uint PropID_StoreItemListUpdate = 2u;

	[Token(Token = "0x4012AE2")]
	public const uint PropID_PurchaseSuccess = 4u;

	[Token(Token = "0x4012AE3")]
	public const uint PropID_GetAds = 16u;

	[Token(Token = "0x4012AE4")]
	public const uint PropID_ExchangeStoreItemListUpdate = 32u;

	[Token(Token = "0x4012AE5")]
	public const uint PropID_ExchangePurchaseSuccess = 64u;

	[Token(Token = "0x4012AE6")]
	public const uint PropID_TreasureBoxProbability_Update = 128u;

	[Token(Token = "0x4012AE7")]
	public const uint PropID_DiscountStoreItemListUpdate = 256u;

	[Token(Token = "0x4012AE8")]
	public const uint PropID_DiscountItemPurchaseSuccess = 512u;

	[Token(Token = "0x4012AE9")]
	public const uint PropID_InstallmentStoreItemListUpdate = 1024u;

	[Token(Token = "0x4012AEA")]
	public const uint PropID_InstallmentItemPurchaseSuccess = 2048u;

	[Token(Token = "0x4012AEB")]
	public const uint PropID_TreasureBoxOpenSuccess = 4096u;

	[Token(Token = "0x4012AEC")]
	public const uint PropID_TreasureBoxOpenFailed = 8192u;

	[Token(Token = "0x4012AED")]
	public const uint PropID_BundleOpenFailed = 16384u;

	[Token(Token = "0x4012AEE")]
	public const uint PropID_BundleOpenSuccess = 32768u;

	[Token(Token = "0x4012AEF")]
	public const uint PropID_PickOptionBundleSuccess = 65536u;

	[Token(Token = "0x4012AF0")]
	public const uint PropID_InGameBonusProbabilityUpdate = 131072u;

	[Token(Token = "0x4012AF1")]
	[FieldOffset(Offset = "0x74")]
	private float m_LastUpdateStoreResTime;

	[Token(Token = "0x4012AF2")]
	[FieldOffset(Offset = "0x78")]
	private float m_LastUpdateDiscountResTime;

	[Token(Token = "0x4012AF3")]
	[FieldOffset(Offset = "0x7C")]
	private float m_LastUpdateExchangeResTime;

	[Token(Token = "0x4012AF4")]
	[FieldOffset(Offset = "0x80")]
	private float m_LastUpdateInstallmentResTime;

	[Token(Token = "0x4012AF5")]
	[FieldOffset(Offset = "0x84")]
	private float m_GetStoreResCoolDown;

	[Token(Token = "0x4012AF6")]
	[FieldOffset(Offset = "0x88")]
	public bool m_ActiveRefreshStoreRes;

	[Token(Token = "0x4012AF7")]
	private const string m_MallItemAnimPrefix = "MALLITEM_FULLSCREEN_ANIM";

	[Token(Token = "0x4012AF8")]
	public const string CLANMALLGUIDE = "ClanMallGuide";

	[Token(Token = "0x4012AF9")]
	[FieldOffset(Offset = "0x8C")]
	private OfferGoodsDesc m_OfferGoods;

	[Token(Token = "0x4012AFA")]
	[FieldOffset(Offset = "0x90")]
	private uint m_SelectedOrder;

	[Token(Token = "0x4012AFB")]
	[FieldOffset(Offset = "0x0")]
	private static Converter<string, uint> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x4012AFC")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<BaseItemInfo, CommonRewardItemInfo> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x4012AFD")]
	[FieldOffset(Offset = "0x8")]
	private static Converter<TreasureBoxShowData, uint> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x4012AFE")]
	[FieldOffset(Offset = "0xC")]
	private static Converter<BundleShowData, uint> _003C_003Ef__am_0024cache3;

	[Token(Token = "0x4012AFF")]
	[FieldOffset(Offset = "0x10")]
	private static Converter<OptionalBundleShowData, uint> _003C_003Ef__am_0024cache4;

	[Token(Token = "0x4012B00")]
	[FieldOffset(Offset = "0x14")]
	private static Converter<TreasureBoxShowData, uint> _003C_003Ef__am_0024cache5;

	[Token(Token = "0x4012B01")]
	[FieldOffset(Offset = "0x18")]
	private static Converter<BundleShowData, uint> _003C_003Ef__am_0024cache6;

	[Token(Token = "0x4012B02")]
	[FieldOffset(Offset = "0x1C")]
	private static Converter<OptionalBundleShowData, uint> _003C_003Ef__am_0024cache7;

	[Token(Token = "0x17001572")]
	public List<AdItemInfo> AdsItemList
	{
		[Token(Token = "0x601498B")]
		[Address(RVA = "0x2FC9428", Offset = "0x2FC9428", VA = "0x2FC9428")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001573")]
	public List<StoreDesc> StoreItemList
	{
		[Token(Token = "0x601498C")]
		[Address(RVA = "0x2FC9480", Offset = "0x2FC9480", VA = "0x2FC9480")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001574")]
	public SortedDictionary<UINavigationUtil.UINavigationMallTabType, List<StoreDesc>> StoreItemsDict
	{
		[Token(Token = "0x601498D")]
		[Address(RVA = "0x2FC94D8", Offset = "0x2FC94D8", VA = "0x2FC94D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001575")]
	public SortedDictionary<UIModelAvatarBase.EWardrobeType, List<StoreDesc>> StoreClothDict
	{
		[Token(Token = "0x601498E")]
		[Address(RVA = "0x2FC9530", Offset = "0x2FC9530", VA = "0x2FC9530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001576")]
	public SortedDictionary<CSSharedItemDataManager.CollectionSubType, List<StoreDesc>> StoreCollectionDict
	{
		[Token(Token = "0x601498F")]
		[Address(RVA = "0x2FC9588", Offset = "0x2FC9588", VA = "0x2FC9588")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001577")]
	public SortedDictionary<CSSharedItemDataManager.CharacterSubType, List<StoreDesc>> StoreCharacterDict
	{
		[Token(Token = "0x6014990")]
		[Address(RVA = "0x2FC95E0", Offset = "0x2FC95E0", VA = "0x2FC95E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6014991")]
		[Address(RVA = "0x2FC9638", Offset = "0x2FC9638", VA = "0x2FC9638")]
		set
		{
		}
	}

	[Token(Token = "0x17001578")]
	public List<StoreDesc> NewItemList
	{
		[Token(Token = "0x6014992")]
		[Address(RVA = "0x2FC9698", Offset = "0x2FC9698", VA = "0x2FC9698")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001579")]
	public Dictionary<uint, List<StoreDesc>> StoreWeaponDict
	{
		[Token(Token = "0x6014993")]
		[Address(RVA = "0x2FC96F0", Offset = "0x2FC96F0", VA = "0x2FC96F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700157A")]
	public Dictionary<uint, List<StoreDesc>> StorePetDict
	{
		[Token(Token = "0x6014994")]
		[Address(RVA = "0x2FC9748", Offset = "0x2FC9748", VA = "0x2FC9748")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700157B")]
	public Dictionary<uint, List<StoreDesc>> StoreBoxDict
	{
		[Token(Token = "0x6014995")]
		[Address(RVA = "0x2FC97A0", Offset = "0x2FC97A0", VA = "0x2FC97A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700157C")]
	public Dictionary<uint, List<ExchangeStoreItemDesc>> ExchangeStoreItemDict
	{
		[Token(Token = "0x6014996")]
		[Address(RVA = "0x2FC97F8", Offset = "0x2FC97F8", VA = "0x2FC97F8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700157D")]
	public Dictionary<uint, List<ExchangeStoreItemDesc>> ExchangeStorePreviousSeasonItemDict
	{
		[Token(Token = "0x6014997")]
		[Address(RVA = "0x2FC9850", Offset = "0x2FC9850", VA = "0x2FC9850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700157E")]
	public Dictionary<uint, ExchangeStoreDesc> ExchangeStoreDict
	{
		[Token(Token = "0x6014998")]
		[Address(RVA = "0x2FC98A8", Offset = "0x2FC98A8", VA = "0x2FC98A8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700157F")]
	public List<ExchangeStoreItemDesc> ExchangeStoreItemList
	{
		[Token(Token = "0x6014999")]
		[Address(RVA = "0x2FC9900", Offset = "0x2FC9900", VA = "0x2FC9900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001580")]
	public List<DiscountStoreDesc> StoreDiscountItemList
	{
		[Token(Token = "0x601499A")]
		[Address(RVA = "0x2FC9958", Offset = "0x2FC9958", VA = "0x2FC9958")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001581")]
	public List<InstallmentStoreDesc> StoreInstallmentItemList
	{
		[Token(Token = "0x601499B")]
		[Address(RVA = "0x2FC99B0", Offset = "0x2FC99B0", VA = "0x2FC99B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001582")]
	public Dictionary<uint, RankExchangeLimitItemDesc> RankExchangeStoreCurrentSeasonItemDict
	{
		[Token(Token = "0x601499E")]
		[Address(RVA = "0x2FC9B58", Offset = "0x2FC9B58", VA = "0x2FC9B58")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001583")]
	public Dictionary<uint, RankExchangeLimitItemDesc> RankExchangeStorePreviousSeasonItemDict
	{
		[Token(Token = "0x601499F")]
		[Address(RVA = "0x2FC9BB0", Offset = "0x2FC9BB0", VA = "0x2FC9BB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001584")]
	public Dictionary<uint, AvatarDebrisInfo> AvatarDebrisInfoDict
	{
		[Token(Token = "0x60149A0")]
		[Address(RVA = "0x2FC9C08", Offset = "0x2FC9C08", VA = "0x2FC9C08")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6014989")]
	[Address(RVA = "0x2FC8A00", Offset = "0x2FC8A00", VA = "0x2FC8A00")]
	public UIModelMall()
	{
	}

	[Token(Token = "0x601498A")]
	[Address(RVA = "0x2FC93D0", Offset = "0x2FC93D0", VA = "0x2FC93D0", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601499C")]
	[Address(RVA = "0x2FC9A08", Offset = "0x2FC9A08", VA = "0x2FC9A08")]
	public RankExchangeDisplayDesc GetRankExchangeStoreDisplayItem()
	{
		return null;
	}

	[Token(Token = "0x601499D")]
	[Address(RVA = "0x2FC9B00", Offset = "0x2FC9B00", VA = "0x2FC9B00")]
	public List<RankExchangeDisplayDesc> GetRankExchangeStoreDisplayItemList()
	{
		return null;
	}

	[Token(Token = "0x60149A1")]
	[Address(RVA = "0x2FC9C60", Offset = "0x2FC9C60", VA = "0x2FC9C60")]
	public void GetStoreRes(bool refreshByItemInfoWrong = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60149A2")]
	[Address(RVA = "0x2FCA054", Offset = "0x2FCA054", VA = "0x2FCA054")]
	public uint GetBRRankLimit(ExchangeStoreItemDesc desc)
	{
		return default(uint);
	}

	[Token(Token = "0x60149A3")]
	[Address(RVA = "0x2FCA1D8", Offset = "0x2FCA1D8", VA = "0x2FCA1D8")]
	public uint GetCSRankLimit(ExchangeStoreItemDesc desc)
	{
		return default(uint);
	}

	[Token(Token = "0x60149A4")]
	[Address(RVA = "0x2FCA35C", Offset = "0x2FCA35C", VA = "0x2FCA35C")]
	public bool IsReachRankLimit(ExchangeStoreItemDesc desc, uint currentBRRank, uint currentCSRank)
	{
		return default(bool);
	}

	[Token(Token = "0x60149A5")]
	[Address(RVA = "0x2FCA42C", Offset = "0x2FCA42C", VA = "0x2FCA42C")]
	public void GetDiscountStoreDesc(bool force = false, uint option = 0u, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60149A6")]
	[Address(RVA = "0x2FCA7E4", Offset = "0x2FCA7E4", VA = "0x2FCA7E4")]
	public void PurchaseDiscountItem(uint storeID, bool isFreeItem = false, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint count = 1u, uint voucherID = 0u)
	{
	}

	[Token(Token = "0x60149A7")]
	[Address(RVA = "0x2FCB438", Offset = "0x2FCB438", VA = "0x2FCB438")]
	public void RequestInstallmentStoreDesc(bool force = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60149A8")]
	[Address(RVA = "0x2FCB868", Offset = "0x2FCB868", VA = "0x2FCB868")]
	private bool IsInstallmentTimeVaild(InstallmentStoreDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x60149A9")]
	[Address(RVA = "0x2FCB9EC", Offset = "0x2FCB9EC", VA = "0x2FCB9EC")]
	public void RequestPurchaseInstallmentItem(uint itemID, bool isOneTimePayment = false, bool isRepay = false)
	{
	}

	[Token(Token = "0x60149AA")]
	[Address(RVA = "0x2FCC0BC", Offset = "0x2FCC0BC", VA = "0x2FCC0BC")]
	public uint CalInstallmentItemPerTermPrice(uint itemID)
	{
		return default(uint);
	}

	[Token(Token = "0x60149AB")]
	[Address(RVA = "0x2FCBF48", Offset = "0x2FCBF48", VA = "0x2FCBF48")]
	public uint CalInstallmentItemOnePaymentPrice(uint itemID)
	{
		return default(uint);
	}

	[Token(Token = "0x60149AC")]
	[Address(RVA = "0x2FCC1E0", Offset = "0x2FCC1E0", VA = "0x2FCC1E0")]
	public uint GetInstallmetItemPrice(uint itemID)
	{
		return default(uint);
	}

	[Token(Token = "0x60149AD")]
	[Address(RVA = "0x2FCC3B4", Offset = "0x2FCC3B4", VA = "0x2FCC3B4")]
	private void UpdateMallTipsNum()
	{
	}

	[Token(Token = "0x60149AE")]
	[Address(RVA = "0x2FCC4BC", Offset = "0x2FCC4BC", VA = "0x2FCC4BC")]
	private int NormalMallTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x60149AF")]
	[Address(RVA = "0x2FCC5C8", Offset = "0x2FCC5C8", VA = "0x2FCC5C8")]
	private int DiscountMallTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x60149B0")]
	[Address(RVA = "0x2FCC6D4", Offset = "0x2FCC6D4", VA = "0x2FCC6D4")]
	private int DiscountMallFreeItemTipsNum()
	{
		return default(int);
	}

	[Token(Token = "0x60149B1")]
	[Address(RVA = "0x2FCC7E0", Offset = "0x2FCC7E0", VA = "0x2FCC7E0")]
	public int DiscountMallUnClaimFreeItemNum()
	{
		return default(int);
	}

	[Token(Token = "0x60149B2")]
	[Address(RVA = "0x2FCC9A8", Offset = "0x2FCC9A8", VA = "0x2FCC9A8")]
	public void ProcessDiscountStoreDesc(CSGetDiscountStoreDescRes res)
	{
	}

	[Token(Token = "0x60149B3")]
	[Address(RVA = "0x2FCCBAC", Offset = "0x2FCCBAC", VA = "0x2FCCBAC")]
	public void ProcessMallTabInfoDict(CSGetStoreTabRes res)
	{
	}

	[Token(Token = "0x60149B4")]
	[Address(RVA = "0x2FCCF44", Offset = "0x2FCCF44", VA = "0x2FCCF44")]
	public string GetTabName(UINavigationUtil.UINavigationMallType mallType, uint tabID)
	{
		return null;
	}

	[Token(Token = "0x60149B5")]
	[Address(RVA = "0x2FCD1B8", Offset = "0x2FCD1B8", VA = "0x2FCD1B8")]
	public int SortWeaponTab(uint typea, uint typeb)
	{
		return default(int);
	}

	[Token(Token = "0x60149B6")]
	[Address(RVA = "0x2FCD448", Offset = "0x2FCD448", VA = "0x2FCD448")]
	public int SortBoxTab(uint typea, uint typeb)
	{
		return default(int);
	}

	[Token(Token = "0x60149B7")]
	[Address(RVA = "0x2FCD244", Offset = "0x2FCD244", VA = "0x2FCD244")]
	private int SortTab(UINavigationUtil.UINavigationMallType mallType, uint typea, uint typeb)
	{
		return default(int);
	}

	[Token(Token = "0x60149B8")]
	[Address(RVA = "0x2FCD4D4", Offset = "0x2FCD4D4", VA = "0x2FCD4D4")]
	private void ResetRefreshStoreItemColdData()
	{
	}

	[Token(Token = "0x60149B9")]
	[Address(RVA = "0x2FCD5F4", Offset = "0x2FCD5F4", VA = "0x2FCD5F4")]
	private void ClearStoreCacheData()
	{
	}

	[Token(Token = "0x60149BA")]
	[Address(RVA = "0x2FCD814", Offset = "0x2FCD814", VA = "0x2FCD814")]
	public void RequestTreasureBoxProbability(uint id, [Optional] Action next)
	{
	}

	[Token(Token = "0x60149BB")]
	[Address(RVA = "0x2FCDB98", Offset = "0x2FCDB98", VA = "0x2FCDB98")]
	public void RequestInGameBonusProbability(uint Id, [Optional] Action next)
	{
	}

	[Token(Token = "0x60149BC")]
	[Address(RVA = "0x2FCE064", Offset = "0x2FCE064", VA = "0x2FCE064")]
	private void ClearTreasureBoxProbabilityCache()
	{
	}

	[Token(Token = "0x60149BD")]
	[Address(RVA = "0x2FCE124", Offset = "0x2FCE124", VA = "0x2FCE124")]
	private void UpdateItemsDict(StoreDesc item, ref List<uint> unKnowTypeItemIDList)
	{
	}

	[Token(Token = "0x60149BE")]
	[Address(RVA = "0x2FCE54C", Offset = "0x2FCE54C", VA = "0x2FCE54C")]
	public uint[] GetOverrideTypeList(string overrideType)
	{
		return null;
	}

	[Token(Token = "0x60149BF")]
	[Address(RVA = "0x2FCE700", Offset = "0x2FCE700", VA = "0x2FCE700")]
	public uint GetTabType(uint itemOverrideMallType)
	{
		return default(uint);
	}

	[Token(Token = "0x60149C0")]
	[Address(RVA = "0x2FCE778", Offset = "0x2FCE778", VA = "0x2FCE778")]
	public uint GetSubType(uint itemOverrideMallType)
	{
		return default(uint);
	}

	[Token(Token = "0x60149C1")]
	[Address(RVA = "0x2FCE7FC", Offset = "0x2FCE7FC", VA = "0x2FCE7FC")]
	private void AddItemToDict(UINavigationUtil.UINavigationMallTabType tabType, uint tabSubType, StoreDesc item)
	{
	}

	[Token(Token = "0x60149C2")]
	[Address(RVA = "0x2FCEEA8", Offset = "0x2FCEEA8", VA = "0x2FCEEA8")]
	private void AddOverrideItem(Dictionary<uint, List<StoreDesc>> dict, uint tabType, StoreDesc item)
	{
	}

	[Token(Token = "0x60149C3")]
	[Address(RVA = "0x2FCF160", Offset = "0x2FCF160", VA = "0x2FCF160")]
	private void UpdateClothDict(StoreDesc item)
	{
	}

	[Token(Token = "0x60149C4")]
	[Address(RVA = "0x2FCF5A4", Offset = "0x2FCF5A4", VA = "0x2FCF5A4")]
	private void UpdateCollectionDict(StoreDesc item)
	{
	}

	[Token(Token = "0x60149C5")]
	[Address(RVA = "0x2FCF9EC", Offset = "0x2FCF9EC", VA = "0x2FCF9EC")]
	public int SortExchangeStorePreviousSeasonRankItem(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60149C6")]
	[Address(RVA = "0x2FCFBBC", Offset = "0x2FCFBBC", VA = "0x2FCFBBC")]
	public int SortExchangeStoreCurrentSeasonRankItem(ExchangeStoreItemDesc x, ExchangeStoreItemDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x60149C7")]
	[Address(RVA = "0x2FCFD8C", Offset = "0x2FCFD8C", VA = "0x2FCFD8C")]
	public void GetExchangeStoreRes(bool force = false, bool refreshByItemInfoWrong = false, LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x60149C8")]
	[Address(RVA = "0x2FD0218", Offset = "0x2FD0218", VA = "0x2FD0218")]
	public ExchangeStoreDesc GetExchangeDescByBoxId(uint boxId)
	{
		return null;
	}

	[Token(Token = "0x60149C9")]
	[Address(RVA = "0x2FD0300", Offset = "0x2FD0300", VA = "0x2FD0300")]
	public ExchangeStoreItemDesc GetExchangeItemDescBySotreId(uint storeId)
	{
		return null;
	}

	[Token(Token = "0x60149CA")]
	[Address(RVA = "0x2FD0464", Offset = "0x2FD0464", VA = "0x2FD0464")]
	private void UpdateExchangeStore(ExchangeStore exchangeStore)
	{
	}

	[Token(Token = "0x60149CB")]
	[Address(RVA = "0x2FD0C2C", Offset = "0x2FD0C2C", VA = "0x2FD0C2C")]
	public static long GuidToLongID()
	{
		return default(long);
	}

	[Token(Token = "0x60149CC")]
	[Address(RVA = "0x2FCAE40", Offset = "0x2FCAE40", VA = "0x2FCAE40")]
	public bool CheckHasEnoughCurrency(EInventory.CurrencyType currencyType, uint totalPrice)
	{
		return default(bool);
	}

	[Token(Token = "0x60149CD")]
	[Address(RVA = "0x2FD0D5C", Offset = "0x2FD0D5C", VA = "0x2FD0D5C")]
	public void Purchase(uint itemId, uint itemCount = 1u, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint voucherID = 0u, bool isOffer = true, bool isItemId = true, bool isQuickPurchase = false)
	{
	}

	[Token(Token = "0x60149CE")]
	[Address(RVA = "0x2FD19F0", Offset = "0x2FD19F0", VA = "0x2FD19F0")]
	public void OfferPurchase(OfferGoodsDesc offerGoods)
	{
	}

	[Token(Token = "0x60149CF")]
	[Address(RVA = "0x2FD1DA0", Offset = "0x2FD1DA0", VA = "0x2FD1DA0")]
	public void Exchange(ExchangeStoreItemDesc exchangeStoreItem, uint count = 1u, uint entryFrom = 1u)
	{
	}

	[Token(Token = "0x60149D0")]
	[Address(RVA = "0x2FD2578", Offset = "0x2FD2578", VA = "0x2FD2578")]
	public void ShowPurchaseReward(uint itemId, List<BaseItemInfo> awardlist, uint count)
	{
	}

	[Token(Token = "0x60149D1")]
	[Address(RVA = "0x2FD2C44", Offset = "0x2FD2C44", VA = "0x2FD2C44")]
	public void RefreshStoreRes()
	{
	}

	[Token(Token = "0x60149D2")]
	[Address(RVA = "0x2FD2CB4", Offset = "0x2FD2CB4", VA = "0x2FD2CB4")]
	public void RefreshExchangeStoreRes()
	{
	}

	[Token(Token = "0x60149D3")]
	[Address(RVA = "0x2FD2D2C", Offset = "0x2FD2D2C", VA = "0x2FD2D2C")]
	public void RefreshDiscountStoreRes()
	{
	}

	[Token(Token = "0x60149D4")]
	[Address(RVA = "0x2FD1294", Offset = "0x2FD1294", VA = "0x2FD1294")]
	public StoreDesc FindStoreItemDescById(uint id, uint awardTime = 0u)
	{
		return null;
	}

	[Token(Token = "0x60149D5")]
	[Address(RVA = "0x2FD1408", Offset = "0x2FD1408", VA = "0x2FD1408")]
	public StoreDesc FindStoreItemDescByStoreId(uint storeId)
	{
		return null;
	}

	[Token(Token = "0x60149D6")]
	[Address(RVA = "0x2FD2DB4", Offset = "0x2FD2DB4", VA = "0x2FD2DB4")]
	public ExchangeStoreItemDesc FindExchagneItemDescById(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149D7")]
	[Address(RVA = "0x2FD2F00", Offset = "0x2FD2F00", VA = "0x2FD2F00")]
	public ExchangeStoreItemDesc FindExchagneItemDescByCommodityID(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149D8")]
	[Address(RVA = "0x2FD304C", Offset = "0x2FD304C", VA = "0x2FD304C")]
	public DiscountStoreDesc FindDiscountItemDescById(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149D9")]
	[Address(RVA = "0x2FD3198", Offset = "0x2FD3198", VA = "0x2FD3198")]
	public bool IsSameAndCanPurchaseDiscountItem(uint id, uint storeId)
	{
		return default(bool);
	}

	[Token(Token = "0x60149DA")]
	[Address(RVA = "0x2FCACFC", Offset = "0x2FCACFC", VA = "0x2FCACFC")]
	public DiscountStoreDesc FindDiscountItemDescByStoreId(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149DB")]
	[Address(RVA = "0x2FCBDD0", Offset = "0x2FCBDD0", VA = "0x2FCBDD0")]
	public InstallmentStoreDesc FindInstallmentItemDescById(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149DC")]
	[Address(RVA = "0x2FD328C", Offset = "0x2FD328C", VA = "0x2FD328C")]
	public bool CheckIsUniqueAndOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x60149DD")]
	[Address(RVA = "0x2FD35AC", Offset = "0x2FD35AC", VA = "0x2FD35AC")]
	public bool ItemCanPurchase(StoreDesc storeDesc)
	{
		return default(bool);
	}

	[Token(Token = "0x60149DE")]
	[Address(RVA = "0x2FD36DC", Offset = "0x2FD36DC", VA = "0x2FD36DC")]
	public bool ItemCanPurchase(ExchangeStoreItemDesc exchangeItemDesc)
	{
		return default(bool);
	}

	[Token(Token = "0x60149DF")]
	[Address(RVA = "0x2FD3644", Offset = "0x2FD3644", VA = "0x2FD3644")]
	public bool CheckItemCanPurchase(uint limited_purchase_times, uint purchase_times)
	{
		return default(bool);
	}

	[Token(Token = "0x60149E0")]
	[Address(RVA = "0x2FD3774", Offset = "0x2FD3774", VA = "0x2FD3774")]
	public int ChangeInstallmentType2Days(EInventory.InstallmentType type)
	{
		return default(int);
	}

	[Token(Token = "0x60149E1")]
	[Address(RVA = "0x2FD37E8", Offset = "0x2FD37E8", VA = "0x2FD37E8")]
	public static List<BaseItemInfo> AssembleAwardList(List<Item> add_list, List<Item> del_list)
	{
		return null;
	}

	[Token(Token = "0x60149E2")]
	[Address(RVA = "0x2FD3ADC", Offset = "0x2FD3ADC", VA = "0x2FD3ADC")]
	public void OpenGrate(uint item_id, uint count = 1u, bool iscrate = false, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	[Token(Token = "0x60149E3")]
	[Address(RVA = "0x2FD3E04", Offset = "0x2FD3E04", VA = "0x2FD3E04")]
	public void OpenOptionalBundle(uint item_id, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	[Token(Token = "0x60149E4")]
	[Address(RVA = "0x2FD487C", Offset = "0x2FD487C", VA = "0x2FD487C")]
	public void SelectOptionalBundle(uint order)
	{
	}

	[Token(Token = "0x60149E5")]
	[Address(RVA = "0x2FD48DC", Offset = "0x2FD48DC", VA = "0x2FD48DC")]
	public void PickOptionalBundle(uint item_id, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	[Token(Token = "0x60149E6")]
	[Address(RVA = "0x2FD4BE0", Offset = "0x2FD4BE0", VA = "0x2FD4BE0")]
	public void PickOptionalBundle(uint item_id, uint option_order, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	[Token(Token = "0x60149E7")]
	[Address(RVA = "0x2FD4EE0", Offset = "0x2FD4EE0", VA = "0x2FD4EE0")]
	public void OpenBundle(uint item_id, UICommonRewardWndController.WndStyleEnum wndStyle = UICommonRewardWndController.WndStyleEnum.COMMON)
	{
	}

	[Token(Token = "0x60149E8")]
	[Address(RVA = "0x2FD5814", Offset = "0x2FD5814", VA = "0x2FD5814")]
	public void GetMallAdRes()
	{
	}

	[Token(Token = "0x60149E9")]
	[Address(RVA = "0x2FD5B40", Offset = "0x2FD5B40", VA = "0x2FD5B40")]
	public bool MallItemIsSoldOut(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60149EA")]
	[Address(RVA = "0x2FD5D14", Offset = "0x2FD5D14", VA = "0x2FD5D14")]
	public bool IsOtherChannelItem(StoreDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x60149EB")]
	[Address(RVA = "0x2FD5DA4", Offset = "0x2FD5DA4", VA = "0x2FD5DA4", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60149EC")]
	[Address(RVA = "0x2FD5E1C", Offset = "0x2FD5E1C", VA = "0x2FD5E1C")]
	private void ResetData()
	{
	}

	[Token(Token = "0x60149ED")]
	[Address(RVA = "0x2FD5E94", Offset = "0x2FD5E94", VA = "0x2FD5E94")]
	public StoreDesc GetLoadoutStoreItemInfo(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149EE")]
	[Address(RVA = "0x2FD6050", Offset = "0x2FD6050", VA = "0x2FD6050")]
	public FullscreenCgDesc GetFullScreenAnimdata(uint id)
	{
		return null;
	}

	[Token(Token = "0x60149EF")]
	[Address(RVA = "0x2FD629C", Offset = "0x2FD629C", VA = "0x2FD629C")]
	public bool GetMallItemAnimIsPlayed(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60149F0")]
	[Address(RVA = "0x2FD64C8", Offset = "0x2FD64C8", VA = "0x2FD64C8")]
	public void SetMallItemAnimPlayed(uint itemID)
	{
	}

	[Token(Token = "0x60149F1")]
	[Address(RVA = "0x2FD16AC", Offset = "0x2FD16AC", VA = "0x2FD16AC")]
	private ulong GetRoomIDByItemList(List<uint> IDList)
	{
		return default(ulong);
	}

	[Token(Token = "0x60149F2")]
	[Address(RVA = "0x2FD661C", Offset = "0x2FD661C", VA = "0x2FD661C")]
	private bool IsBuyRoomCard(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60149F3")]
	[Address(RVA = "0x2FD67FC", Offset = "0x2FD67FC", VA = "0x2FD67FC")]
	public int SortItem(object x, object y)
	{
		return default(int);
	}

	[Token(Token = "0x60149F4")]
	[Address(RVA = "0x2FD7510", Offset = "0x2FD7510", VA = "0x2FD7510")]
	public int SortItemWithCheckClothCanEquip(object x, object y)
	{
		return default(int);
	}

	[Token(Token = "0x60149F5")]
	[Address(RVA = "0x2FD7884", Offset = "0x2FD7884", VA = "0x2FD7884")]
	public int SortItemWithCheckBundleAllItemOwned(object x, object y)
	{
		return default(int);
	}

	[Token(Token = "0x60149F6")]
	[Address(RVA = "0x2FD6D18", Offset = "0x2FD6D18", VA = "0x2FD6D18")]
	public int SortStoreItem(CompareData x, CompareData y, bool checkCanEquipCloth = false, bool checkBundleOwned = false, bool isProcessCheckOwned = false, bool processCheckXOwnedResult = false, bool processCheckYOwnedResult = false, bool checkBoxAllItemOwned = false, bool isProcessCheckBoxItemOwned = false, bool processCheckBoxXOwned = false, bool processCheckBoxYOwned = false)
	{
		return default(int);
	}

	[Token(Token = "0x60149F7")]
	[Address(RVA = "0x2FD843C", Offset = "0x2FD843C", VA = "0x2FD843C")]
	public void SortItemWithCheckBoxAllItemOwned(List<StoreDesc> storeList)
	{
	}

	[Token(Token = "0x60149F8")]
	[Address(RVA = "0x2FD4614", Offset = "0x2FD4614", VA = "0x2FD4614")]
	public static List<CommonRewardItemInfo> FixPetRewardLevel(List<CommonRewardItemInfo> list)
	{
		return null;
	}

	[Token(Token = "0x60149F9")]
	[Address(RVA = "0x2FD886C", Offset = "0x2FD886C", VA = "0x2FD886C")]
	private void FixTreasureBoxRewardLevel(uint treasureboxID, List<CommonRewardItemInfo> list)
	{
	}

	[Token(Token = "0x60149FA")]
	[Address(RVA = "0x2FD7DCC", Offset = "0x2FD7DCC", VA = "0x2FD7DCC")]
	public bool BoxContainsItemAllOwned(uint itemID, bool ignoreNoUnique = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60149FB")]
	[Address(RVA = "0x2FD8CC4", Offset = "0x2FD8CC4", VA = "0x2FD8CC4")]
	public void SortBundleList(List<StoreDescForBundleSort> list)
	{
	}

	[Token(Token = "0x60149FC")]
	[Address(RVA = "0x2FD7BFC", Offset = "0x2FD7BFC", VA = "0x2FD7BFC")]
	public bool CheckBundleOwned(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60149FD")]
	[Address(RVA = "0x2FD9304", Offset = "0x2FD9304", VA = "0x2FD9304")]
	public bool CheckOptionalBundleOwned(uint itemID)
	{
		return default(bool);
	}

	[Token(Token = "0x60149FE")]
	[Address(RVA = "0x2FD99E8", Offset = "0x2FD99E8", VA = "0x2FD99E8")]
	public uint GetRealGemPrice(StoreDesc storeDesc)
	{
		return default(uint);
	}

	[Token(Token = "0x60149FF")]
	[Address(RVA = "0x2FD9A74", Offset = "0x2FD9A74", VA = "0x2FD9A74")]
	public bool IsItemOwnedInBundle(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A00")]
	[Address(RVA = "0x2FD8DD0", Offset = "0x2FD8DD0", VA = "0x2FD8DD0")]
	public bool BundleContainsItemAllOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A01")]
	[Address(RVA = "0x2FDA454", Offset = "0x2FDA454", VA = "0x2FDA454")]
	public bool CheckIsInvisbleSkill(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A02")]
	[Address(RVA = "0x2FD94D4", Offset = "0x2FD94D4", VA = "0x2FD94D4")]
	public bool OptionalBundleContainsItemAllOwned(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A03")]
	[Address(RVA = "0x2FDA6F4", Offset = "0x2FDA6F4", VA = "0x2FDA6F4")]
	public int GetDiscountItemPrice(uint price, float discountValue)
	{
		return default(int);
	}

	[Token(Token = "0x6014A04")]
	[Address(RVA = "0x2FDA81C", Offset = "0x2FDA81C", VA = "0x2FDA81C")]
	public FullScreenAnimParams CreateFullScreenAnimParams(FullscreenCgDesc animData)
	{
		return null;
	}

	[Token(Token = "0x6014A05")]
	[Address(RVA = "0x2FDAAE4", Offset = "0x2FDAAE4", VA = "0x2FDAAE4")]
	public bool HasOfferPurchase()
	{
		return default(bool);
	}

	[Token(Token = "0x6014A06")]
	[Address(RVA = "0x2FDAB48", Offset = "0x2FDAB48", VA = "0x2FDAB48")]
	public OfferGoodsDesc GetOfferGoods()
	{
		return null;
	}

	[Token(Token = "0x6014A07")]
	[Address(RVA = "0x2FD1D44", Offset = "0x2FD1D44", VA = "0x2FD1D44")]
	public void ClearOfferGoods()
	{
	}

	[Token(Token = "0x6014A08")]
	[Address(RVA = "0x2FDABA0", Offset = "0x2FDABA0", VA = "0x2FDABA0")]
	public bool IsShowDiscountTag(StoreDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A09")]
	[Address(RVA = "0x2FD154C", Offset = "0x2FD154C", VA = "0x2FD154C")]
	public bool IsDiscountItem(StoreDesc desc)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A0A")]
	[Address(RVA = "0x2FDACFC", Offset = "0x2FDACFC", VA = "0x2FDACFC")]
	public int SortDiscountItem(DiscountStoreDesc x, DiscountStoreDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6014A0B")]
	[Address(RVA = "0x2FDB06C", Offset = "0x2FDB06C", VA = "0x2FDB06C")]
	public int SortInstallmentItem(InstallmentStoreDesc x, InstallmentStoreDesc y)
	{
		return default(int);
	}

	[Token(Token = "0x6014A0C")]
	[Address(RVA = "0x2FDB6F4", Offset = "0x2FDB6F4", VA = "0x2FDB6F4")]
	public bool IsItemHideInMall(uint itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6014A0D")]
	[Address(RVA = "0x2FDB4AC", Offset = "0x2FDB4AC", VA = "0x2FDB4AC")]
	private int CompareRare(uint itemIDx, uint itemIDy)
	{
		return default(int);
	}

	[Token(Token = "0x6014A0E")]
	[Address(RVA = "0x2FDB824", Offset = "0x2FDB824", VA = "0x2FDB824")]
	public void ProcessAvatarDebris(CSGetRoleDebrisDescRes debrisDescRes)
	{
	}

	[Token(Token = "0x6014A0F")]
	[Address(RVA = "0x2FDBAD8", Offset = "0x2FDBAD8", VA = "0x2FDBAD8")]
	public void PurchaseAvatarDebrisCallback(uint id, uint itemCount, uint itemInterval, EInventory.CurrencyType currencyType, uint price, Action Callback)
	{
	}

	[Token(Token = "0x6014A10")]
	[Address(RVA = "0x2FDBE84", Offset = "0x2FDBE84", VA = "0x2FDBE84")]
	public void PurchaseAvatarDebris(uint id, uint itemCount, uint itemInterval, EInventory.CurrencyType currencyType, uint price, uint voucherID = 0u)
	{
	}

	[Token(Token = "0x6014A11")]
	[Address(RVA = "0x2FDC2A0", Offset = "0x2FDC2A0", VA = "0x2FDC2A0")]
	private void _003CGetDiscountStoreDesc_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014A12")]
	[Address(RVA = "0x2FDC3DC", Offset = "0x2FDC3DC", VA = "0x2FDC3DC")]
	private void _003CRequestInstallmentStoreDesc_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014A13")]
	[Address(RVA = "0x2FDC61C", Offset = "0x2FDC61C", VA = "0x2FDC61C")]
	private static uint _003CGetOverrideTypeList_003Em__2(string type)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A14")]
	[Address(RVA = "0x2FDC648", Offset = "0x2FDC648", VA = "0x2FDC648")]
	private static CommonRewardItemInfo _003CShowPurchaseReward_003Em__3(BaseItemInfo item)
	{
		return null;
	}

	[Token(Token = "0x6014A15")]
	[Address(RVA = "0x2FDC650", Offset = "0x2FDC650", VA = "0x2FDC650")]
	private int _003CSortItemWithCheckBoxAllItemOwned_003Em__4(StoreDescForBoxSort x, StoreDescForBoxSort y)
	{
		return default(int);
	}

	[Token(Token = "0x6014A16")]
	[Address(RVA = "0x2FDC758", Offset = "0x2FDC758", VA = "0x2FDC758")]
	private static uint _003CBoxContainsItemAllOwned_003Em__5(TreasureBoxShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A17")]
	[Address(RVA = "0x2FDC77C", Offset = "0x2FDC77C", VA = "0x2FDC77C")]
	private int _003CSortBundleList_003Em__6(StoreDescForBundleSort x, StoreDescForBundleSort y)
	{
		return default(int);
	}

	[Token(Token = "0x6014A18")]
	[Address(RVA = "0x2FDC8CC", Offset = "0x2FDC8CC", VA = "0x2FDC8CC")]
	private static uint _003CIsItemOwnedInBundle_003Em__7(BundleShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A19")]
	[Address(RVA = "0x2FDC8F0", Offset = "0x2FDC8F0", VA = "0x2FDC8F0")]
	private static uint _003CIsItemOwnedInBundle_003Em__8(OptionalBundleShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A1A")]
	[Address(RVA = "0x2FDC914", Offset = "0x2FDC914", VA = "0x2FDC914")]
	private static uint _003CIsItemOwnedInBundle_003Em__9(TreasureBoxShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A1B")]
	[Address(RVA = "0x2FDC938", Offset = "0x2FDC938", VA = "0x2FDC938")]
	private static uint _003CBundleContainsItemAllOwned_003Em__A(BundleShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A1C")]
	[Address(RVA = "0x2FDC95C", Offset = "0x2FDC95C", VA = "0x2FDC95C")]
	private static uint _003COptionalBundleContainsItemAllOwned_003Em__B(OptionalBundleShowData item)
	{
		return default(uint);
	}

	[Token(Token = "0x6014A1D")]
	[Address(RVA = "0x2FDC980", Offset = "0x2FDC980", VA = "0x2FDC980")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
