using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003928")]
public class UIProfileFightDataItemView : UIBaseView
{
	[Token(Token = "0x4017CC1")]
	[FieldOffset(Offset = "0x14")]
	public Animation Animation;

	[Token(Token = "0x4017CC2")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ProfileNode;

	[Token(Token = "0x4017CC3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FiveDMap;

	[Token(Token = "0x4017CC4")]
	[FieldOffset(Offset = "0x20")]
	public UILabel FirstDimension;

	[Token(Token = "0x4017CC5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject WinrateVFX;

	[Token(Token = "0x4017CC6")]
	[FieldOffset(Offset = "0x28")]
	public GameObject WinrateVFX2;

	[Token(Token = "0x4017CC7")]
	[FieldOffset(Offset = "0x2C")]
	public Transform WinrateVFX3;

	[Token(Token = "0x4017CC8")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SecondDimension;

	[Token(Token = "0x4017CC9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject KillVFX;

	[Token(Token = "0x4017CCA")]
	[FieldOffset(Offset = "0x38")]
	public GameObject KillVFX2;

	[Token(Token = "0x4017CCB")]
	[FieldOffset(Offset = "0x3C")]
	public Transform KillVFX3;

	[Token(Token = "0x4017CCC")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ThirdDimension;

	[Token(Token = "0x4017CCD")]
	[FieldOffset(Offset = "0x44")]
	public GameObject SkillVFX;

	[Token(Token = "0x4017CCE")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SkillVFX2;

	[Token(Token = "0x4017CCF")]
	[FieldOffset(Offset = "0x4C")]
	public Transform SkillVFX3;

	[Token(Token = "0x4017CD0")]
	[FieldOffset(Offset = "0x50")]
	public UILabel FourthDimension;

	[Token(Token = "0x4017CD1")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ExploreVFX;

	[Token(Token = "0x4017CD2")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ExploreVFX2;

	[Token(Token = "0x4017CD3")]
	[FieldOffset(Offset = "0x5C")]
	public Transform ExploreVFX3;

	[Token(Token = "0x4017CD4")]
	[FieldOffset(Offset = "0x60")]
	public UILabel FifthDimension;

	[Token(Token = "0x4017CD5")]
	[FieldOffset(Offset = "0x64")]
	public GameObject SurvivalVFX;

	[Token(Token = "0x4017CD6")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SurvivalVFX2;

	[Token(Token = "0x4017CD7")]
	[FieldOffset(Offset = "0x6C")]
	public Transform SurvivalVFX3;

	[Token(Token = "0x4017CD8")]
	[FieldOffset(Offset = "0x70")]
	public MeshRenderer MapRenderer;

	[Token(Token = "0x4017CD9")]
	[FieldOffset(Offset = "0x74")]
	public MeshFilter MapMeshFilter;

	[Token(Token = "0x4017CDA")]
	[FieldOffset(Offset = "0x78")]
	public Transform PointWinRate;

	[Token(Token = "0x4017CDB")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject PointWinRateVfx;

	[Token(Token = "0x4017CDC")]
	[FieldOffset(Offset = "0x80")]
	public Transform PointSurvival;

	[Token(Token = "0x4017CDD")]
	[FieldOffset(Offset = "0x84")]
	public GameObject PointSurvivalVfx;

	[Token(Token = "0x4017CDE")]
	[FieldOffset(Offset = "0x88")]
	public Transform PointExplore;

	[Token(Token = "0x4017CDF")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject PointExploreVfx;

	[Token(Token = "0x4017CE0")]
	[FieldOffset(Offset = "0x90")]
	public Transform PointSkill;

	[Token(Token = "0x4017CE1")]
	[FieldOffset(Offset = "0x94")]
	public GameObject PointSkillVfx;

	[Token(Token = "0x4017CE2")]
	[FieldOffset(Offset = "0x98")]
	public Transform PointKill;

	[Token(Token = "0x4017CE3")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject PointKillVfx;

	[Token(Token = "0x4017CE4")]
	[FieldOffset(Offset = "0xA0")]
	public UIStarSprite mapRender;

	[Token(Token = "0x4017CE5")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite LineWinRate;

	[Token(Token = "0x4017CE6")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite LineKill;

	[Token(Token = "0x4017CE7")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite LineSkill;

	[Token(Token = "0x4017CE8")]
	[FieldOffset(Offset = "0xB0")]
	public UISprite LineExplore;

	[Token(Token = "0x4017CE9")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite LineSurvival;

	[Token(Token = "0x4017CEA")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject BasicDataPanel;

	[Token(Token = "0x4017CEB")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel PlayTimes;

	[Token(Token = "0x4017CEC")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel WinTimes;

	[Token(Token = "0x4017CED")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel KillTimes;

	[Token(Token = "0x4017CEE")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite nameicon;

	[Token(Token = "0x4017CEF")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel namelabel;

	[Token(Token = "0x4017CF0")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel LabelGameMode;

	[Token(Token = "0x4017CF1")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject detailpanel;

	[Token(Token = "0x4017CF2")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton detailbtn;

	[Token(Token = "0x4017CF3")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite arrow;

	[Token(Token = "0x4017CF4")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel detaillabel;

	[Token(Token = "0x4017CF5")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject detailselect;

	[Token(Token = "0x4017CF6")]
	[FieldOffset(Offset = "0xE8")]
	public Transform Line02;

	[Token(Token = "0x4017CF7")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject ThreeDMap;

	[Token(Token = "0x4017CF8")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject CSWinrateVFX;

	[Token(Token = "0x4017CF9")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject CSWinrateVFX2;

	[Token(Token = "0x4017CFA")]
	[FieldOffset(Offset = "0xF8")]
	public Transform CSWinrateVFX3;

	[Token(Token = "0x4017CFB")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject CSSurvivalVFX;

	[Token(Token = "0x4017CFC")]
	[FieldOffset(Offset = "0x100")]
	public GameObject CSSurvivalVFX2;

	[Token(Token = "0x4017CFD")]
	[FieldOffset(Offset = "0x104")]
	public Transform CSSurvivalVFX3;

	[Token(Token = "0x4017CFE")]
	[FieldOffset(Offset = "0x108")]
	public GameObject CSExploreVFX;

	[Token(Token = "0x4017CFF")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject CSExploreVFX2;

	[Token(Token = "0x4017D00")]
	[FieldOffset(Offset = "0x110")]
	public Transform CSExploreVFX3;

	[Token(Token = "0x4017D01")]
	[FieldOffset(Offset = "0x114")]
	public GameObject CSSkillVFX;

	[Token(Token = "0x4017D02")]
	[FieldOffset(Offset = "0x118")]
	public GameObject CSSkillVFX2;

	[Token(Token = "0x4017D03")]
	[FieldOffset(Offset = "0x11C")]
	public Transform CSSkillVFX3;

	[Token(Token = "0x4017D04")]
	[FieldOffset(Offset = "0x120")]
	public GameObject CSKillVFX;

	[Token(Token = "0x4017D05")]
	[FieldOffset(Offset = "0x124")]
	public GameObject CSKillVFX2;

	[Token(Token = "0x4017D06")]
	[FieldOffset(Offset = "0x128")]
	public Transform CSKillVFX3;

	[Token(Token = "0x4017D07")]
	[FieldOffset(Offset = "0x12C")]
	public MeshRenderer ThreedMapRenderer;

	[Token(Token = "0x4017D08")]
	[FieldOffset(Offset = "0x130")]
	public MeshFilter ThreedMapMeshFilter;

	[Token(Token = "0x4017D09")]
	[FieldOffset(Offset = "0x134")]
	public Transform PointCsLeader;

	[Token(Token = "0x4017D0A")]
	[FieldOffset(Offset = "0x138")]
	public GameObject PointCsLeaderVfx;

	[Token(Token = "0x4017D0B")]
	[FieldOffset(Offset = "0x13C")]
	public Transform PointCsSupport;

	[Token(Token = "0x4017D0C")]
	[FieldOffset(Offset = "0x140")]
	public GameObject PointCsSupportVfx;

	[Token(Token = "0x4017D0D")]
	[FieldOffset(Offset = "0x144")]
	public Transform PointCskill;

	[Token(Token = "0x4017D0E")]
	[FieldOffset(Offset = "0x148")]
	public GameObject PointCskillVfx;

	[Token(Token = "0x4017D0F")]
	[FieldOffset(Offset = "0x14C")]
	public Transform PointCsDamage;

	[Token(Token = "0x4017D10")]
	[FieldOffset(Offset = "0x150")]
	public GameObject PointCsDamageVfx;

	[Token(Token = "0x4017D11")]
	[FieldOffset(Offset = "0x154")]
	public Transform PointCsParticipation;

	[Token(Token = "0x4017D12")]
	[FieldOffset(Offset = "0x158")]
	public GameObject PointCsParticipationVfx;

	[Token(Token = "0x4017D13")]
	[FieldOffset(Offset = "0x15C")]
	public UIStarSprite ThreedmapRender;

	[Token(Token = "0x4017D14")]
	[FieldOffset(Offset = "0x160")]
	public UISprite LineCsLeader;

	[Token(Token = "0x4017D15")]
	[FieldOffset(Offset = "0x164")]
	public UISprite LineCsSupport;

	[Token(Token = "0x4017D16")]
	[FieldOffset(Offset = "0x168")]
	public UISprite LineCskill;

	[Token(Token = "0x4017D17")]
	[FieldOffset(Offset = "0x16C")]
	public UISprite LineCsDamage;

	[Token(Token = "0x4017D18")]
	[FieldOffset(Offset = "0x170")]
	public UISprite LineCsParticipation;

	[Token(Token = "0x4017D19")]
	[FieldOffset(Offset = "0x174")]
	public GameObject CSModeBasicDataPanel;

	[Token(Token = "0x4017D1A")]
	[FieldOffset(Offset = "0x178")]
	public UILabel CSPlayTimes;

	[Token(Token = "0x4017D1B")]
	[FieldOffset(Offset = "0x17C")]
	public UILabel CSWinTimes;

	[Token(Token = "0x4017D1C")]
	[FieldOffset(Offset = "0x180")]
	public UILabel CSKillTimes;

	[Token(Token = "0x4017D1D")]
	[FieldOffset(Offset = "0x184")]
	public UILabel KDATimes;

	[Token(Token = "0x4017D1E")]
	[FieldOffset(Offset = "0x188")]
	public Transform MiniRankInfoContainer;

	[Token(Token = "0x4017D1F")]
	[FieldOffset(Offset = "0x18C")]
	public UILabel LabelSeason;

	[Token(Token = "0x4017D20")]
	[FieldOffset(Offset = "0x190")]
	public Transform ScrollView;

	[Token(Token = "0x4017D21")]
	[FieldOffset(Offset = "0x194")]
	public Transform RightPanel;

	[Token(Token = "0x4017D22")]
	[FieldOffset(Offset = "0x198")]
	public GameObject DetailDataPanel;

	[Token(Token = "0x4017D23")]
	[FieldOffset(Offset = "0x19C")]
	public GameObject DetailBG;

	[Token(Token = "0x4017D24")]
	[FieldOffset(Offset = "0x1A0")]
	public UIGrid DetailGrid;

	[Token(Token = "0x4017D25")]
	[FieldOffset(Offset = "0x1A4")]
	public GameObject TopNsNode;

	[Token(Token = "0x4017D26")]
	[FieldOffset(Offset = "0x1A8")]
	public UILabel TopNsLabel;

	[Token(Token = "0x4017D27")]
	[FieldOffset(Offset = "0x1AC")]
	public UILabel Top10s;

	[Token(Token = "0x4017D28")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject TopNRateNode;

	[Token(Token = "0x4017D29")]
	[FieldOffset(Offset = "0x1B4")]
	public UILabel TopNRateLabel;

	[Token(Token = "0x4017D2A")]
	[FieldOffset(Offset = "0x1B8")]
	public UILabel Top10Rate;

	[Token(Token = "0x4017D2B")]
	[FieldOffset(Offset = "0x1BC")]
	public GameObject KDRatioNode;

	[Token(Token = "0x4017D2C")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObject KDRatioLabel;

	[Token(Token = "0x4017D2D")]
	[FieldOffset(Offset = "0x1C4")]
	public UILabel KDRatio;

	[Token(Token = "0x4017D2E")]
	[FieldOffset(Offset = "0x1C8")]
	public GameObject AVGDisTravNode;

	[Token(Token = "0x4017D2F")]
	[FieldOffset(Offset = "0x1CC")]
	public GameObject AVGDisTravLabel;

	[Token(Token = "0x4017D30")]
	[FieldOffset(Offset = "0x1D0")]
	public UILabel AVGDisTrav;

	[Token(Token = "0x4017D31")]
	[FieldOffset(Offset = "0x1D4")]
	public GameObject AVGSurvivalTimeNode;

	[Token(Token = "0x4017D32")]
	[FieldOffset(Offset = "0x1D8")]
	public GameObject AVGSurvivalTimeLabel;

	[Token(Token = "0x4017D33")]
	[FieldOffset(Offset = "0x1DC")]
	public UILabel AVGSurvivalTime;

	[Token(Token = "0x4017D34")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject RevivesNode;

	[Token(Token = "0x4017D35")]
	[FieldOffset(Offset = "0x1E4")]
	public GameObject RevivesLabel;

	[Token(Token = "0x4017D36")]
	[FieldOffset(Offset = "0x1E8")]
	public UILabel Revives;

	[Token(Token = "0x4017D37")]
	[FieldOffset(Offset = "0x1EC")]
	public GameObject MostKillNode;

	[Token(Token = "0x4017D38")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObject MostKillLabel;

	[Token(Token = "0x4017D39")]
	[FieldOffset(Offset = "0x1F4")]
	public UILabel MostKill;

	[Token(Token = "0x4017D3A")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject GameTimesNode;

	[Token(Token = "0x4017D3B")]
	[FieldOffset(Offset = "0x1FC")]
	public GameObject GameTimesLabel;

	[Token(Token = "0x4017D3C")]
	[FieldOffset(Offset = "0x200")]
	public UILabel GameTimes;

	[Token(Token = "0x4017D3D")]
	[FieldOffset(Offset = "0x204")]
	public GameObject WinCountNode;

	[Token(Token = "0x4017D3E")]
	[FieldOffset(Offset = "0x208")]
	public GameObject WinCountLabel;

	[Token(Token = "0x4017D3F")]
	[FieldOffset(Offset = "0x20C")]
	public UILabel WinCount;

	[Token(Token = "0x4017D40")]
	[FieldOffset(Offset = "0x210")]
	public GameObject KillCountNode;

	[Token(Token = "0x4017D41")]
	[FieldOffset(Offset = "0x214")]
	public GameObject KillCountLabel;

	[Token(Token = "0x4017D42")]
	[FieldOffset(Offset = "0x218")]
	public UILabel KillCount;

	[Token(Token = "0x4017D43")]
	[FieldOffset(Offset = "0x21C")]
	public GameObject MaxRankNode;

	[Token(Token = "0x4017D44")]
	[FieldOffset(Offset = "0x220")]
	public GameObject MaxRankLabel;

	[Token(Token = "0x4017D45")]
	[FieldOffset(Offset = "0x224")]
	public UILabel MaxRank;

	[Token(Token = "0x4017D46")]
	[FieldOffset(Offset = "0x228")]
	public GameObject AVGDamageNode;

	[Token(Token = "0x4017D47")]
	[FieldOffset(Offset = "0x22C")]
	public GameObject AVGDamageLabel;

	[Token(Token = "0x4017D48")]
	[FieldOffset(Offset = "0x230")]
	public UILabel AVGDamage;

	[Token(Token = "0x4017D49")]
	[FieldOffset(Offset = "0x234")]
	public GameObject RoadKillNode;

	[Token(Token = "0x4017D4A")]
	[FieldOffset(Offset = "0x238")]
	public GameObject RoadKillLabel;

	[Token(Token = "0x4017D4B")]
	[FieldOffset(Offset = "0x23C")]
	public UILabel RoadKill;

	[Token(Token = "0x4017D4C")]
	[FieldOffset(Offset = "0x240")]
	public GameObject HeadShotNode;

	[Token(Token = "0x4017D4D")]
	[FieldOffset(Offset = "0x244")]
	public GameObject HeadShotLabel;

	[Token(Token = "0x4017D4E")]
	[FieldOffset(Offset = "0x248")]
	public UILabel HeadShot;

	[Token(Token = "0x4017D4F")]
	[FieldOffset(Offset = "0x24C")]
	public GameObject HeadShotRatioNode;

	[Token(Token = "0x4017D50")]
	[FieldOffset(Offset = "0x250")]
	public GameObject HeadShotRatioLabel;

	[Token(Token = "0x4017D51")]
	[FieldOffset(Offset = "0x254")]
	public UILabel HeadShotRatio;

	[Token(Token = "0x4017D52")]
	[FieldOffset(Offset = "0x258")]
	public GameObject KnockDownNode;

	[Token(Token = "0x4017D53")]
	[FieldOffset(Offset = "0x25C")]
	public GameObject KnockDownLabel;

	[Token(Token = "0x4017D54")]
	[FieldOffset(Offset = "0x260")]
	public UILabel KnockDown;

	[Token(Token = "0x4017D55")]
	[FieldOffset(Offset = "0x264")]
	public GameObject WinRateNode;

	[Token(Token = "0x4017D56")]
	[FieldOffset(Offset = "0x268")]
	public GameObject WinRateLabel;

	[Token(Token = "0x4017D57")]
	[FieldOffset(Offset = "0x26C")]
	public UILabel CSWinRate;

	[Token(Token = "0x4017D58")]
	[FieldOffset(Offset = "0x270")]
	public GameObject MVPNode;

	[Token(Token = "0x4017D59")]
	[FieldOffset(Offset = "0x274")]
	public GameObject MVPLabel;

	[Token(Token = "0x4017D5A")]
	[FieldOffset(Offset = "0x278")]
	public UILabel CSMvp;

	[Token(Token = "0x4017D5B")]
	[FieldOffset(Offset = "0x27C")]
	public GameObject TotalKillNode;

	[Token(Token = "0x4017D5C")]
	[FieldOffset(Offset = "0x280")]
	public GameObject TotalKillLabel;

	[Token(Token = "0x4017D5D")]
	[FieldOffset(Offset = "0x284")]
	public UILabel CSTotalKill;

	[Token(Token = "0x4017D5E")]
	[FieldOffset(Offset = "0x288")]
	public GameObject DoubleKillNode;

	[Token(Token = "0x4017D5F")]
	[FieldOffset(Offset = "0x28C")]
	public GameObject DoubleKillLabel;

	[Token(Token = "0x4017D60")]
	[FieldOffset(Offset = "0x290")]
	public UILabel CSDoubleKill;

	[Token(Token = "0x4017D61")]
	[FieldOffset(Offset = "0x294")]
	public GameObject ThreekillNode;

	[Token(Token = "0x4017D62")]
	[FieldOffset(Offset = "0x298")]
	public GameObject ThreekillLabel;

	[Token(Token = "0x4017D63")]
	[FieldOffset(Offset = "0x29C")]
	public UILabel CSThreeKill;

	[Token(Token = "0x4017D64")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject FourKillNode;

	[Token(Token = "0x4017D65")]
	[FieldOffset(Offset = "0x2A4")]
	public GameObject FourKillLabel;

	[Token(Token = "0x4017D66")]
	[FieldOffset(Offset = "0x2A8")]
	public UILabel CSFourKill;

	[Token(Token = "0x4017D67")]
	[FieldOffset(Offset = "0x2AC")]
	public UISprite FirstDimensionLine;

	[Token(Token = "0x4017D68")]
	[FieldOffset(Offset = "0x2B0")]
	public UISprite SecondDimensionLine;

	[Token(Token = "0x4017D69")]
	[FieldOffset(Offset = "0x2B4")]
	public UISprite ThirdDimensionLine;

	[Token(Token = "0x4017D6A")]
	[FieldOffset(Offset = "0x2B8")]
	public UISprite FourDimensionLine;

	[Token(Token = "0x4017D6B")]
	[FieldOffset(Offset = "0x2BC")]
	public UISprite FifThDimensionLine;

	[Token(Token = "0x4017D6C")]
	[FieldOffset(Offset = "0x2C0")]
	public AnimatedAlpha Arrow;

	[Token(Token = "0x4017D6D")]
	[FieldOffset(Offset = "0x2C4")]
	public UIScrollView DetailScrollview;

	[Token(Token = "0x6016F1F")]
	[Address(RVA = "0x16E543C", Offset = "0x16E543C", VA = "0x16E543C")]
	public UIProfileFightDataItemView()
	{
	}

	[Token(Token = "0x6016F20")]
	[Address(RVA = "0x16E5444", Offset = "0x16E5444", VA = "0x16E5444", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F21")]
	[Address(RVA = "0x16E8EE8", Offset = "0x16E8EE8", VA = "0x16E8EE8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
