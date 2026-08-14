using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003932")]
public class UIProfileView : UIBaseView
{
	[Token(Token = "0x4017E0F")]
	[FieldOffset(Offset = "0x14")]
	public GameObject FULLHDBg2;

	[Token(Token = "0x4017E10")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ProfileNodeAll;

	[Token(Token = "0x4017E11")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid UIGridprofilegrid;

	[Token(Token = "0x4017E12")]
	[FieldOffset(Offset = "0x20")]
	public Animation Animationprofilegrid;

	[Token(Token = "0x4017E13")]
	[FieldOffset(Offset = "0x24")]
	public Transform Item1;

	[Token(Token = "0x4017E14")]
	[FieldOffset(Offset = "0x28")]
	public Transform Item2;

	[Token(Token = "0x4017E15")]
	[FieldOffset(Offset = "0x2C")]
	public Transform Item3;

	[Token(Token = "0x4017E16")]
	[FieldOffset(Offset = "0x30")]
	public Transform profileshowoneitem;

	[Token(Token = "0x4017E17")]
	[FieldOffset(Offset = "0x34")]
	public Transform ProfileFightBrMenu;

	[Token(Token = "0x4017E18")]
	[FieldOffset(Offset = "0x38")]
	public Transform ProfileFightCSMenu;

	[Token(Token = "0x4017E19")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject ProfileDeslabel1;

	[Token(Token = "0x4017E1A")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnProfileNodeALLShare;

	[Token(Token = "0x4017E1B")]
	[FieldOffset(Offset = "0x44")]
	public UIButton ProfileNodeRuleBtn;

	[Token(Token = "0x4017E1C")]
	[FieldOffset(Offset = "0x48")]
	public Transform profileperiodic;

	[Token(Token = "0x4017E1D")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject HistoryNode;

	[Token(Token = "0x4017E1E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject ContentNode;

	[Token(Token = "0x4017E1F")]
	[FieldOffset(Offset = "0x54")]
	public UIButton BtnProfileNodeHistoryShare;

	[Token(Token = "0x4017E20")]
	[FieldOffset(Offset = "0x58")]
	public UIEasyList HistoryList;

	[Token(Token = "0x4017E21")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject HistoryDetail;

	[Token(Token = "0x4017E22")]
	[FieldOffset(Offset = "0x60")]
	public UILabel HistoryRating;

	[Token(Token = "0x4017E23")]
	[FieldOffset(Offset = "0x64")]
	public UILabel HistoryDeltaRating;

	[Token(Token = "0x4017E24")]
	[FieldOffset(Offset = "0x68")]
	public UILabel HistoryRank;

	[Token(Token = "0x4017E25")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel HistoryTotalRank;

	[Token(Token = "0x4017E26")]
	[FieldOffset(Offset = "0x70")]
	public GameObject LoseInfo1;

	[Token(Token = "0x4017E27")]
	[FieldOffset(Offset = "0x74")]
	public GameObject WinInfo1;

	[Token(Token = "0x4017E28")]
	[FieldOffset(Offset = "0x78")]
	public UILabel HistoryNodeMapName;

	[Token(Token = "0x4017E29")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject WerewolvesHistoryRoot;

	[Token(Token = "0x4017E2A")]
	[FieldOffset(Offset = "0x80")]
	public GameObject WolfTextRoot;

	[Token(Token = "0x4017E2B")]
	[FieldOffset(Offset = "0x84")]
	public UILabel WolfKillCount;

	[Token(Token = "0x4017E2C")]
	[FieldOffset(Offset = "0x88")]
	public UILabel WolfTaskCount;

	[Token(Token = "0x4017E2D")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel WolfHideCount;

	[Token(Token = "0x4017E2E")]
	[FieldOffset(Offset = "0x90")]
	public UILabel WolfVoteRoundCount;

	[Token(Token = "0x4017E2F")]
	[FieldOffset(Offset = "0x94")]
	public GameObject HumanTextRoot;

	[Token(Token = "0x4017E30")]
	[FieldOffset(Offset = "0x98")]
	public UILabel HumanTaskCount;

	[Token(Token = "0x4017E31")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel HumanVoteRoundCount;

	[Token(Token = "0x4017E32")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel HumanVoteSuccessCount;

	[Token(Token = "0x4017E33")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel HumanCompleteMergencyTaskCount;

	[Token(Token = "0x4017E34")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject CommonGameModeHistoryRoot;

	[Token(Token = "0x4017E35")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel HistoryKillLabel;

	[Token(Token = "0x4017E36")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel HistoryKill;

	[Token(Token = "0x4017E37")]
	[FieldOffset(Offset = "0xB4")]
	public UILabel HistoryDamageLabel;

	[Token(Token = "0x4017E38")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel HistoryDamage;

	[Token(Token = "0x4017E39")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel ReviveLabel;

	[Token(Token = "0x4017E3A")]
	[FieldOffset(Offset = "0xC0")]
	public UILabel HistoryRevive;

	[Token(Token = "0x4017E3B")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel HistoryHeadShootLabel;

	[Token(Token = "0x4017E3C")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel HistoryHeadShoot;

	[Token(Token = "0x4017E3D")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel historySurvivalLabel;

	[Token(Token = "0x4017E3E")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel HistorySurvival;

	[Token(Token = "0x4017E3F")]
	[FieldOffset(Offset = "0xD4")]
	public UISprite HistoryAchiveIcon;

	[Token(Token = "0x4017E40")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel HistoryDescription;

	[Token(Token = "0x4017E41")]
	[FieldOffset(Offset = "0xDC")]
	public UIGrid HistoryTeammate;

	[Token(Token = "0x4017E42")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton HistoryDetailBtn;

	[Token(Token = "0x4017E43")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject EmptyNode;

	[Token(Token = "0x4017E44")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject PersonShowNode;

	[Token(Token = "0x4017E45")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton PersonBtnCloseup;

	[Token(Token = "0x4017E46")]
	[FieldOffset(Offset = "0xF0")]
	public Transform MarryTr;

	[Token(Token = "0x4017E47")]
	[FieldOffset(Offset = "0xF4")]
	public UISprite MarryIcon;

	[Token(Token = "0x4017E48")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject PersonalCard;

	[Token(Token = "0x4017E49")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject PersonFavorSprite;

	[Token(Token = "0x4017E4A")]
	[FieldOffset(Offset = "0x100")]
	public UIEffectSprite PersonHeadSprite;

	[Token(Token = "0x4017E4B")]
	[FieldOffset(Offset = "0x104")]
	public GameObject PersonFakeSprite;

	[Token(Token = "0x4017E4C")]
	[FieldOffset(Offset = "0x108")]
	public GameObject Icon_Celebrity;

	[Token(Token = "0x4017E4D")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton epbtn;

	[Token(Token = "0x4017E4E")]
	[FieldOffset(Offset = "0x110")]
	public GameObject EPTipsContainer;

	[Token(Token = "0x4017E4F")]
	[FieldOffset(Offset = "0x114")]
	public UIButton EPHelperMaskBtn;

	[Token(Token = "0x4017E50")]
	[FieldOffset(Offset = "0x118")]
	public UIButton likebtn;

	[Token(Token = "0x4017E51")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject LikeTipsContainer;

	[Token(Token = "0x4017E52")]
	[FieldOffset(Offset = "0x120")]
	public UIButton LikeHelperMaskBtn;

	[Token(Token = "0x4017E53")]
	[FieldOffset(Offset = "0x124")]
	public GameObject PersoninfoContainer;

	[Token(Token = "0x4017E54")]
	[FieldOffset(Offset = "0x128")]
	public UILabel UILabelPersonlevel;

	[Token(Token = "0x4017E55")]
	[FieldOffset(Offset = "0x12C")]
	public UICustomHoverButton UICustomHoverButtonPersonlevel;

	[Token(Token = "0x4017E56")]
	[FieldOffset(Offset = "0x130")]
	public UILabel PersonclanName;

	[Token(Token = "0x4017E57")]
	[FieldOffset(Offset = "0x134")]
	public UILabel PersonLagr;

	[Token(Token = "0x4017E58")]
	[FieldOffset(Offset = "0x138")]
	public UISprite PlayerSex;

	[Token(Token = "0x4017E59")]
	[FieldOffset(Offset = "0x13C")]
	public UISprite LanguageSprite;

	[Token(Token = "0x4017E5A")]
	[FieldOffset(Offset = "0x140")]
	public Transform PersonnicknameTr;

	[Token(Token = "0x4017E5B")]
	[FieldOffset(Offset = "0x144")]
	public UILabel Personnickname;

	[Token(Token = "0x4017E5C")]
	[FieldOffset(Offset = "0x148")]
	public UIButton BtnChangeName;

	[Token(Token = "0x4017E5D")]
	[FieldOffset(Offset = "0x14C")]
	public UIButton BtnChangeNameSmall;

	[Token(Token = "0x4017E5E")]
	[FieldOffset(Offset = "0x150")]
	public UILabel IDLabel;

	[Token(Token = "0x4017E5F")]
	[FieldOffset(Offset = "0x154")]
	public UIButton copybtn;

	[Token(Token = "0x4017E60")]
	[FieldOffset(Offset = "0x158")]
	public UILabel likeslabel;

	[Token(Token = "0x4017E61")]
	[FieldOffset(Offset = "0x15C")]
	public UISprite UISpritePinIcon;

	[Token(Token = "0x4017E62")]
	[FieldOffset(Offset = "0x160")]
	public UIButton UIButtonPinIcon;

	[Token(Token = "0x4017E63")]
	[FieldOffset(Offset = "0x164")]
	public UIButton UIButtonGuildbtn;

	[Token(Token = "0x4017E64")]
	[FieldOffset(Offset = "0x168")]
	public UISprite UISpriteGuildbtn;

	[Token(Token = "0x4017E65")]
	[FieldOffset(Offset = "0x16C")]
	public UICustomHoverButton UICustomHoverButtonhuoyue;

	[Token(Token = "0x4017E66")]
	[FieldOffset(Offset = "0x170")]
	public UISprite UISpritehuoyue;

	[Token(Token = "0x4017E67")]
	[FieldOffset(Offset = "0x174")]
	public UICustomHoverButton UICustomHoverButtononlinetime;

	[Token(Token = "0x4017E68")]
	[FieldOffset(Offset = "0x178")]
	public UISprite UISpriteonlinetime;

	[Token(Token = "0x4017E69")]
	[FieldOffset(Offset = "0x17C")]
	public UICustomHoverButton UICustomHoverButtonmodelikes;

	[Token(Token = "0x4017E6A")]
	[FieldOffset(Offset = "0x180")]
	public UISprite UISpritemodelikes;

	[Token(Token = "0x4017E6B")]
	[FieldOffset(Offset = "0x184")]
	public UIToggleButtonGroup SeaSonInfoToogleGroup;

	[Token(Token = "0x4017E6C")]
	[FieldOffset(Offset = "0x188")]
	public UIGrid SeaSonInfoToggleGrid;

	[Token(Token = "0x4017E6D")]
	[FieldOffset(Offset = "0x18C")]
	public GameObject SeaSonBrContainer;

	[Token(Token = "0x4017E6E")]
	[FieldOffset(Offset = "0x190")]
	public UIToggleButton SeaSonBrBtn;

	[Token(Token = "0x4017E6F")]
	[FieldOffset(Offset = "0x194")]
	public GameObject SeaSonCsContainer;

	[Token(Token = "0x4017E70")]
	[FieldOffset(Offset = "0x198")]
	public UIToggleButton SeaSonCsBtn;

	[Token(Token = "0x4017E71")]
	[FieldOffset(Offset = "0x19C")]
	public GameObject SeaSonCsCoontainer;

	[Token(Token = "0x4017E72")]
	[FieldOffset(Offset = "0x1A0")]
	public UILabel CSSEASON_S;

	[Token(Token = "0x4017E73")]
	[FieldOffset(Offset = "0x1A4")]
	public UILabel CSeason_L;

	[Token(Token = "0x4017E74")]
	[FieldOffset(Offset = "0x1A8")]
	public Transform PersonHeroicMarkCSRoot;

	[Token(Token = "0x4017E75")]
	[FieldOffset(Offset = "0x1AC")]
	public UILabel HeroicMarkLabel;

	[Token(Token = "0x4017E76")]
	[FieldOffset(Offset = "0x1B0")]
	public Transform TransformCSNotObtainedIcon;

	[Token(Token = "0x4017E77")]
	[FieldOffset(Offset = "0x1B4")]
	public UIButton UIButtonCSNotObtainedIcon;

	[Token(Token = "0x4017E78")]
	[FieldOffset(Offset = "0x1B8")]
	public UISprite UISpriteHeroicMarkCSIcon;

	[Token(Token = "0x4017E79")]
	[FieldOffset(Offset = "0x1BC")]
	public UIButton UIButtonHeroicMarkCSIcon;

	[Token(Token = "0x4017E7A")]
	[FieldOffset(Offset = "0x1C0")]
	public Transform HeroicCSEffect;

	[Token(Token = "0x4017E7B")]
	[FieldOffset(Offset = "0x1C4")]
	public UILabel PersonSeaSonDesNowCS;

	[Token(Token = "0x4017E7C")]
	[FieldOffset(Offset = "0x1C8")]
	public UILabel PersonSeaSonRankNameCS;

	[Token(Token = "0x4017E7D")]
	[FieldOffset(Offset = "0x1CC")]
	public UISprite UISpritePersonRankIconCS;

	[Token(Token = "0x4017E7E")]
	[FieldOffset(Offset = "0x1D0")]
	public UICustomHoverButton UICustomHoverButtonPersonRankIconCS;

	[Token(Token = "0x4017E7F")]
	[FieldOffset(Offset = "0x1D4")]
	public GameObject StarIcon;

	[Token(Token = "0x4017E80")]
	[FieldOffset(Offset = "0x1D8")]
	public UILabel NowMaxRankTxt;

	[Token(Token = "0x4017E81")]
	[FieldOffset(Offset = "0x1DC")]
	public UIGrid NowCSGrid;

	[Token(Token = "0x4017E82")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject nowstar1;

	[Token(Token = "0x4017E83")]
	[FieldOffset(Offset = "0x1E4")]
	public GameObject nowstar2;

	[Token(Token = "0x4017E84")]
	[FieldOffset(Offset = "0x1E8")]
	public GameObject nowstar3;

	[Token(Token = "0x4017E85")]
	[FieldOffset(Offset = "0x1EC")]
	public GameObject nowstar4;

	[Token(Token = "0x4017E86")]
	[FieldOffset(Offset = "0x1F0")]
	public GameObject nowstar5;

	[Token(Token = "0x4017E87")]
	[FieldOffset(Offset = "0x1F4")]
	public GameObject nowblackstar1;

	[Token(Token = "0x4017E88")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject nowblackstar2;

	[Token(Token = "0x4017E89")]
	[FieldOffset(Offset = "0x1FC")]
	public GameObject nowblackstar3;

	[Token(Token = "0x4017E8A")]
	[FieldOffset(Offset = "0x200")]
	public GameObject nowblackstar4;

	[Token(Token = "0x4017E8B")]
	[FieldOffset(Offset = "0x204")]
	public GameObject nowblackstar5;

	[Token(Token = "0x4017E8C")]
	[FieldOffset(Offset = "0x208")]
	public GameObject SeaSonBrCootainer;

	[Token(Token = "0x4017E8D")]
	[FieldOffset(Offset = "0x20C")]
	public UILabel BRSEASON_S;

	[Token(Token = "0x4017E8E")]
	[FieldOffset(Offset = "0x210")]
	public UILabel BRSeason_L;

	[Token(Token = "0x4017E8F")]
	[FieldOffset(Offset = "0x214")]
	public Transform PersonBRHeroicMarkRoot;

	[Token(Token = "0x4017E90")]
	[FieldOffset(Offset = "0x218")]
	public Transform TransformBRNotObtainedIcon;

	[Token(Token = "0x4017E91")]
	[FieldOffset(Offset = "0x21C")]
	public UIButton UIButtonBRNotObtainedIcon;

	[Token(Token = "0x4017E92")]
	[FieldOffset(Offset = "0x220")]
	public UISprite UISpriteHeroicMarkBRIcon;

	[Token(Token = "0x4017E93")]
	[FieldOffset(Offset = "0x224")]
	public UIButton UIButtonHeroicMarkBRIcon;

	[Token(Token = "0x4017E94")]
	[FieldOffset(Offset = "0x228")]
	public Transform HeroicBREffect;

	[Token(Token = "0x4017E95")]
	[FieldOffset(Offset = "0x22C")]
	public UILabel PersonSeaSonDesNow;

	[Token(Token = "0x4017E96")]
	[FieldOffset(Offset = "0x230")]
	public UILabel PersonSeaSonRankName;

	[Token(Token = "0x4017E97")]
	[FieldOffset(Offset = "0x234")]
	public UISprite UISpritePersonRankIcon;

	[Token(Token = "0x4017E98")]
	[FieldOffset(Offset = "0x238")]
	public UICustomHoverButton UICustomHoverButtonPersonRankIcon;

	[Token(Token = "0x4017E99")]
	[FieldOffset(Offset = "0x23C")]
	public UILabel PersonSeaSonHistoryRankPoint;

	[Token(Token = "0x4017E9A")]
	[FieldOffset(Offset = "0x240")]
	public GameObject HeroicLevelContainer;

	[Token(Token = "0x4017E9B")]
	[FieldOffset(Offset = "0x244")]
	public UILadderMatchHeroicLevelView HeroicLevelView;

	[Token(Token = "0x4017E9C")]
	[FieldOffset(Offset = "0x248")]
	public UIButton BtnEPDocument;

	[Token(Token = "0x4017E9D")]
	[FieldOffset(Offset = "0x24C")]
	public GameObject EpBriefDetailList;

	[Token(Token = "0x4017E9E")]
	[FieldOffset(Offset = "0x250")]
	public UIButton EpBriefBtn;

	[Token(Token = "0x4017E9F")]
	[FieldOffset(Offset = "0x254")]
	public UIGrid SmallEPGrid;

	[Token(Token = "0x4017EA0")]
	[FieldOffset(Offset = "0x258")]
	public GameObject EpFullDetailList;

	[Token(Token = "0x4017EA1")]
	[FieldOffset(Offset = "0x25C")]
	public UIGrid EPFullDetailGrid;

	[Token(Token = "0x4017EA2")]
	[FieldOffset(Offset = "0x260")]
	public UIButton EpFullBtn;

	[Token(Token = "0x4017EA3")]
	[FieldOffset(Offset = "0x264")]
	public UISprite EPFullBg;

	[Token(Token = "0x4017EA4")]
	[FieldOffset(Offset = "0x268")]
	public UISprite EPFullBgSpr;

	[Token(Token = "0x4017EA5")]
	[FieldOffset(Offset = "0x26C")]
	public UILabel PersonalsignatureKey;

	[Token(Token = "0x4017EA6")]
	[FieldOffset(Offset = "0x270")]
	public UILabel Personalsignature;

	[Token(Token = "0x4017EA7")]
	[FieldOffset(Offset = "0x274")]
	public BoxCollider BoxColliderInputField;

	[Token(Token = "0x4017EA8")]
	[FieldOffset(Offset = "0x278")]
	public UIInput UIInputInputField;

	[Token(Token = "0x4017EA9")]
	[FieldOffset(Offset = "0x27C")]
	public GameObject IconEditSignature;

	[Token(Token = "0x4017EAA")]
	[FieldOffset(Offset = "0x280")]
	public GameObject FightBiaoqianTr1;

	[Token(Token = "0x4017EAB")]
	[FieldOffset(Offset = "0x284")]
	public UILabel FightBiaoqian;

	[Token(Token = "0x4017EAC")]
	[FieldOffset(Offset = "0x288")]
	public GameObject FightBiaoqianTr2;

	[Token(Token = "0x4017EAD")]
	[FieldOffset(Offset = "0x28C")]
	public UILabel FightBiaoqianNoKey;

	[Token(Token = "0x4017EAE")]
	[FieldOffset(Offset = "0x290")]
	public UILabel SocialBiaoqianNoKey;

	[Token(Token = "0x4017EAF")]
	[FieldOffset(Offset = "0x294")]
	public GameObject SocialBiaoqianTr2;

	[Token(Token = "0x4017EB0")]
	[FieldOffset(Offset = "0x298")]
	public GameObject SocialBiaoqianTr1;

	[Token(Token = "0x4017EB1")]
	[FieldOffset(Offset = "0x29C")]
	public UILabel SocialBiaoqian;

	[Token(Token = "0x4017EB2")]
	[FieldOffset(Offset = "0x2A0")]
	public UIButton PersonBtnSetting;

	[Token(Token = "0x4017EB3")]
	[FieldOffset(Offset = "0x2A4")]
	public UISprite SpriteRedDotSetting;

	[Token(Token = "0x4017EB4")]
	[FieldOffset(Offset = "0x2A8")]
	public UIButton PersonBtnAddFriend;

	[Token(Token = "0x4017EB5")]
	[FieldOffset(Offset = "0x2AC")]
	public UISprite FrendAddIcon;

	[Token(Token = "0x4017EB6")]
	[FieldOffset(Offset = "0x2B0")]
	public GameObject FriendAddText;

	[Token(Token = "0x4017EB7")]
	[FieldOffset(Offset = "0x2B4")]
	public UIButton PersonalShareBtn;

	[Token(Token = "0x4017EB8")]
	[FieldOffset(Offset = "0x2B8")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x4017EB9")]
	[FieldOffset(Offset = "0x2BC")]
	public GameObject ReplayNode;

	[Token(Token = "0x4017EBA")]
	[FieldOffset(Offset = "0x2C0")]
	public GameObject LeftItem;

	[Token(Token = "0x4017EBB")]
	[FieldOffset(Offset = "0x2C4")]
	public UIGrid ClothPreviewSuitGroup;

	[Token(Token = "0x4017EBC")]
	[FieldOffset(Offset = "0x2C8")]
	public UIGrid ClothPreviewGroup;

	[Token(Token = "0x4017EBD")]
	[FieldOffset(Offset = "0x2CC")]
	public GameObject ItemDesc;

	[Token(Token = "0x4017EBE")]
	[FieldOffset(Offset = "0x2D0")]
	public GameObject itemsdesc;

	[Token(Token = "0x4017EBF")]
	[FieldOffset(Offset = "0x2D4")]
	public UILabel itemDescLabel;

	[Token(Token = "0x4017EC0")]
	[FieldOffset(Offset = "0x2D8")]
	public GameObject ItemName;

	[Token(Token = "0x4017EC1")]
	[FieldOffset(Offset = "0x2DC")]
	public UISprite CalBg;

	[Token(Token = "0x4017EC2")]
	[FieldOffset(Offset = "0x2E0")]
	public UILabel itemNameLabel;

	[Token(Token = "0x4017EC3")]
	[FieldOffset(Offset = "0x2E4")]
	public UISprite ScreenshotTopBanner;

	[Token(Token = "0x4017EC4")]
	[FieldOffset(Offset = "0x2E8")]
	public UINetworkTexture HeadshotRemote;

	[Token(Token = "0x4017EC5")]
	[FieldOffset(Offset = "0x2EC")]
	public GameObject HeadshotDefault;

	[Token(Token = "0x4017EC6")]
	[FieldOffset(Offset = "0x2F0")]
	public UIEffectSprite HeadshotLocal;

	[Token(Token = "0x4017EC7")]
	[FieldOffset(Offset = "0x2F4")]
	public UILabel PlayerNickname;

	[Token(Token = "0x4017EC8")]
	[FieldOffset(Offset = "0x2F8")]
	public UILabel PlayerID;

	[Token(Token = "0x4017EC9")]
	[FieldOffset(Offset = "0x2FC")]
	public UISprite ScreenShotLine;

	[Token(Token = "0x4017ECA")]
	[FieldOffset(Offset = "0x300")]
	public UISprite ScreenShotBg;

	[Token(Token = "0x4017ECB")]
	[FieldOffset(Offset = "0x304")]
	public UISprite FreeFireLogo;

	[Token(Token = "0x4017ECC")]
	[FieldOffset(Offset = "0x308")]
	public GameObject SceenShotProfileNodeAll;

	[Token(Token = "0x4017ECD")]
	[FieldOffset(Offset = "0x30C")]
	public UIGrid ScreenShotprofilegrid;

	[Token(Token = "0x4017ECE")]
	[FieldOffset(Offset = "0x310")]
	public Transform ScreenShotprofileshowoneitem;

	[Token(Token = "0x4017ECF")]
	[FieldOffset(Offset = "0x314")]
	public UILabel ProfilenoDEsHAREDeslabel;

	[Token(Token = "0x4017ED0")]
	[FieldOffset(Offset = "0x318")]
	public GameObject SceenShotProfileHistory;

	[Token(Token = "0x4017ED1")]
	[FieldOffset(Offset = "0x31C")]
	public UITable IconTable;

	[Token(Token = "0x4017ED2")]
	[FieldOffset(Offset = "0x320")]
	public UIButton CreditIcon;

	[Token(Token = "0x4017ED3")]
	[FieldOffset(Offset = "0x324")]
	public UITexture Bg;

	[Token(Token = "0x4017ED4")]
	[FieldOffset(Offset = "0x328")]
	public GameObject CreditInfoNode;

	[Token(Token = "0x4017ED5")]
	[FieldOffset(Offset = "0x32C")]
	public UIGrid CommonHistoryInfoRoot;

	[Token(Token = "0x4017ED6")]
	[FieldOffset(Offset = "0x330")]
	public UILabel HistoryScorelLabel;

	[Token(Token = "0x4017ED7")]
	[FieldOffset(Offset = "0x334")]
	public UILabel HistoryScore;

	[Token(Token = "0x4017ED8")]
	[FieldOffset(Offset = "0x338")]
	public UISprite PersonBg1;

	[Token(Token = "0x4017ED9")]
	[FieldOffset(Offset = "0x33C")]
	public UISprite PersonBg2;

	[Token(Token = "0x6016F3D")]
	[Address(RVA = "0x1ABD9A4", Offset = "0x1ABD9A4", VA = "0x1ABD9A4")]
	public UIProfileView()
	{
	}

	[Token(Token = "0x6016F3E")]
	[Address(RVA = "0x1ABD9AC", Offset = "0x1ABD9AC", VA = "0x1ABD9AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016F3F")]
	[Address(RVA = "0x1AC2218", Offset = "0x1AC2218", VA = "0x1AC2218")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
