using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003931")]
public class UIProfileTeamBattleMatchResultItemView : UIBaseView
{
	[Token(Token = "0x4017DF4")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelfBG;

	[Token(Token = "0x4017DF5")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WinMVPGrade;

	[Token(Token = "0x4017DF6")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FailMVPGrade;

	[Token(Token = "0x4017DF7")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NormalGrade;

	[Token(Token = "0x4017DF8")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FakeBg;

	[Token(Token = "0x4017DF9")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x4017DFA")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x4017DFB")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x4017DFC")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnHead;

	[Token(Token = "0x4017DFD")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Nickname;

	[Token(Token = "0x4017DFE")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ClanName;

	[Token(Token = "0x4017DFF")]
	[FieldOffset(Offset = "0x40")]
	public UIEffectSprite RankIcon;

	[Token(Token = "0x4017E00")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info1Txt;

	[Token(Token = "0x4017E01")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Info2Txt;

	[Token(Token = "0x4017E02")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Info3Txt;

	[Token(Token = "0x4017E03")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x4017E04")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ReportBtn;

	[Token(Token = "0x4017E05")]
	[FieldOffset(Offset = "0x58")]
	public UISprite ReportSprite;

	[Token(Token = "0x4017E06")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LikeContainer;

	[Token(Token = "0x4017E07")]
	[FieldOffset(Offset = "0x60")]
	public UIButton LikeBtn;

	[Token(Token = "0x4017E08")]
	[FieldOffset(Offset = "0x64")]
	public UILabel LikeNum;

	[Token(Token = "0x4017E09")]
	[FieldOffset(Offset = "0x68")]
	public GameObject NormalRoot;

	[Token(Token = "0x4017E0A")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject DataRoot;

	[Token(Token = "0x4017E0B")]
	[FieldOffset(Offset = "0x70")]
	public UIHudMatchResultItemProgressBar InforBar1;

	[Token(Token = "0x4017E0C")]
	[FieldOffset(Offset = "0x74")]
	public UIHudMatchResultItemProgressBar InforBar2;

	[Token(Token = "0x4017E0D")]
	[FieldOffset(Offset = "0x78")]
	public UIHudMatchResultItemProgressBar InforBar3;

	[Token(Token = "0x4017E0E")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel InfoDataTxt;

	[Token(Token = "0x6016F3A")]
	[Address(RVA = "0x1ABB04C", Offset = "0x1ABB04C", VA = "0x1ABB04C")]
	public UIProfileTeamBattleMatchResultItemView()
	{
	}

	[Token(Token = "0x6016F3B")]
	[Address(RVA = "0x1ABB054", Offset = "0x1ABB054", VA = "0x1ABB054", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F3C")]
	[Address(RVA = "0x1ABBB5C", Offset = "0x1ABBB5C", VA = "0x1ABBB5C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
