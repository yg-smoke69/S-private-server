using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003888")]
public class UIManualWebViewView : UIBaseView
{
	[Token(Token = "0x4017522")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WebViewWindow;

	[Token(Token = "0x4017523")]
	[FieldOffset(Offset = "0x18")]
	public UISprite Window;

	[Token(Token = "0x4017524")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Buttons;

	[Token(Token = "0x4017525")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CloseButton;

	[Token(Token = "0x4017526")]
	[FieldOffset(Offset = "0x24")]
	public UISprite WebViewArea;

	[Token(Token = "0x4017527")]
	[FieldOffset(Offset = "0x28")]
	public UIProgressBar WebViewProgressBar;

	[Token(Token = "0x4017528")]
	[FieldOffset(Offset = "0x2C")]
	public UIWidget WebViewProgressBarThumb;

	[Token(Token = "0x6016D43")]
	[Address(RVA = "0x1239FD4", Offset = "0x1239FD4", VA = "0x1239FD4")]
	public UIManualWebViewView()
	{
	}

	[Token(Token = "0x6016D44")]
	[Address(RVA = "0x1239FDC", Offset = "0x1239FDC", VA = "0x1239FDC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016D45")]
	[Address(RVA = "0x123A3C4", Offset = "0x123A3C4", VA = "0x123A3C4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
