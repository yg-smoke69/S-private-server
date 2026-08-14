using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003487")]
public class UICommonTweenTipsView : UIBaseView
{
	[Token(Token = "0x4014724")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel TipsPanel;

	[Token(Token = "0x4014725")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget ParentContainer;

	[Token(Token = "0x4014726")]
	[FieldOffset(Offset = "0x1C")]
	public TweenPosition ParentTP;

	[Token(Token = "0x4014727")]
	[FieldOffset(Offset = "0x20")]
	public Animation anim;

	[Token(Token = "0x4014728")]
	[FieldOffset(Offset = "0x24")]
	public UISprite alphaSprite;

	[Token(Token = "0x4014729")]
	[FieldOffset(Offset = "0x28")]
	public UILabel TipTxt;

	[Token(Token = "0x401472A")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Bg;

	[Token(Token = "0x6016149")]
	[Address(RVA = "0x1EBDCEC", Offset = "0x1EBDCEC", VA = "0x1EBDCEC")]
	public UICommonTweenTipsView()
	{
	}

	[Token(Token = "0x601614A")]
	[Address(RVA = "0x1EBDCF4", Offset = "0x1EBDCF4", VA = "0x1EBDCF4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601614B")]
	[Address(RVA = "0x1EBE0DC", Offset = "0x1EBE0DC", VA = "0x1EBE0DC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
