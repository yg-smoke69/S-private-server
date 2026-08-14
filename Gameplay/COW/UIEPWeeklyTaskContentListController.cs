using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20020E4")]
public class UIEPWeeklyTaskContentListController : UIPopupWindowController
{
	[Token(Token = "0x20020E5")]
	private sealed class _003CCoShow_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CDD0")]
		[FieldOffset(Offset = "0x8")]
		internal UIEPWeeklyTaskContentListController _0024this;

		[Token(Token = "0x400CDD1")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400CDD2")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400CDD3")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17000FE8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AA57")]
			[Address(RVA = "0x2BB7CB0", Offset = "0x2BB7CB0", VA = "0x2BB7CB0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FE9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AA58")]
			[Address(RVA = "0x2BB7CB8", Offset = "0x2BB7CB8", VA = "0x2BB7CB8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AA55")]
		[Address(RVA = "0x2BB7458", Offset = "0x2BB7458", VA = "0x2BB7458")]
		public _003CCoShow_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AA56")]
		[Address(RVA = "0x2BB7C24", Offset = "0x2BB7C24", VA = "0x2BB7C24", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AA59")]
		[Address(RVA = "0x2BB7CC0", Offset = "0x2BB7CC0", VA = "0x2BB7CC0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AA5A")]
		[Address(RVA = "0x2BB7CD4", Offset = "0x2BB7CD4", VA = "0x2BB7CD4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CDCD")]
	[FieldOffset(Offset = "0x48")]
	private UIEPWeeklyTaskContentListView m_View;

	[Token(Token = "0x400CDCE")]
	[FieldOffset(Offset = "0x4C")]
	private List<UIEPWeeklyTaskDetailListController> m_ChildCtrl;

	[Token(Token = "0x400CDCF")]
	[FieldOffset(Offset = "0x50")]
	private int m_CurChildIndex;

	[Token(Token = "0x600AA47")]
	[Address(RVA = "0x2BB6988", Offset = "0x2BB6988", VA = "0x2BB6988")]
	public UIEPWeeklyTaskContentListController()
	{
	}

	[Token(Token = "0x600AA48")]
	[Address(RVA = "0x2BB6A14", Offset = "0x2BB6A14", VA = "0x2BB6A14")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA49")]
	[Address(RVA = "0x2BB6AB8", Offset = "0x2BB6AB8", VA = "0x2BB6AB8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA4A")]
	[Address(RVA = "0x2BB6D60", Offset = "0x2BB6D60", VA = "0x2BB6D60", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600AA4B")]
	[Address(RVA = "0x2BB6DC4", Offset = "0x2BB6DC4", VA = "0x2BB6DC4")]
	private void OnPreClick()
	{
	}

	[Token(Token = "0x600AA4C")]
	[Address(RVA = "0x2BB6FD4", Offset = "0x2BB6FD4", VA = "0x2BB6FD4")]
	private void OnNextClick()
	{
	}

	[Token(Token = "0x600AA4D")]
	[Address(RVA = "0x2BB6EA8", Offset = "0x2BB6EA8", VA = "0x2BB6EA8")]
	private void DoCenter()
	{
	}

	[Token(Token = "0x600AA4E")]
	[Address(RVA = "0x2BB70F0", Offset = "0x2BB70F0", VA = "0x2BB70F0")]
	private void SetButtonState()
	{
	}

	[Token(Token = "0x600AA4F")]
	[Address(RVA = "0x2BB72B4", Offset = "0x2BB72B4", VA = "0x2BB72B4")]
	private void OnCenterChildFinished()
	{
	}

	[Token(Token = "0x600AA50")]
	[Address(RVA = "0x2BB48E4", Offset = "0x2BB48E4", VA = "0x2BB48E4")]
	public void SetIdx(int idx)
	{
	}

	[Token(Token = "0x600AA51")]
	[Address(RVA = "0x2BB738C", Offset = "0x2BB738C", VA = "0x2BB738C")]
	private IEnumerator CoShow()
	{
		return null;
	}

	[Token(Token = "0x600AA52")]
	[Address(RVA = "0x2BB7460", Offset = "0x2BB7460", VA = "0x2BB7460")]
	private void DoShow()
	{
	}

	[Token(Token = "0x600AA53")]
	[Address(RVA = "0x2BB7C14", Offset = "0x2BB7C14", VA = "0x2BB7C14")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA54")]
	[Address(RVA = "0x2BB7C1C", Offset = "0x2BB7C1C", VA = "0x2BB7C1C")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
