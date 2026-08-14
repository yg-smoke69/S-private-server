using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CD3")]
public class UIFrontEndPreviewWeaponSkinUpgradeLeftController : UIFrontEndPreviewWeaponSkinUpgradeBaseController
{
	[Token(Token = "0x4011174")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewWeaponSkinUpgradeLeftView m_UIView;

	[Token(Token = "0x6012C1F")]
	[Address(RVA = "0xE94BA0", Offset = "0xE94BA0", VA = "0xE94BA0")]
	public UIFrontEndPreviewWeaponSkinUpgradeLeftController()
	{
	}

	[Token(Token = "0x6012C20")]
	[Address(RVA = "0xE94BA4", Offset = "0xE94BA4", VA = "0xE94BA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012C21")]
	[Address(RVA = "0xE94C4C", Offset = "0xE94C4C", VA = "0xE94C4C", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012C22")]
	[Address(RVA = "0xE94CFC", Offset = "0xE94CFC", VA = "0xE94CFC", Slot = "35")]
	protected override UIFrontEndPreviewWeaponSkinUpgradeBaseView InitBaseView()
	{
		return null;
	}
}
