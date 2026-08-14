using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200371F")]
public class UIHudSceneEditActionAttributeColorPanelView : UIBaseView
{
	[Token(Token = "0x4016464")]
	[FieldOffset(Offset = "0x14")]
	public Transform TopMenu;

	[Token(Token = "0x4016465")]
	[FieldOffset(Offset = "0x18")]
	public UISprite CurrentColor;

	[Token(Token = "0x4016466")]
	[FieldOffset(Offset = "0x1C")]
	public UITexture HSVSliderTexture;

	[Token(Token = "0x4016467")]
	[FieldOffset(Offset = "0x20")]
	public UISlider HSVSliderBar;

	[Token(Token = "0x4016468")]
	[FieldOffset(Offset = "0x24")]
	public UITexture HSVBoard;

	[Token(Token = "0x4016469")]
	[FieldOffset(Offset = "0x28")]
	public Transform HSVBoardPoint;

	[Token(Token = "0x401646A")]
	[FieldOffset(Offset = "0x2C")]
	public UIGrid Grid;

	[Token(Token = "0x401646B")]
	[FieldOffset(Offset = "0x30")]
	public GameObject PresetColor;

	[Token(Token = "0x401646C")]
	[FieldOffset(Offset = "0x34")]
	public UITexture AlphaTextureBoard;

	[Token(Token = "0x401646D")]
	[FieldOffset(Offset = "0x38")]
	public UISlider AlphaSliderBoard;

	[Token(Token = "0x401646E")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ClearPresetBtn;

	[Token(Token = "0x401646F")]
	[FieldOffset(Offset = "0x40")]
	public Transform ColorSelected;

	[Token(Token = "0x4016470")]
	[FieldOffset(Offset = "0x44")]
	public UIButton CloseMask;

	[Token(Token = "0x6016908")]
	[Address(RVA = "0x1C4C554", Offset = "0x1C4C554", VA = "0x1C4C554")]
	public UIHudSceneEditActionAttributeColorPanelView()
	{
	}

	[Token(Token = "0x6016909")]
	[Address(RVA = "0x1C4C55C", Offset = "0x1C4C55C", VA = "0x1C4C55C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601690A")]
	[Address(RVA = "0x1C4CB00", Offset = "0x1C4CB00", VA = "0x1C4CB00")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
