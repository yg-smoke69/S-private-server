using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200283C")]
internal class UIHudRouletteChatController : UIBaseController
{
	[Token(Token = "0x400F837")]
	[FieldOffset(Offset = "0x0")]
	private static float MaxMoveDis;

	[Token(Token = "0x400F838")]
	[FieldOffset(Offset = "0x4")]
	private static float CancelRadius;

	[Token(Token = "0x400F839")]
	[FieldOffset(Offset = "0x8")]
	private static float CancelRadiusSquare;

	[Token(Token = "0x400F83A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRouletteChatView m_View;

	[Token(Token = "0x400F83B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudRouletteItem> m_ItemList;

	[Token(Token = "0x400F83C")]
	[FieldOffset(Offset = "0x30")]
	private UIHudRouletteItem m_SelectItem;

	[Token(Token = "0x400F83D")]
	[FieldOffset(Offset = "0x34")]
	private int m_SelectIndex;

	[Token(Token = "0x400F83E")]
	[FieldOffset(Offset = "0x38")]
	private float m_FixedRatio;

	[Token(Token = "0x600FB0E")]
	[Address(RVA = "0x1C3BDAC", Offset = "0x1C3BDAC", VA = "0x1C3BDAC")]
	public UIHudRouletteChatController()
	{
	}

	[Token(Token = "0x600FB0F")]
	[Address(RVA = "0x1C3BE38", Offset = "0x1C3BE38", VA = "0x1C3BE38")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB10")]
	[Address(RVA = "0x1C3BEE0", Offset = "0x1C3BEE0", VA = "0x1C3BEE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB11")]
	[Address(RVA = "0x1C3BF9C", Offset = "0x1C3BF9C", VA = "0x1C3BF9C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FB12")]
	[Address(RVA = "0x1C3C8FC", Offset = "0x1C3C8FC", VA = "0x1C3C8FC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600FB13")]
	[Address(RVA = "0x1C3C960", Offset = "0x1C3C960", VA = "0x1C3C960", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB14")]
	[Address(RVA = "0x1C3C9C4", Offset = "0x1C3C9C4", VA = "0x1C3C9C4")]
	public void SetViewData(Vector3 curDirection, bool isShow, bool globalStop)
	{
	}

	[Token(Token = "0x600FB16")]
	[Address(RVA = "0x1C3D25C", Offset = "0x1C3D25C", VA = "0x1C3D25C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FB17")]
	[Address(RVA = "0x1C3D264", Offset = "0x1C3D264", VA = "0x1C3D264")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FB18")]
	[Address(RVA = "0x1C3D26C", Offset = "0x1C3D26C", VA = "0x1C3D26C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600FB19")]
	[Address(RVA = "0x1C3D274", Offset = "0x1C3D274", VA = "0x1C3D274")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
