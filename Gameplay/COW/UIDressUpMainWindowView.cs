using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034F9")]
public class UIDressUpMainWindowView : UIBaseView
{
	[Token(Token = "0x4014D69")]
	[FieldOffset(Offset = "0x14")]
	public Transform LeftTabContainer;

	[Token(Token = "0x4014D6A")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeftAnimContainer;

	[Token(Token = "0x4014D6B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject FirstTabContainer;

	[Token(Token = "0x4014D6C")]
	[FieldOffset(Offset = "0x20")]
	public Transform CollectionContainer;

	[Token(Token = "0x4014D6D")]
	[FieldOffset(Offset = "0x24")]
	public UISprite collectionBg;

	[Token(Token = "0x4014D6E")]
	[FieldOffset(Offset = "0x28")]
	public UISprite collectionbg;

	[Token(Token = "0x4014D6F")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject CollectionContainerNode;

	[Token(Token = "0x4014D70")]
	[FieldOffset(Offset = "0x30")]
	public UIScrollView DressUpScrollView;

	[Token(Token = "0x4014D71")]
	[FieldOffset(Offset = "0x34")]
	public Animation DressUpScrollViewAni;

	[Token(Token = "0x4014D72")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList DressUpEasyList;

	[Token(Token = "0x4014D73")]
	[FieldOffset(Offset = "0x3C")]
	public Transform RightTabContainer;

	[Token(Token = "0x4014D74")]
	[FieldOffset(Offset = "0x40")]
	public GameObject GameObjectDressUpSlotContainer;

	[Token(Token = "0x4014D75")]
	[FieldOffset(Offset = "0x44")]
	public UIDressUpSLotComp UIDressUpSLotCompDressUpSlotContainer;

	[Token(Token = "0x4014D76")]
	[FieldOffset(Offset = "0x48")]
	public GameObject DressUpExchangeContainer;

	[Token(Token = "0x4014D77")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid DressUpExchangeGrid;

	[Token(Token = "0x4014D78")]
	[FieldOffset(Offset = "0x50")]
	public UIButton EquipBtn;

	[Token(Token = "0x4014D79")]
	[FieldOffset(Offset = "0x54")]
	public GameObject EquipCommonState;

	[Token(Token = "0x4014D7A")]
	[FieldOffset(Offset = "0x58")]
	public UILabel EquipBtnLabel1;

	[Token(Token = "0x4014D7B")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject EquipDisableState;

	[Token(Token = "0x4014D7C")]
	[FieldOffset(Offset = "0x60")]
	public UILabel EquipBtnLabel2;

	[Token(Token = "0x4014D7D")]
	[FieldOffset(Offset = "0x64")]
	public GameObject AlreadyEquipState;

	[Token(Token = "0x4014D7E")]
	[FieldOffset(Offset = "0x68")]
	public UILabel EquipBtnLabel3;

	[Token(Token = "0x4014D7F")]
	[FieldOffset(Offset = "0x6C")]
	public UIButton SaveBtn;

	[Token(Token = "0x4014D80")]
	[FieldOffset(Offset = "0x70")]
	public GameObject GoLegendColor;

	[Token(Token = "0x4014D81")]
	[FieldOffset(Offset = "0x74")]
	public UIButton UIButtonBtnColorPanel;

	[Token(Token = "0x4014D82")]
	[FieldOffset(Offset = "0x78")]
	public UISprite UISpriteBtnColorPanel;

	[Token(Token = "0x4014D83")]
	[FieldOffset(Offset = "0x7C")]
	public UIPanel PanelShowColor;

	[Token(Token = "0x4014D84")]
	[FieldOffset(Offset = "0x80")]
	public UISprite SpritePanelColorBg;

	[Token(Token = "0x4014D85")]
	[FieldOffset(Offset = "0x84")]
	public UIGrid GridColorPanel;

	[Token(Token = "0x4014D86")]
	[FieldOffset(Offset = "0x88")]
	public UIButton BagShowBtn;

	[Token(Token = "0x4014D87")]
	[FieldOffset(Offset = "0x8C")]
	public GameObject check;

	[Token(Token = "0x4014D88")]
	[FieldOffset(Offset = "0x90")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x601629B")]
	[Address(RVA = "0x2B983EC", Offset = "0x2B983EC", VA = "0x2B983EC")]
	public UIDressUpMainWindowView()
	{
	}

	[Token(Token = "0x601629C")]
	[Address(RVA = "0x2B983F4", Offset = "0x2B983F4", VA = "0x2B983F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601629D")]
	[Address(RVA = "0x2B9904C", Offset = "0x2B9904C", VA = "0x2B9904C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
