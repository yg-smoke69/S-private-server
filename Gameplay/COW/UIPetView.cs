using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003909")]
public class UIPetView : UIBaseView
{
	[Token(Token = "0x4017B64")]
	[FieldOffset(Offset = "0x14")]
	public UITexture BG;

	[Token(Token = "0x4017B65")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CenterContainer;

	[Token(Token = "0x4017B66")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject PetPanelContainer;

	[Token(Token = "0x4017B67")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PetListTitle;

	[Token(Token = "0x4017B68")]
	[FieldOffset(Offset = "0x24")]
	public UIEasyList PetGrid;

	[Token(Token = "0x4017B69")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PetInfoContainer;

	[Token(Token = "0x4017B6A")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject PetNameTitle;

	[Token(Token = "0x4017B6B")]
	[FieldOffset(Offset = "0x30")]
	public UILabel PetNameLabel;

	[Token(Token = "0x4017B6C")]
	[FieldOffset(Offset = "0x34")]
	public UIButton RenameBtn;

	[Token(Token = "0x4017B6D")]
	[FieldOffset(Offset = "0x38")]
	public GameObject PetLevelLabelGroup;

	[Token(Token = "0x4017B6E")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel Txt_Lv;

	[Token(Token = "0x4017B6F")]
	[FieldOffset(Offset = "0x40")]
	public UILabel exp_label;

	[Token(Token = "0x4017B70")]
	[FieldOffset(Offset = "0x44")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4017B71")]
	[FieldOffset(Offset = "0x48")]
	public GameObject PetScrollView;

	[Token(Token = "0x4017B72")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject IOSPreviewShowLabel;

	[Token(Token = "0x4017B73")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ActionTitleBtn;

	[Token(Token = "0x4017B74")]
	[FieldOffset(Offset = "0x54")]
	public GameObject HLBg_Action;

	[Token(Token = "0x4017B75")]
	[FieldOffset(Offset = "0x58")]
	public UILabel ActionTitle;

	[Token(Token = "0x4017B76")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ActionNewTips;

	[Token(Token = "0x4017B77")]
	[FieldOffset(Offset = "0x60")]
	public UIButton SkinTitleBtn;

	[Token(Token = "0x4017B78")]
	[FieldOffset(Offset = "0x64")]
	public GameObject HLBg_Skin;

	[Token(Token = "0x4017B79")]
	[FieldOffset(Offset = "0x68")]
	public UILabel SkinTitle;

	[Token(Token = "0x4017B7A")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject SkinNewTips;

	[Token(Token = "0x4017B7B")]
	[FieldOffset(Offset = "0x70")]
	public UIButton SkillTitleBtn;

	[Token(Token = "0x4017B7C")]
	[FieldOffset(Offset = "0x74")]
	public GameObject SelectSkillGuide;

	[Token(Token = "0x4017B7D")]
	[FieldOffset(Offset = "0x78")]
	public GameObject Effect_Circle;

	[Token(Token = "0x4017B7E")]
	[FieldOffset(Offset = "0x7C")]
	public GameObject HLBg_Skill;

	[Token(Token = "0x4017B7F")]
	[FieldOffset(Offset = "0x80")]
	public UILabel SkillTitle;

	[Token(Token = "0x4017B80")]
	[FieldOffset(Offset = "0x84")]
	public GameObject SkillNewTips;

	[Token(Token = "0x4017B81")]
	[FieldOffset(Offset = "0x88")]
	public GameObject Rightdownbtn;

	[Token(Token = "0x4017B82")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton PetActBtn;

	[Token(Token = "0x4017B83")]
	[FieldOffset(Offset = "0x90")]
	public UILabel ActionBtn_label;

	[Token(Token = "0x4017B84")]
	[FieldOffset(Offset = "0x94")]
	public UIButton PetShareBtn;

	[Token(Token = "0x4017B85")]
	[FieldOffset(Offset = "0x98")]
	public UILabel ShareBtn_label;

	[Token(Token = "0x4017B86")]
	[FieldOffset(Offset = "0x9C")]
	public GameObject PetFeedContainer;

	[Token(Token = "0x4017B87")]
	[FieldOffset(Offset = "0xA0")]
	public UIButton FeedLevelUpBtn;

	[Token(Token = "0x4017B88")]
	[FieldOffset(Offset = "0xA4")]
	public UIWidget LevelUpWidget;

	[Token(Token = "0x4017B89")]
	[FieldOffset(Offset = "0xA8")]
	public UILabel FeedOneBtn_label;

	[Token(Token = "0x4017B8A")]
	[FieldOffset(Offset = "0xAC")]
	public GameObject LevelUpVFX;

	[Token(Token = "0x4017B8B")]
	[FieldOffset(Offset = "0xB0")]
	public UIButton FeedBuyBtn;

	[Token(Token = "0x4017B8C")]
	[FieldOffset(Offset = "0xB4")]
	public UISprite FeedShowIcon;

	[Token(Token = "0x4017B8D")]
	[FieldOffset(Offset = "0xB8")]
	public UILabel FeedShowTxt;

	[Token(Token = "0x4017B8E")]
	[FieldOffset(Offset = "0xBC")]
	public GameObject GrownUpGo;

	[Token(Token = "0x4017B8F")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject ItemInfoShowContainer;

	[Token(Token = "0x4017B90")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite PetNameInfoIcon;

	[Token(Token = "0x4017B91")]
	[FieldOffset(Offset = "0xC8")]
	public UILabel ItemInfoName;

	[Token(Token = "0x4017B92")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite IPTag;

	[Token(Token = "0x4017B93")]
	[FieldOffset(Offset = "0xD0")]
	public UILabel ItemInfoUnlockDesc;

	[Token(Token = "0x4017B94")]
	[FieldOffset(Offset = "0xD4")]
	public UILabel ItemInfoDesc;

	[Token(Token = "0x4017B95")]
	[FieldOffset(Offset = "0xD8")]
	public UIButton ShowPetBtn;

	[Token(Token = "0x4017B96")]
	[FieldOffset(Offset = "0xDC")]
	public UIButton GotoShopBtn;

	[Token(Token = "0x4017B97")]
	[FieldOffset(Offset = "0xE0")]
	public GameObject ShareUI;

	[Token(Token = "0x4017B98")]
	[FieldOffset(Offset = "0xE4")]
	public UINetworkTexture HeadIcon;

	[Token(Token = "0x4017B99")]
	[FieldOffset(Offset = "0xE8")]
	public UISprite HeadIconLocal;

	[Token(Token = "0x4017B9A")]
	[FieldOffset(Offset = "0xEC")]
	public UILabel NikcName;

	[Token(Token = "0x4017B9B")]
	[FieldOffset(Offset = "0xF0")]
	public UILabel ID;

	[Token(Token = "0x4017B9C")]
	[FieldOffset(Offset = "0xF4")]
	public UISprite FreeFireLogo;

	[Token(Token = "0x4017B9D")]
	[FieldOffset(Offset = "0xF8")]
	public Transform leftside;

	[Token(Token = "0x4017B9E")]
	[FieldOffset(Offset = "0xFC")]
	public Transform rightside;

	[Token(Token = "0x4017B9F")]
	[FieldOffset(Offset = "0x100")]
	public UIWidget midPos;

	[Token(Token = "0x4017BA0")]
	[FieldOffset(Offset = "0x104")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016EC4")]
	[Address(RVA = "0x2C51468", Offset = "0x2C51468", VA = "0x2C51468")]
	public UIPetView()
	{
	}

	[Token(Token = "0x6016EC5")]
	[Address(RVA = "0x2C51470", Offset = "0x2C51470", VA = "0x2C51470", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016EC6")]
	[Address(RVA = "0x2C52B40", Offset = "0x2C52B40", VA = "0x2C52B40")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
