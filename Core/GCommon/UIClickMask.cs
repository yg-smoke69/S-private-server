using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2004130")]
public class UIClickMask
{
	[Token(Token = "0x2004131")]
	public enum ETouchCheck
	{
		[Token(Token = "0x401B5F5")]
		Press,
		[Token(Token = "0x401B5F6")]
		Release
	}

	[Token(Token = "0x401B5ED")]
	[FieldOffset(Offset = "0x8")]
	private Action m_Action;

	[Token(Token = "0x401B5EE")]
	[FieldOffset(Offset = "0xC")]
	private UIBaseController m_TargetUI;

	[Token(Token = "0x401B5EF")]
	[FieldOffset(Offset = "0x10")]
	private GameObject m_TargetGo;

	[Token(Token = "0x401B5F0")]
	[FieldOffset(Offset = "0x14")]
	private List<Rect> m_RectRegionList;

	[Token(Token = "0x401B5F1")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_ClickWorldPos;

	[Token(Token = "0x401B5F2")]
	[FieldOffset(Offset = "0x24")]
	private bool HideTargetUI;

	[Token(Token = "0x401B5F3")]
	[FieldOffset(Offset = "0x28")]
	private ETouchCheck m_TouchCheck;

	[Token(Token = "0x601AA41")]
	[Address(RVA = "0x2C9C9C8", Offset = "0x2C9C9C8", VA = "0x2C9C9C8")]
	public UIClickMask(Action Action, UIWidget maskRegion)
	{
	}

	[Token(Token = "0x601AA42")]
	[Address(RVA = "0x2C9CE14", Offset = "0x2C9CE14", VA = "0x2C9CE14")]
	public UIClickMask(UIBaseController targetUI, UIWidget maskRegion, bool isHide = false)
	{
	}

	[Token(Token = "0x601AA43")]
	[Address(RVA = "0x2C9D128", Offset = "0x2C9D128", VA = "0x2C9D128")]
	public UIClickMask(GameObject targetGo, UIWidget maskRegion)
	{
	}

	[Token(Token = "0x601AA44")]
	[Address(RVA = "0x2C9D434", Offset = "0x2C9D434", VA = "0x2C9D434")]
	public void SetTouchCheck(ETouchCheck state)
	{
	}

	[Token(Token = "0x601AA45")]
	[Address(RVA = "0x2C9D43C", Offset = "0x2C9D43C", VA = "0x2C9D43C")]
	public void AddMaskRegion(UIWidget maskRegion)
	{
	}

	[Token(Token = "0x601AA46")]
	[Address(RVA = "0x2C9D570", Offset = "0x2C9D570", VA = "0x2C9D570")]
	public void RemoveMaskRegion(UIWidget maskRegion)
	{
	}

	[Token(Token = "0x601AA47")]
	[Address(RVA = "0x2C9D660", Offset = "0x2C9D660", VA = "0x2C9D660")]
	public void Destroy()
	{
	}

	[Token(Token = "0x601AA48")]
	[Address(RVA = "0x2C9D848", Offset = "0x2C9D848", VA = "0x2C9D848")]
	private bool GetMaskPressState()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA49")]
	[Address(RVA = "0x2C9DA24", Offset = "0x2C9DA24", VA = "0x2C9DA24")]
	private bool GetMaskReleaseState()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA4A")]
	[Address(RVA = "0x2C9DC00", Offset = "0x2C9DC00", VA = "0x2C9DC00")]
	private bool IsClickPosInRightRegion()
	{
		return default(bool);
	}

	[Token(Token = "0x601AA4B")]
	[Address(RVA = "0x2C9DD9C", Offset = "0x2C9DD9C", VA = "0x2C9DD9C")]
	private void OnUICameraCustomInput()
	{
	}

	[Token(Token = "0x601AA4C")]
	[Address(RVA = "0x2C9CC98", Offset = "0x2C9CC98", VA = "0x2C9CC98")]
	private Rect MaskRect(UIWidget maskWidget)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Rect);
	}
}
