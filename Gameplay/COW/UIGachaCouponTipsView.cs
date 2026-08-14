using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003569")]
public class UIGachaCouponTipsView : UIBaseView
{
	[Token(Token = "0x4015286")]
	[FieldOffset(Offset = "0x14")]
	public GameObject ItemContainer;

	[Token(Token = "0x4015287")]
	[FieldOffset(Offset = "0x18")]
	public GameObject CountDownContent;

	[Token(Token = "0x4015288")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel GachaCountDownLabel;

	[Token(Token = "0x4015289")]
	[FieldOffset(Offset = "0x20")]
	public UICountDownLabel CountDownTxt;

	[Token(Token = "0x401528A")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UnSelectSprite;

	[Token(Token = "0x401528B")]
	[FieldOffset(Offset = "0x28")]
	public GameObject SelectSprite;

	[Token(Token = "0x401528C")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton ChooseBtn;

	[Token(Token = "0x60163EB")]
	[Address(RVA = "0x2470EA0", Offset = "0x2470EA0", VA = "0x2470EA0")]
	public UIGachaCouponTipsView()
	{
	}

	[Token(Token = "0x60163EC")]
	[Address(RVA = "0x2470EA8", Offset = "0x2470EA8", VA = "0x2470EA8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60163ED")]
	[Address(RVA = "0x2471260", Offset = "0x2471260", VA = "0x2471260")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
