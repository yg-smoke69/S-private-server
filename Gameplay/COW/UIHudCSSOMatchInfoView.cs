using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200362A")]
public class UIHudCSSOMatchInfoView : UIBaseView
{
	[Token(Token = "0x4015B30")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BattleContainer;

	[Token(Token = "0x4015B31")]
	[FieldOffset(Offset = "0x18")]
	public Transform myTeam;

	[Token(Token = "0x4015B32")]
	[FieldOffset(Offset = "0x1C")]
	public Transform oppoTeam;

	[Token(Token = "0x4015B33")]
	[FieldOffset(Offset = "0x20")]
	public UILabel curRound;

	[Token(Token = "0x4015B34")]
	[FieldOffset(Offset = "0x24")]
	public UILabel remainTime;

	[Token(Token = "0x4015B35")]
	[FieldOffset(Offset = "0x28")]
	public Transform MyTeamHP;

	[Token(Token = "0x4015B36")]
	[FieldOffset(Offset = "0x2C")]
	public Transform OppoTeamHP;

	[Token(Token = "0x4015B37")]
	[FieldOffset(Offset = "0x30")]
	public GameObject WaitingContainer;

	[Token(Token = "0x4015B38")]
	[FieldOffset(Offset = "0x34")]
	public UILabel waiting;

	[Token(Token = "0x4015B39")]
	[FieldOffset(Offset = "0x38")]
	public UILabel tips;

	[Token(Token = "0x4015B3A")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x601662B")]
	[Address(RVA = "0x2132224", Offset = "0x2132224", VA = "0x2132224")]
	public UIHudCSSOMatchInfoView()
	{
	}

	[Token(Token = "0x601662C")]
	[Address(RVA = "0x213222C", Offset = "0x213222C", VA = "0x213222C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601662D")]
	[Address(RVA = "0x21326DC", Offset = "0x21326DC", VA = "0x21326DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
