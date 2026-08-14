using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003788")]
public class UIHudTutorialGamePopupWndView : UIBaseView
{
	[Token(Token = "0x4016804")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Mask;

	[Token(Token = "0x4016805")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4016806")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton BtnContinue;

	[Token(Token = "0x4016807")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TitleLabel;

	[Token(Token = "0x4016808")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelDescription;

	[Token(Token = "0x4016809")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnLeave;

	[Token(Token = "0x401680A")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BtnContinueLabelNormal;

	[Token(Token = "0x401680B")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel BtnContinueLabelCountDown;

	[Token(Token = "0x6016A43")]
	[Address(RVA = "0x1590A0C", Offset = "0x1590A0C", VA = "0x1590A0C")]
	public UIHudTutorialGamePopupWndView()
	{
	}

	[Token(Token = "0x6016A44")]
	[Address(RVA = "0x1590A14", Offset = "0x1590A14", VA = "0x1590A14", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A45")]
	[Address(RVA = "0x1590E5C", Offset = "0x1590E5C", VA = "0x1590E5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
