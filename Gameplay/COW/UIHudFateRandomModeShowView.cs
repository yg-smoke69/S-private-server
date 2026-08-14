using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200364F")]
public class UIHudFateRandomModeShowView : UIBaseView
{
	[Token(Token = "0x4015C93")]
	[FieldOffset(Offset = "0x14")]
	public UIEventListener Backdrop;

	[Token(Token = "0x4015C94")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Title;

	[Token(Token = "0x4015C95")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Info;

	[Token(Token = "0x4015C96")]
	[FieldOffset(Offset = "0x20")]
	public UISprite icon;

	[Token(Token = "0x601669A")]
	[Address(RVA = "0x1B9A510", Offset = "0x1B9A510", VA = "0x1B9A510")]
	public UIHudFateRandomModeShowView()
	{
	}

	[Token(Token = "0x601669B")]
	[Address(RVA = "0x1B9A518", Offset = "0x1B9A518", VA = "0x1B9A518", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601669C")]
	[Address(RVA = "0x1B9A7E0", Offset = "0x1B9A7E0", VA = "0x1B9A7E0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
