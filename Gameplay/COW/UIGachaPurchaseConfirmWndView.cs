using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003596")]
public class UIGachaPurchaseConfirmWndView : UIBaseView
{
	[Token(Token = "0x4015563")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BuffIcon;

	[Token(Token = "0x4015564")]
	[FieldOffset(Offset = "0x18")]
	public UISprite ItemIcon;

	[Token(Token = "0x4015565")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject headhunterWeaponIcon;

	[Token(Token = "0x4015566")]
	[FieldOffset(Offset = "0x20")]
	public GameObject WeaponIconEffect;

	[Token(Token = "0x4015567")]
	[FieldOffset(Offset = "0x24")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4015568")]
	[FieldOffset(Offset = "0x28")]
	public UILabel ConfirmLabel;

	[Token(Token = "0x4015569")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton PlusBtn;

	[Token(Token = "0x401556A")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CountLabel;

	[Token(Token = "0x401556B")]
	[FieldOffset(Offset = "0x34")]
	public UIButton MinusBtn;

	[Token(Token = "0x401556C")]
	[FieldOffset(Offset = "0x38")]
	public UISprite LotteryNum;

	[Token(Token = "0x401556D")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LegendBox;

	[Token(Token = "0x401556E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Booyan21Box;

	[Token(Token = "0x401556F")]
	[FieldOffset(Offset = "0x44")]
	public GameObject HackerStoreBox;

	[Token(Token = "0x4015570")]
	[FieldOffset(Offset = "0x48")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4015571")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DiamondBtn;

	[Token(Token = "0x4015572")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DiamondLabel;

	[Token(Token = "0x4015573")]
	[FieldOffset(Offset = "0x54")]
	public GameObject CoindBtn;

	[Token(Token = "0x4015574")]
	[FieldOffset(Offset = "0x58")]
	public UILabel CoinLabel;

	[Token(Token = "0x4015575")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggle NoShowToggle;

	[Token(Token = "0x4015576")]
	[FieldOffset(Offset = "0x60")]
	public GameObject Rampgae4CBox;

	[Token(Token = "0x6016472")]
	[Address(RVA = "0x2A298B4", Offset = "0x2A298B4", VA = "0x2A298B4")]
	public UIGachaPurchaseConfirmWndView()
	{
	}

	[Token(Token = "0x6016473")]
	[Address(RVA = "0x2A298BC", Offset = "0x2A298BC", VA = "0x2A298BC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016474")]
	[Address(RVA = "0x2A2A124", Offset = "0x2A2A124", VA = "0x2A2A124")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
