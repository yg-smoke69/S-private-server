using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B0E")]
public class UISecondConfirmContoller : UIPopupWindowController
{
	[Token(Token = "0x2002B0F")]
	public enum Style
	{
		[Token(Token = "0x4010836")]
		IconGoods,
		[Token(Token = "0x4010837")]
		TextGoods,
		[Token(Token = "0x4010838")]
		OneText,
		[Token(Token = "0x4010839")]
		CheckBoxText
	}

	[Token(Token = "0x401082D")]
	[FieldOffset(Offset = "0x48")]
	private UISecondConfirmView m_View;

	[Token(Token = "0x401082E")]
	[FieldOffset(Offset = "0x4C")]
	private List<BaseItemInfo> m_Items;

	[Token(Token = "0x401082F")]
	[FieldOffset(Offset = "0x50")]
	private string m_OneText;

	[Token(Token = "0x4010830")]
	[FieldOffset(Offset = "0x54")]
	private string m_CheckBoxText;

	[Token(Token = "0x4010831")]
	[FieldOffset(Offset = "0x58")]
	private bool m_ForceFullScreen;

	[Token(Token = "0x4010832")]
	[FieldOffset(Offset = "0x5C")]
	private Action m_ConfirmAction;

	[Token(Token = "0x4010833")]
	[FieldOffset(Offset = "0x60")]
	private Action m_CancelAction;

	[Token(Token = "0x4010834")]
	[FieldOffset(Offset = "0x64")]
	private Action<bool> m_CheckBoxSelectedAction;

	[Token(Token = "0x6011B01")]
	[Address(RVA = "0x1A4D604", Offset = "0x1A4D604", VA = "0x1A4D604")]
	public UISecondConfirmContoller()
	{
	}

	[Token(Token = "0x6011B02")]
	[Address(RVA = "0x1A4D60C", Offset = "0x1A4D60C", VA = "0x1A4D60C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B03")]
	[Address(RVA = "0x1A4D6B0", Offset = "0x1A4D6B0", VA = "0x1A4D6B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B04")]
	[Address(RVA = "0x1A4D96C", Offset = "0x1A4D96C", VA = "0x1A4D96C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011B05")]
	[Address(RVA = "0x1A4DAA0", Offset = "0x1A4DAA0", VA = "0x1A4DAA0")]
	private void OnAssetRefresh(object[] param)
	{
	}

	[Token(Token = "0x6011B06")]
	[Address(RVA = "0x1A4DB0C", Offset = "0x1A4DB0C", VA = "0x1A4DB0C")]
	protected void OnCancelClick()
	{
	}

	[Token(Token = "0x6011B07")]
	[Address(RVA = "0x1A4DB84", Offset = "0x1A4DB84", VA = "0x1A4DB84")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6011B08")]
	[Address(RVA = "0x1A4DC1C", Offset = "0x1A4DC1C", VA = "0x1A4DC1C")]
	private void OnCheckBoxClick()
	{
	}

	[Token(Token = "0x6011B09")]
	[Address(RVA = "0x1A4DD0C", Offset = "0x1A4DD0C", VA = "0x1A4DD0C")]
	public void SetData(Style style, [Optional] List<BaseItemInfo> goods, string oneText = "", string CheckBoxText = "", bool autoCheck = false, bool forceFullScreen = false)
	{
	}

	[Token(Token = "0x6011B0A")]
	[Address(RVA = "0x1A4DEFC", Offset = "0x1A4DEFC", VA = "0x1A4DEFC")]
	private void CreateIconGoodss()
	{
	}

	[Token(Token = "0x6011B0B")]
	[Address(RVA = "0x1A4E1EC", Offset = "0x1A4E1EC", VA = "0x1A4E1EC")]
	private void CreateTextGoods()
	{
	}

	[Token(Token = "0x6011B0C")]
	[Address(RVA = "0x1A4E758", Offset = "0x1A4E758", VA = "0x1A4E758")]
	private void CreateOneText()
	{
	}

	[Token(Token = "0x6011B0D")]
	[Address(RVA = "0x1A4E824", Offset = "0x1A4E824", VA = "0x1A4E824")]
	private void CreateCheckBoxText(bool autoCheck = false)
	{
	}

	[Token(Token = "0x6011B0E")]
	[Address(RVA = "0x1A4E9D0", Offset = "0x1A4E9D0", VA = "0x1A4E9D0")]
	public void SetOneTextAlignment(Alignment alignment)
	{
	}

	[Token(Token = "0x6011B0F")]
	[Address(RVA = "0x1A4EA68", Offset = "0x1A4EA68", VA = "0x1A4EA68")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x6011B10")]
	[Address(RVA = "0x1A4EAEC", Offset = "0x1A4EAEC", VA = "0x1A4EAEC")]
	public void SetConfirmBtnText(string text)
	{
	}

	[Token(Token = "0x6011B11")]
	[Address(RVA = "0x1A4EB84", Offset = "0x1A4EB84", VA = "0x1A4EB84")]
	public void SetConfirmText(string text)
	{
	}

	[Token(Token = "0x6011B12")]
	[Address(RVA = "0x1A4EC1C", Offset = "0x1A4EC1C", VA = "0x1A4EC1C")]
	public void ShowCancelButton()
	{
	}

	[Token(Token = "0x6011B13")]
	[Address(RVA = "0x1A4ECCC", Offset = "0x1A4ECCC", VA = "0x1A4ECCC")]
	public void SetConfirmCallback(Action action)
	{
	}

	[Token(Token = "0x6011B14")]
	[Address(RVA = "0x1A4ED2C", Offset = "0x1A4ED2C", VA = "0x1A4ED2C")]
	public void SetCancelCallback(Action action)
	{
	}

	[Token(Token = "0x6011B15")]
	[Address(RVA = "0x1A4ED8C", Offset = "0x1A4ED8C", VA = "0x1A4ED8C")]
	public void SetCloseCallback(Callback action)
	{
	}

	[Token(Token = "0x6011B16")]
	[Address(RVA = "0x1A4EEA4", Offset = "0x1A4EEA4", VA = "0x1A4EEA4")]
	public void SetCheckboxCallback(Action<bool> action)
	{
	}

	[Token(Token = "0x6011B17")]
	[Address(RVA = "0x1A4EF04", Offset = "0x1A4EF04", VA = "0x1A4EF04", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x6011B18")]
	[Address(RVA = "0x1A4F064", Offset = "0x1A4F064", VA = "0x1A4F064")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011B19")]
	[Address(RVA = "0x1A4F06C", Offset = "0x1A4F06C", VA = "0x1A4F06C")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011B1A")]
	[Address(RVA = "0x1A4F074", Offset = "0x1A4F074", VA = "0x1A4F074")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}
}
