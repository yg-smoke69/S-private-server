using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B9")]
public class UIHudUGCMultiTeamMatchResultPlayerItemView : UIBaseView
{
	[Token(Token = "0x4016912")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SelfBG;

	[Token(Token = "0x4016913")]
	[FieldOffset(Offset = "0x18")]
	public GameObject WinMVPGrade;

	[Token(Token = "0x4016914")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FailMVPGrade;

	[Token(Token = "0x4016915")]
	[FieldOffset(Offset = "0x20")]
	public UILabel NormalGrade;

	[Token(Token = "0x4016916")]
	[FieldOffset(Offset = "0x24")]
	public GameObject FakeBg;

	[Token(Token = "0x4016917")]
	[FieldOffset(Offset = "0x28")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x4016918")]
	[FieldOffset(Offset = "0x2C")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x4016919")]
	[FieldOffset(Offset = "0x30")]
	public GameObject IconCelebrity;

	[Token(Token = "0x401691A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Nickname;

	[Token(Token = "0x401691B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ClanName;

	[Token(Token = "0x401691C")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Info1Txt;

	[Token(Token = "0x401691D")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Info2Txt;

	[Token(Token = "0x401691E")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Info3Txt;

	[Token(Token = "0x401691F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel Info4Txt;

	[Token(Token = "0x4016920")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BtnContainer;

	[Token(Token = "0x4016921")]
	[FieldOffset(Offset = "0x50")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x4016922")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ReportBtn;

	[Token(Token = "0x4016923")]
	[FieldOffset(Offset = "0x58")]
	public UIButton LikeBtn;

	[Token(Token = "0x4016924")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject LikeIcon;

	[Token(Token = "0x4016925")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LikeNum;

	[Token(Token = "0x4016926")]
	[FieldOffset(Offset = "0x64")]
	public GameObject VFX_Like;

	[Token(Token = "0x6016AD6")]
	[Address(RVA = "0x1A62B20", Offset = "0x1A62B20", VA = "0x1A62B20")]
	public UIHudUGCMultiTeamMatchResultPlayerItemView()
	{
	}

	[Token(Token = "0x6016AD7")]
	[Address(RVA = "0x1A62B28", Offset = "0x1A62B28", VA = "0x1A62B28", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AD8")]
	[Address(RVA = "0x1A633F0", Offset = "0x1A633F0", VA = "0x1A633F0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
