using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037FA")]
public class UIInstallmentMallPurchaseView : UIBaseView
{
	[Token(Token = "0x4016BD0")]
	[FieldOffset(Offset = "0x14")]
	public BaseItemView BaseItemView;

	[Token(Token = "0x4016BD1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ItemIcon;

	[Token(Token = "0x4016BD2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite WeaponIcon;

	[Token(Token = "0x4016BD3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4016BD4")]
	[FieldOffset(Offset = "0x24")]
	public UISprite QualityBG;

	[Token(Token = "0x4016BD5")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Quality;

	[Token(Token = "0x4016BD6")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4016BD7")]
	[FieldOffset(Offset = "0x30")]
	public UISprite VoucherIcon;

	[Token(Token = "0x4016BD8")]
	[FieldOffset(Offset = "0x34")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4016BD9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Price;

	[Token(Token = "0x4016BDA")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite MoneyBgSprite;

	[Token(Token = "0x4016BDB")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PurchaseContainer;

	[Token(Token = "0x4016BDC")]
	[FieldOffset(Offset = "0x44")]
	public GameObject OverDueContainer;

	[Token(Token = "0x4016BDD")]
	[FieldOffset(Offset = "0x48")]
	public UILabel PurchaseDesc;

	[Token(Token = "0x4016BDE")]
	[FieldOffset(Offset = "0x4C")]
	public UIEasyList Grid;

	[Token(Token = "0x4016BDF")]
	[FieldOffset(Offset = "0x50")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4016BE0")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SpriteQualityOrangePlus;

	[Token(Token = "0x6016B99")]
	[Address(RVA = "0x12800D0", Offset = "0x12800D0", VA = "0x12800D0")]
	public UIInstallmentMallPurchaseView()
	{
	}

	[Token(Token = "0x6016B9A")]
	[Address(RVA = "0x12800D8", Offset = "0x12800D8", VA = "0x12800D8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B9B")]
	[Address(RVA = "0x1280868", Offset = "0x1280868", VA = "0x1280868")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
