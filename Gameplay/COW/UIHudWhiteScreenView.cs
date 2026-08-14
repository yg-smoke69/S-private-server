using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037E7")]
public class UIHudWhiteScreenView : UIBaseView
{
	[Token(Token = "0x4016AD3")]
	[FieldOffset(Offset = "0x14")]
	public UISprite WhiteSprite;

	[Token(Token = "0x4016AD4")]
	[FieldOffset(Offset = "0x18")]
	public UITexture ScreenTexture;

	[Token(Token = "0x6016B60")]
	[Address(RVA = "0x29418BC", Offset = "0x29418BC", VA = "0x29418BC")]
	public UIHudWhiteScreenView()
	{
	}

	[Token(Token = "0x6016B61")]
	[Address(RVA = "0x29418C4", Offset = "0x29418C4", VA = "0x29418C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016B62")]
	[Address(RVA = "0x2941ACC", Offset = "0x2941ACC", VA = "0x2941ACC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
