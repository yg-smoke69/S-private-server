using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002A79")]
public class UIPopupMessageBoxController : UIPopupSpecialWindowController
{
	[Token(Token = "0x2002A7A")]
	public enum EButtonStyle
	{
		[Token(Token = "0x40104ED")]
		None,
		[Token(Token = "0x40104EE")]
		OKOnly,
		[Token(Token = "0x40104EF")]
		OKCancel,
		[Token(Token = "0x40104F0")]
		OKClose
	}

	[Token(Token = "0x2002A7B")]
	public enum EStandardMessageBoxType
	{
		[Token(Token = "0x40104F2")]
		Info,
		[Token(Token = "0x40104F3")]
		Suggestion,
		[Token(Token = "0x40104F4")]
		Warning,
		[Token(Token = "0x40104F5")]
		Error,
		[Token(Token = "0x40104F6")]
		Hint,
		[Token(Token = "0x40104F7")]
		Exception
	}

	[Token(Token = "0x2002A7C")]
	public class MessageBoxInfo
	{
		[Token(Token = "0x40104F8")]
		[FieldOffset(Offset = "0x8")]
		public string Title;

		[Token(Token = "0x40104F9")]
		[FieldOffset(Offset = "0xC")]
		public string Info;

		[Token(Token = "0x40104FA")]
		[FieldOffset(Offset = "0x10")]
		public string OKText;

		[Token(Token = "0x40104FB")]
		[FieldOffset(Offset = "0x14")]
		public string CancelText;

		[Token(Token = "0x40104FC")]
		[FieldOffset(Offset = "0x18")]
		public EButtonStyle ButtonStyle;

		[Token(Token = "0x40104FD")]
		[FieldOffset(Offset = "0x1C")]
		public Action OnOK;

		[Token(Token = "0x40104FE")]
		[FieldOffset(Offset = "0x20")]
		public Action OnCancel;

		[Token(Token = "0x40104FF")]
		[FieldOffset(Offset = "0x24")]
		public Action OnClose;

		[Token(Token = "0x4010500")]
		[FieldOffset(Offset = "0x28")]
		public bool NoCloseButton;

		[Token(Token = "0x4010501")]
		[FieldOffset(Offset = "0x2C")]
		public string note;

		[Token(Token = "0x60114B2")]
		[Address(RVA = "0xEF5D08", Offset = "0xEF5D08", VA = "0xEF5D08")]
		public MessageBoxInfo()
		{
		}
	}

	[Token(Token = "0x40104E0")]
	[FieldOffset(Offset = "0x48")]
	private UIPopupMessageBoxView m_View;

	[Token(Token = "0x40104E1")]
	[FieldOffset(Offset = "0x4C")]
	protected EButtonStyle m_ButtonStyle;

	[Token(Token = "0x40104E2")]
	[FieldOffset(Offset = "0x50")]
	protected bool m_NoCloseButton;

	[Token(Token = "0x40104E3")]
	[FieldOffset(Offset = "0x54")]
	protected Action m_OnOK;

	[Token(Token = "0x40104E4")]
	[FieldOffset(Offset = "0x58")]
	protected Action m_OnCancel;

	[Token(Token = "0x40104E5")]
	[FieldOffset(Offset = "0x5C")]
	protected Action m_OnClose;

	[Token(Token = "0x40104E6")]
	[FieldOffset(Offset = "0x60")]
	private float m_DuraTime;

	[Token(Token = "0x40104E7")]
	[FieldOffset(Offset = "0x64")]
	private bool m_SepicalUpdateButton;

	[Token(Token = "0x40104E8")]
	[FieldOffset(Offset = "0x68")]
	private uint m_LastTime;

	[Token(Token = "0x40104E9")]
	[FieldOffset(Offset = "0x6C")]
	private int m_DelayTime;

	[Token(Token = "0x40104EA")]
	[FieldOffset(Offset = "0x70")]
	private uint m_DelayCallTid;

	[Token(Token = "0x40104EB")]
	[FieldOffset(Offset = "0x74")]
	private string m_OkTextKey;

	[Token(Token = "0x6011497")]
	[Address(RVA = "0x2C65BD0", Offset = "0x2C65BD0", VA = "0x2C65BD0")]
	public UIPopupMessageBoxController()
	{
	}

	[Token(Token = "0x6011498")]
	[Address(RVA = "0x2C65C78", Offset = "0x2C65C78", VA = "0x2C65C78")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011499")]
	[Address(RVA = "0x2C65D1C", Offset = "0x2C65D1C", VA = "0x2C65D1C", Slot = "9")]
	protected override void Awake()
	{
	}

	[Token(Token = "0x601149A")]
	[Address(RVA = "0x2C65D8C", Offset = "0x2C65D8C", VA = "0x2C65D8C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601149B")]
	[Address(RVA = "0x2C66298", Offset = "0x2C66298", VA = "0x2C66298", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601149C")]
	[Address(RVA = "0x2C65FD8", Offset = "0x2C65FD8", VA = "0x2C65FD8")]
	private void SetBGAlpha()
	{
	}

	[Token(Token = "0x601149D")]
	[Address(RVA = "0x2C66410", Offset = "0x2C66410", VA = "0x2C66410")]
	public void ShowStandardMessageBox(string info, EStandardMessageBoxType mbType, [Optional] Action onOK, [Optional] Action onCancel, EButtonStyle buttonStyle = EButtonStyle.OKOnly, bool isColorfulInfo = false, string note = "", [Optional] Transform par, string okTextKey = "", [Optional] Func<bool> confirmDelayCallFunc)
	{
	}

	[Token(Token = "0x601149E")]
	[Address(RVA = "0x2C67810", Offset = "0x2C67810", VA = "0x2C67810")]
	protected void ActivateDelayExit()
	{
	}

	[Token(Token = "0x601149F")]
	[Address(RVA = "0x2C67964", Offset = "0x2C67964", VA = "0x2C67964")]
	protected void UpdateDelayExitView()
	{
	}

	[Token(Token = "0x60114A0")]
	[Address(RVA = "0x2C67D68", Offset = "0x2C67D68", VA = "0x2C67D68")]
	public void ShowMessageBox(string title, string info, EButtonStyle buttonStyle = EButtonStyle.OKCancel, [Optional] Action onOK, [Optional] Action onCancel, bool isColorfulInfo = false)
	{
	}

	[Token(Token = "0x60114A1")]
	[Address(RVA = "0x2C68164", Offset = "0x2C68164", VA = "0x2C68164")]
	public void ShowMessageBox(MessageBoxInfo info)
	{
	}

	[Token(Token = "0x60114A2")]
	[Address(RVA = "0x2C68578", Offset = "0x2C68578", VA = "0x2C68578")]
	public void SetSpeicalOkButton(uint time)
	{
	}

	[Token(Token = "0x60114A3")]
	[Address(RVA = "0x2C68974", Offset = "0x2C68974", VA = "0x2C68974")]
	private void Update()
	{
	}

	[Token(Token = "0x60114A4")]
	[Address(RVA = "0x2C6866C", Offset = "0x2C6866C", VA = "0x2C6866C")]
	private void UpdateOkButton(uint time)
	{
	}

	[Token(Token = "0x60114A5")]
	[Address(RVA = "0x2C68A38", Offset = "0x2C68A38", VA = "0x2C68A38")]
	private void OnBtnOKClick()
	{
	}

	[Token(Token = "0x60114A6")]
	[Address(RVA = "0x2C68ACC", Offset = "0x2C68ACC", VA = "0x2C68ACC")]
	protected void OnBtnCancelClick()
	{
	}

	[Token(Token = "0x60114A7")]
	[Address(RVA = "0x2C673C0", Offset = "0x2C673C0", VA = "0x2C673C0")]
	protected void UpdateView()
	{
	}

	[Token(Token = "0x60114A8")]
	[Address(RVA = "0x2C68B60", Offset = "0x2C68B60", VA = "0x2C68B60", Slot = "46")]
	public override void OnBackButtonClick()
	{
	}

	[Token(Token = "0x60114A9")]
	[Address(RVA = "0x2C68C04", Offset = "0x2C68C04", VA = "0x2C68C04", Slot = "47")]
	public override void OnEnterButtonClick()
	{
	}

	[Token(Token = "0x60114AA")]
	[Address(RVA = "0x2C68C7C", Offset = "0x2C68C7C", VA = "0x2C68C7C")]
	public void SetPopupMessageInfo(string message)
	{
	}

	[Token(Token = "0x60114AB")]
	[Address(RVA = "0x2C68D48", Offset = "0x2C68D48", VA = "0x2C68D48", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x60114AC")]
	[Address(RVA = "0x2C68F0C", Offset = "0x2C68F0C", VA = "0x2C68F0C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60114AD")]
	[Address(RVA = "0x2C68F14", Offset = "0x2C68F14", VA = "0x2C68F14")]
	public void _003C_003EiFixBaseProxy_Awake()
	{
	}

	[Token(Token = "0x60114AE")]
	[Address(RVA = "0x2C68F1C", Offset = "0x2C68F1C", VA = "0x2C68F1C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x60114AF")]
	[Address(RVA = "0x2C68F24", Offset = "0x2C68F24", VA = "0x2C68F24")]
	public void _003C_003EiFixBaseProxy_OnBackButtonClick()
	{
	}

	[Token(Token = "0x60114B0")]
	[Address(RVA = "0x2C68F2C", Offset = "0x2C68F2C", VA = "0x2C68F2C")]
	public void _003C_003EiFixBaseProxy_OnEnterButtonClick()
	{
	}

	[Token(Token = "0x60114B1")]
	[Address(RVA = "0x2C68F34", Offset = "0x2C68F34", VA = "0x2C68F34")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}
}
