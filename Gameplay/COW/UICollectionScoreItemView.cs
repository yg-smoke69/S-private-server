using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003471")]
public class UICollectionScoreItemView : UIBaseView
{
	[Token(Token = "0x4014661")]
	[FieldOffset(Offset = "0x14")]
	public GameObject pro;

	[Token(Token = "0x4014662")]
	[FieldOffset(Offset = "0x18")]
	public GameObject down;

	[Token(Token = "0x4014663")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite down3;

	[Token(Token = "0x4014664")]
	[FieldOffset(Offset = "0x20")]
	public TweenAlpha alphaDown3;

	[Token(Token = "0x4014665")]
	[FieldOffset(Offset = "0x24")]
	public UISprite down2;

	[Token(Token = "0x4014666")]
	[FieldOffset(Offset = "0x28")]
	public TweenAlpha alphaDown2;

	[Token(Token = "0x4014667")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite down1;

	[Token(Token = "0x4014668")]
	[FieldOffset(Offset = "0x30")]
	public TweenAlpha alphaDown1;

	[Token(Token = "0x4014669")]
	[FieldOffset(Offset = "0x34")]
	public GameObject up;

	[Token(Token = "0x401466A")]
	[FieldOffset(Offset = "0x38")]
	public UISprite up1;

	[Token(Token = "0x401466B")]
	[FieldOffset(Offset = "0x3C")]
	public TweenAlpha alphaUp1;

	[Token(Token = "0x401466C")]
	[FieldOffset(Offset = "0x40")]
	public UISprite up2;

	[Token(Token = "0x401466D")]
	[FieldOffset(Offset = "0x44")]
	public TweenAlpha alphaUp2;

	[Token(Token = "0x401466E")]
	[FieldOffset(Offset = "0x48")]
	public UISprite up3;

	[Token(Token = "0x401466F")]
	[FieldOffset(Offset = "0x4C")]
	public TweenAlpha alphaUp3;

	[Token(Token = "0x4014670")]
	[FieldOffset(Offset = "0x50")]
	public UILabel scoreName;

	[Token(Token = "0x4014671")]
	[FieldOffset(Offset = "0x54")]
	public TweenAlpha alphaName;

	[Token(Token = "0x4014672")]
	[FieldOffset(Offset = "0x58")]
	public UIProgressBar scoreBar;

	[Token(Token = "0x4014673")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite BarFG;

	[Token(Token = "0x4014674")]
	[FieldOffset(Offset = "0x60")]
	public UISprite deltaFg;

	[Token(Token = "0x4014675")]
	[FieldOffset(Offset = "0x64")]
	public UILabel scoreValue;

	[Token(Token = "0x4014676")]
	[FieldOffset(Offset = "0x68")]
	public UILabel deltaValue;

	[Token(Token = "0x6016107")]
	[Address(RVA = "0x2CD81BC", Offset = "0x2CD81BC", VA = "0x2CD81BC")]
	public UICollectionScoreItemView()
	{
	}

	[Token(Token = "0x6016108")]
	[Address(RVA = "0x2CD81C4", Offset = "0x2CD81C4", VA = "0x2CD81C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016109")]
	[Address(RVA = "0x2CD8B28", Offset = "0x2CD8B28", VA = "0x2CD8B28")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
