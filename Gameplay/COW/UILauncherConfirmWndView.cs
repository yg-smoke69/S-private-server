using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003814")]
public class UILauncherConfirmWndView : UIBaseView
{
	[Token(Token = "0x4016CFE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4016CFF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelTitle;

	[Token(Token = "0x4016D00")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OneTextStyle;

	[Token(Token = "0x4016D01")]
	[FieldOffset(Offset = "0x20")]
	public UILabel OneTextContent;

	[Token(Token = "0x4016D02")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CancelBtn;

	[Token(Token = "0x4016D03")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CancelBtnLabel;

	[Token(Token = "0x4016D04")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4016D05")]
	[FieldOffset(Offset = "0x30")]
	public UILabel ConfirmBtnLabel;

	[Token(Token = "0x6016BE7")]
	[Address(RVA = "0x22DB078", Offset = "0x22DB078", VA = "0x22DB078")]
	public UILauncherConfirmWndView()
	{
	}

	[Token(Token = "0x6016BE8")]
	[Address(RVA = "0x22DB080", Offset = "0x22DB080", VA = "0x22DB080", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BE9")]
	[Address(RVA = "0x22DB4BC", Offset = "0x22DB4BC", VA = "0x22DB4BC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
