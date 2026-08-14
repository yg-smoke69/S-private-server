using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A75")]
public class UIPopupMessageBox2Controller : UIPopupWindowController
{
	[Token(Token = "0x2002A76")]
	public enum EButtonStyle
	{
		[Token(Token = "0x40104CD")]
		None,
		[Token(Token = "0x40104CE")]
		OKOnly,
		[Token(Token = "0x40104CF")]
		OKCancel,
		[Token(Token = "0x40104D0")]
		OKClose
	}

	[Token(Token = "0x2002A77")]
	public enum EStandardMessageBoxType
	{
		[Token(Token = "0x40104D2")]
		Info,
		[Token(Token = "0x40104D3")]
		Suggestion,
		[Token(Token = "0x40104D4")]
		Warning,
		[Token(Token = "0x40104D5")]
		Error,
		[Token(Token = "0x40104D6")]
		Hint
	}

	[Token(Token = "0x2002A78")]
	public class MessageBoxInfo
	{
		[Token(Token = "0x40104D7")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x40104D8")]
		[FieldOffset(Offset = "0xC")]
		public string Info;

		[Token(Token = "0x40104D9")]
		[FieldOffset(Offset = "0x10")]
		public string OKText;

		[Token(Token = "0x40104DA")]
		[FieldOffset(Offset = "0x14")]
		public string CancelText;

		[Token(Token = "0x40104DB")]
		[FieldOffset(Offset = "0x18")]
		public EButtonStyle ButtonStyle;

		[Token(Token = "0x40104DC")]
		[FieldOffset(Offset = "0x1C")]
		public Action OnOK;

		[Token(Token = "0x40104DD")]
		[FieldOffset(Offset = "0x20")]
		public Action OnCancel;

		[Token(Token = "0x40104DE")]
		[FieldOffset(Offset = "0x24")]
		public bool NoCloseButton;

		[Token(Token = "0x40104DF")]
		[FieldOffset(Offset = "0x28")]
		public string note;

		[Token(Token = "0x6011496")]
		[Address(RVA = "0x2C65B30", Offset = "0x2C65B30", VA = "0x2C65B30")]
		public MessageBoxInfo()
		{
		}
	}

	[Token(Token = "0x40104C7")]
	[FieldOffset(Offset = "0x48")]
	private UIPopupMessageBoxView m_View;

	[Token(Token = "0x40104C8")]
	[FieldOffset(Offset = "0x4C")]
	protected EButtonStyle m_ButtonStyle;

	[Token(Token = "0x40104C9")]
	[FieldOffset(Offset = "0x50")]
	protected bool m_NoCloseButton;

	[Token(Token = "0x40104CA")]
	[FieldOffset(Offset = "0x54")]
	protected Action m_OnOK;

	[Token(Token = "0x40104CB")]
	[FieldOffset(Offset = "0x58")]
	protected Action m_OnCancel;

	[Token(Token = "0x6011485")]
	[Address(RVA = "0x2C63EC8", Offset = "0x2C63EC8", VA = "0x2C63EC8")]
	public UIPopupMessageBox2Controller()
	{
	}

	[Token(Token = "0x6011486")]
	[Address(RVA = "0x2C63ED0", Offset = "0x2C63ED0", VA = "0x2C63ED0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011487")]
	[Address(RVA = "0x2C63F74", Offset = "0x2C63F74", VA = "0x2C63F74", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x6011488")]
	[Address(RVA = "0x2C63FE4", Offset = "0x2C63FE4", VA = "0x2C63FE4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011489")]
	[Address(RVA = "0x2C64228", Offset = "0x2C64228", VA = "0x2C64228", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601148A")]
	[Address(RVA = "0x2C64298", Offset = "0x2C64298", VA = "0x2C64298")]
	public void ShowStandardMessageBox(string info, EStandardMessageBoxType mbType, [Optional] Action onOK, [Optional] Action onCancel, EButtonStyle buttonStyle = EButtonStyle.OKOnly, bool isColorfulInfo = false, string note = "")
	{
	}

	[Token(Token = "0x601148B")]
	[Address(RVA = "0x2C64F50", Offset = "0x2C64F50", VA = "0x2C64F50")]
	public void ShowMessageBox(string title, string info, EButtonStyle buttonStyle = EButtonStyle.OKCancel, [Optional] Action onOK, [Optional] Action onCancel, bool isColorfulInfo = false)
	{
	}

	[Token(Token = "0x601148C")]
	[Address(RVA = "0x2C6534C", Offset = "0x2C6534C", VA = "0x2C6534C")]
	public void ShowMessageBox(MessageBoxInfo info)
	{
	}

	[Token(Token = "0x601148D")]
	[Address(RVA = "0x2C65758", Offset = "0x2C65758", VA = "0x2C65758")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x601148E")]
	[Address(RVA = "0x2C657EC", Offset = "0x2C657EC", VA = "0x2C657EC")]
	protected void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x601148F")]
	[Address(RVA = "0x2C64B00", Offset = "0x2C64B00", VA = "0x2C64B00")]
	protected void UpdateView()
	{
	}

	[Token(Token = "0x6011490")]
	[Address(RVA = "0x2C65880", Offset = "0x2C65880", VA = "0x2C65880")]
	public void SetPopupMessageInfo(string message)
	{
	}

	[Token(Token = "0x6011491")]
	[Address(RVA = "0x2C6594C", Offset = "0x2C6594C", VA = "0x2C6594C", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6011492")]
	[Address(RVA = "0x2C65B10", Offset = "0x2C65B10", VA = "0x2C65B10")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x6011493")]
	[Address(RVA = "0x2C65B18", Offset = "0x2C65B18", VA = "0x2C65B18")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011494")]
	[Address(RVA = "0x2C65B20", Offset = "0x2C65B20", VA = "0x2C65B20")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011495")]
	[Address(RVA = "0x2C65B28", Offset = "0x2C65B28", VA = "0x2C65B28")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
