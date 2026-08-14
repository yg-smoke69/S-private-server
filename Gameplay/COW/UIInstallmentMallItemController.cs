using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021C7")]
public class UIInstallmentMallItemController : UIMallItemWidgetController
{
	[Token(Token = "0x400D34C")]
	[FieldOffset(Offset = "0x130")]
	private InstallmentStoreDesc m_StoreItem;

	[Token(Token = "0x400D34D")]
	[FieldOffset(Offset = "0x134")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x400D34E")]
	[FieldOffset(Offset = "0x138")]
	private bool m_IsOverDueItem;

	[Token(Token = "0x400D34F")]
	[FieldOffset(Offset = "0x13C")]
	private Item m_Item;

	[Token(Token = "0x600B4C9")]
	[Address(RVA = "0x127C2DC", Offset = "0x127C2DC", VA = "0x127C2DC")]
	public UIInstallmentMallItemController()
	{
	}

	[Token(Token = "0x600B4CA")]
	[Address(RVA = "0x127C2E4", Offset = "0x127C2E4", VA = "0x127C2E4", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4CB")]
	[Address(RVA = "0x127C340", Offset = "0x127C340", VA = "0x127C340")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4CC")]
	[Address(RVA = "0x127C3E4", Offset = "0x127C3E4", VA = "0x127C3E4", Slot = "42")]
	protected override void RefreshItemView()
	{
	}

	[Token(Token = "0x600B4CD")]
	[Address(RVA = "0x127C898", Offset = "0x127C898", VA = "0x127C898", Slot = "43")]
	protected override void ResetState()
	{
	}

	[Token(Token = "0x600B4CE")]
	[Address(RVA = "0x127CA1C", Offset = "0x127CA1C", VA = "0x127CA1C", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600B4CF")]
	[Address(RVA = "0x127C6D4", Offset = "0x127C6D4", VA = "0x127C6D4")]
	private void SetPriceLabel()
	{
	}

	[Token(Token = "0x600B4D0")]
	[Address(RVA = "0x127C810", Offset = "0x127C810", VA = "0x127C810")]
	private void SetOverDueTitle()
	{
	}

	[Token(Token = "0x600B4D1")]
	[Address(RVA = "0x127CB80", Offset = "0x127CB80", VA = "0x127CB80", Slot = "47")]
	public override void RefreshItemBGState()
	{
	}

	[Token(Token = "0x600B4D2")]
	[Address(RVA = "0x127CCB8", Offset = "0x127CCB8", VA = "0x127CCB8", Slot = "37")]
	protected override void SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B4D3")]
	[Address(RVA = "0x127CF08", Offset = "0x127CF08", VA = "0x127CF08", Slot = "38")]
	protected override void SendClothClickEvent()
	{
	}

	[Token(Token = "0x600B4D4")]
	[Address(RVA = "0x127D200", Offset = "0x127D200", VA = "0x127D200")]
	public new ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4D5")]
	[Address(RVA = "0x127D208", Offset = "0x127D208", VA = "0x127D208")]
	public void _003C_003EiFixBaseProxy_RefreshItemView()
	{
	}

	[Token(Token = "0x600B4D6")]
	[Address(RVA = "0x127D210", Offset = "0x127D210", VA = "0x127D210")]
	public void _003C_003EiFixBaseProxy_ResetState()
	{
	}

	[Token(Token = "0x600B4D7")]
	[Address(RVA = "0x127D218", Offset = "0x127D218", VA = "0x127D218")]
	public void _003C_003EiFixBaseProxy_SetViewData(object P0, int P1)
	{
	}

	[Token(Token = "0x600B4D8")]
	[Address(RVA = "0x127D220", Offset = "0x127D220", VA = "0x127D220")]
	public void _003C_003EiFixBaseProxy_RefreshItemBGState()
	{
	}

	[Token(Token = "0x600B4D9")]
	[Address(RVA = "0x127D228", Offset = "0x127D228", VA = "0x127D228")]
	public void _003C_003EiFixBaseProxy_SendItemClickEvent()
	{
	}

	[Token(Token = "0x600B4DA")]
	[Address(RVA = "0x127D230", Offset = "0x127D230", VA = "0x127D230")]
	public void _003C_003EiFixBaseProxy_SendClothClickEvent()
	{
	}
}
