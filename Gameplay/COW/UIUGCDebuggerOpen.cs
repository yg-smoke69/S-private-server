using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20023FC")]
public class UIUGCDebuggerOpen : UIPopupWindowController
{
	[Token(Token = "0x400E05F")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCDebuggerOpenView m_View;

	[Token(Token = "0x400E060")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCDebugger m_Debugger;

	[Token(Token = "0x400E061")]
	[FieldOffset(Offset = "0x50")]
	private float m_reqDebugTime;

	[Token(Token = "0x400E062")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400E063")]
	[FieldOffset(Offset = "0x4")]
	private static Action _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x170010F5")]
	private bool IsFillFullBot
	{
		[Token(Token = "0x600CB54")]
		[Address(RVA = "0x2B928C0", Offset = "0x2B928C0", VA = "0x2B928C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170010F6")]
	private bool IsStartFromCurCamera
	{
		[Token(Token = "0x600CB55")]
		[Address(RVA = "0x2B9294C", Offset = "0x2B9294C", VA = "0x2B9294C")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600CB4F")]
	[Address(RVA = "0x2B922CC", Offset = "0x2B922CC", VA = "0x2B922CC")]
	public UIUGCDebuggerOpen()
	{
	}

	[Token(Token = "0x600CB50")]
	[Address(RVA = "0x2B922D4", Offset = "0x2B922D4", VA = "0x2B922D4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CB51")]
	[Address(RVA = "0x2B92378", Offset = "0x2B92378", VA = "0x2B92378", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CB52")]
	[Address(RVA = "0x2B927F8", Offset = "0x2B927F8", VA = "0x2B927F8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CB53")]
	[Address(RVA = "0x2B9285C", Offset = "0x2B9285C", VA = "0x2B9285C", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600CB56")]
	[Address(RVA = "0x2B929D8", Offset = "0x2B929D8", VA = "0x2B929D8")]
	private void OnToggleFullBot()
	{
	}

	[Token(Token = "0x600CB57")]
	[Address(RVA = "0x2B92A9C", Offset = "0x2B92A9C", VA = "0x2B92A9C")]
	private void OnToggleStartMode()
	{
	}

	[Token(Token = "0x600CB58")]
	[Address(RVA = "0x2B92B60", Offset = "0x2B92B60", VA = "0x2B92B60")]
	private void Update()
	{
	}

	[Token(Token = "0x600CB59")]
	[Address(RVA = "0x2B92E08", Offset = "0x2B92E08", VA = "0x2B92E08")]
	private static void OnHandleReturnToEdit()
	{
	}

	[Token(Token = "0x600CB5A")]
	[Address(RVA = "0x2B92FA8", Offset = "0x2B92FA8", VA = "0x2B92FA8")]
	private void OnButtonStartDebug()
	{
	}

	[Token(Token = "0x600CB5B")]
	[Address(RVA = "0x2B933C8", Offset = "0x2B933C8", VA = "0x2B933C8")]
	private static void _003CUpdate_003Em__0()
	{
	}

	[Token(Token = "0x600CB5C")]
	[Address(RVA = "0x2B933CC", Offset = "0x2B933CC", VA = "0x2B933CC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CB5D")]
	[Address(RVA = "0x2B933D4", Offset = "0x2B933D4", VA = "0x2B933D4")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600CB5E")]
	[Address(RVA = "0x2B933DC", Offset = "0x2B933DC", VA = "0x2B933DC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}
}
