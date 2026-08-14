using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002578")]
internal class UICommonCodeInputWindowController : UIPopupWindowController
{
	[Token(Token = "0x400E7D9")]
	[FieldOffset(Offset = "0x48")]
	private UICommonCodeInputWindowView m_View;

	[Token(Token = "0x400E7DA")]
	[FieldOffset(Offset = "0x4C")]
	private CodeInputPopupData m_Data;

	[Token(Token = "0x400E7DB")]
	[FieldOffset(Offset = "0x50")]
	private List<string> m_CodeList;

	[Token(Token = "0x400E7DC")]
	[FieldOffset(Offset = "0x54")]
	private List<UILabel> m_CodeLabels;

	[Token(Token = "0x400E7DD")]
	[FieldOffset(Offset = "0x58")]
	private List<UIToggleButton> m_ToggleList;

	[Token(Token = "0x400E7DE")]
	[FieldOffset(Offset = "0x5C")]
	private List<GameObject> m_Items;

	[Token(Token = "0x400E7DF")]
	[FieldOffset(Offset = "0x60")]
	private Color m_TextColor;

	[Token(Token = "0x600DB09")]
	[Address(RVA = "0x2CDA850", Offset = "0x2CDA850", VA = "0x2CDA850")]
	public UICommonCodeInputWindowController()
	{
	}

	[Token(Token = "0x600DB0A")]
	[Address(RVA = "0x2CDA978", Offset = "0x2CDA978", VA = "0x2CDA978")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DB0B")]
	[Address(RVA = "0x2CDAA20", Offset = "0x2CDAA20", VA = "0x2CDAA20", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DB0C")]
	[Address(RVA = "0x2CDAC0C", Offset = "0x2CDAC0C", VA = "0x2CDAC0C")]
	public void SetUIData(CodeInputPopupData data)
	{
	}

	[Token(Token = "0x600DB0D")]
	[Address(RVA = "0x2CDC290", Offset = "0x2CDC290", VA = "0x2CDC290")]
	public void OnToggleClick(object data)
	{
	}

	[Token(Token = "0x600DB0E")]
	[Address(RVA = "0x2CDBCAC", Offset = "0x2CDBCAC", VA = "0x2CDBCAC")]
	private void SetToggleColor(int idx, bool colorHight = true)
	{
	}

	[Token(Token = "0x600DB0F")]
	[Address(RVA = "0x2CDBE84", Offset = "0x2CDBE84", VA = "0x2CDBE84")]
	private void ShowCursorAtIndex(int idx)
	{
	}

	[Token(Token = "0x600DB10")]
	[Address(RVA = "0x2CDCDA4", Offset = "0x2CDCDA4", VA = "0x2CDCDA4")]
	private void ShowTextAtIndex(int idx, string text)
	{
	}

	[Token(Token = "0x600DB11")]
	[Address(RVA = "0x2CDC0FC", Offset = "0x2CDC0FC", VA = "0x2CDC0FC")]
	private void SetCodePasteBtnState()
	{
	}

	[Token(Token = "0x600DB12")]
	[Address(RVA = "0x2CDD258", Offset = "0x2CDD258", VA = "0x2CDD258")]
	private void OnCodePasteBtnClick()
	{
	}

	[Token(Token = "0x600DB13")]
	[Address(RVA = "0x2CDD82C", Offset = "0x2CDD82C", VA = "0x2CDD82C")]
	private bool IsNumber(string str)
	{
		return default(bool);
	}

	[Token(Token = "0x600DB14")]
	[Address(RVA = "0x2CDD90C", Offset = "0x2CDD90C", VA = "0x2CDD90C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
