using System.Collections.Generic;
using Il2CppDummyDll;

[Token(Token = "0x2003AB7")]
public class WaitingResponseHandler
{
	[Token(Token = "0x4018F54")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<string, bool> m_WaitingDict;

	[Token(Token = "0x60173EF")]
	[Address(RVA = "0x2A6B420", Offset = "0x2A6B420", VA = "0x2A6B420")]
	public WaitingResponseHandler()
	{
	}

	[Token(Token = "0x60173F0")]
	[Address(RVA = "0x2A6B4AC", Offset = "0x2A6B4AC", VA = "0x2A6B4AC")]
	public void Init()
	{
	}

	[Token(Token = "0x60173F1")]
	[Address(RVA = "0x2A6B4B0", Offset = "0x2A6B4B0", VA = "0x2A6B4B0")]
	public void Clear()
	{
	}

	[Token(Token = "0x60173F2")]
	[Address(RVA = "0x2A6B528", Offset = "0x2A6B528", VA = "0x2A6B528")]
	public void Wait(string id)
	{
	}

	[Token(Token = "0x60173F3")]
	[Address(RVA = "0x2A6B66C", Offset = "0x2A6B66C", VA = "0x2A6B66C")]
	public void CancelWait(string id)
	{
	}

	[Token(Token = "0x60173F4")]
	[Address(RVA = "0x2A6B724", Offset = "0x2A6B724", VA = "0x2A6B724")]
	public bool IsPending(string id)
	{
		return default(bool);
	}
}
