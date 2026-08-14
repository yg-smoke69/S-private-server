using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20022B7")]
public class UIHUDPVEGameTargetController : UIBaseController
{
	[Token(Token = "0x20022B8")]
	private sealed class _003CIEHideAll_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x400D924")]
		[FieldOffset(Offset = "0x8")]
		internal UIHUDPVEGameTargetController _0024this;

		[Token(Token = "0x400D925")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400D926")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400D927")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x17001096")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600BEFF")]
			[Address(RVA = "0x1682BA4", Offset = "0x1682BA4", VA = "0x1682BA4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001097")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BF00")]
			[Address(RVA = "0x1682BAC", Offset = "0x1682BAC", VA = "0x1682BAC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BEFD")]
		[Address(RVA = "0x1682658", Offset = "0x1682658", VA = "0x1682658")]
		public _003CIEHideAll_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600BEFE")]
		[Address(RVA = "0x1682AB8", Offset = "0x1682AB8", VA = "0x1682AB8", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BF01")]
		[Address(RVA = "0x1682BB4", Offset = "0x1682BB4", VA = "0x1682BB4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600BF02")]
		[Address(RVA = "0x1682BC8", Offset = "0x1682BC8", VA = "0x1682BC8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400D922")]
	[FieldOffset(Offset = "0x28")]
	private Coroutine m_AnimCoroutine;

	[Token(Token = "0x400D923")]
	[FieldOffset(Offset = "0x2C")]
	private HUDPVEGameTargetView m_View;

	[Token(Token = "0x600BEF4")]
	[Address(RVA = "0x1682040", Offset = "0x1682040", VA = "0x1682040")]
	public UIHUDPVEGameTargetController()
	{
	}

	[Token(Token = "0x600BEF5")]
	[Address(RVA = "0x16820C4", Offset = "0x16820C4", VA = "0x16820C4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BEF6")]
	[Address(RVA = "0x168216C", Offset = "0x168216C", VA = "0x168216C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BEF7")]
	[Address(RVA = "0x16822D0", Offset = "0x16822D0", VA = "0x16822D0")]
	public void OnRoundContentCome(string content)
	{
	}

	[Token(Token = "0x600BEF8")]
	[Address(RVA = "0x168258C", Offset = "0x168258C", VA = "0x168258C")]
	private IEnumerator IEHideAll()
	{
		return null;
	}

	[Token(Token = "0x600BEF9")]
	[Address(RVA = "0x1682660", Offset = "0x1682660", VA = "0x1682660")]
	public void OnGameWin()
	{
	}

	[Token(Token = "0x600BEFA")]
	[Address(RVA = "0x1682908", Offset = "0x1682908", VA = "0x1682908")]
	public void OnTimeOut()
	{
	}

	[Token(Token = "0x600BEFB")]
	[Address(RVA = "0x1682808", Offset = "0x1682808", VA = "0x1682808")]
	private void HideAll()
	{
	}

	[Token(Token = "0x600BEFC")]
	[Address(RVA = "0x1682AB0", Offset = "0x1682AB0", VA = "0x1682AB0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
