using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003778")]
public class UIHudTokenView : UIBaseView
{
	[Token(Token = "0x4016785")]
	[FieldOffset(Offset = "0x14")]
	public UILabel RevivalTipsLabel;

	[Token(Token = "0x4016786")]
	[FieldOffset(Offset = "0x18")]
	public UIButton RevivalBtn;

	[Token(Token = "0x4016787")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RevivalEffect;

	[Token(Token = "0x4016788")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TokenNum;

	[Token(Token = "0x4016789")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VFX_Label;

	[Token(Token = "0x401678A")]
	[FieldOffset(Offset = "0x28")]
	public UISprite RevivalIcon;

	[Token(Token = "0x401678B")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject BuySelfRevive;

	[Token(Token = "0x401678C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject BuySelfReviveIcon;

	[Token(Token = "0x401678D")]
	[FieldOffset(Offset = "0x34")]
	public UIEventListener BuySelfReviveIconEventListener;

	[Token(Token = "0x401678E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject BuySelfReviveCoinIcon;

	[Token(Token = "0x401678F")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel BuySelfReviveCoinCost;

	[Token(Token = "0x4016790")]
	[FieldOffset(Offset = "0x40")]
	public UILabel BuySelfReviveTime;

	[Token(Token = "0x4016791")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BuySelfReviveTip;

	[Token(Token = "0x6016A13")]
	[Address(RVA = "0x15839A8", Offset = "0x15839A8", VA = "0x15839A8")]
	public UIHudTokenView()
	{
	}

	[Token(Token = "0x6016A14")]
	[Address(RVA = "0x15839B0", Offset = "0x15839B0", VA = "0x15839B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A15")]
	[Address(RVA = "0x1583F90", Offset = "0x1583F90", VA = "0x1583F90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
