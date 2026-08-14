using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003477")]
public class UICommonGuideView : UIBaseView
{
	[Token(Token = "0x40146A8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GoHand;

	[Token(Token = "0x40146A9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GoCircle;

	[Token(Token = "0x40146AA")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteCircle;

	[Token(Token = "0x40146AB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GoRect;

	[Token(Token = "0x40146AC")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteRect;

	[Token(Token = "0x40146AD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GoArrow;

	[Token(Token = "0x40146AE")]
	[FieldOffset(Offset = "0x2C")]
	public UIAnchor AnchorArrow;

	[Token(Token = "0x40146AF")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GoHint;

	[Token(Token = "0x40146B0")]
	[FieldOffset(Offset = "0x34")]
	public UILabel HintLabel;

	[Token(Token = "0x40146B1")]
	[FieldOffset(Offset = "0x38")]
	public UISprite TipsBGWidget;

	[Token(Token = "0x40146B2")]
	[FieldOffset(Offset = "0x3C")]
	public Transform TrRootCharacter;

	[Token(Token = "0x40146B3")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget WidgetBound;

	[Token(Token = "0x6016119")]
	[Address(RVA = "0x2CE3394", Offset = "0x2CE3394", VA = "0x2CE3394")]
	public UICommonGuideView()
	{
	}

	[Token(Token = "0x601611A")]
	[Address(RVA = "0x2CE339C", Offset = "0x2CE339C", VA = "0x2CE339C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601611B")]
	[Address(RVA = "0x2CE3900", Offset = "0x2CE3900", VA = "0x2CE3900")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
