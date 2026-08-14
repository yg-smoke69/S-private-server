using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003516")]
public class UIEmoteShowPanelView : UIBaseView
{
	[Token(Token = "0x4014F26")]
	[FieldOffset(Offset = "0x14")]
	public UIEmoteShowItemView EmotionItem1;

	[Token(Token = "0x4014F27")]
	[FieldOffset(Offset = "0x18")]
	public UIEmoteShowItemView EmotionItem2;

	[Token(Token = "0x4014F28")]
	[FieldOffset(Offset = "0x1C")]
	public UIEmoteShowItemView EmotionItem3;

	[Token(Token = "0x4014F29")]
	[FieldOffset(Offset = "0x20")]
	public UIEmoteShowItemView EmotionItem4;

	[Token(Token = "0x4014F2A")]
	[FieldOffset(Offset = "0x24")]
	public UIEmoteShowItemView EmotionItem5;

	[Token(Token = "0x4014F2B")]
	[FieldOffset(Offset = "0x28")]
	public UIEmoteShowItemView EmotionItem6;

	[Token(Token = "0x4014F2C")]
	[FieldOffset(Offset = "0x2C")]
	public UIEmoteShowItemView EmotionItem7;

	[Token(Token = "0x4014F2D")]
	[FieldOffset(Offset = "0x30")]
	public UIEmoteShowItemView EmotionItem8;

	[Token(Token = "0x4014F2E")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnCustomAnim;

	[Token(Token = "0x4014F2F")]
	[FieldOffset(Offset = "0x38")]
	public GameObject DressUpContainer1;

	[Token(Token = "0x4014F30")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject DressUpContainer2;

	[Token(Token = "0x4014F31")]
	[FieldOffset(Offset = "0x40")]
	public UIButton EmotionBGMaskBtn;

	[Token(Token = "0x4014F32")]
	[FieldOffset(Offset = "0x44")]
	public Transform DressUpDesgar1Pos;

	[Token(Token = "0x4014F33")]
	[FieldOffset(Offset = "0x48")]
	public Transform DressUpDesgar2Pos;

	[Token(Token = "0x4014F34")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject DressUpDesgarMask2;

	[Token(Token = "0x4014F35")]
	[FieldOffset(Offset = "0x50")]
	public GameObject DressUpDesgarMask1;

	[Token(Token = "0x60162F2")]
	[Address(RVA = "0x19D5A30", Offset = "0x19D5A30", VA = "0x19D5A30")]
	public UIEmoteShowPanelView()
	{
	}

	[Token(Token = "0x60162F3")]
	[Address(RVA = "0x19D5A38", Offset = "0x19D5A38", VA = "0x19D5A38", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162F4")]
	[Address(RVA = "0x19D6100", Offset = "0x19D6100", VA = "0x19D6100")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
