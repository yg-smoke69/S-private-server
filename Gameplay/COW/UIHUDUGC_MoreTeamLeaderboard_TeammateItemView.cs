using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200379B")]
public class UIHUDUGC_MoreTeamLeaderboard_TeammateItemView : UIBaseView
{
	[Token(Token = "0x401686A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject FakeBg;

	[Token(Token = "0x401686B")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x401686C")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x401686D")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ClanName;

	[Token(Token = "0x401686E")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Nickname;

	[Token(Token = "0x401686F")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x4016870")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid LabelGrid;

	[Token(Token = "0x4016871")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LabelTemp;

	[Token(Token = "0x4016872")]
	[FieldOffset(Offset = "0x34")]
	public GameObject DefaultBg;

	[Token(Token = "0x4016873")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SelfBg;

	[Token(Token = "0x6016A7C")]
	[Address(RVA = "0x2E1A03C", Offset = "0x2E1A03C", VA = "0x2E1A03C")]
	public UIHUDUGC_MoreTeamLeaderboard_TeammateItemView()
	{
	}

	[Token(Token = "0x6016A7D")]
	[Address(RVA = "0x2E1A044", Offset = "0x2E1A044", VA = "0x2E1A044", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A7E")]
	[Address(RVA = "0x2E1A510", Offset = "0x2E1A510", VA = "0x2E1A510")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
