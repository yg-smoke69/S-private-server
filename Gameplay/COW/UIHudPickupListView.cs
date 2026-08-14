using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036DE")]
public class UIHudPickupListView : UIBaseView
{
	[Token(Token = "0x4016285")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView InventoryTrashScrollview;

	[Token(Token = "0x4016286")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid InventoryTrashItemListGrid;

	[Token(Token = "0x4016287")]
	[FieldOffset(Offset = "0x1C")]
	public Transform InventoryTrashItemListGridTF;

	[Token(Token = "0x4016288")]
	[FieldOffset(Offset = "0x20")]
	public Transform CustomNode;

	[Token(Token = "0x4016289")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView ScrollViewRoot;

	[Token(Token = "0x401628A")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid ItemListGrid;

	[Token(Token = "0x401628B")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ItemListGridTF;

	[Token(Token = "0x401628C")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Mask;

	[Token(Token = "0x6016845")]
	[Address(RVA = "0x185C234", Offset = "0x185C234", VA = "0x185C234")]
	public UIHudPickupListView()
	{
	}

	[Token(Token = "0x6016846")]
	[Address(RVA = "0x185C23C", Offset = "0x185C23C", VA = "0x185C23C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016847")]
	[Address(RVA = "0x185C60C", Offset = "0x185C60C", VA = "0x185C60C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
