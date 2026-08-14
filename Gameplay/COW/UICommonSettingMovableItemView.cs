using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003482")]
public class UICommonSettingMovableItemView : UIBaseView
{
	[Token(Token = "0x40146F9")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget Widget;

	[Token(Token = "0x40146FA")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Mask;

	[Token(Token = "0x40146FB")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton TipBtn;

	[Token(Token = "0x40146FC")]
	[FieldOffset(Offset = "0x20")]
	public GameObject SliderContainer;

	[Token(Token = "0x40146FD")]
	[FieldOffset(Offset = "0x24")]
	public UISlider Slider;

	[Token(Token = "0x40146FE")]
	[FieldOffset(Offset = "0x28")]
	public UILabel SliderValue;

	[Token(Token = "0x40146FF")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton DecreaseBtn;

	[Token(Token = "0x4014700")]
	[FieldOffset(Offset = "0x30")]
	public UIButton IncreaseBtn;

	[Token(Token = "0x4014701")]
	[FieldOffset(Offset = "0x34")]
	public UISprite BGSprite;

	[Token(Token = "0x4014702")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LeftLabel;

	[Token(Token = "0x4014703")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggle ExpandToggleBtn;

	[Token(Token = "0x4014704")]
	[FieldOffset(Offset = "0x40")]
	public GameObject FoldedArrow;

	[Token(Token = "0x4014705")]
	[FieldOffset(Offset = "0x44")]
	public GameObject UnfoldedArrow;

	[Token(Token = "0x4014706")]
	[FieldOffset(Offset = "0x48")]
	public UIButton UpArrowBtn;

	[Token(Token = "0x4014707")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite UpArrowSprite;

	[Token(Token = "0x4014708")]
	[FieldOffset(Offset = "0x50")]
	public UIButton DownArrowBtn;

	[Token(Token = "0x4014709")]
	[FieldOffset(Offset = "0x54")]
	public UISprite DownArrowSprite;

	[Token(Token = "0x401470A")]
	[FieldOffset(Offset = "0x58")]
	public UITable MenuItemTable;

	[Token(Token = "0x601613A")]
	[Address(RVA = "0x1EB7ABC", Offset = "0x1EB7ABC", VA = "0x1EB7ABC")]
	public UICommonSettingMovableItemView()
	{
	}

	[Token(Token = "0x601613B")]
	[Address(RVA = "0x1EB7AC4", Offset = "0x1EB7AC4", VA = "0x1EB7AC4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601613C")]
	[Address(RVA = "0x1EB829C", Offset = "0x1EB829C", VA = "0x1EB829C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
