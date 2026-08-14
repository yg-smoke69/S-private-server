using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002614")]
public class UIFlashStoreItemController : UIMallItemWidgetController
{
	[Token(Token = "0x400EB10")]
	[FieldOffset(Offset = "0x130")]
	protected FlashStoreGoodsDesc m_ExchangeItem;

	[Token(Token = "0x400EB11")]
	[FieldOffset(Offset = "0x134")]
	private Dictionary<int, bool> m_ChildTransformActiveDict;

	[Token(Token = "0x400EB12")]
	[FieldOffset(Offset = "0x138")]
	protected UIModelFlashStore.EFlashStoreItemPriceState m_PriceState;

	[Token(Token = "0x600E15A")]
	[Address(RVA = "0x1DD23E0", Offset = "0x1DD23E0", VA = "0x1DD23E0")]
	public UIFlashStoreItemController()
	{
	}

	[Token(Token = "0x600E15B")]
	[Address(RVA = "0x1DD246C", Offset = "0x1DD246C", VA = "0x1DD246C", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E15C")]
	[Address(RVA = "0x1DD24C8", Offset = "0x1DD24C8", VA = "0x1DD24C8")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E15D")]
	[Address(RVA = "0x1DD256C", Offset = "0x1DD256C", VA = "0x1DD256C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E15E")]
	[Address(RVA = "0x1DD26D0", Offset = "0x1DD26D0", VA = "0x1DD26D0", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600E15F")]
	[Address(RVA = "0x1DD3200", Offset = "0x1DD3200", VA = "0x1DD3200", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600E160")]
	[Address(RVA = "0x1DD3304", Offset = "0x1DD3304", VA = "0x1DD3304", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600E161")]
	[Address(RVA = "0x1DD3368", Offset = "0x1DD3368", VA = "0x1DD3368", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600E162")]
	[Address(RVA = "0x1DD33BC", Offset = "0x1DD33BC", VA = "0x1DD33BC", Slot = "46")]
	protected override void SetPreviewTitle()
	{
	}

	[Token(Token = "0x600E163")]
	[Address(RVA = "0x1DD3410", Offset = "0x1DD3410", VA = "0x1DD3410", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E164")]
	[Address(RVA = "0x1DD3598", Offset = "0x1DD3598", VA = "0x1DD3598", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E165")]
	[Address(RVA = "0x1DD2D80", Offset = "0x1DD2D80", VA = "0x1DD2D80")]
	private void SetGenderView()
	{
	}

	[Token(Token = "0x600E166")]
	[Address(RVA = "0x1DD2BD8", Offset = "0x1DD2BD8", VA = "0x1DD2BD8")]
	private void SetDefaultState()
	{
	}

	[Token(Token = "0x600E167")]
	[Address(RVA = "0x1DD2EB8", Offset = "0x1DD2EB8", VA = "0x1DD2EB8")]
	protected void SetExchangePriceLabel()
	{
	}

	[Token(Token = "0x600E168")]
	[Address(RVA = "0x1DD35FC", Offset = "0x1DD35FC", VA = "0x1DD35FC")]
	public void SetWidgetIgnoreBound(bool value)
	{
	}

	[Token(Token = "0x600E169")]
	[Address(RVA = "0x1DD3688", Offset = "0x1DD3688", VA = "0x1DD3688")]
	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E16A")]
	[Address(RVA = "0x1DD3690", Offset = "0x1DD3690", VA = "0x1DD3690")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600E16B")]
	[Address(RVA = "0x1DD3698", Offset = "0x1DD3698", VA = "0x1DD3698")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600E16C")]
	[Address(RVA = "0x1DD36A0", Offset = "0x1DD36A0", VA = "0x1DD36A0")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600E16D")]
	[Address(RVA = "0x1DD36A8", Offset = "0x1DD36A8", VA = "0x1DD36A8")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600E16E")]
	[Address(RVA = "0x1DD36B0", Offset = "0x1DD36B0", VA = "0x1DD36B0")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}

	[Token(Token = "0x600E16F")]
	[Address(RVA = "0x1DD36B8", Offset = "0x1DD36B8", VA = "0x1DD36B8")]
	public void _003C_003EiFixBaseProxy_SetPreviewTitle()
	{
	}

	[Token(Token = "0x600E170")]
	[Address(RVA = "0x1DD36C0", Offset = "0x1DD36C0", VA = "0x1DD36C0")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E171")]
	[Address(RVA = "0x1DD36C8", Offset = "0x1DD36C8", VA = "0x1DD36C8")]
	public new void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
