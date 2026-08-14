using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200371C")]
public class UIHUDRushingPetsMatchInfoView : UIBaseView
{
	[Token(Token = "0x4016441")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GameTimeRoot;

	[Token(Token = "0x4016442")]
	[FieldOffset(Offset = "0x18")]
	public UILabel GemeTimeLabel;

	[Token(Token = "0x4016443")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RoundCountRoot;

	[Token(Token = "0x4016444")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RoundLabel;

	[Token(Token = "0x4016445")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LevelPlayerCountInfoRoot;

	[Token(Token = "0x4016446")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LevelFlowTargetFinishSprite;

	[Token(Token = "0x4016447")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LevelFlowEliminationSprite;

	[Token(Token = "0x4016448")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PlayerCountLabel;

	[Token(Token = "0x4016449")]
	[FieldOffset(Offset = "0x34")]
	public GameObject PlayerScoreRoot;

	[Token(Token = "0x401644A")]
	[FieldOffset(Offset = "0x38")]
	public UILabel PlayerScoreLabel;

	[Token(Token = "0x401644B")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject RoundBeginRoot;

	[Token(Token = "0x401644C")]
	[FieldOffset(Offset = "0x40")]
	public UITexture LevelTexture;

	[Token(Token = "0x401644D")]
	[FieldOffset(Offset = "0x44")]
	public UILabel RoundBeginTitleLabel;

	[Token(Token = "0x401644E")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LevelPlayRuleLabel;

	[Token(Token = "0x401644F")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LevelNameLabel;

	[Token(Token = "0x60168FF")]
	[Address(RVA = "0x220D574", Offset = "0x220D574", VA = "0x220D574")]
	public UIHUDRushingPetsMatchInfoView()
	{
	}

	[Token(Token = "0x6016900")]
	[Address(RVA = "0x220D57C", Offset = "0x220D57C", VA = "0x220D57C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016901")]
	[Address(RVA = "0x220DC10", Offset = "0x220DC10", VA = "0x220DC10")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
