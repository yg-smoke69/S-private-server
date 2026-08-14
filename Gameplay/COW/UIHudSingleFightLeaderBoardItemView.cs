using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200374B")]
public class UIHudSingleFightLeaderBoardItemView : UIBaseView
{
	[Token(Token = "0x40165BB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelfBG;

	[Token(Token = "0x40165BC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Rank1Icon;

	[Token(Token = "0x40165BD")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject Rank2Icon;

	[Token(Token = "0x40165BE")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Rank3Icon;

	[Token(Token = "0x40165BF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RankLabel;

	[Token(Token = "0x40165C0")]
	[FieldOffset(Offset = "0x28")]
	public GameObject FakeBg;

	[Token(Token = "0x40165C1")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x40165C2")]
	[FieldOffset(Offset = "0x30")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x40165C3")]
	[FieldOffset(Offset = "0x34")]
	public GameObject IconCelebrity;

	[Token(Token = "0x40165C4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Nickname;

	[Token(Token = "0x40165C5")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel ClanName;

	[Token(Token = "0x40165C6")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Info1Txt;

	[Token(Token = "0x40165C7")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info2Txt;

	[Token(Token = "0x40165C8")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Info3Txt;

	[Token(Token = "0x40165C9")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel Info4Txt;

	[Token(Token = "0x40165CA")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x40165CB")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ReportBtn;

	[Token(Token = "0x40165CC")]
	[FieldOffset(Offset = "0x58")]
	public UIButton LikeBtn;

	[Token(Token = "0x40165CD")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LikeIcon;

	[Token(Token = "0x40165CE")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LikeNum;

	[Token(Token = "0x40165CF")]
	[FieldOffset(Offset = "0x64")]
	public GameObject VFX_Like;

	[Token(Token = "0x40165D0")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GrayBG;

	[Token(Token = "0x601698C")]
	[Address(RVA = "0x16BBAD8", Offset = "0x16BBAD8", VA = "0x16BBAD8")]
	public UIHudSingleFightLeaderBoardItemView()
	{
	}

	[Token(Token = "0x601698D")]
	[Address(RVA = "0x16BBAE0", Offset = "0x16BBAE0", VA = "0x16BBAE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601698E")]
	[Address(RVA = "0x16BC3FC", Offset = "0x16BC3FC", VA = "0x16BC3FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
