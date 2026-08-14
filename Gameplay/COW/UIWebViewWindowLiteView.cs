using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A7F")]
public class UIWebViewWindowLiteView : UIBaseView
{
	[Token(Token = "0x4018D9E")]
	[FieldOffset(Offset = "0x14")]
	public UISprite WebViewArea;

	[Token(Token = "0x4018D9F")]
	[FieldOffset(Offset = "0x18")]
	public UIProgressBar WebViewProgressBar;

	[Token(Token = "0x4018DA0")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton CloseButton;

	[Token(Token = "0x6017323")]
	[Address(RVA = "0x1B8042C", Offset = "0x1B8042C", VA = "0x1B8042C")]
	public UIWebViewWindowLiteView()
	{
	}

	[Token(Token = "0x6017324")]
	[Address(RVA = "0x1B80434", Offset = "0x1B80434", VA = "0x1B80434", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017325")]
	[Address(RVA = "0x1B8069C", Offset = "0x1B8069C", VA = "0x1B8069C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
