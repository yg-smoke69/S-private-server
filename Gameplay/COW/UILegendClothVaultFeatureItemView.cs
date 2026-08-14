using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200381D")]
public class UILegendClothVaultFeatureItemView : UIBaseView
{
	[Token(Token = "0x4016D96")]
	[FieldOffset(Offset = "0x14")]
	public Transform TrChosen;

	[Token(Token = "0x4016D97")]
	[FieldOffset(Offset = "0x18")]
	public UIButton BtnFeature;

	[Token(Token = "0x4016D98")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite SpriteFeatureIcon;

	[Token(Token = "0x4016D99")]
	[FieldOffset(Offset = "0x20")]
	public UISprite SpriteFeatureIconbg;

	[Token(Token = "0x4016D9A")]
	[FieldOffset(Offset = "0x24")]
	public UISprite SpriteQualityBg;

	[Token(Token = "0x4016D9B")]
	[FieldOffset(Offset = "0x28")]
	public UISprite SpriteQualityPlus;

	[Token(Token = "0x4016D9C")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite SpriteQuality;

	[Token(Token = "0x4016D9D")]
	[FieldOffset(Offset = "0x30")]
	public UILabel LabelFeatureTitle;

	[Token(Token = "0x4016D9E")]
	[FieldOffset(Offset = "0x34")]
	public UILabel LabelFeatureTip;

	[Token(Token = "0x4016D9F")]
	[FieldOffset(Offset = "0x38")]
	public UISprite SpriteOrangeQualityPlus;

	[Token(Token = "0x6016C02")]
	[Address(RVA = "0x253EB54", Offset = "0x253EB54", VA = "0x253EB54")]
	public UILegendClothVaultFeatureItemView()
	{
	}

	[Token(Token = "0x6016C03")]
	[Address(RVA = "0x253EB5C", Offset = "0x253EB5C", VA = "0x253EB5C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C04")]
	[Address(RVA = "0x253F03C", Offset = "0x253F03C", VA = "0x253F03C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
