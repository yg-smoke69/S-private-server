using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F46")]
public class UIFFWS03WarmUpController : UIPopupWindowController
{
	[Token(Token = "0x400C4A4")]
	[FieldOffset(Offset = "0x48")]
	private UIFFWS03WarmUpView m_View;

	[Token(Token = "0x400C4A5")]
	[FieldOffset(Offset = "0x4C")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400C4A6")]
	[FieldOffset(Offset = "0x50")]
	private Action m_CloseAction;

	[Token(Token = "0x6009A77")]
	[Address(RVA = "0x1DB3CA8", Offset = "0x1DB3CA8", VA = "0x1DB3CA8")]
	public UIFFWS03WarmUpController()
	{
	}

	[Token(Token = "0x6009A78")]
	[Address(RVA = "0x1DB3CB0", Offset = "0x1DB3CB0", VA = "0x1DB3CB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009A79")]
	[Address(RVA = "0x1DB3D58", Offset = "0x1DB3D58", VA = "0x1DB3D58", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009A7A")]
	[Address(RVA = "0x1DB4320", Offset = "0x1DB4320", VA = "0x1DB4320", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009A7B")]
	[Address(RVA = "0x1DB4464", Offset = "0x1DB4464", VA = "0x1DB4464")]
	public void SetData(Action closeAction)
	{
	}

	[Token(Token = "0x6009A7C")]
	[Address(RVA = "0x1DB438C", Offset = "0x1DB438C", VA = "0x1DB438C")]
	public void PlayEnterAnim()
	{
	}

	[Token(Token = "0x6009A7D")]
	[Address(RVA = "0x1DB4574", Offset = "0x1DB4574", VA = "0x1DB4574")]
	public void PlayExitAnim()
	{
	}

	[Token(Token = "0x6009A7E")]
	[Address(RVA = "0x1DB464C", Offset = "0x1DB464C", VA = "0x1DB464C")]
	public void OnClickClose()
	{
	}

	[Token(Token = "0x6009A7F")]
	[Address(RVA = "0x1DB46D0", Offset = "0x1DB46D0", VA = "0x1DB46D0")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x6009A80")]
	[Address(RVA = "0x1DB4734", Offset = "0x1DB4734", VA = "0x1DB4734")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009A81")]
	[Address(RVA = "0x1DB473C", Offset = "0x1DB473C", VA = "0x1DB473C")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
