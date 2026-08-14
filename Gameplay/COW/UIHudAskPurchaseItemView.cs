using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20035D8")]
public class UIHudAskPurchaseItemView : UIBaseView
{
	[Token(Token = "0x40158E2")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Name;

	[Token(Token = "0x40158E3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Index;

	[Token(Token = "0x40158E4")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Icon;

	[Token(Token = "0x40158E5")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Finish;

	[Token(Token = "0x40158E6")]
	[FieldOffset(Offset = "0x24")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x40158E7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject PriceGroup;

	[Token(Token = "0x40158E8")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Price;

	[Token(Token = "0x40158E9")]
	[FieldOffset(Offset = "0x30")]
	public UISprite CoinIcon;

	[Token(Token = "0x40158EA")]
	[FieldOffset(Offset = "0x34")]
	public UILabel buyUserIndex;

	[Token(Token = "0x40158EB")]
	[FieldOffset(Offset = "0x38")]
	public GameObject ReplacerTip;

	[Token(Token = "0x6016536")]
	[Address(RVA = "0x1709934", Offset = "0x1709934", VA = "0x1709934")]
	public UIHudAskPurchaseItemView()
	{
	}

	[Token(Token = "0x6016537")]
	[Address(RVA = "0x170993C", Offset = "0x170993C", VA = "0x170993C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016538")]
	[Address(RVA = "0x1709E20", Offset = "0x1709E20", VA = "0x1709E20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
