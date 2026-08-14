using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037B1")]
public class UIHUDUGC_TwoTeamLeaderboard_TeammateItemView : UIBaseView
{
	[Token(Token = "0x40168DC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject FakeBg;

	[Token(Token = "0x40168DD")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x40168DE")]
	[FieldOffset(Offset = "0x1C")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x40168DF")]
	[FieldOffset(Offset = "0x20")]
	public UILabel ClanName;

	[Token(Token = "0x40168E0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Nickname;

	[Token(Token = "0x40168E1")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x40168E2")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid LabelGrid;

	[Token(Token = "0x40168E3")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LabelTemp;

	[Token(Token = "0x40168E4")]
	[FieldOffset(Offset = "0x34")]
	public GameObject DefaultBg;

	[Token(Token = "0x40168E5")]
	[FieldOffset(Offset = "0x38")]
	public GameObject SelfBg;

	[Token(Token = "0x6016ABE")]
	[Address(RVA = "0x292AF34", Offset = "0x292AF34", VA = "0x292AF34")]
	public UIHUDUGC_TwoTeamLeaderboard_TeammateItemView()
	{
	}

	[Token(Token = "0x6016ABF")]
	[Address(RVA = "0x292AF3C", Offset = "0x292AF3C", VA = "0x292AF3C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AC0")]
	[Address(RVA = "0x292B408", Offset = "0x292B408", VA = "0x292B408")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
