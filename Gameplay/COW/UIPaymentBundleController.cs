using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002A14")]
public class UIPaymentBundleController : UIPaymentController.PaymentTabContentController, _Attribute, IConvertible
{
	[Token(Token = "0x2002A15")]
	private sealed class _003CSetTitles_003Ec__AnonStorey1
	{
		[Token(Token = "0x40102CF")]
		[FieldOffset(Offset = "0x8")]
		internal SpecialStoreDesc title;

		[Token(Token = "0x6011058")]
		[Address(RVA = "0x286C4A4", Offset = "0x286C4A4", VA = "0x286C4A4")]
		public _003CSetTitles_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6011059")]
		[Address(RVA = "0x286E830", Offset = "0x286E830", VA = "0x286E830")]
		internal bool _003C_003Em__0(PayBundleWindowDesc x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002A16")]
	private sealed class _003CDelayResetScrollViewPosition_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40102D0")]
		[FieldOffset(Offset = "0x8")]
		internal UIScrollView scrollView;

		[Token(Token = "0x40102D1")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x40102D2")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x40102D3")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001279")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x601105C")]
			[Address(RVA = "0x286E784", Offset = "0x286E784", VA = "0x286E784", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700127A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601105D")]
			[Address(RVA = "0x286E78C", Offset = "0x286E78C", VA = "0x286E78C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x601105A")]
		[Address(RVA = "0x286E4A8", Offset = "0x286E4A8", VA = "0x286E4A8")]
		public _003CDelayResetScrollViewPosition_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x601105B")]
		[Address(RVA = "0x286E6F0", Offset = "0x286E6F0", VA = "0x286E6F0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601105E")]
		[Address(RVA = "0x286E794", Offset = "0x286E794", VA = "0x286E794", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601105F")]
		[Address(RVA = "0x286E7A8", Offset = "0x286E7A8", VA = "0x286E7A8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40102C7")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentBundleView m_View;

	[Token(Token = "0x40102C8")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x40102C9")]
	[FieldOffset(Offset = "0x30")]
	private bool m_ForceRefresh;

	[Token(Token = "0x40102CA")]
	[FieldOffset(Offset = "0x34")]
	private EStore.PbwActivityType m_SelectedStoreType;

	[Token(Token = "0x40102CB")]
	[FieldOffset(Offset = "0x38")]
	private List<UIPaymentBundleItemController> m_BundleItems;

	[Token(Token = "0x40102CC")]
	[FieldOffset(Offset = "0x3C")]
	private Dictionary<uint, UIPaymentBundleTopItemController> m_Titles;

	[Token(Token = "0x40102CD")]
	[FieldOffset(Offset = "0x40")]
	private Coroutine m_DelayResetScrollViewPosition;

	[Token(Token = "0x40102CE")]
	[FieldOffset(Offset = "0x0")]
	private static Comparison<PayBundleWindowDesc> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6011042")]
	[Address(RVA = "0x286AE48", Offset = "0x286AE48", VA = "0x286AE48")]
	public UIPaymentBundleController()
	{
	}

	[Token(Token = "0x6011043")]
	[Address(RVA = "0x286AF04", Offset = "0x286AF04", VA = "0x286AF04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011044")]
	[Address(RVA = "0x286AFAC", Offset = "0x286AFAC", VA = "0x286AFAC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011045")]
	[Address(RVA = "0x286BDEC", Offset = "0x286BDEC", VA = "0x286BDEC", Slot = "31")]
	public override void GotoByParams(UIPaymentController.PaymentGotoParams parameters)
	{
	}

	[Token(Token = "0x6011046")]
	[Address(RVA = "0x286BEE4", Offset = "0x286BEE4", VA = "0x286BEE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011047")]
	[Address(RVA = "0x286C0E4", Offset = "0x286C0E4", VA = "0x286C0E4", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x6011048")]
	[Address(RVA = "0x286C19C", Offset = "0x286C19C", VA = "0x286C19C", Slot = "35")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011049")]
	[Address(RVA = "0x286C288", Offset = "0x286C288", VA = "0x286C288", Slot = "34")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x601104A")]
	[Address(RVA = "0x286C3AC", Offset = "0x286C3AC", VA = "0x286C3AC")]
	private void OnResetTimerFinished()
	{
	}

	[Token(Token = "0x601104B")]
	[Address(RVA = "0x286C440", Offset = "0x286C440", VA = "0x286C440", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x601104C")]
	[Address(RVA = "0x286B20C", Offset = "0x286B20C", VA = "0x286B20C")]
	private void SetTitles(EStore.PbwActivityType type = EStore.PbwActivityType.PbwActivityType_NONE)
	{
	}

	[Token(Token = "0x601104D")]
	[Address(RVA = "0x286CB7C", Offset = "0x286CB7C", VA = "0x286CB7C")]
	private void OnSpecialStoreClicked(EStore.PbwActivityType type)
	{
	}

	[Token(Token = "0x601104E")]
	[Address(RVA = "0x286D64C", Offset = "0x286D64C", VA = "0x286D64C")]
	private void SetBundles(EStore.PbwActivityType type)
	{
	}

	[Token(Token = "0x601104F")]
	[Address(RVA = "0x286E3D4", Offset = "0x286E3D4", VA = "0x286E3D4")]
	private IEnumerator DelayResetScrollViewPosition(UIScrollView scrollView)
	{
		return null;
	}

	[Token(Token = "0x6011050")]
	[Address(RVA = "0x286E4B0", Offset = "0x286E4B0", VA = "0x286E4B0", Slot = "36")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6011051")]
	[Address(RVA = "0x286E5A8", Offset = "0x286E5A8", VA = "0x286E5A8", Slot = "37")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x6011052")]
	[Address(RVA = "0x286E624", Offset = "0x286E624", VA = "0x286E624")]
	private static int _003CSetBundles_003Em__0(PayBundleWindowDesc a, PayBundleWindowDesc b)
	{
		return default(int);
	}

	[Token(Token = "0x6011053")]
	[Address(RVA = "0x286E6D0", Offset = "0x286E6D0", VA = "0x286E6D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011054")]
	[Address(RVA = "0x286E6D8", Offset = "0x286E6D8", VA = "0x286E6D8")]
	public void _003C_003EiFixBaseProxy_GotoByParams(UIPaymentController.PaymentGotoParams P0)
	{
	}

	[Token(Token = "0x6011055")]
	[Address(RVA = "0x286E6DC", Offset = "0x286E6DC", VA = "0x286E6DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011056")]
	[Address(RVA = "0x286E6E4", Offset = "0x286E6E4", VA = "0x286E6E4")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6011057")]
	[Address(RVA = "0x286E6EC", Offset = "0x286E6EC", VA = "0x286E6EC")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
