using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003678")]
public class UIHudInGameShopView : UIBaseView
{
	[Token(Token = "0x4015DFC")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition ShowAnim;

	[Token(Token = "0x4015DFD")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BGBtn;

	[Token(Token = "0x4015DFE")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x4015DFF")]
	[FieldOffset(Offset = "0x20")]
	public UITable ShopTable;

	[Token(Token = "0x4015E00")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CloseBtn;

	[Token(Token = "0x4015E01")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteCloseBtnLight;

	[Token(Token = "0x4015E02")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LeftTimeShow;

	[Token(Token = "0x4015E03")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LeftTime;

	[Token(Token = "0x4015E04")]
	[FieldOffset(Offset = "0x34")]
	public GameObject TotalCount;

	[Token(Token = "0x4015E05")]
	[FieldOffset(Offset = "0x38")]
	public UISprite CoinIcon;

	[Token(Token = "0x4015E06")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel CoinValue;

	[Token(Token = "0x4015E07")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CoinBtn;

	[Token(Token = "0x4015E08")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SpriteBtnCoin;

	[Token(Token = "0x4015E09")]
	[FieldOffset(Offset = "0x48")]
	public GameObject CoinTipAnchor;

	[Token(Token = "0x4015E0A")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BuySameBtn;

	[Token(Token = "0x4015E0B")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BuyBtn;

	[Token(Token = "0x4015E0C")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpriteBuyBtn;

	[Token(Token = "0x4015E0D")]
	[FieldOffset(Offset = "0x58")]
	public UILabel BuyBtnLabel;

	[Token(Token = "0x4015E0E")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel BuyBtnLabelDisable;

	[Token(Token = "0x4015E0F")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Capacity;

	[Token(Token = "0x4015E10")]
	[FieldOffset(Offset = "0x64")]
	public UILabel CapacityValue;

	[Token(Token = "0x4015E11")]
	[FieldOffset(Offset = "0x68")]
	public UIButton CapacityBtn;

	[Token(Token = "0x4015E12")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject CapacityTipAnchor;

	[Token(Token = "0x4015E13")]
	[FieldOffset(Offset = "0x70")]
	public UILabel TipLabel;

	[Token(Token = "0x4015E14")]
	[FieldOffset(Offset = "0x74")]
	public UILabel title;

	[Token(Token = "0x4015E15")]
	[FieldOffset(Offset = "0x78")]
	public UIButton HelpBtn;

	[Token(Token = "0x4015E16")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton AskBtn;

	[Token(Token = "0x4015E17")]
	[FieldOffset(Offset = "0x80")]
	public GameObject RoundInfo;

	[Token(Token = "0x4015E18")]
	[FieldOffset(Offset = "0x84")]
	public UIScrollView RoundScrollView;

	[Token(Token = "0x4015E19")]
	[FieldOffset(Offset = "0x88")]
	public UIGrid RoundGrid;

	[Token(Token = "0x4015E1A")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ExtraTips;

	[Token(Token = "0x4015E1B")]
	[FieldOffset(Offset = "0x90")]
	public UILabel CSShopTips;

	[Token(Token = "0x4015E1C")]
	[FieldOffset(Offset = "0x94")]
	public GameObject CSShopWarning;

	[Token(Token = "0x6016715")]
	[Address(RVA = "0x22A4D30", Offset = "0x22A4D30", VA = "0x22A4D30")]
	public UIHudInGameShopView()
	{
	}

	[Token(Token = "0x6016716")]
	[Address(RVA = "0x22A4D38", Offset = "0x22A4D38", VA = "0x22A4D38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016717")]
	[Address(RVA = "0x22A5A8C", Offset = "0x22A5A8C", VA = "0x22A5A8C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
