using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003849")]
public class UILobbyNewRightBottomView : UIBaseView
{
	[Token(Token = "0x4017028")]
	[FieldOffset(Offset = "0x14")]
	public Transform RightBottom;

	[Token(Token = "0x4017029")]
	[FieldOffset(Offset = "0x18")]
	public UILobbyNewSkinChangeView RightBottomView;

	[Token(Token = "0x401702A")]
	[FieldOffset(Offset = "0x1C")]
	public Transform OptionalDownloaderContainer;

	[Token(Token = "0x401702B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ModeMask;

	[Token(Token = "0x401702C")]
	[FieldOffset(Offset = "0x24")]
	public UIButton UIButtonmapModeBtn;

	[Token(Token = "0x401702D")]
	[FieldOffset(Offset = "0x28")]
	public UIWidget UIWidgetmapModeBtn;

	[Token(Token = "0x401702E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite mapModeBtnBg;

	[Token(Token = "0x401702F")]
	[FieldOffset(Offset = "0x30")]
	public UILabel matchModelSelected;

	[Token(Token = "0x4017030")]
	[FieldOffset(Offset = "0x34")]
	public UISprite matchModeTag;

	[Token(Token = "0x4017031")]
	[FieldOffset(Offset = "0x38")]
	public GameObject NormalVeiw;

	[Token(Token = "0x4017032")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel gameModeSelected;

	[Token(Token = "0x4017033")]
	[FieldOffset(Offset = "0x40")]
	public UILabel mapModeSelected;

	[Token(Token = "0x4017034")]
	[FieldOffset(Offset = "0x44")]
	public GameObject BonusVeiw;

	[Token(Token = "0x4017035")]
	[FieldOffset(Offset = "0x48")]
	public UILabel BgameModeSelected;

	[Token(Token = "0x4017036")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject BonusReward;

	[Token(Token = "0x4017037")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ladderExtraBonusTxt;

	[Token(Token = "0x4017038")]
	[FieldOffset(Offset = "0x54")]
	public GameObject ChampionshipBonusReward;

	[Token(Token = "0x4017039")]
	[FieldOffset(Offset = "0x58")]
	public UILabel GoldBonusLabel;

	[Token(Token = "0x401703A")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel ExpBonusLabel;

	[Token(Token = "0x401703B")]
	[FieldOffset(Offset = "0x60")]
	public UILabel BmapModeSelected;

	[Token(Token = "0x401703C")]
	[FieldOffset(Offset = "0x64")]
	public GameObject NoDudectView;

	[Token(Token = "0x401703D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DoubleTokenView;

	[Token(Token = "0x401703E")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel DoubleTokenLabel;

	[Token(Token = "0x401703F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject DoublePointView;

	[Token(Token = "0x4017040")]
	[FieldOffset(Offset = "0x74")]
	public UILabel RankRPLabel;

	[Token(Token = "0x4017041")]
	[FieldOffset(Offset = "0x78")]
	public UIButton HelperBtn;

	[Token(Token = "0x4017042")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject MapHintContainer;

	[Token(Token = "0x4017043")]
	[FieldOffset(Offset = "0x80")]
	public UILabel NewModeTip;

	[Token(Token = "0x4017044")]
	[FieldOffset(Offset = "0x84")]
	public UILabel ActivityTip;

	[Token(Token = "0x4017045")]
	[FieldOffset(Offset = "0x88")]
	public GameObject MapModeTipsAnim;

	[Token(Token = "0x4017046")]
	[FieldOffset(Offset = "0x8C")]
	public UIWidget RankCompetitionGuide;

	[Token(Token = "0x4017047")]
	[FieldOffset(Offset = "0x90")]
	public UIButton teamModeBtn;

	[Token(Token = "0x4017048")]
	[FieldOffset(Offset = "0x94")]
	public UISprite teamIcon;

	[Token(Token = "0x4017049")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TeamModeTipsAnim;

	[Token(Token = "0x401704A")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject teamModesPanel;

	[Token(Token = "0x401704B")]
	[FieldOffset(Offset = "0xA0")]
	public UISprite teamIconDulicate;

	[Token(Token = "0x401704C")]
	[FieldOffset(Offset = "0xA4")]
	public UIToggleButton teamBtn;

	[Token(Token = "0x401704D")]
	[FieldOffset(Offset = "0xA8")]
	public UIWidget teamBtnAlphaRoot;

	[Token(Token = "0x401704E")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite ModeIcon4p;

	[Token(Token = "0x401704F")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel ModeLabel4p;

	[Token(Token = "0x4017050")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite ModeSelect4p;

	[Token(Token = "0x4017051")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite teamBtnBG;

	[Token(Token = "0x4017052")]
	[FieldOffset(Offset = "0xBC")]
	public UIToggleButton duoBtn;

	[Token(Token = "0x4017053")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget duoBtnAlphaRoot;

	[Token(Token = "0x4017054")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite ModeIcon2p;

	[Token(Token = "0x4017055")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel ModeLabel2p;

	[Token(Token = "0x4017056")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite ModeSelect2p;

	[Token(Token = "0x4017057")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite duoBtnBG;

	[Token(Token = "0x4017058")]
	[FieldOffset(Offset = "0xD4")]
	public UIToggleButton soloBtn;

	[Token(Token = "0x4017059")]
	[FieldOffset(Offset = "0xD8")]
	public UIWidget soloBtnAlphaRoot;

	[Token(Token = "0x401705A")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite ModeIcon1p;

	[Token(Token = "0x401705B")]
	[FieldOffset(Offset = "0xE0")]
	public UILabel ModeLabel1p;

	[Token(Token = "0x401705C")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite ModeSelect1p;

	[Token(Token = "0x401705D")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite soloBtnBG;

	[Token(Token = "0x401705E")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton UIButtonIncreaseBtn;

	[Token(Token = "0x401705F")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite UISpriteIncreaseBtn;

	[Token(Token = "0x4017060")]
	[FieldOffset(Offset = "0xF4")]
	public UISprite IncreaseIcon_0;

	[Token(Token = "0x4017061")]
	[FieldOffset(Offset = "0xF8")]
	public UISprite IncreaseIcon_1;

	[Token(Token = "0x4017062")]
	[FieldOffset(Offset = "0xFC")]
	public UISprite IncreaseIcon_2;

	[Token(Token = "0x4017063")]
	[FieldOffset(Offset = "0x100")]
	public UIButton InviteBtn;

	[Token(Token = "0x4017064")]
	[FieldOffset(Offset = "0x104")]
	public UILabel PlusLabel;

	[Token(Token = "0x4017065")]
	[FieldOffset(Offset = "0x108")]
	public UILabel Label;

	[Token(Token = "0x4017066")]
	[FieldOffset(Offset = "0x10C")]
	public TweenPosition TweenPosPanelRightBottom;

	[Token(Token = "0x4017067")]
	[FieldOffset(Offset = "0x110")]
	public UIButton playBtn;

	[Token(Token = "0x4017068")]
	[FieldOffset(Offset = "0x114")]
	public UILabel playLabel;

	[Token(Token = "0x4017069")]
	[FieldOffset(Offset = "0x118")]
	public GameObject autoMatch;

	[Token(Token = "0x401706A")]
	[FieldOffset(Offset = "0x11C")]
	public UIButton checkBtn;

	[Token(Token = "0x401706B")]
	[FieldOffset(Offset = "0x120")]
	public GameObject checkOn;

	[Token(Token = "0x401706C")]
	[FieldOffset(Offset = "0x124")]
	public Transform LoadOutContainer;

	[Token(Token = "0x401706D")]
	[FieldOffset(Offset = "0x128")]
	public UIWidget LoadoutGuideWidget;

	[Token(Token = "0x401706E")]
	[FieldOffset(Offset = "0x12C")]
	public GameObject soloPanel;

	[Token(Token = "0x401706F")]
	[FieldOffset(Offset = "0x130")]
	public GameObject GameObjectMatchMaking;

	[Token(Token = "0x4017070")]
	[FieldOffset(Offset = "0x134")]
	public UISprite UISpriteMatchMaking;

	[Token(Token = "0x4017071")]
	[FieldOffset(Offset = "0x138")]
	public UILabel SoloMatchMakingLabel;

	[Token(Token = "0x4017072")]
	[FieldOffset(Offset = "0x13C")]
	public UIWidget WidgetBtnStart;

	[Token(Token = "0x4017073")]
	[FieldOffset(Offset = "0x140")]
	public UIButton UIButtonBtnEnterGameSG;

	[Token(Token = "0x4017074")]
	[FieldOffset(Offset = "0x144")]
	public UIWidget UIWidgetBtnEnterGameSG;

	[Token(Token = "0x4017075")]
	[FieldOffset(Offset = "0x148")]
	public UISprite LobbyStartIcon;

	[Token(Token = "0x4017076")]
	[FieldOffset(Offset = "0x14C")]
	public UILabel StartMatchLabel;

	[Token(Token = "0x4017077")]
	[FieldOffset(Offset = "0x150")]
	public Transform SoloBonusInfoAttachPoint;

	[Token(Token = "0x4017078")]
	[FieldOffset(Offset = "0x154")]
	public GameObject Guide_start_Anim;

	[Token(Token = "0x4017079")]
	[FieldOffset(Offset = "0x158")]
	public GameObject GameObjectBtnEnterGameDisable;

	[Token(Token = "0x401707A")]
	[FieldOffset(Offset = "0x15C")]
	public UISprite UISpriteBtnEnterGameDisable;

	[Token(Token = "0x401707B")]
	[FieldOffset(Offset = "0x160")]
	public UILabel SoloBtnEnterDisLabel;

	[Token(Token = "0x401707C")]
	[FieldOffset(Offset = "0x164")]
	public UIWidget IAPBundleContainer;

	[Token(Token = "0x401707D")]
	[FieldOffset(Offset = "0x168")]
	public UIButton BtnBundleChoose1From3;

	[Token(Token = "0x401707E")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject VFX_BundleChoose1From3_NotCliam;

	[Token(Token = "0x401707F")]
	[FieldOffset(Offset = "0x170")]
	public UIButton BtnBundleWeb;

	[Token(Token = "0x4017080")]
	[FieldOffset(Offset = "0x174")]
	public UICountDownLabel IAPBundleCountdownLabel;

	[Token(Token = "0x4017081")]
	[FieldOffset(Offset = "0x178")]
	public Transform pveWeaponInfo;

	[Token(Token = "0x4017082")]
	[FieldOffset(Offset = "0x17C")]
	public UIGrid ModesGrid;

	[Token(Token = "0x4017083")]
	[FieldOffset(Offset = "0x180")]
	public UIToggleButton pentaBtn;

	[Token(Token = "0x4017084")]
	[FieldOffset(Offset = "0x184")]
	public UIWidget pentaBtnAlphaRoot;

	[Token(Token = "0x4017085")]
	[FieldOffset(Offset = "0x188")]
	public UISprite ModeSelect5p;

	[Token(Token = "0x4017086")]
	[FieldOffset(Offset = "0x18C")]
	public UISprite pentaBtnBG;

	[Token(Token = "0x4017087")]
	[FieldOffset(Offset = "0x190")]
	public UIWidget CSGuideWidget;

	[Token(Token = "0x4017088")]
	[FieldOffset(Offset = "0x194")]
	public Transform groupPanel;

	[Token(Token = "0x4017089")]
	[FieldOffset(Offset = "0x198")]
	public UIWidget InviteBoxContainer;

	[Token(Token = "0x401708A")]
	[FieldOffset(Offset = "0x19C")]
	public UISprite BGFilter;

	[Token(Token = "0x401708B")]
	[FieldOffset(Offset = "0x1A0")]
	public UISprite ModesBg;

	[Token(Token = "0x6016C86")]
	[Address(RVA = "0x1CA27A4", Offset = "0x1CA27A4", VA = "0x1CA27A4")]
	public UILobbyNewRightBottomView()
	{
	}

	[Token(Token = "0x6016C87")]
	[Address(RVA = "0x1CA27AC", Offset = "0x1CA27AC", VA = "0x1CA27AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C88")]
	[Address(RVA = "0x1CA4CA4", Offset = "0x1CA4CA4", VA = "0x1CA4CA4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
