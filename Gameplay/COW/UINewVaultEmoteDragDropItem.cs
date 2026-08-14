using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20029FC")]
public class UINewVaultEmoteDragDropItem : UIDragDropItem
{
	[Token(Token = "0x401027E")]
	[FieldOffset(Offset = "0x6C")]
	public EmoteDragDropItemType type;

	[Token(Token = "0x401027F")]
	[FieldOffset(Offset = "0x70")]
	private UINewVaultEmoteSlotController slotController;

	[Token(Token = "0x4010280")]
	[FieldOffset(Offset = "0x74")]
	private UINewVaultEmoteItemController emoteItemController;

	[Token(Token = "0x6010F40")]
	[Address(RVA = "0x2C1E634", Offset = "0x2C1E634", VA = "0x2C1E634")]
	public UINewVaultEmoteDragDropItem()
	{
	}

	[Token(Token = "0x6010F41")]
	[Address(RVA = "0x2C1E6B8", Offset = "0x2C1E6B8", VA = "0x2C1E6B8", Slot = "7")]
	protected override void Start()
	{
	}

	[Token(Token = "0x6010F42")]
	[Address(RVA = "0x2C1E7B0", Offset = "0x2C1E7B0", VA = "0x2C1E7B0", Slot = "11")]
	public override bool StartDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x6010F43")]
	[Address(RVA = "0x2C1EA00", Offset = "0x2C1EA00", VA = "0x2C1EA00", Slot = "20")]
	protected override void OnDragDropRelease(GameObject surface)
	{
	}

	[Token(Token = "0x6010F44")]
	[Address(RVA = "0x2C1F3F8", Offset = "0x2C1F3F8", VA = "0x2C1F3F8", Slot = "17")]
	public override void OnDragOverObject(GameObject obj)
	{
	}

	[Token(Token = "0x6010F45")]
	[Address(RVA = "0x2C1F690", Offset = "0x2C1F690", VA = "0x2C1F690")]
	public void _003C_003EiFixBaseProxy_Start()
	{
	}

	[Token(Token = "0x6010F46")]
	[Address(RVA = "0x2C1F698", Offset = "0x2C1F698", VA = "0x2C1F698")]
	public bool _003C_003EiFixBaseProxy_StartDragging()
	{
		return default(bool);
	}

	[Token(Token = "0x6010F47")]
	[Address(RVA = "0x2C1F6A0", Offset = "0x2C1F6A0", VA = "0x2C1F6A0")]
	public void _003C_003EiFixBaseProxy_OnDragDropRelease(GameObject P0)
	{
	}

	[Token(Token = "0x6010F48")]
	[Address(RVA = "0x2C1F6A8", Offset = "0x2C1F6A8", VA = "0x2C1F6A8")]
	public void _003C_003EiFixBaseProxy_OnDragOverObject(GameObject P0)
	{
	}
}
