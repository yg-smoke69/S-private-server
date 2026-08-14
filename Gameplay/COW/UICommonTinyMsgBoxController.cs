using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025A5")]
public class UICommonTinyMsgBoxController : UIPopupWindowController
{
	[Token(Token = "0x20025A6")]
	public enum EUIStyle
	{
		[Token(Token = "0x400E8D1")]
		EUIStyleNormal,
		[Token(Token = "0x400E8D2")]
		EUIStyleTips,
		[Token(Token = "0x400E8D3")]
		EUIStyleIcon
	}

	[Token(Token = "0x20025A7")]
	public class Config
	{
		[Token(Token = "0x400E8D4")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x400E8D5")]
		[FieldOffset(Offset = "0xC")]
		public string Content;

		[Token(Token = "0x400E8D6")]
		[FieldOffset(Offset = "0x10")]
		public string OKTxt;

		[Token(Token = "0x400E8D7")]
		[FieldOffset(Offset = "0x14")]
		public string CancelTxt;

		[Token(Token = "0x400E8D8")]
		[FieldOffset(Offset = "0x18")]
		public string TipsTxt;

		[Token(Token = "0x400E8D9")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID iconRes;

		[Token(Token = "0x400E8DA")]
		[FieldOffset(Offset = "0x20")]
		public Action OnOk;

		[Token(Token = "0x400E8DB")]
		[FieldOffset(Offset = "0x24")]
		public Action OnCancel;

		[Token(Token = "0x400E8DC")]
		[FieldOffset(Offset = "0x28")]
		public Action OnClose;

		[Token(Token = "0x400E8DD")]
		[FieldOffset(Offset = "0x2C")]
		public EUIStyle Style;

		[Token(Token = "0x600DC5C")]
		[Address(RVA = "0x1EBB1B0", Offset = "0x1EBB1B0", VA = "0x1EBB1B0")]
		public Config()
		{
		}
	}

	[Token(Token = "0x400E8CC")]
	[FieldOffset(Offset = "0x48")]
	private UICommonTinyMsgBoxView m_View;

	[Token(Token = "0x400E8CD")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_OnOK;

	[Token(Token = "0x400E8CE")]
	[FieldOffset(Offset = "0x50")]
	private Action m_OnCancel;

	[Token(Token = "0x400E8CF")]
	[FieldOffset(Offset = "0x54")]
	private Action m_OnClose;

	[Token(Token = "0x600DC50")]
	[Address(RVA = "0x1EB9EA8", Offset = "0x1EB9EA8", VA = "0x1EB9EA8")]
	public UICommonTinyMsgBoxController()
	{
	}

	[Token(Token = "0x600DC51")]
	[Address(RVA = "0x1EB9EB0", Offset = "0x1EB9EB0", VA = "0x1EB9EB0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC52")]
	[Address(RVA = "0x1EB9F54", Offset = "0x1EB9F54", VA = "0x1EB9F54", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC53")]
	[Address(RVA = "0x1EBA2A0", Offset = "0x1EBA2A0", VA = "0x1EBA2A0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600DC54")]
	[Address(RVA = "0x1EBA3F8", Offset = "0x1EBA3F8", VA = "0x1EBA3F8")]
	public void SetUIData(Config config)
	{
	}

	[Token(Token = "0x600DC55")]
	[Address(RVA = "0x1EBADFC", Offset = "0x1EBADFC", VA = "0x1EBADFC")]
	public void ShowTipIcon()
	{
	}

	[Token(Token = "0x600DC56")]
	[Address(RVA = "0x1EBA7B8", Offset = "0x1EBA7B8", VA = "0x1EBA7B8")]
	private void SetUIStyle(EUIStyle style)
	{
	}

	[Token(Token = "0x600DC57")]
	[Address(RVA = "0x1EBAFB0", Offset = "0x1EBAFB0", VA = "0x1EBAFB0")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x600DC58")]
	[Address(RVA = "0x1EBB028", Offset = "0x1EBB028", VA = "0x1EBB028")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x600DC59")]
	[Address(RVA = "0x1EBB0A0", Offset = "0x1EBB0A0", VA = "0x1EBB0A0")]
	public void OnPauseCheck(object[] data)
	{
	}

	[Token(Token = "0x600DC5A")]
	[Address(RVA = "0x1EBB1A0", Offset = "0x1EBB1A0", VA = "0x1EBB1A0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC5B")]
	[Address(RVA = "0x1EBB1A8", Offset = "0x1EBB1A8", VA = "0x1EBB1A8")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
