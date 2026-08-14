using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200360C")]
public class UIHudChangeSeatView : UIBaseView
{
	[Token(Token = "0x4015A10")]
	[FieldOffset(Offset = "0x14")]
	public UIButton Button;

	[Token(Token = "0x4015A11")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CDMask;

	[Token(Token = "0x4015A12")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite ButtonIcon;

	[Token(Token = "0x4015A13")]
	[FieldOffset(Offset = "0x20")]
	public UIProgressBar ProgressBarCD;

	[Token(Token = "0x4015A14")]
	[FieldOffset(Offset = "0x24")]
	public UIProgressBar ProgressConfirmationCD;

	[Token(Token = "0x4015A15")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ConfirmEffectGO;

	[Token(Token = "0x4015A16")]
	[FieldOffset(Offset = "0x2C")]
	public TweenScale CDTween;

	[Token(Token = "0x60165D2")]
	[Address(RVA = "0x214CF4C", Offset = "0x214CF4C", VA = "0x214CF4C")]
	public UIHudChangeSeatView()
	{
	}

	[Token(Token = "0x60165D3")]
	[Address(RVA = "0x214CF54", Offset = "0x214CF54", VA = "0x214CF54", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60165D4")]
	[Address(RVA = "0x214D324", Offset = "0x214D324", VA = "0x214D324")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
