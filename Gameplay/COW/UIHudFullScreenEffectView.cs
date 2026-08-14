using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200365B")]
public class UIHudFullScreenEffectView : UIBaseView
{
	[Token(Token = "0x4015D13")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Sprite;

	[Token(Token = "0x4015D14")]
	[FieldOffset(Offset = "0x18")]
	public TweenAlpha TweenAlpha;

	[Token(Token = "0x60166BE")]
	[Address(RVA = "0x1887520", Offset = "0x1887520", VA = "0x1887520")]
	public UIHudFullScreenEffectView()
	{
	}

	[Token(Token = "0x60166BF")]
	[Address(RVA = "0x1887528", Offset = "0x1887528", VA = "0x1887528", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166C0")]
	[Address(RVA = "0x1887730", Offset = "0x1887730", VA = "0x1887730")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
