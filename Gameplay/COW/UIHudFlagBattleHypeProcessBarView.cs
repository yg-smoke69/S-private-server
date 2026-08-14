using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003654")]
public class UIHudFlagBattleHypeProcessBarView : UIBaseView
{
	[Token(Token = "0x4015CB2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel HypeValueTxt;

	[Token(Token = "0x4015CB3")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SliderContainer;

	[Token(Token = "0x4015CB4")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015CB5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015CB6")]
	[FieldOffset(Offset = "0x24")]
	public Transform s1;

	[Token(Token = "0x4015CB7")]
	[FieldOffset(Offset = "0x28")]
	public UISprite sliderSpr1;

	[Token(Token = "0x4015CB8")]
	[FieldOffset(Offset = "0x2C")]
	public Transform s2;

	[Token(Token = "0x4015CB9")]
	[FieldOffset(Offset = "0x30")]
	public UISprite sliderSpr2;

	[Token(Token = "0x4015CBA")]
	[FieldOffset(Offset = "0x34")]
	public Transform s3;

	[Token(Token = "0x4015CBB")]
	[FieldOffset(Offset = "0x38")]
	public UISprite sliderSpr3;

	[Token(Token = "0x4015CBC")]
	[FieldOffset(Offset = "0x3C")]
	public Transform s4;

	[Token(Token = "0x4015CBD")]
	[FieldOffset(Offset = "0x40")]
	public UISprite sliderSpr4;

	[Token(Token = "0x4015CBE")]
	[FieldOffset(Offset = "0x44")]
	public Transform s5;

	[Token(Token = "0x4015CBF")]
	[FieldOffset(Offset = "0x48")]
	public UISprite sliderSpr5;

	[Token(Token = "0x4015CC0")]
	[FieldOffset(Offset = "0x4C")]
	public ParticleSystem LevelUpEffect;

	[Token(Token = "0x4015CC1")]
	[FieldOffset(Offset = "0x50")]
	public Transform ProcessSliderBg0;

	[Token(Token = "0x4015CC2")]
	[FieldOffset(Offset = "0x54")]
	public Transform ProcessSliderBg1;

	[Token(Token = "0x4015CC3")]
	[FieldOffset(Offset = "0x58")]
	public Transform ProcessSliderBg2;

	[Token(Token = "0x4015CC4")]
	[FieldOffset(Offset = "0x5C")]
	public Transform ProcessSliderBg3;

	[Token(Token = "0x4015CC5")]
	[FieldOffset(Offset = "0x60")]
	public Transform ProcessSliderBg4;

	[Token(Token = "0x4015CC6")]
	[FieldOffset(Offset = "0x64")]
	public UISprite ProcessSlider;

	[Token(Token = "0x4015CC7")]
	[FieldOffset(Offset = "0x68")]
	public Transform movingFrame;

	[Token(Token = "0x4015CC8")]
	[FieldOffset(Offset = "0x6C")]
	public ParticleSystem HypeIncreasingEffect;

	[Token(Token = "0x4015CC9")]
	[FieldOffset(Offset = "0x70")]
	public UICustomHoverButton CheckAllAttributeBtn;

	[Token(Token = "0x4015CCA")]
	[FieldOffset(Offset = "0x74")]
	public UIButton LevelUpBtn;

	[Token(Token = "0x4015CCB")]
	[FieldOffset(Offset = "0x78")]
	public GameObject AttributesSelectContainer;

	[Token(Token = "0x4015CCC")]
	[FieldOffset(Offset = "0x7C")]
	public UIGrid Grid;

	[Token(Token = "0x4015CCD")]
	[FieldOffset(Offset = "0x80")]
	public GameObject DescInfo;

	[Token(Token = "0x4015CCE")]
	[FieldOffset(Offset = "0x84")]
	public UISprite DescBG;

	[Token(Token = "0x4015CCF")]
	[FieldOffset(Offset = "0x88")]
	public UITable DescTable;

	[Token(Token = "0x4015CD0")]
	[FieldOffset(Offset = "0x8C")]
	public UILabel DescTemp;

	[Token(Token = "0x4015CD1")]
	[FieldOffset(Offset = "0x90")]
	public Transform MaxHypeLevelEffect;

	[Token(Token = "0x4015CD2")]
	[FieldOffset(Offset = "0x94")]
	public UIFlagBattleChooseItemController AttributeItem;

	[Token(Token = "0x4015CD3")]
	[FieldOffset(Offset = "0x98")]
	public Transform FSMode;

	[Token(Token = "0x60166A9")]
	[Address(RVA = "0x1BAE5B0", Offset = "0x1BAE5B0", VA = "0x1BAE5B0")]
	public UIHudFlagBattleHypeProcessBarView()
	{
	}

	[Token(Token = "0x60166AA")]
	[Address(RVA = "0x1BAE5B8", Offset = "0x1BAE5B8", VA = "0x1BAE5B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166AB")]
	[Address(RVA = "0x1BAF17C", Offset = "0x1BAF17C", VA = "0x1BAF17C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
