using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026B1")]
public class UIGarenaConnectFacebookPromptController : UIPopupWindowController
{
	[Token(Token = "0x400EEC3")]
	[FieldOffset(Offset = "0x48")]
	private UIGarenaConnectFacebookPromptView m_View;

	[Token(Token = "0x400EEC4")]
	[FieldOffset(Offset = "0x4C")]
	private bool _Connecting;

	[Token(Token = "0x400EEC5")]
	[FieldOffset(Offset = "0x50")]
	private Action _Callback;

	[Token(Token = "0x600E93A")]
	[Address(RVA = "0x21949C8", Offset = "0x21949C8", VA = "0x21949C8")]
	public UIGarenaConnectFacebookPromptController()
	{
	}

	[Token(Token = "0x600E93B")]
	[Address(RVA = "0x21949D0", Offset = "0x21949D0", VA = "0x21949D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E93C")]
	[Address(RVA = "0x2194A74", Offset = "0x2194A74", VA = "0x2194A74", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E93D")]
	[Address(RVA = "0x2194BD0", Offset = "0x2194BD0", VA = "0x2194BD0")]
	public void SetFinishedCallback(Action callback)
	{
	}

	[Token(Token = "0x600E93E")]
	[Address(RVA = "0x2194C30", Offset = "0x2194C30", VA = "0x2194C30", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E93F")]
	[Address(RVA = "0x2194CB8", Offset = "0x2194CB8", VA = "0x2194CB8")]
	private void OnConnectClick()
	{
	}

	[Token(Token = "0x600E940")]
	[Address(RVA = "0x2194D1C", Offset = "0x2194D1C", VA = "0x2194D1C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E941")]
	[Address(RVA = "0x2194D24", Offset = "0x2194D24", VA = "0x2194D24")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
