using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x200262D")]
public abstract class UIGachaBuyBtnController : UIBaseController
{
	[Token(Token = "0x200262E")]
	public enum BuyBtnState
	{
		[Token(Token = "0x400EBC6")]
		STATE_NONE,
		[Token(Token = "0x400EBC7")]
		STATE_BUY_VIA_LIMITFREE,
		[Token(Token = "0x400EBC8")]
		STATE_BUY_VIA_COUPON,
		[Token(Token = "0x400EBC9")]
		STATE_BUY_VIA_CURRENCY
	}

	[Token(Token = "0x200262F")]
	private sealed class _003CUpdateFreeCDLabel_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EBCA")]
		[FieldOffset(Offset = "0x8")]
		internal uint chestID;

		[Token(Token = "0x400EBCB")]
		[FieldOffset(Offset = "0xC")]
		internal UIGachaBuyBtnController _0024this;

		[Token(Token = "0x600E2E3")]
		[Address(RVA = "0x266D710", Offset = "0x266D710", VA = "0x266D710")]
		public _003CUpdateFreeCDLabel_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E2E4")]
		[Address(RVA = "0x266E010", Offset = "0x266E010", VA = "0x266E010")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EBC0")]
	[FieldOffset(Offset = "0x28")]
	protected UIGachaBuyBtnBaseView m_View;

	[Token(Token = "0x400EBC1")]
	[FieldOffset(Offset = "0x2C")]
	protected uint m_CurrentGachaID;

	[Token(Token = "0x400EBC2")]
	[FieldOffset(Offset = "0x30")]
	protected UIModelGacha m_ModelGacha;

	[Token(Token = "0x400EBC3")]
	[FieldOffset(Offset = "0x34")]
	protected bool m_OnEnterPurchase;

	[Token(Token = "0x400EBC4")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600E2BD")]
	[Address(RVA = "0x2666F44", Offset = "0x2666F44", VA = "0x2666F44")]
	protected UIGachaBuyBtnController()
	{
	}

	[Token(Token = "0x600E2BE")]
	protected abstract void InitBuyBtnBaseView();

	[Token(Token = "0x600E2BF")]
	[Address(RVA = "0x2666FC8", Offset = "0x2666FC8", VA = "0x2666FC8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E2C0")]
	[Address(RVA = "0x266726C", Offset = "0x266726C", VA = "0x266726C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E2C1")]
	[Address(RVA = "0x26672D0", Offset = "0x26672D0", VA = "0x26672D0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600E2C2")]
	[Address(RVA = "0x2667388", Offset = "0x2667388", VA = "0x2667388", Slot = "32")]
	public virtual bool OnBeforeSingleBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600E2C3")]
	[Address(RVA = "0x26673EC", Offset = "0x26673EC", VA = "0x26673EC", Slot = "33")]
	public virtual bool OnBeforeMultiBuy(bool isRepurchase)
	{
		return default(bool);
	}

	[Token(Token = "0x600E2C4")]
	[Address(RVA = "0x2667450", Offset = "0x2667450", VA = "0x2667450")]
	public void OnSingleBuy(bool isRepurchase)
	{
	}

	[Token(Token = "0x600E2C5")]
	[Address(RVA = "0x2667988", Offset = "0x2667988", VA = "0x2667988")]
	public void OnMultiBuy(bool isRepurchase)
	{
	}

	[Token(Token = "0x600E2C6")]
	[Address(RVA = "0x2667E78", Offset = "0x2667E78", VA = "0x2667E78")]
	private void OnOneBuyClick()
	{
	}

	[Token(Token = "0x600E2C7")]
	[Address(RVA = "0x26681E4", Offset = "0x26681E4", VA = "0x26681E4")]
	private void OnTenBuyClick()
	{
	}

	[Token(Token = "0x600E2C8")]
	[Address(RVA = "0x2668438", Offset = "0x2668438", VA = "0x2668438")]
	public void RefreshOneBuyBtn(BuyBtnState oneState, uint chestID)
	{
	}

	[Token(Token = "0x600E2C9")]
	[Address(RVA = "0x2669E38", Offset = "0x2669E38", VA = "0x2669E38")]
	public void RefreshTenBuyBtn(BuyBtnState tenState, uint chestID)
	{
	}

	[Token(Token = "0x600E2CA")]
	[Address(RVA = "0x266869C", Offset = "0x266869C", VA = "0x266869C")]
	private void RefreshBuyBtnTip(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600E2CB")]
	[Address(RVA = "0x26690E4", Offset = "0x26690E4", VA = "0x26690E4")]
	private void ResetBuyBtnStats(UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600E2CC")]
	[Address(RVA = "0x2669588", Offset = "0x2669588", VA = "0x2669588")]
	private void ShowBuyViaLimitFreeUI()
	{
	}

	[Token(Token = "0x600E2CD")]
	[Address(RVA = "0x2669740", Offset = "0x2669740", VA = "0x2669740")]
	private void ShowBuyViaCouponUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600E2CE")]
	[Address(RVA = "0x2669B7C", Offset = "0x2669B7C", VA = "0x2669B7C")]
	private void ShowBuyViaCurrencyUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
	{
	}

	[Token(Token = "0x600E2CF")]
	[Address(RVA = "0x266A3A4", Offset = "0x266A3A4", VA = "0x266A3A4", Slot = "34")]
	protected virtual void ShowNormalPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600E2D0")]
	[Address(RVA = "0x266AC3C", Offset = "0x266AC3C", VA = "0x266AC3C", Slot = "35")]
	protected virtual Color GetLimitLabelColor(uint chestID)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Color);
	}

	[Token(Token = "0x600E2D1")]
	[Address(RVA = "0x266AD18", Offset = "0x266AD18", VA = "0x266AD18", Slot = "36")]
	protected virtual void ShowLimitPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type, uint chestID)
	{
	}

	[Token(Token = "0x600E2D2")]
	[Address(RVA = "0x266C85C", Offset = "0x266C85C", VA = "0x266C85C", Slot = "37")]
	protected virtual void ShowDiscountPurchaseUI(GachaDesc desc, UIModelGacha.GachaDrawType type)
	{
	}

	[Token(Token = "0x600E2D3")]
	[Address(RVA = "0x2668A44", Offset = "0x2668A44", VA = "0x2668A44")]
	private void UpdateFreeCDLabel(BuyBtnState oneState, uint chestID)
	{
	}

	[Token(Token = "0x600E2D4")]
	[Address(RVA = "0x266D718", Offset = "0x266D718", VA = "0x266D718")]
	public void DisableOneBtn()
	{
	}

	[Token(Token = "0x600E2D5")]
	[Address(RVA = "0x26677D4", Offset = "0x26677D4", VA = "0x26677D4")]
	public BuyBtnState CalOneBuyBtnState(uint chestID)
	{
		return default(BuyBtnState);
	}

	[Token(Token = "0x600E2D6")]
	[Address(RVA = "0x2667D0C", Offset = "0x2667D0C", VA = "0x2667D0C")]
	public BuyBtnState CalTenBuyBtnState(uint chestID)
	{
		return default(BuyBtnState);
	}

	[Token(Token = "0x600E2D7")]
	[Address(RVA = "0x266D83C", Offset = "0x266D83C", VA = "0x266D83C")]
	public void SetBuyBtnExitPurchaseState()
	{
	}

	[Token(Token = "0x600E2D8")]
	[Address(RVA = "0x266D898", Offset = "0x266D898", VA = "0x266D898")]
	public bool GetBuyBtnPurchaseState()
	{
		return default(bool);
	}

	[Token(Token = "0x600E2D9")]
	[Address(RVA = "0x266D8F0", Offset = "0x266D8F0", VA = "0x266D8F0")]
	public void RefreshBtnState(uint chestID, bool needCheckCurrentGacha = false)
	{
	}

	[Token(Token = "0x600E2DA")]
	[Address(RVA = "0x266DA10", Offset = "0x266DA10", VA = "0x266DA10", Slot = "38")]
	protected virtual void OnRefreshBuyBtn()
	{
	}

	[Token(Token = "0x600E2DB")]
	[Address(RVA = "0x266DA64", Offset = "0x266DA64", VA = "0x266DA64", Slot = "39")]
	public virtual void PurchaseSingle(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	[Token(Token = "0x600E2DC")]
	[Address(RVA = "0x266DD2C", Offset = "0x266DD2C", VA = "0x266DD2C", Slot = "40")]
	public virtual void PurchaseMulti(uint chestID, UIModelGacha.GachaDrawType type, bool isRepurchase = false)
	{
	}

	[Token(Token = "0x600E2DD")]
	[Address(RVA = "0x266DC70", Offset = "0x266DC70", VA = "0x266DC70")]
	protected BuyBtnState GetBuyBtnStateByType(UIModelGacha.GachaDrawType type, uint chestID)
	{
		return default(BuyBtnState);
	}

	[Token(Token = "0x600E2DE")]
	[Address(RVA = "0x26680CC", Offset = "0x26680CC", VA = "0x26680CC")]
	private void PlayPurchaseSound()
	{
	}

	[Token(Token = "0x600E2DF")]
	[Address(RVA = "0x266DF38", Offset = "0x266DF38", VA = "0x266DF38")]
	private static void _003CUpdateFreeCDLabel_003Em__0()
	{
	}

	[Token(Token = "0x600E2E0")]
	[Address(RVA = "0x266DFF8", Offset = "0x266DFF8", VA = "0x266DFF8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E2E1")]
	[Address(RVA = "0x266E000", Offset = "0x266E000", VA = "0x266E000")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E2E2")]
	[Address(RVA = "0x266E008", Offset = "0x266E008", VA = "0x266E008")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
