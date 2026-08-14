using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200373C")]
public class UIHudSceneEditSettingPanelView : UIBaseView
{
	[Token(Token = "0x4016532")]
	[FieldOffset(Offset = "0x14")]
	public UIButton CloseBtn;

	[Token(Token = "0x4016533")]
	[FieldOffset(Offset = "0x18")]
	public TweenPosition TweenPos;

	[Token(Token = "0x4016534")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton RemoveBtn;

	[Token(Token = "0x4016535")]
	[FieldOffset(Offset = "0x20")]
	public UIButton SwitchBtn;

	[Token(Token = "0x4016536")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture CDNIcon;

	[Token(Token = "0x4016537")]
	[FieldOffset(Offset = "0x28")]
	public UISprite DefaultIcon;

	[Token(Token = "0x4016538")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton BigCloseBtn;

	[Token(Token = "0x4016539")]
	[FieldOffset(Offset = "0x30")]
	public UILabel EditModeName;

	[Token(Token = "0x401653A")]
	[FieldOffset(Offset = "0x34")]
	public UIToggleButtonGroup ToggleGroup1;

	[Token(Token = "0x401653B")]
	[FieldOffset(Offset = "0x38")]
	public UIToggleButtonGroup ToggleGroup2;

	[Token(Token = "0x401653C")]
	[FieldOffset(Offset = "0x3C")]
	public UIToggleButtonGroup ToggleGroup3;

	[Token(Token = "0x401653D")]
	[FieldOffset(Offset = "0x40")]
	public UIToggleButtonGroup ToggleGroup4;

	[Token(Token = "0x401653E")]
	[FieldOffset(Offset = "0x44")]
	public UISlider Slider1;

	[Token(Token = "0x401653F")]
	[FieldOffset(Offset = "0x48")]
	public UILabel SliderValueText;

	[Token(Token = "0x4016540")]
	[FieldOffset(Offset = "0x4C")]
	public UIGrid Grid;

	[Token(Token = "0x4016541")]
	[FieldOffset(Offset = "0x50")]
	public UIButton Tip1;

	[Token(Token = "0x4016542")]
	[FieldOffset(Offset = "0x54")]
	public UIButton Tip2;

	[Token(Token = "0x4016543")]
	[FieldOffset(Offset = "0x58")]
	public UIButton Tip3;

	[Token(Token = "0x4016544")]
	[FieldOffset(Offset = "0x5C")]
	public UIButton Tip4;

	[Token(Token = "0x601695F")]
	[Address(RVA = "0x16AD55C", Offset = "0x16AD55C", VA = "0x16AD55C")]
	public UIHudSceneEditSettingPanelView()
	{
	}

	[Token(Token = "0x6016960")]
	[Address(RVA = "0x16AD564", Offset = "0x16AD564", VA = "0x16AD564", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016961")]
	[Address(RVA = "0x16ADDCC", Offset = "0x16ADDCC", VA = "0x16ADDCC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
