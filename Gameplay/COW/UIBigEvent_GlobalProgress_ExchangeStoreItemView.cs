using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20033ED")]
public class UIBigEvent_GlobalProgress_ExchangeStoreItemView : UIBaseView
{
	[Token(Token = "0x4013F85")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Unlock;

	[Token(Token = "0x4013F86")]
	[FieldOffset(Offset = "0x18")]
	public UIButton PurchaseBtn;

	[Token(Token = "0x4013F87")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite BtnBG;

	[Token(Token = "0x4013F88")]
	[FieldOffset(Offset = "0x20")]
	public UILabel CostNum;

	[Token(Token = "0x4013F89")]
	[FieldOffset(Offset = "0x24")]
	public UISprite CurrencyIcon;

	[Token(Token = "0x4013F8A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LimitedNum;

	[Token(Token = "0x4013F8B")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject SellOut;

	[Token(Token = "0x4013F8C")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Owned;

	[Token(Token = "0x4013F8D")]
	[FieldOffset(Offset = "0x34")]
	public UIButton BtnLock;

	[Token(Token = "0x4013F8E")]
	[FieldOffset(Offset = "0x38")]
	public Transform ItemContainer;

	[Token(Token = "0x4013F8F")]
	[FieldOffset(Offset = "0x3C")]
	public UINetworkTexture StoreItemBGCDN;

	[Token(Token = "0x4013F90")]
	[FieldOffset(Offset = "0x40")]
	public GameObject PurchaseBtnLimitPos;

	[Token(Token = "0x4013F91")]
	[FieldOffset(Offset = "0x44")]
	public GameObject PurchaseBtnNoLimitPos;

	[Token(Token = "0x4013F92")]
	[FieldOffset(Offset = "0x48")]
	public GameObject RedTips;

	[Token(Token = "0x6015F7B")]
	[Address(RVA = "0x30264C4", Offset = "0x30264C4", VA = "0x30264C4")]
	public UIBigEvent_GlobalProgress_ExchangeStoreItemView()
	{
	}

	[Token(Token = "0x6015F7C")]
	[Address(RVA = "0x30264CC", Offset = "0x30264CC", VA = "0x30264CC", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015F7D")]
	[Address(RVA = "0x3026AE4", Offset = "0x3026AE4", VA = "0x3026AE4")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
