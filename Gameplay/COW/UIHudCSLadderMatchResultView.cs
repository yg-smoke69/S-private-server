using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003620")]
public class UIHudCSLadderMatchResultView : UIBaseView
{
	[Token(Token = "0x4015ABC")]
	[FieldOffset(Offset = "0x14")]
	public Animation HudCSLadderMatchResultAnim;

	[Token(Token = "0x4015ABD")]
	[FieldOffset(Offset = "0x18")]
	public Animation RankInfoAnim;

	[Token(Token = "0x4015ABE")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite RankAfterSprite;

	[Token(Token = "0x4015ABF")]
	[FieldOffset(Offset = "0x20")]
	public UITable RankAfterStarTable;

	[Token(Token = "0x4015AC0")]
	[FieldOffset(Offset = "0x24")]
	public Animation AfterLabelAnim;

	[Token(Token = "0x4015AC1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel CurRankCountLabel_2;

	[Token(Token = "0x4015AC2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CurLabelHeriocStarMax_2;

	[Token(Token = "0x4015AC3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CurRankCountLabel;

	[Token(Token = "0x4015AC4")]
	[FieldOffset(Offset = "0x34")]
	public UILabel CurLabelHeriocStarMax;

	[Token(Token = "0x4015AC5")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RankNameAfter;

	[Token(Token = "0x4015AC6")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RankBeforeSprite;

	[Token(Token = "0x4015AC7")]
	[FieldOffset(Offset = "0x40")]
	public UITable RankBeforeStarTable;

	[Token(Token = "0x4015AC8")]
	[FieldOffset(Offset = "0x44")]
	public Animation BeforeLabelAnim;

	[Token(Token = "0x4015AC9")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BeforeRankCountLabel;

	[Token(Token = "0x4015ACA")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel BeforeLabelHeriocStarMax;

	[Token(Token = "0x4015ACB")]
	[FieldOffset(Offset = "0x50")]
	public UILabel BeforeRankCountLabel_2;

	[Token(Token = "0x4015ACC")]
	[FieldOffset(Offset = "0x54")]
	public UILabel BeforeLabelHeriocStarMax_2;

	[Token(Token = "0x4015ACD")]
	[FieldOffset(Offset = "0x58")]
	public UILabel RankNameBefore;

	[Token(Token = "0x4015ACE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ScoreInfoContainer;

	[Token(Token = "0x4015ACF")]
	[FieldOffset(Offset = "0x60")]
	public UITable ScoreTable;

	[Token(Token = "0x4015AD0")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ScoreInfo1;

	[Token(Token = "0x4015AD1")]
	[FieldOffset(Offset = "0x68")]
	public UILabel ScoreInfo2;

	[Token(Token = "0x4015AD2")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject ProtectContent;

	[Token(Token = "0x4015AD3")]
	[FieldOffset(Offset = "0x70")]
	public UILabel ProtectLabel;

	[Token(Token = "0x4015AD4")]
	[FieldOffset(Offset = "0x74")]
	public TweenScale TweenScaleProtectProgressBar;

	[Token(Token = "0x4015AD5")]
	[FieldOffset(Offset = "0x78")]
	public UIProgressBar ProtectProgressBar;

	[Token(Token = "0x4015AD6")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel LabelProtectPointChanges;

	[Token(Token = "0x4015AD7")]
	[FieldOffset(Offset = "0x80")]
	public TweenAlpha TweenAlphaProtectPointChanges;

	[Token(Token = "0x4015AD8")]
	[FieldOffset(Offset = "0x84")]
	public Animation ShieldAnim;

	[Token(Token = "0x4015AD9")]
	[FieldOffset(Offset = "0x88")]
	public UILabel Label01;

	[Token(Token = "0x4015ADA")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel Label02;

	[Token(Token = "0x4015ADB")]
	[FieldOffset(Offset = "0x90")]
	public UIButton BackMaskBtn;

	[Token(Token = "0x4015ADC")]
	[FieldOffset(Offset = "0x94")]
	public GameObject RankStar;

	[Token(Token = "0x4015ADD")]
	[FieldOffset(Offset = "0x98")]
	public GameObject LabelAntiHack;

	[Token(Token = "0x4015ADE")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject LabelProtectCompensationPoints;

	[Token(Token = "0x4015ADF")]
	[FieldOffset(Offset = "0xA0")]
	public Transform RankResultBigAniContainer;

	[Token(Token = "0x601660F")]
	[Address(RVA = "0x1F0F57C", Offset = "0x1F0F57C", VA = "0x1F0F57C")]
	public UIHudCSLadderMatchResultView()
	{
	}

	[Token(Token = "0x6016610")]
	[Address(RVA = "0x1F0F584", Offset = "0x1F0F584", VA = "0x1F0F584", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016611")]
	[Address(RVA = "0x1F103E8", Offset = "0x1F103E8", VA = "0x1F103E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
