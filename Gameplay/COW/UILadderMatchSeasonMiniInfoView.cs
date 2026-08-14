using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003811")]
public class UILadderMatchSeasonMiniInfoView : UIBaseView
{
	[Token(Token = "0x4016CA9")]
	[FieldOffset(Offset = "0x14")]
	public UIButton DetailBtn;

	[Token(Token = "0x4016CAA")]
	[FieldOffset(Offset = "0x18")]
	public UIButton ShareBtn;

	[Token(Token = "0x4016CAB")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ContentContainer;

	[Token(Token = "0x4016CAC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject BRRankGroup;

	[Token(Token = "0x4016CAD")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CSRankGroup;

	[Token(Token = "0x4016CAE")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SeasonOpeningObj;

	[Token(Token = "0x4016CAF")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SeasonClosedObj;

	[Token(Token = "0x4016CB0")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CurRankName;

	[Token(Token = "0x4016CB1")]
	[FieldOffset(Offset = "0x34")]
	public UISprite RankIconCurrent;

	[Token(Token = "0x4016CB2")]
	[FieldOffset(Offset = "0x38")]
	public ParticleSystem VFX_Loop;

	[Token(Token = "0x4016CB3")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject LabelScoreTip;

	[Token(Token = "0x4016CB4")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnProtectTip;

	[Token(Token = "0x4016CB5")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LabelProtectTip;

	[Token(Token = "0x4016CB6")]
	[FieldOffset(Offset = "0x48")]
	public TweenAlpha TweenTip;

	[Token(Token = "0x4016CB7")]
	[FieldOffset(Offset = "0x4C")]
	public TweenAlpha BarTween;

	[Token(Token = "0x4016CB8")]
	[FieldOffset(Offset = "0x50")]
	public UISprite BarPointFg;

	[Token(Token = "0x4016CB9")]
	[FieldOffset(Offset = "0x54")]
	public UIProgressBar BarProgressPoint;

	[Token(Token = "0x4016CBA")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ScoreInfoLabel;

	[Token(Token = "0x4016CBB")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel FinalRankName;

	[Token(Token = "0x4016CBC")]
	[FieldOffset(Offset = "0x60")]
	public UISprite RankIconFinal;

	[Token(Token = "0x4016CBD")]
	[FieldOffset(Offset = "0x64")]
	public UIGrid CSStarGrid;

	[Token(Token = "0x4016CBE")]
	[FieldOffset(Offset = "0x68")]
	public GameObject csstar1;

	[Token(Token = "0x4016CBF")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject csstar2;

	[Token(Token = "0x4016CC0")]
	[FieldOffset(Offset = "0x70")]
	public GameObject csstar3;

	[Token(Token = "0x4016CC1")]
	[FieldOffset(Offset = "0x74")]
	public GameObject csstar4;

	[Token(Token = "0x4016CC2")]
	[FieldOffset(Offset = "0x78")]
	public GameObject csstar5;

	[Token(Token = "0x4016CC3")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject csblackstar1;

	[Token(Token = "0x4016CC4")]
	[FieldOffset(Offset = "0x80")]
	public GameObject csblackstar2;

	[Token(Token = "0x4016CC5")]
	[FieldOffset(Offset = "0x84")]
	public GameObject csblackstar3;

	[Token(Token = "0x4016CC6")]
	[FieldOffset(Offset = "0x88")]
	public GameObject csblackstar4;

	[Token(Token = "0x4016CC7")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject csblackstar5;

	[Token(Token = "0x4016CC8")]
	[FieldOffset(Offset = "0x90")]
	public UILabel MaxRankTxt;

	[Token(Token = "0x4016CC9")]
	[FieldOffset(Offset = "0x94")]
	public UISprite CSRankIcon;

	[Token(Token = "0x4016CCA")]
	[FieldOffset(Offset = "0x98")]
	public UILabel CSRankName;

	[Token(Token = "0x4016CCB")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel CSPointNum;

	[Token(Token = "0x4016CCC")]
	[FieldOffset(Offset = "0xA0")]
	public UIWrapContent WrapContent;

	[Token(Token = "0x4016CCD")]
	[FieldOffset(Offset = "0xA4")]
	public Transform countDown;

	[Token(Token = "0x4016CCE")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton QuickStartBtn;

	[Token(Token = "0x4016CCF")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject BgRankOpening;

	[Token(Token = "0x4016CD0")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject BgRankUnopen;

	[Token(Token = "0x4016CD1")]
	[FieldOffset(Offset = "0xB4")]
	public UIProgressBar CSPointSprite;

	[Token(Token = "0x4016CD2")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject CSTipsRoot;

	[Token(Token = "0x4016CD3")]
	[FieldOffset(Offset = "0xBC")]
	public UIWidget CSTipsMiddle;

	[Token(Token = "0x4016CD4")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton CSTipsMiddleBtn;

	[Token(Token = "0x4016CD5")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject CSTipsTop;

	[Token(Token = "0x4016CD6")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel CSTipsTopLabel;

	[Token(Token = "0x4016CD7")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject CSBottomTip;

	[Token(Token = "0x4016CD8")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel CSTipsBottomLabel;

	[Token(Token = "0x4016CD9")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject BRStarContainer;

	[Token(Token = "0x4016CDA")]
	[FieldOffset(Offset = "0xD8")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x4016CDB")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject HeroicStarTips;

	[Token(Token = "0x4016CDC")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton HeroicStarTipsBtn;

	[Token(Token = "0x4016CDD")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject DailyMissionContainer;

	[Token(Token = "0x4016CDE")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject ToggleRankGroup;

	[Token(Token = "0x4016CDF")]
	[FieldOffset(Offset = "0xEC")]
	public UILabel LabelToggleRank;

	[Token(Token = "0x4016CE0")]
	[FieldOffset(Offset = "0xF0")]
	public UIButton ToggleRank;

	[Token(Token = "0x4016CE1")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject ToggleRankSelected;

	[Token(Token = "0x4016CE2")]
	[FieldOffset(Offset = "0xF8")]
	public UIProgressBar ItemSelectedFg;

	[Token(Token = "0x4016CE3")]
	[FieldOffset(Offset = "0xFC")]
	public UIWidget backbg;

	[Token(Token = "0x4016CE4")]
	[FieldOffset(Offset = "0x100")]
	public Animator LadderAni;

	[Token(Token = "0x4016CE5")]
	[FieldOffset(Offset = "0x104")]
	public GameObject RankCardContainer;

	[Token(Token = "0x4016CE6")]
	[FieldOffset(Offset = "0x108")]
	public UIButton ViewRankCardListBtn;

	[Token(Token = "0x4016CE7")]
	[FieldOffset(Offset = "0x10C")]
	public UISprite InUseRankCardIcon;

	[Token(Token = "0x4016CE8")]
	[FieldOffset(Offset = "0x110")]
	public UILabel RankCardCnt;

	[Token(Token = "0x4016CE9")]
	[FieldOffset(Offset = "0x114")]
	public GameObject NoCardInUseIcon;

	[Token(Token = "0x4016CEA")]
	[FieldOffset(Offset = "0x118")]
	public GameObject BRTipsRoot;

	[Token(Token = "0x4016CEB")]
	[FieldOffset(Offset = "0x11C")]
	public UIButton BRTipsMiddle;

	[Token(Token = "0x4016CEC")]
	[FieldOffset(Offset = "0x120")]
	public UIWidget WidgetBRTipsMiddle;

	[Token(Token = "0x4016CED")]
	[FieldOffset(Offset = "0x124")]
	public UILabel BRTipsTopLabel;

	[Token(Token = "0x4016CEE")]
	[FieldOffset(Offset = "0x128")]
	public GameObject BRTipsTop;

	[Token(Token = "0x4016CEF")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject BRBottomTip;

	[Token(Token = "0x4016CF0")]
	[FieldOffset(Offset = "0x130")]
	public UILabel BRTipsBottomLabel;

	[Token(Token = "0x4016CF1")]
	[FieldOffset(Offset = "0x134")]
	public UITable Table;

	[Token(Token = "0x4016CF2")]
	[FieldOffset(Offset = "0x138")]
	public GameObject Thumb;

	[Token(Token = "0x4016CF3")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject ContantScrollBar;

	[Token(Token = "0x4016CF4")]
	[FieldOffset(Offset = "0x140")]
	public GameObject GreyBg;

	[Token(Token = "0x6016BDE")]
	[Address(RVA = "0x22D57F8", Offset = "0x22D57F8", VA = "0x22D57F8")]
	public UILadderMatchSeasonMiniInfoView()
	{
	}

	[Token(Token = "0x6016BDF")]
	[Address(RVA = "0x22D5800", Offset = "0x22D5800", VA = "0x22D5800", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016BE0")]
	[Address(RVA = "0x22D73FC", Offset = "0x22D73FC", VA = "0x22D73FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
