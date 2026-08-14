using System;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002BDD")]
internal class UIVeteranGuideLobbyEnterWndController : UIPopupWindowController
{
	[Token(Token = "0x4010C02")]
	[FieldOffset(Offset = "0x48")]
	private UIVeteranGuideLobbyEnterWndView m_View;

	[Token(Token = "0x4010C03")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x601229E")]
	[Address(RVA = "0x28506D4", Offset = "0x28506D4", VA = "0x28506D4")]
	public UIVeteranGuideLobbyEnterWndController()
	{
	}

	[Token(Token = "0x601229F")]
	[Address(RVA = "0x28506DC", Offset = "0x28506DC", VA = "0x28506DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60122A0")]
	[Address(RVA = "0x2850780", Offset = "0x2850780", VA = "0x2850780", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60122A1")]
	[Address(RVA = "0x2850944", Offset = "0x2850944", VA = "0x2850944")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x60122A2")]
	[Address(RVA = "0x2850C28", Offset = "0x2850C28", VA = "0x2850C28")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x60122A3")]
	[Address(RVA = "0x2850F28", Offset = "0x2850F28", VA = "0x2850F28")]
	private void OnGotoBtnClick()
	{
	}

	[Token(Token = "0x60122A4")]
	[Address(RVA = "0x285127C", Offset = "0x285127C", VA = "0x285127C")]
	private static bool _003CSetViewData_003Em__0(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x60122A5")]
	[Address(RVA = "0x28512A8", Offset = "0x28512A8", VA = "0x28512A8")]
	private void _003COnGotoBtnClick_003Em__1()
	{
	}

	[Token(Token = "0x60122A6")]
	[Address(RVA = "0x2851350", Offset = "0x2851350", VA = "0x2851350")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
