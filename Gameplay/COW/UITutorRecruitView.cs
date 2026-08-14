using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A1B")]
public class UITutorRecruitView : UIBaseView
{
	[Token(Token = "0x4018889")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle WorldToggle;

	[Token(Token = "0x401888A")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget WorldWidget;

	[Token(Token = "0x401888B")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel WorldLabel;

	[Token(Token = "0x401888C")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle ClanToggle;

	[Token(Token = "0x401888D")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget ClanWidget;

	[Token(Token = "0x401888E")]
	[FieldOffset(Offset = "0x28")]
	public UIButton SendBtn;

	[Token(Token = "0x401888F")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget SendWidget;

	[Token(Token = "0x4018890")]
	[FieldOffset(Offset = "0x30")]
	public UIToggle TutorToggle;

	[Token(Token = "0x4018891")]
	[FieldOffset(Offset = "0x34")]
	public UIWidget TutorWidget;

	[Token(Token = "0x4018892")]
	[FieldOffset(Offset = "0x38")]
	public UIInput MessageInput;

	[Token(Token = "0x4018893")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel MessageLabel;

	[Token(Token = "0x4018894")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ClanLabel;

	[Token(Token = "0x4018895")]
	[FieldOffset(Offset = "0x44")]
	public UILabel TutorLabel;

	[Token(Token = "0x4018896")]
	[FieldOffset(Offset = "0x48")]
	public UIButton EditBtn;

	[Token(Token = "0x4018897")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel SendBtnLabel;

	[Token(Token = "0x4018898")]
	[FieldOffset(Offset = "0x50")]
	public UIButton GreyBtn;

	[Token(Token = "0x4018899")]
	[FieldOffset(Offset = "0x54")]
	public UILabel GreyBtnLabel;

	[Token(Token = "0x60171F7")]
	[Address(RVA = "0x1C39784", Offset = "0x1C39784", VA = "0x1C39784")]
	public UITutorRecruitView()
	{
	}

	[Token(Token = "0x60171F8")]
	[Address(RVA = "0x1C3978C", Offset = "0x1C3978C", VA = "0x1C3978C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171F9")]
	[Address(RVA = "0x1C39F34", Offset = "0x1C39F34", VA = "0x1C39F34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
