using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A66")]
public class UIPolicyPopupController : UIPopupSpecialWindowController
{
	[Token(Token = "0x2002A67")]
	public class Config
	{
		[Token(Token = "0x4010488")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x4010489")]
		[FieldOffset(Offset = "0xC")]
		public string Content;

		[Token(Token = "0x401048A")]
		[FieldOffset(Offset = "0x10")]
		public string Tips;

		[Token(Token = "0x401048B")]
		[FieldOffset(Offset = "0x14")]
		public string OKTxt;

		[Token(Token = "0x401048C")]
		[FieldOffset(Offset = "0x18")]
		public string CancelTxt;

		[Token(Token = "0x401048D")]
		[FieldOffset(Offset = "0x1C")]
		public Action OnOk;

		[Token(Token = "0x401048E")]
		[FieldOffset(Offset = "0x20")]
		public Action OnCancel;

		[Token(Token = "0x401048F")]
		[FieldOffset(Offset = "0x24")]
		public bool InitChecked;

		[Token(Token = "0x4010490")]
		[FieldOffset(Offset = "0x25")]
		public bool URLHide;

		[Token(Token = "0x6011410")]
		[Address(RVA = "0x2C55B54", Offset = "0x2C55B54", VA = "0x2C55B54")]
		public Config()
		{
		}
	}

	[Token(Token = "0x4010484")]
	private const string URL = "https://www.garena.sg/privacy";

	[Token(Token = "0x4010485")]
	[FieldOffset(Offset = "0x48")]
	private UIPolicyPopupView m_View;

	[Token(Token = "0x4010486")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_OnOK;

	[Token(Token = "0x4010487")]
	[FieldOffset(Offset = "0x50")]
	private Action m_OnCancel;

	[Token(Token = "0x6011402")]
	[Address(RVA = "0x2C54F5C", Offset = "0x2C54F5C", VA = "0x2C54F5C")]
	public UIPolicyPopupController()
	{
	}

	[Token(Token = "0x6011403")]
	[Address(RVA = "0x2C54F64", Offset = "0x2C54F64", VA = "0x2C54F64")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011404")]
	[Address(RVA = "0x2C55008", Offset = "0x2C55008", VA = "0x2C55008", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011405")]
	[Address(RVA = "0x2C55304", Offset = "0x2C55304", VA = "0x2C55304", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011406")]
	[Address(RVA = "0x2C55374", Offset = "0x2C55374", VA = "0x2C55374")]
	public void SetUIData(Config config)
	{
	}

	[Token(Token = "0x6011407")]
	[Address(RVA = "0x2C555C8", Offset = "0x2C555C8", VA = "0x2C555C8")]
	public void SetUIData(string title = "", string content = "", string tips = "", string okTxt = "", string cancelTxt = "", [Optional] Action okCallback, [Optional] Action cancelCallback)
	{
	}

	[Token(Token = "0x6011408")]
	[Address(RVA = "0x2C5578C", Offset = "0x2C5578C", VA = "0x2C5578C")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x6011409")]
	[Address(RVA = "0x2C5580C", Offset = "0x2C5580C", VA = "0x2C5580C")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x601140A")]
	[Address(RVA = "0x2C5588C", Offset = "0x2C5588C", VA = "0x2C5588C")]
	private void OnCheckChanged()
	{
	}

	[Token(Token = "0x601140B")]
	[Address(RVA = "0x2C559D8", Offset = "0x2C559D8", VA = "0x2C559D8")]
	private void OnURLClick()
	{
	}

	[Token(Token = "0x601140C")]
	[Address(RVA = "0x2C55AB8", Offset = "0x2C55AB8", VA = "0x2C55AB8", Slot = "46")]
	public override void OnBackButtonClick()
	{
	}

	[Token(Token = "0x601140D")]
	[Address(RVA = "0x2C55B3C", Offset = "0x2C55B3C", VA = "0x2C55B3C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601140E")]
	[Address(RVA = "0x2C55B44", Offset = "0x2C55B44", VA = "0x2C55B44")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601140F")]
	[Address(RVA = "0x2C55B4C", Offset = "0x2C55B4C", VA = "0x2C55B4C")]
	public void _003C_003EiFixBaseProxy_OnBackButtonClick()
	{
	}
}
