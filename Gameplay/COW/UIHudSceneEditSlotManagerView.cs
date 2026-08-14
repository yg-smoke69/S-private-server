using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200373D")]
public class UIHudSceneEditSlotManagerView : UIBaseView
{
	[Token(Token = "0x4016545")]
	[FieldOffset(Offset = "0x14")]
	public GameObject SlotTypeBtns;

	[Token(Token = "0x4016546")]
	[FieldOffset(Offset = "0x18")]
	public GameObject EditSlotTab;

	[Token(Token = "0x4016547")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButton EditSlotToggleBtn;

	[Token(Token = "0x4016548")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ShareSlotTab;

	[Token(Token = "0x4016549")]
	[FieldOffset(Offset = "0x24")]
	public UIToggleButton ShareSlotToggleBtn;

	[Token(Token = "0x401654A")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SubscriptionSlotTab;

	[Token(Token = "0x401654B")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButton SubscriptionSlotToggleBtn;

	[Token(Token = "0x401654C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ClassicSlotTab;

	[Token(Token = "0x401654D")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButton ClassicSlotToggleBtn;

	[Token(Token = "0x401654E")]
	[FieldOffset(Offset = "0x38")]
	public GameObject TabBg;

	[Token(Token = "0x401654F")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton HelpBtn;

	[Token(Token = "0x4016550")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CloseBtn;

	[Token(Token = "0x4016551")]
	[FieldOffset(Offset = "0x44")]
	public GameObject LeftContainner;

	[Token(Token = "0x4016552")]
	[FieldOffset(Offset = "0x48")]
	public UIScrollView ItemScrollView;

	[Token(Token = "0x4016553")]
	[FieldOffset(Offset = "0x4C")]
	public UIEasyList GridEasyList;

	[Token(Token = "0x4016554")]
	[FieldOffset(Offset = "0x50")]
	public GameObject InfoPanel;

	[Token(Token = "0x4016555")]
	[FieldOffset(Offset = "0x54")]
	public UISceneEditSlotInfoView SlotInfoView;

	[Token(Token = "0x4016556")]
	[FieldOffset(Offset = "0x58")]
	public UILabel SlotNameTxt;

	[Token(Token = "0x4016557")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton BtnChangeSlotName;

	[Token(Token = "0x4016558")]
	[FieldOffset(Offset = "0x60")]
	public UIGrid InfoGrid;

	[Token(Token = "0x4016559")]
	[FieldOffset(Offset = "0x64")]
	public GameObject CodePanel;

	[Token(Token = "0x401655A")]
	[FieldOffset(Offset = "0x68")]
	public UILabel ShareCodeTxt;

	[Token(Token = "0x401655B")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton BtnCopy;

	[Token(Token = "0x401655C")]
	[FieldOffset(Offset = "0x70")]
	public UILabel SlotIntroTxt;

	[Token(Token = "0x401655D")]
	[FieldOffset(Offset = "0x74")]
	public UISprite InputSprite;

	[Token(Token = "0x401655E")]
	[FieldOffset(Offset = "0x78")]
	public UIInput InputField;

	[Token(Token = "0x401655F")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel SignatureLabel;

	[Token(Token = "0x4016560")]
	[FieldOffset(Offset = "0x80")]
	public GameObject EmptyPanel;

	[Token(Token = "0x4016561")]
	[FieldOffset(Offset = "0x84")]
	public UILabel MaskTips;

	[Token(Token = "0x4016562")]
	[FieldOffset(Offset = "0x88")]
	public UIButton TipsGoBtn;

	[Token(Token = "0x4016563")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject SubscribePanel;

	[Token(Token = "0x4016564")]
	[FieldOffset(Offset = "0x90")]
	public UIInput SearchInput;

	[Token(Token = "0x4016565")]
	[FieldOffset(Offset = "0x94")]
	public UIButton BtnClear;

	[Token(Token = "0x4016566")]
	[FieldOffset(Offset = "0x98")]
	public GameObject TipsPanel;

	[Token(Token = "0x4016567")]
	[FieldOffset(Offset = "0x9C")]
	public UILabel TipsTxt;

	[Token(Token = "0x4016568")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject EditBtns;

	[Token(Token = "0x4016569")]
	[FieldOffset(Offset = "0xA4")]
	public UITable EditBtnsTable;

	[Token(Token = "0x401656A")]
	[FieldOffset(Offset = "0xA8")]
	public UIButton BtnShare;

	[Token(Token = "0x401656B")]
	[FieldOffset(Offset = "0xAC")]
	public UIButton BtnApplyEdit;

	[Token(Token = "0x401656C")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton BtnUpload;

	[Token(Token = "0x401656D")]
	[FieldOffset(Offset = "0xB4")]
	public UIWidget UploadTutorial;

	[Token(Token = "0x401656E")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject ShareBtns;

	[Token(Token = "0x401656F")]
	[FieldOffset(Offset = "0xBC")]
	public UITable ShareBtnsTable;

	[Token(Token = "0x4016570")]
	[FieldOffset(Offset = "0xC0")]
	public UIButton BtnShareDel;

	[Token(Token = "0x4016571")]
	[FieldOffset(Offset = "0xC4")]
	public UIButton BtnApplyShare;

	[Token(Token = "0x4016572")]
	[FieldOffset(Offset = "0xC8")]
	public UIButton BtnShareUpdate;

	[Token(Token = "0x4016573")]
	[FieldOffset(Offset = "0xCC")]
	public UIButton BtnShareThis;

	[Token(Token = "0x4016574")]
	[FieldOffset(Offset = "0xD0")]
	public GameObject SubscriptionBtns;

	[Token(Token = "0x4016575")]
	[FieldOffset(Offset = "0xD4")]
	public UITable SubscriptionBtnsTable;

	[Token(Token = "0x4016576")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton BtnSubDel;

	[Token(Token = "0x4016577")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton BtnPreview;

	[Token(Token = "0x4016578")]
	[FieldOffset(Offset = "0xE0")]
	public UIButton BtnSearch;

	[Token(Token = "0x4016579")]
	[FieldOffset(Offset = "0xE4")]
	public GameObject LikeAndSubscribePanel;

	[Token(Token = "0x401657A")]
	[FieldOffset(Offset = "0xE8")]
	public GameObject EmptyMapPanel;

	[Token(Token = "0x401657B")]
	[FieldOffset(Offset = "0xEC")]
	public GameObject MapBanTipPanel;

	[Token(Token = "0x401657C")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel MapBanTipTxt;

	[Token(Token = "0x6016962")]
	[Address(RVA = "0x16B58D4", Offset = "0x16B58D4", VA = "0x16B58D4")]
	public UIHudSceneEditSlotManagerView()
	{
	}

	[Token(Token = "0x6016963")]
	[Address(RVA = "0x16B58DC", Offset = "0x16B58DC", VA = "0x16B58DC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016964")]
	[Address(RVA = "0x16B6E4C", Offset = "0x16B6E4C", VA = "0x16B6E4C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
