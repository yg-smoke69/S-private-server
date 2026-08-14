using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003513")]
public class UIEmoteDressUpExchangeItemView : UIBaseView
{
	[Token(Token = "0x4014F0E")]
	[FieldOffset(Offset = "0x14")]
	public UIButton SlotBtn;

	[Token(Token = "0x4014F0F")]
	[FieldOffset(Offset = "0x18")]
	public UISprite dresssprite;

	[Token(Token = "0x4014F10")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel SlotId;

	[Token(Token = "0x60162E9")]
	[Address(RVA = "0x19D25E0", Offset = "0x19D25E0", VA = "0x19D25E0")]
	public UIEmoteDressUpExchangeItemView()
	{
	}

	[Token(Token = "0x60162EA")]
	[Address(RVA = "0x19D25E8", Offset = "0x19D25E8", VA = "0x19D25E8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60162EB")]
	[Address(RVA = "0x19D2850", Offset = "0x19D2850", VA = "0x19D2850")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
