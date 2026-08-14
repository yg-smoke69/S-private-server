using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003582")]
public class UIGachaLengendaryExtraListItemView : UIBaseView
{
	[Token(Token = "0x401541B")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget RootViewWidget;

	[Token(Token = "0x401541C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite TokenSprite;

	[Token(Token = "0x401541D")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel TokenNum;

	[Token(Token = "0x401541E")]
	[FieldOffset(Offset = "0x20")]
	public UIButton ClickButon;

	[Token(Token = "0x401541F")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ItemUnLock;

	[Token(Token = "0x4015420")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ItemLocked;

	[Token(Token = "0x4015421")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ItemGained;

	[Token(Token = "0x4015422")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ItemMini;

	[Token(Token = "0x4015423")]
	[FieldOffset(Offset = "0x34")]
	public BaseItemView RewardItem;

	[Token(Token = "0x4015424")]
	[FieldOffset(Offset = "0x38")]
	public UISprite QualityBG;

	[Token(Token = "0x4015425")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpritePurplePlus;

	[Token(Token = "0x4015426")]
	[FieldOffset(Offset = "0x40")]
	public UISprite QualityNameBG01;

	[Token(Token = "0x4015427")]
	[FieldOffset(Offset = "0x44")]
	public GameObject IconGroup;

	[Token(Token = "0x4015428")]
	[FieldOffset(Offset = "0x48")]
	public UISprite Sprite_Debris;

	[Token(Token = "0x4015429")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite VoucherIcon;

	[Token(Token = "0x401542A")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LimitLabel;

	[Token(Token = "0x401542B")]
	[FieldOffset(Offset = "0x54")]
	public UILabel QuantityLabel;

	[Token(Token = "0x401542C")]
	[FieldOffset(Offset = "0x58")]
	public GameObject VfxRareReward;

	[Token(Token = "0x401542D")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite PrizeBg;

	[Token(Token = "0x401542E")]
	[FieldOffset(Offset = "0x60")]
	public UISprite NodeSprite;

	[Token(Token = "0x401542F")]
	[FieldOffset(Offset = "0x64")]
	public UISprite SpriteOrangePlus;

	[Token(Token = "0x6016436")]
	[Address(RVA = "0x2E73558", Offset = "0x2E73558", VA = "0x2E73558")]
	public UIGachaLengendaryExtraListItemView()
	{
	}

	[Token(Token = "0x6016437")]
	[Address(RVA = "0x2E73560", Offset = "0x2E73560", VA = "0x2E73560", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016438")]
	[Address(RVA = "0x2E73E40", Offset = "0x2E73E40", VA = "0x2E73E40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
