using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2003343")]
public class UIChooseHudStyleController : UIPopupWindowController
{
	[Token(Token = "0x4013882")]
	[FieldOffset(Offset = "0x48")]
	public UIChooseHudStyleView m_View;

	[Token(Token = "0x4013883")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_Callback;

	[Token(Token = "0x6015C6B")]
	[Address(RVA = "0x208DD3C", Offset = "0x208DD3C", VA = "0x208DD3C")]
	public UIChooseHudStyleController()
	{
	}

	[Token(Token = "0x6015C6C")]
	[Address(RVA = "0x208DD44", Offset = "0x208DD44", VA = "0x208DD44")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015C6D")]
	[Address(RVA = "0x208DDE8", Offset = "0x208DDE8", VA = "0x208DDE8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015C6E")]
	[Address(RVA = "0x208DFB8", Offset = "0x208DFB8", VA = "0x208DFB8")]
	private void OnBtnCloseClick()
	{
	}

	[Token(Token = "0x6015C6F")]
	[Address(RVA = "0x208E01C", Offset = "0x208E01C", VA = "0x208E01C")]
	public void SetCallback(Action callback)
	{
	}

	[Token(Token = "0x6015C70")]
	[Address(RVA = "0x208E07C", Offset = "0x208E07C", VA = "0x208E07C")]
	private void OnNewClick()
	{
	}

	[Token(Token = "0x6015C71")]
	[Address(RVA = "0x208E184", Offset = "0x208E184", VA = "0x208E184")]
	private void OnOldClick()
	{
	}

	[Token(Token = "0x6015C72")]
	[Address(RVA = "0x208E28C", Offset = "0x208E28C", VA = "0x208E28C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6015C73")]
	[Address(RVA = "0x208E2F8", Offset = "0x208E2F8", VA = "0x208E2F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6015C74")]
	[Address(RVA = "0x208E300", Offset = "0x208E300", VA = "0x208E300")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
