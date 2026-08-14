using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A1A")]
public class UITutorialWebViewView : UIBaseView
{
	[Token(Token = "0x4018887")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WebViewWindow;

	[Token(Token = "0x4018888")]
	[FieldOffset(Offset = "0x18")]
	public UISprite WebViewArea;

	[Token(Token = "0x60171F4")]
	[Address(RVA = "0x2B7E4EC", Offset = "0x2B7E4EC", VA = "0x2B7E4EC")]
	public UITutorialWebViewView()
	{
	}

	[Token(Token = "0x60171F5")]
	[Address(RVA = "0x2B7E4F4", Offset = "0x2B7E4F4", VA = "0x2B7E4F4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60171F6")]
	[Address(RVA = "0x2B7E6FC", Offset = "0x2B7E6FC", VA = "0x2B7E6FC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
