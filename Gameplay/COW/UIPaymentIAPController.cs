using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A30")]
public class UIPaymentIAPController : UIPaymentController.PaymentTabContentController, _Attribute, IConvertible
{
	[Token(Token = "0x2002A31")]
	private enum EBonusState
	{
		[Token(Token = "0x401037E")]
		NoBonusEvent,
		[Token(Token = "0x401037F")]
		NotSpin,
		[Token(Token = "0x4010380")]
		HasBonusTimes,
		[Token(Token = "0x4010381")]
		BonusTimesOver
	}

	[Token(Token = "0x4010370")]
	private const string MYSTERYBONUSSPINKEY = "MYSTERYBONUSSPINKEY_{0}";

	[Token(Token = "0x4010371")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentIAPView m_View;

	[Token(Token = "0x4010372")]
	[FieldOffset(Offset = "0x2C")]
	private UICenterOnChild m_CenterOnChild;

	[Token(Token = "0x4010373")]
	[FieldOffset(Offset = "0x30")]
	private UIModelPayment m_ModelPayment;

	[Token(Token = "0x4010374")]
	[FieldOffset(Offset = "0x34")]
	private EBonusState m_BonusState;

	[Token(Token = "0x4010375")]
	[FieldOffset(Offset = "0x38")]
	private string m_ProductIdentifier;

	[Token(Token = "0x4010376")]
	[FieldOffset(Offset = "0x3C")]
	private List<UIPayItemController> _PayItemControllerList;

	[Token(Token = "0x4010377")]
	[FieldOffset(Offset = "0x40")]
	private List<AdvertDesc> m_CdnAds;

	[Token(Token = "0x4010378")]
	[FieldOffset(Offset = "0x44")]
	private List<UIPaymentIAPCDNItemController> m_CDNAdItems;

	[Token(Token = "0x4010379")]
	[FieldOffset(Offset = "0x48")]
	private List<UILobbyDotController> m_CDNAdDots;

	[Token(Token = "0x401037A")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CDNAdIndex;

	[Token(Token = "0x401037B")]
	[FieldOffset(Offset = "0x50")]
	private uint m_AutoScrollDelayCallID;

	[Token(Token = "0x401037C")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<MysteryBonusProbability> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011120")]
	[Address(RVA = "0x29D3224", Offset = "0x29D3224", VA = "0x29D3224")]
	public UIPaymentIAPController()
	{
	}

	[Token(Token = "0x6011121")]
	[Address(RVA = "0x29D339C", Offset = "0x29D339C", VA = "0x29D339C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011122")]
	[Address(RVA = "0x29D3444", Offset = "0x29D3444", VA = "0x29D3444", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011123")]
	[Address(RVA = "0x29D3A34", Offset = "0x29D3A34", VA = "0x29D3A34", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x6011124")]
	[Address(RVA = "0x29D4010", Offset = "0x29D4010", VA = "0x29D4010", Slot = "36")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6011125")]
	[Address(RVA = "0x29D3E74", Offset = "0x29D3E74", VA = "0x29D3E74")]
	private void UpdatePaymentActivityRedDot()
	{
	}

	[Token(Token = "0x6011126")]
	[Address(RVA = "0x29D40A0", Offset = "0x29D40A0", VA = "0x29D40A0")]
	private void OnBtnPaymentActivityClick()
	{
	}

	[Token(Token = "0x6011127")]
	[Address(RVA = "0x29D4314", Offset = "0x29D4314", VA = "0x29D4314", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6011128")]
	[Address(RVA = "0x29D4714", Offset = "0x29D4714", VA = "0x29D4714", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011129")]
	[Address(RVA = "0x29D4948", Offset = "0x29D4948", VA = "0x29D4948")]
	private void OnBtnProbabilityTipsClick()
	{
	}

	[Token(Token = "0x601112A")]
	[Address(RVA = "0x29D49C0", Offset = "0x29D49C0", VA = "0x29D49C0")]
	private void ClearPayItemControllers()
	{
	}

	[Token(Token = "0x601112B")]
	[Address(RVA = "0x29D4B90", Offset = "0x29D4B90", VA = "0x29D4B90")]
	private void RefreshCdnAds()
	{
	}

	[Token(Token = "0x601112C")]
	[Address(RVA = "0x29D4FC8", Offset = "0x29D4FC8", VA = "0x29D4FC8")]
	private void RefreshCdnAdsUI()
	{
	}

	[Token(Token = "0x601112D")]
	[Address(RVA = "0x29D5B3C", Offset = "0x29D5B3C", VA = "0x29D5B3C")]
	private void OnCDNAdItemsAutoScroll()
	{
	}

	[Token(Token = "0x601112E")]
	[Address(RVA = "0x29D5D10", Offset = "0x29D5D10", VA = "0x29D5D10")]
	private void GetCdnAdsCenterItem(GameObject centerGo)
	{
	}

	[Token(Token = "0x601112F")]
	[Address(RVA = "0x29D5F6C", Offset = "0x29D5F6C", VA = "0x29D5F6C")]
	private void RefreshProbabilityButtonState()
	{
	}

	[Token(Token = "0x6011130")]
	[Address(RVA = "0x29D3BC8", Offset = "0x29D3BC8", VA = "0x29D3BC8")]
	private void RefreshPayItemControllers()
	{
	}

	[Token(Token = "0x6011131")]
	[Address(RVA = "0x29D60D4", Offset = "0x29D60D4", VA = "0x29D60D4")]
	private void OnPayItemClick(object[] parameters)
	{
	}

	[Token(Token = "0x6011132")]
	[Address(RVA = "0x29D6668", Offset = "0x29D6668", VA = "0x29D6668")]
	private void OnSpinBtnClick()
	{
	}

	[Token(Token = "0x6011133")]
	[Address(RVA = "0x29D6778", Offset = "0x29D6778", VA = "0x29D6778")]
	private void OnSpinWndConfirm(object[] parameters)
	{
	}

	[Token(Token = "0x6011134")]
	[Address(RVA = "0x29D69B0", Offset = "0x29D69B0", VA = "0x29D69B0", Slot = "34")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011135")]
	[Address(RVA = "0x29D76E8", Offset = "0x29D76E8", VA = "0x29D76E8", Slot = "35")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011136")]
	[Address(RVA = "0x29D6BD0", Offset = "0x29D6BD0", VA = "0x29D6BD0")]
	private void SetBonusState()
	{
	}

	[Token(Token = "0x6011137")]
	[Address(RVA = "0x29D6CE4", Offset = "0x29D6CE4", VA = "0x29D6CE4")]
	private void RefreshBonusView()
	{
	}

	[Token(Token = "0x6011138")]
	[Address(RVA = "0x29D4380", Offset = "0x29D4380", VA = "0x29D4380")]
	public void TryPopBonusWindow()
	{
	}

	[Token(Token = "0x6011139")]
	[Address(RVA = "0x29D7988", Offset = "0x29D7988", VA = "0x29D7988")]
	private void RefreshBonusCountDownTime()
	{
	}

	[Token(Token = "0x601113A")]
	[Address(RVA = "0x29D7CC8", Offset = "0x29D7CC8", VA = "0x29D7CC8")]
	private void RefreshBonusViewByHasBonusTimesState()
	{
	}

	[Token(Token = "0x601113B")]
	[Address(RVA = "0x29D7780", Offset = "0x29D7780", VA = "0x29D7780")]
	private void ResetBonusWidget()
	{
	}

	[Token(Token = "0x601113C")]
	[Address(RVA = "0x29D6EEC", Offset = "0x29D6EEC", VA = "0x29D6EEC")]
	private void ShowProbabilityTips(List<MysteryBonusProbability> probabilities)
	{
	}

	[Token(Token = "0x601113D")]
	[Address(RVA = "0x29D80A4", Offset = "0x29D80A4", VA = "0x29D80A4")]
	private static int _003CShowProbabilityTips_003Em__0(MysteryBonusProbability a, MysteryBonusProbability b)
	{
		return default(int);
	}

	[Token(Token = "0x601113E")]
	[Address(RVA = "0x29D80EC", Offset = "0x29D80EC", VA = "0x29D80EC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601113F")]
	[Address(RVA = "0x29D80F4", Offset = "0x29D80F4", VA = "0x29D80F4")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}

	[Token(Token = "0x6011140")]
	[Address(RVA = "0x29D80FC", Offset = "0x29D80FC", VA = "0x29D80FC")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6011141")]
	[Address(RVA = "0x29D8104", Offset = "0x29D8104", VA = "0x29D8104")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
