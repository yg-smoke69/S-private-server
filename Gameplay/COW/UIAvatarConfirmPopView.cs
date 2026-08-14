using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033C5")]
public class UIAvatarConfirmPopView : UIBaseView
{
	[Token(Token = "0x4013CAD")]
	[FieldOffset(Offset = "0x14")]
	public GameObject PopType1;

	[Token(Token = "0x4013CAE")]
	[FieldOffset(Offset = "0x18")]
	public UIButton CancelBtn;

	[Token(Token = "0x4013CAF")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Tips1;

	[Token(Token = "0x4013CB0")]
	[FieldOffset(Offset = "0x20")]
	public UIButton LevelUpBtn;

	[Token(Token = "0x4013CB1")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PopType2;

	[Token(Token = "0x4013CB2")]
	[FieldOffset(Offset = "0x28")]
	public UILabel Newtips1;

	[Token(Token = "0x4013CB3")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel NewTips2;

	[Token(Token = "0x4013CB4")]
	[FieldOffset(Offset = "0x30")]
	public Transform ItemContainer;

	[Token(Token = "0x4013CB5")]
	[FieldOffset(Offset = "0x34")]
	public UIButton GoldPurchaseBtn;

	[Token(Token = "0x4013CB6")]
	[FieldOffset(Offset = "0x38")]
	public UILabel GoldPrice;

	[Token(Token = "0x4013CB7")]
	[FieldOffset(Offset = "0x3C")]
	public UILabel GemsPrice;

	[Token(Token = "0x4013CB8")]
	[FieldOffset(Offset = "0x40")]
	public UIButton GemsPurchaseBtn;

	[Token(Token = "0x4013CB9")]
	[FieldOffset(Offset = "0x44")]
	public GameObject GoldAndGems;

	[Token(Token = "0x4013CBA")]
	[FieldOffset(Offset = "0x48")]
	public UIButton DualCurrencyGoldPurchaseBtn;

	[Token(Token = "0x4013CBB")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton DualCurrencyGemsPurchaseBtn;

	[Token(Token = "0x4013CBC")]
	[FieldOffset(Offset = "0x50")]
	public UILabel DualCurrencyGoldPrice;

	[Token(Token = "0x4013CBD")]
	[FieldOffset(Offset = "0x54")]
	public UILabel DualCurrencyGemsPrice;

	[Token(Token = "0x6015F05")]
	[Address(RVA = "0x2A7E3BC", Offset = "0x2A7E3BC", VA = "0x2A7E3BC")]
	public UIAvatarConfirmPopView()
	{
	}

	[Token(Token = "0x6015F06")]
	[Address(RVA = "0x2A7E3C4", Offset = "0x2A7E3C4", VA = "0x2A7E3C4", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F07")]
	[Address(RVA = "0x2A7EB20", Offset = "0x2A7EB20", VA = "0x2A7EB20")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
