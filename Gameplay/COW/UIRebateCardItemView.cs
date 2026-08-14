using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003947")]
public class UIRebateCardItemView : UIBaseView
{
	[Token(Token = "0x4017F7F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MonthCardBg;

	[Token(Token = "0x4017F80")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WeekCardBg;

	[Token(Token = "0x4017F81")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RedeemContainer;

	[Token(Token = "0x4017F82")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RedeemButton_RebateCardTint;

	[Token(Token = "0x4017F83")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OwnedDays;

	[Token(Token = "0x4017F84")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OwnedDaysLabel;

	[Token(Token = "0x4017F85")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel RebateCardNameLabel;

	[Token(Token = "0x4017F86")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LeftTopSprite_RebateCardTint;

	[Token(Token = "0x4017F87")]
	[FieldOffset(Offset = "0x34")]
	public UISprite RightTopSprite;

	[Token(Token = "0x4017F88")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RebateRateLabel;

	[Token(Token = "0x4017F89")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RightBottomSprite;

	[Token(Token = "0x4017F8A")]
	[FieldOffset(Offset = "0x40")]
	public UIWidget BuyInfoContainer;

	[Token(Token = "0x4017F8B")]
	[FieldOffset(Offset = "0x44")]
	public UISprite RebateInfo;

	[Token(Token = "0x4017F8C")]
	[FieldOffset(Offset = "0x48")]
	public UIButton GracePeriodButton;

	[Token(Token = "0x4017F8D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject AccountHold;

	[Token(Token = "0x4017F8E")]
	[FieldOffset(Offset = "0x50")]
	public UIButton FixOnHoldButton;

	[Token(Token = "0x4017F8F")]
	[FieldOffset(Offset = "0x54")]
	public GameObject Effect_Diamond;

	[Token(Token = "0x4017F90")]
	[FieldOffset(Offset = "0x58")]
	public UISprite RedeemAmount;

	[Token(Token = "0x4017F91")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel RedeemAmountLabel;

	[Token(Token = "0x4017F92")]
	[FieldOffset(Offset = "0x60")]
	public UISprite TotalAmount;

	[Token(Token = "0x4017F93")]
	[FieldOffset(Offset = "0x64")]
	public UILabel TotalAmountLabel;

	[Token(Token = "0x4017F94")]
	[FieldOffset(Offset = "0x68")]
	public UISprite WeekCardSprite;

	[Token(Token = "0x4017F95")]
	[FieldOffset(Offset = "0x6C")]
	public UISprite MonthCardSprite;

	[Token(Token = "0x4017F96")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnPurchase;

	[Token(Token = "0x4017F97")]
	[FieldOffset(Offset = "0x74")]
	public UILabel LabelPurchaseHint;

	[Token(Token = "0x4017F98")]
	[FieldOffset(Offset = "0x78")]
	public Animator AnimatorForRenewal;

	[Token(Token = "0x4017F99")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite PurchaseDisabledBG;

	[Token(Token = "0x4017F9A")]
	[FieldOffset(Offset = "0x80")]
	public UILabel PriceLabel_Disabled;

	[Token(Token = "0x4017F9B")]
	[FieldOffset(Offset = "0x84")]
	public UISprite PurchaseEnabledBG;

	[Token(Token = "0x4017F9C")]
	[FieldOffset(Offset = "0x88")]
	public UILabel PriceLabel_Enabled;

	[Token(Token = "0x4017F9D")]
	[FieldOffset(Offset = "0x8C")]
	public UITable Descs;

	[Token(Token = "0x4017F9E")]
	[FieldOffset(Offset = "0x90")]
	public UILabel LabelMonthCardDesc0;

	[Token(Token = "0x4017F9F")]
	[FieldOffset(Offset = "0x94")]
	public UILabel LabelMonthCardDesc1;

	[Token(Token = "0x4017FA0")]
	[FieldOffset(Offset = "0x98")]
	public UILabel LabelMonthCardDesc2;

	[Token(Token = "0x4017FA1")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel LabelMonthCardDesc3;

	[Token(Token = "0x4017FA2")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel LabelMonthCardDesc4;

	[Token(Token = "0x4017FA3")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel LabelMonthCardDesc5;

	[Token(Token = "0x4017FA4")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget SubscriptionWidget;

	[Token(Token = "0x4017FA5")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton SubscriptionHintButton;

	[Token(Token = "0x4017FA6")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite SubscriptionTips;

	[Token(Token = "0x4017FA7")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite SubscriptionBonus;

	[Token(Token = "0x4017FA8")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel SubscriptionBonusAmountLabel;

	[Token(Token = "0x4017FA9")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel SubscriptionToggleText;

	[Token(Token = "0x4017FAA")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton SubscriptionToggleBox;

	[Token(Token = "0x4017FAB")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite SubscriptionToggleTick;

	[Token(Token = "0x6016F7C")]
	[Address(RVA = "0x1E3FF3C", Offset = "0x1E3FF3C", VA = "0x1E3FF3C")]
	public UIRebateCardItemView()
	{
	}

	[Token(Token = "0x6016F7D")]
	[Address(RVA = "0x1E3FF44", Offset = "0x1E3FF44", VA = "0x1E3FF44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F7E")]
	[Address(RVA = "0x1E41124", Offset = "0x1E41124", VA = "0x1E41124")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
