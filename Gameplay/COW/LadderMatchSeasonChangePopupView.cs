using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200338B")]
public class LadderMatchSeasonChangePopupView : UIBaseView
{
	[Token(Token = "0x4013A6C")]
	[FieldOffset(Offset = "0x14")]
	public Animator ViewAnimator;

	[Token(Token = "0x4013A6D")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SeasonRankContainer;

	[Token(Token = "0x4013A6E")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RankIconAnim;

	[Token(Token = "0x4013A6F")]
	[FieldOffset(Offset = "0x20")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x4013A70")]
	[FieldOffset(Offset = "0x24")]
	public GameObject RankIconRoot;

	[Token(Token = "0x4013A71")]
	[FieldOffset(Offset = "0x28")]
	public UILabel RankLabel;

	[Token(Token = "0x4013A72")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel RankSeasonLabel;

	[Token(Token = "0x4013A73")]
	[FieldOffset(Offset = "0x30")]
	public GameObject SeverRankRoot;

	[Token(Token = "0x4013A74")]
	[FieldOffset(Offset = "0x34")]
	public UILabel PeakRankPosition;

	[Token(Token = "0x4013A75")]
	[FieldOffset(Offset = "0x38")]
	public UILabel NickName;

	[Token(Token = "0x4013A76")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture SelfIcon;

	[Token(Token = "0x4013A77")]
	[FieldOffset(Offset = "0x40")]
	public UIEffectSprite HeadSprite;

	[Token(Token = "0x4013A78")]
	[FieldOffset(Offset = "0x44")]
	public GameObject NewSeasonInfoContainer;

	[Token(Token = "0x4013A79")]
	[FieldOffset(Offset = "0x48")]
	public GameObject NewSeasonLabelAnim;

	[Token(Token = "0x4013A7A")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel NewSeasonLabel;

	[Token(Token = "0x4013A7B")]
	[FieldOffset(Offset = "0x50")]
	public Animation NewSeasonInfo;

	[Token(Token = "0x4013A7C")]
	[FieldOffset(Offset = "0x54")]
	public UILabel Txt_NewSeasonTime;

	[Token(Token = "0x4013A7D")]
	[FieldOffset(Offset = "0x58")]
	public UILabel SeasonIconLabel;

	[Token(Token = "0x4013A7E")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ContinueBtnAnim;

	[Token(Token = "0x4013A7F")]
	[FieldOffset(Offset = "0x60")]
	public UILabel BtnLabel;

	[Token(Token = "0x4013A80")]
	[FieldOffset(Offset = "0x64")]
	public UIButton ContinueBtn;

	[Token(Token = "0x4013A81")]
	[FieldOffset(Offset = "0x68")]
	public UINetworkTexture SeasonRewardBGCDN;

	[Token(Token = "0x4013A82")]
	[FieldOffset(Offset = "0x6C")]
	public UIScrollView SeasonExchangeRewardScrollView;

	[Token(Token = "0x4013A83")]
	[FieldOffset(Offset = "0x70")]
	public UIScrollView SeasonAwardScrollView;

	[Token(Token = "0x4013A84")]
	[FieldOffset(Offset = "0x74")]
	public UIEasyList SeasonAwardEasyList;

	[Token(Token = "0x4013A85")]
	[FieldOffset(Offset = "0x78")]
	public UIEasyList SeasonExchangeRewardEasyList;

	[Token(Token = "0x4013A86")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject SeasonExchangeRewardContainer;

	[Token(Token = "0x4013A87")]
	[FieldOffset(Offset = "0x80")]
	public GameObject SeasonAwardContainer;

	[Token(Token = "0x4013A88")]
	[FieldOffset(Offset = "0x84")]
	public UILabel SeasonNameLabel;

	[Token(Token = "0x4013A89")]
	[FieldOffset(Offset = "0x88")]
	public UILabel SeasonPeriodLabel;

	[Token(Token = "0x4013A8A")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject NewSeasonRewardContainer;

	[Token(Token = "0x4013A8B")]
	[FieldOffset(Offset = "0x90")]
	public Transform RewardPreviewDescNode;

	[Token(Token = "0x4013A8C")]
	[FieldOffset(Offset = "0x94")]
	public UILabel Txt_RankSeasonTime;

	[Token(Token = "0x4013A8D")]
	[FieldOffset(Offset = "0x98")]
	public UILabel RankTypeLabel;

	[Token(Token = "0x6015E58")]
	[Address(RVA = "0x1EF4BE8", Offset = "0x1EF4BE8", VA = "0x1EF4BE8")]
	public LadderMatchSeasonChangePopupView()
	{
	}

	[Token(Token = "0x6015E59")]
	[Address(RVA = "0x1EF4BF0", Offset = "0x1EF4BF0", VA = "0x1EF4BF0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E5A")]
	[Address(RVA = "0x1EF5958", Offset = "0x1EF5958", VA = "0x1EF5958")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
