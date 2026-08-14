using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003821")]
public class UILegendClothVaultView : UIBaseView
{
	[Token(Token = "0x4016DB3")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LabelName;

	[Token(Token = "0x4016DB4")]
	[FieldOffset(Offset = "0x18")]
	public GameObject TagPanel;

	[Token(Token = "0x4016DB5")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid GridTagAll;

	[Token(Token = "0x4016DB6")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteIpTag;

	[Token(Token = "0x4016DB7")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelIPName;

	[Token(Token = "0x4016DB8")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid GridTagOthers;

	[Token(Token = "0x4016DB9")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ColorSwitchPanel;

	[Token(Token = "0x4016DBA")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnColorPanel;

	[Token(Token = "0x4016DBB")]
	[FieldOffset(Offset = "0x34")]
	public GameObject GoRedDot;

	[Token(Token = "0x4016DBC")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelColorPanelTitle;

	[Token(Token = "0x4016DBD")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel LabelColorPanelDesc;

	[Token(Token = "0x4016DBE")]
	[FieldOffset(Offset = "0x40")]
	public GameObject FeaturePanel;

	[Token(Token = "0x4016DBF")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelFeatureTitle;

	[Token(Token = "0x4016DC0")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LabelFeatureTip;

	[Token(Token = "0x4016DC1")]
	[FieldOffset(Offset = "0x4C")]
	public UIScrollView FeatureScrollView;

	[Token(Token = "0x4016DC2")]
	[FieldOffset(Offset = "0x50")]
	public UIGrid GridProperty;

	[Token(Token = "0x4016DC3")]
	[FieldOffset(Offset = "0x54")]
	public UIButton BtnHideColorPanel;

	[Token(Token = "0x4016DC4")]
	[FieldOffset(Offset = "0x58")]
	public GameObject ConfirmPanel;

	[Token(Token = "0x4016DC5")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnConfirm;

	[Token(Token = "0x4016DC6")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LabelConfirmTip;

	[Token(Token = "0x4016DC7")]
	[FieldOffset(Offset = "0x64")]
	public GameObject GoBtnConfirmEnable;

	[Token(Token = "0x4016DC8")]
	[FieldOffset(Offset = "0x68")]
	public GameObject GoBtnConfirmDisable;

	[Token(Token = "0x4016DC9")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject StoryPanel;

	[Token(Token = "0x4016DCA")]
	[FieldOffset(Offset = "0x70")]
	public UILabel LabelStoryTitle;

	[Token(Token = "0x4016DCB")]
	[FieldOffset(Offset = "0x74")]
	public UIPanel PanelStoryDesc;

	[Token(Token = "0x4016DCC")]
	[FieldOffset(Offset = "0x78")]
	public UIScrollView ScrollViewStoryDesc;

	[Token(Token = "0x4016DCD")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel LabelStoryDesc_unfold;

	[Token(Token = "0x4016DCE")]
	[FieldOffset(Offset = "0x80")]
	public UIDragScrollView DragScrollViewLabelStoryDesc;

	[Token(Token = "0x4016DCF")]
	[FieldOffset(Offset = "0x84")]
	public UIButton BtnFoldStory;

	[Token(Token = "0x4016DD0")]
	[FieldOffset(Offset = "0x88")]
	public UIButton BtnUnFoldStory;

	[Token(Token = "0x4016DD1")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject ColorPanel;

	[Token(Token = "0x4016DD2")]
	[FieldOffset(Offset = "0x90")]
	public GameObject GoColorPanelUnlockRank;

	[Token(Token = "0x4016DD3")]
	[FieldOffset(Offset = "0x94")]
	public UISprite SpriteColorLadderLevelBR;

	[Token(Token = "0x4016DD4")]
	[FieldOffset(Offset = "0x98")]
	public UISprite SpriteColorLadderLevelCS;

	[Token(Token = "0x4016DD5")]
	[FieldOffset(Offset = "0x9C")]
	public UISprite SpriteColorLadderLevelColor;

	[Token(Token = "0x4016DD6")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel LabelColorPanelComponentsTitle;

	[Token(Token = "0x4016DD7")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton BtnColorPanelComponentHair;

	[Token(Token = "0x4016DD8")]
	[FieldOffset(Offset = "0xA8")]
	public UISprite SpriteColorPanelComponentBgHair;

	[Token(Token = "0x4016DD9")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite SpriteColorPanelComponentHair;

	[Token(Token = "0x4016DDA")]
	[FieldOffset(Offset = "0xB0")]
	public GameObject GoColorPanelPickingHair;

	[Token(Token = "0x4016DDB")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject GoColorPanelUnPickingHair;

	[Token(Token = "0x4016DDC")]
	[FieldOffset(Offset = "0xB8")]
	public UISprite SpriteColorPanelCurrentColorHair;

	[Token(Token = "0x4016DDD")]
	[FieldOffset(Offset = "0xBC")]
	public UIButton BtnColorPanelComponentFace;

	[Token(Token = "0x4016DDE")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject GoColorPanelPickingFace;

	[Token(Token = "0x4016DDF")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject GoColorPanelUnPickingFace;

	[Token(Token = "0x4016DE0")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite SpriteColorPanelComponentBgFace;

	[Token(Token = "0x4016DE1")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite SpriteColorPanelComponentFace;

	[Token(Token = "0x4016DE2")]
	[FieldOffset(Offset = "0xD0")]
	public UISprite SpriteColorPanelCurrentColorFace;

	[Token(Token = "0x4016DE3")]
	[FieldOffset(Offset = "0xD4")]
	public UIButton BtnColorPanelComponentHeadAdditive;

	[Token(Token = "0x4016DE4")]
	[FieldOffset(Offset = "0xD8")]
	public UISprite SpriteColorPanelCurrentColorHeadAdditive;

	[Token(Token = "0x4016DE5")]
	[FieldOffset(Offset = "0xDC")]
	public GameObject GoColorPanelPickingHeadAdditive;

	[Token(Token = "0x4016DE6")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject GoColorPanelUnPickingHeadAdditive;

	[Token(Token = "0x4016DE7")]
	[FieldOffset(Offset = "0xE4")]
	public UISprite SpriteColorPanelComponentBgHeadAdditive;

	[Token(Token = "0x4016DE8")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite SpriteColorPanelComponentHeadAdditive;

	[Token(Token = "0x4016DE9")]
	[FieldOffset(Offset = "0xEC")]
	public UIButton BtnColorPanelComponentChest;

	[Token(Token = "0x4016DEA")]
	[FieldOffset(Offset = "0xF0")]
	public UISprite SpriteColorPanelCurrentColorChest;

	[Token(Token = "0x4016DEB")]
	[FieldOffset(Offset = "0xF4")]
	public GameObject GoColorPanelPickingChest;

	[Token(Token = "0x4016DEC")]
	[FieldOffset(Offset = "0xF8")]
	public GameObject GoColorPanelUnPickingChest;

	[Token(Token = "0x4016DED")]
	[FieldOffset(Offset = "0xFC")]
	public UISprite SpriteColorPanelComponentBgChest;

	[Token(Token = "0x4016DEE")]
	[FieldOffset(Offset = "0x100")]
	public UISprite SpriteColorPanelComponentChest;

	[Token(Token = "0x4016DEF")]
	[FieldOffset(Offset = "0x104")]
	public UIButton BtnColorPanelComponentLegs;

	[Token(Token = "0x4016DF0")]
	[FieldOffset(Offset = "0x108")]
	public UISprite SpriteColorPanelCurrentColorLegs;

	[Token(Token = "0x4016DF1")]
	[FieldOffset(Offset = "0x10C")]
	public GameObject GoColorPanelPickingLegs;

	[Token(Token = "0x4016DF2")]
	[FieldOffset(Offset = "0x110")]
	public GameObject GoColorPanelUnPickingLegs;

	[Token(Token = "0x4016DF3")]
	[FieldOffset(Offset = "0x114")]
	public UISprite SpriteColorPanelComponentBgLegs;

	[Token(Token = "0x4016DF4")]
	[FieldOffset(Offset = "0x118")]
	public UISprite SpriteColorPanelComponentLegs;

	[Token(Token = "0x4016DF5")]
	[FieldOffset(Offset = "0x11C")]
	public UIButton BtnColorPanelComponentFeet;

	[Token(Token = "0x4016DF6")]
	[FieldOffset(Offset = "0x120")]
	public UISprite SpriteColorPanelCurrentColorFeet;

	[Token(Token = "0x4016DF7")]
	[FieldOffset(Offset = "0x124")]
	public GameObject GoColorPanelPickingFeet;

	[Token(Token = "0x4016DF8")]
	[FieldOffset(Offset = "0x128")]
	public GameObject GoColorPanelUnPickingFeet;

	[Token(Token = "0x4016DF9")]
	[FieldOffset(Offset = "0x12C")]
	public UISprite SpriteColorPanelComponentBgFeet;

	[Token(Token = "0x4016DFA")]
	[FieldOffset(Offset = "0x130")]
	public UISprite SpriteColorPanelComponentFeet;

	[Token(Token = "0x4016DFB")]
	[FieldOffset(Offset = "0x134")]
	public UIButton BtnColorPanelComponentsAll;

	[Token(Token = "0x4016DFC")]
	[FieldOffset(Offset = "0x138")]
	public UISprite SpriteColorPanelCurrentColorAll;

	[Token(Token = "0x4016DFD")]
	[FieldOffset(Offset = "0x13C")]
	public GameObject GoColorPanelPickingAll;

	[Token(Token = "0x4016DFE")]
	[FieldOffset(Offset = "0x140")]
	public GameObject GoColorPanelUnPickingAll;

	[Token(Token = "0x4016DFF")]
	[FieldOffset(Offset = "0x144")]
	public UISprite SpriteColorPanelComponentBgAll;

	[Token(Token = "0x4016E00")]
	[FieldOffset(Offset = "0x148")]
	public UISprite SpriteColorPanelComponentsAll;

	[Token(Token = "0x4016E01")]
	[FieldOffset(Offset = "0x14C")]
	public UISprite SpriteColorPanelCurrentColorAllSplitColor;

	[Token(Token = "0x4016E02")]
	[FieldOffset(Offset = "0x150")]
	public UILabel LabelColorPickTitle;

	[Token(Token = "0x4016E03")]
	[FieldOffset(Offset = "0x154")]
	public UIGrid GridColor;

	[Token(Token = "0x4016E04")]
	[FieldOffset(Offset = "0x158")]
	public UIButton BtnPurchase;

	[Token(Token = "0x4016E05")]
	[FieldOffset(Offset = "0x15C")]
	public GameObject ClothSlotPanel;

	[Token(Token = "0x4016E06")]
	[FieldOffset(Offset = "0x160")]
	public UILabel LabelGenderNotMatchTip;

	[Token(Token = "0x4016E07")]
	[FieldOffset(Offset = "0x164")]
	public UIButton BtnGotoAvatarProfile;

	[Token(Token = "0x4016E08")]
	[FieldOffset(Offset = "0x168")]
	public GameObject GoSlotHair;

	[Token(Token = "0x4016E09")]
	[FieldOffset(Offset = "0x16C")]
	public GameObject GoSlotFace;

	[Token(Token = "0x4016E0A")]
	[FieldOffset(Offset = "0x170")]
	public GameObject GoSlotChest;

	[Token(Token = "0x4016E0B")]
	[FieldOffset(Offset = "0x174")]
	public GameObject GoSlotLegs;

	[Token(Token = "0x4016E0C")]
	[FieldOffset(Offset = "0x178")]
	public GameObject GoSlotFeet;

	[Token(Token = "0x4016E0D")]
	[FieldOffset(Offset = "0x17C")]
	public GameObject GoSlotHeadAdditive;

	[Token(Token = "0x6016C0E")]
	[Address(RVA = "0x2542E8C", Offset = "0x2542E8C", VA = "0x2542E8C")]
	public UILegendClothVaultView()
	{
	}

	[Token(Token = "0x6016C0F")]
	[Address(RVA = "0x2542E94", Offset = "0x2542E94", VA = "0x2542E94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C10")]
	[Address(RVA = "0x2545088", Offset = "0x2545088", VA = "0x2545088")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
