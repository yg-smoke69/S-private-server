using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200350D")]
public class UIElitePassSubscriptionView : UIBaseView
{
	[Token(Token = "0x4014EDC")]
	[FieldOffset(Offset = "0x14")]
	public UIButton PrivacyPolicyBtn;

	[Token(Token = "0x4014EDD")]
	[FieldOffset(Offset = "0x18")]
	public UIButton TermsOfServiceBtn;

	[Token(Token = "0x4014EDE")]
	[FieldOffset(Offset = "0x1C")]
	public UICountDownLabel SubscriptionCountDown;

	[Token(Token = "0x4014EDF")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture SubscribedCDN;

	[Token(Token = "0x4014EE0")]
	[FieldOffset(Offset = "0x24")]
	public UIButton SubscribeTipsBtn;

	[Token(Token = "0x4014EE1")]
	[FieldOffset(Offset = "0x28")]
	public UIButton SubscribeBtn;

	[Token(Token = "0x4014EE2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PriceLabel;

	[Token(Token = "0x4014EE3")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BonusUI;

	[Token(Token = "0x4014EE4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel BonusAmountLabel;

	[Token(Token = "0x4014EE5")]
	[FieldOffset(Offset = "0x38")]
	public UITable SubscriptionInfoTable;

	[Token(Token = "0x4014EE6")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SubscriptionInfoLabel_2;

	[Token(Token = "0x60162D7")]
	[Address(RVA = "0x3069290", Offset = "0x3069290", VA = "0x3069290")]
	public UIElitePassSubscriptionView()
	{
	}

	[Token(Token = "0x60162D8")]
	[Address(RVA = "0x3069298", Offset = "0x3069298", VA = "0x3069298", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162D9")]
	[Address(RVA = "0x3069800", Offset = "0x3069800", VA = "0x3069800")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
