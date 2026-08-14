using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200361D")]
public class UIHudCrouchView : UIBaseView
{
	[Token(Token = "0x4015AA6")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnCrouch;

	[Token(Token = "0x4015AA7")]
	[FieldOffset(Offset = "0x18")]
	public UISprite BGCrouch;

	[Token(Token = "0x4015AA8")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite CrouchSprite;

	[Token(Token = "0x4015AA9")]
	[FieldOffset(Offset = "0x20")]
	public UISprite HightlightSpr;

	[Token(Token = "0x6016606")]
	[Address(RVA = "0x13773E0", Offset = "0x13773E0", VA = "0x13773E0")]
	public UIHudCrouchView()
	{
	}

	[Token(Token = "0x6016607")]
	[Address(RVA = "0x13773E8", Offset = "0x13773E8", VA = "0x13773E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016608")]
	[Address(RVA = "0x13776B0", Offset = "0x13776B0", VA = "0x13776B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
