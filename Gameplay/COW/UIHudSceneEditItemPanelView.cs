using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003731")]
public class UIHudSceneEditItemPanelView : UIBaseView
{
	[Token(Token = "0x40164E0")]
	[FieldOffset(Offset = "0x14")]
	public UIScrollView TabScrollView;

	[Token(Token = "0x40164E1")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid TabGrid;

	[Token(Token = "0x40164E2")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggleButtonGroup TabToggleGroup;

	[Token(Token = "0x40164E3")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ItemPanelTab;

	[Token(Token = "0x40164E4")]
	[FieldOffset(Offset = "0x24")]
	public UIScrollView SubTabScrollView;

	[Token(Token = "0x40164E5")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid SubTabGrid;

	[Token(Token = "0x40164E6")]
	[FieldOffset(Offset = "0x2C")]
	public UIToggleButtonGroup SubTabToggleGroup;

	[Token(Token = "0x40164E7")]
	[FieldOffset(Offset = "0x30")]
	public GameObject ItemPanelSubTab;

	[Token(Token = "0x40164E8")]
	[FieldOffset(Offset = "0x34")]
	public UIScrollView ItemListScrollView;

	[Token(Token = "0x40164E9")]
	[FieldOffset(Offset = "0x38")]
	public UIEasyList EasyList;

	[Token(Token = "0x40164EA")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel CostTotalLabel;

	[Token(Token = "0x40164EB")]
	[FieldOffset(Offset = "0x40")]
	public UIButton ToggleBtn;

	[Token(Token = "0x40164EC")]
	[FieldOffset(Offset = "0x44")]
	public UIButton TipsBtn;

	[Token(Token = "0x40164ED")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x40164EE")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel ItemCostLabel;

	[Token(Token = "0x40164EF")]
	[FieldOffset(Offset = "0x50")]
	public UIButton ToggleBtnReverse;

	[Token(Token = "0x40164F0")]
	[FieldOffset(Offset = "0x54")]
	public TweenPosition TweenPos;

	[Token(Token = "0x40164F1")]
	[FieldOffset(Offset = "0x58")]
	public GameObject Bg;

	[Token(Token = "0x40164F2")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject ContentBg;

	[Token(Token = "0x40164F3")]
	[FieldOffset(Offset = "0x60")]
	public UIButton AttributeBtn;

	[Token(Token = "0x40164F4")]
	[FieldOffset(Offset = "0x64")]
	public UISprite line;

	[Token(Token = "0x601693E")]
	[Address(RVA = "0x24DD1A8", Offset = "0x24DD1A8", VA = "0x24DD1A8")]
	public UIHudSceneEditItemPanelView()
	{
	}

	[Token(Token = "0x601693F")]
	[Address(RVA = "0x24DD1B0", Offset = "0x24DD1B0", VA = "0x24DD1B0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016940")]
	[Address(RVA = "0x24DDAA8", Offset = "0x24DDAA8", VA = "0x24DDAA8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
