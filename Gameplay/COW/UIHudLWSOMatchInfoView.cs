using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036A3")]
public class UIHudLWSOMatchInfoView : UIBaseView
{
	[Token(Token = "0x4015FE6")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BattleContainer;

	[Token(Token = "0x4015FE7")]
	[FieldOffset(Offset = "0x18")]
	public Transform myTeam;

	[Token(Token = "0x4015FE8")]
	[FieldOffset(Offset = "0x1C")]
	public Transform oppoTeam;

	[Token(Token = "0x4015FE9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HpKnife;

	[Token(Token = "0x4015FEA")]
	[FieldOffset(Offset = "0x24")]
	public UILabel remainTime;

	[Token(Token = "0x4015FEB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite OppoTeamHpBG;

	[Token(Token = "0x4015FEC")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite MyTeamHPBG;

	[Token(Token = "0x4015FED")]
	[FieldOffset(Offset = "0x30")]
	public UIGrid MyTeamHPGrid;

	[Token(Token = "0x4015FEE")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid OppoTeamHPGrid;

	[Token(Token = "0x4015FEF")]
	[FieldOffset(Offset = "0x38")]
	public GameObject WaitingContainer;

	[Token(Token = "0x4015FF0")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel waitingTips;

	[Token(Token = "0x4015FF1")]
	[FieldOffset(Offset = "0x40")]
	public UILabel curRound;

	[Token(Token = "0x4015FF2")]
	[FieldOffset(Offset = "0x44")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x6016796")]
	[Address(RVA = "0x1BCB200", Offset = "0x1BCB200", VA = "0x1BCB200")]
	public UIHudLWSOMatchInfoView()
	{
	}

	[Token(Token = "0x6016797")]
	[Address(RVA = "0x1BCB208", Offset = "0x1BCB208", VA = "0x1BCB208", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016798")]
	[Address(RVA = "0x1BCB7C8", Offset = "0x1BCB7C8", VA = "0x1BCB7C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
