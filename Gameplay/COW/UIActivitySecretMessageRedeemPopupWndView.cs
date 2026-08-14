using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033B5")]
public class UIActivitySecretMessageRedeemPopupWndView : UIBaseView
{
	[Token(Token = "0x4013BE9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4013BEA")]
	[FieldOffset(Offset = "0x18")]
	public UILabel SecretMessageLabel;

	[Token(Token = "0x4013BEB")]
	[FieldOffset(Offset = "0x1C")]
	public UIInput SecretMessageInput;

	[Token(Token = "0x4013BEC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel HelpTipsLabel;

	[Token(Token = "0x4013BED")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SecretMessageInputMask;

	[Token(Token = "0x4013BEE")]
	[FieldOffset(Offset = "0x28")]
	public UIPanel GuideMaskPanel;

	[Token(Token = "0x4013BEF")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton GuideMask;

	[Token(Token = "0x4013BF0")]
	[FieldOffset(Offset = "0x30")]
	public UIButton PasteBtn;

	[Token(Token = "0x4013BF1")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ConfirmBtnGrey;

	[Token(Token = "0x6015ED5")]
	[Address(RVA = "0x1F1D508", Offset = "0x1F1D508", VA = "0x1F1D508")]
	public UIActivitySecretMessageRedeemPopupWndView()
	{
	}

	[Token(Token = "0x6015ED6")]
	[Address(RVA = "0x1F1D510", Offset = "0x1F1D510", VA = "0x1F1D510", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015ED7")]
	[Address(RVA = "0x1F1D9AC", Offset = "0x1F1D9AC", VA = "0x1F1D9AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
