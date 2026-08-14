using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003768")]
public class UIHudTeamBattleMatchResultItemView : UIBaseView
{
	[Token(Token = "0x40166AB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelfBG;

	[Token(Token = "0x40166AC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WinMVPGrade;

	[Token(Token = "0x40166AD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FailMVPGrade;

	[Token(Token = "0x40166AE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NormalGrade;

	[Token(Token = "0x40166AF")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FakeBg;

	[Token(Token = "0x40166B0")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x40166B1")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x40166B2")]
	[FieldOffset(Offset = "0x30")]
	public GameObject IconCelebrity;

	[Token(Token = "0x40166B3")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Nickname;

	[Token(Token = "0x40166B4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ClanName;

	[Token(Token = "0x40166B5")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Info1Txt;

	[Token(Token = "0x40166B6")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Info2Txt;

	[Token(Token = "0x40166B7")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info3Txt;

	[Token(Token = "0x40166B8")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BtnContainer;

	[Token(Token = "0x40166B9")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x40166BA")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ReportBtn;

	[Token(Token = "0x40166BB")]
	[FieldOffset(Offset = "0x54")]
	public UIButton LikeBtn;

	[Token(Token = "0x40166BC")]
	[FieldOffset(Offset = "0x58")]
	public GameObject LikeIcon;

	[Token(Token = "0x40166BD")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel LikeNum;

	[Token(Token = "0x40166BE")]
	[FieldOffset(Offset = "0x60")]
	public GameObject VFX_Like;

	[Token(Token = "0x40166BF")]
	[FieldOffset(Offset = "0x64")]
	public GameObject NormalRoot;

	[Token(Token = "0x40166C0")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DataRoot;

	[Token(Token = "0x40166C1")]
	[FieldOffset(Offset = "0x6C")]
	public UIHudMatchResultItemProgressBar InfoBar1;

	[Token(Token = "0x40166C2")]
	[FieldOffset(Offset = "0x70")]
	public UIHudMatchResultItemProgressBar InfoBar2;

	[Token(Token = "0x40166C3")]
	[FieldOffset(Offset = "0x74")]
	public UIHudMatchResultItemProgressBar InfoBar3;

	[Token(Token = "0x40166C4")]
	[FieldOffset(Offset = "0x78")]
	public UILabel InfoDataTxt;

	[Token(Token = "0x40166C5")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject StatisticsTips;

	[Token(Token = "0x40166C6")]
	[FieldOffset(Offset = "0x80")]
	public UIButton TipsButton;

	[Token(Token = "0x60169E3")]
	[Address(RVA = "0x1799D90", Offset = "0x1799D90", VA = "0x1799D90")]
	public UIHudTeamBattleMatchResultItemView()
	{
	}

	[Token(Token = "0x60169E4")]
	[Address(RVA = "0x1799D98", Offset = "0x1799D98", VA = "0x1799D98", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60169E5")]
	[Address(RVA = "0x179A8DC", Offset = "0x179A8DC", VA = "0x179A8DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
