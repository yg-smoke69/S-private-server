using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20021D0")]
public class UIInstallmentRepayController : UIPopupWindowController
{
	[Token(Token = "0x400D369")]
	[FieldOffset(Offset = "0x48")]
	private UIInstallmentRepayView m_View;

	[Token(Token = "0x400D36A")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_Action;

	[Token(Token = "0x600B50C")]
	[Address(RVA = "0x1280870", Offset = "0x1280870", VA = "0x1280870")]
	public UIInstallmentRepayController()
	{
	}

	[Token(Token = "0x600B50D")]
	[Address(RVA = "0x1280878", Offset = "0x1280878", VA = "0x1280878")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B50E")]
	[Address(RVA = "0x1280920", Offset = "0x1280920", VA = "0x1280920", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B50F")]
	[Address(RVA = "0x1280AF0", Offset = "0x1280AF0", VA = "0x1280AF0")]
	private void OnOkBtnClick()
	{
	}

	[Token(Token = "0x600B510")]
	[Address(RVA = "0x1280B70", Offset = "0x1280B70", VA = "0x1280B70")]
	public void RefreshData(uint itemID, string message = "T_17_I_INSTALLPAY_PAID_NOTICE", [Optional] Action okAction)
	{
	}

	[Token(Token = "0x600B511")]
	[Address(RVA = "0x1280DD8", Offset = "0x1280DD8", VA = "0x1280DD8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
