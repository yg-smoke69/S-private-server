using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CD6")]
public class UIFrontEndPreviewZoomInWithCameraController : UIPopupWindowController
{
	[Token(Token = "0x401117F")]
	[FieldOffset(Offset = "0x48")]
	private UIFrontEndPreviewZoomInWithCameraView m_View;

	[Token(Token = "0x4011180")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_cameraObj;

	[Token(Token = "0x4011181")]
	[FieldOffset(Offset = "0x50")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x4011182")]
	[FieldOffset(Offset = "0x54")]
	private Action m_CallBack;

	[Token(Token = "0x4011183")]
	[FieldOffset(Offset = "0x58")]
	private bool m_IsCreated;

	[Token(Token = "0x4011184")]
	[FieldOffset(Offset = "0x5C")]
	private Vector3 m_LastPosition;

	[Token(Token = "0x4011185")]
	[FieldOffset(Offset = "0x68")]
	private Quaternion m_LastRotation;

	[Token(Token = "0x4011186")]
	[FieldOffset(Offset = "0x78")]
	private Transform m_Transform;

	[Token(Token = "0x6012C39")]
	[Address(RVA = "0xE97550", Offset = "0xE97550", VA = "0xE97550")]
	public UIFrontEndPreviewZoomInWithCameraController()
	{
	}

	[Token(Token = "0x6012C3A")]
	[Address(RVA = "0xE97558", Offset = "0xE97558", VA = "0xE97558")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012C3B")]
	[Address(RVA = "0xE97600", Offset = "0xE97600", VA = "0xE97600", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012C3C")]
	[Address(RVA = "0xE977F8", Offset = "0xE977F8", VA = "0xE977F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012C3D")]
	[Address(RVA = "0xE97AA4", Offset = "0xE97AA4", VA = "0xE97AA4")]
	public void ShowCamera(ResourceID resId)
	{
	}

	[Token(Token = "0x6012C3E")]
	[Address(RVA = "0xE97EC8", Offset = "0xE97EC8", VA = "0xE97EC8")]
	public void SetAvatarPosition(UIMaleAvatar avatar, Vector3 position, Quaternion rotation)
	{
	}

	[Token(Token = "0x6012C3F")]
	[Address(RVA = "0xE98160", Offset = "0xE98160", VA = "0xE98160")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}

	[Token(Token = "0x6012C40")]
	[Address(RVA = "0xE981C0", Offset = "0xE981C0", VA = "0xE981C0")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6012C41")]
	[Address(RVA = "0xE9835C", Offset = "0xE9835C", VA = "0xE9835C")]
	private void OnZoomCancel(object[] data)
	{
	}

	[Token(Token = "0x6012C42")]
	[Address(RVA = "0xE983C4", Offset = "0xE983C4", VA = "0xE983C4", Slot = "43")]
	public override void OnPopupWindowListChange()
	{
	}

	[Token(Token = "0x6012C43")]
	[Address(RVA = "0xE984E0", Offset = "0xE984E0", VA = "0xE984E0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6012C44")]
	[Address(RVA = "0xE984E8", Offset = "0xE984E8", VA = "0xE984E8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6012C45")]
	[Address(RVA = "0xE984F0", Offset = "0xE984F0", VA = "0xE984F0")]
	public void _003C_003EiFixBaseProxy_OnPopupWindowListChange()
	{
	}
}
