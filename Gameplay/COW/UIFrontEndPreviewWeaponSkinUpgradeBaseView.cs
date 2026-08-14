using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CD2")]
public class UIFrontEndPreviewWeaponSkinUpgradeBaseView : UIFrontEndPreviewUIComponentBaseView
{
	[Token(Token = "0x401116E")]
	[FieldOffset(Offset = "0xC")]
	public bool NeedGoToVaultBtn;

	[Token(Token = "0x401116F")]
	[FieldOffset(Offset = "0x10")]
	public UIToggleButton BtnWeaponSkinUpgradeLv1;

	[Token(Token = "0x4011170")]
	[FieldOffset(Offset = "0x14")]
	public UIToggleButton BtnWeaponSkinUpgradeLvMax;

	[Token(Token = "0x4011171")]
	[FieldOffset(Offset = "0x18")]
	public UIButton LevelUpBtn;

	[Token(Token = "0x4011172")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelWeaponSkinUpgradeLvMaxChosen;

	[Token(Token = "0x4011173")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelWeaponSkinUpgradeLvMaxUnChosen;

	[Token(Token = "0x6012C1E")]
	[Address(RVA = "0xE94B90", Offset = "0xE94B90", VA = "0xE94B90")]
	public UIFrontEndPreviewWeaponSkinUpgradeBaseView()
	{
	}
}
