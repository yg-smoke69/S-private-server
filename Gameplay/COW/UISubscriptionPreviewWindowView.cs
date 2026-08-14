using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039F6")]
public class UISubscriptionPreviewWindowView : UIBaseView
{
	[Token(Token = "0x40186CA")]
	[FieldOffset(Offset = "0x14")]
	public UIButton TermsOfServiceBtn;

	[Token(Token = "0x40186CB")]
	[FieldOffset(Offset = "0x18")]
	public UIButton PrivacyPolicyBtn;

	[Token(Token = "0x40186CC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SubscriptionBenefitLabel;

	[Token(Token = "0x40186CD")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Icon_RebateCard_Week;

	[Token(Token = "0x40186CE")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Icon_RebateCard_Month;

	[Token(Token = "0x40186CF")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Icon_ElitePass;

	[Token(Token = "0x40186D0")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Icon_Bundle;

	[Token(Token = "0x40186D1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SubscriptionInfoTitleLabel;

	[Token(Token = "0x40186D2")]
	[FieldOffset(Offset = "0x34")]
	public UILabel SubscriptionInfoLabel_1;

	[Token(Token = "0x40186D3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel SubscriptionInfoLabel_2;

	[Token(Token = "0x40186D4")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SubscriptionInfoLabel_3;

	[Token(Token = "0x40186D5")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SubscriptionInfoLabel_4;

	[Token(Token = "0x40186D6")]
	[FieldOffset(Offset = "0x44")]
	public UILabel SubscriptionInfoLabel_5;

	[Token(Token = "0x40186D7")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SubscriptionInfoLabel_6;

	[Token(Token = "0x40186D8")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel SubscriptionInfoLabel_7;

	[Token(Token = "0x40186D9")]
	[FieldOffset(Offset = "0x50")]
	public UIButton SubscribeBtn;

	[Token(Token = "0x40186DA")]
	[FieldOffset(Offset = "0x54")]
	public UILabel PerPeriodLabel;

	[Token(Token = "0x40186DB")]
	[FieldOffset(Offset = "0x58")]
	public UILabel PriceLabel;

	[Token(Token = "0x40186DC")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BonusUI;

	[Token(Token = "0x40186DD")]
	[FieldOffset(Offset = "0x60")]
	public UILabel BonusAmountLabel;

	[Token(Token = "0x6017188")]
	[Address(RVA = "0x201377C", Offset = "0x201377C", VA = "0x201377C")]
	public UISubscriptionPreviewWindowView()
	{
	}

	[Token(Token = "0x6017189")]
	[Address(RVA = "0x2013784", Offset = "0x2013784", VA = "0x2013784", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601718A")]
	[Address(RVA = "0x201404C", Offset = "0x201404C", VA = "0x201404C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
