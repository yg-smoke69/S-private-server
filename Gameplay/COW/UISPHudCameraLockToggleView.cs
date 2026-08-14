using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20039B7")]
internal class UISPHudCameraLockToggleView : UIBaseView
{
	[Token(Token = "0x40183E0")]
	[FieldOffset(Offset = "0x14")]
	public UIButton FixedBtn;

	[Token(Token = "0x40183E1")]
	[FieldOffset(Offset = "0x18")]
	public UISprite normal;

	[Token(Token = "0x40183E2")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite LockCamera;

	[Token(Token = "0x40183E3")]
	[FieldOffset(Offset = "0x20")]
	public UISprite UnlockCamera;

	[Token(Token = "0x60170CC")]
	[Address(RVA = "0x1D1A59C", Offset = "0x1D1A59C", VA = "0x1D1A59C")]
	public UISPHudCameraLockToggleView()
	{
	}

	[Token(Token = "0x60170CD")]
	[Address(RVA = "0x1D1A5A4", Offset = "0x1D1A5A4", VA = "0x1D1A5A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60170CE")]
	[Address(RVA = "0x1D1A7AC", Offset = "0x1D1A7AC", VA = "0x1D1A7AC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
