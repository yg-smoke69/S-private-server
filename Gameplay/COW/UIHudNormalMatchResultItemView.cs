using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036C1")]
public class UIHudNormalMatchResultItemView : UIBaseView
{
	[Token(Token = "0x4016128")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelfBG;

	[Token(Token = "0x4016129")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WinMVPGrade;

	[Token(Token = "0x401612A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FailMVPGrade;

	[Token(Token = "0x401612B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NormalGrade;

	[Token(Token = "0x401612C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FakeBg;

	[Token(Token = "0x401612D")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x401612E")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x401612F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject IconCelebrity;

	[Token(Token = "0x4016130")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Nickname;

	[Token(Token = "0x4016131")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ClanName;

	[Token(Token = "0x4016132")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Info1Txt;

	[Token(Token = "0x4016133")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Info2Txt;

	[Token(Token = "0x4016134")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info3Txt;

	[Token(Token = "0x4016135")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Info4Txt;

	[Token(Token = "0x4016136")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x4016137")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ReportBtn;

	[Token(Token = "0x4016138")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LikeBtn;

	[Token(Token = "0x4016139")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LikeIcon;

	[Token(Token = "0x401613A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel LikeNum;

	[Token(Token = "0x401613B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject VFX_Like;

	[Token(Token = "0x401613C")]
	[FieldOffset(Offset = "0x64")]
	public UIHudMatchResultItemProgressBar InfoBar1;

	[Token(Token = "0x401613D")]
	[FieldOffset(Offset = "0x68")]
	public UIHudMatchResultItemProgressBar InfoBar2;

	[Token(Token = "0x401613E")]
	[FieldOffset(Offset = "0x6C")]
	public UIHudMatchResultItemProgressBar InfoBar3;

	[Token(Token = "0x401613F")]
	[FieldOffset(Offset = "0x70")]
	public UIHudMatchResultItemProgressBar InfoBar4;

	[Token(Token = "0x4016140")]
	[FieldOffset(Offset = "0x74")]
	public GameObject DataRoot;

	[Token(Token = "0x4016141")]
	[FieldOffset(Offset = "0x78")]
	public GameObject NormalRoot;

	[Token(Token = "0x4016142")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel InfoDataTxt;

	[Token(Token = "0x4016143")]
	[FieldOffset(Offset = "0x80")]
	public UILabel Info5Txt;

	[Token(Token = "0x4016144")]
	[FieldOffset(Offset = "0x84")]
	public UIHudMatchResultItemProgressBar InfoBar5;

	[Token(Token = "0x4016145")]
	[FieldOffset(Offset = "0x88")]
	public GameObject StatisticsTips;

	[Token(Token = "0x4016146")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton TipsButton;

	[Token(Token = "0x60167F0")]
	[Address(RVA = "0x1F57818", Offset = "0x1F57818", VA = "0x1F57818")]
	public UIHudNormalMatchResultItemView()
	{
	}

	[Token(Token = "0x60167F1")]
	[Address(RVA = "0x1F57820", Offset = "0x1F57820", VA = "0x1F57820", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167F2")]
	[Address(RVA = "0x1F58490", Offset = "0x1F58490", VA = "0x1F58490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
