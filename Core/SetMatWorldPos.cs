using System;
using System.Collections;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20007FC")]
public class SetMatWorldPos : MonoBehaviour
{
	[Token(Token = "0x20007FD")]
	private sealed class _003CDoSet_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4005089")]
		[FieldOffset(Offset = "0x8")]
		internal SetMatWorldPos _0024this;

		[Token(Token = "0x400508A")]
		[FieldOffset(Offset = "0xC")]
		internal object _0024current;

		[Token(Token = "0x400508B")]
		[FieldOffset(Offset = "0x10")]
		internal bool _0024disposing;

		[Token(Token = "0x400508C")]
		[FieldOffset(Offset = "0x14")]
		internal int _0024PC;

		[Token(Token = "0x170003BF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x600331C")]
			[Address(RVA = "0x21C59DC", Offset = "0x21C59DC", VA = "0x21C59DC", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170003C0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600331D")]
			[Address(RVA = "0x21C59E4", Offset = "0x21C59E4", VA = "0x21C59E4", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600331A")]
		[Address(RVA = "0x21C57DC", Offset = "0x21C57DC", VA = "0x21C57DC")]
		public _003CDoSet_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x600331B")]
		[Address(RVA = "0x21C57E4", Offset = "0x21C57E4", VA = "0x21C57E4", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600331E")]
		[Address(RVA = "0x21C59EC", Offset = "0x21C59EC", VA = "0x21C59EC", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600331F")]
		[Address(RVA = "0x21C5A00", Offset = "0x21C5A00", VA = "0x21C5A00", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x4005087")]
	[FieldOffset(Offset = "0xC")]
	public Material Mat;

	[Token(Token = "0x4005088")]
	[FieldOffset(Offset = "0x10")]
	protected Transform CachedTrans;

	[Token(Token = "0x6003315")]
	[Address(RVA = "0x21C559C", Offset = "0x21C559C", VA = "0x21C559C")]
	public SetMatWorldPos()
	{
	}

	[Token(Token = "0x6003316")]
	[Address(RVA = "0x21C55A4", Offset = "0x21C55A4", VA = "0x21C55A4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6003317")]
	[Address(RVA = "0x21C5734", Offset = "0x21C5734", VA = "0x21C5734")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x6003318")]
	[Address(RVA = "0x21C55A8", Offset = "0x21C55A8", VA = "0x21C55A8")]
	private void InitRefs()
	{
	}

	[Token(Token = "0x6003319")]
	[Address(RVA = "0x21C5758", Offset = "0x21C5758", VA = "0x21C5758")]
	private IEnumerator DoSet()
	{
		return null;
	}
}
