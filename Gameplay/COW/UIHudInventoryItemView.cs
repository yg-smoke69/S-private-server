using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200367F")]
public class UIHudInventoryItemView : UIBaseView
{
	[Token(Token = "0x4015E52")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle ItemToggle;

	[Token(Token = "0x4015E53")]
	[FieldOffset(Offset = "0x18")]
	public UIInventoryItemDragDropContainer DragDropContainer;

	[Token(Token = "0x4015E54")]
	[FieldOffset(Offset = "0x1C")]
	public UIInventoryItemDrapDrop DragDropItem;

	[Token(Token = "0x4015E55")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NonDragGO;

	[Token(Token = "0x4015E56")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemName;

	[Token(Token = "0x4015E57")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemCount;

	[Token(Token = "0x4015E58")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteBg;

	[Token(Token = "0x4015E59")]
	[FieldOffset(Offset = "0x30")]
	public GameObject OpBtnGO;

	[Token(Token = "0x4015E5A")]
	[FieldOffset(Offset = "0x34")]
	public UIButton OpBtn;

	[Token(Token = "0x4015E5B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HighlightGO;

	[Token(Token = "0x4015E5C")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015E5D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DragGO;

	[Token(Token = "0x4015E5E")]
	[FieldOffset(Offset = "0x44")]
	public UISprite ItemDragIcon;

	[Token(Token = "0x4015E5F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DeleteMask;

	[Token(Token = "0x601672A")]
	[Address(RVA = "0x209D39C", Offset = "0x209D39C", VA = "0x209D39C")]
	public UIHudInventoryItemView()
	{
	}

	[Token(Token = "0x601672B")]
	[Address(RVA = "0x209D3A4", Offset = "0x209D3A4", VA = "0x209D3A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601672C")]
	[Address(RVA = "0x209D9F0", Offset = "0x209D9F0", VA = "0x209D9F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
