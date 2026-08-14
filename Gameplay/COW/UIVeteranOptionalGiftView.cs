using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A5D")]
public class UIVeteranOptionalGiftView : UIBaseView
{
	[Token(Token = "0x4018B49")]
	[FieldOffset(Offset = "0x14")]
	public Animation AnimationMain;

	[Token(Token = "0x4018B4A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject NoSelectContainer;

	[Token(Token = "0x4018B4B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ClickMask;

	[Token(Token = "0x4018B4C")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Title;

	[Token(Token = "0x4018B4D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GiftPreviewTab;

	[Token(Token = "0x4018B4E")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButton GiftPreview1;

	[Token(Token = "0x4018B4F")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton GiftPreview2;

	[Token(Token = "0x4018B50")]
	[FieldOffset(Offset = "0x30")]
	public UIToggleButton GiftPreview3;

	[Token(Token = "0x4018B51")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton GiftPreview4;

	[Token(Token = "0x4018B52")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButton GiftPreview5;

	[Token(Token = "0x4018B53")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButton GiftPreview6;

	[Token(Token = "0x4018B54")]
	[FieldOffset(Offset = "0x40")]
	public Animation AnimationItemMain;

	[Token(Token = "0x4018B55")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BG;

	[Token(Token = "0x4018B56")]
	[FieldOffset(Offset = "0x48")]
	public GameObject ItemContainer;

	[Token(Token = "0x4018B57")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel TipsLabel;

	[Token(Token = "0x4018B58")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid OptionalGiftGridTop;

	[Token(Token = "0x4018B59")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TipsContainer;

	[Token(Token = "0x4018B5A")]
	[FieldOffset(Offset = "0x58")]
	public UILabel WelcomeReturnLabel;

	[Token(Token = "0x4018B5B")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton VaultBtn;

	[Token(Token = "0x4018B5C")]
	[FieldOffset(Offset = "0x60")]
	public Animation VaultAnimation;

	[Token(Token = "0x4018B5D")]
	[FieldOffset(Offset = "0x64")]
	public UILabel VaultLabel;

	[Token(Token = "0x4018B5E")]
	[FieldOffset(Offset = "0x68")]
	public UILabel RewardsToken;

	[Token(Token = "0x4018B5F")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel RecommendLabel;

	[Token(Token = "0x4018B60")]
	[FieldOffset(Offset = "0x70")]
	public UIButton Recommend;

	[Token(Token = "0x4018B61")]
	[FieldOffset(Offset = "0x74")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4018B62")]
	[FieldOffset(Offset = "0x78")]
	public UILabel ConfirmLabel;

	[Token(Token = "0x4018B63")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject Confirm;

	[Token(Token = "0x4018B64")]
	[FieldOffset(Offset = "0x80")]
	public GameObject NoConfirm;

	[Token(Token = "0x4018B65")]
	[FieldOffset(Offset = "0x84")]
	public UILabel NoConfirmLabel;

	[Token(Token = "0x4018B66")]
	[FieldOffset(Offset = "0x88")]
	public UILabel TaskNumLabel;

	[Token(Token = "0x4018B67")]
	[FieldOffset(Offset = "0x8C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60172BD")]
	[Address(RVA = "0x2CAE750", Offset = "0x2CAE750", VA = "0x2CAE750")]
	public UIVeteranOptionalGiftView()
	{
	}

	[Token(Token = "0x60172BE")]
	[Address(RVA = "0x2CAE758", Offset = "0x2CAE758", VA = "0x2CAE758", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172BF")]
	[Address(RVA = "0x2CAF3E0", Offset = "0x2CAF3E0", VA = "0x2CAF3E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
