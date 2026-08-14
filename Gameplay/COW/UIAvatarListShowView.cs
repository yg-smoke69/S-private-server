using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D0")]
public class UIAvatarListShowView : UIBaseView
{
	[Token(Token = "0x4013D68")]
	[FieldOffset(Offset = "0x14")]
	public TweenPosition AvatarTweenPos;

	[Token(Token = "0x4013D69")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ClostBtn;

	[Token(Token = "0x4013D6A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Icon01;

	[Token(Token = "0x4013D6B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Icon02;

	[Token(Token = "0x4013D6C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LevelTips;

	[Token(Token = "0x4013D6D")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget AvatarWidget;

	[Token(Token = "0x4013D6E")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView AvatarScrollView;

	[Token(Token = "0x4013D6F")]
	[FieldOffset(Offset = "0x30")]
	public UIEasyList Grid;

	[Token(Token = "0x4013D70")]
	[FieldOffset(Offset = "0x34")]
	public UILabel AvatarNameChoose;

	[Token(Token = "0x4013D71")]
	[FieldOffset(Offset = "0x38")]
	public Transform CurrentChooseBtnTr;

	[Token(Token = "0x4013D72")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject AwakenAvatarExchangeContainer;

	[Token(Token = "0x4013D73")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ExchangeToOriAvatarBtn;

	[Token(Token = "0x4013D74")]
	[FieldOffset(Offset = "0x44")]
	public UIAvatarAwakenSwitchItemView AvatarOriItem;

	[Token(Token = "0x4013D75")]
	[FieldOffset(Offset = "0x48")]
	public UIButton ExchangeToAwakenAvatarBtn;

	[Token(Token = "0x4013D76")]
	[FieldOffset(Offset = "0x4C")]
	public UIAvatarAwakenSwitchItemView AvatarAwakenItem;

	[Token(Token = "0x4013D77")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AwakenEntranceBtn;

	[Token(Token = "0x4013D78")]
	[FieldOffset(Offset = "0x54")]
	public UILabel UIAwakenBtnLabel;

	[Token(Token = "0x4013D79")]
	[FieldOffset(Offset = "0x58")]
	public GameObject btnLabelVFX;

	[Token(Token = "0x4013D7A")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject btnIconVFX;

	[Token(Token = "0x4013D7B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject AwakenEntranceTips;

	[Token(Token = "0x4013D7C")]
	[FieldOffset(Offset = "0x64")]
	public UIWidget AvatarGuide;

	[Token(Token = "0x4013D7D")]
	[FieldOffset(Offset = "0x68")]
	public UIButton AvatarButton;

	[Token(Token = "0x6015F26")]
	[Address(RVA = "0x2B5CABC", Offset = "0x2B5CABC", VA = "0x2B5CABC")]
	public UIAvatarListShowView()
	{
	}

	[Token(Token = "0x6015F27")]
	[Address(RVA = "0x2B5CAC4", Offset = "0x2B5CAC4", VA = "0x2B5CAC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F28")]
	[Address(RVA = "0x2B5D3D0", Offset = "0x2B5D3D0", VA = "0x2B5D3D0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
