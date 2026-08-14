using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200367C")]
public class UIHudInventoryAttachmentSlotItemView : UIBaseView
{
	[Token(Token = "0x4015E2D")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle ItemToggle;

	[Token(Token = "0x4015E2E")]
	[FieldOffset(Offset = "0x18")]
	public UIInventoryItemDragDropContainer DragDropContainer;

	[Token(Token = "0x4015E2F")]
	[FieldOffset(Offset = "0x1C")]
	public UIInventoryItemDrapDrop DragDropItem;

	[Token(Token = "0x4015E30")]
	[FieldOffset(Offset = "0x20")]
	public GameObject NonDragGO;

	[Token(Token = "0x4015E31")]
	[FieldOffset(Offset = "0x24")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015E32")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ItemLevelInfoLabel;

	[Token(Token = "0x4015E33")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ItemLevelInfo;

	[Token(Token = "0x4015E34")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ItemBg;

	[Token(Token = "0x4015E35")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HighlightGO;

	[Token(Token = "0x4015E36")]
	[FieldOffset(Offset = "0x38")]
	public UISprite HighlightSprite;

	[Token(Token = "0x4015E37")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DragGO;

	[Token(Token = "0x4015E38")]
	[FieldOffset(Offset = "0x40")]
	public UISprite ItemDragIcon;

	[Token(Token = "0x4015E39")]
	[FieldOffset(Offset = "0x44")]
	public GameObject DeleteMask;

	[Token(Token = "0x6016721")]
	[Address(RVA = "0x22AC974", Offset = "0x22AC974", VA = "0x22AC974")]
	public UIHudInventoryAttachmentSlotItemView()
	{
	}

	[Token(Token = "0x6016722")]
	[Address(RVA = "0x22AC97C", Offset = "0x22AC97C", VA = "0x22AC97C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016723")]
	[Address(RVA = "0x22ACF74", Offset = "0x22ACF74", VA = "0x22ACF74")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
