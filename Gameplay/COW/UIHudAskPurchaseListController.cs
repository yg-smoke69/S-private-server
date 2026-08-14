using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20026D8")]
public class UIHudAskPurchaseListController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x20026D9")]
	private sealed class _003CGCommon_IUIModelDataChangeObserver_OnDataChanged_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EFFB")]
		[FieldOffset(Offset = "0x8")]
		internal AskCSPurchaseInfo info;

		[Token(Token = "0x400EFFC")]
		[FieldOffset(Offset = "0xC")]
		internal UIHudAskPurchaseListController _0024this;

		[Token(Token = "0x600EB24")]
		[Address(RVA = "0x170AB24", Offset = "0x170AB24", VA = "0x170AB24")]
		public _003CGCommon_IUIModelDataChangeObserver_OnDataChanged_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600EB25")]
		[Address(RVA = "0x170AD4C", Offset = "0x170AD4C", VA = "0x170AD4C")]
		internal bool _003C_003Em__0(AskCSPurchaseInfo x)
		{
			return default(bool);
		}

		[Token(Token = "0x600EB26")]
		[Address(RVA = "0x170AE8C", Offset = "0x170AE8C", VA = "0x170AE8C")]
		internal int _003C_003Em__1(AskCSPurchaseInfo a, AskCSPurchaseInfo b)
		{
			return default(int);
		}
	}

	[Token(Token = "0x400EFF9")]
	[FieldOffset(Offset = "0x28")]
	private UIHudAskPurchaseListView m_View;

	[Token(Token = "0x400EFFA")]
	[FieldOffset(Offset = "0x2C")]
	private List<AskCSPurchaseInfo> m_PurchaseInfoList;

	[Token(Token = "0x600EB18")]
	[Address(RVA = "0x1709E28", Offset = "0x1709E28", VA = "0x1709E28")]
	public UIHudAskPurchaseListController()
	{
	}

	[Token(Token = "0x600EB19")]
	[Address(RVA = "0x1709EE0", Offset = "0x1709EE0", VA = "0x1709EE0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EB1A")]
	[Address(RVA = "0x170A068", Offset = "0x170A068", VA = "0x170A068")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EB1B")]
	[Address(RVA = "0x170A110", Offset = "0x170A110", VA = "0x170A110", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600EB1C")]
	[Address(RVA = "0x170A26C", Offset = "0x170A26C", VA = "0x170A26C", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600EB1D")]
	[Address(RVA = "0x170A2E4", Offset = "0x170A2E4", VA = "0x170A2E4", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600EB1E")]
	[Address(RVA = "0x170AB2C", Offset = "0x170AB2C", VA = "0x170AB2C", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600EB1F")]
	[Address(RVA = "0x170ABC0", Offset = "0x170ABC0", VA = "0x170ABC0", Slot = "33")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600EB20")]
	[Address(RVA = "0x170ACB8", Offset = "0x170ACB8", VA = "0x170ACB8", Slot = "34")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600EB21")]
	[Address(RVA = "0x170AD34", Offset = "0x170AD34", VA = "0x170AD34")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600EB22")]
	[Address(RVA = "0x170AD3C", Offset = "0x170AD3C", VA = "0x170AD3C")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x600EB23")]
	[Address(RVA = "0x170AD44", Offset = "0x170AD44", VA = "0x170AD44")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
