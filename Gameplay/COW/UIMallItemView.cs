using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003873")]
public class UIMallItemView : UIBaseView
{
	[Token(Token = "0x4017386")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017387")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4017388")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NormalContainer;

	[Token(Token = "0x4017389")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x401738A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject HighLightBG;

	[Token(Token = "0x401738B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject timePanel;

	[Token(Token = "0x401738C")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel time;

	[Token(Token = "0x401738D")]
	[FieldOffset(Offset = "0x30")]
	public UISprite BG;

	[Token(Token = "0x401738E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BG_grey;

	[Token(Token = "0x401738F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject LimitedTitle;

	[Token(Token = "0x4017390")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PreviewTitle;

	[Token(Token = "0x4017391")]
	[FieldOffset(Offset = "0x40")]
	public UISprite Descargar;

	[Token(Token = "0x4017392")]
	[FieldOffset(Offset = "0x44")]
	public UIButton DownloadBtn;

	[Token(Token = "0x4017393")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ClanLevelTitle;

	[Token(Token = "0x4017394")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ItemIcon;

	[Token(Token = "0x4017395")]
	[FieldOffset(Offset = "0x50")]
	public UISprite HeadIcon;

	[Token(Token = "0x4017396")]
	[FieldOffset(Offset = "0x54")]
	public UISprite BannerIcon;

	[Token(Token = "0x4017397")]
	[FieldOffset(Offset = "0x58")]
	public UISprite DebrisIcon;

	[Token(Token = "0x4017398")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite VehicleSkinIcon;

	[Token(Token = "0x4017399")]
	[FieldOffset(Offset = "0x60")]
	public UISprite WeaponSkinIcon;

	[Token(Token = "0x401739A")]
	[FieldOffset(Offset = "0x64")]
	public Transform GoldContainer;

	[Token(Token = "0x401739B")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GoldIcon;

	[Token(Token = "0x401739C")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel GoldPritceLabel;

	[Token(Token = "0x401739D")]
	[FieldOffset(Offset = "0x70")]
	public Transform DiamondContainer;

	[Token(Token = "0x401739E")]
	[FieldOffset(Offset = "0x74")]
	public UILabel DiamondPritceLabel;

	[Token(Token = "0x401739F")]
	[FieldOffset(Offset = "0x78")]
	public GameObject DiamonIcon;

	[Token(Token = "0x40173A0")]
	[FieldOffset(Offset = "0x7C")]
	public Transform ExchangeContainer;

	[Token(Token = "0x40173A1")]
	[FieldOffset(Offset = "0x80")]
	public UILabel ExchangePriceLabel;

	[Token(Token = "0x40173A2")]
	[FieldOffset(Offset = "0x84")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x40173A3")]
	[FieldOffset(Offset = "0x88")]
	public Transform ClanDiamondContainer;

	[Token(Token = "0x40173A4")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel ClanDiamondPriceLabel;

	[Token(Token = "0x40173A5")]
	[FieldOffset(Offset = "0x90")]
	public UISprite ClanDiamondIcon;

	[Token(Token = "0x40173A6")]
	[FieldOffset(Offset = "0x94")]
	public GameObject UniquedTitle;

	[Token(Token = "0x40173A7")]
	[FieldOffset(Offset = "0x98")]
	public GameObject DiscountItemIcon;

	[Token(Token = "0x40173A8")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject WebTitleContainer;

	[Token(Token = "0x40173A9")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject OverDueTitle;

	[Token(Token = "0x40173AA")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite DiscountTag;

	[Token(Token = "0x40173AB")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel TagLabel;

	[Token(Token = "0x40173AC")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite NewTag;

	[Token(Token = "0x40173AD")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite HotTag;

	[Token(Token = "0x40173AE")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite LimitTag;

	[Token(Token = "0x40173AF")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite LimitCountTag;

	[Token(Token = "0x40173B0")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite EarlyAccess;

	[Token(Token = "0x40173B1")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite RankIcon;

	[Token(Token = "0x40173B2")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite VoucherIcon;

	[Token(Token = "0x40173B3")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite RedEnvelopeIcon;

	[Token(Token = "0x40173B4")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject DefaultContainer;

	[Token(Token = "0x6016D04")]
	[Address(RVA = "0x2261B04", Offset = "0x2261B04", VA = "0x2261B04")]
	public UIMallItemView()
	{
	}

	[Token(Token = "0x6016D05")]
	[Address(RVA = "0x2261B0C", Offset = "0x2261B0C", VA = "0x2261B0C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D06")]
	[Address(RVA = "0x2262CB8", Offset = "0x2262CB8", VA = "0x2262CB8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
