using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon.Utillities;

[Token(Token = "0x2003EBC")]
public class CircularBuffer<T> : _Attribute, IConvertible, IComparable<int>, IFormattable
{
	[Token(Token = "0x2003EBD")]
	private sealed class _003CGetEnumerator_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x401A7DE")]
		[FieldOffset(Offset = "0x0")]
		internal long _003Cversion_003E__0;

		[Token(Token = "0x401A7DF")]
		[FieldOffset(Offset = "0x0")]
		internal int _003Ci_003E__1;

		[Token(Token = "0x401A7E0")]
		[FieldOffset(Offset = "0x0")]
		internal CircularBuffer<T> _0024this;

		[Token(Token = "0x401A7E1")]
		[FieldOffset(Offset = "0x0")]
		internal T _0024current;

		[Token(Token = "0x401A7E2")]
		[FieldOffset(Offset = "0x0")]
		internal bool _0024disposing;

		[Token(Token = "0x401A7E3")]
		[FieldOffset(Offset = "0x0")]
		internal int _0024PC;

		[Token(Token = "0x17001BD6")]
		private T System_002ECollections_002EGeneric_002EIEnumerator_003CT_003E_002ECurrent
		{
			[Token(Token = "0x601985A")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17001BD7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x601985B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6019858")]
		public _003CGetEnumerator_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6019859")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601985C")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601985D")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x401A7D9")]
	[FieldOffset(Offset = "0x0")]
	private T[] m_Buffer;

	[Token(Token = "0x401A7DA")]
	[FieldOffset(Offset = "0x0")]
	private int m_Position;

	[Token(Token = "0x401A7DB")]
	[FieldOffset(Offset = "0x0")]
	private long m_Version;

	[Token(Token = "0x401A7DC")]
	[FieldOffset(Offset = "0x0")]
	private int _003CCapacity_003Ek__BackingField;

	[Token(Token = "0x401A7DD")]
	[FieldOffset(Offset = "0x0")]
	private int _003CCount_003Ek__BackingField;

	[Token(Token = "0x17001BD2")]
	private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly
	{
		[Token(Token = "0x6019856")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001BD3")]
	public T Item
	{
		[Token(Token = "0x6019845")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x6019846")]
		set
		{
		}
	}

	[Token(Token = "0x17001BD4")]
	public int Capacity
	{
		[Token(Token = "0x6019847")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6019848")]
		private set
		{
		}
	}

	[Token(Token = "0x17001BD5")]
	public int Count
	{
		[Token(Token = "0x6019849")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601984A")]
		private set
		{
		}
	}

	[Token(Token = "0x6019844")]
	public CircularBuffer(int capacity)
	{
	}

	[Token(Token = "0x601984B")]
	public void Add(T item)
	{
	}

	[Token(Token = "0x601984C")]
	public T Add()
	{
		return (T)null;
	}

	[Token(Token = "0x601984D")]
	public void Init(Type type)
	{
	}

	[Token(Token = "0x601984E")]
	public void Clear()
	{
	}

	[Token(Token = "0x601984F")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6019850")]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6019851")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6019852")]
	public int IndexOf(T item)
	{
		return default(int);
	}

	[Token(Token = "0x6019853")]
	public void Insert(int index, T item)
	{
	}

	[Token(Token = "0x6019854")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6019855")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x6019857")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
