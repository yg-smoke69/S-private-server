using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003658")]
public class UIHudFourSymbolsHypeProcessBarView : UIBaseView
{
	[Token(Token = "0x4015CE6")]
	[FieldOffset(Offset = "0x14")]
	public UILabel HypeValueTxt;

	[Token(Token = "0x4015CE7")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SliderContainer;

	[Token(Token = "0x4015CE8")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015CE9")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015CEA")]
	[FieldOffset(Offset = "0x24")]
	public Transform s1;

	[Token(Token = "0x4015CEB")]
	[FieldOffset(Offset = "0x28")]
	public UISprite sliderSpr1;

	[Token(Token = "0x4015CEC")]
	[FieldOffset(Offset = "0x2C")]
	public Transform s2;

	[Token(Token = "0x4015CED")]
	[FieldOffset(Offset = "0x30")]
	public UISprite sliderSpr2;

	[Token(Token = "0x4015CEE")]
	[FieldOffset(Offset = "0x34")]
	public Transform s3;

	[Token(Token = "0x4015CEF")]
	[FieldOffset(Offset = "0x38")]
	public UISprite sliderSpr3;

	[Token(Token = "0x4015CF0")]
	[FieldOffset(Offset = "0x3C")]
	public Transform s4;

	[Token(Token = "0x4015CF1")]
	[FieldOffset(Offset = "0x40")]
	public UISprite sliderSpr4;

	[Token(Token = "0x4015CF2")]
	[FieldOffset(Offset = "0x44")]
	public Transform s5;

	[Token(Token = "0x4015CF3")]
	[FieldOffset(Offset = "0x48")]
	public UISprite sliderSpr5;

	[Token(Token = "0x4015CF4")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem LevelUpEffect;

	[Token(Token = "0x4015CF5")]
	[FieldOffset(Offset = "0x50")]
	public Transform ProcessSliderBg0;

	[Token(Token = "0x4015CF6")]
	[FieldOffset(Offset = "0x54")]
	public Transform ProcessSliderBg1;

	[Token(Token = "0x4015CF7")]
	[FieldOffset(Offset = "0x58")]
	public Transform ProcessSliderBg2;

	[Token(Token = "0x4015CF8")]
	[FieldOffset(Offset = "0x5C")]
	public Transform ProcessSliderBg3;

	[Token(Token = "0x4015CF9")]
	[FieldOffset(Offset = "0x60")]
	public Transform ProcessSliderBg4;

	[Token(Token = "0x4015CFA")]
	[FieldOffset(Offset = "0x64")]
	public UISprite ProcessSlider;

	[Token(Token = "0x4015CFB")]
	[FieldOffset(Offset = "0x68")]
	public Transform movingFrame;

	[Token(Token = "0x4015CFC")]
	[FieldOffset(Offset = "0x6C")]
	public ParticleSystem HypeIncreasingEffect;

	[Token(Token = "0x4015CFD")]
	[FieldOffset(Offset = "0x70")]
	public UICustomHoverButton CheckAllAttributeBtn;

	[Token(Token = "0x4015CFE")]
	[FieldOffset(Offset = "0x74")]
	public UIButton LevelUpBtn;

	[Token(Token = "0x4015CFF")]
	[FieldOffset(Offset = "0x78")]
	public GameObject AttributesSelectContainer;

	[Token(Token = "0x4015D00")]
	[FieldOffset(Offset = "0x7C")]
	public UIGrid Grid;

	[Token(Token = "0x4015D01")]
	[FieldOffset(Offset = "0x80")]
	public UIFourSymbolsChooseItemController AttributeItem;

	[Token(Token = "0x4015D02")]
	[FieldOffset(Offset = "0x84")]
	public GameObject DescInfo;

	[Token(Token = "0x4015D03")]
	[FieldOffset(Offset = "0x88")]
	public UISprite DescBG;

	[Token(Token = "0x4015D04")]
	[FieldOffset(Offset = "0x8C")]
	public UITable DescTable;

	[Token(Token = "0x4015D05")]
	[FieldOffset(Offset = "0x90")]
	public UILabel DescTemp;

	[Token(Token = "0x4015D06")]
	[FieldOffset(Offset = "0x94")]
	public Transform MaxHypeLevelEffect;

	[Token(Token = "0x60166B5")]
	[Address(RVA = "0x1884058", Offset = "0x1884058", VA = "0x1884058")]
	public UIHudFourSymbolsHypeProcessBarView()
	{
	}

	[Token(Token = "0x60166B6")]
	[Address(RVA = "0x1884060", Offset = "0x1884060", VA = "0x1884060", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166B7")]
	[Address(RVA = "0x1884BEC", Offset = "0x1884BEC", VA = "0x1884BEC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
