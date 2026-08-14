using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200383F")]
public class UILobbyIAPBundleView : UIBaseView
{
	[Token(Token = "0x4016F8F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton IAPBundleButton;

	[Token(Token = "0x4016F90")]
	[FieldOffset(Offset = "0x18")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x4016F91")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite IconSpriteBG;

	[Token(Token = "0x6016C68")]
	[Address(RVA = "0xDB393C", Offset = "0xDB393C", VA = "0xDB393C")]
	public UILobbyIAPBundleView()
	{
	}

	[Token(Token = "0x6016C69")]
	[Address(RVA = "0xDB3944", Offset = "0xDB3944", VA = "0xDB3944", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016C6A")]
	[Address(RVA = "0xDB3BAC", Offset = "0xDB3BAC", VA = "0xDB3BAC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
