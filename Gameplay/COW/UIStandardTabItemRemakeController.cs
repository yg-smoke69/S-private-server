using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023C6")]
public class UIStandardTabItemRemakeController : UIStandardTabItemController
{
	[Token(Token = "0x400DE95")]
	[FieldOffset(Offset = "0x84")]
	private UIStandardTabItemRemakeView m_RemakeView;

	[Token(Token = "0x600C9B8")]
	[Address(RVA = "0x2003280", Offset = "0x2003280", VA = "0x2003280")]
	public UIStandardTabItemRemakeController()
	{
	}

	[Token(Token = "0x600C9B9")]
	[Address(RVA = "0x200332C", Offset = "0x200332C", VA = "0x200332C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C9BA")]
	[Address(RVA = "0x20033D4", Offset = "0x20033D4", VA = "0x20033D4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C9BB")]
	[Address(RVA = "0x2003564", Offset = "0x2003564", VA = "0x2003564", Slot = "38")]
	protected override UIStandardSubTabItemController CreateSubTabItem(Transform container, bool isLastSubTab)
	{
		return null;
	}

	[Token(Token = "0x600C9BC")]
	[Address(RVA = "0x2003698", Offset = "0x2003698", VA = "0x2003698", Slot = "39")]
	protected override void UpdateExtraSubTabView(bool value)
	{
	}

	[Token(Token = "0x600C9BD")]
	[Address(RVA = "0x2003AE8", Offset = "0x2003AE8", VA = "0x2003AE8", Slot = "37")]
	public override void CheckTagState()
	{
	}

	[Token(Token = "0x600C9BE")]
	[Address(RVA = "0x2003F3C", Offset = "0x2003F3C", VA = "0x2003F3C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C9BF")]
	[Address(RVA = "0x2003F40", Offset = "0x2003F40", VA = "0x2003F40")]
	public UIStandardSubTabItemController _003C_003EiFixBaseProxy_CreateSubTabItem(Transform P0, bool P1)
	{
		return null;
	}

	[Token(Token = "0x600C9C0")]
	[Address(RVA = "0x2003F44", Offset = "0x2003F44", VA = "0x2003F44")]
	public void _003C_003EiFixBaseProxy_UpdateExtraSubTabView(bool P0)
	{
	}

	[Token(Token = "0x600C9C1")]
	[Address(RVA = "0x2003F48", Offset = "0x2003F48", VA = "0x2003F48")]
	public void _003C_003EiFixBaseProxy_CheckTagState()
	{
	}
}
