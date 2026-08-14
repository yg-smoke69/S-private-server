using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E3")]
public class UISplashBannerItemLiveTVView : UIBaseView
{
	[Token(Token = "0x40185D5")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WebViewPanel;

	[Token(Token = "0x40185D6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Container;

	[Token(Token = "0x40185D7")]
	[FieldOffset(Offset = "0x1C")]
	public TweenScale ScaleTween;

	[Token(Token = "0x40185D8")]
	[FieldOffset(Offset = "0x20")]
	public TweenPosition PosTween;

	[Token(Token = "0x40185D9")]
	[FieldOffset(Offset = "0x24")]
	public UIPanel ContainerPanel;

	[Token(Token = "0x40185DA")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Title;

	[Token(Token = "0x40185DB")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BG;

	[Token(Token = "0x40185DC")]
	[FieldOffset(Offset = "0x30")]
	public UINetworkTexture NetworkTextureBG;

	[Token(Token = "0x40185DD")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Content;

	[Token(Token = "0x40185DE")]
	[FieldOffset(Offset = "0x38")]
	public UIButton LiveCloseBtn;

	[Token(Token = "0x40185DF")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton DetailBtn;

	[Token(Token = "0x40185E0")]
	[FieldOffset(Offset = "0x40")]
	public UISprite DetailBtnWidget;

	[Token(Token = "0x40185E1")]
	[FieldOffset(Offset = "0x44")]
	public UIButton FullScreenPlayBtn;

	[Token(Token = "0x40185E2")]
	[FieldOffset(Offset = "0x48")]
	public UISprite FullScreenBtnWidget;

	[Token(Token = "0x40185E3")]
	[FieldOffset(Offset = "0x4C")]
	public UITexture LiveWebViewWidget;

	[Token(Token = "0x40185E4")]
	[FieldOffset(Offset = "0x50")]
	public UINetworkTexture liveBgTexture;

	[Token(Token = "0x601714F")]
	[Address(RVA = "0x205E604", Offset = "0x205E604", VA = "0x205E604")]
	public UISplashBannerItemLiveTVView()
	{
	}

	[Token(Token = "0x6017150")]
	[Address(RVA = "0x205E60C", Offset = "0x205E60C", VA = "0x205E60C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017151")]
	[Address(RVA = "0x205ED3C", Offset = "0x205ED3C", VA = "0x205ED3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
