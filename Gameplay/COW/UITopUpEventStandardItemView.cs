using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A02")]
public class UITopUpEventStandardItemView : UIBaseView
{
	[Token(Token = "0x401875D")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x401875E")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x401875F")]
	[FieldOffset(Offset = "0x1C")]
	public Animation Animation;

	[Token(Token = "0x4018760")]
	[FieldOffset(Offset = "0x20")]
	public GameObject VFX;

	[Token(Token = "0x4018761")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GreyBg;

	[Token(Token = "0x4018762")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HighLightBG;

	[Token(Token = "0x4018763")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NewLabel;

	[Token(Token = "0x4018764")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LimitedLabel;

	[Token(Token = "0x4018765")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LimitedPurchaseLabel;

	[Token(Token = "0x4018766")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HotLabel;

	[Token(Token = "0x4018767")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4018768")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DiscountVFX;

	[Token(Token = "0x4018769")]
	[FieldOffset(Offset = "0x44")]
	public GameObject EarlyBirdLabel;

	[Token(Token = "0x401876A")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ExpireTime;

	[Token(Token = "0x401876B")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite QualityBG;

	[Token(Token = "0x401876C")]
	[FieldOffset(Offset = "0x50")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x401876D")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x401876E")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BaseItemView;

	[Token(Token = "0x401876F")]
	[FieldOffset(Offset = "0x5C")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4018770")]
	[FieldOffset(Offset = "0x60")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4018771")]
	[FieldOffset(Offset = "0x64")]
	public GameObject BaseitemName;

	[Token(Token = "0x4018772")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Free;

	[Token(Token = "0x4018773")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid PriceContainer;

	[Token(Token = "0x4018774")]
	[FieldOffset(Offset = "0x70")]
	public Transform GoldContainer;

	[Token(Token = "0x4018775")]
	[FieldOffset(Offset = "0x74")]
	public UILabel GoldPriceLabel;

	[Token(Token = "0x4018776")]
	[FieldOffset(Offset = "0x78")]
	public UILabel GoldOriginalPriceLabel;

	[Token(Token = "0x4018777")]
	[FieldOffset(Offset = "0x7C")]
	public Transform DiamondContainer;

	[Token(Token = "0x4018778")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DiamondPriceLabel;

	[Token(Token = "0x4018779")]
	[FieldOffset(Offset = "0x84")]
	public UILabel DiamondOriginalPriceLabel;

	[Token(Token = "0x401877A")]
	[FieldOffset(Offset = "0x88")]
	public Transform ExchangeContainer;

	[Token(Token = "0x401877B")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ExchangePriceLabel;

	[Token(Token = "0x401877C")]
	[FieldOffset(Offset = "0x90")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x401877D")]
	[FieldOffset(Offset = "0x94")]
	public GameObject GemsAndGoldContainer;

	[Token(Token = "0x401877E")]
	[FieldOffset(Offset = "0x98")]
	public UILabel DualCurrencyGoldPrice;

	[Token(Token = "0x401877F")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel DualCurrencyGemsPrice;

	[Token(Token = "0x4018780")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject CheckIcon;

	[Token(Token = "0x4018781")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject OverDueTitle;

	[Token(Token = "0x4018782")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject LockedTitle;

	[Token(Token = "0x4018783")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject OwnedTitle;

	[Token(Token = "0x4018784")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject ClaimedTitle;

	[Token(Token = "0x4018785")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject LimitedTitle;

	[Token(Token = "0x4018786")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel CanNotEquipTitle;

	[Token(Token = "0x4018787")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject PreviewFemale;

	[Token(Token = "0x4018788")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject PreviewMale;

	[Token(Token = "0x4018789")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject PreviewCommon;

	[Token(Token = "0x401878A")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject OtherChannelContainer;

	[Token(Token = "0x401878B")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel OtherChannelTitle;

	[Token(Token = "0x401878C")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite OtherChannelIcon;

	[Token(Token = "0x401878D")]
	[FieldOffset(Offset = "0xD4")]
	public UISprite RankIcon;

	[Token(Token = "0x401878E")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite Descargar;

	[Token(Token = "0x401878F")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel ClanLevelLabel;

	[Token(Token = "0x4018790")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject DiscountEffect;

	[Token(Token = "0x4018791")]
	[FieldOffset(Offset = "0xE4")]
	public UITipsButton Tips;

	[Token(Token = "0x4018792")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite IPTag;

	[Token(Token = "0x4018793")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x60171AC")]
	[Address(RVA = "0x2AFA774", Offset = "0x2AFA774", VA = "0x2AFA774")]
	public UITopUpEventStandardItemView()
	{
	}

	[Token(Token = "0x60171AD")]
	[Address(RVA = "0x2AFA77C", Offset = "0x2AFA77C", VA = "0x2AFA77C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171AE")]
	[Address(RVA = "0x2AFBBCC", Offset = "0x2AFBBCC", VA = "0x2AFBBCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
