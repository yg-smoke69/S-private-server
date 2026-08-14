using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200385E")]
public class UILuckyWheelItemView : UIBaseView
{
	[Token(Token = "0x40171F9")]
	[FieldOffset(Offset = "0x14")]
	public UISprite UsedBg;

	[Token(Token = "0x40171FA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject DrawedEffect;

	[Token(Token = "0x40171FB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject SelectedBg;

	[Token(Token = "0x40171FC")]
	[FieldOffset(Offset = "0x20")]
	public UILabel DiscountLabel;

	[Token(Token = "0x40171FD")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PriceLabelContainer;

	[Token(Token = "0x40171FE")]
	[FieldOffset(Offset = "0x28")]
	public UISprite CoinIconSprite;

	[Token(Token = "0x40171FF")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017200")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Level1;

	[Token(Token = "0x4017201")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Level1BigPrizeVfx;

	[Token(Token = "0x4017202")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Level2;

	[Token(Token = "0x4017203")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Level3;

	[Token(Token = "0x4017204")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ItemBtn;

	[Token(Token = "0x6016CC5")]
	[Address(RVA = "0x18CA864", Offset = "0x18CA864", VA = "0x18CA864")]
	public UILuckyWheelItemView()
	{
	}

	[Token(Token = "0x6016CC6")]
	[Address(RVA = "0x18CA86C", Offset = "0x18CA86C", VA = "0x18CA86C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CC7")]
	[Address(RVA = "0x18CADE0", Offset = "0x18CADE0", VA = "0x18CADE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
