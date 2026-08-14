using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002ABC")]
public class UIRebateCardPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x40106A6")]
	private const uint REDEEM_BTN_DEFAULT_COLOR = 4290380031u;

	[Token(Token = "0x40106A7")]
	private const uint REDEEM_BTN_GREY_COLOR = 2155905279u;

	[Token(Token = "0x40106A8")]
	private const uint REDEEM_BTN_TITLE_GREY_COLOR = 757935615u;

	[Token(Token = "0x40106A9")]
	private const uint REDEEM_BTN_TITLE_DEFAULT_COLOR = 2000686079u;

	[Token(Token = "0x40106AA")]
	[FieldOffset(Offset = "0x48")]
	private UIRebateCardPopupWindowView m_View;

	[Token(Token = "0x40106AB")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelRebateCard m_Model;

	[Token(Token = "0x40106AC")]
	[FieldOffset(Offset = "0x50")]
	private UIRebateCardItemController m_MonthCardItemController;

	[Token(Token = "0x40106AD")]
	[FieldOffset(Offset = "0x54")]
	private UIRebateCardItemController m_WeekCardItemController;

	[Token(Token = "0x40106AE")]
	[FieldOffset(Offset = "0x0")]
	private static Action<Texture> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40106AF")]
	[FieldOffset(Offset = "0x4")]
	private static Action<Texture> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x6011803")]
	[Address(RVA = "0x1E4112C", Offset = "0x1E4112C", VA = "0x1E4112C")]
	public UIRebateCardPopupWindowController()
	{
	}

	[Token(Token = "0x6011804")]
	[Address(RVA = "0x1E41134", Offset = "0x1E41134", VA = "0x1E41134")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011805")]
	[Address(RVA = "0x1E411D8", Offset = "0x1E411D8", VA = "0x1E411D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011806")]
	[Address(RVA = "0x1E41804", Offset = "0x1E41804", VA = "0x1E41804")]
	private void OnGetCDNAD(object[] data)
	{
	}

	[Token(Token = "0x6011807")]
	[Address(RVA = "0x1E41F28", Offset = "0x1E41F28", VA = "0x1E41F28")]
	private void UpdateRebateCards()
	{
	}

	[Token(Token = "0x6011808")]
	[Address(RVA = "0x1E424F8", Offset = "0x1E424F8", VA = "0x1E424F8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011809")]
	[Address(RVA = "0x1E42638", Offset = "0x1E42638", VA = "0x1E42638")]
	private void OnNotifyCheckboxChange()
	{
	}

	[Token(Token = "0x601180A")]
	[Address(RVA = "0x1E41670", Offset = "0x1E41670", VA = "0x1E41670")]
	private void RefreshViewData()
	{
	}

	[Token(Token = "0x601180B")]
	[Address(RVA = "0x1E426EC", Offset = "0x1E426EC", VA = "0x1E426EC", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x601180C")]
	[Address(RVA = "0x1E42780", Offset = "0x1E42780", VA = "0x1E42780", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601180D")]
	[Address(RVA = "0x1E42834", Offset = "0x1E42834", VA = "0x1E42834")]
	private static void _003COnGetCDNAD_003Em__0(Texture nt)
	{
	}

	[Token(Token = "0x601180E")]
	[Address(RVA = "0x1E42914", Offset = "0x1E42914", VA = "0x1E42914")]
	private static void _003COnGetCDNAD_003Em__1(Texture nt)
	{
	}

	[Token(Token = "0x601180F")]
	[Address(RVA = "0x1E429F4", Offset = "0x1E429F4", VA = "0x1E429F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011810")]
	[Address(RVA = "0x1E429FC", Offset = "0x1E429FC", VA = "0x1E429FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
