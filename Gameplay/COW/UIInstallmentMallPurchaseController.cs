using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20021CA")]
public class UIInstallmentMallPurchaseController : UIPopupWindowController
{
	[Token(Token = "0x400D352")]
	[FieldOffset(Offset = "0x48")]
	private UIInstallmentMallPurchaseView m_View;

	[Token(Token = "0x400D353")]
	[FieldOffset(Offset = "0x4C")]
	protected UIModelMall m_ModelMall;

	[Token(Token = "0x400D354")]
	[FieldOffset(Offset = "0x50")]
	protected InstallmentStoreDesc m_ItemDesc;

	[Token(Token = "0x400D355")]
	[FieldOffset(Offset = "0x54")]
	private UIModelCDNAd m_ModelCDNAd;

	[Token(Token = "0x600B4EF")]
	[Address(RVA = "0x127B574", Offset = "0x127B574", VA = "0x127B574")]
	public UIInstallmentMallPurchaseController()
	{
	}

	[Token(Token = "0x600B4F0")]
	[Address(RVA = "0x127B5D0", Offset = "0x127B5D0", VA = "0x127B5D0")]
	public static ResourceID UIResource()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B4F1")]
	[Address(RVA = "0x127B968", Offset = "0x127B968", VA = "0x127B968")]
	protected object GetView()
	{
		return null;
	}

	[Token(Token = "0x600B4F2")]
	[Address(RVA = "0x127B83C", Offset = "0x127B83C", VA = "0x127B83C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B4F3")]
	[Address(RVA = "0x127BD70", Offset = "0x127BD70", VA = "0x127BD70")]
	protected void RefreshTermList()
	{
	}

	[Token(Token = "0x600B4F4")]
	[Address(RVA = "0x127BD10", Offset = "0x127BD10", VA = "0x127BD10", Slot = "46")]
	protected virtual void RefreshView()
	{
	}

	[Token(Token = "0x600B4F5")]
	[Address(RVA = "0x127E2D8", Offset = "0x127E2D8", VA = "0x127E2D8")]
	private void RefreshCDNBG()
	{
	}

	[Token(Token = "0x600B4F6")]
	[Address(RVA = "0x127E420", Offset = "0x127E420", VA = "0x127E420")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
