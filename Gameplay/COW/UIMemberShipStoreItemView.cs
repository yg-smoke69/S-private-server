using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038AB")]
public class UIMemberShipStoreItemView : UIBaseView
{
	[Token(Token = "0x40176EE")]
	[FieldOffset(Offset = "0x14")]
	public Transform StandardItem;

	[Token(Token = "0x40176EF")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BuyBtn;

	[Token(Token = "0x40176F0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject BuyFree;

	[Token(Token = "0x40176F1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BuyViaCurrency;

	[Token(Token = "0x40176F2")]
	[FieldOffset(Offset = "0x24")]
	public UISprite CurrencyIcon;

	[Token(Token = "0x40176F3")]
	[FieldOffset(Offset = "0x28")]
	public UILabel PriceLabel;

	[Token(Token = "0x40176F4")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OriginalPriceLabel;

	[Token(Token = "0x40176F5")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BuyedLabel;

	[Token(Token = "0x40176F6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject FreeTips;

	[Token(Token = "0x40176F7")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DiscountTag;

	[Token(Token = "0x40176F8")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel DiscountLabel;

	[Token(Token = "0x40176F9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject VipTag;

	[Token(Token = "0x6016DAC")]
	[Address(RVA = "0x1304D30", Offset = "0x1304D30", VA = "0x1304D30")]
	public UIMemberShipStoreItemView()
	{
	}

	[Token(Token = "0x6016DAD")]
	[Address(RVA = "0x1304D38", Offset = "0x1304D38", VA = "0x1304D38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DAE")]
	[Address(RVA = "0x1305290", Offset = "0x1305290", VA = "0x1305290")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
