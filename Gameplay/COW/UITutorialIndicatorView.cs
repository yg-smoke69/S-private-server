using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A18")]
public class UITutorialIndicatorView : UIBaseView
{
	[Token(Token = "0x401886D")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel MainPanel;

	[Token(Token = "0x401886E")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoCircle;

	[Token(Token = "0x401886F")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteCircle;

	[Token(Token = "0x4018870")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoArrow;

	[Token(Token = "0x4018871")]
	[FieldOffset(Offset = "0x24")]
	public UIAnchor AnchorArrow;

	[Token(Token = "0x4018872")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoRect;

	[Token(Token = "0x4018873")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteRect;

	[Token(Token = "0x4018874")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GoHint;

	[Token(Token = "0x4018875")]
	[FieldOffset(Offset = "0x34")]
	public UILabel HintLabel;

	[Token(Token = "0x4018876")]
	[FieldOffset(Offset = "0x38")]
	public UISprite TipsBGWidget;

	[Token(Token = "0x4018877")]
	[FieldOffset(Offset = "0x3C")]
	public Transform TrRootCharacter;

	[Token(Token = "0x4018878")]
	[FieldOffset(Offset = "0x40")]
	public GameObject GoHand;

	[Token(Token = "0x4018879")]
	[FieldOffset(Offset = "0x44")]
	public Transform TrHandVisualAngle;

	[Token(Token = "0x401887A")]
	[FieldOffset(Offset = "0x48")]
	public Transform TrHandMoveRound;

	[Token(Token = "0x401887B")]
	[FieldOffset(Offset = "0x4C")]
	public Transform TrHandDragInBag;

	[Token(Token = "0x401887C")]
	[FieldOffset(Offset = "0x50")]
	public GameObject MaskAll;

	[Token(Token = "0x401887D")]
	[FieldOffset(Offset = "0x54")]
	public UIButton MaskBtnUIButton;

	[Token(Token = "0x401887E")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget MaskBtnUIWidget;

	[Token(Token = "0x401887F")]
	[FieldOffset(Offset = "0x5C")]
	public BoxCollider MaskBtnBoxCollider;

	[Token(Token = "0x4018880")]
	[FieldOffset(Offset = "0x60")]
	public Transform TrHandHintAbove;

	[Token(Token = "0x60171EE")]
	[Address(RVA = "0x2B7D9F4", Offset = "0x2B7D9F4", VA = "0x2B7D9F4")]
	public UITutorialIndicatorView()
	{
	}

	[Token(Token = "0x60171EF")]
	[Address(RVA = "0x2B7D9FC", Offset = "0x2B7D9FC", VA = "0x2B7D9FC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171F0")]
	[Address(RVA = "0x2B7E1B4", Offset = "0x2B7E1B4", VA = "0x2B7E1B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
