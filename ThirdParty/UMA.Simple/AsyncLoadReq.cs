using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UMA.Simple;

[Token(Token = "0x2003C74")]
public class AsyncLoadReq : _Attribute
{
	[Token(Token = "0x4019B09")]
	[FieldOffset(Offset = "0x8")]
	private int _003CIndex_003Ek__BackingField;

	[Token(Token = "0x4019B0A")]
	[FieldOffset(Offset = "0xC")]
	public bool IsSlot;

	[Token(Token = "0x4019B0B")]
	[FieldOffset(Offset = "0x10")]
	public int Hash;

	[Token(Token = "0x4019B0C")]
	[FieldOffset(Offset = "0x14")]
	public int Param;

	[Token(Token = "0x4019B0D")]
	[FieldOffset(Offset = "0x18")]
	public uint Ticket;

	[Token(Token = "0x4019B0E")]
	[FieldOffset(Offset = "0x1C")]
	public bool Cache;

	[Token(Token = "0x4019B0F")]
	[FieldOffset(Offset = "0x20")]
	public Action<uint, Object, AsyncLoadReq> Callback;

	[Token(Token = "0x4019B10")]
	[FieldOffset(Offset = "0x24")]
	public Action<Object, uint> CallbackAssetTicket;

	[Token(Token = "0x4019B11")]
	[FieldOffset(Offset = "0x28")]
	public Action<Object, uint, int> CallbackAssetTicketParam;

	[Token(Token = "0x4019B12")]
	[FieldOffset(Offset = "0x2C")]
	public Sample Sample;

	[Token(Token = "0x1700199A")]
	public int Index
	{
		[Token(Token = "0x6018223")]
		[Address(RVA = "0x2D553E0", Offset = "0x2D553E0", VA = "0x2D553E0", Slot = "4")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6018224")]
		[Address(RVA = "0x2D553E8", Offset = "0x2D553E8", VA = "0x2D553E8", Slot = "5")]
		set
		{
		}
	}

	[Token(Token = "0x6018222")]
	[Address(RVA = "0x2D55340", Offset = "0x2D55340", VA = "0x2D55340")]
	public AsyncLoadReq()
	{
	}

	[Token(Token = "0x6018225")]
	[Address(RVA = "0x2D553F0", Offset = "0x2D553F0", VA = "0x2D553F0")]
	public void OnAsyncCallback(uint ticket, bool success, Object asset)
	{
	}

	[Token(Token = "0x6018226")]
	[Address(RVA = "0x2D55488", Offset = "0x2D55488", VA = "0x2D55488")]
	public void InvokeCallback(Object t)
	{
	}

	[Token(Token = "0x6018227")]
	[Address(RVA = "0x2D55538", Offset = "0x2D55538", VA = "0x2D55538", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
