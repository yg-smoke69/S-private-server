using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003672")]
public class UIHudHypeProcessBarView : UIBaseView
{
	[Token(Token = "0x4015D9B")]
	[FieldOffset(Offset = "0x14")]
	public UILabel HypeValueTxt;

	[Token(Token = "0x4015D9C")]
	[FieldOffset(Offset = "0x18")]
	public GameObject SliderContainer;

	[Token(Token = "0x4015D9D")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ArrowUp;

	[Token(Token = "0x4015D9E")]
	[FieldOffset(Offset = "0x20")]
	public GameObject ArrowDown;

	[Token(Token = "0x4015D9F")]
	[FieldOffset(Offset = "0x24")]
	public Transform ProcessSliderBg0;

	[Token(Token = "0x4015DA0")]
	[FieldOffset(Offset = "0x28")]
	public Transform ProcessSliderBg1;

	[Token(Token = "0x4015DA1")]
	[FieldOffset(Offset = "0x2C")]
	public Transform ProcessSliderBg2;

	[Token(Token = "0x4015DA2")]
	[FieldOffset(Offset = "0x30")]
	public Transform ProcessSliderBg3;

	[Token(Token = "0x4015DA3")]
	[FieldOffset(Offset = "0x34")]
	public Transform ProcessSliderBg4;

	[Token(Token = "0x4015DA4")]
	[FieldOffset(Offset = "0x38")]
	public UISprite ProcessSlider;

	[Token(Token = "0x4015DA5")]
	[FieldOffset(Offset = "0x3C")]
	public Transform movingFrame;

	[Token(Token = "0x4015DA6")]
	[FieldOffset(Offset = "0x40")]
	public ParticleSystem HypeIncreasingEffect;

	[Token(Token = "0x4015DA7")]
	[FieldOffset(Offset = "0x44")]
	public Transform lv1pos;

	[Token(Token = "0x4015DA8")]
	[FieldOffset(Offset = "0x48")]
	public Transform lv2pos;

	[Token(Token = "0x4015DA9")]
	[FieldOffset(Offset = "0x4C")]
	public Transform lv3pos;

	[Token(Token = "0x4015DAA")]
	[FieldOffset(Offset = "0x50")]
	public Transform lv4pos;

	[Token(Token = "0x4015DAB")]
	[FieldOffset(Offset = "0x54")]
	public Transform lv5pos;

	[Token(Token = "0x4015DAC")]
	[FieldOffset(Offset = "0x58")]
	public ParticleSystem LevelUpEffect;

	[Token(Token = "0x4015DAD")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject DevideLine;

	[Token(Token = "0x4015DAE")]
	[FieldOffset(Offset = "0x60")]
	public GameObject SnowManCloth;

	[Token(Token = "0x4015DAF")]
	[FieldOffset(Offset = "0x64")]
	public Transform Down;

	[Token(Token = "0x4015DB0")]
	[FieldOffset(Offset = "0x68")]
	public Transform Up;

	[Token(Token = "0x4015DB1")]
	[FieldOffset(Offset = "0x6C")]
	public Transform All;

	[Token(Token = "0x4015DB2")]
	[FieldOffset(Offset = "0x70")]
	public Transform MaxHypeLevelEffect;

	[Token(Token = "0x4015DB3")]
	[FieldOffset(Offset = "0x74")]
	public GameObject BallRadiusBarContainer;

	[Token(Token = "0x4015DB4")]
	[FieldOffset(Offset = "0x78")]
	public UISprite BallRadiusBar;

	[Token(Token = "0x4015DB5")]
	[FieldOffset(Offset = "0x7C")]
	public UISprite Ball;

	[Token(Token = "0x6016703")]
	[Address(RVA = "0x134C644", Offset = "0x134C644", VA = "0x134C644")]
	public UIHudHypeProcessBarView()
	{
	}

	[Token(Token = "0x6016704")]
	[Address(RVA = "0x134C64C", Offset = "0x134C64C", VA = "0x134C64C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016705")]
	[Address(RVA = "0x134CF14", Offset = "0x134CF14", VA = "0x134CF14")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
