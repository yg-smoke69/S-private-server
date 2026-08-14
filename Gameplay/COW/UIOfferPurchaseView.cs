using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038DC")]
public class UIOfferPurchaseView : UIBaseView
{
	[Token(Token = "0x4017979")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Name;

	[Token(Token = "0x401797A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Desc;

	[Token(Token = "0x401797B")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ItemContainer;

	[Token(Token = "0x401797C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x401797D")]
	[FieldOffset(Offset = "0x24")]
	public UIButton CloseBtn;

	[Token(Token = "0x401797E")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Price;

	[Token(Token = "0x401797F")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel BasePrice;

	[Token(Token = "0x4017980")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Discount;

	[Token(Token = "0x6016E3D")]
	[Address(RVA = "0x159E540", Offset = "0x159E540", VA = "0x159E540")]
	public UIOfferPurchaseView()
	{
	}

	[Token(Token = "0x6016E3E")]
	[Address(RVA = "0x159E548", Offset = "0x159E548", VA = "0x159E548", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016E3F")]
	[Address(RVA = "0x159E984", Offset = "0x159E984", VA = "0x159E984")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
