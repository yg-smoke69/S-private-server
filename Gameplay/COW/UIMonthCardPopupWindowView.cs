using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20038B5")]
public class UIMonthCardPopupWindowView : UIBaseView
{
	[Token(Token = "0x4017747")]
	[FieldOffset(Offset = "0x14")]
	public UIButton BtnClose;

	[Token(Token = "0x4017748")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BuyInfoContainer;

	[Token(Token = "0x4017749")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelRemainingDay;

	[Token(Token = "0x401774A")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnRedeem;

	[Token(Token = "0x401774B")]
	[FieldOffset(Offset = "0x24")]
	public GameObject EffectRedeem;

	[Token(Token = "0x401774C")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelRedeemTitle;

	[Token(Token = "0x401774D")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite RedeemBtnBG;

	[Token(Token = "0x401774E")]
	[FieldOffset(Offset = "0x30")]
	public GameObject DiamondIcon;

	[Token(Token = "0x401774F")]
	[FieldOffset(Offset = "0x34")]
	public GameObject CoinsIcon;

	[Token(Token = "0x4017750")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelRedeemAmount;

	[Token(Token = "0x4017751")]
	[FieldOffset(Offset = "0x3C")]
	public UICountDownLabel LabelTimeCount;

	[Token(Token = "0x4017752")]
	[FieldOffset(Offset = "0x40")]
	public UIButton BtnPurchase;

	[Token(Token = "0x4017753")]
	[FieldOffset(Offset = "0x44")]
	public UISprite PurchaseBtnBG;

	[Token(Token = "0x4017754")]
	[FieldOffset(Offset = "0x48")]
	public UILabel LabelPrice;

	[Token(Token = "0x4017755")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel LabelPurchaseHint;

	[Token(Token = "0x4017756")]
	[FieldOffset(Offset = "0x50")]
	public UILabel LabelMonthCardDesc0;

	[Token(Token = "0x4017757")]
	[FieldOffset(Offset = "0x54")]
	public UILabel LabelMonthCardDesc1;

	[Token(Token = "0x4017758")]
	[FieldOffset(Offset = "0x58")]
	public UILabel LabelMonthCardDesc2;

	[Token(Token = "0x4017759")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel LabelResetHint;

	[Token(Token = "0x401775A")]
	[FieldOffset(Offset = "0x60")]
	public GameObject LoadingContainer;

	[Token(Token = "0x6016DCA")]
	[Address(RVA = "0x194EF94", Offset = "0x194EF94", VA = "0x194EF94")]
	public UIMonthCardPopupWindowView()
	{
	}

	[Token(Token = "0x6016DCB")]
	[Address(RVA = "0x194EF9C", Offset = "0x194EF9C", VA = "0x194EF9C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016DCC")]
	[Address(RVA = "0x194F828", Offset = "0x194F828", VA = "0x194F828")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
