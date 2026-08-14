using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200386B")]
public class UIMallCrystalItemView : UIBaseView
{
	[Token(Token = "0x40172B8")]
	[FieldOffset(Offset = "0x14")]
	public UIButton UIMallCrystalItem;

	[Token(Token = "0x40172B9")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Default;

	[Token(Token = "0x40172BA")]
	[FieldOffset(Offset = "0x1C")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x40172BB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject HighLightBG;

	[Token(Token = "0x40172BC")]
	[FieldOffset(Offset = "0x24")]
	public GameObject UniquedTitle;

	[Token(Token = "0x40172BD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ExchangeContainer;

	[Token(Token = "0x40172BE")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel ExchangePriceLabel;

	[Token(Token = "0x40172BF")]
	[FieldOffset(Offset = "0x30")]
	public UISprite ExchangeIcon;

	[Token(Token = "0x6016CEC")]
	[Address(RVA = "0x23A5B94", Offset = "0x23A5B94", VA = "0x23A5B94")]
	public UIMallCrystalItemView()
	{
	}

	[Token(Token = "0x6016CED")]
	[Address(RVA = "0x23A5B9C", Offset = "0x23A5B9C", VA = "0x23A5B9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016CEE")]
	[Address(RVA = "0x23A5FB4", Offset = "0x23A5FB4", VA = "0x23A5FB4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
