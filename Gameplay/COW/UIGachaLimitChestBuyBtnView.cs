using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003585")]
public class UIGachaLimitChestBuyBtnView : UIBaseView
{
	[Token(Token = "0x4015448")]
	[FieldOffset(Offset = "0x14")]
	public UIGachaBuyBtnBaseView UIGachaBuyBtnBaseView;

	[Token(Token = "0x4015449")]
	[FieldOffset(Offset = "0x18")]
	public GameObject FreeTip;

	[Token(Token = "0x401544A")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Label;

	[Token(Token = "0x601643F")]
	[Address(RVA = "0x2E77030", Offset = "0x2E77030", VA = "0x2E77030")]
	public UIGachaLimitChestBuyBtnView()
	{
	}

	[Token(Token = "0x6016440")]
	[Address(RVA = "0x2E77038", Offset = "0x2E77038", VA = "0x2E77038", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016441")]
	[Address(RVA = "0x2E77294", Offset = "0x2E77294", VA = "0x2E77294")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
