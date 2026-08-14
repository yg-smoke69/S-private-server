using System;
using System.Collections;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x20029B1")]
internal class UIMatchResultTaskItemController : UIEasyListItemController
{
	[Token(Token = "0x20029B2")]
	private sealed class _003CPlayAnim_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x40100A4")]
		[FieldOffset(Offset = "0x8")]
		internal float _003ClerpValue_003E__0;

		[Token(Token = "0x40100A5")]
		[FieldOffset(Offset = "0xC")]
		internal float _003CcurNum_003E__1;

		[Token(Token = "0x40100A6")]
		[FieldOffset(Offset = "0x10")]
		internal UIMatchResultTaskItemController _0024this;

		[Token(Token = "0x40100A7")]
		[FieldOffset(Offset = "0x14")]
		internal object _0024current;

		[Token(Token = "0x40100A8")]
		[FieldOffset(Offset = "0x18")]
		internal bool _0024disposing;

		[Token(Token = "0x40100A9")]
		[FieldOffset(Offset = "0x1C")]
		internal int _0024PC;

		[Token(Token = "0x17001268")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6010C16")]
			[Address(RVA = "0x268B9D4", Offset = "0x268B9D4", VA = "0x268B9D4", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001269")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6010C17")]
			[Address(RVA = "0x268B9DC", Offset = "0x268B9DC", VA = "0x268B9DC", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6010C14")]
		[Address(RVA = "0x268B1EC", Offset = "0x268B1EC", VA = "0x268B1EC")]
		public _003CPlayAnim_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6010C15")]
		[Address(RVA = "0x268B204", Offset = "0x268B204", VA = "0x268B204", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6010C18")]
		[Address(RVA = "0x268B9E4", Offset = "0x268B9E4", VA = "0x268B9E4", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6010C19")]
		[Address(RVA = "0x268B9F8", Offset = "0x268B9F8", VA = "0x268B9F8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401009C")]
	[FieldOffset(Offset = "0x38")]
	private UIMatchResultTaskItemView m_View;

	[Token(Token = "0x401009D")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_CurrentValue;

	[Token(Token = "0x401009E")]
	[FieldOffset(Offset = "0x40")]
	private uint m_BeforeValue;

	[Token(Token = "0x401009F")]
	[FieldOffset(Offset = "0x44")]
	private uint m_TargetValue;

	[Token(Token = "0x40100A0")]
	[FieldOffset(Offset = "0x48")]
	private EPTarget_Status m_TargetStatus;

	[Token(Token = "0x40100A1")]
	[FieldOffset(Offset = "0x4C")]
	private float m_PlayAnimTime;

	[Token(Token = "0x40100A2")]
	[FieldOffset(Offset = "0x50")]
	private Coroutine m_PlayAnimCoroutine;

	[Token(Token = "0x40100A3")]
	[FieldOffset(Offset = "0x54")]
	private bool m_PlayAnim;

	[Token(Token = "0x6010C0C")]
	[Address(RVA = "0x268A1C8", Offset = "0x268A1C8", VA = "0x268A1C8")]
	public UIMatchResultTaskItemController()
	{
	}

	[Token(Token = "0x6010C0D")]
	[Address(RVA = "0x268A1E0", Offset = "0x268A1E0", VA = "0x268A1E0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010C0E")]
	[Address(RVA = "0x268A284", Offset = "0x268A284", VA = "0x268A284", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010C0F")]
	[Address(RVA = "0x268A340", Offset = "0x268A340", VA = "0x268A340", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010C10")]
	[Address(RVA = "0x268A3BC", Offset = "0x268A3BC", VA = "0x268A3BC", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6010C11")]
	[Address(RVA = "0x268B120", Offset = "0x268B120", VA = "0x268B120")]
	private IEnumerator PlayAnim()
	{
		return null;
	}

	[Token(Token = "0x6010C12")]
	[Address(RVA = "0x268B1F4", Offset = "0x268B1F4", VA = "0x268B1F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010C13")]
	[Address(RVA = "0x268B1FC", Offset = "0x268B1FC", VA = "0x268B1FC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
