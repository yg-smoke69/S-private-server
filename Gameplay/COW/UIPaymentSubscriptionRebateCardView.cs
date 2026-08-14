using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038F6")]
public class UIPaymentSubscriptionRebateCardView : UIBaseView
{
	[Token(Token = "0x4017AB0")]
	[FieldOffset(Offset = "0x14")]
	public GameObject UIPaymentSubscriptionRebateCard;

	[Token(Token = "0x4017AB1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject AccountHold;

	[Token(Token = "0x4017AB2")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton FixOnHoldButton;

	[Token(Token = "0x4017AB3")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GracePeriodButton;

	[Token(Token = "0x4017AB4")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TotalAmount;

	[Token(Token = "0x4017AB5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RebateRateLabel;

	[Token(Token = "0x4017AB6")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel TotalAmountLabel;

	[Token(Token = "0x4017AB7")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTextureExt MainAdNetworkTexture;

	[Token(Token = "0x4017AB8")]
	[FieldOffset(Offset = "0x34")]
	public UITable PricingTable;

	[Token(Token = "0x4017AB9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017ABA")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PeriodLabel;

	[Token(Token = "0x4017ABB")]
	[FieldOffset(Offset = "0x40")]
	public UIButton InfoButton;

	[Token(Token = "0x4017ABC")]
	[FieldOffset(Offset = "0x44")]
	public UISprite BonusUI;

	[Token(Token = "0x4017ABD")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BonusAmountLabel;

	[Token(Token = "0x4017ABE")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton SubscribeButton;

	[Token(Token = "0x4017ABF")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SubscribeButtonMask;

	[Token(Token = "0x4017AC0")]
	[FieldOffset(Offset = "0x54")]
	public UILabel SubscribeButtonLabel;

	[Token(Token = "0x4017AC1")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BtnOperateBgYellow;

	[Token(Token = "0x4017AC2")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel TotalValueLabel;

	[Token(Token = "0x4017AC3")]
	[FieldOffset(Offset = "0x60")]
	public UILabel MorePirzeLabel;

	[Token(Token = "0x6016E8B")]
	[Address(RVA = "0x29ED1D4", Offset = "0x29ED1D4", VA = "0x29ED1D4")]
	public UIPaymentSubscriptionRebateCardView()
	{
	}

	[Token(Token = "0x6016E8C")]
	[Address(RVA = "0x29ED1DC", Offset = "0x29ED1DC", VA = "0x29ED1DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E8D")]
	[Address(RVA = "0x29EDA80", Offset = "0x29EDA80", VA = "0x29EDA80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
