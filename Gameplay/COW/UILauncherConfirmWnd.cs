using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028EB")]
public class UILauncherConfirmWnd : UIPopupWindowController
{
	[Token(Token = "0x400FBA0")]
	[FieldOffset(Offset = "0x48")]
	private UILauncherConfirmWndView m_View;

	[Token(Token = "0x400FBA1")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_ConfirmAction;

	[Token(Token = "0x400FBA2")]
	[FieldOffset(Offset = "0x50")]
	private Action m_CancelAction;

	[Token(Token = "0x60102A8")]
	[Address(RVA = "0x22DA628", Offset = "0x22DA628", VA = "0x22DA628")]
	public UILauncherConfirmWnd()
	{
	}

	[Token(Token = "0x60102A9")]
	[Address(RVA = "0x22DA630", Offset = "0x22DA630", VA = "0x22DA630", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60102AA")]
	[Address(RVA = "0x22DA8CC", Offset = "0x22DA8CC", VA = "0x22DA8CC")]
	protected void OnCancelClick()
	{
	}

	[Token(Token = "0x60102AB")]
	[Address(RVA = "0x22DA944", Offset = "0x22DA944", VA = "0x22DA944")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x60102AC")]
	[Address(RVA = "0x22DA9BC", Offset = "0x22DA9BC", VA = "0x22DA9BC")]
	public void SetData(string text = "")
	{
	}

	[Token(Token = "0x60102AD")]
	[Address(RVA = "0x22DAA54", Offset = "0x22DAA54", VA = "0x22DAA54")]
	public void SetOneTextOverflow(Overflow overflow)
	{
	}

	[Token(Token = "0x60102AE")]
	[Address(RVA = "0x22DAAEC", Offset = "0x22DAAEC", VA = "0x22DAAEC")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x60102AF")]
	[Address(RVA = "0x22DAC48", Offset = "0x22DAC48", VA = "0x22DAC48")]
	public void ShowCancelButton()
	{
	}

	[Token(Token = "0x60102B0")]
	[Address(RVA = "0x22DACF8", Offset = "0x22DACF8", VA = "0x22DACF8")]
	public void SetConfirmBtnLabel(string key)
	{
	}

	[Token(Token = "0x60102B1")]
	[Address(RVA = "0x22DAE54", Offset = "0x22DAE54", VA = "0x22DAE54")]
	public void SetCancelBtnLabel(string key)
	{
	}

	[Token(Token = "0x60102B2")]
	[Address(RVA = "0x22DAFB0", Offset = "0x22DAFB0", VA = "0x22DAFB0")]
	public void SetConfirmCallback(Action action)
	{
	}

	[Token(Token = "0x60102B3")]
	[Address(RVA = "0x22DB010", Offset = "0x22DB010", VA = "0x22DB010")]
	public void SetCancelCallback(Action action)
	{
	}

	[Token(Token = "0x60102B4")]
	[Address(RVA = "0x22DB070", Offset = "0x22DB070", VA = "0x22DB070")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
