using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003DDE")]
public class AkAuxSendArray : _Attribute
{
	[Token(Token = "0x401A442")]
	private const int MAX_COUNT = 4;

	[Token(Token = "0x401A443")]
	[FieldOffset(Offset = "0x8")]
	private readonly int SIZE_OF_AKAUXSENDVALUE;

	[Token(Token = "0x401A444")]
	[FieldOffset(Offset = "0xC")]
	private IntPtr m_Buffer;

	[Token(Token = "0x401A445")]
	[FieldOffset(Offset = "0x10")]
	private int m_Count;

	[Token(Token = "0x17001B33")]
	public AkAuxSendValue Item
	{
		[Token(Token = "0x60192D9")]
		[Address(RVA = "0x35C5774", Offset = "0x35C5774", VA = "0x35C5774")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001B34")]
	public bool isFull
	{
		[Token(Token = "0x60192DA")]
		[Address(RVA = "0x35C58E0", Offset = "0x35C58E0", VA = "0x35C58E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60192D8")]
	[Address(RVA = "0x35C569C", Offset = "0x35C569C", VA = "0x35C569C")]
	public AkAuxSendArray()
	{
	}

	[Token(Token = "0x60192DB")]
	[Address(RVA = "0x35C594C", Offset = "0x35C594C", VA = "0x35C594C", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60192DC")]
	[Address(RVA = "0x35C59F8", Offset = "0x35C59F8", VA = "0x35C59F8", Slot = "1")]
	~AkAuxSendArray()
	{
	}

	[Token(Token = "0x60192DD")]
	[Address(RVA = "0x35C5A5C", Offset = "0x35C5A5C", VA = "0x35C5A5C")]
	public void Reset()
	{
	}

	[Token(Token = "0x60192DE")]
	[Address(RVA = "0x35C5A68", Offset = "0x35C5A68", VA = "0x35C5A68")]
	public bool Add(GameObject in_listenerGameObj, uint in_AuxBusID, float in_fValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60192DF")]
	[Address(RVA = "0x35C5BB4", Offset = "0x35C5BB4", VA = "0x35C5BB4")]
	public bool Add(uint in_AuxBusID, float in_fValue)
	{
		return default(bool);
	}

	[Token(Token = "0x60192E0")]
	[Address(RVA = "0x35C5CBC", Offset = "0x35C5CBC", VA = "0x35C5CBC")]
	public bool Contains(GameObject in_listenerGameObj, uint in_AuxBusID)
	{
		return default(bool);
	}

	[Token(Token = "0x60192E1")]
	[Address(RVA = "0x35C5E2C", Offset = "0x35C5E2C", VA = "0x35C5E2C")]
	public bool Contains(uint in_AuxBusID)
	{
		return default(bool);
	}

	[Token(Token = "0x60192E2")]
	[Address(RVA = "0x35C5F4C", Offset = "0x35C5F4C", VA = "0x35C5F4C")]
	public AKRESULT SetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60192E3")]
	[Address(RVA = "0x35C6034", Offset = "0x35C6034", VA = "0x35C6034")]
	public AKRESULT GetValues(GameObject gameObject)
	{
		return default(AKRESULT);
	}

	[Token(Token = "0x60192E4")]
	[Address(RVA = "0x35C6128", Offset = "0x35C6128", VA = "0x35C6128")]
	public IntPtr GetBuffer()
	{
		return default(IntPtr);
	}

	[Token(Token = "0x60192E5")]
	[Address(RVA = "0x35C6130", Offset = "0x35C6130", VA = "0x35C6130")]
	public int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60192E6")]
	[Address(RVA = "0x35C5880", Offset = "0x35C5880", VA = "0x35C5880")]
	private IntPtr GetObjectPtr(int index)
	{
		return default(IntPtr);
	}
}
