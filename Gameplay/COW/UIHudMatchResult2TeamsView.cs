using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036AD")]
public class UIHudMatchResult2TeamsView : UIBaseView
{
	[Token(Token = "0x4016057")]
	[FieldOffset(Offset = "0x14")]
	public GameObject TeamInfoContainer;

	[Token(Token = "0x4016058")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LocalTeamIcon;

	[Token(Token = "0x4016059")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject OptTeamIcon;

	[Token(Token = "0x401605A")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Team2Icon;

	[Token(Token = "0x401605B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Team1Icon;

	[Token(Token = "0x401605C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LocalTeamScore;

	[Token(Token = "0x401605D")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel OptTeamScore;

	[Token(Token = "0x401605E")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Defeat;

	[Token(Token = "0x401605F")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Booyah;

	[Token(Token = "0x4016060")]
	[FieldOffset(Offset = "0x38")]
	public GameObject GridContainer;

	[Token(Token = "0x4016061")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject GridTitle;

	[Token(Token = "0x4016062")]
	[FieldOffset(Offset = "0x40")]
	public UIGrid GridLeft;

	[Token(Token = "0x4016063")]
	[FieldOffset(Offset = "0x44")]
	public UIGrid GridRight;

	[Token(Token = "0x4016064")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BtnMask;

	[Token(Token = "0x4016065")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BtnShare;

	[Token(Token = "0x4016066")]
	[FieldOffset(Offset = "0x50")]
	public UIButton BtnNext;

	[Token(Token = "0x60167B4")]
	[Address(RVA = "0x1003B54", Offset = "0x1003B54", VA = "0x1003B54")]
	public UIHudMatchResult2TeamsView()
	{
	}

	[Token(Token = "0x60167B5")]
	[Address(RVA = "0x1003B5C", Offset = "0x1003B5C", VA = "0x1003B5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167B6")]
	[Address(RVA = "0x1004250", Offset = "0x1004250", VA = "0x1004250")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
