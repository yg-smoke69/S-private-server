using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035E7")]
public class UIHudBigHeadHypeProcessBarView : UIBaseView
{
	[Token(Token = "0x4015930")]
	[FieldOffset(Offset = "0x14")]
	public UILabel HypeValueTxt;

	[Token(Token = "0x4015931")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SliderContainer;

	[Token(Token = "0x4015932")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015933")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015934")]
	[FieldOffset(Offset = "0x24")]
	public Transform ProcessSliderBg0;

	[Token(Token = "0x4015935")]
	[FieldOffset(Offset = "0x28")]
	public Transform ProcessSliderBg1;

	[Token(Token = "0x4015936")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ProcessSliderBg2;

	[Token(Token = "0x4015937")]
	[FieldOffset(Offset = "0x30")]
	public Transform ProcessSliderBg3;

	[Token(Token = "0x4015938")]
	[FieldOffset(Offset = "0x34")]
	public Transform ProcessSliderBg4;

	[Token(Token = "0x4015939")]
	[FieldOffset(Offset = "0x38")]
	public UISprite ProcessSlider;

	[Token(Token = "0x401593A")]
	[FieldOffset(Offset = "0x3C")]
	public Transform movingFrame;

	[Token(Token = "0x401593B")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem HypeIncreasingEffect;

	[Token(Token = "0x401593C")]
	[FieldOffset(Offset = "0x44")]
	public Transform lv1pos;

	[Token(Token = "0x401593D")]
	[FieldOffset(Offset = "0x48")]
	public Transform lv2pos;

	[Token(Token = "0x401593E")]
	[FieldOffset(Offset = "0x4C")]
	public Transform lv3pos;

	[Token(Token = "0x401593F")]
	[FieldOffset(Offset = "0x50")]
	public Transform lv4pos;

	[Token(Token = "0x4015940")]
	[FieldOffset(Offset = "0x54")]
	public Transform lv5pos;

	[Token(Token = "0x4015941")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystem LevelUpEffect;

	[Token(Token = "0x4015942")]
	[FieldOffset(Offset = "0x5C")]
	public UIWidget TutorialWidget;

	[Token(Token = "0x4015943")]
	[FieldOffset(Offset = "0x60")]
	public Transform MaxHypeLevelEffect;

	[Token(Token = "0x4015944")]
	[FieldOffset(Offset = "0x64")]
	public GameObject SnowManCloth;

	[Token(Token = "0x6016563")]
	[Address(RVA = "0x1DFAADC", Offset = "0x1DFAADC", VA = "0x1DFAADC")]
	public UIHudBigHeadHypeProcessBarView()
	{
	}

	[Token(Token = "0x6016564")]
	[Address(RVA = "0x1DFAAE4", Offset = "0x1DFAAE4", VA = "0x1DFAAE4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016565")]
	[Address(RVA = "0x1DFB1FC", Offset = "0x1DFB1FC", VA = "0x1DFB1FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
