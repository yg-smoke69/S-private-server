using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003A6A")]
internal class UIVoucherItemView : UIBaseView
{
	[Token(Token = "0x4018C4F")]
	[FieldOffset(Offset = "0x14")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018C50")]
	[FieldOffset(Offset = "0x18")]
	public UIWidget Container;

	[Token(Token = "0x4018C51")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel PriceLabel;

	[Token(Token = "0x4018C52")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLight;

	[Token(Token = "0x60172E4")]
	[Address(RVA = "0x101A368", Offset = "0x101A368", VA = "0x101A368")]
	public UIVoucherItemView()
	{
	}

	[Token(Token = "0x60172E5")]
	[Address(RVA = "0x101A370", Offset = "0x101A370", VA = "0x101A370", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60172E6")]
	[Address(RVA = "0x101A578", Offset = "0x101A578", VA = "0x101A578")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
