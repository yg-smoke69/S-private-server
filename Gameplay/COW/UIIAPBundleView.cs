using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037F4")]
public class UIIAPBundleView : UIBaseView
{
	[Token(Token = "0x4016B37")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIIAPBundle;

	[Token(Token = "0x4016B38")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContentBG;

	[Token(Token = "0x4016B39")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Hint;

	[Token(Token = "0x4016B3A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject DiscountWidget;

	[Token(Token = "0x4016B3B")]
	[FieldOffset(Offset = "0x24")]
	public Animation DiscountWidgetAnimation;

	[Token(Token = "0x4016B3C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel DiscountEffectLabel;

	[Token(Token = "0x4016B3D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4016B3E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SloganLabel;

	[Token(Token = "0x4016B3F")]
	[FieldOffset(Offset = "0x34")]
	public UINetworkTexture CDNTitle;

	[Token(Token = "0x4016B40")]
	[FieldOffset(Offset = "0x38")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x4016B41")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel DefaultLabelTitle;

	[Token(Token = "0x4016B42")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DesciptionLabel;

	[Token(Token = "0x4016B43")]
	[FieldOffset(Offset = "0x44")]
	public UIScrollView BundleContentScrollView;

	[Token(Token = "0x4016B44")]
	[FieldOffset(Offset = "0x48")]
	public UIEasyList ContentItemsEasyList;

	[Token(Token = "0x4016B45")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid BundleContentGrid;

	[Token(Token = "0x4016B46")]
	[FieldOffset(Offset = "0x50")]
	public Transform Item0;

	[Token(Token = "0x4016B47")]
	[FieldOffset(Offset = "0x54")]
	public Transform Item1;

	[Token(Token = "0x4016B48")]
	[FieldOffset(Offset = "0x58")]
	public Transform Item2;

	[Token(Token = "0x4016B49")]
	[FieldOffset(Offset = "0x5C")]
	public Transform Item3;

	[Token(Token = "0x4016B4A")]
	[FieldOffset(Offset = "0x60")]
	public Transform Item4;

	[Token(Token = "0x4016B4B")]
	[FieldOffset(Offset = "0x64")]
	public UITable Table;

	[Token(Token = "0x4016B4C")]
	[FieldOffset(Offset = "0x68")]
	public UILabel OwnedLabel;

	[Token(Token = "0x4016B4D")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite ReturnTypeSprite;

	[Token(Token = "0x4016B4E")]
	[FieldOffset(Offset = "0x70")]
	public BaseItemView ReturnItemView;

	[Token(Token = "0x4016B4F")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ReturnNumLabel;

	[Token(Token = "0x4016B50")]
	[FieldOffset(Offset = "0x78")]
	public GameObject OR;

	[Token(Token = "0x4016B51")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject CenterPoint;

	[Token(Token = "0x4016B52")]
	[FieldOffset(Offset = "0x80")]
	public UIGrid PurchaseBtnGrid;

	[Token(Token = "0x4016B53")]
	[FieldOffset(Offset = "0x84")]
	public UIButton PurchaseButton;

	[Token(Token = "0x4016B54")]
	[FieldOffset(Offset = "0x88")]
	public GameObject ExtraDiamond;

	[Token(Token = "0x4016B55")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ExtraDiamondLabel;

	[Token(Token = "0x4016B56")]
	[FieldOffset(Offset = "0x90")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x4016B57")]
	[FieldOffset(Offset = "0x94")]
	public UILabel ActualPriceLabel;

	[Token(Token = "0x4016B58")]
	[FieldOffset(Offset = "0x98")]
	public UISprite PendingMask;

	[Token(Token = "0x4016B59")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel PendingLabel;

	[Token(Token = "0x4016B5A")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton DiamondPurchaseButton;

	[Token(Token = "0x4016B5B")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject OriginalDiamond;

	[Token(Token = "0x4016B5C")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel OriginalDiamondPriceLabel;

	[Token(Token = "0x4016B5D")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject ActualDiamond;

	[Token(Token = "0x4016B5E")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel ActualDiamondPriceLabel;

	[Token(Token = "0x4016B5F")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite DiamondPendingMask;

	[Token(Token = "0x4016B60")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel DiamondPendingLabel;

	[Token(Token = "0x4016B61")]
	[FieldOffset(Offset = "0xBC")]
	public UIPanel PanelMaxDepth;

	[Token(Token = "0x4016B62")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016B87")]
	[Address(RVA = "0xD423C8", Offset = "0xD423C8", VA = "0xD423C8")]
	public UIIAPBundleView()
	{
	}

	[Token(Token = "0x6016B88")]
	[Address(RVA = "0xD423D0", Offset = "0xD423D0", VA = "0xD423D0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B89")]
	[Address(RVA = "0xD4347C", Offset = "0xD4347C", VA = "0xD4347C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
