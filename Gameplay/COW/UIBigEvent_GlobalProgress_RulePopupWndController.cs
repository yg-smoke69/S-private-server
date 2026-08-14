using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E9B")]
public class UIBigEvent_GlobalProgress_RulePopupWndController : UIPopupWindowController
{
	[Token(Token = "0x400C05F")]
	[FieldOffset(Offset = "0x48")]
	private UIBigEvent_GlobalProgress_RulePopupWndView m_View;

	[Token(Token = "0x400C060")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelBigEventTemplate m_UIModelBigEventTemplate;

	[Token(Token = "0x60093AD")]
	[Address(RVA = "0x10C1050", Offset = "0x10C1050", VA = "0x10C1050")]
	public UIBigEvent_GlobalProgress_RulePopupWndController()
	{
	}

	[Token(Token = "0x60093AE")]
	[Address(RVA = "0x10C1058", Offset = "0x10C1058", VA = "0x10C1058", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60093AF")]
	[Address(RVA = "0x10C1224", Offset = "0x10C1224", VA = "0x10C1224")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60093B0")]
	[Address(RVA = "0x10C12CC", Offset = "0x10C12CC", VA = "0x10C12CC")]
	public void RefreshView(EBigEventTemplateRulePopupWndType rulePopupWndType)
	{
	}

	[Token(Token = "0x60093B1")]
	[Address(RVA = "0x10C1760", Offset = "0x10C1760", VA = "0x10C1760")]
	private void OnClickBtnClose()
	{
	}

	[Token(Token = "0x60093B2")]
	[Address(RVA = "0x10C17C4", Offset = "0x10C17C4", VA = "0x10C17C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
