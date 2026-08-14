using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003568")]
public class UIGachaCouponExpireInfoView : UIBaseView
{
	[Token(Token = "0x4015281")]
	[FieldOffset(Offset = "0x14")]
	public UIGrid ItemGrid;

	[Token(Token = "0x4015282")]
	[FieldOffset(Offset = "0x18")]
	public UIEasyList ItemEasyList;

	[Token(Token = "0x4015283")]
	[FieldOffset(Offset = "0x1C")]
	public UIButton GoToBtn;

	[Token(Token = "0x4015284")]
	[FieldOffset(Offset = "0x20")]
	public UISprite BtnBG;

	[Token(Token = "0x4015285")]
	[FieldOffset(Offset = "0x24")]
	public UIToggle ToggleTOS;

	[Token(Token = "0x60163E8")]
	[Address(RVA = "0x2470048", Offset = "0x2470048", VA = "0x2470048")]
	public UIGachaCouponExpireInfoView()
	{
	}

	[Token(Token = "0x60163E9")]
	[Address(RVA = "0x2470050", Offset = "0x2470050", VA = "0x2470050", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163EA")]
	[Address(RVA = "0x2470378", Offset = "0x2470378", VA = "0x2470378")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
