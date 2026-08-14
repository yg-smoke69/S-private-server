using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036AA")]
public class UIHudMatchEndShowTimeView : UIBaseView
{
	[Token(Token = "0x4016024")]
	[FieldOffset(Offset = "0x14")]
	public Animator Animator;

	[Token(Token = "0x4016025")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ScoreContainer;

	[Token(Token = "0x4016026")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LeftTeamScoreBG;

	[Token(Token = "0x4016027")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LeftTeamScore;

	[Token(Token = "0x4016028")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LeftTeamIconOB;

	[Token(Token = "0x4016029")]
	[FieldOffset(Offset = "0x28")]
	public UISprite LeftTeamIcon;

	[Token(Token = "0x401602A")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite LeftTeamClanIcon;

	[Token(Token = "0x401602B")]
	[FieldOffset(Offset = "0x30")]
	public UISprite RightTeamScoreBG;

	[Token(Token = "0x401602C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel RightTeamScore;

	[Token(Token = "0x401602D")]
	[FieldOffset(Offset = "0x38")]
	public UISprite RightTeamClanIcon;

	[Token(Token = "0x401602E")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RightTeamIconOB;

	[Token(Token = "0x401602F")]
	[FieldOffset(Offset = "0x40")]
	public UISprite RightTeamIcon;

	[Token(Token = "0x4016030")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BooyahContainer;

	[Token(Token = "0x4016031")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BOOYAHSprite;

	[Token(Token = "0x4016032")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DefeatedContainer;

	[Token(Token = "0x4016033")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Lose;

	[Token(Token = "0x4016034")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ShowResultBtn;

	[Token(Token = "0x4016035")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ShowResultLabel;

	[Token(Token = "0x4016036")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel Time;

	[Token(Token = "0x60167AB")]
	[Address(RVA = "0xFFE3E8", Offset = "0xFFE3E8", VA = "0xFFE3E8")]
	public UIHudMatchEndShowTimeView()
	{
	}

	[Token(Token = "0x60167AC")]
	[Address(RVA = "0xFFE3F0", Offset = "0xFFE3F0", VA = "0xFFE3F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167AD")]
	[Address(RVA = "0xFFEC04", Offset = "0xFFEC04", VA = "0xFFEC04")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
