using System.Collections.Generic;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002793")]
internal class UIHudItemMarkGridWndController : UIBaseController
{
	[Token(Token = "0x400F45C")]
	[FieldOffset(Offset = "0x28")]
	private UIHudMarkItemShowGridWndView m_View;

	[Token(Token = "0x400F45D")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudItemMarkShowItemController> m_ItemControllers;

	[Token(Token = "0x400F45E")]
	[FieldOffset(Offset = "0x30")]
	private LevelContainerBase m_CurrentContainer;

	[Token(Token = "0x400F45F")]
	[FieldOffset(Offset = "0x34")]
	private int m_CurrentLen;

	[Token(Token = "0x400F460")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_CurrentMarkPosition;

	[Token(Token = "0x400F461")]
	[FieldOffset(Offset = "0x44")]
	private int m_initItemCount;

	[Token(Token = "0x400F462")]
	[FieldOffset(Offset = "0x48")]
	private float m_NextAutoHideTime;

	[Token(Token = "0x400F463")]
	[FieldOffset(Offset = "0x4C")]
	private string BUTTON_MARK_NAME;

	[Token(Token = "0x400F464")]
	[FieldOffset(Offset = "0x50")]
	private string UIROOT_NAME;

	[Token(Token = "0x400F465")]
	[FieldOffset(Offset = "0x54")]
	private string BTNITEM_NAME;

	[Token(Token = "0x600F3B7")]
	[Address(RVA = "0x20A7104", Offset = "0x20A7104", VA = "0x20A7104")]
	public UIHudItemMarkGridWndController()
	{
	}

	[Token(Token = "0x600F3B8")]
	[Address(RVA = "0x20A71CC", Offset = "0x20A71CC", VA = "0x20A71CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F3B9")]
	[Address(RVA = "0x20A7270", Offset = "0x20A7270", VA = "0x20A7270", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F3BA")]
	[Address(RVA = "0x20A76A4", Offset = "0x20A76A4", VA = "0x20A76A4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F3BB")]
	[Address(RVA = "0x20A79E0", Offset = "0x20A79E0", VA = "0x20A79E0")]
	private void RefreshShowList(object[] param)
	{
	}

	[Token(Token = "0x600F3BC")]
	[Address(RVA = "0x20A80B8", Offset = "0x20A80B8", VA = "0x20A80B8")]
	private void OnEnterPickupArea(object[] param)
	{
	}

	[Token(Token = "0x600F3BD")]
	[Address(RVA = "0x20A8114", Offset = "0x20A8114", VA = "0x20A8114")]
	private void OnLocalPlayerBeHit(object[] param)
	{
	}

	[Token(Token = "0x600F3BE")]
	[Address(RVA = "0x20A83C0", Offset = "0x20A83C0", VA = "0x20A83C0")]
	private void FixedUpdate()
	{
	}

	[Token(Token = "0x600F3BF")]
	[Address(RVA = "0x20A8200", Offset = "0x20A8200", VA = "0x20A8200")]
	private void ExitChooseWndState()
	{
	}

	[Token(Token = "0x600F3C0")]
	[Address(RVA = "0x20A85A4", Offset = "0x20A85A4", VA = "0x20A85A4")]
	private void OnExitPickupArea(object[] param)
	{
	}

	[Token(Token = "0x600F3C1")]
	[Address(RVA = "0x20A8600", Offset = "0x20A8600", VA = "0x20A8600")]
	private void OnChooseOneItemMark(object[] param)
	{
	}

	[Token(Token = "0x600F3C2")]
	[Address(RVA = "0x20A88C8", Offset = "0x20A88C8", VA = "0x20A88C8")]
	private void OnClickEndShow(List<GameObject> hits)
	{
	}

	[Token(Token = "0x600F3C3")]
	[Address(RVA = "0x20A8930", Offset = "0x20A8930", VA = "0x20A8930")]
	private void OnDragScreenEvent(GameObject obj, Vector2 dragStartPos)
	{
	}

	[Token(Token = "0x600F3C4")]
	[Address(RVA = "0x20A8B48", Offset = "0x20A8B48", VA = "0x20A8B48", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F3C5")]
	[Address(RVA = "0x20A7AD0", Offset = "0x20A7AD0", VA = "0x20A7AD0")]
	public void RefreshPickUpDataList(LevelContainerBase container)
	{
	}

	[Token(Token = "0x600F3C6")]
	[Address(RVA = "0x20A843C", Offset = "0x20A843C", VA = "0x20A843C")]
	private void ClearMarkItemControllers()
	{
	}

	[Token(Token = "0x600F3C7")]
	[Address(RVA = "0x20A8D7C", Offset = "0x20A8D7C", VA = "0x20A8D7C")]
	private void ShowMarkItemUI(uint dataID, uint Count, Vector3 Position)
	{
	}

	[Token(Token = "0x600F3C8")]
	[Address(RVA = "0x20A9378", Offset = "0x20A9378", VA = "0x20A9378")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F3C9")]
	[Address(RVA = "0x20A9380", Offset = "0x20A9380", VA = "0x20A9380")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F3CA")]
	[Address(RVA = "0x20A9388", Offset = "0x20A9388", VA = "0x20A9388")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
