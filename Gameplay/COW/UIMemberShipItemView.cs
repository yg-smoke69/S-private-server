using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038A5")]
public class UIMemberShipItemView : UIBaseView
{
	[Token(Token = "0x40176A8")]
	[FieldOffset(Offset = "0x14")]
	public GameObject CountDown;

	[Token(Token = "0x40176A9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel RebateCardTime;

	[Token(Token = "0x40176AA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject WeekCardBg;

	[Token(Token = "0x40176AB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WeekDecoration;

	[Token(Token = "0x40176AC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject MonthCardBg;

	[Token(Token = "0x40176AD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject MonthDecoration;

	[Token(Token = "0x40176AE")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget BuyInfoContainer;

	[Token(Token = "0x40176AF")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget RebateInfo;

	[Token(Token = "0x40176B0")]
	[FieldOffset(Offset = "0x34")]
	public UIButton GracePeriodButton;

	[Token(Token = "0x40176B1")]
	[FieldOffset(Offset = "0x38")]
	public GameObject AccountHold;

	[Token(Token = "0x40176B2")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton FixOnHoldButton;

	[Token(Token = "0x40176B3")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnPurchase;

	[Token(Token = "0x40176B4")]
	[FieldOffset(Offset = "0x44")]
	public UISprite PurchaseDisabledBG;

	[Token(Token = "0x40176B5")]
	[FieldOffset(Offset = "0x48")]
	public UILabel PriceLabel_Disabled;

	[Token(Token = "0x40176B6")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite PurchaseEnabledBG;

	[Token(Token = "0x40176B7")]
	[FieldOffset(Offset = "0x50")]
	public UILabel PriceLabel_Enabled;

	[Token(Token = "0x40176B8")]
	[FieldOffset(Offset = "0x54")]
	public UISprite PurchaseDiscountBG;

	[Token(Token = "0x40176B9")]
	[FieldOffset(Offset = "0x58")]
	public UILabel PriceLabel_Discount;

	[Token(Token = "0x40176BA")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel PriceLabel_Original;

	[Token(Token = "0x40176BB")]
	[FieldOffset(Offset = "0x60")]
	public GameObject CountDownContainer;

	[Token(Token = "0x40176BC")]
	[FieldOffset(Offset = "0x64")]
	public UICountDownLabel CountDownLabel;

	[Token(Token = "0x40176BD")]
	[FieldOffset(Offset = "0x68")]
	public GameObject TotalValue;

	[Token(Token = "0x40176BE")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject SvipHintTotalValue;

	[Token(Token = "0x40176BF")]
	[FieldOffset(Offset = "0x70")]
	public UILabel SvipHintTotalNormalValueLabel;

	[Token(Token = "0x40176C0")]
	[FieldOffset(Offset = "0x74")]
	public UILabel SvipHintTotalSvipValueLabel;

	[Token(Token = "0x40176C1")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TotalValueLabel;

	[Token(Token = "0x40176C2")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton TotalValueTipBtn;

	[Token(Token = "0x40176C3")]
	[FieldOffset(Offset = "0x80")]
	public GameObject InstanteGet;

	[Token(Token = "0x40176C4")]
	[FieldOffset(Offset = "0x84")]
	public UILabel InstanteGetLabel;

	[Token(Token = "0x40176C5")]
	[FieldOffset(Offset = "0x88")]
	public GameObject SignTotal;

	[Token(Token = "0x40176C6")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject SvipHintSignInValue;

	[Token(Token = "0x40176C7")]
	[FieldOffset(Offset = "0x90")]
	public UILabel SvipHintSignInNormalValueLabel;

	[Token(Token = "0x40176C8")]
	[FieldOffset(Offset = "0x94")]
	public UILabel SvipHintSignInSvipValueLabel;

	[Token(Token = "0x40176C9")]
	[FieldOffset(Offset = "0x98")]
	public UILabel SignTotalLabel;

	[Token(Token = "0x40176CA")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject MorePirze;

	[Token(Token = "0x40176CB")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject SvipHintMoreValue;

	[Token(Token = "0x40176CC")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel SvipHintMoreNormalValueLabel;

	[Token(Token = "0x40176CD")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel SvipHintMoreSvipValueLabel;

	[Token(Token = "0x40176CE")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel MorePirzeLabel;

	[Token(Token = "0x40176CF")]
	[FieldOffset(Offset = "0xB0")]
	public UIEasyList EasyList;

	[Token(Token = "0x40176D0")]
	[FieldOffset(Offset = "0xB4")]
	public UIWidget SubscriptionWidget;

	[Token(Token = "0x40176D1")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite SubscriptionBonus;

	[Token(Token = "0x40176D2")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel SubscriptionBonusAmountLabel;

	[Token(Token = "0x40176D3")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel SubscriptionToggleText;

	[Token(Token = "0x40176D4")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton SubscriptionHintButton;

	[Token(Token = "0x40176D5")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite SubscriptionTips;

	[Token(Token = "0x40176D6")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton SubscriptionToggleBox;

	[Token(Token = "0x40176D7")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite SubscriptionToggleTick;

	[Token(Token = "0x40176D8")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel TotalPercentLabel;

	[Token(Token = "0x40176D9")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel TotalWorthLabel;

	[Token(Token = "0x40176DA")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton BtnPurchaseThirdParty;

	[Token(Token = "0x6016D9A")]
	[Address(RVA = "0x26A1658", Offset = "0x26A1658", VA = "0x26A1658")]
	public UIMemberShipItemView()
	{
	}

	[Token(Token = "0x6016D9B")]
	[Address(RVA = "0x26A1660", Offset = "0x26A1660", VA = "0x26A1660", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D9C")]
	[Address(RVA = "0x26A2A20", Offset = "0x26A2A20", VA = "0x26A2A20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
