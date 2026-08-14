using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002685")]
public class UILegendDrawAnimPopWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x2002686")]
	private sealed class _003CRefreshEasyListView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EDCC")]
		[FieldOffset(Offset = "0x8")]
		internal List<GachaShowItem> lotteriesSorted;

		[Token(Token = "0x600E741")]
		[Address(RVA = "0x25462A0", Offset = "0x25462A0", VA = "0x25462A0")]
		public _003CRefreshEasyListView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E742")]
		[Address(RVA = "0x2546970", Offset = "0x2546970", VA = "0x2546970")]
		internal bool _003C_003Em__0(BaseItemInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400EDC3")]
	[FieldOffset(Offset = "0x48")]
	private uint m_GachaID;

	[Token(Token = "0x400EDC4")]
	[FieldOffset(Offset = "0x4C")]
	private uint m_DelayCallID;

	[Token(Token = "0x400EDC5")]
	[FieldOffset(Offset = "0x50")]
	private int m_ListCount;

	[Token(Token = "0x400EDC6")]
	[FieldOffset(Offset = "0x54")]
	private float m_TotalTime;

	[Token(Token = "0x400EDC7")]
	[FieldOffset(Offset = "0x58")]
	private float m_StayTimeAfterAnimEnd;

	[Token(Token = "0x400EDC8")]
	[FieldOffset(Offset = "0x5C")]
	private UILegendDrawAnimPopWindowView m_View;

	[Token(Token = "0x400EDC9")]
	[FieldOffset(Offset = "0x60")]
	private UIModelGacha m_Model;

	[Token(Token = "0x400EDCA")]
	[FieldOffset(Offset = "0x64")]
	private int m_TargetIndex;

	[Token(Token = "0x400EDCB")]
	[FieldOffset(Offset = "0x68")]
	private List<BaseItemInfo> gachaShowItems;

	[Token(Token = "0x600E732")]
	[Address(RVA = "0x2545090", Offset = "0x2545090", VA = "0x2545090")]
	public UILegendDrawAnimPopWindowController()
	{
	}

	[Token(Token = "0x600E733")]
	[Address(RVA = "0x2545134", Offset = "0x2545134", VA = "0x2545134")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E734")]
	[Address(RVA = "0x25451D8", Offset = "0x25451D8", VA = "0x25451D8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E735")]
	[Address(RVA = "0x2545408", Offset = "0x2545408", VA = "0x2545408", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600E736")]
	[Address(RVA = "0x2545570", Offset = "0x2545570", VA = "0x2545570")]
	public void SetGachaID(uint gachaID)
	{
	}

	[Token(Token = "0x600E737")]
	[Address(RVA = "0x25455E4", Offset = "0x25455E4", VA = "0x25455E4")]
	private void RefreshEasyListView()
	{
	}

	[Token(Token = "0x600E738")]
	[Address(RVA = "0x2545E70", Offset = "0x2545E70", VA = "0x2545E70")]
	private void DOScroll()
	{
	}

	[Token(Token = "0x600E739")]
	[Address(RVA = "0x25462A8", Offset = "0x25462A8", VA = "0x25462A8")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x600E73A")]
	[Address(RVA = "0x254659C", Offset = "0x254659C", VA = "0x254659C", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600E73B")]
	[Address(RVA = "0x2546618", Offset = "0x2546618", VA = "0x2546618", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E73C")]
	[Address(RVA = "0x25467B0", Offset = "0x25467B0", VA = "0x25467B0", Slot = "41")]
	public override bool IgnoreEsc()
	{
		return default(bool);
	}

	[Token(Token = "0x600E73D")]
	[Address(RVA = "0x2546808", Offset = "0x2546808", VA = "0x2546808")]
	private void _003COnFinished_003Em__0()
	{
	}

	[Token(Token = "0x600E73E")]
	[Address(RVA = "0x2546958", Offset = "0x2546958", VA = "0x2546958")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E73F")]
	[Address(RVA = "0x2546960", Offset = "0x2546960", VA = "0x2546960")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x600E740")]
	[Address(RVA = "0x2546968", Offset = "0x2546968", VA = "0x2546968")]
	public bool _003C_003EiFixBaseProxy_IgnoreEsc()
	{
		return default(bool);
	}
}
