using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200386E")]
public class UIMallGetEquitView : UIBaseView
{
	[Token(Token = "0x4017345")]
	[FieldOffset(Offset = "0x14")]
	public UISprite BG;

	[Token(Token = "0x4017346")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ContinueOpenContainer;

	[Token(Token = "0x4017347")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton OpenBtn;

	[Token(Token = "0x4017348")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CountLabel;

	[Token(Token = "0x4017349")]
	[FieldOffset(Offset = "0x24")]
	public UISprite OpenCrateIcon;

	[Token(Token = "0x401734A")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CancelOpenBtn;

	[Token(Token = "0x401734B")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EndOpenContainer;

	[Token(Token = "0x401734C")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BuyBtn;

	[Token(Token = "0x401734D")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoldIcon;

	[Token(Token = "0x401734E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DiamondIcon;

	[Token(Token = "0x401734F")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PriceLabel;

	[Token(Token = "0x4017350")]
	[FieldOffset(Offset = "0x40")]
	public UISprite BuyCrateIcon;

	[Token(Token = "0x4017351")]
	[FieldOffset(Offset = "0x44")]
	public UIButton CancelBuyBtn;

	[Token(Token = "0x4017352")]
	[FieldOffset(Offset = "0x48")]
	public UISprite EquitIcon;

	[Token(Token = "0x4017353")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite EquitHightlightSprite;

	[Token(Token = "0x4017354")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4017355")]
	[FieldOffset(Offset = "0x54")]
	public UILabel ItemCountLabel;

	[Token(Token = "0x4017356")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ItemExpireTimeLable;

	[Token(Token = "0x6016CF5")]
	[Address(RVA = "0x22537EC", Offset = "0x22537EC", VA = "0x22537EC")]
	public UIMallGetEquitView()
	{
	}

	[Token(Token = "0x6016CF6")]
	[Address(RVA = "0x22537F4", Offset = "0x22537F4", VA = "0x22537F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CF7")]
	[Address(RVA = "0x2253FCC", Offset = "0x2253FCC", VA = "0x2253FCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
