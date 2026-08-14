using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002C1C")]
internal class UIWeaponUpgradeTokenExchangeController : UIPopupWindowController
{
	[Token(Token = "0x4010D6D")]
	[FieldOffset(Offset = "0x48")]
	private UIWeaponUpgradeTokenExchangeView m_View;

	[Token(Token = "0x4010D6E")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_ConfirmAction;

	[Token(Token = "0x4010D6F")]
	[FieldOffset(Offset = "0x50")]
	private Action m_CloseAction;

	[Token(Token = "0x601259A")]
	[Address(RVA = "0x1B7C098", Offset = "0x1B7C098", VA = "0x1B7C098")]
	public UIWeaponUpgradeTokenExchangeController()
	{
	}

	[Token(Token = "0x601259B")]
	[Address(RVA = "0x1B7C0A0", Offset = "0x1B7C0A0", VA = "0x1B7C0A0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601259C")]
	[Address(RVA = "0x1B7C148", Offset = "0x1B7C148", VA = "0x1B7C148", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601259D")]
	[Address(RVA = "0x1B7C2A4", Offset = "0x1B7C2A4", VA = "0x1B7C2A4", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x601259E")]
	[Address(RVA = "0x1B7C308", Offset = "0x1B7C308", VA = "0x1B7C308", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601259F")]
	[Address(RVA = "0x1B7C380", Offset = "0x1B7C380", VA = "0x1B7C380", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x60125A0")]
	[Address(RVA = "0x1B7C3E4", Offset = "0x1B7C3E4", VA = "0x1B7C3E4")]
	public void SetViewData(List<BaseItemInfo> beforeItems, List<BaseItemInfo> afterItems)
	{
	}

	[Token(Token = "0x60125A1")]
	[Address(RVA = "0x1B7C7D8", Offset = "0x1B7C7D8", VA = "0x1B7C7D8")]
	private void OnConversionBtnClick()
	{
	}

	[Token(Token = "0x60125A2")]
	[Address(RVA = "0x1B7C850", Offset = "0x1B7C850", VA = "0x1B7C850")]
	public void SetConfirmCallback(Action action)
	{
	}

	[Token(Token = "0x60125A3")]
	[Address(RVA = "0x1B7C8B0", Offset = "0x1B7C8B0", VA = "0x1B7C8B0")]
	public void SetCloseCallback(Action action)
	{
	}

	[Token(Token = "0x60125A4")]
	[Address(RVA = "0x1B7C910", Offset = "0x1B7C910", VA = "0x1B7C910")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60125A5")]
	[Address(RVA = "0x1B7C918", Offset = "0x1B7C918", VA = "0x1B7C918")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x60125A6")]
	[Address(RVA = "0x1B7C920", Offset = "0x1B7C920", VA = "0x1B7C920")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60125A7")]
	[Address(RVA = "0x1B7C928", Offset = "0x1B7C928", VA = "0x1B7C928")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
