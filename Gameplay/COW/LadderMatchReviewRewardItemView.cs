using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003389")]
public class LadderMatchReviewRewardItemView : UIBaseView
{
	[Token(Token = "0x4013A58")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RankIconNext;

	[Token(Token = "0x4013A59")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NextRankName;

	[Token(Token = "0x4013A5A")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4013A5B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel TopRewardTips;

	[Token(Token = "0x4013A5C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject SpriteCurRank;

	[Token(Token = "0x4013A5D")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ProgreessBarContainer;

	[Token(Token = "0x4013A5E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ItemNormalBgBlackPx;

	[Token(Token = "0x4013A5F")]
	[FieldOffset(Offset = "0x30")]
	public UIProgressBar ItemNormalBgYellowPx;

	[Token(Token = "0x4013A60")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Thumb;

	[Token(Token = "0x4013A61")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ArrowDark;

	[Token(Token = "0x4013A62")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Arrow;

	[Token(Token = "0x6015E52")]
	[Address(RVA = "0x1EF4200", Offset = "0x1EF4200", VA = "0x1EF4200")]
	public LadderMatchReviewRewardItemView()
	{
	}

	[Token(Token = "0x6015E53")]
	[Address(RVA = "0x1EF4208", Offset = "0x1EF4208", VA = "0x1EF4208", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E54")]
	[Address(RVA = "0x1EF4734", Offset = "0x1EF4734", VA = "0x1EF4734")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
