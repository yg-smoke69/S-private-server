using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003798")]
public class UIHUDUGC_MatchInfoTitleView : UIBaseView
{
	[Token(Token = "0x401684B")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PhaseCountDown;

	[Token(Token = "0x401684C")]
	[FieldOffset(Offset = "0x18")]
	public UILabel PhaseCountDownLabel;

	[Token(Token = "0x401684D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RoundNum;

	[Token(Token = "0x401684E")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RoundNumLabel;

	[Token(Token = "0x401684F")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Bg_Left;

	[Token(Token = "0x4016850")]
	[FieldOffset(Offset = "0x28")]
	public UITable Left;

	[Token(Token = "0x4016851")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid LeftTeammates;

	[Token(Token = "0x4016852")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x4016853")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Bg_Right;

	[Token(Token = "0x4016854")]
	[FieldOffset(Offset = "0x38")]
	public UITable Right;

	[Token(Token = "0x4016855")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel RightTeamScore;

	[Token(Token = "0x4016856")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid RightTeammates;

	[Token(Token = "0x4016857")]
	[FieldOffset(Offset = "0x44")]
	public GameObject AliveNum;

	[Token(Token = "0x4016858")]
	[FieldOffset(Offset = "0x48")]
	public UILabel AliveNumLabel;

	[Token(Token = "0x4016859")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton LeaderboardButton;

	[Token(Token = "0x401685A")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid MoreTeamContainer;

	[Token(Token = "0x401685B")]
	[FieldOffset(Offset = "0x54")]
	public GameObject TargetScore;

	[Token(Token = "0x401685C")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TargetScoreLabel;

	[Token(Token = "0x6016A73")]
	[Address(RVA = "0x2E1362C", Offset = "0x2E1362C", VA = "0x2E1362C")]
	public UIHUDUGC_MatchInfoTitleView()
	{
	}

	[Token(Token = "0x6016A74")]
	[Address(RVA = "0x2E13634", Offset = "0x2E13634", VA = "0x2E13634", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A75")]
	[Address(RVA = "0x2E13DF4", Offset = "0x2E13DF4", VA = "0x2E13DF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
