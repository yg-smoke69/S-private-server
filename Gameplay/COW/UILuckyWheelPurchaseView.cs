using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003860")]
public class UILuckyWheelPurchaseView : UIBaseView
{
	[Token(Token = "0x4017219")]
	[FieldOffset(Offset = "0x14")]
	public UILabel ItemNameLabel;

	[Token(Token = "0x401721A")]
	[FieldOffset(Offset = "0x18")]
	public UILabel purchaseDescLabel;

	[Token(Token = "0x401721B")]
	[FieldOffset(Offset = "0x1C")]
	public Transform ItemContainer;

	[Token(Token = "0x401721C")]
	[FieldOffset(Offset = "0x20")]
	public UIButton GemsPurchaseBtn;

	[Token(Token = "0x401721D")]
	[FieldOffset(Offset = "0x24")]
	public UILabel GemsPrice;

	[Token(Token = "0x401721E")]
	[FieldOffset(Offset = "0x28")]
	public GameObject DiamondVoucherEffect;

	[Token(Token = "0x6016CCB")]
	[Address(RVA = "0x18CD8B0", Offset = "0x18CD8B0", VA = "0x18CD8B0")]
	public UILuckyWheelPurchaseView()
	{
	}

	[Token(Token = "0x6016CCC")]
	[Address(RVA = "0x18CD8B8", Offset = "0x18CD8B8", VA = "0x18CD8B8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CCD")]
	[Address(RVA = "0x18CDC0C", Offset = "0x18CDC0C", VA = "0x18CDC0C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
