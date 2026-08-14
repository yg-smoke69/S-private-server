using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200356C")]
public class UIGachaEnergyBuyBtnView : UIBaseView
{
	[Token(Token = "0x40152BF")]
	[FieldOffset(Offset = "0x14")]
	public UIGachaBuyBtnBaseView UIGachaBuyBtnBaseView;

	[Token(Token = "0x40152C0")]
	[FieldOffset(Offset = "0x18")]
	public UISprite NewsIcon;

	[Token(Token = "0x60163F4")]
	[Address(RVA = "0x2473694", Offset = "0x2473694", VA = "0x2473694")]
	public UIGachaEnergyBuyBtnView()
	{
	}

	[Token(Token = "0x60163F5")]
	[Address(RVA = "0x247369C", Offset = "0x247369C", VA = "0x247369C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163F6")]
	[Address(RVA = "0x24738A4", Offset = "0x24738A4", VA = "0x24738A4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
