using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E2")]
public class UIPaymentBundleItemView : UIBaseView
{
	[Token(Token = "0x40179A4")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView IAPBundleItemView;

	[Token(Token = "0x40179A5")]
	[FieldOffset(Offset = "0x18")]
	public UIDragScrollView DragScrollView;

	[Token(Token = "0x40179A6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Tag;

	[Token(Token = "0x40179A7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TagLabel;

	[Token(Token = "0x40179A8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Countdown;

	[Token(Token = "0x40179A9")]
	[FieldOffset(Offset = "0x28")]
	public Transform Time;

	[Token(Token = "0x40179AA")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SubTitle;

	[Token(Token = "0x40179AB")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Title;

	[Token(Token = "0x40179AC")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ClickBtn;

	[Token(Token = "0x40179AD")]
	[FieldOffset(Offset = "0x38")]
	public UISprite PurchasableSprite;

	[Token(Token = "0x40179AE")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BundlePriceLabel;

	[Token(Token = "0x40179AF")]
	[FieldOffset(Offset = "0x40")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x40179B0")]
	[FieldOffset(Offset = "0x44")]
	public UILabel PendingLabel;

	[Token(Token = "0x40179B1")]
	[FieldOffset(Offset = "0x48")]
	public UISprite PurchasableDiamondSprite;

	[Token(Token = "0x40179B2")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BundlePriceDiamondLabel;

	[Token(Token = "0x40179B3")]
	[FieldOffset(Offset = "0x50")]
	public UILabel OriginalPriceDiamondLabel;

	[Token(Token = "0x40179B4")]
	[FieldOffset(Offset = "0x54")]
	public UISprite PurchasableFreeSprite;

	[Token(Token = "0x40179B5")]
	[FieldOffset(Offset = "0x58")]
	public UISprite UnpurchasableSprite;

	[Token(Token = "0x40179B6")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject HasGained;

	[Token(Token = "0x40179B7")]
	[FieldOffset(Offset = "0x60")]
	public UILabel PurchaseLimitLabel;

	[Token(Token = "0x40179B8")]
	[FieldOffset(Offset = "0x64")]
	public UISprite PercentageSprite;

	[Token(Token = "0x40179B9")]
	[FieldOffset(Offset = "0x68")]
	public UILabel PercentageLabel;

	[Token(Token = "0x40179BA")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid ContentsGrid;

	[Token(Token = "0x40179BB")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid ContentsGridTop;

	[Token(Token = "0x40179BC")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid ContentsGridBottom;

	[Token(Token = "0x6016E4F")]
	[Address(RVA = "0x2872C50", Offset = "0x2872C50", VA = "0x2872C50")]
	public UIPaymentBundleItemView()
	{
	}

	[Token(Token = "0x6016E50")]
	[Address(RVA = "0x2872C58", Offset = "0x2872C58", VA = "0x2872C58", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E51")]
	[Address(RVA = "0x28736B4", Offset = "0x28736B4", VA = "0x28736B4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
