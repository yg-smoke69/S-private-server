using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002784")]
internal class UIHudInventoryAttachmentSlotItemController : UIInventoryItemControllerBase
{
	[Token(Token = "0x400F3F6")]
	[FieldOffset(Offset = "0x30")]
	protected UIHudInventoryAttachmentSlotItemView m_View;

	[Token(Token = "0x400F3F7")]
	[FieldOffset(Offset = "0x34")]
	protected GameObject m_EmptyBG;

	[Token(Token = "0x400F3F8")]
	[FieldOffset(Offset = "0x38")]
	protected bool m_EnableDrag;

	[Token(Token = "0x600F2AC")]
	[Address(RVA = "0x22A9F94", Offset = "0x22A9F94", VA = "0x22A9F94")]
	public UIHudInventoryAttachmentSlotItemController()
	{
	}

	[Token(Token = "0x600F2AD")]
	[Address(RVA = "0x22AA5BC", Offset = "0x22AA5BC", VA = "0x22AA5BC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F2AE")]
	[Address(RVA = "0x22AAAD4", Offset = "0x22AAAD4", VA = "0x22AAAD4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F2AF")]
	[Address(RVA = "0x22AAC08", Offset = "0x22AAC08", VA = "0x22AAC08", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F2B0")]
	[Address(RVA = "0x22AA0AC", Offset = "0x22AA0AC", VA = "0x22AA0AC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F2B1")]
	[Address(RVA = "0x22AAD70", Offset = "0x22AAD70", VA = "0x22AAD70")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600F2B2")]
	[Address(RVA = "0x22AA16C", Offset = "0x22AA16C", VA = "0x22AA16C")]
	protected void EnableDrageDrop(bool enable)
	{
	}

	[Token(Token = "0x600F2B3")]
	[Address(RVA = "0x22AA9E4", Offset = "0x22AA9E4", VA = "0x22AA9E4", Slot = "42")]
	public virtual void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG, UIInventoryItemDragDropContainer parentContainer)
	{
	}

	[Token(Token = "0x600F2B4")]
	[Address(RVA = "0x22AAFD0", Offset = "0x22AAFD0", VA = "0x22AAFD0", Slot = "43")]
	public virtual void SetUIData(UIItem item)
	{
	}

	[Token(Token = "0x600F2B5")]
	[Address(RVA = "0x22ABA28", Offset = "0x22ABA28", VA = "0x22ABA28")]
	private void OnSlotItemChanged(object[] data)
	{
	}

	[Token(Token = "0x600F2B6")]
	[Address(RVA = "0x22ABAC0", Offset = "0x22ABAC0", VA = "0x22ABAC0", Slot = "35")]
	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F2B7")]
	[Address(RVA = "0x22AA2C8", Offset = "0x22AA2C8", VA = "0x22AA2C8", Slot = "33")]
	public override void OnDrapStart()
	{
	}

	[Token(Token = "0x600F2B8")]
	[Address(RVA = "0x22AA3D8", Offset = "0x22AA3D8", VA = "0x22AA3D8", Slot = "34")]
	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F2B9")]
	[Address(RVA = "0x22AC714", Offset = "0x22AC714", VA = "0x22AC714", Slot = "37")]
	public override UIToggle GetToggle()
	{
		return null;
	}

	[Token(Token = "0x600F2BA")]
	[Address(RVA = "0x22AC784", Offset = "0x22AC784", VA = "0x22AC784", Slot = "38")]
	public override GameObject GetHighlightGO()
	{
		return null;
	}

	[Token(Token = "0x600F2BB")]
	[Address(RVA = "0x22AC7F4", Offset = "0x22AC7F4", VA = "0x22AC7F4", Slot = "39")]
	public override GameObject GetDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F2BC")]
	[Address(RVA = "0x22AC864", Offset = "0x22AC864", VA = "0x22AC864", Slot = "40")]
	public override GameObject GetNonDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F2BD")]
	[Address(RVA = "0x22AC8D4", Offset = "0x22AC8D4", VA = "0x22AC8D4", Slot = "41")]
	public override GameObject GetDragRedGo()
	{
		return null;
	}

	[Token(Token = "0x600F2BE")]
	[Address(RVA = "0x22AC650", Offset = "0x22AC650", VA = "0x22AC650")]
	private BMGBKEENCJH GetEquipSlotByContainerType(EInventoryDragDropContainerType containerType)
	{
		return default(BMGBKEENCJH);
	}

	[Token(Token = "0x600F2BF")]
	[Address(RVA = "0x22AC944", Offset = "0x22AC944", VA = "0x22AC944")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F2C0")]
	[Address(RVA = "0x22AC94C", Offset = "0x22AC94C", VA = "0x22AC94C")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F2C1")]
	[Address(RVA = "0x22AC954", Offset = "0x22AC954", VA = "0x22AC954")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F2C2")]
	[Address(RVA = "0x22AC95C", Offset = "0x22AC95C", VA = "0x22AC95C")]
	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600F2C3")]
	[Address(RVA = "0x22AC964", Offset = "0x22AC964", VA = "0x22AC964")]
	public void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	[Token(Token = "0x600F2C4")]
	[Address(RVA = "0x22AC96C", Offset = "0x22AC96C", VA = "0x22AC96C")]
	public bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}
}
