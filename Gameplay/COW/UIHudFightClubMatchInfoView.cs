using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003652")]
public class UIHudFightClubMatchInfoView : UIBaseView
{
	[Token(Token = "0x4015C9A")]
	[FieldOffset(Offset = "0x14")]
	public Transform myTeam;

	[Token(Token = "0x4015C9B")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid MyteamGrid;

	[Token(Token = "0x4015C9C")]
	[FieldOffset(Offset = "0x1C")]
	public Transform oppoTeam;

	[Token(Token = "0x4015C9D")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid OppoTeamGrid;

	[Token(Token = "0x4015C9E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel myWinNum;

	[Token(Token = "0x4015C9F")]
	[FieldOffset(Offset = "0x28")]
	public UILabel remainTime;

	[Token(Token = "0x4015CA0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel oppoWinNum;

	[Token(Token = "0x4015CA1")]
	[FieldOffset(Offset = "0x30")]
	public UILabel curRound;

	[Token(Token = "0x4015CA2")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x4015CA3")]
	[FieldOffset(Offset = "0x38")]
	public UIWidget WidgetBtnLeaderboard;

	[Token(Token = "0x4015CA4")]
	[FieldOffset(Offset = "0x3C")]
	public UIWidget WidgetTutorial;

	[Token(Token = "0x4015CA5")]
	[FieldOffset(Offset = "0x40")]
	public UISprite leftBG;

	[Token(Token = "0x4015CA6")]
	[FieldOffset(Offset = "0x44")]
	public UISprite rightBG;

	[Token(Token = "0x60166A3")]
	[Address(RVA = "0x1B9EE38", Offset = "0x1B9EE38", VA = "0x1B9EE38")]
	public UIHudFightClubMatchInfoView()
	{
	}

	[Token(Token = "0x60166A4")]
	[Address(RVA = "0x1B9EE40", Offset = "0x1B9EE40", VA = "0x1B9EE40", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166A5")]
	[Address(RVA = "0x1B9F418", Offset = "0x1B9F418", VA = "0x1B9F418")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
