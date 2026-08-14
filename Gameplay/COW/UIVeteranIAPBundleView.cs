using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A5A")]
public class UIVeteranIAPBundleView : UIBaseView
{
	[Token(Token = "0x4018B1E")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIVeteranIAPBundle;

	[Token(Token = "0x4018B1F")]
	[FieldOffset(Offset = "0x18")]
	public Animation main;

	[Token(Token = "0x4018B20")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Close;

	[Token(Token = "0x4018B21")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DiscountWidget;

	[Token(Token = "0x4018B22")]
	[FieldOffset(Offset = "0x24")]
	public Animation DiscountWidgetAnimation;

	[Token(Token = "0x4018B23")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DiscountEffectLabel;

	[Token(Token = "0x4018B24")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x4018B25")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DesciptionLabel;

	[Token(Token = "0x4018B26")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView BundleContentScrollView;

	[Token(Token = "0x4018B27")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList ContentItemsEasyList;

	[Token(Token = "0x4018B28")]
	[FieldOffset(Offset = "0x3C")]
	public UIGrid BundleContentGrid;

	[Token(Token = "0x4018B29")]
	[FieldOffset(Offset = "0x40")]
	public Transform Item0;

	[Token(Token = "0x4018B2A")]
	[FieldOffset(Offset = "0x44")]
	public Transform Item1;

	[Token(Token = "0x4018B2B")]
	[FieldOffset(Offset = "0x48")]
	public Transform Item2;

	[Token(Token = "0x4018B2C")]
	[FieldOffset(Offset = "0x4C")]
	public Transform Item3;

	[Token(Token = "0x4018B2D")]
	[FieldOffset(Offset = "0x50")]
	public Transform Item4;

	[Token(Token = "0x4018B2E")]
	[FieldOffset(Offset = "0x54")]
	public UITable Table;

	[Token(Token = "0x4018B2F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel OwnedLabel;

	[Token(Token = "0x4018B30")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite ReturnTypeSprite;

	[Token(Token = "0x4018B31")]
	[FieldOffset(Offset = "0x60")]
	public BaseItemView ReturnItemView;

	[Token(Token = "0x4018B32")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ReturnNumLabel;

	[Token(Token = "0x4018B33")]
	[FieldOffset(Offset = "0x68")]
	public UIGrid PurchaseBtnGrid;

	[Token(Token = "0x4018B34")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton PurchaseButton;

	[Token(Token = "0x4018B35")]
	[FieldOffset(Offset = "0x70")]
	public GameObject ExtraDiamond;

	[Token(Token = "0x4018B36")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ExtraDiamondLabel;

	[Token(Token = "0x4018B37")]
	[FieldOffset(Offset = "0x78")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x4018B38")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel ActualPriceLabel;

	[Token(Token = "0x4018B39")]
	[FieldOffset(Offset = "0x80")]
	public UISprite PendingMask;

	[Token(Token = "0x4018B3A")]
	[FieldOffset(Offset = "0x84")]
	public UILabel PendingLabel;

	[Token(Token = "0x4018B3B")]
	[FieldOffset(Offset = "0x88")]
	public UIPanel PanelMaxDepth;

	[Token(Token = "0x4018B3C")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite PreviewLeft;

	[Token(Token = "0x4018B3D")]
	[FieldOffset(Offset = "0x90")]
	public UISprite PreviewRight;

	[Token(Token = "0x60172B4")]
	[Address(RVA = "0x285D5A0", Offset = "0x285D5A0", VA = "0x285D5A0")]
	public UIVeteranIAPBundleView()
	{
	}

	[Token(Token = "0x60172B5")]
	[Address(RVA = "0x285D5A8", Offset = "0x285D5A8", VA = "0x285D5A8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172B6")]
	[Address(RVA = "0x285E210", Offset = "0x285E210", VA = "0x285E210")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
