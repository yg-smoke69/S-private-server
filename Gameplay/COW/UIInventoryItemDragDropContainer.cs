using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D02")]
public class UIInventoryItemDragDropContainer : UIDragDropContainer
{
	[Token(Token = "0x4011279")]
	[FieldOffset(Offset = "0x10")]
	public UIInventoryItemDragDropContainer ParentContainer;

	[Token(Token = "0x401127A")]
	[FieldOffset(Offset = "0x14")]
	public EInventoryDragDropContainerType ContainerType;

	[Token(Token = "0x6012D0D")]
	[Address(RVA = "0x1286C5C", Offset = "0x1286C5C", VA = "0x1286C5C")]
	public UIInventoryItemDragDropContainer()
	{
	}

	[Token(Token = "0x6012D0E")]
	[Address(RVA = "0x1286C64", Offset = "0x1286C64", VA = "0x1286C64")]
	protected void OnDragOver(GameObject dragged)
	{
	}

	[Token(Token = "0x6012D0F")]
	[Address(RVA = "0x1286ED0", Offset = "0x1286ED0", VA = "0x1286ED0")]
	protected void OnDragOut(GameObject dragged)
	{
	}
}
