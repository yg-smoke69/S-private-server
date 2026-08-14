using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200386C")]
public class UIMallDetailView : UIBaseView
{
	[Token(Token = "0x40172C0")]
	[FieldOffset(Offset = "0x14")]
	public Animation Animation;

	[Token(Token = "0x40172C1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject GiftRank;

	[Token(Token = "0x40172C2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GiftRankName;

	[Token(Token = "0x40172C3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite GiftRankIcon;

	[Token(Token = "0x40172C4")]
	[FieldOffset(Offset = "0x24")]
	public UIButton GiftRankBtn;

	[Token(Token = "0x40172C5")]
	[FieldOffset(Offset = "0x28")]
	public GameObject GiftRankEffect;

	[Token(Token = "0x40172C6")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RecommendBuyBtn;

	[Token(Token = "0x40172C7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject GiftReceive;

	[Token(Token = "0x40172C8")]
	[FieldOffset(Offset = "0x34")]
	public UILabel ReceiveNum;

	[Token(Token = "0x40172C9")]
	[FieldOffset(Offset = "0x38")]
	public UISprite ReceiveIcon;

	[Token(Token = "0x40172CA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject GiftSend;

	[Token(Token = "0x40172CB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel SendNum;

	[Token(Token = "0x40172CC")]
	[FieldOffset(Offset = "0x44")]
	public UISprite SendIcon;

	[Token(Token = "0x40172CD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject BtnGroupContainer;

	[Token(Token = "0x40172CE")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton BuyBtn;

	[Token(Token = "0x40172CF")]
	[FieldOffset(Offset = "0x50")]
	public UISprite BuyBtnBG;

	[Token(Token = "0x40172D0")]
	[FieldOffset(Offset = "0x54")]
	public UISprite BuyIcon;

	[Token(Token = "0x40172D1")]
	[FieldOffset(Offset = "0x58")]
	public UILabel BuyBtnLabel;

	[Token(Token = "0x40172D2")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel LabelLimitedCount;

	[Token(Token = "0x40172D3")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BuyVoucher;

	[Token(Token = "0x40172D4")]
	[FieldOffset(Offset = "0x64")]
	public UISprite BuyVoucherIcon;

	[Token(Token = "0x40172D5")]
	[FieldOffset(Offset = "0x68")]
	public UILabel BuyVoucherLabel;

	[Token(Token = "0x40172D6")]
	[FieldOffset(Offset = "0x6C")]
	public UIGrid BuyVoucherGrid;

	[Token(Token = "0x40172D7")]
	[FieldOffset(Offset = "0x70")]
	public UISprite GoldIcon;

	[Token(Token = "0x40172D8")]
	[FieldOffset(Offset = "0x74")]
	public UISprite GemsIcon;

	[Token(Token = "0x40172D9")]
	[FieldOffset(Offset = "0x78")]
	public UIButton InstallmentTutorialBtn;

	[Token(Token = "0x40172DA")]
	[FieldOffset(Offset = "0x7C")]
	public UIButton BtnGoExchange;

	[Token(Token = "0x40172DB")]
	[FieldOffset(Offset = "0x80")]
	public UILabel LabeGoExchange;

	[Token(Token = "0x40172DC")]
	[FieldOffset(Offset = "0x84")]
	public UISprite IconGoExchange;

	[Token(Token = "0x40172DD")]
	[FieldOffset(Offset = "0x88")]
	public Transform MallPanelContainer;

	[Token(Token = "0x40172DE")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject MainToggles;

	[Token(Token = "0x40172DF")]
	[FieldOffset(Offset = "0x90")]
	public UIScrollView MainToggleScrollView;

	[Token(Token = "0x40172E0")]
	[FieldOffset(Offset = "0x94")]
	public UIToggleButton mallToggle;

	[Token(Token = "0x40172E1")]
	[FieldOffset(Offset = "0x98")]
	public UIToggleButton petToggle;

	[Token(Token = "0x40172E2")]
	[FieldOffset(Offset = "0x9C")]
	public UIGrid MainToggleGrid;

	[Token(Token = "0x40172E3")]
	[FieldOffset(Offset = "0xA0")]
	public UIToggleButtonGroup MainToggleGroup;

	[Token(Token = "0x40172E4")]
	[FieldOffset(Offset = "0xA4")]
	public UIToggleButton InstallmentToggle;

	[Token(Token = "0x40172E5")]
	[FieldOffset(Offset = "0xA8")]
	public UIToggleButton discountToggle;

	[Token(Token = "0x40172E6")]
	[FieldOffset(Offset = "0xAC")]
	public UIScrollView NormalMallTabScrollView;

	[Token(Token = "0x40172E7")]
	[FieldOffset(Offset = "0xB0")]
	public UIGrid NormalMallTabGrid;

	[Token(Token = "0x40172E8")]
	[FieldOffset(Offset = "0xB4")]
	public UIToggleButtonGroup NormalMallTabGroup;

	[Token(Token = "0x40172E9")]
	[FieldOffset(Offset = "0xB8")]
	public Animation DiscountAnim;

	[Token(Token = "0x40172EA")]
	[FieldOffset(Offset = "0xBC")]
	public UILabel MaxOff;

	[Token(Token = "0x40172EB")]
	[FieldOffset(Offset = "0xC0")]
	public UIWidget CountDownContainer;

	[Token(Token = "0x40172EC")]
	[FieldOffset(Offset = "0xC4")]
	public Transform DiscountContainer;

	[Token(Token = "0x40172ED")]
	[FieldOffset(Offset = "0xC8")]
	public GameObject SubToggles;

	[Token(Token = "0x40172EE")]
	[FieldOffset(Offset = "0xCC")]
	public UIScrollView SubToggleScrollView;

	[Token(Token = "0x40172EF")]
	[FieldOffset(Offset = "0xD0")]
	public UIToggleButton subToggle;

	[Token(Token = "0x40172F0")]
	[FieldOffset(Offset = "0xD4")]
	public UIGrid SubToggleGrid;

	[Token(Token = "0x40172F1")]
	[FieldOffset(Offset = "0xD8")]
	public UIToggleButtonGroup SubToggleGroup;

	[Token(Token = "0x40172F2")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject side_BG;

	[Token(Token = "0x40172F3")]
	[FieldOffset(Offset = "0xE0")]
	public UIScrollView MallScrollView;

	[Token(Token = "0x40172F4")]
	[FieldOffset(Offset = "0xE4")]
	public UIEasyList Grid;

	[Token(Token = "0x40172F5")]
	[FieldOffset(Offset = "0xE8")]
	public UIScrollView MallBoxItemScrollView;

	[Token(Token = "0x40172F6")]
	[FieldOffset(Offset = "0xEC")]
	public UIEasyList BoxItemGrid;

	[Token(Token = "0x40172F7")]
	[FieldOffset(Offset = "0xF0")]
	public UIScrollView MallWeaponItemScrollView;

	[Token(Token = "0x40172F8")]
	[FieldOffset(Offset = "0xF4")]
	public UIEasyList WeaponItemGrid;

	[Token(Token = "0x40172F9")]
	[FieldOffset(Offset = "0xF8")]
	public UIScrollView MallCrystalItemScrollView;

	[Token(Token = "0x40172FA")]
	[FieldOffset(Offset = "0xFC")]
	public UIEasyList CrystalItemGrid;

	[Token(Token = "0x40172FB")]
	[FieldOffset(Offset = "0x100")]
	public UIScrollView MallDiscountScrollView;

	[Token(Token = "0x40172FC")]
	[FieldOffset(Offset = "0x104")]
	public UIEasyList DiscountItemGrid;

	[Token(Token = "0x40172FD")]
	[FieldOffset(Offset = "0x108")]
	public GameObject AdsPanel;

	[Token(Token = "0x40172FE")]
	[FieldOffset(Offset = "0x10C")]
	public UIScrollView ADScrollView;

	[Token(Token = "0x40172FF")]
	[FieldOffset(Offset = "0x110")]
	public UIWrapContent AdsContent;

	[Token(Token = "0x4017300")]
	[FieldOffset(Offset = "0x114")]
	public GameObject ADEffect;

	[Token(Token = "0x4017301")]
	[FieldOffset(Offset = "0x118")]
	public Transform CarouselContainer;

	[Token(Token = "0x4017302")]
	[FieldOffset(Offset = "0x11C")]
	public UIPanel CarouselPanel;

	[Token(Token = "0x4017303")]
	[FieldOffset(Offset = "0x120")]
	public Transform GiftContainer;

	[Token(Token = "0x4017304")]
	[FieldOffset(Offset = "0x124")]
	public GameObject NoItemTips;

	[Token(Token = "0x4017305")]
	[FieldOffset(Offset = "0x128")]
	public GameObject GenderSelectionContainer;

	[Token(Token = "0x4017306")]
	[FieldOffset(Offset = "0x12C")]
	public UIToggleButton AllClothToggle;

	[Token(Token = "0x4017307")]
	[FieldOffset(Offset = "0x130")]
	public UIToggleButton CommonClothToggle;

	[Token(Token = "0x4017308")]
	[FieldOffset(Offset = "0x134")]
	public UIToggleButton MaleClothToggle;

	[Token(Token = "0x4017309")]
	[FieldOffset(Offset = "0x138")]
	public UIToggleButton FemaleClothToggle;

	[Token(Token = "0x401730A")]
	[FieldOffset(Offset = "0x13C")]
	public UIWidget WeaponTypeFilter;

	[Token(Token = "0x401730B")]
	[FieldOffset(Offset = "0x140")]
	public UIWidget WeaponModelFilter;

	[Token(Token = "0x401730C")]
	[FieldOffset(Offset = "0x144")]
	public UICountDownLabel LeftTime;

	[Token(Token = "0x401730D")]
	[FieldOffset(Offset = "0x148")]
	public GameObject WeaponMallEffect;

	[Token(Token = "0x401730E")]
	[FieldOffset(Offset = "0x14C")]
	public UIToggleButtonGroup SwitchClothPreviewBtnGroup;

	[Token(Token = "0x401730F")]
	[FieldOffset(Offset = "0x150")]
	public UIToggleButton SwitchClothMaleBtn;

	[Token(Token = "0x4017310")]
	[FieldOffset(Offset = "0x154")]
	public UIToggleButton SwitchClotFemaleBtn;

	[Token(Token = "0x4017311")]
	[FieldOffset(Offset = "0x158")]
	public GameObject ClothPreviewTab;

	[Token(Token = "0x4017312")]
	[FieldOffset(Offset = "0x15C")]
	public UIToggleButtonGroup ClothPreviewBtGroup;

	[Token(Token = "0x4017313")]
	[FieldOffset(Offset = "0x160")]
	public UIToggleButton previewHair;

	[Token(Token = "0x4017314")]
	[FieldOffset(Offset = "0x164")]
	public UIToggleButton previewFace;

	[Token(Token = "0x4017315")]
	[FieldOffset(Offset = "0x168")]
	public UIToggleButton previewHeadAdditive;

	[Token(Token = "0x4017316")]
	[FieldOffset(Offset = "0x16C")]
	public UIToggleButton previewChest;

	[Token(Token = "0x4017317")]
	[FieldOffset(Offset = "0x170")]
	public UIToggleButton previewlegs;

	[Token(Token = "0x4017318")]
	[FieldOffset(Offset = "0x174")]
	public UIToggleButton previewFeet;

	[Token(Token = "0x4017319")]
	[FieldOffset(Offset = "0x178")]
	public UIToggleButton previewClothesSet;

	[Token(Token = "0x401731A")]
	[FieldOffset(Offset = "0x17C")]
	public GameObject RecommendContainer;

	[Token(Token = "0x401731B")]
	[FieldOffset(Offset = "0x180")]
	public UIScrollView RecommendScrollView;

	[Token(Token = "0x401731C")]
	[FieldOffset(Offset = "0x184")]
	public UIEasyList RecommendGrid;

	[Token(Token = "0x401731D")]
	[FieldOffset(Offset = "0x188")]
	public GameObject RecommendTitle;

	[Token(Token = "0x401731E")]
	[FieldOffset(Offset = "0x18C")]
	public UIButton HyperBookCheckBtn;

	[Token(Token = "0x6016CEF")]
	[Address(RVA = "0x23B49DC", Offset = "0x23B49DC", VA = "0x23B49DC")]
	public UIMallDetailView()
	{
	}

	[Token(Token = "0x6016CF0")]
	[Address(RVA = "0x23B49E4", Offset = "0x23B49E4", VA = "0x23B49E4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CF1")]
	[Address(RVA = "0x23B6D64", Offset = "0x23B6D64", VA = "0x23B6D64")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
