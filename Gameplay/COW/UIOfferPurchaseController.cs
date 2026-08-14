using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002212")]
public class UIOfferPurchaseController : UIPopupWindowController
{
	[Token(Token = "0x400D50B")]
	[FieldOffset(Offset = "0x48")]
	private UIOfferPurchaseView m_View;

	[Token(Token = "0x400D50C")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400D50D")]
	[FieldOffset(Offset = "0x50")]
	private OfferGoodsDesc m_OffGoods;

	[Token(Token = "0x600B83B")]
	[Address(RVA = "0x159DB30", Offset = "0x159DB30", VA = "0x159DB30")]
	public UIOfferPurchaseController()
	{
	}

	[Token(Token = "0x600B83C")]
	[Address(RVA = "0x159DB38", Offset = "0x159DB38", VA = "0x159DB38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B83D")]
	[Address(RVA = "0x159DBE0", Offset = "0x159DBE0", VA = "0x159DBE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B83E")]
	[Address(RVA = "0x159DE20", Offset = "0x159DE20", VA = "0x159DE20")]
	private void OnPurchaseBtn()
	{
	}

	[Token(Token = "0x600B83F")]
	[Address(RVA = "0x159DF18", Offset = "0x159DF18", VA = "0x159DF18")]
	private void OnClose()
	{
	}

	[Token(Token = "0x600B840")]
	[Address(RVA = "0x159DF9C", Offset = "0x159DF9C", VA = "0x159DF9C")]
	public void RefreshData(OfferGoodsDesc offerGoods)
	{
	}

	[Token(Token = "0x600B841")]
	[Address(RVA = "0x159E324", Offset = "0x159E324", VA = "0x159E324")]
	private void CreateStandItemMini()
	{
	}

	[Token(Token = "0x600B842")]
	[Address(RVA = "0x159E538", Offset = "0x159E538", VA = "0x159E538")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
