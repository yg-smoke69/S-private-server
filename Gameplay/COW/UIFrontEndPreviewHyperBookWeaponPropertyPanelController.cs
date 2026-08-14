using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CBB")]
public class UIFrontEndPreviewHyperBookWeaponPropertyPanelController : UIFrontEndPreviewWeaponPropertyPanelBaseController
{
	[Token(Token = "0x4011126")]
	[FieldOffset(Offset = "0x38")]
	private UIFrontEndPreviewWeaponPropertyPanelView m_UIView;

	[Token(Token = "0x6012B8E")]
	[Address(RVA = "0x27FCF5C", Offset = "0x27FCF5C", VA = "0x27FCF5C")]
	public UIFrontEndPreviewHyperBookWeaponPropertyPanelController()
	{
	}

	[Token(Token = "0x6012B8F")]
	[Address(RVA = "0x27FCF64", Offset = "0x27FCF64", VA = "0x27FCF64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B90")]
	[Address(RVA = "0x27FD00C", Offset = "0x27FD00C", VA = "0x27FD00C", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B91")]
	[Address(RVA = "0x27FD0BC", Offset = "0x27FD0BC", VA = "0x27FD0BC", Slot = "35")]
	protected override UIFrontEndPreviewWeaponPropertyPanelBaseView InitBaseView()
	{
		return null;
	}
}
