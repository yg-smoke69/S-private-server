using COW;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003A9F")]
public class UIGachaBuyBtnBaseView : MonoBehaviour
{
	[Token(Token = "0x4018ECD")]
	[FieldOffset(Offset = "0xC")]
	public bool SupportOneBuyButton;

	[Token(Token = "0x4018ECE")]
	[FieldOffset(Offset = "0xD")]
	public bool SupportMultiBuyButton;

	[Token(Token = "0x4018ECF")]
	[FieldOffset(Offset = "0xE")]
	public bool SupportOneBuyFree;

	[Token(Token = "0x4018ED0")]
	[FieldOffset(Offset = "0xF")]
	public bool SupportDiscountBuy;

	[Token(Token = "0x4018ED1")]
	[FieldOffset(Offset = "0x10")]
	public bool SupportCoupon;

	[Token(Token = "0x4018ED2")]
	[FieldOffset(Offset = "0x11")]
	public bool SupportLimitBuy;

	[Token(Token = "0x4018ED3")]
	[FieldOffset(Offset = "0x12")]
	public bool SupportFirstReward;

	[Token(Token = "0x4018ED4")]
	[FieldOffset(Offset = "0x13")]
	public bool SupportExtraReward;

	[Token(Token = "0x4018ED5")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OneBuyBtn;

	[Token(Token = "0x4018ED6")]
	[FieldOffset(Offset = "0x18")]
	public UILabel OneBuyFree;

	[Token(Token = "0x4018ED7")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite OneConsumeTypeIcon;

	[Token(Token = "0x4018ED8")]
	[FieldOffset(Offset = "0x20")]
	public UISprite OneCurrencyIcon;

	[Token(Token = "0x4018ED9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite OneDiscountIcon;

	[Token(Token = "0x4018EDA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel OnePriceLabel;

	[Token(Token = "0x4018EDB")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject OneLimitContainer;

	[Token(Token = "0x4018EDC")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OneLimitPercentLabel;

	[Token(Token = "0x4018EDD")]
	[FieldOffset(Offset = "0x34")]
	public GameObject OneDiscountContainer;

	[Token(Token = "0x4018EDE")]
	[FieldOffset(Offset = "0x38")]
	public UILabel OnePercentLable;

	[Token(Token = "0x4018EDF")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel OneOriginalPriceLabel;

	[Token(Token = "0x4018EE0")]
	[FieldOffset(Offset = "0x40")]
	public UILabel OneDiscountPriceLabel;

	[Token(Token = "0x4018EE1")]
	[FieldOffset(Offset = "0x44")]
	public UILabel OneDiscountFreeLabel;

	[Token(Token = "0x4018EE2")]
	[FieldOffset(Offset = "0x48")]
	public UILabel OneBuyTips;

	[Token(Token = "0x4018EE3")]
	[FieldOffset(Offset = "0x4C")]
	public UICountDownLabel FreeCountdownLabel;

	[Token(Token = "0x4018EE4")]
	[FieldOffset(Offset = "0x50")]
	public Transform StandardLabelPos;

	[Token(Token = "0x4018EE5")]
	[FieldOffset(Offset = "0x54")]
	public UIButton TenBuyBtn;

	[Token(Token = "0x4018EE6")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TenPriceLabel;

	[Token(Token = "0x4018EE7")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite TenConsumeTypeIcon;

	[Token(Token = "0x4018EE8")]
	[FieldOffset(Offset = "0x60")]
	public UISprite TenCurrencyIcon;

	[Token(Token = "0x4018EE9")]
	[FieldOffset(Offset = "0x64")]
	public UISprite TenDiscountIcon;

	[Token(Token = "0x4018EEA")]
	[FieldOffset(Offset = "0x68")]
	public GameObject TenLimitContainer;

	[Token(Token = "0x4018EEB")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel TenLimitPercentLabel;

	[Token(Token = "0x4018EEC")]
	[FieldOffset(Offset = "0x70")]
	public GameObject TenDiscountContainer;

	[Token(Token = "0x4018EED")]
	[FieldOffset(Offset = "0x74")]
	public UILabel TenPercentLable;

	[Token(Token = "0x4018EEE")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TenOriginalPriceLabel;

	[Token(Token = "0x4018EEF")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel TenDiscountPriceLabel;

	[Token(Token = "0x4018EF0")]
	[FieldOffset(Offset = "0x80")]
	public UILabel TenDiscountFreeLabel;

	[Token(Token = "0x4018EF1")]
	[FieldOffset(Offset = "0x84")]
	public UILabel TenBuyLabel;

	[Token(Token = "0x60173A0")]
	[Address(RVA = "0x1474338", Offset = "0x1474338", VA = "0x1474338")]
	public UIGachaBuyBtnBaseView()
	{
	}
}
