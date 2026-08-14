using System;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002490")]
public class UIAccountDelPopupController : UIPopupSpecialWindowController
{
	[Token(Token = "0x2002491")]
	public delegate bool InputStyleOnOk(string str);

	[Token(Token = "0x2002492")]
	public enum UIStyle
	{
		[Token(Token = "0x400E2B4")]
		EStyleNormal,
		[Token(Token = "0x400E2B5")]
		EStyleCheckBox,
		[Token(Token = "0x400E2B6")]
		EStyleInput
	}

	[Token(Token = "0x2002493")]
	public class Config
	{
		[Token(Token = "0x400E2B7")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x400E2B8")]
		[FieldOffset(Offset = "0xC")]
		public string Content;

		[Token(Token = "0x400E2B9")]
		[FieldOffset(Offset = "0x10")]
		public string Tips;

		[Token(Token = "0x400E2BA")]
		[FieldOffset(Offset = "0x14")]
		public string OKTxt;

		[Token(Token = "0x400E2BB")]
		[FieldOffset(Offset = "0x18")]
		public string CancelTxt;

		[Token(Token = "0x400E2BC")]
		[FieldOffset(Offset = "0x1C")]
		public Action OnOk;

		[Token(Token = "0x400E2BD")]
		[FieldOffset(Offset = "0x20")]
		public Action OnCancel;

		[Token(Token = "0x400E2BE")]
		[FieldOffset(Offset = "0x24")]
		public InputStyleOnOk InputStyleOnOk;

		[Token(Token = "0x400E2BF")]
		[FieldOffset(Offset = "0x28")]
		public bool InitChecked;

		[Token(Token = "0x400E2C0")]
		[FieldOffset(Offset = "0x29")]
		public bool HideURL;

		[Token(Token = "0x400E2C1")]
		[FieldOffset(Offset = "0x2C")]
		public UIStyle Style;

		[Token(Token = "0x600D0F3")]
		[Address(RVA = "0x29FD414", Offset = "0x29FD414", VA = "0x29FD414")]
		public Config()
		{
		}
	}

	[Token(Token = "0x400E2AD")]
	private const string URL = "https://www.garena.sg/privacy";

	[Token(Token = "0x400E2AE")]
	[FieldOffset(Offset = "0x48")]
	private UIAccountDelPopupView m_View;

	[Token(Token = "0x400E2AF")]
	[FieldOffset(Offset = "0x4C")]
	private Action m_OnOK;

	[Token(Token = "0x400E2B0")]
	[FieldOffset(Offset = "0x50")]
	private Action m_OnCancel;

	[Token(Token = "0x400E2B1")]
	[FieldOffset(Offset = "0x54")]
	private InputStyleOnOk m_InputStyleOnOk;

	[Token(Token = "0x400E2B2")]
	[FieldOffset(Offset = "0x58")]
	private UIStyle m_Style;

	[Token(Token = "0x600D0E2")]
	[Address(RVA = "0x29FC3D0", Offset = "0x29FC3D0", VA = "0x29FC3D0")]
	public UIAccountDelPopupController()
	{
	}

	[Token(Token = "0x600D0E3")]
	[Address(RVA = "0x29FC3D8", Offset = "0x29FC3D8", VA = "0x29FC3D8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D0E4")]
	[Address(RVA = "0x29FC47C", Offset = "0x29FC47C", VA = "0x29FC47C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D0E5")]
	[Address(RVA = "0x29FC778", Offset = "0x29FC778", VA = "0x29FC778", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600D0E6")]
	[Address(RVA = "0x29FC7E8", Offset = "0x29FC7E8", VA = "0x29FC7E8")]
	public void SetUIData(Config config)
	{
	}

	[Token(Token = "0x600D0E7")]
	[Address(RVA = "0x29FCC14", Offset = "0x29FCC14", VA = "0x29FCC14")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x600D0E8")]
	[Address(RVA = "0x29FD0D4", Offset = "0x29FD0D4", VA = "0x29FD0D4")]
	private void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x600D0E9")]
	[Address(RVA = "0x29FD14C", Offset = "0x29FD14C", VA = "0x29FD14C")]
	private void OnCheckChanged()
	{
	}

	[Token(Token = "0x600D0EA")]
	[Address(RVA = "0x29FD298", Offset = "0x29FD298", VA = "0x29FD298")]
	private void OnURLClick()
	{
	}

	[Token(Token = "0x600D0EB")]
	[Address(RVA = "0x29FD378", Offset = "0x29FD378", VA = "0x29FD378", Slot = "46")]
	public override void OnBackButtonClick()
	{
	}

	[Token(Token = "0x600D0EC")]
	[Address(RVA = "0x29FD3FC", Offset = "0x29FD3FC", VA = "0x29FD3FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D0ED")]
	[Address(RVA = "0x29FD404", Offset = "0x29FD404", VA = "0x29FD404")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600D0EE")]
	[Address(RVA = "0x29FD40C", Offset = "0x29FD40C", VA = "0x29FD40C")]
	public void _003C_003EiFixBaseProxy_OnBackButtonClick()
	{
	}
}
