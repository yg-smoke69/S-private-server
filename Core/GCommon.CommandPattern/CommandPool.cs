using System;
using System.Collections;
using Il2CppDummyDll;

namespace GCommon.CommandPattern;

[Token(Token = "0x2003E7C")]
public class CommandPool
{
	[Token(Token = "0x401A6AA")]
	[FieldOffset(Offset = "0x8")]
	private string m_TypeName;

	[Token(Token = "0x401A6AB")]
	[FieldOffset(Offset = "0xC")]
	private Queue m_FreeObjects;

	[Token(Token = "0x60196F2")]
	[Address(RVA = "0x3086C80", Offset = "0x3086C80", VA = "0x3086C80")]
	public CommandPool(string name)
	{
	}

	[Token(Token = "0x60196F3")]
	public T AllocObject<T>() where T : Command, new()
	{
		return null;
	}

	[Token(Token = "0x60196F4")]
	public void CollectObject<T>(T obj) where T : CommandPoolCallback
	{
	}

	[Token(Token = "0x60196F5")]
	[Address(RVA = "0x308640C", Offset = "0x308640C", VA = "0x308640C")]
	public void Clear()
	{
	}

	[Token(Token = "0x60196F6")]
	[Address(RVA = "0x3086D04", Offset = "0x3086D04", VA = "0x3086D04")]
	protected CommandPoolCallback AllocObjectInternal()
	{
		return null;
	}

	[Token(Token = "0x60196F7")]
	[Address(RVA = "0x3086EBC", Offset = "0x3086EBC", VA = "0x3086EBC")]
	protected void CollectObjectInternal(object obj)
	{
	}

	[Token(Token = "0x60196F8")]
	[Address(RVA = "0x3086EF8", Offset = "0x3086EF8", VA = "0x3086EF8")]
	private bool CheckType(Type type)
	{
		return default(bool);
	}
}
