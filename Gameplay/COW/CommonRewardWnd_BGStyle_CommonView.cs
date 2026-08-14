using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003379")]
public class CommonRewardWnd_BGStyle_CommonView : UIBaseView
{
	[Token(Token = "0x4013995")]
	[FieldOffset(Offset = "0x14")]
	public UILabel TitleLabel;

	[Token(Token = "0x4013996")]
	[FieldOffset(Offset = "0x18")]
	public GameObject VFX;

	[Token(Token = "0x4013997")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid BtnGroup;

	[Token(Token = "0x4013998")]
	[FieldOffset(Offset = "0x20")]
	public UIButton RepurchaseBtn;

	[Token(Token = "0x4013999")]
	[FieldOffset(Offset = "0x24")]
	public UILabel RepurchaseLabel;

	[Token(Token = "0x401399A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel FreeLabel;

	[Token(Token = "0x401399B")]
	[FieldOffset(Offset = "0x2C")]
	public UICountDownIcon CountDownIcon;

	[Token(Token = "0x401399C")]
	[FieldOffset(Offset = "0x30")]
	public UICountDownLabel GachaCountDownLabel;

	[Token(Token = "0x401399D")]
	[FieldOffset(Offset = "0x34")]
	public UISprite CurrencyIcon;

	[Token(Token = "0x401399E")]
	[FieldOffset(Offset = "0x38")]
	public UILabel CurrencyCountLabel;

	[Token(Token = "0x401399F")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton OKBtn;

	[Token(Token = "0x40139A0")]
	[FieldOffset(Offset = "0x40")]
	public UIButton CancelBtn;

	[Token(Token = "0x40139A1")]
	[FieldOffset(Offset = "0x44")]
	public UIButton OpenBtn;

	[Token(Token = "0x40139A2")]
	[FieldOffset(Offset = "0x48")]
	public UIButton FastEquipBtn;

	[Token(Token = "0x40139A3")]
	[FieldOffset(Offset = "0x4C")]
	public UIButton ChooseBtn;

	[Token(Token = "0x40139A4")]
	[FieldOffset(Offset = "0x50")]
	public GameObject VoucherGroup;

	[Token(Token = "0x40139A5")]
	[FieldOffset(Offset = "0x54")]
	public UIButton ExchangeBtn;

	[Token(Token = "0x40139A6")]
	[FieldOffset(Offset = "0x58")]
	public UILabel TotalVourcherCntLabel;

	[Token(Token = "0x40139A7")]
	[FieldOffset(Offset = "0x5C")]
	public UILabel CurVoucherCntLabel;

	[Token(Token = "0x40139A8")]
	[FieldOffset(Offset = "0x60")]
	public UISprite VoucherIcon;

	[Token(Token = "0x6015E22")]
	[Address(RVA = "0x173D830", Offset = "0x173D830", VA = "0x173D830")]
	public CommonRewardWnd_BGStyle_CommonView()
	{
	}

	[Token(Token = "0x6015E23")]
	[Address(RVA = "0x173D838", Offset = "0x173D838", VA = "0x173D838", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E24")]
	[Address(RVA = "0x173E0E8", Offset = "0x173E0E8", VA = "0x173E0E8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
