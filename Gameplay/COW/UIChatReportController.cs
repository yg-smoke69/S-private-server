using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002513")]
public class UIChatReportController : UIPopupWindowController
{
	[Token(Token = "0x400E60A")]
	[FieldOffset(Offset = "0x48")]
	private UIChatReportView m_View;

	[Token(Token = "0x400E60B")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_SelectedReason;

	[Token(Token = "0x400E60C")]
	[FieldOffset(Offset = "0x50")]
	private MessageInfo m_MessageData;

	[Token(Token = "0x600D738")]
	[Address(RVA = "0x2078AB0", Offset = "0x2078AB0", VA = "0x2078AB0")]
	public UIChatReportController()
	{
	}

	[Token(Token = "0x600D739")]
	[Address(RVA = "0x2078AB8", Offset = "0x2078AB8", VA = "0x2078AB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D73A")]
	[Address(RVA = "0x2078E3C", Offset = "0x2078E3C", VA = "0x2078E3C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D73B")]
	[Address(RVA = "0x2078EE0", Offset = "0x2078EE0", VA = "0x2078EE0")]
	public void SetUIData(MessageInfo messageInfo)
	{
	}

	[Token(Token = "0x600D73C")]
	[Address(RVA = "0x20795FC", Offset = "0x20795FC", VA = "0x20795FC")]
	private void OnReportReasonSelect(UIToggleButton button)
	{
	}

	[Token(Token = "0x600D73D")]
	[Address(RVA = "0x207991C", Offset = "0x207991C", VA = "0x207991C")]
	private void OnReportButtonClick()
	{
	}

	[Token(Token = "0x600D73E")]
	[Address(RVA = "0x2079BC4", Offset = "0x2079BC4", VA = "0x2079BC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
