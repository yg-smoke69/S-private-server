using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200310D")]
public class UIModelLuckyWheel : UIBaseModel
{
	[Token(Token = "0x200310E")]
	public enum WheelItemState
	{
		[Token(Token = "0x4012A7D")]
		None,
		[Token(Token = "0x4012A7E")]
		Drawed,
		[Token(Token = "0x4012A7F")]
		DrawedAndUsed
	}

	[Token(Token = "0x200310F")]
	public enum RefreshCoinType
	{
		[Token(Token = "0x4012A81")]
		Diamond = 1,
		[Token(Token = "0x4012A82")]
		Gold
	}

	[Token(Token = "0x2003110")]
	public enum DiscountType
	{
		[Token(Token = "0x4012A84")]
		None,
		[Token(Token = "0x4012A85")]
		Discount,
		[Token(Token = "0x4012A86")]
		Price
	}

	[Token(Token = "0x2003111")]
	public class LuckyWheelShareInfo
	{
		[Token(Token = "0x4012A87")]
		[FieldOffset(Offset = "0x8")]
		public bool NeedShowShareUI;

		[Token(Token = "0x4012A88")]
		[FieldOffset(Offset = "0xC")]
		public uint Price;

		[Token(Token = "0x4012A89")]
		[FieldOffset(Offset = "0x10")]
		public uint OriginalPrice;

		[Token(Token = "0x601492C")]
		[Address(RVA = "0x1B1E898", Offset = "0x1B1E898", VA = "0x1B1E898")]
		public LuckyWheelShareInfo()
		{
		}
	}

	[Token(Token = "0x2003112")]
	private sealed class _003CGetCurrentDiscountType_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012A8A")]
		[FieldOffset(Offset = "0x8")]
		internal CSLuckyWheelDiscountInfo item;

		[Token(Token = "0x601492D")]
		[Address(RVA = "0x1B19A00", Offset = "0x1B19A00", VA = "0x1B19A00")]
		public _003CGetCurrentDiscountType_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x601492E")]
		[Address(RVA = "0x1B1DCB0", Offset = "0x1B1DCB0", VA = "0x1B1DCB0")]
		internal bool _003C_003Em__0(CSLuckyWheelDiscountDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003113")]
	private sealed class _003CGetCurrentDiscountValue_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012A8B")]
		[FieldOffset(Offset = "0x8")]
		internal CSLuckyWheelDiscountInfo item;

		[Token(Token = "0x601492F")]
		[Address(RVA = "0x1B1A5C8", Offset = "0x1B1A5C8", VA = "0x1B1A5C8")]
		public _003CGetCurrentDiscountValue_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6014930")]
		[Address(RVA = "0x1B1DCFC", Offset = "0x1B1DCFC", VA = "0x1B1DCFC")]
		internal bool _003C_003Em__0(CSLuckyWheelDiscountDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003114")]
	private sealed class _003CGetCurrentRewardPoolList_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012A8C")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014931")]
		[Address(RVA = "0x1B1AA64", Offset = "0x1B1AA64", VA = "0x1B1AA64")]
		public _003CGetCurrentRewardPoolList_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x6014932")]
		[Address(RVA = "0x1B1DD48", Offset = "0x1B1DD48", VA = "0x1B1DD48")]
		internal bool _003C_003Em__0(CSLuckyWheelShopItemDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003115")]
	private sealed class _003CGetWheelItemStateByID_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012A8D")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014933")]
		[Address(RVA = "0x1B1AF84", Offset = "0x1B1AF84", VA = "0x1B1AF84")]
		public _003CGetWheelItemStateByID_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x6014934")]
		[Address(RVA = "0x1B1DDF0", Offset = "0x1B1DDF0", VA = "0x1B1DDF0")]
		internal bool _003C_003Em__0(CSLuckyWheelDiscountInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003116")]
	private sealed class _003CGetWheelItemDescByID_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012A8E")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014935")]
		[Address(RVA = "0x1B1B0E8", Offset = "0x1B1B0E8", VA = "0x1B1B0E8")]
		public _003CGetWheelItemDescByID_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6014936")]
		[Address(RVA = "0x1B1DDB8", Offset = "0x1B1DDB8", VA = "0x1B1DDB8")]
		internal bool _003C_003Em__0(CSLuckyWheelDiscountDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003117")]
	private sealed class _003CGetRewardPoolItemByID_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012A8F")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x6014937")]
		[Address(RVA = "0x1B1B42C", Offset = "0x1B1B42C", VA = "0x1B1B42C")]
		public _003CGetRewardPoolItemByID_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6014938")]
		[Address(RVA = "0x1B1DD80", Offset = "0x1B1DD80", VA = "0x1B1DD80")]
		internal bool _003C_003Em__0(CSLuckyWheelShopItemDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2003118")]
	private sealed class _003CRequestLuckyWheelBuyItem_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012A90")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x4012A91")]
		[FieldOffset(Offset = "0xC")]
		internal bool needShare;

		[Token(Token = "0x4012A92")]
		[FieldOffset(Offset = "0x10")]
		internal CSLuckyWheelDiscountDesc discount;

		[Token(Token = "0x4012A93")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelLuckyWheel _0024this;

		[Token(Token = "0x4012A94")]
		[FieldOffset(Offset = "0x0")]
		private static Converter<ExchangedAward, CommonRewardItemInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x6014939")]
		[Address(RVA = "0x1B1C1D4", Offset = "0x1B1C1D4", VA = "0x1B1C1D4")]
		public _003CRequestLuckyWheelBuyItem_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x601493A")]
		[Address(RVA = "0x1B1DE74", Offset = "0x1B1DE74", VA = "0x1B1DE74")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601493B")]
		[Address(RVA = "0x1B1E8A0", Offset = "0x1B1E8A0", VA = "0x1B1E8A0")]
		private static CommonRewardItemInfo _003C_003Em__1(ExchangedAward item)
		{
			return null;
		}
	}

	[Token(Token = "0x2003119")]
	private sealed class _003CRequestLuckyWheelBuyItem_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012A95")]
		[FieldOffset(Offset = "0x8")]
		internal CSLuckyWheelDiscountInfo item;

		[Token(Token = "0x601493C")]
		[Address(RVA = "0x1B1C1DC", Offset = "0x1B1C1DC", VA = "0x1B1C1DC")]
		public _003CRequestLuckyWheelBuyItem_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x601493D")]
		[Address(RVA = "0x1B1DE28", Offset = "0x1B1DE28", VA = "0x1B1DE28")]
		internal bool _003C_003Em__0(CSLuckyWheelDiscountDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200311A")]
	private sealed class _003CCheckHasBuyedItemByID_003Ec__AnonStorey8
	{
		[Token(Token = "0x4012A96")]
		[FieldOffset(Offset = "0x8")]
		internal uint id;

		[Token(Token = "0x601493E")]
		[Address(RVA = "0x1B1C460", Offset = "0x1B1C460", VA = "0x1B1C460")]
		public _003CCheckHasBuyedItemByID_003Ec__AnonStorey8()
		{
		}

		[Token(Token = "0x601493F")]
		[Address(RVA = "0x1B1DC2C", Offset = "0x1B1DC2C", VA = "0x1B1DC2C")]
		internal bool _003C_003Em__0(CSLuckyWheelShopItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200311B")]
	private sealed class _003CGetCurrentDiscountID_003Ec__AnonStorey9
	{
		[Token(Token = "0x4012A97")]
		[FieldOffset(Offset = "0x8")]
		internal CSLuckyWheelDiscountInfo item;

		[Token(Token = "0x6014940")]
		[Address(RVA = "0x1B1CFD8", Offset = "0x1B1CFD8", VA = "0x1B1CFD8")]
		public _003CGetCurrentDiscountID_003Ec__AnonStorey9()
		{
		}

		[Token(Token = "0x6014941")]
		[Address(RVA = "0x1B1DC64", Offset = "0x1B1DC64", VA = "0x1B1DC64")]
		internal bool _003C_003Em__0(CSLuckyWheelDiscountDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012A6F")]
	public const int LUCKYWHEEL_ALL_COUNT = 8;

	[Token(Token = "0x4012A70")]
	public const string LUCKYWHEELFIRSTENTERKET = "LuckyWheelFirstEnterKey_{0}_{1}";

	[Token(Token = "0x4012A71")]
	[FieldOffset(Offset = "0x0")]
	public static uint PropID_LuckyWheel_DrawDiscount;

	[Token(Token = "0x4012A72")]
	[FieldOffset(Offset = "0x4")]
	public static uint PropID_LuckyWheel_GetInfo;

	[Token(Token = "0x4012A73")]
	[FieldOffset(Offset = "0x8")]
	public static uint PropID_LuckyWheel_GetDesc;

	[Token(Token = "0x4012A74")]
	[FieldOffset(Offset = "0xC")]
	public static uint PropID_LuckyWheel_BuyItem;

	[Token(Token = "0x4012A75")]
	[FieldOffset(Offset = "0x10")]
	public static uint PropID_LuckyWheel_RefreshRewardPool;

	[Token(Token = "0x4012A76")]
	[FieldOffset(Offset = "0xC")]
	public bool NoNeedConfirmRefreshRewardPool;

	[Token(Token = "0x4012A77")]
	[FieldOffset(Offset = "0x10")]
	private uint _003CTotalWeight_003Ek__BackingField;

	[Token(Token = "0x4012A78")]
	[FieldOffset(Offset = "0x14")]
	public LuckyWheelShareInfo ShareInfo;

	[Token(Token = "0x4012A79")]
	[FieldOffset(Offset = "0x18")]
	private uint _003CCurrentLuckyWheelID_003Ek__BackingField;

	[Token(Token = "0x4012A7A")]
	[FieldOffset(Offset = "0x1C")]
	private CSLuckyWheelInfo m_CSLuckyWheelInfo;

	[Token(Token = "0x4012A7B")]
	[FieldOffset(Offset = "0x20")]
	private CSLuckyWheelDesc m_CSLuckyWheelDesc;

	[Token(Token = "0x1700156C")]
	public uint TotalWeight
	{
		[Token(Token = "0x60148FA")]
		[Address(RVA = "0x1B19184", Offset = "0x1B19184", VA = "0x1B19184")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60148FB")]
		[Address(RVA = "0x1B1918C", Offset = "0x1B1918C", VA = "0x1B1918C")]
		private set
		{
		}
	}

	[Token(Token = "0x1700156D")]
	public uint CurrentLuckyWheelID
	{
		[Token(Token = "0x60148FC")]
		[Address(RVA = "0x1B19194", Offset = "0x1B19194", VA = "0x1B19194")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60148FD")]
		[Address(RVA = "0x1B1919C", Offset = "0x1B1919C", VA = "0x1B1919C")]
		private set
		{
		}
	}

	[Token(Token = "0x60148F9")]
	[Address(RVA = "0x1B19100", Offset = "0x1B19100", VA = "0x1B19100")]
	public UIModelLuckyWheel()
	{
	}

	[Token(Token = "0x60148FE")]
	[Address(RVA = "0x1B191A4", Offset = "0x1B191A4", VA = "0x1B191A4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60148FF")]
	[Address(RVA = "0x1B191FC", Offset = "0x1B191FC", VA = "0x1B191FC", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6014900")]
	[Address(RVA = "0x1B1926C", Offset = "0x1B1926C", VA = "0x1B1926C", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6014901")]
	[Address(RVA = "0x1B192F4", Offset = "0x1B192F4", VA = "0x1B192F4")]
	public long GetStartTime()
	{
		return default(long);
	}

	[Token(Token = "0x6014902")]
	[Address(RVA = "0x1B19368", Offset = "0x1B19368", VA = "0x1B19368")]
	public long GetEndTime()
	{
		return default(long);
	}

	[Token(Token = "0x6014903")]
	[Address(RVA = "0x1B193DC", Offset = "0x1B193DC", VA = "0x1B193DC")]
	public bool HasLuckyWheelActivity()
	{
		return default(bool);
	}

	[Token(Token = "0x6014904")]
	[Address(RVA = "0x1B194EC", Offset = "0x1B194EC", VA = "0x1B194EC")]
	public bool HasNeverEnterCurrentLuckyWheel()
	{
		return default(bool);
	}

	[Token(Token = "0x6014905")]
	[Address(RVA = "0x1B19700", Offset = "0x1B19700", VA = "0x1B19700")]
	public DiscountType GetCurrentDiscountType()
	{
		return default(DiscountType);
	}

	[Token(Token = "0x6014906")]
	[Address(RVA = "0x1B19A08", Offset = "0x1B19A08", VA = "0x1B19A08")]
	private int SortDiscountDesc(CSLuckyWheelDiscountDesc a, CSLuckyWheelDiscountDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014907")]
	[Address(RVA = "0x1B19AB4", Offset = "0x1B19AB4", VA = "0x1B19AB4")]
	private int SortDiscountDescByRule(CSLuckyWheelDiscountDesc a, CSLuckyWheelDiscountDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014908")]
	[Address(RVA = "0x1B19C24", Offset = "0x1B19C24", VA = "0x1B19C24")]
	private int SortRewardPoolDesc(CSLuckyWheelShopItemDesc a, CSLuckyWheelShopItemDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6014909")]
	[Address(RVA = "0x1B19CD0", Offset = "0x1B19CD0", VA = "0x1B19CD0")]
	private int ComparRewardItem(CSLuckyWheelShopItemDesc a, CSLuckyWheelShopItemDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x601490A")]
	[Address(RVA = "0x1B1A2D0", Offset = "0x1B1A2D0", VA = "0x1B1A2D0")]
	public uint GetCurrentDiscountValue()
	{
		return default(uint);
	}

	[Token(Token = "0x601490B")]
	[Address(RVA = "0x1B1A5D0", Offset = "0x1B1A5D0", VA = "0x1B1A5D0")]
	public List<CSLuckyWheelShopItemDesc> GetCurrentRewardPoolList()
	{
		return null;
	}

	[Token(Token = "0x601490C")]
	[Address(RVA = "0x1B1AA6C", Offset = "0x1B1AA6C", VA = "0x1B1AA6C")]
	public RefreshCoinType GetCurrentRefreshCoinType()
	{
		return default(RefreshCoinType);
	}

	[Token(Token = "0x601490D")]
	[Address(RVA = "0x1B1AAC4", Offset = "0x1B1AAC4", VA = "0x1B1AAC4")]
	public uint GetCurrentRefreshRemainCount()
	{
		return default(uint);
	}

	[Token(Token = "0x601490E")]
	[Address(RVA = "0x1B1AB30", Offset = "0x1B1AB30", VA = "0x1B1AB30")]
	public uint GetCurrentRefreshPrice()
	{
		return default(uint);
	}

	[Token(Token = "0x601490F")]
	[Address(RVA = "0x1B1ABB0", Offset = "0x1B1ABB0", VA = "0x1B1ABB0")]
	public bool HasFreeRefreshTime()
	{
		return default(bool);
	}

	[Token(Token = "0x6014910")]
	[Address(RVA = "0x1B1AC28", Offset = "0x1B1AC28", VA = "0x1B1AC28")]
	public uint GetTotalFreeRefreshCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6014911")]
	[Address(RVA = "0x1B1AC94", Offset = "0x1B1AC94", VA = "0x1B1AC94")]
	public List<CSLuckyWheelShopItemDesc> GetLuckyWhellRewardItems()
	{
		return null;
	}

	[Token(Token = "0x6014912")]
	[Address(RVA = "0x1B1ADF8", Offset = "0x1B1ADF8", VA = "0x1B1ADF8")]
	public WheelItemState GetWheelItemStateByID(uint id)
	{
		return default(WheelItemState);
	}

	[Token(Token = "0x6014913")]
	[Address(RVA = "0x1B1AF8C", Offset = "0x1B1AF8C", VA = "0x1B1AF8C")]
	public CSLuckyWheelDiscountDesc GetWheelItemDescByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014914")]
	[Address(RVA = "0x1B1B0F0", Offset = "0x1B1B0F0", VA = "0x1B1B0F0")]
	public List<CSLuckyWheelDiscountDesc> GetWheelItemDescList()
	{
		return null;
	}

	[Token(Token = "0x6014915")]
	[Address(RVA = "0x1B1B15C", Offset = "0x1B1B15C", VA = "0x1B1B15C")]
	public List<CSLuckyWheelDiscountDesc> GetSortedWheelItemDescList()
	{
		return null;
	}

	[Token(Token = "0x6014916")]
	[Address(RVA = "0x1B1B2D0", Offset = "0x1B1B2D0", VA = "0x1B1B2D0")]
	public CSLuckyWheelShopItemDesc GetRewardPoolItemByID(uint id)
	{
		return null;
	}

	[Token(Token = "0x6014917")]
	[Address(RVA = "0x1B1B434", Offset = "0x1B1B434", VA = "0x1B1B434")]
	public void RequestLuckyWheelDesc(LoadingType loadingType = LoadingType.CircleLoading)
	{
	}

	[Token(Token = "0x6014918")]
	[Address(RVA = "0x1B1B724", Offset = "0x1B1B724", VA = "0x1B1B724")]
	public void RequestLuckyWheelInfo(uint httpOption = 0u)
	{
	}

	[Token(Token = "0x6014919")]
	[Address(RVA = "0x1B1B974", Offset = "0x1B1B974", VA = "0x1B1B974")]
	public void RequestLuckyWheelDrawDiscount()
	{
	}

	[Token(Token = "0x601491A")]
	[Address(RVA = "0x1B1BBF0", Offset = "0x1B1BBF0", VA = "0x1B1BBF0")]
	public void RequestLuckyWheelBuyItem(uint id)
	{
	}

	[Token(Token = "0x601491B")]
	[Address(RVA = "0x1B1C1E4", Offset = "0x1B1C1E4", VA = "0x1B1C1E4")]
	public void RequestRefreshRewardPool()
	{
	}

	[Token(Token = "0x601491C")]
	[Address(RVA = "0x1B1A164", Offset = "0x1B1A164", VA = "0x1B1A164")]
	public bool CheckHasBuyedItemByID(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601491D")]
	[Address(RVA = "0x1B1C468", Offset = "0x1B1C468", VA = "0x1B1C468")]
	public bool IsInCurrentRewardPool(uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x601491E")]
	[Address(RVA = "0x1B1C538", Offset = "0x1B1C538", VA = "0x1B1C538")]
	public int GetUsedDiscountCount()
	{
		return default(int);
	}

	[Token(Token = "0x601491F")]
	[Address(RVA = "0x1B1C6F4", Offset = "0x1B1C6F4", VA = "0x1B1C6F4")]
	public bool IsLastDiscount()
	{
		return default(bool);
	}

	[Token(Token = "0x6014920")]
	[Address(RVA = "0x1B1C8C4", Offset = "0x1B1C8C4", VA = "0x1B1C8C4")]
	public bool IsLastDraw()
	{
		return default(bool);
	}

	[Token(Token = "0x6014921")]
	[Address(RVA = "0x1B1CA94", Offset = "0x1B1CA94", VA = "0x1B1CA94")]
	public bool IsProperbilityOpen()
	{
		return default(bool);
	}

	[Token(Token = "0x6014922")]
	[Address(RVA = "0x1B1CB0C", Offset = "0x1B1CB0C", VA = "0x1B1CB0C")]
	public bool HasFinishedLuckyWheel()
	{
		return default(bool);
	}

	[Token(Token = "0x6014923")]
	[Address(RVA = "0x1B1CCD4", Offset = "0x1B1CCD4", VA = "0x1B1CCD4")]
	public uint GetCurrentDiscountID()
	{
		return default(uint);
	}

	[Token(Token = "0x6014924")]
	[Address(RVA = "0x1B1CFE0", Offset = "0x1B1CFE0", VA = "0x1B1CFE0")]
	public bool CheckCanRefresh()
	{
		return default(bool);
	}

	[Token(Token = "0x6014926")]
	[Address(RVA = "0x1B1D40C", Offset = "0x1B1D40C", VA = "0x1B1D40C")]
	private void _003CRequestLuckyWheelDesc_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014927")]
	[Address(RVA = "0x1B1D754", Offset = "0x1B1D754", VA = "0x1B1D754")]
	private void _003CRequestLuckyWheelInfo_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014928")]
	[Address(RVA = "0x1B1D8D0", Offset = "0x1B1D8D0", VA = "0x1B1D8D0")]
	private void _003CRequestLuckyWheelDrawDiscount_003Em__2(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6014929")]
	[Address(RVA = "0x1B1DA60", Offset = "0x1B1DA60", VA = "0x1B1DA60")]
	private void _003CRequestRefreshRewardPool_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x601492A")]
	[Address(RVA = "0x1B1DC1C", Offset = "0x1B1DC1C", VA = "0x1B1DC1C")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x601492B")]
	[Address(RVA = "0x1B1DC24", Offset = "0x1B1DC24", VA = "0x1B1DC24")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
