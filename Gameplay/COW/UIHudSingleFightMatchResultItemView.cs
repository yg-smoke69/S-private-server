using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200374D")]
public class UIHudSingleFightMatchResultItemView : UIBaseView
{
	[Token(Token = "0x40165D9")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelfBG;

	[Token(Token = "0x40165DA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Rank1Icon;

	[Token(Token = "0x40165DB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Rank2Icon;

	[Token(Token = "0x40165DC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Rank3Icon;

	[Token(Token = "0x40165DD")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RankLabel;

	[Token(Token = "0x40165DE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FakeBg;

	[Token(Token = "0x40165DF")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x40165E0")]
	[FieldOffset(Offset = "0x30")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x40165E1")]
	[FieldOffset(Offset = "0x34")]
	public GameObject IconCelebrity;

	[Token(Token = "0x40165E2")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Nickname;

	[Token(Token = "0x40165E3")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ClanName;

	[Token(Token = "0x40165E4")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Info1Txt;

	[Token(Token = "0x40165E5")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info2Txt;

	[Token(Token = "0x40165E6")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Info3Txt;

	[Token(Token = "0x40165E7")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Info4Txt;

	[Token(Token = "0x40165E8")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x40165E9")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ReportBtn;

	[Token(Token = "0x40165EA")]
	[FieldOffset(Offset = "0x58")]
	public UIButton LikeBtn;

	[Token(Token = "0x40165EB")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LikeIcon;

	[Token(Token = "0x40165EC")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LikeNum;

	[Token(Token = "0x40165ED")]
	[FieldOffset(Offset = "0x64")]
	public GameObject VFX_Like;

	[Token(Token = "0x6016992")]
	[Address(RVA = "0x16BFEF8", Offset = "0x16BFEF8", VA = "0x16BFEF8")]
	public UIHudSingleFightMatchResultItemView()
	{
	}

	[Token(Token = "0x6016993")]
	[Address(RVA = "0x16BFF00", Offset = "0x16BFF00", VA = "0x16BFF00", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016994")]
	[Address(RVA = "0x16C07C8", Offset = "0x16C07C8", VA = "0x16C07C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
