using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

[Token(Token = "0x2003DDF")]
public abstract class AkBaseArray<T> : _Attribute
{
	[Token(Token = "0x401A446")]
	[FieldOffset(Offset = "0x0")]
	private int _003CCapacity_003Ek__BackingField;

	[Token(Token = "0x401A447")]
	[FieldOffset(Offset = "0x0")]
	private IntPtr m_Buffer;

	[Token(Token = "0x17001B35")]
	public int Capacity
	{
		[Token(Token = "0x60192EA")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60192EB")]
		private set
		{
		}
	}

	[Token(Token = "0x17001B36")]
	protected abstract int StructureSize
	{
		[Token(Token = "0x60192ED")]
		get;
	}

	[Token(Token = "0x17001B37")]
	public T Item
	{
		[Token(Token = "0x60192F2")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x60192F3")]
		set
		{
		}
	}

	[Token(Token = "0x60192E7")]
	public AkBaseArray(int capacity)
	{
	}

	[Token(Token = "0x60192E8")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60192E9")]
	~AkBaseArray()
	{
	}

	[Token(Token = "0x60192EC")]
	public virtual int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60192EE")]
	protected virtual void DefaultConstructAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x60192EF")]
	protected virtual void ReleaseAllocatedMemoryFromReferenceAtIntPtr(IntPtr address)
	{
	}

	[Token(Token = "0x60192F0")]
	protected abstract T CreateNewReferenceFromIntPtr(IntPtr address);

	[Token(Token = "0x60192F1")]
	protected abstract void CloneIntoReferenceFromIntPtr(IntPtr address, T other);

	[Token(Token = "0x60192F4")]
	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60192F5")]
	protected IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
