using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E87")]
public class ObjectPoolCallbackBase : _Attribute
{
	[Token(Token = "0x401A6B1")]
	[FieldOffset(Offset = "0x8")]
	private bool m_IsInPool;

	[Token(Token = "0x601971C")]
	[Address(RVA = "0x297FB54", Offset = "0x297FB54", VA = "0x297FB54")]
	public ObjectPoolCallbackBase()
	{
	}

	[Token(Token = "0x601971D")]
	[Address(RVA = "0x297FB64", Offset = "0x297FB64", VA = "0x297FB64", Slot = "7")]
	public virtual void OnAllocated()
	{
	}

	[Token(Token = "0x601971E")]
	[Address(RVA = "0x297FB70", Offset = "0x297FB70", VA = "0x297FB70", Slot = "8")]
	public virtual void OnCollected()
	{
	}

	[Token(Token = "0x601971F")]
	[Address(RVA = "0x297FB7C", Offset = "0x297FB7C", VA = "0x297FB7C", Slot = "9")]
	public virtual bool IsInPool()
	{
		return default(bool);
	}
}
