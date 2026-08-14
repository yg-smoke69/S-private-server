using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200366B")]
public class UIHudGrenadeSubBtnView : UIBaseView
{
	[Token(Token = "0x4015D77")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnGrenade;

	[Token(Token = "0x4015D78")]
	[FieldOffset(Offset = "0x18")]
	public UISprite icon;

	[Token(Token = "0x4015D79")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel count;

	[Token(Token = "0x60166EE")]
	[Address(RVA = "0x133B39C", Offset = "0x133B39C", VA = "0x133B39C")]
	public UIHudGrenadeSubBtnView()
	{
	}

	[Token(Token = "0x60166EF")]
	[Address(RVA = "0x133B3A4", Offset = "0x133B3A4", VA = "0x133B3A4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60166F0")]
	[Address(RVA = "0x133B60C", Offset = "0x133B60C", VA = "0x133B60C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
