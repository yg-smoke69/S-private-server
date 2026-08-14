using System.Collections.Generic;
using Il2CppDummyDll;

namespace ReactUI;

[Token(Token = "0x2000CB5")]
public class SignalDelegateList
{
	[Token(Token = "0x4006773")]
	[FieldOffset(Offset = "0x8")]
	private LinkedList<SignalDelegate> m_delegateList;

	[Token(Token = "0x60060B9")]
	[Address(RVA = "0x3156230", Offset = "0x3156230", VA = "0x3156230")]
	public SignalDelegateList()
	{
	}

	[Token(Token = "0x60060BA")]
	[Address(RVA = "0x3156238", Offset = "0x3156238", VA = "0x3156238")]
	public void Clear()
	{
	}

	[Token(Token = "0x60060BB")]
	[Address(RVA = "0x31562A4", Offset = "0x31562A4", VA = "0x31562A4")]
	public SignalHandle GetHandle(SignalDelegate s)
	{
		return null;
	}

	[Token(Token = "0x60060BC")]
	[Address(RVA = "0x31563C0", Offset = "0x31563C0", VA = "0x31563C0")]
	public void CallHandle(object[] args)
	{
	}
}
