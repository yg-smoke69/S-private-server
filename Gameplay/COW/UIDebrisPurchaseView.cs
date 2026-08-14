using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034B0")]
public class UIDebrisPurchaseView : UIBaseView
{
	[Token(Token = "0x40149BA")]
	[FieldOffset(Offset = "0x14")]
	public UISprite ItemIcon;

	[Token(Token = "0x40149BB")]
	[FieldOffset(Offset = "0x18")]
	public UISprite QualityBg;

	[Token(Token = "0x40149BC")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite Quality;

	[Token(Token = "0x40149BD")]
	[FieldOffset(Offset = "0x20")]
	public UILabel orLabel;

	[Token(Token = "0x40149BE")]
	[FieldOffset(Offset = "0x24")]
	public UITable PurchaseTable;

	[Token(Token = "0x40149BF")]
	[FieldOffset(Offset = "0x28")]
	public UIButton CoinButton;

	[Token(Token = "0x40149C0")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel CoinCount;

	[Token(Token = "0x40149C1")]
	[FieldOffset(Offset = "0x30")]
	public UIButton GemButton;

	[Token(Token = "0x40149C2")]
	[FieldOffset(Offset = "0x34")]
	public UILabel GemCount;

	[Token(Token = "0x40149C3")]
	[FieldOffset(Offset = "0x38")]
	public GameObject VouchderObj;

	[Token(Token = "0x40149C4")]
	[FieldOffset(Offset = "0x3C")]
	public UIVoucher Voucher;

	[Token(Token = "0x40149C5")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ModifyNumContainer;

	[Token(Token = "0x40149C6")]
	[FieldOffset(Offset = "0x44")]
	public UIButton minusBtn;

	[Token(Token = "0x40149C7")]
	[FieldOffset(Offset = "0x48")]
	public UILabel CurrentShowlabel;

	[Token(Token = "0x40149C8")]
	[FieldOffset(Offset = "0x4C")]
	public UIInput CountInput;

	[Token(Token = "0x40149C9")]
	[FieldOffset(Offset = "0x50")]
	public UIButton plusBtn;

	[Token(Token = "0x40149CA")]
	[FieldOffset(Offset = "0x54")]
	public UIButton maxBtn;

	[Token(Token = "0x60161C4")]
	[Address(RVA = "0x11F3BB0", Offset = "0x11F3BB0", VA = "0x11F3BB0")]
	public UIDebrisPurchaseView()
	{
	}

	[Token(Token = "0x60161C5")]
	[Address(RVA = "0x11F3BB8", Offset = "0x11F3BB8", VA = "0x11F3BB8", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x60161C6")]
	[Address(RVA = "0x11F4348", Offset = "0x11F4348", VA = "0x11F4348")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
