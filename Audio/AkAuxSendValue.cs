using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003D5F")]
public class AkAuxSendValue : _Attribute
{
	[Token(Token = "0x401A177")]
	[FieldOffset(Offset = "0x8")]
	private IntPtr swigCPtr;

	[Token(Token = "0x401A178")]
	[FieldOffset(Offset = "0xC")]
	protected bool swigCMemOwn;

	[Token(Token = "0x17001A24")]
	public ulong listenerID
	{
		[Token(Token = "0x6018E9E")]
		[Address(RVA = "0x35C6400", Offset = "0x35C6400", VA = "0x35C6400")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6018E9D")]
		[Address(RVA = "0x35C635C", Offset = "0x35C635C", VA = "0x35C635C")]
		set
		{
		}
	}

	[Token(Token = "0x17001A25")]
	public uint auxBusID
	{
		[Token(Token = "0x6018EA0")]
		[Address(RVA = "0x35C6518", Offset = "0x35C6518", VA = "0x35C6518")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6018E9F")]
		[Address(RVA = "0x35C6488", Offset = "0x35C6488", VA = "0x35C6488")]
		set
		{
		}
	}

	[Token(Token = "0x17001A26")]
	public float fControlValue
	{
		[Token(Token = "0x6018EA2")]
		[Address(RVA = "0x35C6630", Offset = "0x35C6630", VA = "0x35C6630")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6018EA1")]
		[Address(RVA = "0x35C65A0", Offset = "0x35C65A0", VA = "0x35C65A0")]
		set
		{
		}
	}

	[Token(Token = "0x6018E98")]
	[Address(RVA = "0x35C58B8", Offset = "0x35C58B8", VA = "0x35C58B8")]
	internal AkAuxSendValue(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	[Token(Token = "0x6018E99")]
	[Address(RVA = "0x35C6138", Offset = "0x35C6138", VA = "0x35C6138")]
	internal static IntPtr getCPtr(AkAuxSendValue obj)
	{
		return default(IntPtr);
	}

	[Token(Token = "0x6018E9A")]
	[Address(RVA = "0x35C6190", Offset = "0x35C6190", VA = "0x35C6190", Slot = "5")]
	internal virtual void setCPtr(IntPtr cPtr)
	{
	}

	[Token(Token = "0x6018E9B")]
	[Address(RVA = "0x35C61BC", Offset = "0x35C61BC", VA = "0x35C61BC", Slot = "1")]
	~AkAuxSendValue()
	{
	}

	[Token(Token = "0x6018E9C")]
	[Address(RVA = "0x35C6230", Offset = "0x35C6230", VA = "0x35C6230", Slot = "6")]
	public virtual void Dispose()
	{
	}

	[Token(Token = "0x6018EA3")]
	[Address(RVA = "0x35C66B8", Offset = "0x35C66B8", VA = "0x35C66B8")]
	public void Set(GameObject listener, uint id, float value)
	{
	}

	[Token(Token = "0x6018EA4")]
	[Address(RVA = "0x35C67C8", Offset = "0x35C67C8", VA = "0x35C67C8")]
	public bool IsSame(GameObject listener, uint id)
	{
		return default(bool);
	}

	[Token(Token = "0x6018EA5")]
	[Address(RVA = "0x35C68C0", Offset = "0x35C68C0", VA = "0x35C68C0")]
	public static int GetSizeOf()
	{
		return default(int);
	}
}
