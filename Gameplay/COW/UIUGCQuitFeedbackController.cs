using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002365")]
public class UIUGCQuitFeedbackController : UIPopupWindowController
{
	[Token(Token = "0x2002366")]
	private sealed class _003CShowOKBtnDelay_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400DC6B")]
		[FieldOffset(Offset = "0x8")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x400DC6C")]
		[FieldOffset(Offset = "0xC")]
		internal UIUGCQuitFeedbackController _0024this;

		[Token(Token = "0x400DC6D")]
		[FieldOffset(Offset = "0x10")]
		internal object _0024current;

		[Token(Token = "0x400DC6E")]
		[FieldOffset(Offset = "0x14")]
		internal bool _0024disposing;

		[Token(Token = "0x400DC6F")]
		[FieldOffset(Offset = "0x18")]
		internal int _0024PC;

		[Token(Token = "0x170010CE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600C587")]
			[Address(RVA = "0x2790390", Offset = "0x2790390", VA = "0x2790390", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170010CF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600C588")]
			[Address(RVA = "0x2790398", Offset = "0x2790398", VA = "0x2790398", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600C585")]
		[Address(RVA = "0x278F8A8", Offset = "0x278F8A8", VA = "0x278F8A8")]
		public _003CShowOKBtnDelay_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600C586")]
		[Address(RVA = "0x27900D8", Offset = "0x27900D8", VA = "0x27900D8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600C589")]
		[Address(RVA = "0x27903A0", Offset = "0x27903A0", VA = "0x27903A0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600C58A")]
		[Address(RVA = "0x27903B4", Offset = "0x27903B4", VA = "0x27903B4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400DC67")]
	[FieldOffset(Offset = "0x48")]
	private UIUGCQuitFeedbackView m_View;

	[Token(Token = "0x400DC68")]
	private const int MaxItemCount = 4;

	[Token(Token = "0x400DC69")]
	[FieldOffset(Offset = "0x4C")]
	private int m_CountDownSecond;

	[Token(Token = "0x400DC6A")]
	[FieldOffset(Offset = "0x50")]
	private List<uint> m_SelectedIdList;

	[Token(Token = "0x600C57B")]
	[Address(RVA = "0x278F0FC", Offset = "0x278F0FC", VA = "0x278F0FC")]
	public UIUGCQuitFeedbackController()
	{
	}

	[Token(Token = "0x600C57C")]
	[Address(RVA = "0x278F10C", Offset = "0x278F10C", VA = "0x278F10C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C57D")]
	[Address(RVA = "0x278F1B0", Offset = "0x278F1B0", VA = "0x278F1B0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C57E")]
	[Address(RVA = "0x278F7DC", Offset = "0x278F7DC", VA = "0x278F7DC")]
	private IEnumerator ShowOKBtnDelay()
	{
		return null;
	}

	[Token(Token = "0x600C57F")]
	[Address(RVA = "0x278F8B0", Offset = "0x278F8B0", VA = "0x278F8B0")]
	private void OnCancelClick()
	{
	}

	[Token(Token = "0x600C580")]
	[Address(RVA = "0x278F914", Offset = "0x278F914", VA = "0x278F914")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600C581")]
	[Address(RVA = "0x278FA5C", Offset = "0x278FA5C", VA = "0x278FA5C")]
	private void SendSelectedToGS()
	{
	}

	[Token(Token = "0x600C582")]
	[Address(RVA = "0x278F3D4", Offset = "0x278F3D4", VA = "0x278F3D4")]
	private void RefreshUI()
	{
	}

	[Token(Token = "0x600C583")]
	[Address(RVA = "0x278FF70", Offset = "0x278FF70", VA = "0x278FF70")]
	private void OnItemClick(uint id, bool selected)
	{
	}

	[Token(Token = "0x600C584")]
	[Address(RVA = "0x27900D0", Offset = "0x27900D0", VA = "0x27900D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
