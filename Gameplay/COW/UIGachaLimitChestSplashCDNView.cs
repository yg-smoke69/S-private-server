using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200358B")]
public class UIGachaLimitChestSplashCDNView : UIBaseView
{
	[Token(Token = "0x40154B7")]
	[FieldOffset(Offset = "0x14")]
	public UIPanel WebViewPanel;

	[Token(Token = "0x40154B8")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x40154B9")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton close;

	[Token(Token = "0x40154BA")]
	[FieldOffset(Offset = "0x20")]
	public UINetworkTexture NetworkTextureContent;

	[Token(Token = "0x6016451")]
	[Address(RVA = "0x2E87114", Offset = "0x2E87114", VA = "0x2E87114")]
	public UIGachaLimitChestSplashCDNView()
	{
	}

	[Token(Token = "0x6016452")]
	[Address(RVA = "0x2E8711C", Offset = "0x2E8711C", VA = "0x2E8711C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016453")]
	[Address(RVA = "0x2E873E4", Offset = "0x2E873E4", VA = "0x2E873E4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
