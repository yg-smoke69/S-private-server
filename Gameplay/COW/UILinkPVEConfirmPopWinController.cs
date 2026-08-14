using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002191")]
public class UILinkPVEConfirmPopWinController : UIPopupWindowController
{
	[Token(Token = "0x400D262")]
	[FieldOffset(Offset = "0x48")]
	private UILinkActivityPVEConfirmPopWindowView m_View;

	[Token(Token = "0x400D263")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_confirmCallback;

	[Token(Token = "0x600B218")]
	[Address(RVA = "0x255B1A4", Offset = "0x255B1A4", VA = "0x255B1A4")]
	public UILinkPVEConfirmPopWinController()
	{
	}

	[Token(Token = "0x600B219")]
	[Address(RVA = "0x255B1AC", Offset = "0x255B1AC", VA = "0x255B1AC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B21A")]
	[Address(RVA = "0x255B254", Offset = "0x255B254", VA = "0x255B254", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B21B")]
	[Address(RVA = "0x2557A48", Offset = "0x2557A48", VA = "0x2557A48")]
	public void SetCallback(Action callback)
	{
	}

	[Token(Token = "0x600B21C")]
	[Address(RVA = "0x255B3B0", Offset = "0x255B3B0", VA = "0x255B3B0")]
	public void OnConfirmClick()
	{
	}

	[Token(Token = "0x600B21D")]
	[Address(RVA = "0x255B428", Offset = "0x255B428", VA = "0x255B428", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600B21E")]
	[Address(RVA = "0x255B494", Offset = "0x255B494", VA = "0x255B494")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B21F")]
	[Address(RVA = "0x255B49C", Offset = "0x255B49C", VA = "0x255B49C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
