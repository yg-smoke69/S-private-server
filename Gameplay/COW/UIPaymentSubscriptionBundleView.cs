using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F1")]
public class UIPaymentSubscriptionBundleView : UIBaseView
{
	[Token(Token = "0x4017A78")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentSubscriptionBundle;

	[Token(Token = "0x4017A79")]
	[FieldOffset(Offset = "0x18")]
	public Animation UIPaymentSubscriptionBundleAnim;

	[Token(Token = "0x4017A7A")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton InfoButton;

	[Token(Token = "0x4017A7B")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BonusUI;

	[Token(Token = "0x4017A7C")]
	[FieldOffset(Offset = "0x24")]
	public UILabel BonusAmountLabel;

	[Token(Token = "0x4017A7D")]
	[FieldOffset(Offset = "0x28")]
	public UIButton SubscribeButton;

	[Token(Token = "0x4017A7E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel SubscribeButtonLabel;

	[Token(Token = "0x4017A7F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SubscribeButtonBgYellow;

	[Token(Token = "0x4017A80")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SubscribeButtonMask;

	[Token(Token = "0x4017A81")]
	[FieldOffset(Offset = "0x38")]
	public UITable PricingTable;

	[Token(Token = "0x4017A82")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017A83")]
	[FieldOffset(Offset = "0x40")]
	public UILabel PeriodLabel;

	[Token(Token = "0x4017A84")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ClaimButton;

	[Token(Token = "0x4017A85")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ClaimButtonMask;

	[Token(Token = "0x4017A86")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ClaimButtonLabel;

	[Token(Token = "0x4017A87")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ClaimButtonBgYellow;

	[Token(Token = "0x4017A88")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid ContentContainer;

	[Token(Token = "0x4017A89")]
	[FieldOffset(Offset = "0x58")]
	public UILabel NameLabel;

	[Token(Token = "0x4017A8A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel DescLabel;

	[Token(Token = "0x4017A8B")]
	[FieldOffset(Offset = "0x60")]
	public UITexture BgTexture;

	[Token(Token = "0x4017A8C")]
	[FieldOffset(Offset = "0x64")]
	public GameObject AccountHold;

	[Token(Token = "0x4017A8D")]
	[FieldOffset(Offset = "0x68")]
	public UIButton FixOnHoldButton;

	[Token(Token = "0x4017A8E")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton GracePeriodButton;

	[Token(Token = "0x4017A8F")]
	[FieldOffset(Offset = "0x70")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016E7C")]
	[Address(RVA = "0x29E4650", Offset = "0x29E4650", VA = "0x29E4650")]
	public UIPaymentSubscriptionBundleView()
	{
	}

	[Token(Token = "0x6016E7D")]
	[Address(RVA = "0x29E4658", Offset = "0x29E4658", VA = "0x29E4658", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E7E")]
	[Address(RVA = "0x29E5070", Offset = "0x29E5070", VA = "0x29E5070")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
