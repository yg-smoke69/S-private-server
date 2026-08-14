using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039ED")]
public class UIStandardItemMAXBView : UIBaseView
{
	[Token(Token = "0x4018631")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018632")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4018633")]
	[FieldOffset(Offset = "0x1C")]
	public Animation Animation;

	[Token(Token = "0x4018634")]
	[FieldOffset(Offset = "0x20")]
	public GameObject VFX;

	[Token(Token = "0x4018635")]
	[FieldOffset(Offset = "0x24")]
	public GameObject GreyBg;

	[Token(Token = "0x4018636")]
	[FieldOffset(Offset = "0x28")]
	public GameObject HighLightBG;

	[Token(Token = "0x4018637")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NewLabel;

	[Token(Token = "0x4018638")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LimitedLabel;

	[Token(Token = "0x4018639")]
	[FieldOffset(Offset = "0x34")]
	public GameObject LimitedPurchaseLabel;

	[Token(Token = "0x401863A")]
	[FieldOffset(Offset = "0x38")]
	public GameObject HotLabel;

	[Token(Token = "0x401863B")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x401863C")]
	[FieldOffset(Offset = "0x40")]
	public GameObject DiscountVFX;

	[Token(Token = "0x401863D")]
	[FieldOffset(Offset = "0x44")]
	public GameObject EarlyBirdLabel;

	[Token(Token = "0x401863E")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ExpireTime;

	[Token(Token = "0x401863F")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite QualityBG;

	[Token(Token = "0x4018640")]
	[FieldOffset(Offset = "0x50")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4018641")]
	[FieldOffset(Offset = "0x54")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x4018642")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BaseItemView;

	[Token(Token = "0x4018643")]
	[FieldOffset(Offset = "0x5C")]
	public BaseItemView2 BaseInfoView;

	[Token(Token = "0x4018644")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BaseitemName;

	[Token(Token = "0x4018645")]
	[FieldOffset(Offset = "0x64")]
	public GameObject Free;

	[Token(Token = "0x4018646")]
	[FieldOffset(Offset = "0x68")]
	public UIGrid PriceContainer;

	[Token(Token = "0x4018647")]
	[FieldOffset(Offset = "0x6C")]
	public UIWidget GoldContainer;

	[Token(Token = "0x4018648")]
	[FieldOffset(Offset = "0x70")]
	public UILabel GoldPriceLabel;

	[Token(Token = "0x4018649")]
	[FieldOffset(Offset = "0x74")]
	public UILabel GoldOriginalPriceLabel;

	[Token(Token = "0x401864A")]
	[FieldOffset(Offset = "0x78")]
	public UIWidget DiamondContainer;

	[Token(Token = "0x401864B")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel DiamondPriceLabel;

	[Token(Token = "0x401864C")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DiamondOriginalPriceLabel;

	[Token(Token = "0x401864D")]
	[FieldOffset(Offset = "0x84")]
	public Transform ExchangeContainer;

	[Token(Token = "0x401864E")]
	[FieldOffset(Offset = "0x88")]
	public UILabel ExchangePriceLabel;

	[Token(Token = "0x401864F")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x4018650")]
	[FieldOffset(Offset = "0x90")]
	public GameObject GemsAndGoldContainer;

	[Token(Token = "0x4018651")]
	[FieldOffset(Offset = "0x94")]
	public UILabel DualCurrencyGoldPrice;

	[Token(Token = "0x4018652")]
	[FieldOffset(Offset = "0x98")]
	public UILabel DualCurrencyGemsPrice;

	[Token(Token = "0x4018653")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject CheckIcon;

	[Token(Token = "0x4018654")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject OverDueTitle;

	[Token(Token = "0x4018655")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject LockedTitle;

	[Token(Token = "0x4018656")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject OwnedTitle;

	[Token(Token = "0x4018657")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject ClaimedTitle;

	[Token(Token = "0x4018658")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject LimitedTitle;

	[Token(Token = "0x4018659")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel CanNotEquipTitle;

	[Token(Token = "0x401865A")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject PreviewFemale;

	[Token(Token = "0x401865B")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject PreviewMale;

	[Token(Token = "0x401865C")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject PreviewCommon;

	[Token(Token = "0x401865D")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject OtherChannelContainer;

	[Token(Token = "0x401865E")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel OtherChannelTitle;

	[Token(Token = "0x401865F")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite OtherChannelIcon;

	[Token(Token = "0x4018660")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite RankIcon;

	[Token(Token = "0x4018661")]
	[FieldOffset(Offset = "0xD4")]
	public UISprite Descargar;

	[Token(Token = "0x4018662")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel ClanLevelLabel;

	[Token(Token = "0x4018663")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite IPTag;

	[Token(Token = "0x4018664")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject DiscountEffect;

	[Token(Token = "0x4018665")]
	[FieldOffset(Offset = "0xE4")]
	public UITipsButton Tips;

	[Token(Token = "0x4018666")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite LinkTag;

	[Token(Token = "0x4018667")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x4018668")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite DescargarCenter;

	[Token(Token = "0x4018669")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel NotReadyLabel;

	[Token(Token = "0x401866A")]
	[FieldOffset(Offset = "0xF8")]
	public UISprite TokenTag;

	[Token(Token = "0x401866B")]
	[FieldOffset(Offset = "0xFC")]
	public UIButton TokenTagBtn;

	[Token(Token = "0x401866C")]
	[FieldOffset(Offset = "0x100")]
	public GameObject FlashGemsContainer;

	[Token(Token = "0x401866D")]
	[FieldOffset(Offset = "0x104")]
	public GameObject FlashGemsAndGemsContainer;

	[Token(Token = "0x401866E")]
	[FieldOffset(Offset = "0x108")]
	public GameObject FlashGemsOnlyContainer;

	[Token(Token = "0x401866F")]
	[FieldOffset(Offset = "0x10C")]
	public UILabel FlashGemsAndGemsFlashGemsPrice;

	[Token(Token = "0x4018670")]
	[FieldOffset(Offset = "0x110")]
	public UILabel FlashGemsAndGemsGemsPrice;

	[Token(Token = "0x4018671")]
	[FieldOffset(Offset = "0x114")]
	public GameObject Plus;

	[Token(Token = "0x4018672")]
	[FieldOffset(Offset = "0x118")]
	public UILabel FlashGemsOnlyPriceLabel;

	[Token(Token = "0x601716D")]
	[Address(RVA = "0x2069B68", Offset = "0x2069B68", VA = "0x2069B68")]
	public UIStandardItemMAXBView()
	{
	}

	[Token(Token = "0x601716E")]
	[Address(RVA = "0x2069B70", Offset = "0x2069B70", VA = "0x2069B70", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601716F")]
	[Address(RVA = "0x206B400", Offset = "0x206B400", VA = "0x206B400")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
