using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003404")]
public class UIBriefBoxView : UIBaseView
{
	[Token(Token = "0x40140B7")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel UIBriefBox;

	[Token(Token = "0x40140B8")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Container;

	[Token(Token = "0x40140B9")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ProfileContainer;

	[Token(Token = "0x40140BA")]
	[FieldOffset(Offset = "0x20")]
	public UIGrid ItemGrid;

	[Token(Token = "0x40140BB")]
	[FieldOffset(Offset = "0x24")]
	public UISprite BGBorder;

	[Token(Token = "0x40140BC")]
	[FieldOffset(Offset = "0x28")]
	public UISprite BG;

	[Token(Token = "0x40140BD")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ProfilePivot;

	[Token(Token = "0x40140BE")]
	[FieldOffset(Offset = "0x30")]
	public UISprite LanguageSprite;

	[Token(Token = "0x40140BF")]
	[FieldOffset(Offset = "0x34")]
	public MinWidgetTableItem MinWidget;

	[Token(Token = "0x40140C0")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ScrollViewRoot;

	[Token(Token = "0x40140C1")]
	[FieldOffset(Offset = "0x3C")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40140C2")]
	[FieldOffset(Offset = "0x40")]
	public LayoutTable Other;

	[Token(Token = "0x40140C3")]
	[FieldOffset(Offset = "0x44")]
	public Transform Rank;

	[Token(Token = "0x40140C4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject SeaSonBrContainer;

	[Token(Token = "0x40140C5")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject SeaSonCsContainer;

	[Token(Token = "0x40140C6")]
	[FieldOffset(Offset = "0x50")]
	public GameObject SeaSonCsCoontainer;

	[Token(Token = "0x40140C7")]
	[FieldOffset(Offset = "0x54")]
	public UILabel PersonSeaSonDesNowCS;

	[Token(Token = "0x40140C8")]
	[FieldOffset(Offset = "0x58")]
	public UILabel PersonSeaSonDesNowCS_S;

	[Token(Token = "0x40140C9")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject PersonSeaHistoryBRRoot;

	[Token(Token = "0x40140CA")]
	[FieldOffset(Offset = "0x60")]
	public UILabel PersonSeaSonDesHistoryCS;

	[Token(Token = "0x40140CB")]
	[FieldOffset(Offset = "0x64")]
	public UISprite PersonRankIconHistoryCS;

	[Token(Token = "0x40140CC")]
	[FieldOffset(Offset = "0x68")]
	public GameObject PersonHeroicMarkCSRoot;

	[Token(Token = "0x40140CD")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton CSNotObtainedIconBth;

	[Token(Token = "0x40140CE")]
	[FieldOffset(Offset = "0x70")]
	public UISprite UISpriteHeroicMarkCSIconBtn;

	[Token(Token = "0x40140CF")]
	[FieldOffset(Offset = "0x74")]
	public UIButton UIButtonHeroicMarkCSIconBtn;

	[Token(Token = "0x40140D0")]
	[FieldOffset(Offset = "0x78")]
	public Transform HeroicCSEffect;

	[Token(Token = "0x40140D1")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel PersonSeaSonRankNameCS;

	[Token(Token = "0x40140D2")]
	[FieldOffset(Offset = "0x80")]
	public UILabel PersonSeaSonRankNameHistoryCS;

	[Token(Token = "0x40140D3")]
	[FieldOffset(Offset = "0x84")]
	public UISprite PersonRankIconCS;

	[Token(Token = "0x40140D4")]
	[FieldOffset(Offset = "0x88")]
	public GameObject StarIcon;

	[Token(Token = "0x40140D5")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel NowMaxRankTxt;

	[Token(Token = "0x40140D6")]
	[FieldOffset(Offset = "0x90")]
	public UIGrid NowCSGrid;

	[Token(Token = "0x40140D7")]
	[FieldOffset(Offset = "0x94")]
	public GameObject nowstar1;

	[Token(Token = "0x40140D8")]
	[FieldOffset(Offset = "0x98")]
	public GameObject nowstar2;

	[Token(Token = "0x40140D9")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject nowstar3;

	[Token(Token = "0x40140DA")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject nowstar4;

	[Token(Token = "0x40140DB")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject nowstar5;

	[Token(Token = "0x40140DC")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject nowblackstar1;

	[Token(Token = "0x40140DD")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject nowblackstar2;

	[Token(Token = "0x40140DE")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject nowblackstar3;

	[Token(Token = "0x40140DF")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject nowblackstar4;

	[Token(Token = "0x40140E0")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject nowblackstar5;

	[Token(Token = "0x40140E1")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel HistoryMaxRankTxt;

	[Token(Token = "0x40140E2")]
	[FieldOffset(Offset = "0xC0")]
	public UIGrid HistoryCsGrid;

	[Token(Token = "0x40140E3")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject Historystar1;

	[Token(Token = "0x40140E4")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject Historystar2;

	[Token(Token = "0x40140E5")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject Historystar3;

	[Token(Token = "0x40140E6")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject Historystar4;

	[Token(Token = "0x40140E7")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject Historystar5;

	[Token(Token = "0x40140E8")]
	[FieldOffset(Offset = "0xD8")]
	public GameObject Historyblackstar1;

	[Token(Token = "0x40140E9")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject Historyblackstar2;

	[Token(Token = "0x40140EA")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject Historyblackstar3;

	[Token(Token = "0x40140EB")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject Historyblackstar4;

	[Token(Token = "0x40140EC")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject Historyblackstar5;

	[Token(Token = "0x40140ED")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject SeaSonBrCootainer;

	[Token(Token = "0x40140EE")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel PersonSeaSonDesNow;

	[Token(Token = "0x40140EF")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel PersonSeaSonDesNow_S;

	[Token(Token = "0x40140F0")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject PersonSeaSonBRRoot;

	[Token(Token = "0x40140F1")]
	[FieldOffset(Offset = "0xFC")]
	public UILabel PersonSeaSonDesHistory;

	[Token(Token = "0x40140F2")]
	[FieldOffset(Offset = "0x100")]
	public UISprite PersonRankIconHistory;

	[Token(Token = "0x40140F3")]
	[FieldOffset(Offset = "0x104")]
	public GameObject PersonHeroicMarkBRRoot;

	[Token(Token = "0x40140F4")]
	[FieldOffset(Offset = "0x108")]
	public UIButton BRNotObtainedIconBth;

	[Token(Token = "0x40140F5")]
	[FieldOffset(Offset = "0x10C")]
	public UISprite UISpriteHeroicMarkBRIconBtn;

	[Token(Token = "0x40140F6")]
	[FieldOffset(Offset = "0x110")]
	public UIButton UIButtonHeroicMarkBRIconBtn;

	[Token(Token = "0x40140F7")]
	[FieldOffset(Offset = "0x114")]
	public Transform HeroicBREffect;

	[Token(Token = "0x40140F8")]
	[FieldOffset(Offset = "0x118")]
	public UILabel PersonSeaSonRankName;

	[Token(Token = "0x40140F9")]
	[FieldOffset(Offset = "0x11C")]
	public UILabel PersonSeaSonRankNameHistory;

	[Token(Token = "0x40140FA")]
	[FieldOffset(Offset = "0x120")]
	public UISprite PersonRankIcon;

	[Token(Token = "0x40140FB")]
	[FieldOffset(Offset = "0x124")]
	public UILabel PersonSeaSonRankPoint;

	[Token(Token = "0x40140FC")]
	[FieldOffset(Offset = "0x128")]
	public UILabel PersonSeaSonHistoryRankPoint;

	[Token(Token = "0x40140FD")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject HeroicLevelContainer;

	[Token(Token = "0x40140FE")]
	[FieldOffset(Offset = "0x130")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x40140FF")]
	[FieldOffset(Offset = "0x134")]
	public GameObject HeroicLevelContainerMax;

	[Token(Token = "0x4014100")]
	[FieldOffset(Offset = "0x138")]
	public UILadderMatchHeroicLevelView HeroicLevelViewMax;

	[Token(Token = "0x4014101")]
	[FieldOffset(Offset = "0x13C")]
	public Transform Tag;

	[Token(Token = "0x4014102")]
	[FieldOffset(Offset = "0x140")]
	public UIGrid TagGrid;

	[Token(Token = "0x4014103")]
	[FieldOffset(Offset = "0x144")]
	public ProfileTagView ProfileItem;

	[Token(Token = "0x4014104")]
	[FieldOffset(Offset = "0x148")]
	public Transform SocialTag;

	[Token(Token = "0x4014105")]
	[FieldOffset(Offset = "0x14C")]
	public UIGrid SocialTagGrid;

	[Token(Token = "0x4014106")]
	[FieldOffset(Offset = "0x150")]
	public ProfileTagView SocialProfileItem;

	[Token(Token = "0x4014107")]
	[FieldOffset(Offset = "0x154")]
	public GameObject LineBG02;

	[Token(Token = "0x4014108")]
	[FieldOffset(Offset = "0x158")]
	public Transform Desc;

	[Token(Token = "0x4014109")]
	[FieldOffset(Offset = "0x15C")]
	public UILabel DescLabel;

	[Token(Token = "0x401410A")]
	[FieldOffset(Offset = "0x160")]
	public GameObject Report;

	[Token(Token = "0x401410B")]
	[FieldOffset(Offset = "0x164")]
	public UIButton ReportBtn;

	[Token(Token = "0x401410C")]
	[FieldOffset(Offset = "0x168")]
	public GameObject ReportDisableGO;

	[Token(Token = "0x401410D")]
	[FieldOffset(Offset = "0x16C")]
	public UILabel ReportDisableLabel;

	[Token(Token = "0x401410E")]
	[FieldOffset(Offset = "0x170")]
	public Transform Center;

	[Token(Token = "0x6015FC0")]
	[Address(RVA = "0x1442C80", Offset = "0x1442C80", VA = "0x1442C80")]
	public UIBriefBoxView()
	{
	}

	[Token(Token = "0x6015FC1")]
	[Address(RVA = "0x1442C88", Offset = "0x1442C88", VA = "0x1442C88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015FC2")]
	[Address(RVA = "0x1444BC4", Offset = "0x1444BC4", VA = "0x1444BC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
