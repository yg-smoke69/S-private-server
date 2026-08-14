using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022A5")]
internal class PlatformPromotionProductMessageBoxController : UIPopupWindowController
{
	[Token(Token = "0x400D8D1")]
	[FieldOffset(Offset = "0x48")]
	private List<PlatformPromotionProductsData> m_PlatformPromotionProductResults;

	[Token(Token = "0x400D8D2")]
	[FieldOffset(Offset = "0x4C")]
	private PlatformPromotionProductMessageBoxView m_View;

	[Token(Token = "0x400D8D3")]
	[FieldOffset(Offset = "0x50")]
	private UIStandardItemMiniController m_ItemCtrl;

	[Token(Token = "0x400D8D4")]
	[FieldOffset(Offset = "0x54")]
	private UIModelPayment m_Model;

	[Token(Token = "0x600BE7B")]
	[Address(RVA = "0x1C05C40", Offset = "0x1C05C40", VA = "0x1C05C40")]
	public PlatformPromotionProductMessageBoxController()
	{
	}

	[Token(Token = "0x600BE7C")]
	[Address(RVA = "0x1C05CCC", Offset = "0x1C05CCC", VA = "0x1C05CCC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BE7D")]
	[Address(RVA = "0x1C05D74", Offset = "0x1C05D74", VA = "0x1C05D74", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BE7E")]
	[Address(RVA = "0x1C06384", Offset = "0x1C06384", VA = "0x1C06384", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600BE7F")]
	[Address(RVA = "0x1C05F50", Offset = "0x1C05F50", VA = "0x1C05F50")]
	private void InitItem()
	{
	}

	[Token(Token = "0x600BE80")]
	[Address(RVA = "0x1C0605C", Offset = "0x1C0605C", VA = "0x1C0605C")]
	private void SetViewData()
	{
	}

	[Token(Token = "0x600BE81")]
	[Address(RVA = "0x1C06504", Offset = "0x1C06504", VA = "0x1C06504")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BE82")]
	[Address(RVA = "0x1C0650C", Offset = "0x1C0650C", VA = "0x1C0650C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
