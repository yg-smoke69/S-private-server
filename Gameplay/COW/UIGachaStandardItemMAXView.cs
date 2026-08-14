using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003598")]
public class UIGachaStandardItemMAXView : UIBaseView
{
	[Token(Token = "0x4015589")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x401558A")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x401558B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject VFX;

	[Token(Token = "0x401558C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject GreyBg;

	[Token(Token = "0x401558D")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HighLightBG;

	[Token(Token = "0x401558E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NewLabel;

	[Token(Token = "0x401558F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LimitedLabel;

	[Token(Token = "0x4015590")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LimitedPurchaseLabel;

	[Token(Token = "0x4015591")]
	[FieldOffset(Offset = "0x34")]
	public GameObject HotLabel;

	[Token(Token = "0x4015592")]
	[FieldOffset(Offset = "0x38")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4015593")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject EarlyBirdLabel;

	[Token(Token = "0x4015594")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ExpireTime;

	[Token(Token = "0x4015595")]
	[FieldOffset(Offset = "0x44")]
	public UISprite QualityBG;

	[Token(Token = "0x4015596")]
	[FieldOffset(Offset = "0x48")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4015597")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x4015598")]
	[FieldOffset(Offset = "0x50")]
	public GameObject BaseItemView;

	[Token(Token = "0x4015599")]
	[FieldOffset(Offset = "0x54")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x401559A")]
	[FieldOffset(Offset = "0x58")]
	public UISprite VoucherIcon;

	[Token(Token = "0x401559B")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject BaseitemName;

	[Token(Token = "0x401559C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Free;

	[Token(Token = "0x401559D")]
	[FieldOffset(Offset = "0x64")]
	public UIGrid PriceContainer;

	[Token(Token = "0x401559E")]
	[FieldOffset(Offset = "0x68")]
	public Transform GoldContainer;

	[Token(Token = "0x401559F")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel GoldPriceLabel;

	[Token(Token = "0x40155A0")]
	[FieldOffset(Offset = "0x70")]
	public UILabel GoldOriginalPriceLabel;

	[Token(Token = "0x40155A1")]
	[FieldOffset(Offset = "0x74")]
	public Transform DiamondContainer;

	[Token(Token = "0x40155A2")]
	[FieldOffset(Offset = "0x78")]
	public UILabel DiamondPriceLabel;

	[Token(Token = "0x40155A3")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel DiamondOriginalPriceLabel;

	[Token(Token = "0x40155A4")]
	[FieldOffset(Offset = "0x80")]
	public Transform ExchangeContainer;

	[Token(Token = "0x40155A5")]
	[FieldOffset(Offset = "0x84")]
	public UILabel ExchangePriceLabel;

	[Token(Token = "0x40155A6")]
	[FieldOffset(Offset = "0x88")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x40155A7")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject GemsAndGoldContainer;

	[Token(Token = "0x40155A8")]
	[FieldOffset(Offset = "0x90")]
	public UILabel DualCurrencyGoldPrice;

	[Token(Token = "0x40155A9")]
	[FieldOffset(Offset = "0x94")]
	public UILabel DualCurrencyGemsPrice;

	[Token(Token = "0x40155AA")]
	[FieldOffset(Offset = "0x98")]
	public GameObject CheckIcon;

	[Token(Token = "0x40155AB")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject OverDueTitle;

	[Token(Token = "0x40155AC")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject LockedTitle;

	[Token(Token = "0x40155AD")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject OwnedTitle;

	[Token(Token = "0x40155AE")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject ClaimedTitle;

	[Token(Token = "0x40155AF")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject LimitedTitle;

	[Token(Token = "0x40155B0")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel CanNotEquipTitle;

	[Token(Token = "0x40155B1")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject PreviewFemale;

	[Token(Token = "0x40155B2")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject PreviewMale;

	[Token(Token = "0x40155B3")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject PreviewCommon;

	[Token(Token = "0x40155B4")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject WebTitleContainer;

	[Token(Token = "0x40155B5")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite RankIcon;

	[Token(Token = "0x40155B6")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite Descargar;

	[Token(Token = "0x40155B7")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel ClanLevelLabel;

	[Token(Token = "0x40155B8")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite IPTag;

	[Token(Token = "0x40155B9")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject DiscountEffect;

	[Token(Token = "0x40155BA")]
	[FieldOffset(Offset = "0xD8")]
	public UITipsButton Tips;

	[Token(Token = "0x40155BB")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016478")]
	[Address(RVA = "0x2A2C8B0", Offset = "0x2A2C8B0", VA = "0x2A2C8B0")]
	public UIGachaStandardItemMAXView()
	{
	}

	[Token(Token = "0x6016479")]
	[Address(RVA = "0x2A2C8B8", Offset = "0x2A2C8B8", VA = "0x2A2C8B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601647A")]
	[Address(RVA = "0x2A2DB94", Offset = "0x2A2DB94", VA = "0x2A2DB94")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
