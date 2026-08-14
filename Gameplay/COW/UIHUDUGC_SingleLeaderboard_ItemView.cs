using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037AB")]
public class UIHUDUGC_SingleLeaderboard_ItemView : UIBaseView
{
	[Token(Token = "0x40168A7")]
	[FieldOffset(Offset = "0x14")]
	public UIEffectSprite BannerBg;

	[Token(Token = "0x40168A8")]
	[FieldOffset(Offset = "0x18")]
	public UIEffectSprite HeadIcon;

	[Token(Token = "0x40168A9")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel ClanName;

	[Token(Token = "0x40168AA")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Nickname;

	[Token(Token = "0x40168AB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x40168AC")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid LabelGrid;

	[Token(Token = "0x40168AD")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject LabelTemp;

	[Token(Token = "0x40168AE")]
	[FieldOffset(Offset = "0x30")]
	public GameObject DefaultBg;

	[Token(Token = "0x40168AF")]
	[FieldOffset(Offset = "0x34")]
	public GameObject SelfBg;

	[Token(Token = "0x40168B0")]
	[FieldOffset(Offset = "0x38")]
	public UILabel RankLabel;

	[Token(Token = "0x40168B1")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite RankSprite;

	[Token(Token = "0x40168B2")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LV;

	[Token(Token = "0x6016AAC")]
	[Address(RVA = "0x29227B0", Offset = "0x29227B0", VA = "0x29227B0")]
	public UIHUDUGC_SingleLeaderboard_ItemView()
	{
	}

	[Token(Token = "0x6016AAD")]
	[Address(RVA = "0x29227B8", Offset = "0x29227B8", VA = "0x29227B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016AAE")]
	[Address(RVA = "0x2922D50", Offset = "0x2922D50", VA = "0x2922D50")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
