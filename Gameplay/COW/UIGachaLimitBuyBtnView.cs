using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003584")]
public class UIGachaLimitBuyBtnView : UIBaseView
{
	[Token(Token = "0x4015446")]
	[FieldOffset(Offset = "0x14")]
	public UIGachaBuyBtnBaseView UIGachaBuyBtnBaseView;

	[Token(Token = "0x4015447")]
	[FieldOffset(Offset = "0x18")]
	public GameObject FreeTip;

	[Token(Token = "0x601643C")]
	[Address(RVA = "0x2E767E8", Offset = "0x2E767E8", VA = "0x2E767E8")]
	public UIGachaLimitBuyBtnView()
	{
	}

	[Token(Token = "0x601643D")]
	[Address(RVA = "0x2E767F0", Offset = "0x2E767F0", VA = "0x2E767F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601643E")]
	[Address(RVA = "0x2E769EC", Offset = "0x2E769EC", VA = "0x2E769EC")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
