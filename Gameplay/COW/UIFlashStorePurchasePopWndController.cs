using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002104")]
public class UIFlashStorePurchasePopWndController : UIPopupWindowController
{
	[Token(Token = "0x400CE89")]
	[FieldOffset(Offset = "0x48")]
	protected UIFlashStorePurchasePopWndView m_View;

	[Token(Token = "0x400CE8A")]
	[FieldOffset(Offset = "0x4C")]
	protected FlashStoreGoodsDesc m_SelectItem;

	[Token(Token = "0x400CE8B")]
	[FieldOffset(Offset = "0x50")]
	protected CSSharedItemData m_SelectItemData;

	[Token(Token = "0x400CE8C")]
	[FieldOffset(Offset = "0x54")]
	protected uint m_AcitivityID;

	[Token(Token = "0x400CE8D")]
	[FieldOffset(Offset = "0x58")]
	protected UIModelFlashStore.EFlashStoreItemPriceState m_GemsPriceState;

	[Token(Token = "0x400CE8E")]
	[FieldOffset(Offset = "0x5C")]
	protected UIModelFlashStore.ECurrentSelectItemAvailableState m_GemsAvailableState;

	[Token(Token = "0x400CE8F")]
	[FieldOffset(Offset = "0x60")]
	protected bool m_InputExceedNotify;

	[Token(Token = "0x400CE90")]
	protected const string FLASH_GEMS_ICON = "FF_UI_FlashStore_PurpleDiamond";

	[Token(Token = "0x400CE91")]
	protected const string GEMS_ICON = "FF_UI_FlashStore_Diamond";

	[Token(Token = "0x400CE92")]
	[FieldOffset(Offset = "0x61")]
	protected bool m_IsShowCountModifier;

	[Token(Token = "0x400CE93")]
	[FieldOffset(Offset = "0x64")]
	protected int m_MaxCount;

	[Token(Token = "0x400CE94")]
	[FieldOffset(Offset = "0x68")]
	protected int m_Count;

	[Token(Token = "0x17000FF1")]
	protected int ItemCount
	{
		[Token(Token = "0x600AB98")]
		[Address(RVA = "0x1B5A148", Offset = "0x1B5A148", VA = "0x1B5A148")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600AB99")]
		[Address(RVA = "0x1B5A1A0", Offset = "0x1B5A1A0", VA = "0x1B5A1A0")]
		set
		{
		}
	}

	[Token(Token = "0x600AB97")]
	[Address(RVA = "0x1B5A134", Offset = "0x1B5A134", VA = "0x1B5A134")]
	public UIFlashStorePurchasePopWndController()
	{
	}

	[Token(Token = "0x600AB9A")]
	[Address(RVA = "0x1B5A434", Offset = "0x1B5A434", VA = "0x1B5A434")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AB9B")]
	[Address(RVA = "0x1B5A4DC", Offset = "0x1B5A4DC", VA = "0x1B5A4DC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AB9C")]
	[Address(RVA = "0x1B5AE70", Offset = "0x1B5AE70", VA = "0x1B5AE70", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AB9D")]
	[Address(RVA = "0x1B5B050", Offset = "0x1B5B050", VA = "0x1B5B050")]
	protected void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600AB9E")]
	[Address(RVA = "0x1B5B70C", Offset = "0x1B5B70C", VA = "0x1B5B70C")]
	protected bool IsShowCountModifier(FlashStoreGoodsDesc exchangeStoreItem, CSSharedItemData m_SelectItemData)
	{
		return default(bool);
	}

	[Token(Token = "0x600AB9F")]
	[Address(RVA = "0x1B5B7B8", Offset = "0x1B5B7B8", VA = "0x1B5B7B8")]
	protected void SetMaxCount(int maxCount)
	{
	}

	[Token(Token = "0x600ABA0")]
	[Address(RVA = "0x1B5B818", Offset = "0x1B5B818", VA = "0x1B5B818")]
	protected void SetMaxPurchaseCount(uint limited_purchase_times, uint purchase_times, uint normalLimitedPurchaseCnt)
	{
	}

	[Token(Token = "0x600ABA1")]
	[Address(RVA = "0x1B5B9B8", Offset = "0x1B5B9B8", VA = "0x1B5B9B8")]
	protected void RefreshPurchaseLabel(uint originalFlashGemsPrice, uint originalGemsPrice, uint flashGemsActualCost, uint gemsActualCost, uint gemsReplenishNeedCnt, UIModelFlashStore.EFlashStoreItemPriceState gemsPriceState, UIModelFlashStore.ECurrentSelectItemAvailableState gemsAvailableState)
	{
	}

	[Token(Token = "0x600ABA2")]
	[Address(RVA = "0x1B5C690", Offset = "0x1B5C690", VA = "0x1B5C690")]
	protected void InitItemInfo(BaseItemInfo baseItemInfo)
	{
	}

	[Token(Token = "0x600ABA3")]
	[Address(RVA = "0x1B5C930", Offset = "0x1B5C930", VA = "0x1B5C930")]
	private void InitCountModifierView(FlashStoreGoodsDesc exchangeStoreItem, UIModelFlashStore model)
	{
	}

	[Token(Token = "0x600ABA4")]
	[Address(RVA = "0x1B5A5A0", Offset = "0x1B5A5A0", VA = "0x1B5A5A0")]
	private void InitViewData()
	{
	}

	[Token(Token = "0x600ABA5")]
	[Address(RVA = "0x1B54D5C", Offset = "0x1B54D5C", VA = "0x1B54D5C")]
	public void RefreshViewData(uint acitivityID, FlashStoreGoodsDesc exchangeStoreItem, UIModelFlashStore.EFlashStoreItemPriceState gemsPriceState, UIModelFlashStore.ECurrentSelectItemAvailableState gemsAvailableState)
	{
	}

	[Token(Token = "0x600ABA6")]
	[Address(RVA = "0x1B5A218", Offset = "0x1B5A218", VA = "0x1B5A218")]
	protected void OnSelectCntChanged(uint purchaseCnt)
	{
	}

	[Token(Token = "0x600ABA7")]
	[Address(RVA = "0x1B5CD70", Offset = "0x1B5CD70", VA = "0x1B5CD70")]
	protected void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x600ABA8")]
	[Address(RVA = "0x1B5CF9C", Offset = "0x1B5CF9C", VA = "0x1B5CF9C")]
	protected void OnMinsBtnClick()
	{
	}

	[Token(Token = "0x600ABA9")]
	[Address(RVA = "0x1B5D018", Offset = "0x1B5D018", VA = "0x1B5D018")]
	protected void OnMaxBtnClick()
	{
	}

	[Token(Token = "0x600ABAA")]
	[Address(RVA = "0x1B5D07C", Offset = "0x1B5D07C", VA = "0x1B5D07C")]
	protected void OnAddTenBtnClick()
	{
	}

	[Token(Token = "0x600ABAB")]
	[Address(RVA = "0x1B5D2A0", Offset = "0x1B5D2A0", VA = "0x1B5D2A0")]
	protected void OnCountInputSubmit()
	{
	}

	[Token(Token = "0x600ABAC")]
	[Address(RVA = "0x1B5CCB4", Offset = "0x1B5CCB4", VA = "0x1B5CCB4")]
	protected void RefreshCountInput()
	{
	}

	[Token(Token = "0x600ABAD")]
	[Address(RVA = "0x1B5D554", Offset = "0x1B5D554", VA = "0x1B5D554")]
	protected void OnCountInputChanged()
	{
	}

	[Token(Token = "0x600ABAE")]
	[Address(RVA = "0x1B5D804", Offset = "0x1B5D804", VA = "0x1B5D804")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600ABAF")]
	[Address(RVA = "0x1B5D80C", Offset = "0x1B5D80C", VA = "0x1B5D80C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
