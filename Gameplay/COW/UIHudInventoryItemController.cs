using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200278B")]
internal class UIHudInventoryItemController : UIInventoryItemControllerBase
{
	[Token(Token = "0x400F430")]
	[FieldOffset(Offset = "0x30")]
	private UIHudInventoryItemView m_View;

	[Token(Token = "0x600F33E")]
	[Address(RVA = "0x2099C44", Offset = "0x2099C44", VA = "0x2099C44")]
	public UIHudInventoryItemController()
	{
	}

	[Token(Token = "0x600F33F")]
	[Address(RVA = "0x2099C4C", Offset = "0x2099C4C", VA = "0x2099C4C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F340")]
	[Address(RVA = "0x2099CF0", Offset = "0x2099CF0", VA = "0x2099CF0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F341")]
	[Address(RVA = "0x2099E84", Offset = "0x2099E84", VA = "0x2099E84", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F342")]
	[Address(RVA = "0x2099F44", Offset = "0x2099F44", VA = "0x2099F44")]
	public void OnRecycle()
	{
	}

	[Token(Token = "0x600F343")]
	[Address(RVA = "0x209A0C8", Offset = "0x209A0C8", VA = "0x209A0C8")]
	public void OnReInit()
	{
	}

	[Token(Token = "0x600F344")]
	[Address(RVA = "0x209A2E4", Offset = "0x209A2E4", VA = "0x209A2E4")]
	public void SetItemNameColor(Color newColor)
	{
	}

	[Token(Token = "0x600F345")]
	[Address(RVA = "0x209A3AC", Offset = "0x209A3AC", VA = "0x209A3AC")]
	public void SetUIData(UIItem item)
	{
	}

	[Token(Token = "0x600F346")]
	[Address(RVA = "0x209A9A4", Offset = "0x209A9A4", VA = "0x209A9A4")]
	public void RefeshCount(int count)
	{
	}

	[Token(Token = "0x600F347")]
	[Address(RVA = "0x209AA3C", Offset = "0x209AA3C", VA = "0x209AA3C")]
	public UIWidget GetTutorialWidget()
	{
		return null;
	}

	[Token(Token = "0x600F348")]
	[Address(RVA = "0x209AB0C", Offset = "0x209AB0C", VA = "0x209AB0C")]
	private void OnOpBtnGOClick()
	{
	}

	[Token(Token = "0x600F349")]
	[Address(RVA = "0x209C048", Offset = "0x209C048", VA = "0x209C048", Slot = "36")]
	protected override void OnItemToggleChanged()
	{
	}

	[Token(Token = "0x600F34A")]
	[Address(RVA = "0x209B8B4", Offset = "0x209B8B4", VA = "0x209B8B4")]
	private bool HasWeaponCanReplace()
	{
		return default(bool);
	}

	[Token(Token = "0x600F34B")]
	[Address(RVA = "0x209C30C", Offset = "0x209C30C", VA = "0x209C30C")]
	public void HideOpBtnGo()
	{
	}

	[Token(Token = "0x600F34C")]
	[Address(RVA = "0x209C3F4", Offset = "0x209C3F4", VA = "0x209C3F4")]
	public GameObject GetOpBtnGo()
	{
		return null;
	}

	[Token(Token = "0x600F34D")]
	[Address(RVA = "0x209C464", Offset = "0x209C464", VA = "0x209C464")]
	public UISprite GetItemIcon()
	{
		return null;
	}

	[Token(Token = "0x600F34E")]
	[Address(RVA = "0x209C4D4", Offset = "0x209C4D4", VA = "0x209C4D4", Slot = "37")]
	public override UIToggle GetToggle()
	{
		return null;
	}

	[Token(Token = "0x600F34F")]
	[Address(RVA = "0x209C544", Offset = "0x209C544", VA = "0x209C544", Slot = "38")]
	public override GameObject GetHighlightGO()
	{
		return null;
	}

	[Token(Token = "0x600F350")]
	[Address(RVA = "0x209C5B4", Offset = "0x209C5B4", VA = "0x209C5B4", Slot = "39")]
	public override GameObject GetDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F351")]
	[Address(RVA = "0x209C624", Offset = "0x209C624", VA = "0x209C624", Slot = "40")]
	public override GameObject GetNonDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F352")]
	[Address(RVA = "0x209C694", Offset = "0x209C694", VA = "0x209C694")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600F353")]
	[Address(RVA = "0x209C888", Offset = "0x209C888", VA = "0x209C888", Slot = "41")]
	public override GameObject GetDragRedGo()
	{
		return null;
	}

	[Token(Token = "0x600F354")]
	[Address(RVA = "0x209C8F8", Offset = "0x209C8F8", VA = "0x209C8F8", Slot = "35")]
	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F355")]
	[Address(RVA = "0x209A844", Offset = "0x209A844", VA = "0x209A844")]
	private void ShowItemCount(int count)
	{
	}

	[Token(Token = "0x600F356")]
	[Address(RVA = "0x209D25C", Offset = "0x209D25C", VA = "0x209D25C")]
	private bool IsShopToken()
	{
		return default(bool);
	}

	[Token(Token = "0x600F357")]
	[Address(RVA = "0x209D37C", Offset = "0x209D37C", VA = "0x209D37C")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F358")]
	[Address(RVA = "0x209D384", Offset = "0x209D384", VA = "0x209D384")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F359")]
	[Address(RVA = "0x209D38C", Offset = "0x209D38C", VA = "0x209D38C")]
	public void _003C_003EiFixBaseProxy_OnItemToggleChanged()
	{
	}

	[Token(Token = "0x600F35A")]
	[Address(RVA = "0x209D394", Offset = "0x209D394", VA = "0x209D394")]
	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}
}
