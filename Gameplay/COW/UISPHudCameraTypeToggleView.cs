using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B9")]
internal class UISPHudCameraTypeToggleView : UIBaseView
{
	[Token(Token = "0x40183E8")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SwitchBtn;

	[Token(Token = "0x40183E9")]
	[FieldOffset(Offset = "0x18")]
	public UISprite normal;

	[Token(Token = "0x40183EA")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite FixedCamera;

	[Token(Token = "0x40183EB")]
	[FieldOffset(Offset = "0x20")]
	public UISprite FreeCamera;

	[Token(Token = "0x60170D2")]
	[Address(RVA = "0x1D1B254", Offset = "0x1D1B254", VA = "0x1D1B254")]
	public UISPHudCameraTypeToggleView()
	{
	}

	[Token(Token = "0x60170D3")]
	[Address(RVA = "0x1D1B25C", Offset = "0x1D1B25C", VA = "0x1D1B25C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170D4")]
	[Address(RVA = "0x1D1B464", Offset = "0x1D1B464", VA = "0x1D1B464")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
