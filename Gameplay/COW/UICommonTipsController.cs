using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20025A8")]
public class UICommonTipsController : UIPopupWindowController
{
	[Token(Token = "0x400E8DE")]
	[FieldOffset(Offset = "0x48")]
	private UICommonTipsView m_View;

	[Token(Token = "0x400E8DF")]
	[FieldOffset(Offset = "0x4C")]
	private Vector2 m_showOffset;

	[Token(Token = "0x400E8E0")]
	[FieldOffset(Offset = "0x54")]
	private int m_Width;

	[Token(Token = "0x400E8E1")]
	[FieldOffset(Offset = "0x58")]
	private int m_Height;

	[Token(Token = "0x400E8E2")]
	[FieldOffset(Offset = "0x5C")]
	private float m_scale;

	[Token(Token = "0x400E8E3")]
	[FieldOffset(Offset = "0x60")]
	private UIClickMask m_ClickMask;

	[Token(Token = "0x600DC5D")]
	[Address(RVA = "0x1EBB8E8", Offset = "0x1EBB8E8", VA = "0x1EBB8E8")]
	public UICommonTipsController()
	{
	}

	[Token(Token = "0x600DC5E")]
	[Address(RVA = "0x1EBB8F0", Offset = "0x1EBB8F0", VA = "0x1EBB8F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC5F")]
	[Address(RVA = "0x1EBB994", Offset = "0x1EBB994", VA = "0x1EBB994", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC60")]
	[Address(RVA = "0x1EBBB34", Offset = "0x1EBBB34", VA = "0x1EBBB34")]
	public void ShowTips([Optional] List<string> list)
	{
	}

	[Token(Token = "0x600DC61")]
	[Address(RVA = "0x1EBBC44", Offset = "0x1EBBC44", VA = "0x1EBBC44")]
	public void ShowTipsAtPosition(List<string> list, float postionX, float postionY)
	{
	}

	[Token(Token = "0x600DC62")]
	[Address(RVA = "0x1EBC098", Offset = "0x1EBC098", VA = "0x1EBC098", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DC63")]
	[Address(RVA = "0x1EBC110", Offset = "0x1EBC110", VA = "0x1EBC110")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC64")]
	[Address(RVA = "0x1EBC118", Offset = "0x1EBC118", VA = "0x1EBC118")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
