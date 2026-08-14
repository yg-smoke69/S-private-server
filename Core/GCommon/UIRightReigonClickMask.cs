using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200412F")]
public class UIRightReigonClickMask
{
	[Token(Token = "0x401B5EA")]
	[FieldOffset(Offset = "0x8")]
	private List<Rect> m_RectRegionList;

	[Token(Token = "0x401B5EB")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 m_ClickWorldPos;

	[Token(Token = "0x401B5EC")]
	[FieldOffset(Offset = "0x18")]
	public Action OnClickInRightRegion;

	[Token(Token = "0x601AA39")]
	[Address(RVA = "0x2BBC408", Offset = "0x2BBC408", VA = "0x2BBC408")]
	public UIRightReigonClickMask()
	{
	}

	[Token(Token = "0x601AA3A")]
	[Address(RVA = "0x2BBC494", Offset = "0x2BBC494", VA = "0x2BBC494")]
	public void OpenMask()
	{
	}

	[Token(Token = "0x601AA3B")]
	[Address(RVA = "0x2BBC67C", Offset = "0x2BBC67C", VA = "0x2BBC67C")]
	public void CloseMask()
	{
	}

	[Token(Token = "0x601AA3C")]
	[Address(RVA = "0x2BBC898", Offset = "0x2BBC898", VA = "0x2BBC898")]
	private bool GetMaskPressState()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA3D")]
	[Address(RVA = "0x2BBCA74", Offset = "0x2BBCA74", VA = "0x2BBCA74")]
	private bool IsClickPosInRightRegion()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA3E")]
	[Address(RVA = "0x2BBCC10", Offset = "0x2BBCC10", VA = "0x2BBCC10")]
	protected void OnUICameraCustomInput()
	{
	}

	[Token(Token = "0x601AA3F")]
	[Address(RVA = "0x2BBCE2C", Offset = "0x2BBCE2C", VA = "0x2BBCE2C")]
	public void AddMaskRegion(UIWidget maskRegion)
	{
	}

	[Token(Token = "0x601AA40")]
	[Address(RVA = "0x2BBCECC", Offset = "0x2BBCECC", VA = "0x2BBCECC")]
	private Rect MaskRect(UIWidget maskWidget)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}
}
