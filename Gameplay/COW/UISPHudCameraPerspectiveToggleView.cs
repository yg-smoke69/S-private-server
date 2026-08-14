using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B8")]
internal class UISPHudCameraPerspectiveToggleView : UIBaseView
{
	[Token(Token = "0x40183E4")]
	[FieldOffset(Offset = "0x14")]
	public UIButton FixedBtn;

	[Token(Token = "0x40183E5")]
	[FieldOffset(Offset = "0x18")]
	public UISprite normal;

	[Token(Token = "0x40183E6")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Normal;

	[Token(Token = "0x40183E7")]
	[FieldOffset(Offset = "0x20")]
	public UISprite Perspective;

	[Token(Token = "0x60170CF")]
	[Address(RVA = "0x1D1AFB8", Offset = "0x1D1AFB8", VA = "0x1D1AFB8")]
	public UISPHudCameraPerspectiveToggleView()
	{
	}

	[Token(Token = "0x60170D0")]
	[Address(RVA = "0x1D1AFC0", Offset = "0x1D1AFC0", VA = "0x1D1AFC0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170D1")]
	[Address(RVA = "0x1D1B1C8", Offset = "0x1D1B1C8", VA = "0x1D1B1C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
