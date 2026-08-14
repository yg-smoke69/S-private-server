using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039A3")]
public class UISeasonStatsDetailView : UIBaseView
{
	[Token(Token = "0x40182BB")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BRExtraBg;

	[Token(Token = "0x40182BC")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BRRankGroup;

	[Token(Token = "0x40182BD")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel mMatchCount;

	[Token(Token = "0x40182BE")]
	[FieldOffset(Offset = "0x20")]
	public UILabel bKD;

	[Token(Token = "0x40182BF")]
	[FieldOffset(Offset = "0x24")]
	public UILabel mWins;

	[Token(Token = "0x40182C0")]
	[FieldOffset(Offset = "0x28")]
	public UILabel mMostRankLevel;

	[Token(Token = "0x40182C1")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel mMostRankPoint;

	[Token(Token = "0x40182C2")]
	[FieldOffset(Offset = "0x30")]
	public UILabel mTop10P;

	[Token(Token = "0x40182C3")]
	[FieldOffset(Offset = "0x34")]
	public UILabel mTop50P;

	[Token(Token = "0x40182C4")]
	[FieldOffset(Offset = "0x38")]
	public UILabel mSurvialTime;

	[Token(Token = "0x40182C5")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel mMoveDistance;

	[Token(Token = "0x40182C6")]
	[FieldOffset(Offset = "0x40")]
	public UILabel bTotalKill;

	[Token(Token = "0x40182C7")]
	[FieldOffset(Offset = "0x44")]
	public UILabel bHeadShot;

	[Token(Token = "0x40182C8")]
	[FieldOffset(Offset = "0x48")]
	public UILabel bAvgKill;

	[Token(Token = "0x40182C9")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel bAvgDamage;

	[Token(Token = "0x40182CA")]
	[FieldOffset(Offset = "0x50")]
	public UILabel bMostKill;

	[Token(Token = "0x40182CB")]
	[FieldOffset(Offset = "0x54")]
	public UILabel bMostDamage;

	[Token(Token = "0x40182CC")]
	[FieldOffset(Offset = "0x58")]
	public UILabel bRevivals;

	[Token(Token = "0x40182CD")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject CSRankGroup;

	[Token(Token = "0x40182CE")]
	[FieldOffset(Offset = "0x60")]
	public UILabel CSMatchCount;

	[Token(Token = "0x40182CF")]
	[FieldOffset(Offset = "0x64")]
	public GameObject KDRatioLabel;

	[Token(Token = "0x40182D0")]
	[FieldOffset(Offset = "0x68")]
	public UILabel CSKDRatio;

	[Token(Token = "0x40182D1")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject GoDetailStatsCS;

	[Token(Token = "0x40182D2")]
	[FieldOffset(Offset = "0x70")]
	public UILabel CSWins;

	[Token(Token = "0x40182D3")]
	[FieldOffset(Offset = "0x74")]
	public UILabel CSMostRankLevel;

	[Token(Token = "0x40182D4")]
	[FieldOffset(Offset = "0x78")]
	public GameObject MVPLabel;

	[Token(Token = "0x40182D5")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel CSMvp;

	[Token(Token = "0x40182D6")]
	[FieldOffset(Offset = "0x80")]
	public GameObject WinRateLabel;

	[Token(Token = "0x40182D7")]
	[FieldOffset(Offset = "0x84")]
	public UILabel CSWinRate;

	[Token(Token = "0x40182D8")]
	[FieldOffset(Offset = "0x88")]
	public GameObject AVGDamageLabel;

	[Token(Token = "0x40182D9")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel CSAVGDamage;

	[Token(Token = "0x40182DA")]
	[FieldOffset(Offset = "0x90")]
	public GameObject RevivesLabel;

	[Token(Token = "0x40182DB")]
	[FieldOffset(Offset = "0x94")]
	public UILabel CSRevives;

	[Token(Token = "0x40182DC")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TotalKillLabel;

	[Token(Token = "0x40182DD")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel CSTotalKill;

	[Token(Token = "0x40182DE")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject DoubleKillLabel;

	[Token(Token = "0x40182DF")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel CSDoubleKill;

	[Token(Token = "0x40182E0")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject ThreekillLabel;

	[Token(Token = "0x40182E1")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel CSThreeKill;

	[Token(Token = "0x40182E2")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject FourKillLabel;

	[Token(Token = "0x40182E3")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel CSFourKill;

	[Token(Token = "0x40182E4")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject HeadShotLabel;

	[Token(Token = "0x40182E5")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel CSHeadShot;

	[Token(Token = "0x40182E6")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject HeadShotRatioLabel;

	[Token(Token = "0x40182E7")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel CSHeadShotRatio;

	[Token(Token = "0x40182E8")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject GoDetailStatsPeriodic;

	[Token(Token = "0x40182E9")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel PeriodicWins;

	[Token(Token = "0x40182EA")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel PeriodicMaxRank;

	[Token(Token = "0x40182EB")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel PeriodicAVGDamage;

	[Token(Token = "0x40182EC")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel PeriodicHeadShot;

	[Token(Token = "0x40182ED")]
	[FieldOffset(Offset = "0xDC")]
	public UILabel PeriodicTotalKill;

	[Token(Token = "0x40182EE")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel PeriodicWinRate;

	[Token(Token = "0x40182EF")]
	[FieldOffset(Offset = "0xE4")]
	public UILabel PeriodicAssists;

	[Token(Token = "0x40182F0")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel PeriodicHeadShotKillRate;

	[Token(Token = "0x40182F1")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject BRRankLevel;

	[Token(Token = "0x40182F2")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite RankIconCurrent;

	[Token(Token = "0x40182F3")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel CurRankName;

	[Token(Token = "0x40182F4")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject RankEffect;

	[Token(Token = "0x40182F5")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject HeroicLeveContainer;

	[Token(Token = "0x40182F6")]
	[FieldOffset(Offset = "0x100")]
	public UILadderMatchHeroicLevelView UILadderMatchHeroic;

	[Token(Token = "0x40182F7")]
	[FieldOffset(Offset = "0x104")]
	public UILabel SeasonInfoLabel;

	[Token(Token = "0x40182F8")]
	[FieldOffset(Offset = "0x108")]
	public UILabel SeasonLabel;

	[Token(Token = "0x40182F9")]
	[FieldOffset(Offset = "0x10C")]
	public UILabel RankType;

	[Token(Token = "0x40182FA")]
	[FieldOffset(Offset = "0x110")]
	public GameObject CSRankLevel;

	[Token(Token = "0x40182FB")]
	[FieldOffset(Offset = "0x114")]
	public UILabel LabelStarRankType;

	[Token(Token = "0x40182FC")]
	[FieldOffset(Offset = "0x118")]
	public UIGrid CSGrid;

	[Token(Token = "0x40182FD")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject star1;

	[Token(Token = "0x40182FE")]
	[FieldOffset(Offset = "0x120")]
	public GameObject star2;

	[Token(Token = "0x40182FF")]
	[FieldOffset(Offset = "0x124")]
	public GameObject star3;

	[Token(Token = "0x4018300")]
	[FieldOffset(Offset = "0x128")]
	public GameObject star4;

	[Token(Token = "0x4018301")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject star5;

	[Token(Token = "0x4018302")]
	[FieldOffset(Offset = "0x130")]
	public GameObject blackstar1;

	[Token(Token = "0x4018303")]
	[FieldOffset(Offset = "0x134")]
	public GameObject blackstar2;

	[Token(Token = "0x4018304")]
	[FieldOffset(Offset = "0x138")]
	public GameObject blackstar3;

	[Token(Token = "0x4018305")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject blackstar4;

	[Token(Token = "0x4018306")]
	[FieldOffset(Offset = "0x140")]
	public GameObject blackstar5;

	[Token(Token = "0x4018307")]
	[FieldOffset(Offset = "0x144")]
	public GameObject StarIcon;

	[Token(Token = "0x4018308")]
	[FieldOffset(Offset = "0x148")]
	public UILabel MaxRankTxt;

	[Token(Token = "0x4018309")]
	[FieldOffset(Offset = "0x14C")]
	public UISprite CSRankIcon;

	[Token(Token = "0x401830A")]
	[FieldOffset(Offset = "0x150")]
	public UILabel CSRankName;

	[Token(Token = "0x401830B")]
	[FieldOffset(Offset = "0x154")]
	public UILabel CSSeasonInfoLabel;

	[Token(Token = "0x401830C")]
	[FieldOffset(Offset = "0x158")]
	public UILabel CSSeasonLabel;

	[Token(Token = "0x401830D")]
	[FieldOffset(Offset = "0x15C")]
	public UIButton ShareBtn;

	[Token(Token = "0x401830E")]
	[FieldOffset(Offset = "0x160")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x401830F")]
	[FieldOffset(Offset = "0x164")]
	public GameObject LadderParticleEffect;

	[Token(Token = "0x4018310")]
	[FieldOffset(Offset = "0x168")]
	public UILabel BRRankLabel;

	[Token(Token = "0x4018311")]
	[FieldOffset(Offset = "0x16C")]
	public UILabel CSRankLabel;

	[Token(Token = "0x6017090")]
	[Address(RVA = "0x1A4B01C", Offset = "0x1A4B01C", VA = "0x1A4B01C")]
	public UISeasonStatsDetailView()
	{
	}

	[Token(Token = "0x6017091")]
	[Address(RVA = "0x1A4B024", Offset = "0x1A4B024", VA = "0x1A4B024", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017092")]
	[Address(RVA = "0x1A4D08C", Offset = "0x1A4D08C", VA = "0x1A4D08C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
