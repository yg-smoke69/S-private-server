using System;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003DE3")]
public class AkMIDIPostArray
{
	[Token(Token = "0x401A44C")]
	[FieldOffset(Offset = "0x8")]
	private readonly int m_Count;

	[Token(Token = "0x401A44D")]
	[FieldOffset(Offset = "0xC")]
	private readonly int SIZE_OF;

	[Token(Token = "0x401A44E")]
	[FieldOffset(Offset = "0x10")]
	private IntPtr m_Buffer;

	[Token(Token = "0x17001B3B")]
	public AkMIDIPost Item
	{
		[Token(Token = "0x6019308")]
		[Address(RVA = "0x36B7CA4", Offset = "0x36B7CA4", VA = "0x36B7CA4")]
		get
		{
			return null;
		}
		[Token(Token = "0x6019309")]
		[Address(RVA = "0x36B7DE0", Offset = "0x36B7DE0", VA = "0x36B7DE0")]
		set
		{
		}
	}

	[Token(Token = "0x6019307")]
	[Address(RVA = "0x36B7BC4", Offset = "0x36B7BC4", VA = "0x36B7BC4")]
	public AkMIDIPostArray(int size)
	{
	}

	[Token(Token = "0x601930A")]
	[Address(RVA = "0x36B7F44", Offset = "0x36B7F44", VA = "0x36B7F44", Slot = "1")]
	~AkMIDIPostArray()
	{
	}

	[Token(Token = "0x601930B")]
	[Address(RVA = "0x36B8024", Offset = "0x36B8024", VA = "0x36B8024")]
	public void PostOnEvent(uint in_eventID, GameObject gameObject)
	{
	}

	[Token(Token = "0x601930C")]
	[Address(RVA = "0x36B8120", Offset = "0x36B8120", VA = "0x36B8120")]
	public void PostOnEvent(uint in_eventID, GameObject gameObject, int count)
	{
	}

	[Token(Token = "0x601930D")]
	[Address(RVA = "0x36B8280", Offset = "0x36B8280", VA = "0x36B8280")]
	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x601930E")]
	[Address(RVA = "0x36B8288", Offset = "0x36B8288", VA = "0x36B8288")]
	public int Count()
	{
		return default(int);
	}

	[Token(Token = "0x601930F")]
	[Address(RVA = "0x36B7DA8", Offset = "0x36B7DA8", VA = "0x36B7DA8")]
	private IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
