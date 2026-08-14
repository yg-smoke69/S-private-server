using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20027F8")]
internal class UIHudPickupListController : UIBaseController
{
	[Token(Token = "0x400F69A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudPickupListView m_View;

	[Token(Token = "0x400F69B")]
	[FieldOffset(Offset = "0x2C")]
	private List<MNGBAPBBJDC> m_CurrentPickupList;

	[Token(Token = "0x400F69C")]
	[FieldOffset(Offset = "0x30")]
	private uint m_CurrentContainerID;

	[Token(Token = "0x400F69D")]
	[FieldOffset(Offset = "0x34")]
	private List<UIHudPickupListItemController> m_ItemControllers;

	[Token(Token = "0x400F69E")]
	[FieldOffset(Offset = "0x38")]
	private List<UIHudPickupListItemController> m_InventoryTrashItemControllers;

	[Token(Token = "0x400F69F")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_IsInventoryOpen;

	[Token(Token = "0x400F6A0")]
	[FieldOffset(Offset = "0x40")]
	private AutoPickUpHelper m_AutoPickUp;

	[Token(Token = "0x400F6A1")]
	[FieldOffset(Offset = "0x44")]
	private int m_ScrollViewDepth;

	[Token(Token = "0x400F6A2")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsEnterPickUpArea;

	[Token(Token = "0x400F6A3")]
	[FieldOffset(Offset = "0x4C")]
	private int m_MaxPickupLength;

	[Token(Token = "0x400F6A4")]
	[FieldOffset(Offset = "0x50")]
	private int pickupcellwidth;

	[Token(Token = "0x400F6A5")]
	[FieldOffset(Offset = "0x54")]
	private int m_MaxItemCount;

	[Token(Token = "0x400F6A6")]
	public const uint VISIBILITY_STATE_ItemMarkGridWnd = 536870912u;

	[Token(Token = "0x400F6A7")]
	public const uint VISIBILITY_STATE_TRASHPARTIAL = 1073741824u;

	[Token(Token = "0x400F6A8")]
	[FieldOffset(Offset = "0x58")]
	private bool m_NeedRefresh;

	[Token(Token = "0x400F6A9")]
	[FieldOffset(Offset = "0x5C")]
	private EPickupListOp m_PickupOP;

	[Token(Token = "0x600F831")]
	[Address(RVA = "0x1854238", Offset = "0x1854238", VA = "0x1854238")]
	public UIHudPickupListController()
	{
	}

	[Token(Token = "0x600F832")]
	[Address(RVA = "0x185431C", Offset = "0x185431C", VA = "0x185431C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F833")]
	[Address(RVA = "0x18543C0", Offset = "0x18543C0", VA = "0x18543C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F834")]
	[Address(RVA = "0x1854CCC", Offset = "0x1854CCC", VA = "0x1854CCC", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F835")]
	[Address(RVA = "0x1854D94", Offset = "0x1854D94", VA = "0x1854D94")]
	private void OnShowPickUpList(object[] data)
	{
	}

	[Token(Token = "0x600F836")]
	[Address(RVA = "0x1854E78", Offset = "0x1854E78", VA = "0x1854E78")]
	public void SetCustomTrans(Vector3 pos)
	{
	}

	[Token(Token = "0x600F837")]
	[Address(RVA = "0x1854FCC", Offset = "0x1854FCC", VA = "0x1854FCC")]
	public void SetCustomScale(Vector3 scale)
	{
	}

	[Token(Token = "0x600F838")]
	[Address(RVA = "0x1855120", Offset = "0x1855120", VA = "0x1855120")]
	private void OnHIdePickUpList(object[] data)
	{
	}

	[Token(Token = "0x600F839")]
	[Address(RVA = "0x1855204", Offset = "0x1855204", VA = "0x1855204")]
	private void FreezeAutoPickup(object[] data)
	{
	}

	[Token(Token = "0x600F83A")]
	[Address(RVA = "0x185530C", Offset = "0x185530C", VA = "0x185530C")]
	private void RefreshPickLevel(object[] data)
	{
	}

	[Token(Token = "0x600F83B")]
	[Address(RVA = "0x18557A8", Offset = "0x18557A8", VA = "0x18557A8")]
	private void RefreshItemState(object[] data)
	{
	}

	[Token(Token = "0x600F83C")]
	[Address(RVA = "0x1855AD0", Offset = "0x1855AD0", VA = "0x1855AD0", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F83D")]
	[Address(RVA = "0x1855B34", Offset = "0x1855B34", VA = "0x1855B34", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F83E")]
	[Address(RVA = "0x185616C", Offset = "0x185616C", VA = "0x185616C")]
	private void OnAutoPickUp(object[] data)
	{
	}

	[Token(Token = "0x600F83F")]
	[Address(RVA = "0x185697C", Offset = "0x185697C", VA = "0x185697C")]
	private void RefreshAutoPickupList(object[] data)
	{
	}

	[Token(Token = "0x600F840")]
	[Address(RVA = "0x185768C", Offset = "0x185768C", VA = "0x185768C")]
	private void OnPlayerDead(object[] data)
	{
	}

	[Token(Token = "0x600F841")]
	[Address(RVA = "0x1857710", Offset = "0x1857710", VA = "0x1857710")]
	private void SortList(List<MNGBAPBBJDC> targetlist)
	{
	}

	[Token(Token = "0x600F842")]
	[Address(RVA = "0x185784C", Offset = "0x185784C", VA = "0x185784C")]
	private void OnEnterPickupArea(object[] param)
	{
	}

	[Token(Token = "0x600F843")]
	[Address(RVA = "0x1857D38", Offset = "0x1857D38", VA = "0x1857D38")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600F844")]
	[Address(RVA = "0x18569E8", Offset = "0x18569E8", VA = "0x18569E8")]
	private void RefreshCurrentPickUpList(EPickupListOp op)
	{
	}

	[Token(Token = "0x600F845")]
	[Address(RVA = "0x18580F4", Offset = "0x18580F4", VA = "0x18580F4")]
	private void OnExitPickupArea(object[] param)
	{
	}

	[Token(Token = "0x600F846")]
	[Address(RVA = "0x185820C", Offset = "0x185820C", VA = "0x185820C")]
	private void OnSettingChange(object[] data)
	{
	}

	[Token(Token = "0x600F847")]
	[Address(RVA = "0x1858308", Offset = "0x1858308", VA = "0x1858308")]
	private void OnInventoryOpen(object[] param)
	{
	}

	[Token(Token = "0x600F848")]
	[Address(RVA = "0x18588C4", Offset = "0x18588C4", VA = "0x18588C4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600F849")]
	[Address(RVA = "0x18589C8", Offset = "0x18589C8", VA = "0x18589C8")]
	private void OnInventoryClose(object[] param)
	{
	}

	[Token(Token = "0x600F84A")]
	[Address(RVA = "0x1858B60", Offset = "0x1858B60", VA = "0x1858B60")]
	private void RefreshPickupItem()
	{
	}

	[Token(Token = "0x600F84B")]
	[Address(RVA = "0x185A254", Offset = "0x185A254", VA = "0x185A254")]
	private void RefreshPickupNewItem()
	{
	}

	[Token(Token = "0x600F84C")]
	[Address(RVA = "0x1857DB0", Offset = "0x1857DB0", VA = "0x1857DB0")]
	private void RefreshUIData()
	{
	}

	[Token(Token = "0x600F84D")]
	[Address(RVA = "0x185A7B4", Offset = "0x185A7B4", VA = "0x185A7B4")]
	public bool CheckInScrollDrag()
	{
		return default(bool);
	}

	[Token(Token = "0x600F84E")]
	[Address(RVA = "0x18584A0", Offset = "0x18584A0", VA = "0x18584A0")]
	private void RefreshTutorial()
	{
	}

	[Token(Token = "0x600F84F")]
	[Address(RVA = "0x185A934", Offset = "0x185A934", VA = "0x185A934")]
	public int GetGridepth()
	{
		return default(int);
	}

	[Token(Token = "0x600F850")]
	[Address(RVA = "0x185A98C", Offset = "0x185A98C", VA = "0x185A98C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F851")]
	[Address(RVA = "0x185A994", Offset = "0x185A994", VA = "0x185A994")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600F852")]
	[Address(RVA = "0x185A99C", Offset = "0x185A99C", VA = "0x185A99C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F853")]
	[Address(RVA = "0x185A9A4", Offset = "0x185A9A4", VA = "0x185A9A4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F854")]
	[Address(RVA = "0x185A9AC", Offset = "0x185A9AC", VA = "0x185A9AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
