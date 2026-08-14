using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20022D3")]
internal class UIHudReaperTransformController : UIBaseController
{
	[Token(Token = "0x400D981")]
	[FieldOffset(Offset = "0x28")]
	private UIHudReaperTransformView m_View;

	[Token(Token = "0x400D982")]
	[FieldOffset(Offset = "0x2C")]
	private float iconDarkAlpha;

	[Token(Token = "0x400D983")]
	[FieldOffset(Offset = "0x0")]
	private static Action<bool> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x400D984")]
	[FieldOffset(Offset = "0x4")]
	private static Action<bool> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x400D985")]
	[FieldOffset(Offset = "0x8")]
	private static Action<bool> _003C_003Ef__am_0024cache2;

	[Token(Token = "0x600BFDB")]
	[Address(RVA = "0x13D964C", Offset = "0x13D964C", VA = "0x13D964C")]
	public UIHudReaperTransformController()
	{
	}

	[Token(Token = "0x600BFDC")]
	[Address(RVA = "0x13D96D8", Offset = "0x13D96D8", VA = "0x13D96D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BFDD")]
	[Address(RVA = "0x13D9780", Offset = "0x13D9780", VA = "0x13D9780", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BFDE")]
	[Address(RVA = "0x13D9A6C", Offset = "0x13D9A6C", VA = "0x13D9A6C")]
	private void OnTransformClick()
	{
	}

	[Token(Token = "0x600BFDF")]
	[Address(RVA = "0x13D9CEC", Offset = "0x13D9CEC", VA = "0x13D9CEC")]
	public void UpdateState()
	{
	}

	[Token(Token = "0x600BFE0")]
	[Address(RVA = "0x13DA394", Offset = "0x13DA394", VA = "0x13DA394")]
	private static void _003CUpdateState_003Em__0(bool active)
	{
	}

	[Token(Token = "0x600BFE1")]
	[Address(RVA = "0x13DA52C", Offset = "0x13DA52C", VA = "0x13DA52C")]
	private static void _003CUpdateState_003Em__1(bool active)
	{
	}

	[Token(Token = "0x600BFE2")]
	[Address(RVA = "0x13DA6C4", Offset = "0x13DA6C4", VA = "0x13DA6C4")]
	private static void _003CUpdateState_003Em__2(bool active)
	{
	}

	[Token(Token = "0x600BFE3")]
	[Address(RVA = "0x13DA85C", Offset = "0x13DA85C", VA = "0x13DA85C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
