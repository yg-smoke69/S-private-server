using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020D8")]
public class UIEPTaskGuideController : UIPopupWindowController
{
	[Token(Token = "0x20020D9")]
	private sealed class _003CCoTypeLabel_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400CD91")]
		[FieldOffset(Offset = "0x8")]
		internal UILabel label;

		[Token(Token = "0x400CD92")]
		[FieldOffset(Offset = "0xC")]
		internal string str;

		[Token(Token = "0x400CD93")]
		[FieldOffset(Offset = "0x10")]
		internal char[] _0024locvar0;

		[Token(Token = "0x400CD94")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024locvar1;

		[Token(Token = "0x400CD95")]
		[FieldOffset(Offset = "0x18")]
		internal char _003Cletter_003E__1;

		[Token(Token = "0x400CD96")]
		[FieldOffset(Offset = "0x1C")]
		internal UIEPTaskGuideController _0024this;

		[Token(Token = "0x400CD97")]
		[FieldOffset(Offset = "0x20")]
		internal object _0024current;

		[Token(Token = "0x400CD98")]
		[FieldOffset(Offset = "0x24")]
		internal bool _0024disposing;

		[Token(Token = "0x400CD99")]
		[FieldOffset(Offset = "0x28")]
		internal int _0024PC;

		[Token(Token = "0x17000FE6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600AA19")]
			[Address(RVA = "0x2BB19D0", Offset = "0x2BB19D0", VA = "0x2BB19D0", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000FE7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600AA1A")]
			[Address(RVA = "0x2BB19D8", Offset = "0x2BB19D8", VA = "0x2BB19D8", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600AA17")]
		[Address(RVA = "0x2BB15C8", Offset = "0x2BB15C8", VA = "0x2BB15C8")]
		public _003CCoTypeLabel_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600AA18")]
		[Address(RVA = "0x2BB1724", Offset = "0x2BB1724", VA = "0x2BB1724", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600AA1B")]
		[Address(RVA = "0x2BB19E0", Offset = "0x2BB19E0", VA = "0x2BB19E0", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600AA1C")]
		[Address(RVA = "0x2BB19F4", Offset = "0x2BB19F4", VA = "0x2BB19F4", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400CD8C")]
	[FieldOffset(Offset = "0x48")]
	private UIEPTaskGuideView m_View;

	[Token(Token = "0x400CD8D")]
	[FieldOffset(Offset = "0x4C")]
	private UIEPTaskEntryController m_EPTaskEntryController;

	[Token(Token = "0x400CD8E")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine mCor;

	[Token(Token = "0x400CD8F")]
	[FieldOffset(Offset = "0x54")]
	private float percharshowTime;

	[Token(Token = "0x400CD90")]
	[FieldOffset(Offset = "0x0")]
	private static Callback _003C_003Ef__am_0024cache0;

	[Token(Token = "0x600AA0A")]
	[Address(RVA = "0x2BB037C", Offset = "0x2BB037C", VA = "0x2BB037C")]
	public UIEPTaskGuideController()
	{
	}

	[Token(Token = "0x600AA0B")]
	[Address(RVA = "0x2BB0390", Offset = "0x2BB0390", VA = "0x2BB0390", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600AA0C")]
	[Address(RVA = "0x2BB0B0C", Offset = "0x2BB0B0C", VA = "0x2BB0B0C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600AA0D")]
	[Address(RVA = "0x2BB0BB0", Offset = "0x2BB0BB0", VA = "0x2BB0BB0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x600AA0E")]
	[Address(RVA = "0x2BB08C0", Offset = "0x2BB08C0", VA = "0x2BB08C0")]
	private void InitUI()
	{
	}

	[Token(Token = "0x600AA0F")]
	[Address(RVA = "0x2BB0C14", Offset = "0x2BB0C14", VA = "0x2BB0C14")]
	private void OnAvatarShowFinish()
	{
	}

	[Token(Token = "0x600AA10")]
	[Address(RVA = "0x2BB0E8C", Offset = "0x2BB0E8C", VA = "0x2BB0E8C")]
	private void OnBtnNext()
	{
	}

	[Token(Token = "0x600AA11")]
	[Address(RVA = "0x2BB112C", Offset = "0x2BB112C", VA = "0x2BB112C")]
	private void OnBtnNext1()
	{
	}

	[Token(Token = "0x600AA12")]
	[Address(RVA = "0x2BB143C", Offset = "0x2BB143C", VA = "0x2BB143C")]
	private void OnBtnEntry()
	{
	}

	[Token(Token = "0x600AA13")]
	[Address(RVA = "0x2BB0D74", Offset = "0x2BB0D74", VA = "0x2BB0D74")]
	private IEnumerator CoTypeLabel(UILabel label, string str)
	{
		return null;
	}

	[Token(Token = "0x600AA14")]
	[Address(RVA = "0x2BB15D0", Offset = "0x2BB15D0", VA = "0x2BB15D0")]
	private static void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600AA15")]
	[Address(RVA = "0x2BB1714", Offset = "0x2BB1714", VA = "0x2BB1714")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600AA16")]
	[Address(RVA = "0x2BB171C", Offset = "0x2BB171C", VA = "0x2BB171C")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
