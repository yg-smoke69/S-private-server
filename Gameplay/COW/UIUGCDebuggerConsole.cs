using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023F9")]
public class UIUGCDebuggerConsole : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x20023FA")]
	private sealed class _003CCor_ShowNotifyDown_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400E057")]
		[FieldOffset(Offset = "0x8")]
		internal UIUGCDebuggerConsole _0024this;

		[Token(Token = "0x400E058")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400E059")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400E05A")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170010F3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600CB3E")]
			[Address(RVA = "0x2B910FC", Offset = "0x2B910FC", VA = "0x2B910FC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010F4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600CB3F")]
			[Address(RVA = "0x2B91104", Offset = "0x2B91104", VA = "0x2B91104", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600CB3C")]
		[Address(RVA = "0x2B907A4", Offset = "0x2B907A4", VA = "0x2B907A4")]
		public _003CCor_ShowNotifyDown_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600CB3D")]
		[Address(RVA = "0x2B90FF4", Offset = "0x2B90FF4", VA = "0x2B90FF4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600CB40")]
		[Address(RVA = "0x2B9110C", Offset = "0x2B9110C", VA = "0x2B9110C", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600CB41")]
		[Address(RVA = "0x2B91120", Offset = "0x2B91120", VA = "0x2B91120", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400E04F")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCDebuggerConsoleView m_View;

	[Token(Token = "0x400E050")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelUGCDebugger m_Debugger;

	[Token(Token = "0x400E051")]
	[FieldOffset(Offset = "0x50")]
	private List<UIModelUGCDebugger.LogData> m_showingLogData;

	[Token(Token = "0x400E052")]
	[FieldOffset(Offset = "0x54")]
	private bool m_isScrollToEnd;

	[Token(Token = "0x400E053")]
	[FieldOffset(Offset = "0x58")]
	private int m_contentItemCount;

	[Token(Token = "0x400E054")]
	[FieldOffset(Offset = "0x5C")]
	private Coroutine m_delay_Cor;

	[Token(Token = "0x400E055")]
	[FieldOffset(Offset = "0x60")]
	private int ShowingMaxIndex;

	[Token(Token = "0x400E056")]
	[FieldOffset(Offset = "0x64")]
	private List<UIEasyListItemController> m_allItems;

	[Token(Token = "0x170010EF")]
	private bool IsToggleInfo
	{
		[Token(Token = "0x600CB20")]
		[Address(RVA = "0x2B8F884", Offset = "0x2B8F884", VA = "0x2B8F884")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600CB21")]
		[Address(RVA = "0x2B8F910", Offset = "0x2B8F910", VA = "0x2B8F910")]
		set
		{
		}
	}

	[Token(Token = "0x170010F0")]
	private bool IsToggleWarnning
	{
		[Token(Token = "0x600CB22")]
		[Address(RVA = "0x2B8F9A8", Offset = "0x2B8F9A8", VA = "0x2B8F9A8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600CB23")]
		[Address(RVA = "0x2B8FA34", Offset = "0x2B8FA34", VA = "0x2B8FA34")]
		set
		{
		}
	}

	[Token(Token = "0x170010F1")]
	private bool IsToggleError
	{
		[Token(Token = "0x600CB24")]
		[Address(RVA = "0x2B8FACC", Offset = "0x2B8FACC", VA = "0x2B8FACC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600CB25")]
		[Address(RVA = "0x2B8FB58", Offset = "0x2B8FB58", VA = "0x2B8FB58")]
		set
		{
		}
	}

	[Token(Token = "0x170010F2")]
	private bool IsToggleSystem
	{
		[Token(Token = "0x600CB26")]
		[Address(RVA = "0x2B8FBF0", Offset = "0x2B8FBF0", VA = "0x2B8FBF0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600CB27")]
		[Address(RVA = "0x2B8FC7C", Offset = "0x2B8FC7C", VA = "0x2B8FC7C")]
		set
		{
		}
	}

	[Token(Token = "0x600CB1C")]
	[Address(RVA = "0x2B8E9F4", Offset = "0x2B8E9F4", VA = "0x2B8E9F4")]
	public UIUGCDebuggerConsole()
	{
	}

	[Token(Token = "0x600CB1D")]
	[Address(RVA = "0x2B8EACC", Offset = "0x2B8EACC", VA = "0x2B8EACC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600CB1E")]
	[Address(RVA = "0x2B8EB70", Offset = "0x2B8EB70", VA = "0x2B8EB70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600CB1F")]
	[Address(RVA = "0x2B8F6E8", Offset = "0x2B8F6E8", VA = "0x2B8F6E8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600CB28")]
	[Address(RVA = "0x2B8FD14", Offset = "0x2B8FD14", VA = "0x2B8FD14")]
	private void SaveToggleUserInfo()
	{
	}

	[Token(Token = "0x600CB29")]
	[Address(RVA = "0x2B8F0D8", Offset = "0x2B8F0D8", VA = "0x2B8F0D8")]
	private void LoadToggleUserInfo()
	{
	}

	[Token(Token = "0x600CB2A")]
	[Address(RVA = "0x2B8FE6C", Offset = "0x2B8FE6C", VA = "0x2B8FE6C")]
	private void OnTestAddLog()
	{
	}

	[Token(Token = "0x600CB2B")]
	[Address(RVA = "0x2B900B0", Offset = "0x2B900B0", VA = "0x2B900B0")]
	private void OnLogAdded(object[] data)
	{
	}

	[Token(Token = "0x600CB2C")]
	[Address(RVA = "0x2B905DC", Offset = "0x2B905DC", VA = "0x2B905DC")]
	private void OnLogShowChanged(object[] data)
	{
	}

	[Token(Token = "0x600CB2D")]
	[Address(RVA = "0x2B90644", Offset = "0x2B90644", VA = "0x2B90644")]
	private void Delay_ShowNotifyDown()
	{
	}

	[Token(Token = "0x600CB2E")]
	[Address(RVA = "0x2B906D8", Offset = "0x2B906D8", VA = "0x2B906D8")]
	private IEnumerator Cor_ShowNotifyDown()
	{
		return null;
	}

	[Token(Token = "0x600CB2F")]
	[Address(RVA = "0x2B907AC", Offset = "0x2B907AC", VA = "0x2B907AC")]
	private void RefreshShowingMaxIndex()
	{
	}

	[Token(Token = "0x600CB30")]
	[Address(RVA = "0x2B90A70", Offset = "0x2B90A70", VA = "0x2B90A70")]
	private void OnToggleInfo()
	{
	}

	[Token(Token = "0x600CB31")]
	[Address(RVA = "0x2B90AD8", Offset = "0x2B90AD8", VA = "0x2B90AD8")]
	private void OnToggleWarnning()
	{
	}

	[Token(Token = "0x600CB32")]
	[Address(RVA = "0x2B90B40", Offset = "0x2B90B40", VA = "0x2B90B40")]
	private void OnToggleError()
	{
	}

	[Token(Token = "0x600CB33")]
	[Address(RVA = "0x2B90BA8", Offset = "0x2B90BA8", VA = "0x2B90BA8")]
	private void OnToggleSystem()
	{
	}

	[Token(Token = "0x600CB34")]
	[Address(RVA = "0x2B8F220", Offset = "0x2B8F220", VA = "0x2B8F220")]
	private void RefreshAllLog()
	{
	}

	[Token(Token = "0x600CB35")]
	[Address(RVA = "0x2B904D4", Offset = "0x2B904D4", VA = "0x2B904D4")]
	private bool IsNeedShow(UIModelUGCDebugger.LogData d)
	{
		return default(bool);
	}

	[Token(Token = "0x600CB36")]
	[Address(RVA = "0x2B90C10", Offset = "0x2B90C10", VA = "0x2B90C10")]
	private void OnSelectItem(int index)
	{
	}

	[Token(Token = "0x600CB37")]
	[Address(RVA = "0x2B90C6C", Offset = "0x2B90C6C", VA = "0x2B90C6C")]
	private void OnLongPressItem(int index, Vector3 position)
	{
	}

	[Token(Token = "0x600CB38")]
	[Address(RVA = "0x2B90CE4", Offset = "0x2B90CE4", VA = "0x2B90CE4", Slot = "46")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600CB39")]
	[Address(RVA = "0x2B90EFC", Offset = "0x2B90EFC", VA = "0x2B90EFC", Slot = "47")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600CB3A")]
	[Address(RVA = "0x2B90FE4", Offset = "0x2B90FE4", VA = "0x2B90FE4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600CB3B")]
	[Address(RVA = "0x2B90FEC", Offset = "0x2B90FEC", VA = "0x2B90FEC")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
