using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A71")]
public class UIWeaponSkinLobbyMainView : UIBaseView
{
	[Token(Token = "0x4018C76")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ThirdPanelAnchor;

	[Token(Token = "0x4018C77")]
	[FieldOffset(Offset = "0x18")]
	public GameObject ThirdPanel;

	[Token(Token = "0x4018C78")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ThirdScrollView;

	[Token(Token = "0x4018C79")]
	[FieldOffset(Offset = "0x20")]
	public UIEasyList ThirdGrid;

	[Token(Token = "0x4018C7A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ShareUI;

	[Token(Token = "0x4018C7B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ShareItemDesc;

	[Token(Token = "0x4018C7C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite ShareNameBg;

	[Token(Token = "0x4018C7D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel SHareNameLabel;

	[Token(Token = "0x4018C7E")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ShareLevelObj;

	[Token(Token = "0x4018C7F")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ShareLevelLabel;

	[Token(Token = "0x4018C80")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ShareLevelIcon;

	[Token(Token = "0x4018C81")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ShareLevelLeftLabelTr;

	[Token(Token = "0x4018C82")]
	[FieldOffset(Offset = "0x44")]
	public GameObject ShareLevelCommonLabelTr;

	[Token(Token = "0x4018C83")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ShareDesc;

	[Token(Token = "0x4018C84")]
	[FieldOffset(Offset = "0x4C")]
	public Transform ShareLowPoint;

	[Token(Token = "0x4018C85")]
	[FieldOffset(Offset = "0x50")]
	public Transform ShareHighPoint;

	[Token(Token = "0x4018C86")]
	[FieldOffset(Offset = "0x54")]
	public UILabel OwnSkinLabel;

	[Token(Token = "0x4018C87")]
	[FieldOffset(Offset = "0x58")]
	public UIWidget LeftUI;

	[Token(Token = "0x4018C88")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject weaponMenuContainer;

	[Token(Token = "0x4018C89")]
	[FieldOffset(Offset = "0x60")]
	public GameObject FirstPanel;

	[Token(Token = "0x4018C8A")]
	[FieldOffset(Offset = "0x64")]
	public UIScrollView FirstScrollView;

	[Token(Token = "0x4018C8B")]
	[FieldOffset(Offset = "0x68")]
	public UIEasyList FirstGrid;

	[Token(Token = "0x4018C8C")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject SceondPanel;

	[Token(Token = "0x4018C8D")]
	[FieldOffset(Offset = "0x70")]
	public UIScrollView SecondScrollView;

	[Token(Token = "0x4018C8E")]
	[FieldOffset(Offset = "0x74")]
	public UIEasyList SecondGrid;

	[Token(Token = "0x4018C8F")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ItemDesc;

	[Token(Token = "0x4018C90")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject DescLevelObj;

	[Token(Token = "0x4018C91")]
	[FieldOffset(Offset = "0x80")]
	public UILabel DescLevelLabel;

	[Token(Token = "0x4018C92")]
	[FieldOffset(Offset = "0x84")]
	public GameObject DescLevelLeftLabelTr;

	[Token(Token = "0x4018C93")]
	[FieldOffset(Offset = "0x88")]
	public UISprite DescLevelIcon;

	[Token(Token = "0x4018C94")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject DescLevelCommonLabelTr;

	[Token(Token = "0x4018C95")]
	[FieldOffset(Offset = "0x90")]
	public GameObject itemsdesc;

	[Token(Token = "0x4018C96")]
	[FieldOffset(Offset = "0x94")]
	public UILabel itemDescLabel;

	[Token(Token = "0x4018C97")]
	[FieldOffset(Offset = "0x98")]
	public GameObject itemsname;

	[Token(Token = "0x4018C98")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite NewQualityiconBgY;

	[Token(Token = "0x4018C99")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel itemNameLabel;

	[Token(Token = "0x4018C9A")]
	[FieldOffset(Offset = "0xA4")]
	public UISprite itemnamerightposspr;

	[Token(Token = "0x4018C9B")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite NewQualityicon;

	[Token(Token = "0x4018C9C")]
	[FieldOffset(Offset = "0xAC")]
	public UIGrid IconTable;

	[Token(Token = "0x4018C9D")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton notificationIconBtn;

	[Token(Token = "0x4018C9E")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject notificationIcon;

	[Token(Token = "0x4018C9F")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject showIcon;

	[Token(Token = "0x4018CA0")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton showIconBtn;

	[Token(Token = "0x4018CA1")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton weaponskillbtn;

	[Token(Token = "0x4018CA2")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite SkillSpirte;

	[Token(Token = "0x4018CA3")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton skillbtn;

	[Token(Token = "0x4018CA4")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton tipsleft;

	[Token(Token = "0x4018CA5")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel skilltiplabelleft;

	[Token(Token = "0x4018CA6")]
	[FieldOffset(Offset = "0xD4")]
	public UIButton tipsright;

	[Token(Token = "0x4018CA7")]
	[FieldOffset(Offset = "0xD8")]
	public UILabel skilltiplabelright;

	[Token(Token = "0x4018CA8")]
	[FieldOffset(Offset = "0xDC")]
	public UISprite SkillSprBg;

	[Token(Token = "0x4018CA9")]
	[FieldOffset(Offset = "0xE0")]
	public UISprite sexicon;

	[Token(Token = "0x4018CAA")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject weaponSkinUpgradeInfoIcon;

	[Token(Token = "0x4018CAB")]
	[FieldOffset(Offset = "0xE8")]
	public UIButton BtnWeaponSkinUpgradeInfoIcon;

	[Token(Token = "0x4018CAC")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite IPTag;

	[Token(Token = "0x4018CAD")]
	[FieldOffset(Offset = "0xF0")]
	public Transform DescHighPos;

	[Token(Token = "0x4018CAE")]
	[FieldOffset(Offset = "0xF4")]
	public Transform DeshLowPos;

	[Token(Token = "0x4018CAF")]
	[FieldOffset(Offset = "0xF8")]
	public UIButton ShareBtn;

	[Token(Token = "0x4018CB0")]
	[FieldOffset(Offset = "0xFC")]
	public GameObject propertyContainer;

	[Token(Token = "0x4018CB1")]
	[FieldOffset(Offset = "0x100")]
	public GameObject pvpPropertyContainer;

	[Token(Token = "0x4018CB2")]
	[FieldOffset(Offset = "0x104")]
	public GameObject propertyScore;

	[Token(Token = "0x4018CB3")]
	[FieldOffset(Offset = "0x108")]
	public UITable propertyTable;

	[Token(Token = "0x4018CB4")]
	[FieldOffset(Offset = "0x10C")]
	public UIGrid scoreGrid;

	[Token(Token = "0x4018CB5")]
	[FieldOffset(Offset = "0x110")]
	public GameObject weaponSkill;

	[Token(Token = "0x4018CB6")]
	[FieldOffset(Offset = "0x114")]
	public GameObject pvePropertyContainer;

	[Token(Token = "0x4018CB7")]
	[FieldOffset(Offset = "0x118")]
	public GameObject pveweaponProperty;

	[Token(Token = "0x4018CB8")]
	[FieldOffset(Offset = "0x11C")]
	public GameObject skillicon;

	[Token(Token = "0x4018CB9")]
	[FieldOffset(Offset = "0x120")]
	public UIGrid toggleGrid;

	[Token(Token = "0x4018CBA")]
	[FieldOffset(Offset = "0x124")]
	public UIToggleButton pvpToggle;

	[Token(Token = "0x4018CBB")]
	[FieldOffset(Offset = "0x128")]
	public UIToggleButton pveToggle;

	[Token(Token = "0x4018CBC")]
	[FieldOffset(Offset = "0x12C")]
	public UIWidget RightUI;

	[Token(Token = "0x4018CBD")]
	[FieldOffset(Offset = "0x130")]
	public UIButton switchbtn;

	[Token(Token = "0x4018CBE")]
	[FieldOffset(Offset = "0x134")]
	public GameObject SwitchToGunSpr;

	[Token(Token = "0x4018CBF")]
	[FieldOffset(Offset = "0x138")]
	public GameObject SwitchToPersonSpr;

	[Token(Token = "0x4018CC0")]
	[FieldOffset(Offset = "0x13C")]
	public UIButton zoomBtn;

	[Token(Token = "0x4018CC1")]
	[FieldOffset(Offset = "0x140")]
	public GameObject btnGroup;

	[Token(Token = "0x4018CC2")]
	[FieldOffset(Offset = "0x144")]
	public UIButton equipBtn;

	[Token(Token = "0x4018CC3")]
	[FieldOffset(Offset = "0x148")]
	public UILabel btnName;

	[Token(Token = "0x4018CC4")]
	[FieldOffset(Offset = "0x14C")]
	public UIButton showBtn;

	[Token(Token = "0x4018CC5")]
	[FieldOffset(Offset = "0x150")]
	public UISprite ShowBtnSprite;

	[Token(Token = "0x4018CC6")]
	[FieldOffset(Offset = "0x154")]
	public UILabel showBtnName;

	[Token(Token = "0x4018CC7")]
	[FieldOffset(Offset = "0x158")]
	public GameObject check;

	[Token(Token = "0x4018CC8")]
	[FieldOffset(Offset = "0x15C")]
	public UIButton LevelUpBtn;

	[Token(Token = "0x4018CC9")]
	[FieldOffset(Offset = "0x160")]
	public GameObject LevelUpVfx;

	[Token(Token = "0x4018CCA")]
	[FieldOffset(Offset = "0x164")]
	public UIWidget PreviewUI;

	[Token(Token = "0x4018CCB")]
	[FieldOffset(Offset = "0x168")]
	public Transform notificationContainer;

	[Token(Token = "0x4018CCC")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject EventTrigger;

	[Token(Token = "0x4018CCD")]
	[FieldOffset(Offset = "0x170")]
	public Transform HotFixDownloadPos;

	[Token(Token = "0x4018CCE")]
	[FieldOffset(Offset = "0x174")]
	public UILabel NotReadyLabel;

	[Token(Token = "0x4018CCF")]
	[FieldOffset(Offset = "0x178")]
	public GameObject MutliSelectNode;

	[Token(Token = "0x4018CD0")]
	[FieldOffset(Offset = "0x17C")]
	public UICheckboxButton MutliCheckButton;

	[Token(Token = "0x4018CD1")]
	[FieldOffset(Offset = "0x180")]
	public UIButton TipsBtn;

	[Token(Token = "0x4018CD2")]
	[FieldOffset(Offset = "0x184")]
	public UISprite TipsBtnUISprite;

	[Token(Token = "0x4018CD3")]
	[FieldOffset(Offset = "0x188")]
	public UIButton MutliEquipBtn;

	[Token(Token = "0x4018CD4")]
	[FieldOffset(Offset = "0x18C")]
	public UIButton MutliUnequipBtn;

	[Token(Token = "0x4018CD5")]
	[FieldOffset(Offset = "0x190")]
	public GameObject MutliEquipedBtn;

	[Token(Token = "0x4018CD6")]
	[FieldOffset(Offset = "0x194")]
	public UIWidget MutliSelectGuideNode;

	[Token(Token = "0x60172F9")]
	[Address(RVA = "0x2EDB650", Offset = "0x2EDB650", VA = "0x2EDB650")]
	public UIWeaponSkinLobbyMainView()
	{
	}

	[Token(Token = "0x60172FA")]
	[Address(RVA = "0x2EDB658", Offset = "0x2EDB658", VA = "0x2EDB658", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172FB")]
	[Address(RVA = "0x2EDD978", Offset = "0x2EDD978", VA = "0x2EDD978")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
