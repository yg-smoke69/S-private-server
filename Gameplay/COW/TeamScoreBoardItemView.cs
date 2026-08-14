using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003394")]
public class TeamScoreBoardItemView : UIBaseView
{
	[Token(Token = "0x4013AB7")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MVPGrade;

	[Token(Token = "0x4013AB8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NormalGrade;

	[Token(Token = "0x4013AB9")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpecialIcon;

	[Token(Token = "0x4013ABA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject MaxRankNode;

	[Token(Token = "0x4013ABB")]
	[FieldOffset(Offset = "0x24")]
	public UISprite MaxRankIcon;

	[Token(Token = "0x4013ABC")]
	[FieldOffset(Offset = "0x28")]
	public UILabel MaxRankTxt;

	[Token(Token = "0x4013ABD")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x4013ABE")]
	[FieldOffset(Offset = "0x30")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x4013ABF")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Nickname;

	[Token(Token = "0x4013AC0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ClanName;

	[Token(Token = "0x4013AC1")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x4013AC2")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Info1Txt;

	[Token(Token = "0x4013AC3")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info2Txt;

	[Token(Token = "0x4013AC4")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Info3Txt;

	[Token(Token = "0x4013AC5")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BGGray;

	[Token(Token = "0x4013AC6")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ReportBtn;

	[Token(Token = "0x4013AC7")]
	[FieldOffset(Offset = "0x54")]
	public UISprite SkillSprite;

	[Token(Token = "0x4013AC8")]
	[FieldOffset(Offset = "0x58")]
	public UIEventListener SkillBtn;

	[Token(Token = "0x4013AC9")]
	[FieldOffset(Offset = "0x5C")]
	public UISprite SkillCDProgress;

	[Token(Token = "0x4013ACA")]
	[FieldOffset(Offset = "0x60")]
	public UISprite SkillEffectProgress;

	[Token(Token = "0x4013ACB")]
	[FieldOffset(Offset = "0x64")]
	public GameObject SkillContainer;

	[Token(Token = "0x4013ACC")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SelfBG;

	[Token(Token = "0x6015E72")]
	[Address(RVA = "0x28A043C", Offset = "0x28A043C", VA = "0x28A043C")]
	public TeamScoreBoardItemView()
	{
	}

	[Token(Token = "0x6015E73")]
	[Address(RVA = "0x28A0444", Offset = "0x28A0444", VA = "0x28A0444", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E74")]
	[Address(RVA = "0x28A0D84", Offset = "0x28A0D84", VA = "0x28A0D84")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
