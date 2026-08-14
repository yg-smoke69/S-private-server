using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035B7")]
public class UIGrowthFundAdView : UIBaseView
{
	[Token(Token = "0x40157D7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Effect;

	[Token(Token = "0x40157D8")]
	[FieldOffset(Offset = "0x18")]
	public Animation Anim;

	[Token(Token = "0x40157D9")]
	[FieldOffset(Offset = "0x1C")]
	public TweenScale Window;

	[Token(Token = "0x40157DA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Single;

	[Token(Token = "0x40157DB")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SingleCloseBtn;

	[Token(Token = "0x40157DC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SingleTitle01;

	[Token(Token = "0x40157DD")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SingleTitle02;

	[Token(Token = "0x40157DE")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SingleLabel3;

	[Token(Token = "0x40157DF")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SingleLabel1;

	[Token(Token = "0x40157E0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel SingleLabel4;

	[Token(Token = "0x40157E1")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SingleLabel2;

	[Token(Token = "0x40157E2")]
	[FieldOffset(Offset = "0x40")]
	public UIButton SingleBtn;

	[Token(Token = "0x40157E3")]
	[FieldOffset(Offset = "0x44")]
	public UILabel SingleBtnLabel;

	[Token(Token = "0x40157E4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Multi;

	[Token(Token = "0x40157E5")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton FundBtn;

	[Token(Token = "0x40157E6")]
	[FieldOffset(Offset = "0x50")]
	public UILabel FundLabel;

	[Token(Token = "0x40157E7")]
	[FieldOffset(Offset = "0x54")]
	public UIButton NewbieBtn;

	[Token(Token = "0x40157E8")]
	[FieldOffset(Offset = "0x58")]
	public UILabel NewbieLabel;

	[Token(Token = "0x40157E9")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Newbies;

	[Token(Token = "0x40157EA")]
	[FieldOffset(Offset = "0x60")]
	public UILabel NewbieLabel1;

	[Token(Token = "0x40157EB")]
	[FieldOffset(Offset = "0x64")]
	public UILabel NewbieLabel2;

	[Token(Token = "0x40157EC")]
	[FieldOffset(Offset = "0x68")]
	public UILabel NewbieLabel3;

	[Token(Token = "0x40157ED")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel NewbieLabel4;

	[Token(Token = "0x40157EE")]
	[FieldOffset(Offset = "0x70")]
	public GameObject GrowthFunds;

	[Token(Token = "0x40157EF")]
	[FieldOffset(Offset = "0x74")]
	public UILabel GrowthLabel1;

	[Token(Token = "0x40157F0")]
	[FieldOffset(Offset = "0x78")]
	public UILabel GrowthLabel2;

	[Token(Token = "0x40157F1")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel GrowthLabel3;

	[Token(Token = "0x40157F2")]
	[FieldOffset(Offset = "0x80")]
	public UILabel GrowthLabel4;

	[Token(Token = "0x40157F3")]
	[FieldOffset(Offset = "0x84")]
	public UIButton MultiCloseBtn;

	[Token(Token = "0x40157F4")]
	[FieldOffset(Offset = "0x88")]
	public GameObject DefaultTex;

	[Token(Token = "0x40157F5")]
	[FieldOffset(Offset = "0x8C")]
	public UINetworkTextureExt NetworkTextureContentMulti;

	[Token(Token = "0x40157F6")]
	[FieldOffset(Offset = "0x90")]
	public UINetworkTextureExt NetworkTextureContentSingle;

	[Token(Token = "0x40157F7")]
	[FieldOffset(Offset = "0x94")]
	public GameObject GrowthFund;

	[Token(Token = "0x40157F8")]
	[FieldOffset(Offset = "0x98")]
	public UIButton GrowthFundBtn;

	[Token(Token = "0x40157F9")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel GrowthFundBtnLabel;

	[Token(Token = "0x40157FA")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel GrowthFundTitle01;

	[Token(Token = "0x40157FB")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel GrowthFundTitle02;

	[Token(Token = "0x40157FC")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel GrowthFundDiamondPrice;

	[Token(Token = "0x40157FD")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel GrowthFundDiscountPercent;

	[Token(Token = "0x40157FE")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel GrowthFundDiscountDiamondAmount;

	[Token(Token = "0x40157FF")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel GrowthFundTopTitle;

	[Token(Token = "0x4015800")]
	[FieldOffset(Offset = "0xB8")]
	public UIButton GrowthFundCloseBtn;

	[Token(Token = "0x4015801")]
	[FieldOffset(Offset = "0xBC")]
	public UINetworkTextureExt NetworkTextureContentGrowthFund;

	[Token(Token = "0x60164D3")]
	[Address(RVA = "0x202605C", Offset = "0x202605C", VA = "0x202605C")]
	public UIGrowthFundAdView()
	{
	}

	[Token(Token = "0x60164D4")]
	[Address(RVA = "0x2026064", Offset = "0x2026064", VA = "0x2026064", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164D5")]
	[Address(RVA = "0x2027178", Offset = "0x2027178", VA = "0x2027178")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
