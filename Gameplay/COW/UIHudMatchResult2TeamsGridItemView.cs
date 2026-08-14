using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036AC")]
public class UIHudMatchResult2TeamsGridItemView : UIBaseView
{
	[Token(Token = "0x4016048")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Self;

	[Token(Token = "0x4016049")]
	[FieldOffset(Offset = "0x18")]
	public UIButton SimpleProfileInfo;

	[Token(Token = "0x401604A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject fakeBg;

	[Token(Token = "0x401604B")]
	[FieldOffset(Offset = "0x20")]
	public UIEffectSprite bannerBg;

	[Token(Token = "0x401604C")]
	[FieldOffset(Offset = "0x24")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x401604D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject infoContainer;

	[Token(Token = "0x401604E")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel nickname;

	[Token(Token = "0x401604F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel clanName;

	[Token(Token = "0x4016050")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Kill;

	[Token(Token = "0x4016051")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Death;

	[Token(Token = "0x4016052")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Assist;

	[Token(Token = "0x4016053")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Damage;

	[Token(Token = "0x4016054")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Evaluation;

	[Token(Token = "0x4016055")]
	[FieldOffset(Offset = "0x48")]
	public GameObject Mvp;

	[Token(Token = "0x4016056")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton AddFriendBtn;

	[Token(Token = "0x60167B1")]
	[Address(RVA = "0x100348C", Offset = "0x100348C", VA = "0x100348C")]
	public UIHudMatchResult2TeamsGridItemView()
	{
	}

	[Token(Token = "0x60167B2")]
	[Address(RVA = "0x1003494", Offset = "0x1003494", VA = "0x1003494", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60167B3")]
	[Address(RVA = "0x1003B4C", Offset = "0x1003B4C", VA = "0x1003B4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
