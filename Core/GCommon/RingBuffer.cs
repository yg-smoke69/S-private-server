using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E8A")]
public class RingBuffer<T> : _Attribute, IConvertible, IComparable<int>, IFormattable
{
	[Token(Token = "0x2003E8B")]
	private sealed class _003CGetEnumerator_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A6B8")]
		[FieldOffset(Offset = "0x0")]
		internal int _003C_index_003E__0;

		[Token(Token = "0x401A6B9")]
		[FieldOffset(Offset = "0x0")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x401A6BA")]
		[FieldOffset(Offset = "0x0")]
		internal RingBuffer<T> _0024this;

		[Token(Token = "0x401A6BB")]
		[FieldOffset(Offset = "0x0")]
		internal T _0024current;

		[Token(Token = "0x401A6BC")]
		[FieldOffset(Offset = "0x0")]
		internal bool _0024disposing;

		[Token(Token = "0x401A6BD")]
		[FieldOffset(Offset = "0x0")]
		internal int _0024PC;

		[Token(Token = "0x17001BC4")]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[Token(Token = "0x6019742")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17001BC5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6019743")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6019740")]
		public _003CGetEnumerator_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6019741")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6019744")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6019745")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401A6B3")]
	[FieldOffset(Offset = "0x0")]
	protected int head;

	[Token(Token = "0x401A6B4")]
	[FieldOffset(Offset = "0x0")]
	protected int tail;

	[Token(Token = "0x401A6B5")]
	[FieldOffset(Offset = "0x0")]
	protected int size;

	[Token(Token = "0x401A6B6")]
	[FieldOffset(Offset = "0x0")]
	protected T[] buffer;

	[Token(Token = "0x401A6B7")]
	[FieldOffset(Offset = "0x0")]
	private bool allowOverflow;

	[Token(Token = "0x17001BBD")]
	public bool AllowOverflow
	{
		[Token(Token = "0x601972D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BBE")]
	public int Capacity
	{
		[Token(Token = "0x601972E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BBF")]
	public int Size
	{
		[Token(Token = "0x601972F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BC0")]
	public int Count
	{
		[Token(Token = "0x6019736")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001BC1")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6019737")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BC2")]
	public object SyncRoot
	{
		[Token(Token = "0x601973D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001BC3")]
	public bool IsSynchronized
	{
		[Token(Token = "0x601973E")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x601972A")]
	public RingBuffer()
	{
	}

	[Token(Token = "0x601972B")]
	public RingBuffer(int capacity)
	{
	}

	[Token(Token = "0x601972C")]
	public RingBuffer(int capacity, bool overflow)
	{
	}

	[Token(Token = "0x6019730")]
	public T Get()
	{
		return (T)null;
	}

	[Token(Token = "0x6019731")]
	public void Put(T item)
	{
	}

	[Token(Token = "0x6019732")]
	protected void addToBuffer(T toAdd, bool overflow)
	{
	}

	[Token(Token = "0x6019733")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6019734")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6019735")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6019738")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x6019739")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x601973A")]
	public void Clear()
	{
	}

	[Token(Token = "0x601973B")]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x601973C")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x601973F")]
	private void System_002ECollections_002EICollection_002ECopyTo(Array array, int index)
	{
	}
}
