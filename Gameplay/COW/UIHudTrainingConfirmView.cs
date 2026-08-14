using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003779")]
public class UIHudTrainingConfirmView : UIBaseView
{
	[Token(Token = "0x4016792")]
	[FieldOffset(Offset = "0x14")]
	public UIButton MaskBtn;

	[Token(Token = "0x4016793")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Icon;

	[Token(Token = "0x4016794")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel DescLabel;

	[Token(Token = "0x4016795")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TitleLabel;

	[Token(Token = "0x4016796")]
	[FieldOffset(Offset = "0x24")]
	public UIButton BtnCancel;

	[Token(Token = "0x4016797")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelCancel;

	[Token(Token = "0x4016798")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4016799")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelConfirm;

	[Token(Token = "0x6016A16")]
	[Address(RVA = "0x1583F98", Offset = "0x1583F98", VA = "0x1583F98")]
	public UIHudTrainingConfirmView()
	{
	}

	[Token(Token = "0x6016A17")]
	[Address(RVA = "0x1583FA0", Offset = "0x1583FA0", VA = "0x1583FA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A18")]
	[Address(RVA = "0x15843E8", Offset = "0x15843E8", VA = "0x15843E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
