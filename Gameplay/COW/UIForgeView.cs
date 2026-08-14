using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003541")]
public class UIForgeView : UIBaseView
{
	[Token(Token = "0x401513A")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Container;

	[Token(Token = "0x401513B")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Toggles;

	[Token(Token = "0x401513C")]
	[FieldOffset(Offset = "0x1C")]
	public UIScrollView ToggleScrollView;

	[Token(Token = "0x401513D")]
	[FieldOffset(Offset = "0x20")]
	public UIToggleButton Toggle;

	[Token(Token = "0x401513E")]
	[FieldOffset(Offset = "0x24")]
	public UIGrid ToggleGrid;

	[Token(Token = "0x401513F")]
	[FieldOffset(Offset = "0x28")]
	public UIToggleButtonGroup ToggleGroup;

	[Token(Token = "0x4015140")]
	[FieldOffset(Offset = "0x2C")]
	public UIScrollView ItemScrollView;

	[Token(Token = "0x4015141")]
	[FieldOffset(Offset = "0x30")]
	public UIEasyList Grid;

	[Token(Token = "0x4015142")]
	[FieldOffset(Offset = "0x34")]
	public UIButton ExchangeBtn;

	[Token(Token = "0x4015143")]
	[FieldOffset(Offset = "0x38")]
	public UISprite BuyBtnBG;

	[Token(Token = "0x4015144")]
	[FieldOffset(Offset = "0x3C")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x4015145")]
	[FieldOffset(Offset = "0x40")]
	public UILabel ExchangeBtnLabel;

	[Token(Token = "0x4015146")]
	[FieldOffset(Offset = "0x44")]
	public UILabel LabelLimitedCount;

	[Token(Token = "0x4015147")]
	[FieldOffset(Offset = "0x48")]
	public UITable NotEnoughMaterial;

	[Token(Token = "0x4015148")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite NotEnoughMaterial1;

	[Token(Token = "0x4015149")]
	[FieldOffset(Offset = "0x50")]
	public UISprite NotEnoughMaterial2;

	[Token(Token = "0x401514A")]
	[FieldOffset(Offset = "0x54")]
	public UIWidget PreviewBorder;

	[Token(Token = "0x6016373")]
	[Address(RVA = "0x1B6AF98", Offset = "0x1B6AF98", VA = "0x1B6AF98")]
	public UIForgeView()
	{
	}

	[Token(Token = "0x6016374")]
	[Address(RVA = "0x1B6AFA0", Offset = "0x1B6AFA0", VA = "0x1B6AFA0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016375")]
	[Address(RVA = "0x1B6B730", Offset = "0x1B6B730", VA = "0x1B6B730")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
