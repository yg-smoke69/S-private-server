using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200387B")]
public class UIMallWeaponItemView : UIBaseView
{
	[Token(Token = "0x401741E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIMallWeaponItem;

	[Token(Token = "0x401741F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject HighLightBG;

	[Token(Token = "0x4017420")]
	[FieldOffset(Offset = "0x1C")]
	public SetRelativeDepth WeaponVFX;

	[Token(Token = "0x4017421")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Default;

	[Token(Token = "0x4017422")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x4017423")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DiscountItemIcon;

	[Token(Token = "0x4017424")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject OtherChannelContainer;

	[Token(Token = "0x4017425")]
	[FieldOffset(Offset = "0x30")]
	public UILabel OtherChannelTitle;

	[Token(Token = "0x4017426")]
	[FieldOffset(Offset = "0x34")]
	public UISprite OtherChannelIcon;

	[Token(Token = "0x4017427")]
	[FieldOffset(Offset = "0x38")]
	public UILabel DiscountLabel;

	[Token(Token = "0x4017428")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DiscountVFX;

	[Token(Token = "0x4017429")]
	[FieldOffset(Offset = "0x40")]
	public UITable PriceContainer;

	[Token(Token = "0x401742A")]
	[FieldOffset(Offset = "0x44")]
	public GameObject DiamondIcon;

	[Token(Token = "0x401742B")]
	[FieldOffset(Offset = "0x48")]
	public UILabel DiamondPrice;

	[Token(Token = "0x401742C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject Slash;

	[Token(Token = "0x401742D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GoldIcon;

	[Token(Token = "0x401742E")]
	[FieldOffset(Offset = "0x54")]
	public UILabel GoldPrice;

	[Token(Token = "0x401742F")]
	[FieldOffset(Offset = "0x58")]
	public UILabel OriginalPrice;

	[Token(Token = "0x4017430")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite PriceBG;

	[Token(Token = "0x4017431")]
	[FieldOffset(Offset = "0x60")]
	public UITexture LocalImg;

	[Token(Token = "0x4017432")]
	[FieldOffset(Offset = "0x64")]
	public GameObject OwnedTitle;

	[Token(Token = "0x6016D1C")]
	[Address(RVA = "0x227033C", Offset = "0x227033C", VA = "0x227033C")]
	public UIMallWeaponItemView()
	{
	}

	[Token(Token = "0x6016D1D")]
	[Address(RVA = "0x2270344", Offset = "0x2270344", VA = "0x2270344", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D1E")]
	[Address(RVA = "0x2270C00", Offset = "0x2270C00", VA = "0x2270C00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
