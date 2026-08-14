using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003522")]
public class UIEPTaskGuideView : UIBaseView
{
	[Token(Token = "0x4014F92")]
	[FieldOffset(Offset = "0x14")]
	public TweenAlpha AvatarSpr;

	[Token(Token = "0x4014F93")]
	[FieldOffset(Offset = "0x18")]
	public UILabel GuideInfo;

	[Token(Token = "0x4014F94")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton btnNext;

	[Token(Token = "0x4014F95")]
	[FieldOffset(Offset = "0x20")]
	public UIButton btnNext1;

	[Token(Token = "0x4014F96")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EpTaskEntry;

	[Token(Token = "0x4014F97")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Effect_Circle;

	[Token(Token = "0x4014F98")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Effect_Arrow;

	[Token(Token = "0x4014F99")]
	[FieldOffset(Offset = "0x30")]
	public TweenPosition UI_CommonGuide_Arrow;

	[Token(Token = "0x4014F9A")]
	[FieldOffset(Offset = "0x34")]
	public GameObject EpTaskEntryPos;

	[Token(Token = "0x4014F9B")]
	[FieldOffset(Offset = "0x38")]
	public Transform ClickEffect;

	[Token(Token = "0x4014F9C")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton btnEntry;

	[Token(Token = "0x4014F9D")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnBg;

	[Token(Token = "0x6016316")]
	[Address(RVA = "0x2BB1A7C", Offset = "0x2BB1A7C", VA = "0x2BB1A7C")]
	public UIEPTaskGuideView()
	{
	}

	[Token(Token = "0x6016317")]
	[Address(RVA = "0x2BB1A84", Offset = "0x2BB1A84", VA = "0x2BB1A84", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016318")]
	[Address(RVA = "0x2BB1FF4", Offset = "0x2BB1FF4", VA = "0x2BB1FF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
