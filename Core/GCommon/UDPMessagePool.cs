using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x200409A")]
internal class UDPMessagePool<T> : _Attribute where T : UDPClientMessageBase, new()
{
	[Token(Token = "0x401B241")]
	[FieldOffset(Offset = "0x0")]
	private Queue<T> m_FreeList;

	[Token(Token = "0x601A4B1")]
	public UDPMessagePool()
	{
	}

	[Token(Token = "0x601A4B2")]
	public T Get()
	{
		return null;
	}

	[Token(Token = "0x601A4B3")]
	public void Put(T v)
	{
	}

	[Token(Token = "0x601A4B4")]
	public void Clear()
	{
	}
}
