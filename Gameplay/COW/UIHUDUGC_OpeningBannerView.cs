using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20037A2")]
public class UIHUDUGC_OpeningBannerView : UIBaseView
{
	[Token(Token = "0x4016888")]
	[FieldOffset(Offset = "0x14")]
	public UILabel IntroKey;

	[Token(Token = "0x4016889")]
	[FieldOffset(Offset = "0x18")]
	public UILabel IntroDetail;

	[Token(Token = "0x401688A")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x401688B")]
	[FieldOffset(Offset = "0x20")]
	public Transform Bg;

	[Token(Token = "0x6016A91")]
	[Address(RVA = "0x2E21A8C", Offset = "0x2E21A8C", VA = "0x2E21A8C")]
	public UIHUDUGC_OpeningBannerView()
	{
	}

	[Token(Token = "0x6016A92")]
	[Address(RVA = "0x2E21A94", Offset = "0x2E21A94", VA = "0x2E21A94", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A93")]
	[Address(RVA = "0x2E21D34", Offset = "0x2E21D34", VA = "0x2E21D34")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
