using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035BB")]
public class UIHDLobbyIAPBundleView : UIBaseView
{
	[Token(Token = "0x401581A")]
	[FieldOffset(Offset = "0x14")]
	public UIButton IAPBundleButton;

	[Token(Token = "0x401581B")]
	[FieldOffset(Offset = "0x18")]
	public UICountDownLabel CountdownLabel;

	[Token(Token = "0x401581C")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite IconSpriteBG;

	[Token(Token = "0x60164DF")]
	[Address(RVA = "0x202E198", Offset = "0x202E198", VA = "0x202E198")]
	public UIHDLobbyIAPBundleView()
	{
	}

	[Token(Token = "0x60164E0")]
	[Address(RVA = "0x202E1A0", Offset = "0x202E1A0", VA = "0x202E1A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60164E1")]
	[Address(RVA = "0x202E408", Offset = "0x202E408", VA = "0x202E408")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
