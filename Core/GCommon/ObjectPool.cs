using System.Collections.Generic;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E88")]
public class ObjectPool<T> where T : IObjectPoolCallback, new()
{
	[Token(Token = "0x401A6B2")]
	[FieldOffset(Offset = "0x0")]
	protected Queue<T> m_FreeObjects;

	[Token(Token = "0x6019720")]
	public ObjectPool()
	{
	}

	[Token(Token = "0x6019721")]
	public T AllocObject()
	{
		return (T)null;
	}

	[Token(Token = "0x6019722")]
	public void CollectObject(T obj)
	{
	}

	[Token(Token = "0x6019723")]
	public virtual void Clear()
	{
	}

	[Token(Token = "0x6019724")]
	protected virtual IObjectPoolCallback AllocObjectInternal()
	{
		return null;
	}

	[Token(Token = "0x6019725")]
	protected virtual void CollectObjectInternal(T obj)
	{
	}
}
