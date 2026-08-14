using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021F3")]
public class UIMallPurchaseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x400D49A")]
	[FieldOffset(Offset = "0x6F")]
	private bool m_IsOffer;

	[Token(Token = "0x400D49B")]
	[FieldOffset(Offset = "0x70")]
	private bool m_IsQuickPurchase;

	[Token(Token = "0x400D49C")]
	[FieldOffset(Offset = "0x74")]
	private StoreDesc m_StoreDesc;

	[Token(Token = "0x400D49D")]
	[FieldOffset(Offset = "0x78")]
	private Action<string> m_SuccessCallback;

	[Token(Token = "0x400D49E")]
	[FieldOffset(Offset = "0x7C")]
	private EInventory.CurrencyType m_CurrencyType;

	[Token(Token = "0x600B6DE")]
	[Address(RVA = "0x22667D4", Offset = "0x22667D4", VA = "0x22667D4")]
	public UIMallPurchaseController()
	{
	}

	[Token(Token = "0x600B6DF")]
	[Address(RVA = "0x22667E4", Offset = "0x22667E4", VA = "0x22667E4")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B6E0")]
	[Address(RVA = "0x2266888", Offset = "0x2266888", VA = "0x2266888", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B6E1")]
	[Address(RVA = "0x2266B20", Offset = "0x2266B20", VA = "0x2266B20")]
	private void OnGemsPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B6E2")]
	[Address(RVA = "0x2266E60", Offset = "0x2266E60", VA = "0x2266E60")]
	private void OnGoldPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B6E3")]
	[Address(RVA = "0x2266B88", Offset = "0x2266B88", VA = "0x2266B88")]
	private void PurchaseItem()
	{
	}

	[Token(Token = "0x600B6E4")]
	[Address(RVA = "0x2266EC8", Offset = "0x2266EC8", VA = "0x2266EC8")]
	private void Purchase()
	{
	}

	[Token(Token = "0x600B6E5")]
	[Address(RVA = "0x226716C", Offset = "0x226716C", VA = "0x226716C")]
	public void RefreshData(StoreDesc storeDesc, bool showVoucherContainer = false, bool isOffer = false, bool enableInput = false, int maxCount = 0, int defaultValue = 1, [Optional] Action<string> successCallback, bool inputExceedNotify = false, bool isQuickPurchase = false, bool forceShowMaxBtn = false)
	{
	}

	[Token(Token = "0x600B6E6")]
	[Address(RVA = "0x2267574", Offset = "0x2267574", VA = "0x2267574")]
	public void SetUIData(BaseItemInfo baseItemInfo, uint coinsPrice, uint gemsprice, [Optional] EventDelegate onPurchase, bool showVoucherContainer = false, int defaultCount = 1)
	{
	}

	[Token(Token = "0x600B6E7")]
	[Address(RVA = "0x2267DE8", Offset = "0x2267DE8", VA = "0x2267DE8")]
	public void SetUIData(string itemName, ResourceID image, uint quality, EInventory.CurrencyType currencyType = EInventory.CurrencyType.CurrencyType_COINS, uint price = 0u, [Optional] EventDelegate onPurchase, bool showVoucherContainer = false)
	{
	}

	[Token(Token = "0x600B6E8")]
	[Address(RVA = "0x2267F58", Offset = "0x2267F58", VA = "0x2267F58")]
	public void SetDebrisStylePurchase()
	{
	}

	[Token(Token = "0x600B6E9")]
	[Address(RVA = "0x226763C", Offset = "0x226763C", VA = "0x226763C")]
	private void SetPriceData(EventDelegate onPurchase, int defaultCount = 1)
	{
	}

	[Token(Token = "0x600B6EA")]
	[Address(RVA = "0x2268060", Offset = "0x2268060", VA = "0x2268060")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
