using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003621")]
public class UIHudCSMatchInfoView : UIBaseView
{
	[Token(Token = "0x4015AE0")]
	[FieldOffset(Offset = "0x14")]
	public Transform myTeam;

	[Token(Token = "0x4015AE1")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid MyteamGrid;

	[Token(Token = "0x4015AE2")]
	[FieldOffset(Offset = "0x1C")]
	public Transform oppoTeam;

	[Token(Token = "0x4015AE3")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid OppoTeamGrid;

	[Token(Token = "0x4015AE4")]
	[FieldOffset(Offset = "0x24")]
	public UILabel myWinNum;

	[Token(Token = "0x4015AE5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel remainTime;

	[Token(Token = "0x4015AE6")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel oppoWinNum;

	[Token(Token = "0x4015AE7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel curRound;

	[Token(Token = "0x4015AE8")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x4015AE9")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget WidgetBtnLeaderboard;

	[Token(Token = "0x4015AEA")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget WidgetTutorial;

	[Token(Token = "0x4015AEB")]
	[FieldOffset(Offset = "0x40")]
	public UISprite leftBG;

	[Token(Token = "0x4015AEC")]
	[FieldOffset(Offset = "0x44")]
	public UISprite rightBG;

	[Token(Token = "0x4015AED")]
	[FieldOffset(Offset = "0x48")]
	public UIWidget NewTutorialWidget_HelloCS;

	[Token(Token = "0x4015AEE")]
	[FieldOffset(Offset = "0x4C")]
	public UIWidget NewTutorialWidget_AllScore;

	[Token(Token = "0x4015AEF")]
	[FieldOffset(Offset = "0x50")]
	public UIWidget NewTutorialWidget_FriendScore;

	[Token(Token = "0x4015AF0")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget NewTutorialWidget_GameBall;

	[Token(Token = "0x4015AF1")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget NewTutorialWidget_EnemyScore;

	[Token(Token = "0x6016612")]
	[Address(RVA = "0x1F17420", Offset = "0x1F17420", VA = "0x1F17420")]
	public UIHudCSMatchInfoView()
	{
	}

	[Token(Token = "0x6016613")]
	[Address(RVA = "0x1F17428", Offset = "0x1F17428", VA = "0x1F17428", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016614")]
	[Address(RVA = "0x1F17BE0", Offset = "0x1F17BE0", VA = "0x1F17BE0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
