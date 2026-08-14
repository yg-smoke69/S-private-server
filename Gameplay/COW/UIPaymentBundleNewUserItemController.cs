using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A19")]
public class UIPaymentBundleNewUserItemController : UIPaymentBundleItemController, _Attribute
{
	[Token(Token = "0x40102DD")]
	[FieldOffset(Offset = "0x48")]
	private UIPaymentBundleNewUserItemView m_View;

	[Token(Token = "0x40102DE")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIStandardItemMiniController> m_ContentItems;

	[Token(Token = "0x40102DF")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601106F")]
	[Address(RVA = "0x28736BC", Offset = "0x28736BC", VA = "0x28736BC")]
	public UIPaymentBundleNewUserItemController()
	{
	}

	[Token(Token = "0x6011070")]
	[Address(RVA = "0x2873744", Offset = "0x2873744", VA = "0x2873744")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011071")]
	[Address(RVA = "0x28737EC", Offset = "0x28737EC", VA = "0x28737EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011072")]
	[Address(RVA = "0x2873A68", Offset = "0x2873A68", VA = "0x2873A68", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011073")]
	[Address(RVA = "0x2873C28", Offset = "0x2873C28", VA = "0x2873C28", Slot = "39")]
	protected override void UpdateContents()
	{
	}

	[Token(Token = "0x6011074")]
	[Address(RVA = "0x2876A30", Offset = "0x2876A30", VA = "0x2876A30")]
	private void OnPurchaseButtonClick()
	{
	}

	[Token(Token = "0x6011075")]
	[Address(RVA = "0x28773F0", Offset = "0x28773F0", VA = "0x28773F0")]
	private void OnPaidFailed(object[] data)
	{
	}

	[Token(Token = "0x6011076")]
	[Address(RVA = "0x2877520", Offset = "0x2877520", VA = "0x2877520")]
	private static void _003COnPurchaseButtonClick_003Em__0()
	{
	}

	[Token(Token = "0x6011077")]
	[Address(RVA = "0x28775B8", Offset = "0x28775B8", VA = "0x28775B8")]
	private bool _003COnPurchaseButtonClick_003Em__1(SpecialStoreDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x6011078")]
	[Address(RVA = "0x2877604", Offset = "0x2877604", VA = "0x2877604")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011079")]
	[Address(RVA = "0x2877608", Offset = "0x2877608", VA = "0x2877608")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601107A")]
	[Address(RVA = "0x287760C", Offset = "0x287760C", VA = "0x287760C")]
	public void _003C_003EiFixBaseProxy_UpdateContents()
	{
	}
}
