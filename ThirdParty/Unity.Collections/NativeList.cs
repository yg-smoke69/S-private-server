using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2003D04")]
public struct NativeList<T> : _Attribute where T : struct
{
	[Token(Token = "0x4019E5D")]
	[FieldOffset(Offset = "0x0")]
	internal unsafe NativeListData* m_ListData;

	[Token(Token = "0x4019E5E")]
	[FieldOffset(Offset = "0x0")]
	private Allocator m_Allocator;

	[Token(Token = "0x170019C9")]
	public T Item
	{
		[Token(Token = "0x60186E5")]
		get
		{
			return (T)null;
		}
		[Token(Token = "0x60186E6")]
		set
		{
		}
	}

	[Token(Token = "0x170019CA")]
	public int Length
	{
		[Token(Token = "0x60186E7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170019CB")]
	public int Capacity
	{
		[Token(Token = "0x60186E8")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60186E9")]
		set
		{
		}
	}

	[Token(Token = "0x170019CC")]
	public bool IsCreated
	{
		[Token(Token = "0x60186EE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60186E1")]
	public NativeList(Allocator i_label)
	{
	}

	[Token(Token = "0x60186E2")]
	public NativeList(int capacity, Allocator i_label)
	{
	}

	[Token(Token = "0x60186E3")]
	private NativeList(int capacity, Allocator i_label, int stackDepth)
	{
	}

	[Token(Token = "0x60186E4")]
	internal static void IsBlittableAndThrow()
	{
	}

	[Token(Token = "0x60186EA")]
	public void Add(T element)
	{
	}

	[Token(Token = "0x60186EB")]
	public void AddRange(NativeArray<T> elements)
	{
	}

	[Token(Token = "0x60186EC")]
	public unsafe void AddRange(void* elements, int count)
	{
	}

	[Token(Token = "0x60186ED")]
	public void RemoveAtSwapBack(int index)
	{
	}

	[Token(Token = "0x60186EF")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60186F0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60186F1")]
	public static implicit operator NativeArray<T>(NativeList<T> nativeList)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(NativeArray<T>);
	}

	[Token(Token = "0x60186F2")]
	public NativeArray<T> AsArray()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(NativeArray<T>);
	}

	[Token(Token = "0x60186F3")]
	public NativeArray<T> ToDeferredJobArray()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(NativeArray<T>);
	}

	[Token(Token = "0x60186F4")]
	public NativeArray<T> AsDeferredJobArray()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(NativeArray<T>);
	}

	[Token(Token = "0x60186F5")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60186F6")]
	public NativeArray<T> ToArray(Allocator allocator)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(NativeArray<T>);
	}

	[Token(Token = "0x60186F7")]
	public void CopyFrom(T[] array)
	{
	}

	[Token(Token = "0x60186F8")]
	public void ResizeUninitialized(int length)
	{
	}
}
