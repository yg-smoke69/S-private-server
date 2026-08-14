using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200386A")]
public class UIMallBoxItemView : UIBaseView
{
	[Token(Token = "0x40172A4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIMallBoxItem;

	[Token(Token = "0x40172A5")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Widget;

	[Token(Token = "0x40172A6")]
	[FieldOffset(Offset = "0x1C")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x40172A7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Default;

	[Token(Token = "0x40172A8")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40172A9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HighLightBG;

	[Token(Token = "0x40172AA")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject DiscountItemIcon;

	[Token(Token = "0x40172AB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject OtherChannelContainer;

	[Token(Token = "0x40172AC")]
	[FieldOffset(Offset = "0x34")]
	public UILabel OtherChannelTitle;

	[Token(Token = "0x40172AD")]
	[FieldOffset(Offset = "0x38")]
	public UISprite OtherChannelIcon;

	[Token(Token = "0x40172AE")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x40172AF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DiscountVFX;

	[Token(Token = "0x40172B0")]
	[FieldOffset(Offset = "0x44")]
	public UITable PriceContainer;

	[Token(Token = "0x40172B1")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DiamondIcon;

	[Token(Token = "0x40172B2")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel DiamondPrice;

	[Token(Token = "0x40172B3")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Slash;

	[Token(Token = "0x40172B4")]
	[FieldOffset(Offset = "0x54")]
	public GameObject GoldIcon;

	[Token(Token = "0x40172B5")]
	[FieldOffset(Offset = "0x58")]
	public UILabel GoldPrice;

	[Token(Token = "0x40172B6")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel OriginalPrice;

	[Token(Token = "0x40172B7")]
	[FieldOffset(Offset = "0x60")]
	public UISprite PriceBG;

	[Token(Token = "0x6016CE9")]
	[Address(RVA = "0x2398974", Offset = "0x2398974", VA = "0x2398974")]
	public UIMallBoxItemView()
	{
	}

	[Token(Token = "0x6016CEA")]
	[Address(RVA = "0x239897C", Offset = "0x239897C", VA = "0x239897C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CEB")]
	[Address(RVA = "0x23991E4", Offset = "0x23991E4", VA = "0x23991E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
