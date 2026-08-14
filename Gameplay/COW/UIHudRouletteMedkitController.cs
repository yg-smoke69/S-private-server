using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200283E")]
internal class UIHudRouletteMedkitController : UIBaseController
{
	[Token(Token = "0x400F847")]
	[FieldOffset(Offset = "0x0")]
	private static float MaxMoveDis;

	[Token(Token = "0x400F848")]
	[FieldOffset(Offset = "0x4")]
	private static float CancelRadius;

	[Token(Token = "0x400F849")]
	[FieldOffset(Offset = "0x8")]
	private static float CancelRadiusSquare;

	[Token(Token = "0x400F84A")]
	[FieldOffset(Offset = "0x28")]
	private UIHudRouletteMedkitView m_View;

	[Token(Token = "0x400F84B")]
	[FieldOffset(Offset = "0x2C")]
	private List<UIHudMedkitItem> m_ItemList;

	[Token(Token = "0x400F84C")]
	[FieldOffset(Offset = "0x30")]
	private UIHudMedkitItem m_SelectItem;

	[Token(Token = "0x400F84D")]
	[FieldOffset(Offset = "0x34")]
	private int m_SelectIndex;

	[Token(Token = "0x400F84E")]
	[FieldOffset(Offset = "0x38")]
	private float m_FixedRatio;

	[Token(Token = "0x600FB28")]
	[Address(RVA = "0x1C3EFCC", Offset = "0x1C3EFCC", VA = "0x1C3EFCC")]
	public UIHudRouletteMedkitController()
	{
	}

	[Token(Token = "0x600FB29")]
	[Address(RVA = "0x1C3F058", Offset = "0x1C3F058", VA = "0x1C3F058")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600FB2A")]
	[Address(RVA = "0x1C3F100", Offset = "0x1C3F100", VA = "0x1C3F100", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600FB2B")]
	[Address(RVA = "0x1C3F208", Offset = "0x1C3F208", VA = "0x1C3F208", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600FB2C")]
	[Address(RVA = "0x1C3F68C", Offset = "0x1C3F68C", VA = "0x1C3F68C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600FB2D")]
	[Address(RVA = "0x1C3F6F0", Offset = "0x1C3F6F0", VA = "0x1C3F6F0", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB2E")]
	[Address(RVA = "0x1C3F754", Offset = "0x1C3F754", VA = "0x1C3F754", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600FB2F")]
	[Address(RVA = "0x1C3F888", Offset = "0x1C3F888", VA = "0x1C3F888")]
	private void RefreshItemInfo(object[] data)
	{
	}

	[Token(Token = "0x600FB30")]
	[Address(RVA = "0x1C3F9BC", Offset = "0x1C3F9BC", VA = "0x1C3F9BC")]
	public void SetViewData(Vector3 curDirection, bool isShow, bool globalStop)
	{
	}

	[Token(Token = "0x600FB32")]
	[Address(RVA = "0x1C400B8", Offset = "0x1C400B8", VA = "0x1C400B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600FB33")]
	[Address(RVA = "0x1C400C0", Offset = "0x1C400C0", VA = "0x1C400C0")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600FB34")]
	[Address(RVA = "0x1C400C8", Offset = "0x1C400C8", VA = "0x1C400C8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600FB35")]
	[Address(RVA = "0x1C400D0", Offset = "0x1C400D0", VA = "0x1C400D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600FB36")]
	[Address(RVA = "0x1C400D8", Offset = "0x1C400D8", VA = "0x1C400D8")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
