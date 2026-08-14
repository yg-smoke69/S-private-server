using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B22")]
public class UISmallCommonTinyMsgBoxController : UIPopupWindowController
{
	[Token(Token = "0x2002B23")]
	public enum EUIStyle
	{
		[Token(Token = "0x40108A2")]
		EUIStyleNormal,
		[Token(Token = "0x40108A3")]
		EUIStyleTips,
		[Token(Token = "0x40108A4")]
		EUIStyleIcon
	}

	[Token(Token = "0x2002B24")]
	public class Config
	{
		[Token(Token = "0x40108A5")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x40108A6")]
		[FieldOffset(Offset = "0xC")]
		public string Content;

		[Token(Token = "0x40108A7")]
		[FieldOffset(Offset = "0x10")]
		public string OKTxt;

		[Token(Token = "0x40108A8")]
		[FieldOffset(Offset = "0x14")]
		public string CancelTxt;

		[Token(Token = "0x40108A9")]
		[FieldOffset(Offset = "0x18")]
		public string TipsTxt;

		[Token(Token = "0x40108AA")]
		[FieldOffset(Offset = "0x1C")]
		public ResourceID iconRes;

		[Token(Token = "0x40108AB")]
		[FieldOffset(Offset = "0x20")]
		public Action OnOk;

		[Token(Token = "0x40108AC")]
		[FieldOffset(Offset = "0x24")]
		public Action OnCancel;

		[Token(Token = "0x40108AD")]
		[FieldOffset(Offset = "0x28")]
		public Action OnClose;

		[Token(Token = "0x40108AE")]
		[FieldOffset(Offset = "0x2C")]
		public EUIStyle Style;

		[Token(Token = "0x6011BD6")]
		[Address(RVA = "0x2058F7C", Offset = "0x2058F7C", VA = "0x2058F7C")]
		public Config()
		{
		}
	}

	[Token(Token = "0x401089D")]
	[FieldOffset(Offset = "0x48")]
	private UISmallCommonTinyMsgBoxView m_View;

	[Token(Token = "0x401089E")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_OnOK;

	[Token(Token = "0x401089F")]
	[FieldOffset(Offset = "0x50")]
	private Action m_OnCancel;

	[Token(Token = "0x40108A0")]
	[FieldOffset(Offset = "0x54")]
	private Action m_OnClose;

	[Token(Token = "0x6011BCC")]
	[Address(RVA = "0x2058280", Offset = "0x2058280", VA = "0x2058280")]
	public UISmallCommonTinyMsgBoxController()
	{
	}

	[Token(Token = "0x6011BCD")]
	[Address(RVA = "0x2058288", Offset = "0x2058288", VA = "0x2058288")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011BCE")]
	[Address(RVA = "0x205832C", Offset = "0x205832C", VA = "0x205832C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011BCF")]
	[Address(RVA = "0x20584FC", Offset = "0x20584FC", VA = "0x20584FC", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011BD0")]
	[Address(RVA = "0x2058584", Offset = "0x2058584", VA = "0x2058584")]
	public void SetUIData(Config config)
	{
	}

	[Token(Token = "0x6011BD1")]
	[Address(RVA = "0x2058838", Offset = "0x2058838", VA = "0x2058838")]
	private void SetUIStyle(EUIStyle style)
	{
	}

	[Token(Token = "0x6011BD2")]
	[Address(RVA = "0x2058E7C", Offset = "0x2058E7C", VA = "0x2058E7C")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x6011BD3")]
	[Address(RVA = "0x2058EF4", Offset = "0x2058EF4", VA = "0x2058EF4")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x6011BD4")]
	[Address(RVA = "0x2058F6C", Offset = "0x2058F6C", VA = "0x2058F6C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011BD5")]
	[Address(RVA = "0x2058F74", Offset = "0x2058F74", VA = "0x2058F74")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
