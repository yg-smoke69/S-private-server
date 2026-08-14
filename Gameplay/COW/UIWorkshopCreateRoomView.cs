using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A86")]
public class UIWorkshopCreateRoomView : UIBaseView
{
	[Token(Token = "0x4018E19")]
	[FieldOffset(Offset = "0x14")]
	public GameObject RoomGameSettingBtnGo;

	[Token(Token = "0x4018E1A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4018E1B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject RoomCardGo;

	[Token(Token = "0x4018E1C")]
	[FieldOffset(Offset = "0x20")]
	public GameObject InfoPanel;

	[Token(Token = "0x4018E1D")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget RoomSettingPanel;

	[Token(Token = "0x4018E1E")]
	[FieldOffset(Offset = "0x28")]
	public UIInput NameInput;

	[Token(Token = "0x4018E1F")]
	[FieldOffset(Offset = "0x2C")]
	public UIInput CodeInput;

	[Token(Token = "0x4018E20")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget WorkShopPopMenu;

	[Token(Token = "0x4018E21")]
	[FieldOffset(Offset = "0x34")]
	public UIEasyList GridEasyList;

	[Token(Token = "0x4018E22")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RefreshBtn;

	[Token(Token = "0x4018E23")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject SpriteRefresh;

	[Token(Token = "0x4018E24")]
	[FieldOffset(Offset = "0x40")]
	public UILabel UILabelRefreshTxt;

	[Token(Token = "0x4018E25")]
	[FieldOffset(Offset = "0x44")]
	public UICountDownLabel UICountDownLabelRefreshTxt;

	[Token(Token = "0x4018E26")]
	[FieldOffset(Offset = "0x48")]
	public GameObject EmptyBg;

	[Token(Token = "0x4018E27")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject EmptyNode;

	[Token(Token = "0x4018E28")]
	[FieldOffset(Offset = "0x50")]
	public GameObject InfoNode;

	[Token(Token = "0x4018E29")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget MapContainer;

	[Token(Token = "0x4018E2A")]
	[FieldOffset(Offset = "0x58")]
	public UISprite MapWidget;

	[Token(Token = "0x4018E2B")]
	[FieldOffset(Offset = "0x5C")]
	public UIPanel MapExtarInfo;

	[Token(Token = "0x4018E2C")]
	[FieldOffset(Offset = "0x60")]
	public UILabel LabelWorkshopName;

	[Token(Token = "0x4018E2D")]
	[FieldOffset(Offset = "0x64")]
	public UIButton BtnFullPreview;

	[Token(Token = "0x4018E2E")]
	[FieldOffset(Offset = "0x68")]
	public UILabel LabelSubscribeCount;

	[Token(Token = "0x4018E2F")]
	[FieldOffset(Offset = "0x6C")]
	public UILabel LabelLikeCount;

	[Token(Token = "0x4018E30")]
	[FieldOffset(Offset = "0x70")]
	public UILabel LabelAuthorName;

	[Token(Token = "0x4018E31")]
	[FieldOffset(Offset = "0x74")]
	public UIButton BtnAuthor;

	[Token(Token = "0x4018E32")]
	[FieldOffset(Offset = "0x78")]
	public UILabel LabelTotalRoundCnt;

	[Token(Token = "0x4018E33")]
	[FieldOffset(Offset = "0x7C")]
	public UILabel LabelBattleTypeInfo;

	[Token(Token = "0x4018E34")]
	[FieldOffset(Offset = "0x80")]
	public UIScrollView DescScrollView;

	[Token(Token = "0x4018E35")]
	[FieldOffset(Offset = "0x84")]
	public UILabel LabelDesc;

	[Token(Token = "0x4018E36")]
	[FieldOffset(Offset = "0x88")]
	public UIPanel RoomSettingMaskPanel;

	[Token(Token = "0x4018E37")]
	[FieldOffset(Offset = "0x8C")]
	public UIButton RoomSettingMask;

	[Token(Token = "0x4018E38")]
	[FieldOffset(Offset = "0x90")]
	public GameObject CSAdSettingPanel;

	[Token(Token = "0x4018E39")]
	[FieldOffset(Offset = "0x94")]
	public UIGrid BtnGrid;

	[Token(Token = "0x4018E3A")]
	[FieldOffset(Offset = "0x98")]
	public UIButton CancelBtn;

	[Token(Token = "0x4018E3B")]
	[FieldOffset(Offset = "0x9C")]
	public UIButton ConfirmBtn;

	[Token(Token = "0x4018E3C")]
	[FieldOffset(Offset = "0xA0")]
	public GameObject NormalConfirmBtn;

	[Token(Token = "0x4018E3D")]
	[FieldOffset(Offset = "0xA4")]
	public GameObject FreeConfirmBtn;

	[Token(Token = "0x6017338")]
	[Address(RVA = "0x1A2B3C4", Offset = "0x1A2B3C4", VA = "0x1A2B3C4")]
	public UIWorkshopCreateRoomView()
	{
	}

	[Token(Token = "0x6017339")]
	[Address(RVA = "0x1A2B3CC", Offset = "0x1A2B3CC", VA = "0x1A2B3CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601733A")]
	[Address(RVA = "0x1A2C27C", Offset = "0x1A2C27C", VA = "0x1A2C27C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
