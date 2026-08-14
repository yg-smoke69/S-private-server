using System.Collections.Generic;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002E42")]
public class GachaLimitInfoData : GachaPackageInfoData
{
	[Token(Token = "0x4011AE8")]
	[FieldOffset(Offset = "0x0")]
	public static uint GACHA_LIMIT_POOL_MAX;

	[Token(Token = "0x4011AE9")]
	[FieldOffset(Offset = "0x24")]
	private List<uint> _003CRemoveItemList_003Ek__BackingField;

	[Token(Token = "0x4011AEA")]
	[FieldOffset(Offset = "0x28")]
	private List<uint> _003COwnedItemList_003Ek__BackingField;

	[Token(Token = "0x4011AEB")]
	[FieldOffset(Offset = "0x2C")]
	private List<uint> _003CPriceList_003Ek__BackingField;

	[Token(Token = "0x4011AEC")]
	[FieldOffset(Offset = "0x30")]
	private List<uint> _003CPriceDiscountType_003Ek__BackingField;

	[Token(Token = "0x4011AED")]
	[FieldOffset(Offset = "0x34")]
	private List<uint> _003CPriceDiscountList_003Ek__BackingField;

	[Token(Token = "0x4011AEE")]
	[FieldOffset(Offset = "0x38")]
	private uint _003CCurrentPurchaseRewardID_003Ek__BackingField;

	[Token(Token = "0x17001404")]
	public List<uint> RemoveItemList
	{
		[Token(Token = "0x601358B")]
		[Address(RVA = "0x10543D4", Offset = "0x10543D4", VA = "0x10543D4")]
		get
		{
			return null;
		}
		[Token(Token = "0x601358C")]
		[Address(RVA = "0x10543AC", Offset = "0x10543AC", VA = "0x10543AC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001405")]
	public List<uint> OwnedItemList
	{
		[Token(Token = "0x601358D")]
		[Address(RVA = "0x10543DC", Offset = "0x10543DC", VA = "0x10543DC")]
		get
		{
			return null;
		}
		[Token(Token = "0x601358E")]
		[Address(RVA = "0x10543B4", Offset = "0x10543B4", VA = "0x10543B4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001406")]
	public List<uint> PriceList
	{
		[Token(Token = "0x601358F")]
		[Address(RVA = "0x10543E4", Offset = "0x10543E4", VA = "0x10543E4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013590")]
		[Address(RVA = "0x10543BC", Offset = "0x10543BC", VA = "0x10543BC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001407")]
	public List<uint> PriceDiscountType
	{
		[Token(Token = "0x6013591")]
		[Address(RVA = "0x10543EC", Offset = "0x10543EC", VA = "0x10543EC")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013592")]
		[Address(RVA = "0x10543CC", Offset = "0x10543CC", VA = "0x10543CC")]
		private set
		{
		}
	}

	[Token(Token = "0x17001408")]
	public List<uint> PriceDiscountList
	{
		[Token(Token = "0x6013593")]
		[Address(RVA = "0x10543F4", Offset = "0x10543F4", VA = "0x10543F4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6013594")]
		[Address(RVA = "0x10543C4", Offset = "0x10543C4", VA = "0x10543C4")]
		private set
		{
		}
	}

	[Token(Token = "0x17001409")]
	public uint CurrentPurchaseRewardID
	{
		[Token(Token = "0x6013595")]
		[Address(RVA = "0x10543FC", Offset = "0x10543FC", VA = "0x10543FC")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6013596")]
		[Address(RVA = "0x1054404", Offset = "0x1054404", VA = "0x1054404")]
		private set
		{
		}
	}

	[Token(Token = "0x601358A")]
	[Address(RVA = "0x10542C4", Offset = "0x10542C4", VA = "0x10542C4")]
	public GachaLimitInfoData()
	{
	}

	[Token(Token = "0x6013597")]
	[Address(RVA = "0x105440C", Offset = "0x105440C", VA = "0x105440C", Slot = "6")]
	public override void UpdateByGachaResult(CSLotteryRes gachaResult)
	{
	}

	[Token(Token = "0x6013598")]
	[Address(RVA = "0x1054494", Offset = "0x1054494", VA = "0x1054494")]
	private void SetCurrentResultID()
	{
	}

	[Token(Token = "0x6013599")]
	[Address(RVA = "0x1054640", Offset = "0x1054640", VA = "0x1054640", Slot = "4")]
	protected override void OnUpdateInfoData()
	{
	}

	[Token(Token = "0x601359A")]
	[Address(RVA = "0x1054A08", Offset = "0x1054A08", VA = "0x1054A08")]
	public int GetCurrentPurchaseCnt()
	{
		return default(int);
	}

	[Token(Token = "0x601359B")]
	[Address(RVA = "0x1054B04", Offset = "0x1054B04", VA = "0x1054B04")]
	public int GetPurchaseLimitCount()
	{
		return default(int);
	}

	[Token(Token = "0x601359C")]
	[Address(RVA = "0x1054CA0", Offset = "0x1054CA0", VA = "0x1054CA0", Slot = "7")]
	protected override void OnProcseeDescData(GachaDesc gachaRes)
	{
	}

	[Token(Token = "0x601359D")]
	[Address(RVA = "0x1054D8C", Offset = "0x1054D8C", VA = "0x1054D8C")]
	private void UpdatePriceInfo(uint[] price, uint[] priceType, uint[] priceDiscount)
	{
	}

	[Token(Token = "0x601359E")]
	[Address(RVA = "0x10546A8", Offset = "0x10546A8", VA = "0x10546A8")]
	public void UpdateLimitGachaRemoveItems()
	{
	}

	[Token(Token = "0x601359F")]
	[Address(RVA = "0x105486C", Offset = "0x105486C", VA = "0x105486C")]
	private void UpdateLimitGachaHasOwnedItems()
	{
	}

	[Token(Token = "0x60135A1")]
	[Address(RVA = "0x10550AC", Offset = "0x10550AC", VA = "0x10550AC")]
	public void _003C_003EiFixBaseProxy_UpdateByGachaResult(CSLotteryRes P0)
	{
	}

	[Token(Token = "0x60135A2")]
	[Address(RVA = "0x10550B0", Offset = "0x10550B0", VA = "0x10550B0")]
	public void _003C_003EiFixBaseProxy_OnUpdateInfoData()
	{
	}

	[Token(Token = "0x60135A3")]
	[Address(RVA = "0x10550B4", Offset = "0x10550B4", VA = "0x10550B4")]
	public void _003C_003EiFixBaseProxy_OnProcseeDescData(GachaDesc P0)
	{
	}
}
