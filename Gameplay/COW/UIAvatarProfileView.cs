using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033D6")]
public class UIAvatarProfileView : UIBaseView
{
	[Token(Token = "0x4013DCC")]
	[FieldOffset(Offset = "0x14")]
	public GameObject MaxMask1;

	[Token(Token = "0x4013DCD")]
	[FieldOffset(Offset = "0x18")]
	public UISprite AlignmentIcon;

	[Token(Token = "0x4013DCE")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton AlignmentBtn;

	[Token(Token = "0x4013DCF")]
	[FieldOffset(Offset = "0x20")]
	public UITable CharacterInfoTable;

	[Token(Token = "0x4013DD0")]
	[FieldOffset(Offset = "0x24")]
	public UILabel CharacterName;

	[Token(Token = "0x4013DD1")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Characterlv;

	[Token(Token = "0x4013DD2")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CharacterIntroduction;

	[Token(Token = "0x4013DD3")]
	[FieldOffset(Offset = "0x30")]
	public UILabel DefaultCharacterIntroduction;

	[Token(Token = "0x4013DD4")]
	[FieldOffset(Offset = "0x34")]
	public GameObject tipsNode;

	[Token(Token = "0x4013DD5")]
	[FieldOffset(Offset = "0x38")]
	public UIButton TipBtn;

	[Token(Token = "0x4013DD6")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SkillDesc;

	[Token(Token = "0x4013DD7")]
	[FieldOffset(Offset = "0x40")]
	public Transform SkillSprite;

	[Token(Token = "0x4013DD8")]
	[FieldOffset(Offset = "0x44")]
	public UILabel SkillName;

	[Token(Token = "0x4013DD9")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SkillType;

	[Token(Token = "0x4013DDA")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DebrisInfo;

	[Token(Token = "0x4013DDB")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DebrisCount;

	[Token(Token = "0x4013DDC")]
	[FieldOffset(Offset = "0x54")]
	public UIButton levelUpEffectContainer;

	[Token(Token = "0x4013DDD")]
	[FieldOffset(Offset = "0x58")]
	public UIButton AwakenSkillUpgradeBtn;

	[Token(Token = "0x4013DDE")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject AwakenSkillRedDot;

	[Token(Token = "0x4013DDF")]
	[FieldOffset(Offset = "0x60")]
	public UIScrollView SkillDescScrollView;

	[Token(Token = "0x4013DE0")]
	[FieldOffset(Offset = "0x64")]
	public UILabel CurrentSkillDesc;

	[Token(Token = "0x4013DE1")]
	[FieldOffset(Offset = "0x68")]
	public UIEasyList ProfileList;

	[Token(Token = "0x4013DE2")]
	[FieldOffset(Offset = "0x6C")]
	public UIPanel ArrowPanel;

	[Token(Token = "0x4013DE3")]
	[FieldOffset(Offset = "0x70")]
	public GameObject SkillSlots;

	[Token(Token = "0x4013DE4")]
	[FieldOffset(Offset = "0x74")]
	public Transform SlotPos_1;

	[Token(Token = "0x4013DE5")]
	[FieldOffset(Offset = "0x78")]
	public Transform SlotPos_2;

	[Token(Token = "0x4013DE6")]
	[FieldOffset(Offset = "0x7C")]
	public Transform SlotPos_3;

	[Token(Token = "0x4013DE7")]
	[FieldOffset(Offset = "0x80")]
	public Transform SlotPos_4;

	[Token(Token = "0x4013DE8")]
	[FieldOffset(Offset = "0x84")]
	public Transform SlotPos_5;

	[Token(Token = "0x4013DE9")]
	[FieldOffset(Offset = "0x88")]
	public GameObject pveweaponnode;

	[Token(Token = "0x4013DEA")]
	[FieldOffset(Offset = "0x8C")]
	public UISprite pveweaponicon;

	[Token(Token = "0x4013DEB")]
	[FieldOffset(Offset = "0x90")]
	public GameObject DefaultAvatarNode;

	[Token(Token = "0x4013DEC")]
	[FieldOffset(Offset = "0x94")]
	public UISprite DefaultIPTag;

	[Token(Token = "0x4013DED")]
	[FieldOffset(Offset = "0x98")]
	public UIButton DefaultVoicePlayBtn;

	[Token(Token = "0x4013DEE")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject DefaultVoicePlaying;

	[Token(Token = "0x4013DEF")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject DefaultVoiceNormal;

	[Token(Token = "0x4013DF0")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel DefaultAvatarName;

	[Token(Token = "0x4013DF1")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel DefaultAvatarDesc;

	[Token(Token = "0x4013DF2")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject ChangeSkinColor;

	[Token(Token = "0x4013DF3")]
	[FieldOffset(Offset = "0xB0")]
	public UISlider UISlidercolorSlider;

	[Token(Token = "0x4013DF4")]
	[FieldOffset(Offset = "0xB4")]
	public UIEventListener UIEventListenercolorSlider;

	[Token(Token = "0x4013DF5")]
	[FieldOffset(Offset = "0xB8")]
	public UIEventListener Thumb;

	[Token(Token = "0x4013DF6")]
	[FieldOffset(Offset = "0xBC")]
	public UISprite ThumbSprite;

	[Token(Token = "0x4013DF7")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite colorResult;

	[Token(Token = "0x4013DF8")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject DefaultStoryPanel;

	[Token(Token = "0x4013DF9")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel DefaultAge;

	[Token(Token = "0x4013DFA")]
	[FieldOffset(Offset = "0xCC")]
	public UILabel DefaultBirth;

	[Token(Token = "0x4013DFB")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel DefaultCareer;

	[Token(Token = "0x4013DFC")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel DefaultLove;

	[Token(Token = "0x4013DFD")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel DefaultRelation1;

	[Token(Token = "0x4013DFE")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite UISpriteDefaultRelationIcon1;

	[Token(Token = "0x4013DFF")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton UIButtonDefaultRelationIcon1;

	[Token(Token = "0x4013E00")]
	[FieldOffset(Offset = "0xE4")]
	public UILabel DefaultRelation2;

	[Token(Token = "0x4013E01")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite UISpriteDefaultRelationIcon2;

	[Token(Token = "0x4013E02")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton UIButtonDefaultRelationIcon2;

	[Token(Token = "0x4013E03")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel DefaultRelation3;

	[Token(Token = "0x4013E04")]
	[FieldOffset(Offset = "0xF4")]
	public UISprite UISpriteDefaultRelationIcon3;

	[Token(Token = "0x4013E05")]
	[FieldOffset(Offset = "0xF8")]
	public UIButton UIButtonDefaultRelationIcon3;

	[Token(Token = "0x4013E06")]
	[FieldOffset(Offset = "0xFC")]
	public UIButton DefaultStoryBtn;

	[Token(Token = "0x4013E07")]
	[FieldOffset(Offset = "0x100")]
	public GameObject Maxbg1;

	[Token(Token = "0x4013E08")]
	[FieldOffset(Offset = "0x104")]
	public GameObject CommonAvatarNode;

	[Token(Token = "0x4013E09")]
	[FieldOffset(Offset = "0x108")]
	public UISprite CommonIPTag;

	[Token(Token = "0x4013E0A")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton CommonVoicePlayBtn;

	[Token(Token = "0x4013E0B")]
	[FieldOffset(Offset = "0x110")]
	public GameObject CommonVoicePlaying;

	[Token(Token = "0x4013E0C")]
	[FieldOffset(Offset = "0x114")]
	public GameObject CommonVoiceNormal;

	[Token(Token = "0x4013E0D")]
	[FieldOffset(Offset = "0x118")]
	public UILabel CommonAvatarName;

	[Token(Token = "0x4013E0E")]
	[FieldOffset(Offset = "0x11C")]
	public UILabel CommonAvatarDesc;

	[Token(Token = "0x4013E0F")]
	[FieldOffset(Offset = "0x120")]
	public GameObject CommonSkillPanel;

	[Token(Token = "0x4013E10")]
	[FieldOffset(Offset = "0x124")]
	public UIPanel CommonSkillP;

	[Token(Token = "0x4013E11")]
	[FieldOffset(Offset = "0x128")]
	public Transform CommonMainSkillPos;

	[Token(Token = "0x4013E12")]
	[FieldOffset(Offset = "0x12C")]
	public Transform CommonEquipPos1;

	[Token(Token = "0x4013E13")]
	[FieldOffset(Offset = "0x130")]
	public Transform CommonEquipPos2;

	[Token(Token = "0x4013E14")]
	[FieldOffset(Offset = "0x134")]
	public Transform CommonEquipPos3;

	[Token(Token = "0x4013E15")]
	[FieldOffset(Offset = "0x138")]
	public UILabel CommonSkillType;

	[Token(Token = "0x4013E16")]
	[FieldOffset(Offset = "0x13C")]
	public UILabel CommonSkillName;

	[Token(Token = "0x4013E17")]
	[FieldOffset(Offset = "0x140")]
	public UIButton CommonlevelUpEffectContainer;

	[Token(Token = "0x4013E18")]
	[FieldOffset(Offset = "0x144")]
	public UIButton CommonLevelUpBtn;

	[Token(Token = "0x4013E19")]
	[FieldOffset(Offset = "0x148")]
	public UIScrollView CommonSkillDescScrollView;

	[Token(Token = "0x4013E1A")]
	[FieldOffset(Offset = "0x14C")]
	public UILabel CommonCurrentSkillDesc;

	[Token(Token = "0x4013E1B")]
	[FieldOffset(Offset = "0x150")]
	public UIButton UIButtonCommonLevelBtn;

	[Token(Token = "0x4013E1C")]
	[FieldOffset(Offset = "0x154")]
	public UIWidget UIWidgetCommonLevelBtn;

	[Token(Token = "0x4013E1D")]
	[FieldOffset(Offset = "0x158")]
	public GameObject CommonLevelTips;

	[Token(Token = "0x4013E1E")]
	[FieldOffset(Offset = "0x15C")]
	public GameObject CommonShowMode;

	[Token(Token = "0x4013E1F")]
	[FieldOffset(Offset = "0x160")]
	public GameObject CommonDisableMode;

	[Token(Token = "0x4013E20")]
	[FieldOffset(Offset = "0x164")]
	public UILabel DisableLabel2;

	[Token(Token = "0x4013E21")]
	[FieldOffset(Offset = "0x168")]
	public UIButton CommonTipBtn;

	[Token(Token = "0x4013E22")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject CommonStoryPanel;

	[Token(Token = "0x4013E23")]
	[FieldOffset(Offset = "0x170")]
	public UILabel CommonAge;

	[Token(Token = "0x4013E24")]
	[FieldOffset(Offset = "0x174")]
	public UILabel CommonBirth;

	[Token(Token = "0x4013E25")]
	[FieldOffset(Offset = "0x178")]
	public UILabel CommonCareer;

	[Token(Token = "0x4013E26")]
	[FieldOffset(Offset = "0x17C")]
	public UILabel CommonLove;

	[Token(Token = "0x4013E27")]
	[FieldOffset(Offset = "0x180")]
	public UILabel CommonRelation1;

	[Token(Token = "0x4013E28")]
	[FieldOffset(Offset = "0x184")]
	public UISprite UISpriteCommonRelationIcon1;

	[Token(Token = "0x4013E29")]
	[FieldOffset(Offset = "0x188")]
	public UIButton UIButtonCommonRelationIcon1;

	[Token(Token = "0x4013E2A")]
	[FieldOffset(Offset = "0x18C")]
	public UILabel CommonRelation2;

	[Token(Token = "0x4013E2B")]
	[FieldOffset(Offset = "0x190")]
	public UISprite UISpriteCommonRelationIcon2;

	[Token(Token = "0x4013E2C")]
	[FieldOffset(Offset = "0x194")]
	public UIButton UIButtonCommonRelationIcon2;

	[Token(Token = "0x4013E2D")]
	[FieldOffset(Offset = "0x198")]
	public UILabel CommonRelation3;

	[Token(Token = "0x4013E2E")]
	[FieldOffset(Offset = "0x19C")]
	public UISprite UISpriteCommonRelationIcon3;

	[Token(Token = "0x4013E2F")]
	[FieldOffset(Offset = "0x1A0")]
	public UIButton UIButtonCommonRelationIcon3;

	[Token(Token = "0x4013E30")]
	[FieldOffset(Offset = "0x1A4")]
	public UIButton CommonStoryBtn;

	[Token(Token = "0x4013E31")]
	[FieldOffset(Offset = "0x1A8")]
	public UIButton CommonSwitchBtn;

	[Token(Token = "0x4013E32")]
	[FieldOffset(Offset = "0x1AC")]
	public UISprite CommonSwitchIcon;

	[Token(Token = "0x4013E33")]
	[FieldOffset(Offset = "0x1B0")]
	public GameObject Maxbg3;

	[Token(Token = "0x4013E34")]
	[FieldOffset(Offset = "0x1B4")]
	public GameObject AwakenAvaytarNode;

	[Token(Token = "0x4013E35")]
	[FieldOffset(Offset = "0x1B8")]
	public UISprite AwakenIPTag;

	[Token(Token = "0x4013E36")]
	[FieldOffset(Offset = "0x1BC")]
	public UIButton AwakenVoicePlayBtn;

	[Token(Token = "0x4013E37")]
	[FieldOffset(Offset = "0x1C0")]
	public GameObject AwakenVoicePlaying;

	[Token(Token = "0x4013E38")]
	[FieldOffset(Offset = "0x1C4")]
	public GameObject AwakenVoiceNormal;

	[Token(Token = "0x4013E39")]
	[FieldOffset(Offset = "0x1C8")]
	public UILabel AwakenAvatarName;

	[Token(Token = "0x4013E3A")]
	[FieldOffset(Offset = "0x1CC")]
	public UILabel AwakenAvatarDesc;

	[Token(Token = "0x4013E3B")]
	[FieldOffset(Offset = "0x1D0")]
	public UIButton AwakenEntranceBtn;

	[Token(Token = "0x4013E3C")]
	[FieldOffset(Offset = "0x1D4")]
	public UILabel Label;

	[Token(Token = "0x4013E3D")]
	[FieldOffset(Offset = "0x1D8")]
	public GameObject Vfx;

	[Token(Token = "0x4013E3E")]
	[FieldOffset(Offset = "0x1DC")]
	public GameObject VFX;

	[Token(Token = "0x4013E3F")]
	[FieldOffset(Offset = "0x1E0")]
	public GameObject AwakenEntranceTips;

	[Token(Token = "0x4013E40")]
	[FieldOffset(Offset = "0x1E4")]
	public GameObject AwakenAvatarExchangeContainer;

	[Token(Token = "0x4013E41")]
	[FieldOffset(Offset = "0x1E8")]
	public UIButton UIButtonExchangeToOriAvatarBtn;

	[Token(Token = "0x4013E42")]
	[FieldOffset(Offset = "0x1EC")]
	public UIAvatarAwakenSwitchItemView UIAvatarAwakenSwitchItemViewExchangeToOriAvatarBtn;

	[Token(Token = "0x4013E43")]
	[FieldOffset(Offset = "0x1F0")]
	public UIButton UIButtonExchangeToAwakenAvatarBtn;

	[Token(Token = "0x4013E44")]
	[FieldOffset(Offset = "0x1F4")]
	public UIAvatarAwakenSwitchItemView UIAvatarAwakenSwitchItemViewExchangeToAwakenAvatarBtn;

	[Token(Token = "0x4013E45")]
	[FieldOffset(Offset = "0x1F8")]
	public GameObject AwakenUnLockKey;

	[Token(Token = "0x4013E46")]
	[FieldOffset(Offset = "0x1FC")]
	public UISprite AwakenTagIcon;

	[Token(Token = "0x4013E47")]
	[FieldOffset(Offset = "0x200")]
	public GameObject AwakenSkillPanel;

	[Token(Token = "0x4013E48")]
	[FieldOffset(Offset = "0x204")]
	public UIPanel AwakenSkillP;

	[Token(Token = "0x4013E49")]
	[FieldOffset(Offset = "0x208")]
	public Transform AwakenEquipPos1;

	[Token(Token = "0x4013E4A")]
	[FieldOffset(Offset = "0x20C")]
	public Transform AwakenEquipPos2;

	[Token(Token = "0x4013E4B")]
	[FieldOffset(Offset = "0x210")]
	public Transform AwakenEquipPos3;

	[Token(Token = "0x4013E4C")]
	[FieldOffset(Offset = "0x214")]
	public Transform AwakenMainSkillPos;

	[Token(Token = "0x4013E4D")]
	[FieldOffset(Offset = "0x218")]
	public UILabel AwakenSkillType;

	[Token(Token = "0x4013E4E")]
	[FieldOffset(Offset = "0x21C")]
	public UILabel AwakenSkillName;

	[Token(Token = "0x4013E4F")]
	[FieldOffset(Offset = "0x220")]
	public GameObject VFX_ChangeName;

	[Token(Token = "0x4013E50")]
	[FieldOffset(Offset = "0x224")]
	public UIButton AwakenlevelUpEffectContainer;

	[Token(Token = "0x4013E51")]
	[FieldOffset(Offset = "0x228")]
	public UIButton AwakenLevelUpBtn;

	[Token(Token = "0x4013E52")]
	[FieldOffset(Offset = "0x22C")]
	public UIScrollView AwakenSkillDescScrollView;

	[Token(Token = "0x4013E53")]
	[FieldOffset(Offset = "0x230")]
	public UILabel AwakenCurrentSkillDesc;

	[Token(Token = "0x4013E54")]
	[FieldOffset(Offset = "0x234")]
	public UISprite icon;

	[Token(Token = "0x4013E55")]
	[FieldOffset(Offset = "0x238")]
	public UIScrollView AwakenSkillDescScrollView1;

	[Token(Token = "0x4013E56")]
	[FieldOffset(Offset = "0x23C")]
	public UILabel AwakenCurrentSkillDesc1;

	[Token(Token = "0x4013E57")]
	[FieldOffset(Offset = "0x240")]
	public UIButton UIButtonAwakenLevelBtn;

	[Token(Token = "0x4013E58")]
	[FieldOffset(Offset = "0x244")]
	public UIWidget UIWidgetAwakenLevelBtn;

	[Token(Token = "0x4013E59")]
	[FieldOffset(Offset = "0x248")]
	public GameObject AwakenLevelTips;

	[Token(Token = "0x4013E5A")]
	[FieldOffset(Offset = "0x24C")]
	public GameObject AwakenSHowMode;

	[Token(Token = "0x4013E5B")]
	[FieldOffset(Offset = "0x250")]
	public GameObject AwakenDisableMode;

	[Token(Token = "0x4013E5C")]
	[FieldOffset(Offset = "0x254")]
	public UILabel DisableLevel1;

	[Token(Token = "0x4013E5D")]
	[FieldOffset(Offset = "0x258")]
	public UIButton AwakenTipBtn;

	[Token(Token = "0x4013E5E")]
	[FieldOffset(Offset = "0x25C")]
	public GameObject AwakenStoryPanel;

	[Token(Token = "0x4013E5F")]
	[FieldOffset(Offset = "0x260")]
	public UILabel AwakenAge;

	[Token(Token = "0x4013E60")]
	[FieldOffset(Offset = "0x264")]
	public UILabel AwakenBirth;

	[Token(Token = "0x4013E61")]
	[FieldOffset(Offset = "0x268")]
	public UILabel AwakenCareer;

	[Token(Token = "0x4013E62")]
	[FieldOffset(Offset = "0x26C")]
	public UILabel AwakenLove;

	[Token(Token = "0x4013E63")]
	[FieldOffset(Offset = "0x270")]
	public UILabel AwakenRelation1;

	[Token(Token = "0x4013E64")]
	[FieldOffset(Offset = "0x274")]
	public UISprite UISpriteAwakenRelationIcon1;

	[Token(Token = "0x4013E65")]
	[FieldOffset(Offset = "0x278")]
	public UIButton UIButtonAwakenRelationIcon1;

	[Token(Token = "0x4013E66")]
	[FieldOffset(Offset = "0x27C")]
	public UILabel AwakenRelation2;

	[Token(Token = "0x4013E67")]
	[FieldOffset(Offset = "0x280")]
	public UISprite UISpriteAwakenRelationIcon2;

	[Token(Token = "0x4013E68")]
	[FieldOffset(Offset = "0x284")]
	public UIButton UIButtonAwakenRelationIcon2;

	[Token(Token = "0x4013E69")]
	[FieldOffset(Offset = "0x288")]
	public UILabel AwakenRelation3;

	[Token(Token = "0x4013E6A")]
	[FieldOffset(Offset = "0x28C")]
	public UISprite UISpriteAwakenRelationIcon3;

	[Token(Token = "0x4013E6B")]
	[FieldOffset(Offset = "0x290")]
	public UIButton UIButtonAwakenRelationIcon3;

	[Token(Token = "0x4013E6C")]
	[FieldOffset(Offset = "0x294")]
	public UIButton AwakenStoryBtn;

	[Token(Token = "0x4013E6D")]
	[FieldOffset(Offset = "0x298")]
	public UIButton AwakenSwitchBtn;

	[Token(Token = "0x4013E6E")]
	[FieldOffset(Offset = "0x29C")]
	public UISprite AwakenSwitchIcon;

	[Token(Token = "0x4013E6F")]
	[FieldOffset(Offset = "0x2A0")]
	public GameObject Maxbg2;

	[Token(Token = "0x4013E70")]
	[FieldOffset(Offset = "0x2A4")]
	public GameObject Border;

	[Token(Token = "0x4013E71")]
	[FieldOffset(Offset = "0x2A8")]
	public UIButton VoiceDownloadBtn;

	[Token(Token = "0x4013E72")]
	[FieldOffset(Offset = "0x2AC")]
	public GameObject CommonSkillShowTag;

	[Token(Token = "0x4013E73")]
	[FieldOffset(Offset = "0x2B0")]
	public Transform HotFixDownloadPos;

	[Token(Token = "0x4013E74")]
	[FieldOffset(Offset = "0x2B4")]
	public UIButton SkillGuideBtn;

	[Token(Token = "0x4013E75")]
	[FieldOffset(Offset = "0x2B8")]
	public UIWidget SkillGuideWidget;

	[Token(Token = "0x4013E76")]
	[FieldOffset(Offset = "0x2BC")]
	public Transform AwakenLoveNode;

	[Token(Token = "0x4013E77")]
	[FieldOffset(Offset = "0x2C0")]
	public Transform CommonLoveNode;

	[Token(Token = "0x4013E78")]
	[FieldOffset(Offset = "0x2C4")]
	public Transform DefaultLoveNode;

	[Token(Token = "0x4013E79")]
	[FieldOffset(Offset = "0x2C8")]
	public GameObject EmptyShowTag;

	[Token(Token = "0x4013E7A")]
	[FieldOffset(Offset = "0x2CC")]
	public Transform EmptyEquipPos1;

	[Token(Token = "0x4013E7B")]
	[FieldOffset(Offset = "0x2D0")]
	public Transform EmptyEquipPos2;

	[Token(Token = "0x4013E7C")]
	[FieldOffset(Offset = "0x2D4")]
	public Transform EmptyEquipPos3;

	[Token(Token = "0x4013E7D")]
	[FieldOffset(Offset = "0x2D8")]
	public UIButton EmptySkillSlotBtn;

	[Token(Token = "0x4013E7E")]
	[FieldOffset(Offset = "0x2DC")]
	public GameObject LeftPanel1;

	[Token(Token = "0x6015F38")]
	[Address(RVA = "0x2F8F248", Offset = "0x2F8F248", VA = "0x2F8F248")]
	public UIAvatarProfileView()
	{
	}

	[Token(Token = "0x6015F39")]
	[Address(RVA = "0x2F8F250", Offset = "0x2F8F250", VA = "0x2F8F250", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F3A")]
	[Address(RVA = "0x2F9318C", Offset = "0x2F9318C", VA = "0x2F9318C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
