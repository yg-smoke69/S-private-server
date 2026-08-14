using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003573")]
public class UIGachaFeatureView : UIBaseView
{
	[Token(Token = "0x4015306")]
	[FieldOffset(Offset = "0x14")]
	public Animator ShowFeatureAnim;

	[Token(Token = "0x4015307")]
	[FieldOffset(Offset = "0x18")]
	public GameObject UIContent;

	[Token(Token = "0x4015308")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton Mask;

	[Token(Token = "0x4015309")]
	[FieldOffset(Offset = "0x20")]
	public UITexture GachaFeature_Bg;

	[Token(Token = "0x401530A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject InterfaceMask;

	[Token(Token = "0x401530B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ItemShow;

	[Token(Token = "0x401530C")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject ItemInfoContainer;

	[Token(Token = "0x401530D")]
	[FieldOffset(Offset = "0x30")]
	public BaseItemView2 BaseInfoView;

	[Token(Token = "0x401530E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton SkipMask;

	[Token(Token = "0x401530F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject Bottom_btn;

	[Token(Token = "0x4015310")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ShareBtn;

	[Token(Token = "0x4015311")]
	[FieldOffset(Offset = "0x40")]
	public Animator ShareIconAnimator;

	[Token(Token = "0x4015312")]
	[FieldOffset(Offset = "0x44")]
	public UIButton OkBtn;

	[Token(Token = "0x4015313")]
	[FieldOffset(Offset = "0x48")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x4015314")]
	[FieldOffset(Offset = "0x4C")]
	public UISprite IPTag;

	[Token(Token = "0x4015315")]
	[FieldOffset(Offset = "0x50")]
	public UILabel ItemNameVioLabel;

	[Token(Token = "0x4015316")]
	[FieldOffset(Offset = "0x54")]
	public UISprite IPTagVio;

	[Token(Token = "0x4015317")]
	[FieldOffset(Offset = "0x58")]
	public GameObject GoQualityPlusPurple;

	[Token(Token = "0x4015318")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject GoQualityPlusOrange;

	[Token(Token = "0x4015319")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ItemNameRedLabel;

	[Token(Token = "0x401531A")]
	[FieldOffset(Offset = "0x64")]
	public UISprite IPRedTag;

	[Token(Token = "0x401531B")]
	[FieldOffset(Offset = "0x68")]
	public Transform LuckyWheelShreInfo;

	[Token(Token = "0x401531C")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject Left;

	[Token(Token = "0x6016409")]
	[Address(RVA = "0x2488024", Offset = "0x2488024", VA = "0x2488024")]
	public UIGachaFeatureView()
	{
	}

	[Token(Token = "0x601640A")]
	[Address(RVA = "0x248802C", Offset = "0x248802C", VA = "0x248802C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601640B")]
	[Address(RVA = "0x248898C", Offset = "0x248898C", VA = "0x248898C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
