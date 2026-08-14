using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200378B")]
public class UIHudTweenTipsView : UIBaseView
{
	[Token(Token = "0x4016818")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget anchor;

	[Token(Token = "0x4016819")]
	[FieldOffset(Offset = "0x18")]
	public UIPanel LabelPanel;

	[Token(Token = "0x401681A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Message;

	[Token(Token = "0x401681B")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Messageshow;

	[Token(Token = "0x401681C")]
	[FieldOffset(Offset = "0x24")]
	public UISprite Icon;

	[Token(Token = "0x401681D")]
	[FieldOffset(Offset = "0x28")]
	public UISprite Bg;

	[Token(Token = "0x401681E")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite Decoration01;

	[Token(Token = "0x401681F")]
	[FieldOffset(Offset = "0x30")]
	public UISprite Decoration02;

	[Token(Token = "0x6016A4C")]
	[Address(RVA = "0x1594418", Offset = "0x1594418", VA = "0x1594418")]
	public UIHudTweenTipsView()
	{
	}

	[Token(Token = "0x6016A4D")]
	[Address(RVA = "0x1594420", Offset = "0x1594420", VA = "0x1594420", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A4E")]
	[Address(RVA = "0x1594868", Offset = "0x1594868", VA = "0x1594868")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
