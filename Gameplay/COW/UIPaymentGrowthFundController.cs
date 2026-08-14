using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002A2C")]
public class UIPaymentGrowthFundController : UIPaymentController.PaymentTabContentController, _Attribute
{
	[Token(Token = "0x2002A2D")]
	private sealed class _003COnEnableRoutine_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010363")]
		[FieldOffset(Offset = "0x8")]
		internal UIPaymentGrowthFundController _0024this;

		[Token(Token = "0x4010364")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x4010365")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x4010366")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001282")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011107")]
			[Address(RVA = "0x29D03D4", Offset = "0x29D03D4", VA = "0x29D03D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001283")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011108")]
			[Address(RVA = "0x29D03DC", Offset = "0x29D03DC", VA = "0x29D03DC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011105")]
		[Address(RVA = "0x29D02E8", Offset = "0x29D02E8", VA = "0x29D02E8")]
		public _003COnEnableRoutine_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011106")]
		[Address(RVA = "0x29D02F0", Offset = "0x29D02F0", VA = "0x29D02F0", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6011109")]
		[Address(RVA = "0x29D03E4", Offset = "0x29D03E4", VA = "0x29D03E4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601110A")]
		[Address(RVA = "0x29D03F8", Offset = "0x29D03F8", VA = "0x29D03F8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401035F")]
	[FieldOffset(Offset = "0x28")]
	private UIPaymentGrowthFundView m_View;

	[Token(Token = "0x4010360")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelPayment m_Payment;

	[Token(Token = "0x4010361")]
	[FieldOffset(Offset = "0x30")]
	private List<UIPaymentGrowthFundItemController> m_Items;

	[Token(Token = "0x4010362")]
	[FieldOffset(Offset = "0x34")]
	private bool m_LastPurchaseState;

	[Token(Token = "0x60110F1")]
	[Address(RVA = "0x2889BA8", Offset = "0x2889BA8", VA = "0x2889BA8")]
	public UIPaymentGrowthFundController()
	{
	}

	[Token(Token = "0x60110F2")]
	[Address(RVA = "0x2889C30", Offset = "0x2889C30", VA = "0x2889C30")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60110F3")]
	[Address(RVA = "0x2889CD8", Offset = "0x2889CD8", VA = "0x2889CD8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60110F4")]
	[Address(RVA = "0x288A088", Offset = "0x288A088", VA = "0x288A088", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60110F5")]
	[Address(RVA = "0x288A288", Offset = "0x288A288", VA = "0x288A288", Slot = "21")]
	public override void Show()
	{
	}

	[Token(Token = "0x60110F6")]
	[Address(RVA = "0x288A340", Offset = "0x288A340", VA = "0x288A340", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x60110F7")]
	[Address(RVA = "0x288A3F8", Offset = "0x288A3F8", VA = "0x288A3F8")]
	private void OnClickHint()
	{
	}

	[Token(Token = "0x60110F8")]
	[Address(RVA = "0x288A640", Offset = "0x288A640", VA = "0x288A640")]
	private void OnClickPurchase()
	{
	}

	[Token(Token = "0x60110F9")]
	[Address(RVA = "0x288A6E8", Offset = "0x288A6E8", VA = "0x288A6E8", Slot = "35")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60110FA")]
	[Address(RVA = "0x288A7D4", Offset = "0x288A7D4", VA = "0x288A7D4", Slot = "34")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60110FB")]
	[Address(RVA = "0x288A9F0", Offset = "0x288A9F0", VA = "0x288A9F0", Slot = "32")]
	public override void RefreshContent()
	{
	}

	[Token(Token = "0x60110FC")]
	[Address(RVA = "0x288A928", Offset = "0x288A928", VA = "0x288A928")]
	private void ShowEffect()
	{
	}

	[Token(Token = "0x60110FD")]
	[Address(RVA = "0x288C6E4", Offset = "0x288C6E4", VA = "0x288C6E4")]
	private void ScrollToFirstNotClaimedItem()
	{
	}

	[Token(Token = "0x60110FE")]
	[Address(RVA = "0x288CE24", Offset = "0x288CE24", VA = "0x288CE24")]
	private IEnumerator OnEnableRoutine()
	{
		return null;
	}

	[Token(Token = "0x60110FF")]
	[Address(RVA = "0x288CEF0", Offset = "0x288CEF0", VA = "0x288CEF0")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6011100")]
	[Address(RVA = "0x288CF60", Offset = "0x288CF60", VA = "0x288CF60")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011101")]
	[Address(RVA = "0x288CF68", Offset = "0x288CF68", VA = "0x288CF68")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x6011102")]
	[Address(RVA = "0x288CF70", Offset = "0x288CF70", VA = "0x288CF70")]
	public void _003C_003EiFixBaseProxy_Show()
	{
	}

	[Token(Token = "0x6011103")]
	[Address(RVA = "0x288CF78", Offset = "0x288CF78", VA = "0x288CF78")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}

	[Token(Token = "0x6011104")]
	[Address(RVA = "0x288CF80", Offset = "0x288CF80", VA = "0x288CF80")]
	public void _003C_003EiFixBaseProxy_RefreshContent()
	{
	}
}
