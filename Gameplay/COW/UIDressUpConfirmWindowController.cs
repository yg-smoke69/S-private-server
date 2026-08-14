using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025D1")]
public class UIDressUpConfirmWindowController : UIPopupWindowController
{
	[Token(Token = "0x400E9D1")]
	[FieldOffset(Offset = "0x48")]
	private UIDressUpConfirmWindowView m_View;

	[Token(Token = "0x400E9D2")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_callback1;

	[Token(Token = "0x400E9D3")]
	[FieldOffset(Offset = "0x50")]
	private Action m_callback2;

	[Token(Token = "0x600DE57")]
	[Address(RVA = "0x276A308", Offset = "0x276A308", VA = "0x276A308")]
	public UIDressUpConfirmWindowController()
	{
	}

	[Token(Token = "0x600DE58")]
	[Address(RVA = "0x276A310", Offset = "0x276A310", VA = "0x276A310")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DE59")]
	[Address(RVA = "0x276A3B4", Offset = "0x276A3B4", VA = "0x276A3B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DE5A")]
	[Address(RVA = "0x276A66C", Offset = "0x276A66C", VA = "0x276A66C")]
	private void OnCallback1()
	{
	}

	[Token(Token = "0x600DE5B")]
	[Address(RVA = "0x276A6EC", Offset = "0x276A6EC", VA = "0x276A6EC")]
	private void OnCallback2()
	{
	}

	[Token(Token = "0x600DE5C")]
	[Address(RVA = "0x276A76C", Offset = "0x276A76C", VA = "0x276A76C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DE5D")]
	[Address(RVA = "0x276A7DC", Offset = "0x276A7DC", VA = "0x276A7DC")]
	public void SetStyle(int index, Action ac1, Action ac2)
	{
	}

	[Token(Token = "0x600DE5E")]
	[Address(RVA = "0x276A918", Offset = "0x276A918", VA = "0x276A918")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DE5F")]
	[Address(RVA = "0x276A920", Offset = "0x276A920", VA = "0x276A920")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
