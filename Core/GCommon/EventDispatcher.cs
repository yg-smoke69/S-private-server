using System.Collections.Generic;
using COW;
using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003E83")]
public class EventDispatcher
{
	[Token(Token = "0x2003E84")]
	public delegate void EventHandler(object[] data);

	[Token(Token = "0x2003E85")]
	public delegate void GEventHandler(GEvent data);

	[Token(Token = "0x401A6AE")]
	[FieldOffset(Offset = "0x8")]
	private Dictionary<int, EventHandler> m_EventDict;

	[Token(Token = "0x401A6AF")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<int, GEventHandler> m_GEventDict;

	[Token(Token = "0x401A6B0")]
	[FieldOffset(Offset = "0x10")]
	private EventIDComparer m_EventIDComparer;

	[Token(Token = "0x601970A")]
	[Address(RVA = "0x329FF10", Offset = "0x329FF10", VA = "0x329FF10")]
	public EventDispatcher()
	{
	}

	[Token(Token = "0x601970B")]
	[Address(RVA = "0x32A0008", Offset = "0x32A0008", VA = "0x32A0008")]
	public void DispatchEvent(EventID eventID, object[] data)
	{
	}

	[Token(Token = "0x601970C")]
	[Address(RVA = "0x32A046C", Offset = "0x32A046C", VA = "0x32A046C")]
	public void DispatchGEvent(EventID eventID, GEvent data)
	{
	}

	[Token(Token = "0x601970D")]
	[Address(RVA = "0x32A08D0", Offset = "0x32A08D0", VA = "0x32A08D0")]
	public void RegisterEvent(EventID eventID, EventHandler eventHandler)
	{
	}

	[Token(Token = "0x601970E")]
	[Address(RVA = "0x32A0A60", Offset = "0x32A0A60", VA = "0x32A0A60")]
	public void RegisterEvent(EventID eventID, GEventHandler eventHandler)
	{
	}

	[Token(Token = "0x601970F")]
	[Address(RVA = "0x32A0BF0", Offset = "0x32A0BF0", VA = "0x32A0BF0")]
	public void UnRegisterEvent(EventID eventID, EventHandler eventHandler)
	{
	}

	[Token(Token = "0x6019710")]
	[Address(RVA = "0x32A0D7C", Offset = "0x32A0D7C", VA = "0x32A0D7C")]
	public void UnRegisterGEvent(EventID eventID, GEventHandler eventHandler)
	{
	}
}
