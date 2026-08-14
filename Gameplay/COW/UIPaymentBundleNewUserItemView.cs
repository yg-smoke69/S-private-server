using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E3")]
public class UIPaymentBundleNewUserItemView : UIBaseView
{
	[Token(Token = "0x40179BD")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView IAPBundleItemView;

	[Token(Token = "0x40179BE")]
	[FieldOffset(Offset = "0x18")]
	public UIDragScrollView DragScrollView;

	[Token(Token = "0x40179BF")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Countdown;

	[Token(Token = "0x40179C0")]
	[FieldOffset(Offset = "0x20")]
	public Transform Time;

	[Token(Token = "0x40179C1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Tag;

	[Token(Token = "0x40179C2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TagLabel;

	[Token(Token = "0x40179C3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Title;

	[Token(Token = "0x40179C4")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SubTitle;

	[Token(Token = "0x40179C5")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ClickBtn;

	[Token(Token = "0x40179C6")]
	[FieldOffset(Offset = "0x38")]
	public UISprite PurchasableSprite;

	[Token(Token = "0x40179C7")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BundlePriceLabel;

	[Token(Token = "0x40179C8")]
	[FieldOffset(Offset = "0x40")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x40179C9")]
	[FieldOffset(Offset = "0x44")]
	public UILabel PendingLabel;

	[Token(Token = "0x40179CA")]
	[FieldOffset(Offset = "0x48")]
	public UISprite PurchasableDiamondSprite;

	[Token(Token = "0x40179CB")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BundlePriceDiamondLabel;

	[Token(Token = "0x40179CC")]
	[FieldOffset(Offset = "0x50")]
	public UILabel OriginalPriceDiamondLabel;

	[Token(Token = "0x40179CD")]
	[FieldOffset(Offset = "0x54")]
	public UISprite PurchasableFreeSprite;

	[Token(Token = "0x40179CE")]
	[FieldOffset(Offset = "0x58")]
	public UISprite UnpurchasableSprite;

	[Token(Token = "0x40179CF")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject HasGained;

	[Token(Token = "0x40179D0")]
	[FieldOffset(Offset = "0x60")]
	public UILabel PurchaseLimitLabel;

	[Token(Token = "0x40179D1")]
	[FieldOffset(Offset = "0x64")]
	public UISprite PercentageSprite;

	[Token(Token = "0x40179D2")]
	[FieldOffset(Offset = "0x68")]
	public UILabel PercentageLabel;

	[Token(Token = "0x40179D3")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid ContentsGrid;

	[Token(Token = "0x40179D4")]
	[FieldOffset(Offset = "0x70")]
	public UIGrid ContentsGridBottom;

	[Token(Token = "0x40179D5")]
	[FieldOffset(Offset = "0x74")]
	public UIGrid ContentsGridTop;

	[Token(Token = "0x40179D6")]
	[FieldOffset(Offset = "0x78")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40179D7")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel TitleShadow;

	[Token(Token = "0x6016E52")]
	[Address(RVA = "0x2877610", Offset = "0x2877610", VA = "0x2877610")]
	public UIPaymentBundleNewUserItemView()
	{
	}

	[Token(Token = "0x6016E53")]
	[Address(RVA = "0x2877618", Offset = "0x2877618", VA = "0x2877618", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E54")]
	[Address(RVA = "0x2878134", Offset = "0x2878134", VA = "0x2878134")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
