using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A1")]
public class UIHudLWSOLeaderBoardItemView : UIBaseView
{
	[Token(Token = "0x4015FAE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIHudLWSOLeaderBoardItem;

	[Token(Token = "0x4015FAF")]
	[FieldOffset(Offset = "0x18")]
	public Animator ItemAni;

	[Token(Token = "0x4015FB0")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Info;

	[Token(Token = "0x4015FB1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject OwnBG;

	[Token(Token = "0x4015FB2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject TeamMateBG;

	[Token(Token = "0x4015FB3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject EnemyBG;

	[Token(Token = "0x4015FB4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject UpArrow;

	[Token(Token = "0x4015FB5")]
	[FieldOffset(Offset = "0x30")]
	public UILabel UpArrowNumLabel;

	[Token(Token = "0x4015FB6")]
	[FieldOffset(Offset = "0x34")]
	public GameObject DownArrow;

	[Token(Token = "0x4015FB7")]
	[FieldOffset(Offset = "0x38")]
	public UILabel DownArrowNumLabel;

	[Token(Token = "0x4015FB8")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel RankLabel;

	[Token(Token = "0x4015FB9")]
	[FieldOffset(Offset = "0x40")]
	public GameObject Rankone;

	[Token(Token = "0x4015FBA")]
	[FieldOffset(Offset = "0x44")]
	public GameObject Ranktwo;

	[Token(Token = "0x4015FBB")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Rankthre;

	[Token(Token = "0x4015FBC")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid HPGrid;

	[Token(Token = "0x4015FBD")]
	[FieldOffset(Offset = "0x50")]
	public UISprite HP1;

	[Token(Token = "0x4015FBE")]
	[FieldOffset(Offset = "0x54")]
	public UISprite HP2;

	[Token(Token = "0x4015FBF")]
	[FieldOffset(Offset = "0x58")]
	public UISprite HP3;

	[Token(Token = "0x4015FC0")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite HP4;

	[Token(Token = "0x4015FC1")]
	[FieldOffset(Offset = "0x60")]
	public UISprite HP5;

	[Token(Token = "0x4015FC2")]
	[FieldOffset(Offset = "0x64")]
	public UILabel NameLabel;

	[Token(Token = "0x4015FC3")]
	[FieldOffset(Offset = "0x68")]
	public UISprite RandomIcon;

	[Token(Token = "0x4015FC4")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel KLabel;

	[Token(Token = "0x4015FC5")]
	[FieldOffset(Offset = "0x70")]
	public UILabel DLabel;

	[Token(Token = "0x4015FC6")]
	[FieldOffset(Offset = "0x74")]
	public UILabel HSLabel;

	[Token(Token = "0x4015FC7")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Eliminate;

	[Token(Token = "0x4015FC8")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject WinStreakVFX2;

	[Token(Token = "0x4015FC9")]
	[FieldOffset(Offset = "0x80")]
	public GameObject WinStreakVFX3;

	[Token(Token = "0x6016790")]
	[Address(RVA = "0x1BC5D2C", Offset = "0x1BC5D2C", VA = "0x1BC5D2C")]
	public UIHudLWSOLeaderBoardItemView()
	{
	}

	[Token(Token = "0x6016791")]
	[Address(RVA = "0x1BC5D34", Offset = "0x1BC5D34", VA = "0x1BC5D34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016792")]
	[Address(RVA = "0x1BC686C", Offset = "0x1BC686C", VA = "0x1BC686C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
