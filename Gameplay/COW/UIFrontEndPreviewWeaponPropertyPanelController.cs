using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CD0")]
public class UIFrontEndPreviewWeaponPropertyPanelController : UIFrontEndPreviewWeaponPropertyPanelBaseController
{
	[Token(Token = "0x401116C")]
	[FieldOffset(Offset = "0x38")]
	private UIFrontEndPreviewWeaponPropertyPanelView m_UIView;

	[Token(Token = "0x6012C12")]
	[Address(RVA = "0xE93974", Offset = "0xE93974", VA = "0xE93974")]
	public UIFrontEndPreviewWeaponPropertyPanelController()
	{
	}

	[Token(Token = "0x6012C13")]
	[Address(RVA = "0xE93978", Offset = "0xE93978", VA = "0xE93978")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012C14")]
	[Address(RVA = "0xE93A20", Offset = "0xE93A20", VA = "0xE93A20", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012C15")]
	[Address(RVA = "0xE93AD0", Offset = "0xE93AD0", VA = "0xE93AD0", Slot = "35")]
	protected override UIFrontEndPreviewWeaponPropertyPanelBaseView InitBaseView()
	{
		return null;
	}
}
