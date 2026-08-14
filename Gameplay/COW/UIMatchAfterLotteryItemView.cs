using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003891")]
public class UIMatchAfterLotteryItemView : UIBaseView
{
	[Token(Token = "0x40175D4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Mask;

	[Token(Token = "0x40175D5")]
	[FieldOffset(Offset = "0x18")]
	public UINetworkTexture MaskIcon;

	[Token(Token = "0x40175D6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ButtonsParent;

	[Token(Token = "0x40175D7")]
	[FieldOffset(Offset = "0x20")]
	public GameObject FreeObj;

	[Token(Token = "0x40175D8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WinGift;

	[Token(Token = "0x40175D9")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CostObj;

	[Token(Token = "0x40175DA")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel DiamondCount;

	[Token(Token = "0x40175DB")]
	[FieldOffset(Offset = "0x30")]
	public UISprite MaskIconSprite;

	[Token(Token = "0x40175DC")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Mask_Front;

	[Token(Token = "0x40175DD")]
	[FieldOffset(Offset = "0x38")]
	public UISprite IconFront;

	[Token(Token = "0x40175DE")]
	[FieldOffset(Offset = "0x3C")]
	public BaseItemView m_BaseItemView;

	[Token(Token = "0x40175DF")]
	[FieldOffset(Offset = "0x40")]
	public GameObject GreyMask;

	[Token(Token = "0x40175E0")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Glow_Back;

	[Token(Token = "0x40175E1")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Glow_Front;

	[Token(Token = "0x40175E2")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SilverFront;

	[Token(Token = "0x40175E3")]
	[FieldOffset(Offset = "0x50")]
	public GameObject GoldenFront;

	[Token(Token = "0x40175E4")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DiamondFront;

	[Token(Token = "0x40175E5")]
	[FieldOffset(Offset = "0x58")]
	public Animator QualityAnimator;

	[Token(Token = "0x40175E6")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject VFX_RollCard;

	[Token(Token = "0x40175E7")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SilverFlip;

	[Token(Token = "0x40175E8")]
	[FieldOffset(Offset = "0x64")]
	public GameObject GoldenFlip;

	[Token(Token = "0x40175E9")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DiamondFlip;

	[Token(Token = "0x6016D5E")]
	[Address(RVA = "0x28151FC", Offset = "0x28151FC", VA = "0x28151FC")]
	public UIMatchAfterLotteryItemView()
	{
	}

	[Token(Token = "0x6016D5F")]
	[Address(RVA = "0x2815204", Offset = "0x2815204", VA = "0x2815204", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D60")]
	[Address(RVA = "0x2815AD8", Offset = "0x2815AD8", VA = "0x2815AD8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
