using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E2")]
public class UISplashBannerItemCDNView : UIBaseView
{
	[Token(Token = "0x40185CE")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WebViewPanel;

	[Token(Token = "0x40185CF")]
	[FieldOffset(Offset = "0x18")]
	public UISplashBannerItemCDNHelperUtil UISplashBannerItemCDNHelperUtil;

	[Token(Token = "0x40185D0")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x40185D1")]
	[FieldOffset(Offset = "0x20")]
	public UIButton close;

	[Token(Token = "0x40185D2")]
	[FieldOffset(Offset = "0x24")]
	public UINetworkTexture NetworkTextureContent;

	[Token(Token = "0x40185D3")]
	[FieldOffset(Offset = "0x28")]
	public UIButton NetworkTextureContentButton;

	[Token(Token = "0x40185D4")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject EventTrigger;

	[Token(Token = "0x601714C")]
	[Address(RVA = "0x205CC10", Offset = "0x205CC10", VA = "0x205CC10")]
	public UISplashBannerItemCDNView()
	{
	}

	[Token(Token = "0x601714D")]
	[Address(RVA = "0x205CC18", Offset = "0x205CC18", VA = "0x205CC18", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601714E")]
	[Address(RVA = "0x205CFF4", Offset = "0x205CFF4", VA = "0x205CFF4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
