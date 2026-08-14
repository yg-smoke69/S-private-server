using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CC5")]
public class UIFrontendPreviewPVEWeaponPropertyController : UIFrontendPreviewPVEWeaponPropertyBaseController
{
	[Token(Token = "0x401115D")]
	[FieldOffset(Offset = "0x40")]
	private UIFrontendPreviewPVEWeaponPropertyView m_UIView;

	[Token(Token = "0x6012BDB")]
	[Address(RVA = "0x2659404", Offset = "0x2659404", VA = "0x2659404")]
	public UIFrontendPreviewPVEWeaponPropertyController()
	{
	}

	[Token(Token = "0x6012BDC")]
	[Address(RVA = "0x2659408", Offset = "0x2659408", VA = "0x2659408")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012BDD")]
	[Address(RVA = "0x26594B0", Offset = "0x26594B0", VA = "0x26594B0", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012BDE")]
	[Address(RVA = "0x2659560", Offset = "0x2659560", VA = "0x2659560", Slot = "35")]
	protected override UIFrontendPreviewPVEWeaponPropertyBaseView InitBaseView()
	{
		return null;
	}
}
