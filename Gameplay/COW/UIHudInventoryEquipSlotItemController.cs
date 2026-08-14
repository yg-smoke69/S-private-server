using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200278A")]
internal class UIHudInventoryEquipSlotItemController : UIInventoryItemControllerBase
{
	[Token(Token = "0x400F42D")]
	[FieldOffset(Offset = "0x30")]
	private UIHudInventoryEquipSlotItemView m_View;

	[Token(Token = "0x400F42E")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_EmptyBG;

	[Token(Token = "0x400F42F")]
	[FieldOffset(Offset = "0x38")]
	private UIHudInventoryAttachmentSlotItemController m_Attachment;

	[Token(Token = "0x600F329")]
	[Address(RVA = "0x2097780", Offset = "0x2097780", VA = "0x2097780")]
	public UIHudInventoryEquipSlotItemController()
	{
	}

	[Token(Token = "0x600F32A")]
	[Address(RVA = "0x2097788", Offset = "0x2097788", VA = "0x2097788")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F32B")]
	[Address(RVA = "0x209782C", Offset = "0x209782C", VA = "0x209782C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F32C")]
	[Address(RVA = "0x20986FC", Offset = "0x20986FC", VA = "0x20986FC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F32D")]
	[Address(RVA = "0x20987BC", Offset = "0x20987BC", VA = "0x20987BC")]
	public void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG)
	{
	}

	[Token(Token = "0x600F32E")]
	[Address(RVA = "0x20979DC", Offset = "0x20979DC", VA = "0x20979DC")]
	public void SetUIData(UIItem item)
	{
	}

	[Token(Token = "0x600F32F")]
	[Address(RVA = "0x2098864", Offset = "0x2098864", VA = "0x2098864")]
	public void RefreshAttachmentState()
	{
	}

	[Token(Token = "0x600F330")]
	[Address(RVA = "0x2098B44", Offset = "0x2098B44", VA = "0x2098B44", Slot = "35")]
	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F331")]
	[Address(RVA = "0x2098E1C", Offset = "0x2098E1C", VA = "0x2098E1C", Slot = "33")]
	public override void OnDrapStart()
	{
	}

	[Token(Token = "0x600F332")]
	[Address(RVA = "0x2098F28", Offset = "0x2098F28", VA = "0x2098F28")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600F333")]
	[Address(RVA = "0x2099188", Offset = "0x2099188", VA = "0x2099188", Slot = "34")]
	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F334")]
	[Address(RVA = "0x2099310", Offset = "0x2099310", VA = "0x2099310", Slot = "37")]
	public override UIToggle GetToggle()
	{
		return null;
	}

	[Token(Token = "0x600F335")]
	[Address(RVA = "0x2099380", Offset = "0x2099380", VA = "0x2099380", Slot = "38")]
	public override GameObject GetHighlightGO()
	{
		return null;
	}

	[Token(Token = "0x600F336")]
	[Address(RVA = "0x20993F0", Offset = "0x20993F0", VA = "0x20993F0", Slot = "39")]
	public override GameObject GetDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F337")]
	[Address(RVA = "0x2099460", Offset = "0x2099460", VA = "0x2099460", Slot = "40")]
	public override GameObject GetNonDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F338")]
	[Address(RVA = "0x20994D0", Offset = "0x20994D0", VA = "0x20994D0", Slot = "41")]
	public override GameObject GetDragRedGo()
	{
		return null;
	}

	[Token(Token = "0x600F339")]
	[Address(RVA = "0x2099540", Offset = "0x2099540", VA = "0x2099540")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F33A")]
	[Address(RVA = "0x2099548", Offset = "0x2099548", VA = "0x2099548")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F33B")]
	[Address(RVA = "0x2099550", Offset = "0x2099550", VA = "0x2099550")]
	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600F33C")]
	[Address(RVA = "0x2099558", Offset = "0x2099558", VA = "0x2099558")]
	public void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	[Token(Token = "0x600F33D")]
	[Address(RVA = "0x2099560", Offset = "0x2099560", VA = "0x2099560")]
	public bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}
}
