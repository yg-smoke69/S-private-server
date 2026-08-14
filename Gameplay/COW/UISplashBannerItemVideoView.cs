using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039E4")]
public class UISplashBannerItemVideoView : UIBaseView
{
	[Token(Token = "0x40185E5")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WebViewPanel;

	[Token(Token = "0x40185E6")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Content;

	[Token(Token = "0x40185E7")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Title;

	[Token(Token = "0x40185E8")]
	[FieldOffset(Offset = "0x20")]
	public UIButton CloseBtn;

	[Token(Token = "0x40185E9")]
	[FieldOffset(Offset = "0x24")]
	public UISprite WebViewArea;

	[Token(Token = "0x40185EA")]
	[FieldOffset(Offset = "0x28")]
	public UIButton GotoBtn;

	[Token(Token = "0x6017152")]
	[Address(RVA = "0x205F7E4", Offset = "0x205F7E4", VA = "0x205F7E4")]
	public UISplashBannerItemVideoView()
	{
	}

	[Token(Token = "0x6017153")]
	[Address(RVA = "0x205F7EC", Offset = "0x205F7EC", VA = "0x205F7EC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6017154")]
	[Address(RVA = "0x205FB68", Offset = "0x205FB68", VA = "0x205FB68")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
