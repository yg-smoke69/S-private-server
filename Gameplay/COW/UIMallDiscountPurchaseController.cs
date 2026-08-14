using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021E4")]
public class UIMallDiscountPurchaseController : UIMallPurchaseBaseController
{
	[Token(Token = "0x400D411")]
	[FieldOffset(Offset = "0x70")]
	private DiscountStoreDesc m_DiscountStoreDesc;

	[Token(Token = "0x600B628")]
	[Address(RVA = "0x2251630", Offset = "0x2251630", VA = "0x2251630")]
	public UIMallDiscountPurchaseController()
	{
	}

	[Token(Token = "0x600B629")]
	[Address(RVA = "0x2251650", Offset = "0x2251650", VA = "0x2251650")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B62A")]
	[Address(RVA = "0x22516F4", Offset = "0x22516F4", VA = "0x22516F4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B62B")]
	[Address(RVA = "0x2251FE0", Offset = "0x2251FE0", VA = "0x2251FE0")]
	private void OnGemsPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B62C")]
	[Address(RVA = "0x22521F8", Offset = "0x22521F8", VA = "0x22521F8")]
	private void OnGoldPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600B62D")]
	[Address(RVA = "0x2252044", Offset = "0x2252044", VA = "0x2252044")]
	private void PurchaseDiscountItem(EInventory.CurrencyType currencyType)
	{
	}

	[Token(Token = "0x600B62E")]
	[Address(RVA = "0x22522C8", Offset = "0x22522C8", VA = "0x22522C8")]
	public void RefreshData(DiscountStoreDesc discountStoreDesc, bool showVoucherContainer = false)
	{
	}

	[Token(Token = "0x600B62F")]
	[Address(RVA = "0x2252AA0", Offset = "0x2252AA0", VA = "0x2252AA0")]
	private void SetPriceData()
	{
	}

	[Token(Token = "0x600B630")]
	[Address(RVA = "0x22537E8", Offset = "0x22537E8", VA = "0x22537E8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
