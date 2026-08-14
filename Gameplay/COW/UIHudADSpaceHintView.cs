using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C7")]
public class UIHudADSpaceHintView : UIBaseView
{
	[Token(Token = "0x401587E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Enter1v1Warning;

	[Token(Token = "0x401587F")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Enter1v1Hint;

	[Token(Token = "0x4015880")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Avatar;

	[Token(Token = "0x4015881")]
	[FieldOffset(Offset = "0x20")]
	public UILabel HintLabel;

	[Token(Token = "0x4015882")]
	[FieldOffset(Offset = "0x24")]
	public GameObject End1v1TimeOut;

	[Token(Token = "0x4015883")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Start1v1Info;

	[Token(Token = "0x4015884")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Start1v1InfoIcon;

	[Token(Token = "0x4015885")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Start1v1InfoTitle;

	[Token(Token = "0x4015886")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Start1v1InfoInfo;

	[Token(Token = "0x4015887")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Win1V1Kill;

	[Token(Token = "0x4015888")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Win1v1;

	[Token(Token = "0x4015889")]
	[FieldOffset(Offset = "0x40")]
	public UISprite WinAvatar;

	[Token(Token = "0x401588A")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Win1v1Label;

	[Token(Token = "0x401588B")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SelfWinBg;

	[Token(Token = "0x401588C")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject RivalWinBg;

	[Token(Token = "0x401588D")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Win1v1BonusScore;

	[Token(Token = "0x401588E")]
	[FieldOffset(Offset = "0x54")]
	public UISprite TeamIcon;

	[Token(Token = "0x401588F")]
	[FieldOffset(Offset = "0x58")]
	public GameObject SelfWinBgTeam;

	[Token(Token = "0x4015890")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject RivalWinBgTeam;

	[Token(Token = "0x6016503")]
	[Address(RVA = "0x163A754", Offset = "0x163A754", VA = "0x163A754")]
	public UIHudADSpaceHintView()
	{
	}

	[Token(Token = "0x6016504")]
	[Address(RVA = "0x163A75C", Offset = "0x163A75C", VA = "0x163A75C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016505")]
	[Address(RVA = "0x163AF40", Offset = "0x163AF40", VA = "0x163AF40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
