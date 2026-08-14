using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003876")]
public class UIMallPurchaseView : UIBaseView
{
	[Token(Token = "0x40173BA")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x40173BB")]
	[FieldOffset(Offset = "0x18")]
	public UILabel limitedPurchaseLabel;

	[Token(Token = "0x40173BC")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel purchaseDescLabel;

	[Token(Token = "0x40173BD")]
	[FieldOffset(Offset = "0x20")]
	public Transform ItemContainer;

	[Token(Token = "0x40173BE")]
	[FieldOffset(Offset = "0x24")]
	public UIButton GoldPurchaseBtn;

	[Token(Token = "0x40173BF")]
	[FieldOffset(Offset = "0x28")]
	public UILabel GoldPrice;

	[Token(Token = "0x40173C0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel GoldBefore;

	[Token(Token = "0x40173C1")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GoldVoucherEffect;

	[Token(Token = "0x40173C2")]
	[FieldOffset(Offset = "0x34")]
	public UIButton GemsPurchaseBtn;

	[Token(Token = "0x40173C3")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GemsPrice;

	[Token(Token = "0x40173C4")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel GemsBefore;

	[Token(Token = "0x40173C5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DiamondVoucherEffect;

	[Token(Token = "0x40173C6")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ExchangeBtn;

	[Token(Token = "0x40173C7")]
	[FieldOffset(Offset = "0x48")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x40173C8")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ExchagneLabel;

	[Token(Token = "0x40173C9")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ClanExchangeBtn;

	[Token(Token = "0x40173CA")]
	[FieldOffset(Offset = "0x54")]
	public UISprite ClanExchangeIcon;

	[Token(Token = "0x40173CB")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ClanExchagneLabel;

	[Token(Token = "0x40173CC")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel ClanDiamondLabel;

	[Token(Token = "0x40173CD")]
	[FieldOffset(Offset = "0x60")]
	public GameObject GoldAndGems;

	[Token(Token = "0x40173CE")]
	[FieldOffset(Offset = "0x64")]
	public UIButton DualCurrencyGoldPurchaseBtn;

	[Token(Token = "0x40173CF")]
	[FieldOffset(Offset = "0x68")]
	public UILabel DualCurrencyGoldPrice;

	[Token(Token = "0x40173D0")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject DualCurrencyGoldVoucherEffect;

	[Token(Token = "0x40173D1")]
	[FieldOffset(Offset = "0x70")]
	public UILabel DualCurrencyGoldPriceBefore;

	[Token(Token = "0x40173D2")]
	[FieldOffset(Offset = "0x74")]
	public UIButton DualCurrencyGemsPurchaseBtn;

	[Token(Token = "0x40173D3")]
	[FieldOffset(Offset = "0x78")]
	public UILabel DualCurrencyGemsPrice;

	[Token(Token = "0x40173D4")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DualCurrencyDiamondVoucherEffect;

	[Token(Token = "0x40173D5")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DualCurrencyGemsPriceBefore;

	[Token(Token = "0x40173D6")]
	[FieldOffset(Offset = "0x84")]
	public UIButton ForgeExchangeBtn;

	[Token(Token = "0x40173D7")]
	[FieldOffset(Offset = "0x88")]
	public UISprite Material2Icon;

	[Token(Token = "0x40173D8")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite Material1Icon;

	[Token(Token = "0x40173D9")]
	[FieldOffset(Offset = "0x90")]
	public UILabel Material2Cnt;

	[Token(Token = "0x40173DA")]
	[FieldOffset(Offset = "0x94")]
	public UILabel Material1Cnt;

	[Token(Token = "0x40173DB")]
	[FieldOffset(Offset = "0x98")]
	public GameObject Add;

	[Token(Token = "0x40173DC")]
	[FieldOffset(Offset = "0x9C")]
	public UIVoucher Voucher;

	[Token(Token = "0x40173DD")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject ModifyNumContainer;

	[Token(Token = "0x40173DE")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton PlusBtn;

	[Token(Token = "0x40173DF")]
	[FieldOffset(Offset = "0xA8")]
	public UIInput CountInput;

	[Token(Token = "0x40173E0")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel CountLabel;

	[Token(Token = "0x40173E1")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton MinusBtn;

	[Token(Token = "0x40173E2")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton MaxBtn;

	[Token(Token = "0x40173E3")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel LabelMax;

	[Token(Token = "0x40173E4")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton AddTenBtn;

	[Token(Token = "0x40173E5")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject VoucherBound;

	[Token(Token = "0x40173E6")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject GoldWithDiscount;

	[Token(Token = "0x40173E7")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject GoldWithoutDiscount;

	[Token(Token = "0x40173E8")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel GoldDiscountPrice;

	[Token(Token = "0x40173E9")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject GemWithoutDiscount;

	[Token(Token = "0x40173EA")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel GemsDiscountPrice;

	[Token(Token = "0x40173EB")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject GemWithDiscount;

	[Token(Token = "0x40173EC")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel DualCurrencyGoldDiscountPrice;

	[Token(Token = "0x40173ED")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject DualCurrencyGoldWithoutDiscount;

	[Token(Token = "0x40173EE")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject DualCurrencyGoldWithDiscount;

	[Token(Token = "0x40173EF")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject DualCurrencyGemsWithDiscount;

	[Token(Token = "0x40173F0")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject DualCurrencyGemsWithoutDiscount;

	[Token(Token = "0x40173F1")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel DualCurrencyGemsDiscountPrice;

	[Token(Token = "0x6016D0D")]
	[Address(RVA = "0x226836C", Offset = "0x226836C", VA = "0x226836C")]
	public UIMallPurchaseView()
	{
	}

	[Token(Token = "0x6016D0E")]
	[Address(RVA = "0x2268374", Offset = "0x2268374", VA = "0x2268374", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D0F")]
	[Address(RVA = "0x22698D4", Offset = "0x22698D4", VA = "0x22698D4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
