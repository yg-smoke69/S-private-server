using System;
using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002C5A")]
public class EmoteAvatarTouchHandler : MonoBehaviour
{
	[Token(Token = "0x4010EB6")]
	[FieldOffset(Offset = "0xC")]
	private Camera cam;

	[Token(Token = "0x4010EB7")]
	[FieldOffset(Offset = "0x10")]
	private UIPopupWindowController popWinCtrl;

	[Token(Token = "0x4010EB8")]
	[FieldOffset(Offset = "0x14")]
	private Type naviType;

	[Token(Token = "0x4010EB9")]
	[FieldOffset(Offset = "0x18")]
	private FrontEndPreviewComponent m_FrontEndPreviewComponent;

	[Token(Token = "0x4010EBA")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_FingerDownOnAvatar;

	[Token(Token = "0x4010EBB")]
	[FieldOffset(Offset = "0x20")]
	private float m_TimeTick;

	[Token(Token = "0x4010EBC")]
	[FieldOffset(Offset = "0x24")]
	private float m_CurrentTime;

	[Token(Token = "0x4010EBD")]
	[FieldOffset(Offset = "0x28")]
	private float OffsetX;

	[Token(Token = "0x4010EBE")]
	[FieldOffset(Offset = "0x2C")]
	private float OffsetY;

	[Token(Token = "0x4010EBF")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 pressPos;

	[Token(Token = "0x4010EC0")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 releasePos;

	[Token(Token = "0x601281A")]
	[Address(RVA = "0x3206E48", Offset = "0x3206E48", VA = "0x3206E48")]
	public EmoteAvatarTouchHandler()
	{
	}

	[Token(Token = "0x601281B")]
	[Address(RVA = "0x3206E50", Offset = "0x3206E50", VA = "0x3206E50")]
	private void Awake()
	{
	}

	[Token(Token = "0x601281C")]
	[Address(RVA = "0x3206F08", Offset = "0x3206F08", VA = "0x3206F08")]
	private void Update()
	{
	}

	[Token(Token = "0x601281D")]
	[Address(RVA = "0x3207C18", Offset = "0x3207C18", VA = "0x3207C18")]
	private bool CheckNaviType(Type t)
	{
		return default(bool);
	}

	[Token(Token = "0x601281E")]
	[Address(RVA = "0x3206F44", Offset = "0x3206F44", VA = "0x3206F44")]
	private void CheckTouchAvatar()
	{
	}

	[Token(Token = "0x601281F")]
	[Address(RVA = "0x3207688", Offset = "0x3207688", VA = "0x3207688")]
	private void CheckInputButtonDown()
	{
	}

	[Token(Token = "0x6012820")]
	[Address(RVA = "0x3207F4C", Offset = "0x3207F4C", VA = "0x3207F4C", Slot = "4")]
	protected virtual void OnTouchAvatar()
	{
	}

	[Token(Token = "0x6012821")]
	[Address(RVA = "0x3207D64", Offset = "0x3207D64", VA = "0x3207D64")]
	private bool IsCamAvalible(Camera cam)
	{
		return default(bool);
	}

	[Token(Token = "0x6012822")]
	[Address(RVA = "0x3208120", Offset = "0x3208120", VA = "0x3208120")]
	public void SetFrontEndPreviewComponent(FrontEndPreviewComponent frontEndPreviewComponent)
	{
	}
}
