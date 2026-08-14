using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025C5")]
public class UIDebrisPurchaseController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400E9AF")]
	[FieldOffset(Offset = "0x48")]
	private UIDebrisPurchaseView m_View;

	[Token(Token = "0x400E9B0")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelMall m_ModelMall;

	[Token(Token = "0x400E9B1")]
	[FieldOffset(Offset = "0x50")]
	private int m_NextLevelDebrisPurchaseCnt;

	[Token(Token = "0x400E9B2")]
	[FieldOffset(Offset = "0x54")]
	private int m_DebrisPurchaseCnt;

	[Token(Token = "0x400E9B3")]
	[FieldOffset(Offset = "0x58")]
	private uint m_PriceCoin;

	[Token(Token = "0x400E9B4")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_PriceGem;

	[Token(Token = "0x400E9B5")]
	[FieldOffset(Offset = "0x60")]
	private uint m_Interval;

	[Token(Token = "0x400E9B6")]
	[FieldOffset(Offset = "0x64")]
	private uint m_ItemID;

	[Token(Token = "0x400E9B7")]
	[FieldOffset(Offset = "0x68")]
	private int m_TotalPriceForVoucher;

	[Token(Token = "0x400E9B8")]
	[FieldOffset(Offset = "0x6C")]
	private EInventory.CurrencyType m_VoucherCurrencyType;

	[Token(Token = "0x400E9B9")]
	[FieldOffset(Offset = "0x70")]
	protected VoucherData m_VoucherData;

	[Token(Token = "0x400E9BA")]
	[FieldOffset(Offset = "0x74")]
	protected UIVoucherController m_VoucherCtrl;

	[Token(Token = "0x400E9BB")]
	[FieldOffset(Offset = "0x78")]
	protected bool m_InputExceedNotify;

	[Token(Token = "0x600DDDE")]
	[Address(RVA = "0x11F222C", Offset = "0x11F222C", VA = "0x11F222C")]
	public UIDebrisPurchaseController()
	{
	}

	[Token(Token = "0x600DDDF")]
	[Address(RVA = "0x11F223C", Offset = "0x11F223C", VA = "0x11F223C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DDE0")]
	[Address(RVA = "0x11F22E0", Offset = "0x11F22E0", VA = "0x11F22E0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DDE1")]
	[Address(RVA = "0x11F2758", Offset = "0x11F2758", VA = "0x11F2758")]
	private void OnPlusBtnClick()
	{
	}

	[Token(Token = "0x600DDE2")]
	[Address(RVA = "0x11F28A4", Offset = "0x11F28A4", VA = "0x11F28A4")]
	private void OnMinusBtnClick()
	{
	}

	[Token(Token = "0x600DDE3")]
	[Address(RVA = "0x11F2924", Offset = "0x11F2924", VA = "0x11F2924")]
	private void OnMaxBtnClick()
	{
	}

	[Token(Token = "0x600DDE4")]
	[Address(RVA = "0x11F2994", Offset = "0x11F2994", VA = "0x11F2994")]
	public void InitView(int cnt)
	{
	}

	[Token(Token = "0x600DDE5")]
	[Address(RVA = "0x11F2B78", Offset = "0x11F2B78", VA = "0x11F2B78")]
	private void ShowVoucher()
	{
	}

	[Token(Token = "0x600DDE6")]
	[Address(RVA = "0x11F27DC", Offset = "0x11F27DC", VA = "0x11F27DC")]
	public void RefreshSliderInfo()
	{
	}

	[Token(Token = "0x600DDE7")]
	[Address(RVA = "0x11F2F8C", Offset = "0x11F2F8C", VA = "0x11F2F8C")]
	private void RefreshCurDebrisInfo()
	{
	}

	[Token(Token = "0x600DDE8")]
	[Address(RVA = "0x11F2CD0", Offset = "0x11F2CD0", VA = "0x11F2CD0")]
	private void RefreshPriceBtnState()
	{
	}

	[Token(Token = "0x600DDE9")]
	[Address(RVA = "0x11F3160", Offset = "0x11F3160", VA = "0x11F3160")]
	private void RefreshPrice()
	{
	}

	[Token(Token = "0x600DDEA")]
	[Address(RVA = "0x11F33A8", Offset = "0x11F33A8", VA = "0x11F33A8")]
	private void SetPriceLabelText(int price)
	{
	}

	[Token(Token = "0x600DDEB")]
	[Address(RVA = "0x11F34C0", Offset = "0x11F34C0", VA = "0x11F34C0")]
	private void OnCoinBtnClick()
	{
	}

	[Token(Token = "0x600DDEC")]
	[Address(RVA = "0x11F3698", Offset = "0x11F3698", VA = "0x11F3698")]
	private void OnGemBtnClick()
	{
	}

	[Token(Token = "0x600DDED")]
	[Address(RVA = "0x11F2C60", Offset = "0x11F2C60", VA = "0x11F2C60")]
	private int CalcTotalPriceForVoucher()
	{
		return default(int);
	}

	[Token(Token = "0x600DDEE")]
	[Address(RVA = "0x11F329C", Offset = "0x11F329C", VA = "0x11F329C")]
	private void RefreshVoucherCtrlTotalPrice()
	{
	}

	[Token(Token = "0x600DDEF")]
	[Address(RVA = "0x11F362C", Offset = "0x11F362C", VA = "0x11F362C")]
	private uint GetVoucherID()
	{
		return default(uint);
	}

	[Token(Token = "0x600DDF0")]
	[Address(RVA = "0x11F3800", Offset = "0x11F3800", VA = "0x11F3800", Slot = "46")]
	public UIVoucherController OpenVoucherController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DDF1")]
	[Address(RVA = "0x11F38FC", Offset = "0x11F38FC", VA = "0x11F38FC", Slot = "48")]
	public UIVoucherItemController OpenVoucherItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600DDF2")]
	[Address(RVA = "0x11F39F4", Offset = "0x11F39F4", VA = "0x11F39F4", Slot = "47")]
	public void OnVoucherItemClick(object[] data)
	{
	}

	[Token(Token = "0x600DDF3")]
	[Address(RVA = "0x11F2A1C", Offset = "0x11F2A1C", VA = "0x11F2A1C")]
	private void RefreshView()
	{
	}

	[Token(Token = "0x600DDF4")]
	[Address(RVA = "0x11F3BA8", Offset = "0x11F3BA8", VA = "0x11F3BA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
