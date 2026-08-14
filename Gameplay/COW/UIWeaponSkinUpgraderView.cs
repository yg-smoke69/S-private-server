using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A7B")]
public class UIWeaponSkinUpgraderView : UIBaseView
{
	[Token(Token = "0x4018D44")]
	[FieldOffset(Offset = "0x14")]
	public GameObject GoRootNode;

	[Token(Token = "0x4018D45")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x4018D46")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ObjAnnouncementArea;

	[Token(Token = "0x4018D47")]
	[FieldOffset(Offset = "0x20")]
	public UIWidget WidgetPreview;

	[Token(Token = "0x4018D48")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelSkinName;

	[Token(Token = "0x4018D49")]
	[FieldOffset(Offset = "0x28")]
	public GameObject NewSkill;

	[Token(Token = "0x4018D4A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject NewSkillLock;

	[Token(Token = "0x4018D4B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelLockTip;

	[Token(Token = "0x4018D4C")]
	[FieldOffset(Offset = "0x34")]
	public UILabel UILabelLabelSkillDesc;

	[Token(Token = "0x4018D4D")]
	[FieldOffset(Offset = "0x38")]
	public TweenAlpha AlphaSkillDesc;

	[Token(Token = "0x4018D4E")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite SpriteSkillIcon;

	[Token(Token = "0x4018D4F")]
	[FieldOffset(Offset = "0x40")]
	public UILabel LabelWeaponSkill;

	[Token(Token = "0x4018D50")]
	[FieldOffset(Offset = "0x44")]
	public ParticleSystem ParticalSkillLock;

	[Token(Token = "0x4018D51")]
	[FieldOffset(Offset = "0x48")]
	public ParticleSystem ParticalSkillGlow;

	[Token(Token = "0x4018D52")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem ParticalSkillLizi;

	[Token(Token = "0x4018D53")]
	[FieldOffset(Offset = "0x50")]
	public ParticleSystem ParticalSkillFlash;

	[Token(Token = "0x4018D54")]
	[FieldOffset(Offset = "0x54")]
	public GameObject propertyContainer;

	[Token(Token = "0x4018D55")]
	[FieldOffset(Offset = "0x58")]
	public GameObject pvpPropertyContainer;

	[Token(Token = "0x4018D56")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject propertyScore;

	[Token(Token = "0x4018D57")]
	[FieldOffset(Offset = "0x60")]
	public UITable propertyTable;

	[Token(Token = "0x4018D58")]
	[FieldOffset(Offset = "0x64")]
	public UIGrid scoreGrid;

	[Token(Token = "0x4018D59")]
	[FieldOffset(Offset = "0x68")]
	public ParticleSystem ParticalAttrGlow;

	[Token(Token = "0x4018D5A")]
	[FieldOffset(Offset = "0x6C")]
	public ParticleSystem ParticalAttrGlow2;

	[Token(Token = "0x4018D5B")]
	[FieldOffset(Offset = "0x70")]
	public ParticleSystem ParticalAttrLizi;

	[Token(Token = "0x4018D5C")]
	[FieldOffset(Offset = "0x74")]
	public ParticleSystem ParticalAttrCirculation;

	[Token(Token = "0x4018D5D")]
	[FieldOffset(Offset = "0x78")]
	public ParticleSystem ParticalAttrJiantou;

	[Token(Token = "0x4018D5E")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject EventTrigger;

	[Token(Token = "0x4018D5F")]
	[FieldOffset(Offset = "0x80")]
	public GameObject GoUIMask;

	[Token(Token = "0x4018D60")]
	[FieldOffset(Offset = "0x84")]
	public GameObject OverView;

	[Token(Token = "0x4018D61")]
	[FieldOffset(Offset = "0x88")]
	public UIScrollView PropertyPickScrollView;

	[Token(Token = "0x4018D62")]
	[FieldOffset(Offset = "0x8C")]
	public UIGrid GridProperty;

	[Token(Token = "0x4018D63")]
	[FieldOffset(Offset = "0x90")]
	public UIButton BtnSeeAnimAgain;

	[Token(Token = "0x4018D64")]
	[FieldOffset(Offset = "0x94")]
	public UILabel LabelSeeAnimAgain;

	[Token(Token = "0x4018D65")]
	[FieldOffset(Offset = "0x98")]
	public UISprite SpriteSeeAnimAgain;

	[Token(Token = "0x4018D66")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel LabelFeatureText;

	[Token(Token = "0x4018D67")]
	[FieldOffset(Offset = "0xA0")]
	public UIGrid MainBtnGrid;

	[Token(Token = "0x4018D68")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton BtnGoToDetail;

	[Token(Token = "0x4018D69")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton BtnGoToPurchase;

	[Token(Token = "0x4018D6A")]
	[FieldOffset(Offset = "0xAC")]
	public UILabel LabelBtnGridGoposUnopen;

	[Token(Token = "0x4018D6B")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject UpgradeView;

	[Token(Token = "0x4018D6C")]
	[FieldOffset(Offset = "0xB4")]
	public UIButton BtnSeeAnim;

	[Token(Token = "0x4018D6D")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel LabelSeeAnim;

	[Token(Token = "0x4018D6E")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite SpriteSeeAnim;

	[Token(Token = "0x4018D6F")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton BtnGoToDepot;

	[Token(Token = "0x4018D70")]
	[FieldOffset(Offset = "0xC4")]
	public UILabel LabelObtainedFeature;

	[Token(Token = "0x4018D71")]
	[FieldOffset(Offset = "0xC8")]
	public UIGrid GridFeatureAdd;

	[Token(Token = "0x4018D72")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject ObjHaveHad;

	[Token(Token = "0x4018D73")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel LabelObtainStyle;

	[Token(Token = "0x4018D74")]
	[FieldOffset(Offset = "0xD4")]
	public GameObject ObjHaventHave;

	[Token(Token = "0x4018D75")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel LabelFeatureViewGoposUnopen;

	[Token(Token = "0x4018D76")]
	[FieldOffset(Offset = "0xDC")]
	public UIGrid FragmentProgressGrid;

	[Token(Token = "0x4018D77")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject FragmentProgressItem0;

	[Token(Token = "0x4018D78")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite SpriteFragmentProgressItem0;

	[Token(Token = "0x4018D79")]
	[FieldOffset(Offset = "0xE8")]
	public UILabel LabelFragmentProgressItem0;

	[Token(Token = "0x4018D7A")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject FragmentProgressItem2;

	[Token(Token = "0x4018D7B")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite SpriteFragmentProgressItem2;

	[Token(Token = "0x4018D7C")]
	[FieldOffset(Offset = "0xF4")]
	public UILabel LabelFragmentProgressItem2;

	[Token(Token = "0x4018D7D")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject FragmentProgressItem1;

	[Token(Token = "0x4018D7E")]
	[FieldOffset(Offset = "0xFC")]
	public UISprite SpriteFragmentProgressItem1;

	[Token(Token = "0x4018D7F")]
	[FieldOffset(Offset = "0x100")]
	public UILabel LabelFragmentProgressItem1;

	[Token(Token = "0x4018D80")]
	[FieldOffset(Offset = "0x104")]
	public UIButton BtnGetFragment;

	[Token(Token = "0x4018D81")]
	[FieldOffset(Offset = "0x108")]
	public UILabel LabelGetFragment;

	[Token(Token = "0x4018D82")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton BtnUpgrade;

	[Token(Token = "0x4018D83")]
	[FieldOffset(Offset = "0x110")]
	public UIButton BtnUpgradeViewPurchase;

	[Token(Token = "0x4018D84")]
	[FieldOffset(Offset = "0x114")]
	public UILabel LabelUpgradeFirst;

	[Token(Token = "0x4018D85")]
	[FieldOffset(Offset = "0x118")]
	public UIButton BtnGotoUpgrade;

	[Token(Token = "0x4018D86")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject LevelPickContainer;

	[Token(Token = "0x4018D87")]
	[FieldOffset(Offset = "0x120")]
	public UIScrollView UIScrollViewLevelPickScrollView;

	[Token(Token = "0x4018D88")]
	[FieldOffset(Offset = "0x124")]
	public UIPanel PanelLevelPick;

	[Token(Token = "0x4018D89")]
	[FieldOffset(Offset = "0x128")]
	public UIGrid LevelGrid;

	[Token(Token = "0x4018D8A")]
	[FieldOffset(Offset = "0x12C")]
	public Transform TrDownload;

	[Token(Token = "0x4018D8B")]
	[FieldOffset(Offset = "0x130")]
	public UILabel RemainTokenNum;

	[Token(Token = "0x4018D8C")]
	[FieldOffset(Offset = "0x134")]
	public UIButton RemainTokenExchangeBtn;

	[Token(Token = "0x4018D8D")]
	[FieldOffset(Offset = "0x138")]
	public UISprite TokenSprite;

	[Token(Token = "0x4018D8E")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject RemainingTokenExchange;

	[Token(Token = "0x4018D8F")]
	[FieldOffset(Offset = "0x140")]
	public Transform BtnSeeAnimAgainDownloadCtrlPos;

	[Token(Token = "0x4018D90")]
	[FieldOffset(Offset = "0x144")]
	public Transform BtnSeeAnimDownloadCtrlPis;

	[Token(Token = "0x6017317")]
	[Address(RVA = "0x1B78B78", Offset = "0x1B78B78", VA = "0x1B78B78")]
	public UIWeaponSkinUpgraderView()
	{
	}

	[Token(Token = "0x6017318")]
	[Address(RVA = "0x1B78B80", Offset = "0x1B78B80", VA = "0x1B78B80", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017319")]
	[Address(RVA = "0x1B7A84C", Offset = "0x1B7A84C", VA = "0x1B7A84C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
