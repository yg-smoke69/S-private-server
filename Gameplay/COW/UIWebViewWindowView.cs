using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A80")]
public class UIWebViewWindowView : UIBaseView
{
	[Token(Token = "0x4018DA1")]
	[FieldOffset(Offset = "0x14")]
	public UISprite WebViewArea;

	[Token(Token = "0x4018DA2")]
	[FieldOffset(Offset = "0x18")]
	public UILabel ProgressLabel;

	[Token(Token = "0x4018DA3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LoadingGIF;

	[Token(Token = "0x4018DA4")]
	[FieldOffset(Offset = "0x20")]
	public UIProgressBar WebViewProgressBar;

	[Token(Token = "0x4018DA5")]
	[FieldOffset(Offset = "0x24")]
	public UIWidget WebViewProgressBarThumb;

	[Token(Token = "0x4018DA6")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CloseButton;

	[Token(Token = "0x4018DA7")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ExternalButton;

	[Token(Token = "0x4018DA8")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ReloadButton;

	[Token(Token = "0x4018DA9")]
	[FieldOffset(Offset = "0x34")]
	public GameObject ReloadTips;

	[Token(Token = "0x4018DAA")]
	[FieldOffset(Offset = "0x38")]
	public UILabel ReloadLabel;

	[Token(Token = "0x6017326")]
	[Address(RVA = "0x1B806A4", Offset = "0x1B806A4", VA = "0x1B806A4")]
	public UIWebViewWindowView()
	{
	}

	[Token(Token = "0x6017327")]
	[Address(RVA = "0x1B806AC", Offset = "0x1B806AC", VA = "0x1B806AC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017328")]
	[Address(RVA = "0x1B80B9C", Offset = "0x1B80B9C", VA = "0x1B80B9C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
