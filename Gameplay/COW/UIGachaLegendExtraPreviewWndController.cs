using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200264C")]
public class UIGachaLegendExtraPreviewWndController : UIPopupWindowController
{
	[Token(Token = "0x400EC83")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaLegendExtraPreviewWndView m_View;

	[Token(Token = "0x600E483")]
	[Address(RVA = "0x248899C", Offset = "0x248899C", VA = "0x248899C")]
	public UIGachaLegendExtraPreviewWndController()
	{
	}

	[Token(Token = "0x600E484")]
	[Address(RVA = "0x24889A4", Offset = "0x24889A4", VA = "0x24889A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E485")]
	[Address(RVA = "0x2488A48", Offset = "0x2488A48", VA = "0x2488A48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E486")]
	[Address(RVA = "0x2488BA4", Offset = "0x2488BA4", VA = "0x2488BA4")]
	public void SetViewData(ExtraRewardDesc desc, ExtraAwardItemState m_State)
	{
	}

	[Token(Token = "0x600E487")]
	[Address(RVA = "0x24894F4", Offset = "0x24894F4", VA = "0x24894F4")]
	private void OnOKClick()
	{
	}

	[Token(Token = "0x600E488")]
	[Address(RVA = "0x2489558", Offset = "0x2489558", VA = "0x2489558", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E489")]
	[Address(RVA = "0x24895BC", Offset = "0x24895BC", VA = "0x24895BC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E48A")]
	[Address(RVA = "0x2489620", Offset = "0x2489620", VA = "0x2489620")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E48B")]
	[Address(RVA = "0x2489628", Offset = "0x2489628", VA = "0x2489628")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E48C")]
	[Address(RVA = "0x2489630", Offset = "0x2489630", VA = "0x2489630")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
