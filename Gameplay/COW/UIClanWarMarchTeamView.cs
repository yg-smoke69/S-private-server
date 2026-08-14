using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003462")]
public class UIClanWarMarchTeamView : UIBaseView
{
	[Token(Token = "0x401457C")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Title;

	[Token(Token = "0x401457D")]
	[FieldOffset(Offset = "0x18")]
	public UIButton MarchTeamRuleBtn;

	[Token(Token = "0x401457E")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton LeaderboardBtn;

	[Token(Token = "0x401457F")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4014580")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RefreshBtnNormalContainer;

	[Token(Token = "0x4014581")]
	[FieldOffset(Offset = "0x28")]
	public GameObject RefreshBtnDisableContainer;

	[Token(Token = "0x4014582")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownLabel RefreshBtnDisableCountDown;

	[Token(Token = "0x4014583")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid TeamMemberList;

	[Token(Token = "0x4014584")]
	[FieldOffset(Offset = "0x34")]
	public UILabel MinCnt;

	[Token(Token = "0x4014585")]
	[FieldOffset(Offset = "0x38")]
	public UIGrid MarchOpsBtnGrid;

	[Token(Token = "0x4014586")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton InviteBtn;

	[Token(Token = "0x4014587")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ConveneBtn;

	[Token(Token = "0x4014588")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ConveneCDRoot;

	[Token(Token = "0x4014589")]
	[FieldOffset(Offset = "0x48")]
	public UICountDownLabel ConveneCDCountDownLabel;

	[Token(Token = "0x401458A")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton LeaveBtn;

	[Token(Token = "0x401458B")]
	[FieldOffset(Offset = "0x50")]
	public UIButton JoinBtn;

	[Token(Token = "0x401458C")]
	[FieldOffset(Offset = "0x54")]
	public GameObject JoinBtnAvailable;

	[Token(Token = "0x401458D")]
	[FieldOffset(Offset = "0x58")]
	public UILabel JoinBtnLabel;

	[Token(Token = "0x401458E")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject JoinBtnUnavailable;

	[Token(Token = "0x401458F")]
	[FieldOffset(Offset = "0x60")]
	public UILabel JoinBtnLabelDisabled;

	[Token(Token = "0x4014590")]
	[FieldOffset(Offset = "0x64")]
	public UICountDownLabel JoinBtnLabelCountDown;

	[Token(Token = "0x4014591")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Waiting;

	[Token(Token = "0x4014592")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel WatingLabel;

	[Token(Token = "0x4014593")]
	[FieldOffset(Offset = "0x70")]
	public UIButton Ready;

	[Token(Token = "0x4014594")]
	[FieldOffset(Offset = "0x74")]
	public UILabel ReadyLabel;

	[Token(Token = "0x4014595")]
	[FieldOffset(Offset = "0x78")]
	public GameObject LoadoutGo;

	[Token(Token = "0x4014596")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton StartBtn;

	[Token(Token = "0x4014597")]
	[FieldOffset(Offset = "0x80")]
	public GameObject StartAvailable;

	[Token(Token = "0x4014598")]
	[FieldOffset(Offset = "0x84")]
	public GameObject StartUnavailable;

	[Token(Token = "0x4014599")]
	[FieldOffset(Offset = "0x88")]
	public UILabel StartLabelDisable;

	[Token(Token = "0x401459A")]
	[FieldOffset(Offset = "0x8C")]
	public UICountDownLabel StartLabelCountDown;

	[Token(Token = "0x401459B")]
	[FieldOffset(Offset = "0x90")]
	public GameObject Matching;

	[Token(Token = "0x401459C")]
	[FieldOffset(Offset = "0x94")]
	public GameObject CountDownContent;

	[Token(Token = "0x401459D")]
	[FieldOffset(Offset = "0x98")]
	public UILabel CountDownLabel;

	[Token(Token = "0x401459E")]
	[FieldOffset(Offset = "0x9C")]
	public UICountDownLabel CountDown;

	[Token(Token = "0x60160DA")]
	[Address(RVA = "0x28FF4C4", Offset = "0x28FF4C4", VA = "0x28FF4C4")]
	public UIClanWarMarchTeamView()
	{
	}

	[Token(Token = "0x60160DB")]
	[Address(RVA = "0x28FF4CC", Offset = "0x28FF4CC", VA = "0x28FF4CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60160DC")]
	[Address(RVA = "0x29002B0", Offset = "0x29002B0", VA = "0x29002B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
