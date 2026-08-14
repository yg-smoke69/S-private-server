using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038EB")]
public class UIPaymentGrowthFundView : UIBaseView
{
	[Token(Token = "0x4017A28")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Hint;

	[Token(Token = "0x4017A29")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HasGained;

	[Token(Token = "0x4017A2A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel HasGainedLevel;

	[Token(Token = "0x4017A2B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel HasGainedDesc;

	[Token(Token = "0x4017A2C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HasNotGained;

	[Token(Token = "0x4017A2D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite PurchasableDiamondSprite;

	[Token(Token = "0x4017A2E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BundlePriceDiamondLabel;

	[Token(Token = "0x4017A2F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OriginalPriceDiamondLabel;

	[Token(Token = "0x4017A30")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PendingDiamondLabel;

	[Token(Token = "0x4017A31")]
	[FieldOffset(Offset = "0x38")]
	public UISprite PurchasableSprite;

	[Token(Token = "0x4017A32")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton Purchase;

	[Token(Token = "0x4017A33")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BundlePriceLabel;

	[Token(Token = "0x4017A34")]
	[FieldOffset(Offset = "0x44")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x4017A35")]
	[FieldOffset(Offset = "0x48")]
	public UILabel PendingLabel;

	[Token(Token = "0x4017A36")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite UnpurchasableSprite;

	[Token(Token = "0x4017A37")]
	[FieldOffset(Offset = "0x50")]
	public UISprite PurchasableFreeSprite;

	[Token(Token = "0x4017A38")]
	[FieldOffset(Offset = "0x54")]
	public UISprite PercentageSprite;

	[Token(Token = "0x4017A39")]
	[FieldOffset(Offset = "0x58")]
	public UILabel PercentageLabel;

	[Token(Token = "0x4017A3A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel DiamondCountLabel;

	[Token(Token = "0x4017A3B")]
	[FieldOffset(Offset = "0x60")]
	public UILabel HasNotGainedLevel;

	[Token(Token = "0x4017A3C")]
	[FieldOffset(Offset = "0x64")]
	public UILabel HasNotGainedDesc;

	[Token(Token = "0x4017A3D")]
	[FieldOffset(Offset = "0x68")]
	public UIScrollView BundlesScrollView;

	[Token(Token = "0x4017A3E")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid BundlesScrollViewGrid;

	[Token(Token = "0x4017A3F")]
	[FieldOffset(Offset = "0x70")]
	public UISprite ArrowRight;

	[Token(Token = "0x4017A40")]
	[FieldOffset(Offset = "0x74")]
	public UISprite ArrowLeft;

	[Token(Token = "0x4017A41")]
	[FieldOffset(Offset = "0x78")]
	public GameObject VFX_UI_Fund_01;

	[Token(Token = "0x6016E6A")]
	[Address(RVA = "0x29D1E9C", Offset = "0x29D1E9C", VA = "0x29D1E9C")]
	public UIPaymentGrowthFundView()
	{
	}

	[Token(Token = "0x6016E6B")]
	[Address(RVA = "0x29D1EA4", Offset = "0x29D1EA4", VA = "0x29D1EA4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E6C")]
	[Address(RVA = "0x29D2988", Offset = "0x29D2988", VA = "0x29D2988")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
