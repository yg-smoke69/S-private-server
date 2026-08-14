using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003617")]
public class UIHudControlMatchTimeScoreView : UIBaseView
{
	[Token(Token = "0x4015A53")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x4015A54")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ActivatingPoint;

	[Token(Token = "0x4015A55")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject NoActivatingPoint;

	[Token(Token = "0x4015A56")]
	[FieldOffset(Offset = "0x20")]
	public UILabel time;

	[Token(Token = "0x4015A57")]
	[FieldOffset(Offset = "0x24")]
	public UILabel targetScore;

	[Token(Token = "0x4015A58")]
	[FieldOffset(Offset = "0x28")]
	public UISprite NormalState;

	[Token(Token = "0x4015A59")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite NormalStateLight;

	[Token(Token = "0x4015A5A")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ScrambleState;

	[Token(Token = "0x4015A5B")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PingJuEffect;

	[Token(Token = "0x4015A5C")]
	[FieldOffset(Offset = "0x38")]
	public GameObject GetScoreVFX_Local;

	[Token(Token = "0x4015A5D")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject GetScoreVFX_Opp;

	[Token(Token = "0x4015A5E")]
	[FieldOffset(Offset = "0x40")]
	public GameObject OccupyVFX_Local;

	[Token(Token = "0x4015A5F")]
	[FieldOffset(Offset = "0x44")]
	public GameObject OccupyVFX_Opp;

	[Token(Token = "0x4015A60")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LocalTeamScore;

	[Token(Token = "0x4015A61")]
	[FieldOffset(Offset = "0x4C")]
	public UIProgressBar LocalTeamScoreBar;

	[Token(Token = "0x4015A62")]
	[FieldOffset(Offset = "0x50")]
	public UILabel OppTeamScore;

	[Token(Token = "0x4015A63")]
	[FieldOffset(Offset = "0x54")]
	public UIProgressBar OppTeamScoreBar;

	[Token(Token = "0x60165F4")]
	[Address(RVA = "0x13654EC", Offset = "0x13654EC", VA = "0x13654EC")]
	public UIHudControlMatchTimeScoreView()
	{
	}

	[Token(Token = "0x60165F5")]
	[Address(RVA = "0x13654F4", Offset = "0x13654F4", VA = "0x13654F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165F6")]
	[Address(RVA = "0x1365C54", Offset = "0x1365C54", VA = "0x1365C54")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
