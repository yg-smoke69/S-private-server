using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200268C")]
public class UIGachaCouponExpireInfoController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400EDE4")]
	[FieldOffset(Offset = "0x48")]
	private UIGachaCouponExpireInfoView m_View;

	[Token(Token = "0x400EDE5")]
	[FieldOffset(Offset = "0x50")]
	private ulong m_AccountId;

	[Token(Token = "0x400EDE6")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<Item> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600E768")]
	[Address(RVA = "0x246E778", Offset = "0x246E778", VA = "0x246E778")]
	public UIGachaCouponExpireInfoController()
	{
	}

	[Token(Token = "0x600E769")]
	[Address(RVA = "0x246E780", Offset = "0x246E780", VA = "0x246E780")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E76A")]
	[Address(RVA = "0x246E828", Offset = "0x246E828", VA = "0x246E828", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E76B")]
	[Address(RVA = "0x246F3A8", Offset = "0x246F3A8", VA = "0x246F3A8")]
	private int FindSelectItemChestID()
	{
		return default(int);
	}

	[Token(Token = "0x600E76C")]
	[Address(RVA = "0x246F9B0", Offset = "0x246F9B0", VA = "0x246F9B0")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600E76D")]
	[Address(RVA = "0x246FAF8", Offset = "0x246FAF8", VA = "0x246FAF8")]
	private void OnToggleClick()
	{
	}

	[Token(Token = "0x600E76E")]
	[Address(RVA = "0x246FDA8", Offset = "0x246FDA8", VA = "0x246FDA8", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E76F")]
	[Address(RVA = "0x246FE7C", Offset = "0x246FE7C", VA = "0x246FE7C", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E770")]
	[Address(RVA = "0x246FF74", Offset = "0x246FF74", VA = "0x246FF74", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E771")]
	[Address(RVA = "0x246FFF0", Offset = "0x246FFF0", VA = "0x246FFF0")]
	private static int _003COnUIInit_003Em__0(Item a, Item b)
	{
		return default(int);
	}

	[Token(Token = "0x600E772")]
	[Address(RVA = "0x2470038", Offset = "0x2470038", VA = "0x2470038")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E773")]
	[Address(RVA = "0x2470040", Offset = "0x2470040", VA = "0x2470040")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
