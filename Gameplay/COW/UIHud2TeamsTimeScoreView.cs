using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035C2")]
public class UIHud2TeamsTimeScoreView : UIBaseView
{
	[Token(Token = "0x4015852")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x4015853")]
	[FieldOffset(Offset = "0x18")]
	public UILabel team1Score;

	[Token(Token = "0x4015854")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel time;

	[Token(Token = "0x4015855")]
	[FieldOffset(Offset = "0x20")]
	public UILabel team2Score;

	[Token(Token = "0x4015856")]
	[FieldOffset(Offset = "0x24")]
	public UILabel targetScore;

	[Token(Token = "0x4015857")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Effect1;

	[Token(Token = "0x4015858")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Effect2;

	[Token(Token = "0x4015859")]
	[FieldOffset(Offset = "0x30")]
	public GameObject VFX_Team1Win;

	[Token(Token = "0x401585A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject VFX_Team2Win;

	[Token(Token = "0x401585B")]
	[FieldOffset(Offset = "0x38")]
	public GameObject VFX_Team1Combo;

	[Token(Token = "0x401585C")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject VFX_Team2Combo;

	[Token(Token = "0x401585D")]
	[FieldOffset(Offset = "0x40")]
	public GameObject MyTeamUp;

	[Token(Token = "0x401585E")]
	[FieldOffset(Offset = "0x44")]
	public GameObject EnemyTeamUp;

	[Token(Token = "0x401585F")]
	[FieldOffset(Offset = "0x48")]
	public GameObject EnemyTeamDwon;

	[Token(Token = "0x4015860")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject MyTeamDown;

	[Token(Token = "0x60164F4")]
	[Address(RVA = "0x163650C", Offset = "0x163650C", VA = "0x163650C")]
	public UIHud2TeamsTimeScoreView()
	{
	}

	[Token(Token = "0x60164F5")]
	[Address(RVA = "0x1636514", Offset = "0x1636514", VA = "0x1636514", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164F6")]
	[Address(RVA = "0x1636B84", Offset = "0x1636B84", VA = "0x1636B84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
