using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200367E")]
public class UIHudInventoryEquipSlotItemView : UIBaseView
{
	[Token(Token = "0x4015E42")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle ItemToggle;

	[Token(Token = "0x4015E43")]
	[FieldOffset(Offset = "0x18")]
	public UIInventoryItemDragDropContainer DragDropContainer;

	[Token(Token = "0x4015E44")]
	[FieldOffset(Offset = "0x1C")]
	public UIInventoryItemDrapDrop DragDropItem;

	[Token(Token = "0x4015E45")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NonDragGO;

	[Token(Token = "0x4015E46")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ItemLevelInfo;

	[Token(Token = "0x4015E47")]
	[FieldOffset(Offset = "0x28")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015E48")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ItemName;

	[Token(Token = "0x4015E49")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ItemCount;

	[Token(Token = "0x4015E4A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CountBGGO;

	[Token(Token = "0x4015E4B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HighlightGO;

	[Token(Token = "0x4015E4C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Attachment;

	[Token(Token = "0x4015E4D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject slotEmptyBG;

	[Token(Token = "0x4015E4E")]
	[FieldOffset(Offset = "0x44")]
	public Transform attSlot;

	[Token(Token = "0x4015E4F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DragGO;

	[Token(Token = "0x4015E50")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ItemDragIcon;

	[Token(Token = "0x4015E51")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DeleteMask;

	[Token(Token = "0x6016727")]
	[Address(RVA = "0x2099568", Offset = "0x2099568", VA = "0x2099568")]
	public UIHudInventoryEquipSlotItemView()
	{
	}

	[Token(Token = "0x6016728")]
	[Address(RVA = "0x2099570", Offset = "0x2099570", VA = "0x2099570", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016729")]
	[Address(RVA = "0x2099C3C", Offset = "0x2099C3C", VA = "0x2099C3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
