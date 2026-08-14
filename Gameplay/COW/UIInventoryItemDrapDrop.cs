using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D03")]
public class UIInventoryItemDrapDrop : UIDragDropItem
{
	[Token(Token = "0x401127B")]
	[FieldOffset(Offset = "0x6C")]
	private UIInventoryItemControllerBase m_BaseController;

	[Token(Token = "0x6012D10")]
	[Address(RVA = "0x128713C", Offset = "0x128713C", VA = "0x128713C")]
	public UIInventoryItemDrapDrop()
	{
	}

	[Token(Token = "0x6012D11")]
	[Address(RVA = "0x12871C0", Offset = "0x12871C0", VA = "0x12871C0", Slot = "7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6012D12")]
	[Address(RVA = "0x12872C8", Offset = "0x12872C8", VA = "0x12872C8", Slot = "18")]
	protected override void OnDragDropStart()
	{
	}

	[Token(Token = "0x6012D13")]
	[Address(RVA = "0x12874A8", Offset = "0x12874A8", VA = "0x12874A8", Slot = "16")]
	protected override void ForceStopDragging(GameObject go)
	{
	}

	[Token(Token = "0x6012D14")]
	[Address(RVA = "0x1287514", Offset = "0x1287514", VA = "0x1287514")]
	public void OnDragFocus()
	{
	}

	[Token(Token = "0x6012D15")]
	[Address(RVA = "0x128757C", Offset = "0x128757C", VA = "0x128757C", Slot = "20")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x6012D16")]
	[Address(RVA = "0x12879A8", Offset = "0x12879A8", VA = "0x12879A8")]
	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	[Token(Token = "0x6012D17")]
	[Address(RVA = "0x12879B0", Offset = "0x12879B0", VA = "0x12879B0")]
	public void _003C_003EiFixBaseProxy_OnDragDropStart()
	{
	}

	[Token(Token = "0x6012D18")]
	[Address(RVA = "0x12879B8", Offset = "0x12879B8", VA = "0x12879B8")]
	public void _003C_003EiFixBaseProxy_ForceStopDragging(GameObject P0)
	{
	}

	[Token(Token = "0x6012D19")]
	[Address(RVA = "0x12879C0", Offset = "0x12879C0", VA = "0x12879C0")]
	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}
}
