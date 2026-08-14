using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035F2")]
public class UIHudBombMatchInfoView : UIBaseView
{
	[Token(Token = "0x401598B")]
	[FieldOffset(Offset = "0x14")]
	public UISprite leftBG;

	[Token(Token = "0x401598C")]
	[FieldOffset(Offset = "0x18")]
	public UISprite rightBG;

	[Token(Token = "0x401598D")]
	[FieldOffset(Offset = "0x1C")]
	public Transform myTeam;

	[Token(Token = "0x401598E")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid MyteamGrid;

	[Token(Token = "0x401598F")]
	[FieldOffset(Offset = "0x24")]
	public Transform oppoTeam;

	[Token(Token = "0x4015990")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid OppoTeamGrid;

	[Token(Token = "0x4015991")]
	[FieldOffset(Offset = "0x2C")]
	public Animator SwitchAnimator;

	[Token(Token = "0x4015992")]
	[FieldOffset(Offset = "0x30")]
	public UILabel myWinNum;

	[Token(Token = "0x4015993")]
	[FieldOffset(Offset = "0x34")]
	public UISprite myFaction;

	[Token(Token = "0x4015994")]
	[FieldOffset(Offset = "0x38")]
	public UISprite FixedMyFaction;

	[Token(Token = "0x4015995")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel curRound;

	[Token(Token = "0x4015996")]
	[FieldOffset(Offset = "0x40")]
	public UISprite oppoFaction;

	[Token(Token = "0x4015997")]
	[FieldOffset(Offset = "0x44")]
	public UILabel oppoWinNum;

	[Token(Token = "0x4015998")]
	[FieldOffset(Offset = "0x48")]
	public UISprite FixedOppoFaction;

	[Token(Token = "0x4015999")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem VFX_attack;

	[Token(Token = "0x401599A")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem VFX_defense;

	[Token(Token = "0x401599B")]
	[FieldOffset(Offset = "0x54")]
	public UIButton BtnLeaderboard;

	[Token(Token = "0x401599C")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget WidgetBtnLeaderboard;

	[Token(Token = "0x401599D")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel countTime;

	[Token(Token = "0x401599E")]
	[FieldOffset(Offset = "0x60")]
	public UISprite IconBomb;

	[Token(Token = "0x401599F")]
	[FieldOffset(Offset = "0x64")]
	public UISprite IconNormal;

	[Token(Token = "0x40159A0")]
	[FieldOffset(Offset = "0x68")]
	public GameObject VFXFlashing1;

	[Token(Token = "0x40159A1")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject VFXFlashing2;

	[Token(Token = "0x6016584")]
	[Address(RVA = "0x1E11670", Offset = "0x1E11670", VA = "0x1E11670")]
	public UIHudBombMatchInfoView()
	{
	}

	[Token(Token = "0x6016585")]
	[Address(RVA = "0x1E11678", Offset = "0x1E11678", VA = "0x1E11678", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016586")]
	[Address(RVA = "0x1E11FF8", Offset = "0x1E11FF8", VA = "0x1E11FF8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
