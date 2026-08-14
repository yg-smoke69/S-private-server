using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2001E93")]
internal class UIBigEvent_GlobalProgress_ExchangeStoreItemController : UIEasyListItemController
{
	[Token(Token = "0x2001E94")]
	private enum EStoreItemState
	{
		[Token(Token = "0x400C049")]
		NONE,
		[Token(Token = "0x400C04A")]
		NotEnoughToken,
		[Token(Token = "0x400C04B")]
		CanPurchase,
		[Token(Token = "0x400C04C")]
		NotInTime
	}

	[Token(Token = "0x400C03D")]
	[FieldOffset(Offset = "0x38")]
	private UIBigEvent_GlobalProgress_ExchangeStoreItemView m_View;

	[Token(Token = "0x400C03E")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelBigEventTemplate m_ModelBigEventTemplate;

	[Token(Token = "0x400C03F")]
	[FieldOffset(Offset = "0x40")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400C040")]
	[FieldOffset(Offset = "0x44")]
	private UIStandardItemMiniController m_ItemCtrl;

	[Token(Token = "0x400C041")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsUniquedAndOwned;

	[Token(Token = "0x400C042")]
	[FieldOffset(Offset = "0x49")]
	private bool m_SellOut;

	[Token(Token = "0x400C043")]
	[FieldOffset(Offset = "0x4A")]
	private bool m_LockState;

	[Token(Token = "0x400C044")]
	[FieldOffset(Offset = "0x4C")]
	private CustomEventStoreCommodityDesc m_Data;

	[Token(Token = "0x400C045")]
	[FieldOffset(Offset = "0x50")]
	private EStoreItemState m_StoreItemState;

	[Token(Token = "0x400C046")]
	[FieldOffset(Offset = "0x54")]
	private EStoreTab m_StoreItemType;

	[Token(Token = "0x400C047")]
	[FieldOffset(Offset = "0x58")]
	private Color m_NotPurchaseGray;

	[Token(Token = "0x6009362")]
	[Address(RVA = "0x30241F4", Offset = "0x30241F4", VA = "0x30241F4")]
	public UIBigEvent_GlobalProgress_ExchangeStoreItemController()
	{
	}

	[Token(Token = "0x6009363")]
	[Address(RVA = "0x3024240", Offset = "0x3024240", VA = "0x3024240")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009364")]
	[Address(RVA = "0x30242E8", Offset = "0x30242E8", VA = "0x30242E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009365")]
	[Address(RVA = "0x3024560", Offset = "0x3024560", VA = "0x3024560", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6009366")]
	[Address(RVA = "0x30246E0", Offset = "0x30246E0", VA = "0x30246E0")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x6009367")]
	[Address(RVA = "0x3024B20", Offset = "0x3024B20", VA = "0x3024B20")]
	private void SetCDNView()
	{
	}

	[Token(Token = "0x6009368")]
	[Address(RVA = "0x3024FA8", Offset = "0x3024FA8", VA = "0x3024FA8")]
	private void SetStoreItemState()
	{
	}

	[Token(Token = "0x6009369")]
	[Address(RVA = "0x3024C84", Offset = "0x3024C84", VA = "0x3024C84")]
	private void SetStandardItemView()
	{
	}

	[Token(Token = "0x600936A")]
	[Address(RVA = "0x3025240", Offset = "0x3025240", VA = "0x3025240")]
	private void SetLimitedPurchaseView()
	{
	}

	[Token(Token = "0x600936B")]
	[Address(RVA = "0x3025960", Offset = "0x3025960", VA = "0x3025960")]
	private void SetPurchaseBtnState()
	{
	}

	[Token(Token = "0x600936C")]
	[Address(RVA = "0x30250A8", Offset = "0x30250A8", VA = "0x30250A8")]
	private void SetCurrencyIcon()
	{
	}

	[Token(Token = "0x600936D")]
	[Address(RVA = "0x3025DF4", Offset = "0x3025DF4", VA = "0x3025DF4")]
	private void OnPurchaseBtnClick()
	{
	}

	[Token(Token = "0x600936E")]
	[Address(RVA = "0x30262B0", Offset = "0x30262B0", VA = "0x30262B0")]
	private void OnBtnLockClick()
	{
	}

	[Token(Token = "0x600936F")]
	[Address(RVA = "0x30264BC", Offset = "0x30264BC", VA = "0x30264BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
