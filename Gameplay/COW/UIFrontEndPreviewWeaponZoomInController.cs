using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CD5")]
public class UIFrontEndPreviewWeaponZoomInController : UIPopupWindowController
{
	[Token(Token = "0x4011176")]
	[FieldOffset(Offset = "0x48")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x4011177")]
	[FieldOffset(Offset = "0x4C")]
	private UIFrontEndPreviewWeaponZoomInView m_View;

	[Token(Token = "0x4011178")]
	[FieldOffset(Offset = "0x50")]
	private GameObject m_ItemCameraGo;

	[Token(Token = "0x4011179")]
	[FieldOffset(Offset = "0x54")]
	private Camera m_ItemCamera;

	[Token(Token = "0x401117A")]
	[FieldOffset(Offset = "0x58")]
	private GameObject m_ZoomItem;

	[Token(Token = "0x401117B")]
	[FieldOffset(Offset = "0x5C")]
	private Action m_CallBack;

	[Token(Token = "0x401117C")]
	[FieldOffset(Offset = "0x60")]
	private bool m_IsCreated;

	[Token(Token = "0x401117D")]
	[FieldOffset(Offset = "0x61")]
	private bool m_CanRotated;

	[Token(Token = "0x401117E")]
	private const float m_RotateRate = 0.5f;

	[Token(Token = "0x6012C27")]
	[Address(RVA = "0xE952A8", Offset = "0xE952A8", VA = "0xE952A8")]
	public UIFrontEndPreviewWeaponZoomInController()
	{
	}

	[Token(Token = "0x6012C28")]
	[Address(RVA = "0xE952B0", Offset = "0xE952B0", VA = "0xE952B0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012C29")]
	[Address(RVA = "0xE95358", Offset = "0xE95358", VA = "0xE95358", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012C2A")]
	[Address(RVA = "0xE9590C", Offset = "0xE9590C", VA = "0xE9590C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012C2B")]
	[Address(RVA = "0xE95DE0", Offset = "0xE95DE0", VA = "0xE95DE0")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6012C2C")]
	[Address(RVA = "0xE95E50", Offset = "0xE95E50", VA = "0xE95E50", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6012C2D")]
	[Address(RVA = "0xE95CA4", Offset = "0xE95CA4", VA = "0xE95CA4")]
	private void SetItemCamState(bool enabled)
	{
	}

	[Token(Token = "0x6012C2E")]
	[Address(RVA = "0xE95EA8", Offset = "0xE95EA8", VA = "0xE95EA8")]
	public void ShowZoomItem(ResourceID resId, uint id, Vector3 position, Quaternion rotation, Vector3 scale, bool showArrow, bool isCreated, bool Rotate, bool backGroundEffect, [Optional] Action cb, bool needCreatePetLight = false, uint petLightType = 0u)
	{
	}

	[Token(Token = "0x6012C2F")]
	[Address(RVA = "0xE96C98", Offset = "0xE96C98", VA = "0xE96C98")]
	private void Rotate3DModel()
	{
	}

	[Token(Token = "0x6012C30")]
	[Address(RVA = "0xE97004", Offset = "0xE97004", VA = "0xE97004")]
	private void Update()
	{
	}

	[Token(Token = "0x6012C31")]
	[Address(RVA = "0xE97074", Offset = "0xE97074", VA = "0xE97074")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6012C32")]
	[Address(RVA = "0xE970D8", Offset = "0xE970D8", VA = "0xE970D8")]
	private void OnZoomCancel(object[] data)
	{
	}

	[Token(Token = "0x6012C33")]
	[Address(RVA = "0xE97140", Offset = "0xE97140", VA = "0xE97140")]
	private void OnZoomClose(object[] data)
	{
	}

	[Token(Token = "0x6012C34")]
	[Address(RVA = "0xE971A8", Offset = "0xE971A8", VA = "0xE971A8", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6012C35")]
	[Address(RVA = "0xE972C4", Offset = "0xE972C4", VA = "0xE972C4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012C36")]
	[Address(RVA = "0xE972CC", Offset = "0xE972CC", VA = "0xE972CC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6012C37")]
	[Address(RVA = "0xE972D4", Offset = "0xE972D4", VA = "0xE972D4")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6012C38")]
	[Address(RVA = "0xE972DC", Offset = "0xE972DC", VA = "0xE972DC")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
