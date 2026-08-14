using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002B69")]
public class UITokenTipsController : UIPopupWindowController
{
	[Token(Token = "0x40109F6")]
	[FieldOffset(Offset = "0x48")]
	private UITokenTipsView m_View;

	[Token(Token = "0x40109F7")]
	[FieldOffset(Offset = "0x4C")]
	private int m_TopAndBottomPadding;

	[Token(Token = "0x6011E25")]
	[Address(RVA = "0x201F1E0", Offset = "0x201F1E0", VA = "0x201F1E0")]
	public UITokenTipsController()
	{
	}

	[Token(Token = "0x6011E26")]
	[Address(RVA = "0x201F1F0", Offset = "0x201F1F0", VA = "0x201F1F0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011E27")]
	[Address(RVA = "0x201F294", Offset = "0x201F294", VA = "0x201F294", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011E28")]
	[Address(RVA = "0x201F484", Offset = "0x201F484", VA = "0x201F484", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011E29")]
	[Address(RVA = "0x201F5B8", Offset = "0x201F5B8", VA = "0x201F5B8", Slot = "38")]
	protected override bool UseCustomizedAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6011E2A")]
	[Address(RVA = "0x201F610", Offset = "0x201F610", VA = "0x201F610")]
	private void OnNavigationPushed(object[] args)
	{
	}

	[Token(Token = "0x6011E2B")]
	[Address(RVA = "0x201F67C", Offset = "0x201F67C", VA = "0x201F67C")]
	public void SetData(Vector3 itemPos, string descrip, List<BigEventTokenTipsDesc> tokenTipsList, Vector3 offset)
	{
	}

	[Token(Token = "0x6011E2C")]
	[Address(RVA = "0x201FB50", Offset = "0x201FB50", VA = "0x201FB50")]
	private void AdjustView(Vector3 itemPos, Vector3 offset)
	{
	}

	[Token(Token = "0x6011E2D")]
	[Address(RVA = "0x20204D8", Offset = "0x20204D8", VA = "0x20204D8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011E2E")]
	[Address(RVA = "0x20204E0", Offset = "0x20204E0", VA = "0x20204E0")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011E2F")]
	[Address(RVA = "0x20204E8", Offset = "0x20204E8", VA = "0x20204E8")]
	public bool _003C_003EiFixBaseProxy_UseCustomizedAnimation()
	{
		return default(bool);
	}
}
