using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B10")]
public class UISecondConfirmSmallContoller : UIPopupWindowController
{
	[Token(Token = "0x401083A")]
	[FieldOffset(Offset = "0x48")]
	private UISecondConfirmSmallView m_View;

	[Token(Token = "0x401083B")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_ConfirmAction;

	[Token(Token = "0x401083C")]
	[FieldOffset(Offset = "0x50")]
	private Action m_CancelAction;

	[Token(Token = "0x401083D")]
	[FieldOffset(Offset = "0x54")]
	private bool m_IgnoreESC;

	[Token(Token = "0x401083E")]
	[FieldOffset(Offset = "0x55")]
	private bool m_ConfirmNoClose;

	[Token(Token = "0x6011B1B")]
	[Address(RVA = "0x1A4F07C", Offset = "0x1A4F07C", VA = "0x1A4F07C")]
	public UISecondConfirmSmallContoller()
	{
	}

	[Token(Token = "0x6011B1C")]
	[Address(RVA = "0x1A4F084", Offset = "0x1A4F084", VA = "0x1A4F084")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B1D")]
	[Address(RVA = "0x1A4F128", Offset = "0x1A4F128", VA = "0x1A4F128", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B1E")]
	[Address(RVA = "0x1A4F350", Offset = "0x1A4F350", VA = "0x1A4F350")]
	protected void OnCancelClick()
	{
	}

	[Token(Token = "0x6011B1F")]
	[Address(RVA = "0x1A4F3C8", Offset = "0x1A4F3C8", VA = "0x1A4F3C8")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6011B20")]
	[Address(RVA = "0x1A4F44C", Offset = "0x1A4F44C", VA = "0x1A4F44C")]
	public void SetData(string text = "")
	{
	}

	[Token(Token = "0x6011B21")]
	[Address(RVA = "0x1A4F4E4", Offset = "0x1A4F4E4", VA = "0x1A4F4E4")]
	public void SetData(string text, List<ResourceID> iconResList)
	{
	}

	[Token(Token = "0x6011B22")]
	[Address(RVA = "0x1A4F5F0", Offset = "0x1A4F5F0", VA = "0x1A4F5F0")]
	public void SetOneTextOverflow(Overflow overflow)
	{
	}

	[Token(Token = "0x6011B23")]
	[Address(RVA = "0x1A4F688", Offset = "0x1A4F688", VA = "0x1A4F688")]
	public void SetOneTextAlignment(Alignment alignment)
	{
	}

	[Token(Token = "0x6011B24")]
	[Address(RVA = "0x1A4F720", Offset = "0x1A4F720", VA = "0x1A4F720")]
	public void SetTitle(string title)
	{
	}

	[Token(Token = "0x6011B25")]
	[Address(RVA = "0x1A4F7A4", Offset = "0x1A4F7A4", VA = "0x1A4F7A4")]
	public void SetCloseBtnView(bool isShow)
	{
	}

	[Token(Token = "0x6011B26")]
	[Address(RVA = "0x1A4F828", Offset = "0x1A4F828", VA = "0x1A4F828")]
	public void ShowCancelButton()
	{
	}

	[Token(Token = "0x6011B27")]
	[Address(RVA = "0x1A4F8D8", Offset = "0x1A4F8D8", VA = "0x1A4F8D8")]
	public void SetConfirmView(bool isShow = true)
	{
	}

	[Token(Token = "0x6011B28")]
	[Address(RVA = "0x1A4F990", Offset = "0x1A4F990", VA = "0x1A4F990")]
	public void SetConfirmBtnLabel(string key)
	{
	}

	[Token(Token = "0x6011B29")]
	[Address(RVA = "0x1A4FAEC", Offset = "0x1A4FAEC", VA = "0x1A4FAEC")]
	public void SetCancelBtnLabel(string key)
	{
	}

	[Token(Token = "0x6011B2A")]
	[Address(RVA = "0x1A4FC48", Offset = "0x1A4FC48", VA = "0x1A4FC48")]
	public void SetConfirmCallback(Action action)
	{
	}

	[Token(Token = "0x6011B2B")]
	[Address(RVA = "0x1A4FCA8", Offset = "0x1A4FCA8", VA = "0x1A4FCA8")]
	public void SetCancelCallback(Action action)
	{
	}

	[Token(Token = "0x6011B2C")]
	[Address(RVA = "0x1A4FD08", Offset = "0x1A4FD08", VA = "0x1A4FD08")]
	public void SetIgnoreESC(bool ignoreESC = false)
	{
	}

	[Token(Token = "0x6011B2D")]
	[Address(RVA = "0x1A4FD68", Offset = "0x1A4FD68", VA = "0x1A4FD68")]
	public void SetConfirmNotClose(bool confirmNotClose = false)
	{
	}

	[Token(Token = "0x6011B2E")]
	[Address(RVA = "0x1A4FDC8", Offset = "0x1A4FDC8", VA = "0x1A4FDC8", Slot = "42")]
	public override void EnterByReturn()
	{
	}

	[Token(Token = "0x6011B2F")]
	[Address(RVA = "0x1A4FF28", Offset = "0x1A4FF28", VA = "0x1A4FF28", Slot = "41")]
	public override bool IgnoreEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x6011B30")]
	[Address(RVA = "0x1A4FF80", Offset = "0x1A4FF80", VA = "0x1A4FF80")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011B31")]
	[Address(RVA = "0x1A4FF88", Offset = "0x1A4FF88", VA = "0x1A4FF88")]
	public void _003C_003EiFixBaseProxy_EnterByReturn()
	{
	}

	[Token(Token = "0x6011B32")]
	[Address(RVA = "0x1A4FF90", Offset = "0x1A4FF90", VA = "0x1A4FF90")]
	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return default(bool);
	}
}
