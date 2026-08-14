using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002D0A")]
public class BaseItemInfo
{
	[Token(Token = "0x40112D3")]
	[FieldOffset(Offset = "0x0")]
	public static BaseItemInfo[] EmptyArray;

	[Token(Token = "0x40112D4")]
	[FieldOffset(Offset = "0x8")]
	public uint m_ID;

	[Token(Token = "0x40112D5")]
	[FieldOffset(Offset = "0xC")]
	public string m_Name;

	[Token(Token = "0x40112D6")]
	[FieldOffset(Offset = "0x10")]
	public int m_Type;

	[Token(Token = "0x40112D7")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID m_IconRes;

	[Token(Token = "0x40112D8")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID m_BigIconRes;

	[Token(Token = "0x40112D9")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_Count;

	[Token(Token = "0x40112DA")]
	[FieldOffset(Offset = "0x20")]
	public EInventory.ItemStatus m_Status;

	[Token(Token = "0x40112DB")]
	[FieldOffset(Offset = "0x24")]
	public uint m_DeltaTime;

	[Token(Token = "0x40112DC")]
	[FieldOffset(Offset = "0x28")]
	public uint m_Quality;

	[Token(Token = "0x40112DD")]
	[FieldOffset(Offset = "0x2C")]
	public string m_Description;

	[Token(Token = "0x40112DE")]
	[FieldOffset(Offset = "0x30")]
	public bool m_IsBigEventBadge;

	[Token(Token = "0x40112DF")]
	[FieldOffset(Offset = "0x31")]
	public bool m_IsLinkDebris;

	[Token(Token = "0x40112E0")]
	[FieldOffset(Offset = "0x34")]
	public ItemUtil.ItemShareType m_ShareType;

	[Token(Token = "0x6012D47")]
	[Address(RVA = "0x2E566C8", Offset = "0x2E566C8", VA = "0x2E566C8")]
	public BaseItemInfo(EInventory.AwardType type, uint quantity)
	{
	}

	[Token(Token = "0x6012D48")]
	[Address(RVA = "0x2E56DAC", Offset = "0x2E56DAC", VA = "0x2E56DAC")]
	public BaseItemInfo(uint quality, ResourceID resourceID, string name)
	{
	}

	[Token(Token = "0x6012D49")]
	[Address(RVA = "0x2E56EDC", Offset = "0x2E56EDC", VA = "0x2E56EDC")]
	public BaseItemInfo(uint itemID, EInventory.AwardType type, uint count, uint effectTime = 0u)
	{
	}

	[Token(Token = "0x6012D4A")]
	[Address(RVA = "0x2E57754", Offset = "0x2E57754", VA = "0x2E57754")]
	public BaseItemInfo()
	{
	}

	[Token(Token = "0x6012D4B")]
	[Address(RVA = "0x2E57868", Offset = "0x2E57868", VA = "0x2E57868")]
	public static implicit operator BaseItemInfo(AwardDesc awardItem)
	{
		return null;
	}

	[Token(Token = "0x6012D4C")]
	[Address(RVA = "0x2E580DC", Offset = "0x2E580DC", VA = "0x2E580DC")]
	public static implicit operator BaseItemInfo(CSLuckyWheelShopItemDesc awardItem)
	{
		return null;
	}

	[Token(Token = "0x6012D4D")]
	[Address(RVA = "0x2E588DC", Offset = "0x2E588DC", VA = "0x2E588DC")]
	public static implicit operator BaseItemInfo(GachaShowItem item)
	{
		return null;
	}

	[Token(Token = "0x6012D4E")]
	[Address(RVA = "0x2E58A00", Offset = "0x2E58A00", VA = "0x2E58A00")]
	public static implicit operator BaseItemInfo(Item item)
	{
		return null;
	}

	[Token(Token = "0x6012D4F")]
	[Address(RVA = "0x2E58CDC", Offset = "0x2E58CDC", VA = "0x2E58CDC")]
	public static implicit operator BaseItemInfo(BundleShowData awardItem)
	{
		return null;
	}

	[Token(Token = "0x6012D50")]
	[Address(RVA = "0x2E5954C", Offset = "0x2E5954C", VA = "0x2E5954C")]
	public static implicit operator BaseItemInfo(OptionalBundleShowData awardItem)
	{
		return null;
	}

	[Token(Token = "0x6012D51")]
	[Address(RVA = "0x2E59DBC", Offset = "0x2E59DBC", VA = "0x2E59DBC")]
	public static implicit operator BaseItemInfo(TreasureBoxShowData awardItem)
	{
		return null;
	}

	[Token(Token = "0x6012D52")]
	[Address(RVA = "0x2E5A79C", Offset = "0x2E5A79C", VA = "0x2E5A79C")]
	public static implicit operator BaseItemInfo(StoreDesc storeDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D53")]
	[Address(RVA = "0x2E5AA30", Offset = "0x2E5AA30", VA = "0x2E5AA30")]
	public static implicit operator BaseItemInfo(MysteryPoolStoreItem storeDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D54")]
	[Address(RVA = "0x2E5ACC0", Offset = "0x2E5ACC0", VA = "0x2E5ACC0")]
	public static implicit operator BaseItemInfo(DiscountStoreDesc discountDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D55")]
	[Address(RVA = "0x2E5AF50", Offset = "0x2E5AF50", VA = "0x2E5AF50")]
	public static implicit operator BaseItemInfo(InstallmentStoreDesc installmentDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D56")]
	[Address(RVA = "0x2E5B1C8", Offset = "0x2E5B1C8", VA = "0x2E5B1C8")]
	public static implicit operator BaseItemInfo(GiftItem giftItem)
	{
		return null;
	}

	[Token(Token = "0x6012D57")]
	[Address(RVA = "0x2E5B458", Offset = "0x2E5B458", VA = "0x2E5B458")]
	public static implicit operator BaseItemInfo(FlashStoreGoodsDesc exchangeItemDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D58")]
	[Address(RVA = "0x2E5B65C", Offset = "0x2E5B65C", VA = "0x2E5B65C")]
	public static implicit operator BaseItemInfo(ExchangeStoreItemDesc exchangeItemDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D59")]
	[Address(RVA = "0x2E5B8EC", Offset = "0x2E5B8EC", VA = "0x2E5B8EC")]
	public static implicit operator BaseItemInfo(PetInfo petData)
	{
		return null;
	}

	[Token(Token = "0x6012D5A")]
	[Address(RVA = "0x2E5BAD0", Offset = "0x2E5BAD0", VA = "0x2E5BAD0")]
	public static implicit operator BaseItemInfo(BigEventStoreCommodityDesc commodityDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D5B")]
	[Address(RVA = "0x2E5BD60", Offset = "0x2E5BD60", VA = "0x2E5BD60")]
	public static implicit operator BaseItemInfo(WeaponSkinUpdateItemDesc weaponSkinItemDesc)
	{
		return null;
	}

	[Token(Token = "0x6012D5C")]
	[Address(RVA = "0x2E5BF68", Offset = "0x2E5BF68", VA = "0x2E5BF68")]
	public bool IsGold()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D5D")]
	[Address(RVA = "0x2E5C048", Offset = "0x2E5C048", VA = "0x2E5C048")]
	public bool IsGem()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D5E")]
	[Address(RVA = "0x2E5C128", Offset = "0x2E5C128", VA = "0x2E5C128")]
	public bool IsExp()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D5F")]
	[Address(RVA = "0x2E5C208", Offset = "0x2E5C208", VA = "0x2E5C208")]
	public bool IsLink()
	{
		return default(bool);
	}

	[Token(Token = "0x6012D60")]
	[Address(RVA = "0x2E5C260", Offset = "0x2E5C260", VA = "0x2E5C260")]
	public string GetName()
	{
		return null;
	}

	[Token(Token = "0x6012D61")]
	[Address(RVA = "0x2E5C3B4", Offset = "0x2E5C3B4", VA = "0x2E5C3B4")]
	public uint GetCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6012D62")]
	[Address(RVA = "0x2E5C40C", Offset = "0x2E5C40C", VA = "0x2E5C40C")]
	public string GetDescription()
	{
		return null;
	}
}
