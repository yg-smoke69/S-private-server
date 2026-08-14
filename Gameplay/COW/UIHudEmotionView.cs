using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003640")]
public class UIHudEmotionView : UIBaseView
{
	[Token(Token = "0x4015C29")]
	[FieldOffset(Offset = "0x14")]
	public UIHudEmotionItem UIHudEmotionItem1;

	[Token(Token = "0x4015C2A")]
	[FieldOffset(Offset = "0x18")]
	public UIHudEmotionItem UIHudEmotionItem2;

	[Token(Token = "0x4015C2B")]
	[FieldOffset(Offset = "0x1C")]
	public UIHudEmotionItem UIHudEmotionItem3;

	[Token(Token = "0x4015C2C")]
	[FieldOffset(Offset = "0x20")]
	public UIHudEmotionItem UIHudEmotionItem4;

	[Token(Token = "0x4015C2D")]
	[FieldOffset(Offset = "0x24")]
	public UIHudEmotionItem UIHudEmotionItem5;

	[Token(Token = "0x4015C2E")]
	[FieldOffset(Offset = "0x28")]
	public UIHudEmotionItem UIHudEmotionItem6;

	[Token(Token = "0x4015C2F")]
	[FieldOffset(Offset = "0x2C")]
	public UIHudEmotionItem UIHudEmotionItem7;

	[Token(Token = "0x4015C30")]
	[FieldOffset(Offset = "0x30")]
	public UIHudEmotionItem UIHudEmotionItem8;

	[Token(Token = "0x4015C31")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnCustomAnim;

	[Token(Token = "0x4015C32")]
	[FieldOffset(Offset = "0x38")]
	public UIButton BtnPaintSprayer;

	[Token(Token = "0x4015C33")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel PaintSprayerCount;

	[Token(Token = "0x4015C34")]
	[FieldOffset(Offset = "0x40")]
	public UIButton EmotionBGMaskBtn;

	[Token(Token = "0x4015C35")]
	[FieldOffset(Offset = "0x44")]
	public GameObject DownloadInfo;

	[Token(Token = "0x4015C36")]
	[FieldOffset(Offset = "0x48")]
	public UIHudAvatarTransformer UIHudAvatarTransformer;

	[Token(Token = "0x4015C37")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DesPos1;

	[Token(Token = "0x4015C38")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DesPos2;

	[Token(Token = "0x4015C39")]
	[FieldOffset(Offset = "0x54")]
	public GameObject DesPos3;

	[Token(Token = "0x4015C3A")]
	[FieldOffset(Offset = "0x58")]
	public GameObject DesPos4;

	[Token(Token = "0x4015C3B")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject DesPos5;

	[Token(Token = "0x4015C3C")]
	[FieldOffset(Offset = "0x60")]
	public GameObject DesPos6;

	[Token(Token = "0x4015C3D")]
	[FieldOffset(Offset = "0x64")]
	public GameObject DesPos7;

	[Token(Token = "0x4015C3E")]
	[FieldOffset(Offset = "0x68")]
	public GameObject DesPos8;

	[Token(Token = "0x601666D")]
	[Address(RVA = "0x1CE24A0", Offset = "0x1CE24A0", VA = "0x1CE24A0")]
	public UIHudEmotionView()
	{
	}

	[Token(Token = "0x601666E")]
	[Address(RVA = "0x1CE24A8", Offset = "0x1CE24A8", VA = "0x1CE24A8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601666F")]
	[Address(RVA = "0x1CE2DC4", Offset = "0x1CE2DC4", VA = "0x1CE2DC4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
