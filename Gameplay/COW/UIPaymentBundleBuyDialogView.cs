using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038E0")]
public class UIPaymentBundleBuyDialogView : UIBaseView
{
	[Token(Token = "0x4017994")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4017995")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Button;

	[Token(Token = "0x4017996")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel BundlePriceDiamondLabel;

	[Token(Token = "0x4017997")]
	[FieldOffset(Offset = "0x20")]
	public UILabel OriginalPriceDiamondLabel;

	[Token(Token = "0x4017998")]
	[FieldOffset(Offset = "0x24")]
	public UISprite PercentageSprite;

	[Token(Token = "0x4017999")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PercentageLabel;

	[Token(Token = "0x6016E49")]
	[Address(RVA = "0x2869EC4", Offset = "0x2869EC4", VA = "0x2869EC4")]
	public UIPaymentBundleBuyDialogView()
	{
	}

	[Token(Token = "0x6016E4A")]
	[Address(RVA = "0x2869ECC", Offset = "0x2869ECC", VA = "0x2869ECC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E4B")]
	[Address(RVA = "0x286A254", Offset = "0x286A254", VA = "0x286A254")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
