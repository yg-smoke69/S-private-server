using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003577")]
public class UIGachaLegendaryBuyBtnView : UIBaseView
{
	[Token(Token = "0x4015355")]
	[FieldOffset(Offset = "0x14")]
	public UIGachaBuyBtnBaseView UIGachaBuyBtnBaseView;

	[Token(Token = "0x4015356")]
	[FieldOffset(Offset = "0x18")]
	public UISprite NewsIcon;

	[Token(Token = "0x6016415")]
	[Address(RVA = "0x248CA2C", Offset = "0x248CA2C", VA = "0x248CA2C")]
	public UIGachaLegendaryBuyBtnView()
	{
	}

	[Token(Token = "0x6016416")]
	[Address(RVA = "0x248CA34", Offset = "0x248CA34", VA = "0x248CA34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016417")]
	[Address(RVA = "0x248CC3C", Offset = "0x248CC3C", VA = "0x248CC3C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
