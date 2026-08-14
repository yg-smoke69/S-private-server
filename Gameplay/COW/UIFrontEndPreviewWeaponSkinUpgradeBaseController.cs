using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CD1")]
public abstract class UIFrontEndPreviewWeaponSkinUpgradeBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewWeaponSkinUpgradeBaseView>
{
	[Token(Token = "0x401116D")]
	[FieldOffset(Offset = "0x38")]
	private List<UIToggleButton> m_WeaponUpgradeBtn;

	[Token(Token = "0x6012C16")]
	[Address(RVA = "0xE93CF8", Offset = "0xE93CF8", VA = "0xE93CF8")]
	protected UIFrontEndPreviewWeaponSkinUpgradeBaseController()
	{
	}

	[Token(Token = "0x6012C17")]
	[Address(RVA = "0xE93D5C", Offset = "0xE93D5C", VA = "0xE93D5C", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012C18")]
	[Address(RVA = "0xE93F18", Offset = "0xE93F18", VA = "0xE93F18")]
	private void InitWeaponSkinUpgradeBtnList()
	{
	}

	[Token(Token = "0x6012C19")]
	[Address(RVA = "0xE94230", Offset = "0xE94230", VA = "0xE94230")]
	private void OnGotoWeaponSkinUpgraderClick()
	{
	}

	[Token(Token = "0x6012C1A")]
	[Address(RVA = "0xE94524", Offset = "0xE94524", VA = "0xE94524")]
	public void OnSetWeaponSkinUpgradeLevel(bool isMaxLv)
	{
	}

	[Token(Token = "0x6012C1B")]
	[Address(RVA = "0xE945C4", Offset = "0xE945C4", VA = "0xE945C4")]
	public void OnRefreshWeaponPropertyScore(int maxLevel)
	{
	}

	[Token(Token = "0x6012C1C")]
	[Address(RVA = "0xE94784", Offset = "0xE94784", VA = "0xE94784")]
	public void RefreshWeaponSkinUpgradeItemByLv(ECollectionLevel collectionLevel)
	{
	}

	[Token(Token = "0x6012C1D")]
	[Address(RVA = "0xE94B8C", Offset = "0xE94B8C", VA = "0xE94B8C")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}
}
