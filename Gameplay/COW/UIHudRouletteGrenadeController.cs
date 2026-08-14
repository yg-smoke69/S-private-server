using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200283D")]
internal class UIHudRouletteGrenadeController : UIBaseController
{
	[Token(Token = "0x400F83F")]
	[FieldOffset(Offset = "0x0")]
	private static float MaxMoveDis;

	[Token(Token = "0x400F840")]
	[FieldOffset(Offset = "0x4")]
	private static float CancelRadius;

	[Token(Token = "0x400F841")]
	[FieldOffset(Offset = "0x8")]
	private static float CancelRadiusSquare;

	[Token(Token = "0x400F842")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRouletteGrenadeView m_View;

	[Token(Token = "0x400F843")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudGrenadeItem> m_ItemList;

	[Token(Token = "0x400F844")]
	[FieldOffset(Offset = "0x30")]
	private UIHudGrenadeItem m_SelectItem;

	[Token(Token = "0x400F845")]
	[FieldOffset(Offset = "0x34")]
	private int m_SelectIndex;

	[Token(Token = "0x400F846")]
	[FieldOffset(Offset = "0x38")]
	private float m_FixedRatio;

	[Token(Token = "0x600FB1A")]
	[Address(RVA = "0x1C3D77C", Offset = "0x1C3D77C", VA = "0x1C3D77C")]
	public UIHudRouletteGrenadeController()
	{
	}

	[Token(Token = "0x600FB1B")]
	[Address(RVA = "0x1C3D808", Offset = "0x1C3D808", VA = "0x1C3D808")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB1C")]
	[Address(RVA = "0x1C3D8B0", Offset = "0x1C3D8B0", VA = "0x1C3D8B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB1D")]
	[Address(RVA = "0x1C3D9F8", Offset = "0x1C3D9F8", VA = "0x1C3D9F8", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FB1E")]
	[Address(RVA = "0x1C3E0F4", Offset = "0x1C3E0F4", VA = "0x1C3E0F4", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600FB1F")]
	[Address(RVA = "0x1C3E158", Offset = "0x1C3E158", VA = "0x1C3E158", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB20")]
	[Address(RVA = "0x1C3DE5C", Offset = "0x1C3DE5C", VA = "0x1C3DE5C")]
	private void SwapSlotItems(object[] data)
	{
	}

	[Token(Token = "0x600FB21")]
	[Address(RVA = "0x1C3E1BC", Offset = "0x1C3E1BC", VA = "0x1C3E1BC")]
	private void RefreshItemInfo(object[] data)
	{
	}

	[Token(Token = "0x600FB22")]
	[Address(RVA = "0x1C3E2F0", Offset = "0x1C3E2F0", VA = "0x1C3E2F0")]
	public void SetViewData(Vector3 curDirection, bool isShow, bool globalStop)
	{
	}

	[Token(Token = "0x600FB24")]
	[Address(RVA = "0x1C3E9EC", Offset = "0x1C3E9EC", VA = "0x1C3E9EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FB25")]
	[Address(RVA = "0x1C3E9F4", Offset = "0x1C3E9F4", VA = "0x1C3E9F4")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FB26")]
	[Address(RVA = "0x1C3E9FC", Offset = "0x1C3E9FC", VA = "0x1C3E9FC")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600FB27")]
	[Address(RVA = "0x1C3EA04", Offset = "0x1C3EA04", VA = "0x1C3EA04")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
