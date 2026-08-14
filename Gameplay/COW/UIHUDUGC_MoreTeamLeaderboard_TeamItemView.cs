using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200379A")]
public class UIHUDUGC_MoreTeamLeaderboard_TeamItemView : UIBaseView
{
	[Token(Token = "0x4016861")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Rank;

	[Token(Token = "0x4016862")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x4016863")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Score;

	[Token(Token = "0x4016864")]
	[FieldOffset(Offset = "0x20")]
	public UISprite TeamColorNoAlpha;

	[Token(Token = "0x4016865")]
	[FieldOffset(Offset = "0x24")]
	public UISprite TeamColor;

	[Token(Token = "0x4016866")]
	[FieldOffset(Offset = "0x28")]
	public UIButton HelpBtn;

	[Token(Token = "0x4016867")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid TitleGrid;

	[Token(Token = "0x4016868")]
	[FieldOffset(Offset = "0x30")]
	public GameObject LabelTemp;

	[Token(Token = "0x4016869")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid TeammateGrid;

	[Token(Token = "0x6016A79")]
	[Address(RVA = "0x2E18F44", Offset = "0x2E18F44", VA = "0x2E18F44")]
	public UIHUDUGC_MoreTeamLeaderboard_TeamItemView()
	{
	}

	[Token(Token = "0x6016A7A")]
	[Address(RVA = "0x2E18F4C", Offset = "0x2E18F4C", VA = "0x2E18F4C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A7B")]
	[Address(RVA = "0x2E193E8", Offset = "0x2E193E8", VA = "0x2E193E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
