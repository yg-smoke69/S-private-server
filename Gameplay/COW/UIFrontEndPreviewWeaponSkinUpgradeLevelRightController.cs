using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CD4")]
public class UIFrontEndPreviewWeaponSkinUpgradeLevelRightController : UIFrontEndPreviewWeaponSkinUpgradeBaseController
{
	[Token(Token = "0x4011175")]
	[FieldOffset(Offset = "0x3C")]
	private UIFrontEndPreviewWeaponSkinUpgradeLevelRightView m_UIView;

	[Token(Token = "0x6012C23")]
	[Address(RVA = "0xE94F24", Offset = "0xE94F24", VA = "0xE94F24")]
	public UIFrontEndPreviewWeaponSkinUpgradeLevelRightController()
	{
	}

	[Token(Token = "0x6012C24")]
	[Address(RVA = "0xE94F28", Offset = "0xE94F28", VA = "0xE94F28")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012C25")]
	[Address(RVA = "0xE94FD0", Offset = "0xE94FD0", VA = "0xE94FD0", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012C26")]
	[Address(RVA = "0xE95080", Offset = "0xE95080", VA = "0xE95080", Slot = "35")]
	protected override UIFrontEndPreviewWeaponSkinUpgradeBaseView InitBaseView()
	{
		return null;
	}
}
