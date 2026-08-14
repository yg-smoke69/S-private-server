using System.Collections.Generic;
using Il2CppDummyDll;

namespace UMA.Simple;

[Token(Token = "0x2003C73")]
public class ListPoolWithIndexedObjects<T> where T : IGetSetIndex, new()
{
	[Token(Token = "0x4019B07")]
	[FieldOffset(Offset = "0x0")]
	private List<T> m_Pool;

	[Token(Token = "0x4019B08")]
	[FieldOffset(Offset = "0x0")]
	private int m_pFree;

	[Token(Token = "0x601821B")]
	public ListPoolWithIndexedObjects()
	{
	}

	[Token(Token = "0x601821C")]
	public List<T> GetPool()
	{
		return null;
	}

	[Token(Token = "0x601821D")]
	public T Allocate()
	{
		return (T)null;
	}

	[Token(Token = "0x601821E")]
	protected virtual T Create()
	{
		return (T)null;
	}

	[Token(Token = "0x601821F")]
	protected virtual void OnAllocate(T t)
	{
	}

	[Token(Token = "0x6018220")]
	public void Release(T t)
	{
	}

	[Token(Token = "0x6018221")]
	protected virtual void OnRelease(T t)
	{
	}
}
