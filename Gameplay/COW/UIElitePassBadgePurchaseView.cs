using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034FB")]
public class UIElitePassBadgePurchaseView : UIBaseView
{
	[Token(Token = "0x4014D97")]
	[FieldOffset(Offset = "0x14")]
	public UICountDownLabel RefreshLabel;

	[Token(Token = "0x4014D98")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture CDNTheme;

	[Token(Token = "0x4014D99")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BadgeCountIconSprite;

	[Token(Token = "0x4014D9A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton badgeInfoBtn;

	[Token(Token = "0x4014D9B")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BadgeCount;

	[Token(Token = "0x4014D9C")]
	[FieldOffset(Offset = "0x28")]
	public UIButton MinusBtn;

	[Token(Token = "0x4014D9D")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton MinusFiveBtn;

	[Token(Token = "0x4014D9E")]
	[FieldOffset(Offset = "0x30")]
	public UIButton PlusBtn;

	[Token(Token = "0x4014D9F")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PlusFiveBtn;

	[Token(Token = "0x4014DA0")]
	[FieldOffset(Offset = "0x38")]
	public UIInput BuyCountField;

	[Token(Token = "0x4014DA1")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite Badge;

	[Token(Token = "0x4014DA2")]
	[FieldOffset(Offset = "0x40")]
	public UILabel DiamondAmountOriginal;

	[Token(Token = "0x4014DA3")]
	[FieldOffset(Offset = "0x44")]
	public GameObject DiamondSpriteOriginal;

	[Token(Token = "0x4014DA4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CoinSpriteOriginal;

	[Token(Token = "0x4014DA5")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4014DA6")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DiamondSprite;

	[Token(Token = "0x4014DA7")]
	[FieldOffset(Offset = "0x54")]
	public UILabel DiamondAmount;

	[Token(Token = "0x4014DA8")]
	[FieldOffset(Offset = "0x58")]
	public GameObject CoinSprite;

	[Token(Token = "0x4014DA9")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton UpgradeBtn;

	[Token(Token = "0x4014DAA")]
	[FieldOffset(Offset = "0x60")]
	public UISprite EPSprite;

	[Token(Token = "0x4014DAB")]
	[FieldOffset(Offset = "0x64")]
	public UIEasyList Grid;

	[Token(Token = "0x4014DAC")]
	[FieldOffset(Offset = "0x68")]
	public UIWidget PreViewContain;

	[Token(Token = "0x4014DAD")]
	[FieldOffset(Offset = "0x6C")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x60162A1")]
	[Address(RVA = "0x2A3F078", Offset = "0x2A3F078", VA = "0x2A3F078")]
	public UIElitePassBadgePurchaseView()
	{
	}

	[Token(Token = "0x60162A2")]
	[Address(RVA = "0x2A3F080", Offset = "0x2A3F080", VA = "0x2A3F080", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162A3")]
	[Address(RVA = "0x2A3FA38", Offset = "0x2A3FA38", VA = "0x2A3FA38")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
