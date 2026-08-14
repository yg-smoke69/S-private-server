using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200386D")]
public class UIMallDiscountItemView : UIBaseView
{
	[Token(Token = "0x401731F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4017320")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ItemWidget;

	[Token(Token = "0x4017321")]
	[FieldOffset(Offset = "0x1C")]
	public UITipsButton tipsButton;

	[Token(Token = "0x4017322")]
	[FieldOffset(Offset = "0x20")]
	public BaseItemView BaseInfoView;

	[Token(Token = "0x4017323")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TimaAndCount;

	[Token(Token = "0x4017324")]
	[FieldOffset(Offset = "0x28")]
	public UILabel time;

	[Token(Token = "0x4017325")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite QualityBG;

	[Token(Token = "0x4017326")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Quality;

	[Token(Token = "0x4017327")]
	[FieldOffset(Offset = "0x34")]
	public GameObject BG_grey;

	[Token(Token = "0x4017328")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PreviewFemale;

	[Token(Token = "0x4017329")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject PreviewMale;

	[Token(Token = "0x401732A")]
	[FieldOffset(Offset = "0x40")]
	public UISprite Descargar;

	[Token(Token = "0x401732B")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LimitedTitle;

	[Token(Token = "0x401732C")]
	[FieldOffset(Offset = "0x48")]
	public UIButton DownloadBtn;

	[Token(Token = "0x401732D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject UniquedTitle;

	[Token(Token = "0x401732E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GetTitle;

	[Token(Token = "0x401732F")]
	[FieldOffset(Offset = "0x54")]
	public Transform GoldContainer;

	[Token(Token = "0x4017330")]
	[FieldOffset(Offset = "0x58")]
	public GameObject GoldIcon;

	[Token(Token = "0x4017331")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel GoldPriceLabel;

	[Token(Token = "0x4017332")]
	[FieldOffset(Offset = "0x60")]
	public UILabel OriginGoldPriceLabel;

	[Token(Token = "0x4017333")]
	[FieldOffset(Offset = "0x64")]
	public Transform DiamondContainer;

	[Token(Token = "0x4017334")]
	[FieldOffset(Offset = "0x68")]
	public UILabel DiamondPriceLabel;

	[Token(Token = "0x4017335")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject DiamonIcon;

	[Token(Token = "0x4017336")]
	[FieldOffset(Offset = "0x70")]
	public UILabel OriginDiamondPriceLabel;

	[Token(Token = "0x4017337")]
	[FieldOffset(Offset = "0x74")]
	public GameObject Discount;

	[Token(Token = "0x4017338")]
	[FieldOffset(Offset = "0x78")]
	public UISprite DiscountBG;

	[Token(Token = "0x4017339")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x401733A")]
	[FieldOffset(Offset = "0x80")]
	public UISprite ItemIcon;

	[Token(Token = "0x401733B")]
	[FieldOffset(Offset = "0x84")]
	public UISprite HeadIcon;

	[Token(Token = "0x401733C")]
	[FieldOffset(Offset = "0x88")]
	public UISprite BannerIcon;

	[Token(Token = "0x401733D")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite DebrisIcon;

	[Token(Token = "0x401733E")]
	[FieldOffset(Offset = "0x90")]
	public UISprite VehicleSkinIcon;

	[Token(Token = "0x401733F")]
	[FieldOffset(Offset = "0x94")]
	public UISprite WeaponSkinIcon;

	[Token(Token = "0x4017340")]
	[FieldOffset(Offset = "0x98")]
	public UISprite RankIcon;

	[Token(Token = "0x4017341")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4017342")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite RedEnvelopeIcon;

	[Token(Token = "0x4017343")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject HighLightBG;

	[Token(Token = "0x4017344")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject Effect;

	[Token(Token = "0x6016CF2")]
	[Address(RVA = "0x23B6D6C", Offset = "0x23B6D6C", VA = "0x23B6D6C")]
	public UIMallDiscountItemView()
	{
	}

	[Token(Token = "0x6016CF3")]
	[Address(RVA = "0x23B6D74", Offset = "0x23B6D74", VA = "0x23B6D74", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CF4")]
	[Address(RVA = "0x23B7C1C", Offset = "0x23B7C1C", VA = "0x23B7C1C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
