using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F2")]
public class UIPaymentSubscriptionElitePassView : UIBaseView
{
	[Token(Token = "0x4017A90")]
	[FieldOffset(Offset = "0x14")]
	public GameObject AccountHold;

	[Token(Token = "0x4017A91")]
	[FieldOffset(Offset = "0x18")]
	public UIButton FixOnHoldButton;

	[Token(Token = "0x4017A92")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GracePeriodButton;

	[Token(Token = "0x4017A93")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x4017A94")]
	[FieldOffset(Offset = "0x24")]
	public UITable PricingTable;

	[Token(Token = "0x4017A95")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017A96")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PeriodLabel;

	[Token(Token = "0x4017A97")]
	[FieldOffset(Offset = "0x30")]
	public UIButton InfoButton;

	[Token(Token = "0x4017A98")]
	[FieldOffset(Offset = "0x34")]
	public UIButton SubscribeButton;

	[Token(Token = "0x4017A99")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SubscribeButtonMask;

	[Token(Token = "0x4017A9A")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SubscribeButtonLabel;

	[Token(Token = "0x4017A9B")]
	[FieldOffset(Offset = "0x40")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x4017A9C")]
	[FieldOffset(Offset = "0x44")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x4017A9D")]
	[FieldOffset(Offset = "0x48")]
	public UISprite BonusUI;

	[Token(Token = "0x4017A9E")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BonusAmountLabel;

	[Token(Token = "0x4017A9F")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ToTalWorth;

	[Token(Token = "0x4017AA0")]
	[FieldOffset(Offset = "0x54")]
	public UIGrid RewardItems;

	[Token(Token = "0x6016E7F")]
	[Address(RVA = "0x29E6EB0", Offset = "0x29E6EB0", VA = "0x29E6EB0")]
	public UIPaymentSubscriptionElitePassView()
	{
	}

	[Token(Token = "0x6016E80")]
	[Address(RVA = "0x29E6EB8", Offset = "0x29E6EB8", VA = "0x29E6EB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E81")]
	[Address(RVA = "0x29E7648", Offset = "0x29E7648", VA = "0x29E7648")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
