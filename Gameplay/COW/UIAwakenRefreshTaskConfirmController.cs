using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FB6")]
public class UIAwakenRefreshTaskConfirmController : UIPopupWindowController
{
	[Token(Token = "0x400C6F1")]
	[FieldOffset(Offset = "0x48")]
	private UIAwakenRefreshTaskConfirmWndView m_View;

	[Token(Token = "0x400C6F2")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_CancelAction;

	[Token(Token = "0x400C6F3")]
	[FieldOffset(Offset = "0x50")]
	private Action m_ConfirmAction;

	[Token(Token = "0x6009E81")]
	[Address(RVA = "0x13FEF98", Offset = "0x13FEF98", VA = "0x13FEF98")]
	public UIAwakenRefreshTaskConfirmController()
	{
	}

	[Token(Token = "0x6009E82")]
	[Address(RVA = "0x13FEFA0", Offset = "0x13FEFA0", VA = "0x13FEFA0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009E83")]
	[Address(RVA = "0x13FF048", Offset = "0x13FF048", VA = "0x13FF048", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009E84")]
	[Address(RVA = "0x13FF218", Offset = "0x13FF218", VA = "0x13FF218")]
	protected void OnCancelClick()
	{
	}

	[Token(Token = "0x6009E85")]
	[Address(RVA = "0x13FF290", Offset = "0x13FF290", VA = "0x13FF290")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6009E86")]
	[Address(RVA = "0x13FF308", Offset = "0x13FF308", VA = "0x13FF308")]
	public void SetData(string content)
	{
	}

	[Token(Token = "0x6009E87")]
	[Address(RVA = "0x13FF464", Offset = "0x13FF464", VA = "0x13FF464")]
	public void SetConfirmCallback(Action action)
	{
	}

	[Token(Token = "0x6009E88")]
	[Address(RVA = "0x13FF4C4", Offset = "0x13FF4C4", VA = "0x13FF4C4")]
	public void SetCancelCallback(Action action)
	{
	}

	[Token(Token = "0x6009E89")]
	[Address(RVA = "0x13FF524", Offset = "0x13FF524", VA = "0x13FF524")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
