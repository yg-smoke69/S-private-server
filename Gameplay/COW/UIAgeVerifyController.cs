using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200249B")]
public class UIAgeVerifyController : UIPopupWindowController
{
	[Token(Token = "0x400E2E5")]
	[FieldOffset(Offset = "0x48")]
	public UIAgeVerifyView m_View;

	[Token(Token = "0x400E2E6")]
	[FieldOffset(Offset = "0x4C")]
	public Action m_Callback;

	[Token(Token = "0x400E2E7")]
	[FieldOffset(Offset = "0x50")]
	private UIModelUser m_UserModel;

	[Token(Token = "0x400E2E8")]
	[FieldOffset(Offset = "0x54")]
	private UIModelAntiAddiction m_AntiAddictionModel;

	[Token(Token = "0x400E2E9")]
	[FieldOffset(Offset = "0x0")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600D148")]
	[Address(RVA = "0x1F30D84", Offset = "0x1F30D84", VA = "0x1F30D84")]
	public UIAgeVerifyController()
	{
	}

	[Token(Token = "0x600D149")]
	[Address(RVA = "0x1F30D8C", Offset = "0x1F30D8C", VA = "0x1F30D8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D14A")]
	[Address(RVA = "0x1F30E30", Offset = "0x1F30E30", VA = "0x1F30E30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D14B")]
	[Address(RVA = "0x1F3128C", Offset = "0x1F3128C", VA = "0x1F3128C")]
	private void InitAddictUIView()
	{
	}

	[Token(Token = "0x600D14C")]
	[Address(RVA = "0x1F3138C", Offset = "0x1F3138C", VA = "0x1F3138C")]
	public void ShowAgeGroup(bool isChildrenAgeGroup = false)
	{
	}

	[Token(Token = "0x600D14D")]
	[Address(RVA = "0x1F31784", Offset = "0x1F31784", VA = "0x1F31784")]
	private void OnlowAgeClick()
	{
	}

	[Token(Token = "0x600D14E")]
	[Address(RVA = "0x1F31AF8", Offset = "0x1F31AF8", VA = "0x1F31AF8")]
	private void OnMidAgeClick()
	{
	}

	[Token(Token = "0x600D14F")]
	[Address(RVA = "0x1F31B88", Offset = "0x1F31B88", VA = "0x1F31B88")]
	private void OnHighAgeClick()
	{
	}

	[Token(Token = "0x600D150")]
	[Address(RVA = "0x1F31814", Offset = "0x1F31814", VA = "0x1F31814")]
	private void SendSetAgeStateReq()
	{
	}

	[Token(Token = "0x600D151")]
	[Address(RVA = "0x1F31C18", Offset = "0x1F31C18", VA = "0x1F31C18", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D152")]
	[Address(RVA = "0x1F31CC8", Offset = "0x1F31CC8", VA = "0x1F31CC8")]
	private void OnSkipClick()
	{
	}

	[Token(Token = "0x600D153")]
	[Address(RVA = "0x1F31D50", Offset = "0x1F31D50", VA = "0x1F31D50")]
	private static void _003CSendSetAgeStateReq_003Em__0(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x600D154")]
	[Address(RVA = "0x1F31D54", Offset = "0x1F31D54", VA = "0x1F31D54")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D155")]
	[Address(RVA = "0x1F31D5C", Offset = "0x1F31D5C", VA = "0x1F31D5C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
