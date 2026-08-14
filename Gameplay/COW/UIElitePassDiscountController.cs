using System;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20025EB")]
public class UIElitePassDiscountController : UIPopupWindowController
{
	[Token(Token = "0x400EA61")]
	[FieldOffset(Offset = "0x48")]
	private UIElitePassDiscountView m_View;

	[Token(Token = "0x400EA62")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_DelayCallTid;

	[Token(Token = "0x400EA63")]
	[FieldOffset(Offset = "0x50")]
	private uint m_DelayCallSoundTid;

	[Token(Token = "0x400EA64")]
	[FieldOffset(Offset = "0x54")]
	private GameObject m_SoundAudioResource;

	[Token(Token = "0x400EA65")]
	[FieldOffset(Offset = "0x58")]
	private UICountDownController m_CountDownCtrl;

	[Token(Token = "0x400EA66")]
	[FieldOffset(Offset = "0x5C")]
	private uint m_CustomizedDiscount;

	[Token(Token = "0x400EA67")]
	[FieldOffset(Offset = "0x60")]
	private UIModelElitePass m_Model;

	[Token(Token = "0x400EA68")]
	[FieldOffset(Offset = "0x64")]
	private UINavigationUtil.UINavigationElitePassType m_FromType;

	[Token(Token = "0x400EA69")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<AdvertDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600DF80")]
	[Address(RVA = "0x2A530FC", Offset = "0x2A530FC", VA = "0x2A530FC")]
	public UIElitePassDiscountController()
	{
	}

	[Token(Token = "0x600DF81")]
	[Address(RVA = "0x2A53104", Offset = "0x2A53104", VA = "0x2A53104")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DF82")]
	[Address(RVA = "0x2A531AC", Offset = "0x2A531AC", VA = "0x2A531AC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DF83")]
	[Address(RVA = "0x2A53A5C", Offset = "0x2A53A5C", VA = "0x2A53A5C", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DF84")]
	[Address(RVA = "0x2A53CCC", Offset = "0x2A53CCC", VA = "0x2A53CCC")]
	public void SetFromPageType(UINavigationUtil.UINavigationElitePassType type)
	{
	}

	[Token(Token = "0x600DF85")]
	[Address(RVA = "0x2A53D2C", Offset = "0x2A53D2C", VA = "0x2A53D2C")]
	public void SetDiscountCountdown(ulong endTime)
	{
	}

	[Token(Token = "0x600DF86")]
	[Address(RVA = "0x2A537A4", Offset = "0x2A537A4", VA = "0x2A537A4")]
	private void UpdateCDN()
	{
	}

	[Token(Token = "0x600DF87")]
	[Address(RVA = "0x2A53FEC", Offset = "0x2A53FEC", VA = "0x2A53FEC")]
	private void UpdateGetBonusBtn()
	{
	}

	[Token(Token = "0x600DF88")]
	[Address(RVA = "0x2A541EC", Offset = "0x2A541EC", VA = "0x2A541EC")]
	private void OnUpgradeBtnClick()
	{
	}

	[Token(Token = "0x600DF89")]
	[Address(RVA = "0x2A543F4", Offset = "0x2A543F4", VA = "0x2A543F4")]
	private void OnSpinBtnClick()
	{
	}

	[Token(Token = "0x600DF8A")]
	[Address(RVA = "0x2A54918", Offset = "0x2A54918", VA = "0x2A54918")]
	private void StopRotateSoundAndPlayGainSound()
	{
	}

	[Token(Token = "0x600DF8B")]
	[Address(RVA = "0x2A54B08", Offset = "0x2A54B08", VA = "0x2A54B08")]
	private void StopBounsSpin()
	{
	}

	[Token(Token = "0x600DF8C")]
	[Address(RVA = "0x2A54BDC", Offset = "0x2A54BDC", VA = "0x2A54BDC")]
	private void _003CSetDiscountCountdown_003Em__0()
	{
	}

	[Token(Token = "0x600DF8D")]
	[Address(RVA = "0x2A54C80", Offset = "0x2A54C80", VA = "0x2A54C80")]
	private static bool _003CUpdateCDN_003Em__1(AdvertDesc x)
	{
		return default(bool);
	}

	[Token(Token = "0x600DF8E")]
	[Address(RVA = "0x2A54CB0", Offset = "0x2A54CB0", VA = "0x2A54CB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DF8F")]
	[Address(RVA = "0x2A54CB8", Offset = "0x2A54CB8", VA = "0x2A54CB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
