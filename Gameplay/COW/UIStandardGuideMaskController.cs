using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023B9")]
public class UIStandardGuideMaskController : UIPopupWindowController
{
	[Token(Token = "0x20023BA")]
	private sealed class _003CSetViewData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DE60")]
		[FieldOffset(Offset = "0x8")]
		internal List<EventDelegate> guideEvent;

		[Token(Token = "0x600C912")]
		[Address(RVA = "0x2066EE4", Offset = "0x2066EE4", VA = "0x2066EE4")]
		public _003CSetViewData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C913")]
		[Address(RVA = "0x2066FD4", Offset = "0x2066FD4", VA = "0x2066FD4")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400DE59")]
	[FieldOffset(Offset = "0x48")]
	private UIStandardGuideMaskView m_View;

	[Token(Token = "0x400DE5A")]
	[FieldOffset(Offset = "0x4C")]
	private Material m_MaskMat;

	[Token(Token = "0x400DE5B")]
	[FieldOffset(Offset = "0x50")]
	private Transform m_MaskTrans;

	[Token(Token = "0x400DE5C")]
	[FieldOffset(Offset = "0x54")]
	private UIRightReigonClickMask m_GuideClickMask;

	[Token(Token = "0x400DE5D")]
	private const int m_PanelDepth = 20;

	[Token(Token = "0x400DE5E")]
	private const int m_ColliderHalfWidth = 1250;

	[Token(Token = "0x400DE5F")]
	private const int m_ColliderHalfHeight = 750;

	[Token(Token = "0x600C90A")]
	[Address(RVA = "0x2066254", Offset = "0x2066254", VA = "0x2066254")]
	public UIStandardGuideMaskController()
	{
	}

	[Token(Token = "0x600C90B")]
	[Address(RVA = "0x206625C", Offset = "0x206625C", VA = "0x206625C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C90C")]
	[Address(RVA = "0x2066300", Offset = "0x2066300", VA = "0x2066300", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C90D")]
	[Address(RVA = "0x2066434", Offset = "0x2066434", VA = "0x2066434", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600C90E")]
	[Address(RVA = "0x20664AC", Offset = "0x20664AC", VA = "0x20664AC")]
	public void SetViewData(UIWidget widget, [Optional] List<EventDelegate> guideEvent, [Optional] Action guideAction)
	{
	}

	[Token(Token = "0x600C90F")]
	[Address(RVA = "0x2066EEC", Offset = "0x2066EEC", VA = "0x2066EEC")]
	public void UpdateDepth(int newDepth)
	{
	}

	[Token(Token = "0x600C910")]
	[Address(RVA = "0x2066FC4", Offset = "0x2066FC4", VA = "0x2066FC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C911")]
	[Address(RVA = "0x2066FCC", Offset = "0x2066FCC", VA = "0x2066FCC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
