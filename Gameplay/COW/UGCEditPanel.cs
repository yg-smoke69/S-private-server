using System;
using System.Collections.Generic;
using GCommon.UGCUI;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002425")]
public class UGCEditPanel : UGCUIWidget
{
	[Token(Token = "0x400E0F0")]
	[FieldOffset(Offset = "0x40")]
	public bool dragRestrict;

	[Token(Token = "0x400E0F1")]
	[FieldOffset(Offset = "0x44")]
	public Action onClick;

	[Token(Token = "0x400E0F2")]
	[FieldOffset(Offset = "0x48")]
	public Action<Vector2, Vector2> onDrag;

	[Token(Token = "0x400E0F3")]
	[FieldOffset(Offset = "0x4C")]
	public Action<float, float> onPinchAndSpread;

	[Token(Token = "0x400E0F4")]
	[FieldOffset(Offset = "0x50")]
	private float m_InitScale;

	[Token(Token = "0x400E0F5")]
	[FieldOffset(Offset = "0x54")]
	private float m_MinZoomRatio;

	[Token(Token = "0x400E0F6")]
	[FieldOffset(Offset = "0x58")]
	private float m_MaxZoomRatio;

	[Token(Token = "0x400E0F7")]
	[FieldOffset(Offset = "0x5C")]
	private float m_DragRestrictRatioX;

	[Token(Token = "0x400E0F8")]
	[FieldOffset(Offset = "0x60")]
	private float m_DragRestrictRatioY;

	[Token(Token = "0x17001105")]
	public float CurrentScale
	{
		[Token(Token = "0x600CC9D")]
		[Address(RVA = "0x23419A4", Offset = "0x23419A4", VA = "0x23419A4")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600CC9C")]
	[Address(RVA = "0x23418CC", Offset = "0x23418CC", VA = "0x23418CC")]
	public UGCEditPanel()
	{
	}

	[Token(Token = "0x600CC9E")]
	[Address(RVA = "0x2341A3C", Offset = "0x2341A3C", VA = "0x2341A3C")]
	private void Awake()
	{
	}

	[Token(Token = "0x600CC9F")]
	[Address(RVA = "0x2341C28", Offset = "0x2341C28", VA = "0x2341C28")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600CCA0")]
	[Address(RVA = "0x2341DEC", Offset = "0x2341DEC", VA = "0x2341DEC")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x600CCA1")]
	[Address(RVA = "0x2341FB0", Offset = "0x2341FB0", VA = "0x2341FB0")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600CCA2")]
	[Address(RVA = "0x234201C", Offset = "0x234201C", VA = "0x234201C")]
	private void OnDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600CCA3")]
	[Address(RVA = "0x23421B0", Offset = "0x23421B0", VA = "0x23421B0")]
	private void OnGesture(List<LeanFinger> fingers)
	{
	}

	[Token(Token = "0x600CCA4")]
	[Address(RVA = "0x2342324", Offset = "0x2342324", VA = "0x2342324")]
	public void SetZoomLimit(float minRatio, float maxRatio)
	{
	}

	[Token(Token = "0x600CCA5")]
	[Address(RVA = "0x23423AC", Offset = "0x23423AC", VA = "0x23423AC")]
	public void DragSelf(Vector2 currentScreenPosition, Vector2 delta)
	{
	}

	[Token(Token = "0x600CCA6")]
	[Address(RVA = "0x23426E8", Offset = "0x23426E8", VA = "0x23426E8")]
	public float Zoom(float delta)
	{
		return default(float);
	}
}
