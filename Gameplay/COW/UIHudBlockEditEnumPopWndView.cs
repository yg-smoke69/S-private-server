using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035EC")]
public class UIHudBlockEditEnumPopWndView : UIBaseView
{
	[Token(Token = "0x401595E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnConfirm;

	[Token(Token = "0x401595F")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ToggleGrid;

	[Token(Token = "0x4015960")]
	[FieldOffset(Offset = "0x1C")]
	public UIHudBlockEditEnumPopItemController TemplateToggle;

	[Token(Token = "0x4015961")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4015962")]
	[FieldOffset(Offset = "0x24")]
	public UIHudBlockEditEnumPopItemController TemplateItem;

	[Token(Token = "0x4015963")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SpriteGrid;

	[Token(Token = "0x4015964")]
	[FieldOffset(Offset = "0x2C")]
	public UIHudBlockEditEnumPopItemController TemplateSprite;

	[Token(Token = "0x4015965")]
	[FieldOffset(Offset = "0x30")]
	public Transform EnumPopPos;

	[Token(Token = "0x6016572")]
	[Address(RVA = "0x1E0585C", Offset = "0x1E0585C", VA = "0x1E0585C")]
	public UIHudBlockEditEnumPopWndView()
	{
	}

	[Token(Token = "0x6016573")]
	[Address(RVA = "0x1E05864", Offset = "0x1E05864", VA = "0x1E05864", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016574")]
	[Address(RVA = "0x1E05C84", Offset = "0x1E05C84", VA = "0x1E05C84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
