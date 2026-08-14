using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038D7")]
public class UINewVaultView : UIBaseView
{
	[Token(Token = "0x40178E6")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftTabContainer;

	[Token(Token = "0x40178E7")]
	[FieldOffset(Offset = "0x18")]
	public UILabel LabelHint;

	[Token(Token = "0x40178E8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CallsignConfig;

	[Token(Token = "0x40178E9")]
	[FieldOffset(Offset = "0x20")]
	public UICheckboxButton CallsignCheckboxBtn;

	[Token(Token = "0x40178EA")]
	[FieldOffset(Offset = "0x24")]
	public UIButton HelpBtn;

	[Token(Token = "0x40178EB")]
	[FieldOffset(Offset = "0x28")]
	public UITable Table;

	[Token(Token = "0x40178EC")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ClothSetRecommend;

	[Token(Token = "0x40178ED")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ClothSetRecommendBG;

	[Token(Token = "0x40178EE")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnGoToDressUp;

	[Token(Token = "0x40178EF")]
	[FieldOffset(Offset = "0x38")]
	public GameObject VFX_UINewVault;

	[Token(Token = "0x40178F0")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject EmoteConfig;

	[Token(Token = "0x40178F1")]
	[FieldOffset(Offset = "0x40")]
	public UICheckboxButton EmoteCheckboxBtn;

	[Token(Token = "0x40178F2")]
	[FieldOffset(Offset = "0x44")]
	public UIWidget EmoteCheckWidget;

	[Token(Token = "0x40178F3")]
	[FieldOffset(Offset = "0x48")]
	public UIButton BagShowBtn;

	[Token(Token = "0x40178F4")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite ShowBtnSprite;

	[Token(Token = "0x40178F5")]
	[FieldOffset(Offset = "0x50")]
	public UILabel showBtnName;

	[Token(Token = "0x40178F6")]
	[FieldOffset(Offset = "0x54")]
	public GameObject check;

	[Token(Token = "0x40178F7")]
	[FieldOffset(Offset = "0x58")]
	public GameObject BackpackSwitchWidget;

	[Token(Token = "0x40178F8")]
	[FieldOffset(Offset = "0x5C")]
	public UIToggle BackpackSwitchToggle;

	[Token(Token = "0x40178F9")]
	[FieldOffset(Offset = "0x60")]
	public GameObject MusicConfig;

	[Token(Token = "0x40178FA")]
	[FieldOffset(Offset = "0x64")]
	public UICheckboxButton MusicCheckboxBtn;

	[Token(Token = "0x40178FB")]
	[FieldOffset(Offset = "0x68")]
	public GameObject SecondTabsNode;

	[Token(Token = "0x40178FC")]
	[FieldOffset(Offset = "0x6C")]
	public Transform CollectionContainer;

	[Token(Token = "0x40178FD")]
	[FieldOffset(Offset = "0x70")]
	public UISprite collectionBg;

	[Token(Token = "0x40178FE")]
	[FieldOffset(Offset = "0x74")]
	public UISprite collectionbg;

	[Token(Token = "0x40178FF")]
	[FieldOffset(Offset = "0x78")]
	public GameObject CollectionContainerNode;

	[Token(Token = "0x4017900")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject NormalNode;

	[Token(Token = "0x4017901")]
	[FieldOffset(Offset = "0x80")]
	public GameObject EmoteSlot;

	[Token(Token = "0x4017902")]
	[FieldOffset(Offset = "0x84")]
	public Transform Slot1;

	[Token(Token = "0x4017903")]
	[FieldOffset(Offset = "0x88")]
	public Transform Slot2;

	[Token(Token = "0x4017904")]
	[FieldOffset(Offset = "0x8C")]
	public Transform Slot3;

	[Token(Token = "0x4017905")]
	[FieldOffset(Offset = "0x90")]
	public Transform Slot4;

	[Token(Token = "0x4017906")]
	[FieldOffset(Offset = "0x94")]
	public Transform Slot5;

	[Token(Token = "0x4017907")]
	[FieldOffset(Offset = "0x98")]
	public Transform Slot6;

	[Token(Token = "0x4017908")]
	[FieldOffset(Offset = "0x9C")]
	public Transform Slot7;

	[Token(Token = "0x4017909")]
	[FieldOffset(Offset = "0xA0")]
	public Transform Slot8;

	[Token(Token = "0x401790A")]
	[FieldOffset(Offset = "0xA4")]
	public UILabel EmoteLabel;

	[Token(Token = "0x401790B")]
	[FieldOffset(Offset = "0xA8")]
	public GameObject EmoteNode;

	[Token(Token = "0x401790C")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject HeadPicNode;

	[Token(Token = "0x401790D")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject BannerNode;

	[Token(Token = "0x401790E")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject MusicNode;

	[Token(Token = "0x401790F")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject InstallmentNode;

	[Token(Token = "0x4017910")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject CollectionContainerNormalPos;

	[Token(Token = "0x4017911")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject CollectionContainerNoSecondTabPos;

	[Token(Token = "0x4017912")]
	[FieldOffset(Offset = "0xC4")]
	public Transform ClothSetRecommendAttachPoint;

	[Token(Token = "0x4017913")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject FirstTabNode;

	[Token(Token = "0x4017914")]
	[FieldOffset(Offset = "0xCC")]
	public GameObject Preview;

	[Token(Token = "0x4017915")]
	[FieldOffset(Offset = "0xD0")]
	public UIWidget PreviewLeftSide;

	[Token(Token = "0x4017916")]
	[FieldOffset(Offset = "0xD4")]
	public UIWidget PreviewLeftSide1;

	[Token(Token = "0x4017917")]
	[FieldOffset(Offset = "0xD8")]
	public UIWidget PreviewRightSide;

	[Token(Token = "0x4017918")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject CallsignPreview;

	[Token(Token = "0x4017919")]
	[FieldOffset(Offset = "0xE0")]
	public Transform HeadPreviewNode;

	[Token(Token = "0x401791A")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject EmotePreview;

	[Token(Token = "0x401791B")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject BGMPreview;

	[Token(Token = "0x401791C")]
	[FieldOffset(Offset = "0xEC")]
	public UISprite BMGRecordIcon;

	[Token(Token = "0x401791D")]
	[FieldOffset(Offset = "0xF0")]
	public GameObject GoLegendColor;

	[Token(Token = "0x401791E")]
	[FieldOffset(Offset = "0xF4")]
	public UIButton BtnColorPanel;

	[Token(Token = "0x401791F")]
	[FieldOffset(Offset = "0xF8")]
	public UISprite SpriteBtnColor;

	[Token(Token = "0x4017920")]
	[FieldOffset(Offset = "0xFC")]
	public UIPanel PanelShowColor;

	[Token(Token = "0x4017921")]
	[FieldOffset(Offset = "0x100")]
	public UISprite SpritePanelColorBg;

	[Token(Token = "0x4017922")]
	[FieldOffset(Offset = "0x104")]
	public UIGrid GridColorPanel;

	[Token(Token = "0x4017923")]
	[FieldOffset(Offset = "0x108")]
	public GameObject EmoteTrashContainer;

	[Token(Token = "0x4017924")]
	[FieldOffset(Offset = "0x10C")]
	public UIButton OpenBtn;

	[Token(Token = "0x4017925")]
	[FieldOffset(Offset = "0x110")]
	public UILabel OpenBtnLabel;

	[Token(Token = "0x4017926")]
	[FieldOffset(Offset = "0x114")]
	public UIButton GoToBtn;

	[Token(Token = "0x4017927")]
	[FieldOffset(Offset = "0x118")]
	public UILabel GoToBtnLabel;

	[Token(Token = "0x4017928")]
	[FieldOffset(Offset = "0x11C")]
	public UIButton EquipBtn;

	[Token(Token = "0x4017929")]
	[FieldOffset(Offset = "0x120")]
	public UILabel EquipBtnLabel;

	[Token(Token = "0x401792A")]
	[FieldOffset(Offset = "0x124")]
	public UIButton UnEquipBtn;

	[Token(Token = "0x401792B")]
	[FieldOffset(Offset = "0x128")]
	public UIButton btnRepay;

	[Token(Token = "0x401792C")]
	[FieldOffset(Offset = "0x12C")]
	public UITable TopRightBtns;

	[Token(Token = "0x401792D")]
	[FieldOffset(Offset = "0x130")]
	public UIButton GotoAvatarProfileBtn;

	[Token(Token = "0x401792E")]
	[FieldOffset(Offset = "0x134")]
	public UIButton FakeGuideButton;

	[Token(Token = "0x401792F")]
	[FieldOffset(Offset = "0x138")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016E2E")]
	[Address(RVA = "0x26CFA80", Offset = "0x26CFA80", VA = "0x26CFA80")]
	public UINewVaultView()
	{
	}

	[Token(Token = "0x6016E2F")]
	[Address(RVA = "0x26CFA88", Offset = "0x26CFA88", VA = "0x26CFA88", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E30")]
	[Address(RVA = "0x26D1490", Offset = "0x26D1490", VA = "0x26D1490")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
