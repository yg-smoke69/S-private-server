using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CB4")]
public sealed class SignalHandle
{
	[Token(Token = "0x4006771")]
	[FieldOffset(Offset = "0x8")]
	private LinkedList<SignalDelegate> m_ownerList;

	[Token(Token = "0x4006772")]
	[FieldOffset(Offset = "0xC")]
	private LinkedListNode<SignalDelegate> m_signalNode;

	[Token(Token = "0x60060B7")]
	[Address(RVA = "0x3156398", Offset = "0x3156398", VA = "0x3156398")]
	internal SignalHandle(LinkedList<SignalDelegate> list, LinkedListNode<SignalDelegate> node)
	{
	}

	[Token(Token = "0x60060B8")]
	[Address(RVA = "0x31564A0", Offset = "0x31564A0", VA = "0x31564A0")]
	public void Dispose()
	{
	}
}
