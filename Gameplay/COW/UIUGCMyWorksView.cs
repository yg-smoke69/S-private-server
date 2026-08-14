using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A40")]
public class UIUGCMyWorksView : UIBaseView
{
	[Token(Token = "0x401899E")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PopMenuGo;

	[Token(Token = "0x401899F")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView ScrollView;

	[Token(Token = "0x40189A0")]
	[FieldOffset(Offset = "0x1C")]
	public UIEasyList GridEasyList;

	[Token(Token = "0x40189A1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject InfoPanel;

	[Token(Token = "0x40189A2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EmptyPanel;

	[Token(Token = "0x40189A3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject TipsPanel;

	[Token(Token = "0x40189A4")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BtnCreateRoom;

	[Token(Token = "0x40189A5")]
	[FieldOffset(Offset = "0x30")]
	public UIButton BtnPublish;

	[Token(Token = "0x40189A6")]
	[FieldOffset(Offset = "0x34")]
	public UISprite IconPublish;

	[Token(Token = "0x40189A7")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnEdit;

	[Token(Token = "0x40189A8")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel SlotNameTxt;

	[Token(Token = "0x40189A9")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnChangeSlotName;

	[Token(Token = "0x40189AA")]
	[FieldOffset(Offset = "0x44")]
	public UILabel GameModeTxt;

	[Token(Token = "0x40189AB")]
	[FieldOffset(Offset = "0x48")]
	public UILabel UpdateTimeTxt;

	[Token(Token = "0x40189AC")]
	[FieldOffset(Offset = "0x4C")]
	public UIInput InputField;

	[Token(Token = "0x40189AD")]
	[FieldOffset(Offset = "0x50")]
	public UILabel SignatureLabel;

	[Token(Token = "0x40189AE")]
	[FieldOffset(Offset = "0x54")]
	public UILabel PublishStateTxt;

	[Token(Token = "0x40189AF")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LikeCountTxt;

	[Token(Token = "0x40189B0")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel SubscribeCountTxt;

	[Token(Token = "0x40189B1")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ShareCodeTxt;

	[Token(Token = "0x40189B2")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnCopy;

	[Token(Token = "0x40189B3")]
	[FieldOffset(Offset = "0x68")]
	public GameObject CodePanel;

	[Token(Token = "0x40189B4")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Btns;

	[Token(Token = "0x40189B5")]
	[FieldOffset(Offset = "0x70")]
	public UIButton BtnShare;

	[Token(Token = "0x40189B6")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnMore;

	[Token(Token = "0x40189B7")]
	[FieldOffset(Offset = "0x78")]
	public UILabel TipsTxt;

	[Token(Token = "0x40189B8")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel MaskTips;

	[Token(Token = "0x40189B9")]
	[FieldOffset(Offset = "0x80")]
	public GameObject SharePanel;

	[Token(Token = "0x40189BA")]
	[FieldOffset(Offset = "0x84")]
	public UIButton BtnSaveAs;

	[Token(Token = "0x40189BB")]
	[FieldOffset(Offset = "0x88")]
	public UILabel BtnSaveAsTxt;

	[Token(Token = "0x40189BC")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton BtnDetail;

	[Token(Token = "0x40189BD")]
	[FieldOffset(Offset = "0x90")]
	public UILabel BtnDetailTxt;

	[Token(Token = "0x40189BE")]
	[FieldOffset(Offset = "0x94")]
	public UIButton BtnUnpublish;

	[Token(Token = "0x40189BF")]
	[FieldOffset(Offset = "0x98")]
	public UILabel BtnUnpublishTxt;

	[Token(Token = "0x40189C0")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton BtnDel;

	[Token(Token = "0x40189C1")]
	[FieldOffset(Offset = "0xA0")]
	public UILabel BtnDelTxt;

	[Token(Token = "0x40189C2")]
	[FieldOffset(Offset = "0xA4")]
	public UIButton BtnNew;

	[Token(Token = "0x40189C3")]
	[FieldOffset(Offset = "0xA8")]
	public UITable DropBtnsTable;

	[Token(Token = "0x40189C4")]
	[FieldOffset(Offset = "0xAC")]
	public UISprite BtnShareIcon;

	[Token(Token = "0x40189C5")]
	[FieldOffset(Offset = "0xB0")]
	public UILabel BtnPublishTxt;

	[Token(Token = "0x40189C6")]
	[FieldOffset(Offset = "0xB4")]
	public GameObject SepLine;

	[Token(Token = "0x40189C7")]
	[FieldOffset(Offset = "0xB8")]
	public GameObject DropBtnsGo;

	[Token(Token = "0x40189C8")]
	[FieldOffset(Offset = "0xBC")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x40189C9")]
	[FieldOffset(Offset = "0xC0")]
	public UISprite TipsBg;

	[Token(Token = "0x40189CA")]
	[FieldOffset(Offset = "0xC4")]
	public UISprite TipsIcon;

	[Token(Token = "0x40189CB")]
	[FieldOffset(Offset = "0xC8")]
	public UISprite NameInputSprite;

	[Token(Token = "0x40189CC")]
	[FieldOffset(Offset = "0xCC")]
	public UISprite IntroInputSprite;

	[Token(Token = "0x6017266")]
	[Address(RVA = "0x278C7FC", Offset = "0x278C7FC", VA = "0x278C7FC")]
	public UIUGCMyWorksView()
	{
	}

	[Token(Token = "0x6017267")]
	[Address(RVA = "0x278C804", Offset = "0x278C804", VA = "0x278C804", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017268")]
	[Address(RVA = "0x278DA80", Offset = "0x278DA80", VA = "0x278DA80")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
