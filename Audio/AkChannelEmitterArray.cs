using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003DE0")]
public class AkChannelEmitterArray : _Attribute
{
	[Token(Token = "0x401A448")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr m_Buffer;

	[Token(Token = "0x401A449")]
	[FieldOffset(Offset = "0xC")]
	private IntPtr m_Current;

	[Token(Token = "0x401A44A")]
	[FieldOffset(Offset = "0x10")]
	private uint m_MaxCount;

	[Token(Token = "0x401A44B")]
	[FieldOffset(Offset = "0x14")]
	private uint _003CCount_003Ek__BackingField;

	[Token(Token = "0x17001B38")]
	public uint Count
	{
		[Token(Token = "0x60192F7")]
		[Address(RVA = "0x35CF398", Offset = "0x35CF398", VA = "0x35CF398")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60192F8")]
		[Address(RVA = "0x35CF390", Offset = "0x35CF390", VA = "0x35CF390")]
		private set
		{
		}
	}

	[Token(Token = "0x60192F6")]
	[Address(RVA = "0x35CF2E8", Offset = "0x35CF2E8", VA = "0x35CF2E8")]
	public AkChannelEmitterArray(uint in_Count)
	{
	}

	[Token(Token = "0x60192F9")]
	[Address(RVA = "0x35CF3A0", Offset = "0x35CF3A0", VA = "0x35CF3A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60192FA")]
	[Address(RVA = "0x35CF44C", Offset = "0x35CF44C", VA = "0x35CF44C", Slot = "1")]
	~AkChannelEmitterArray()
	{
	}

	[Token(Token = "0x60192FB")]
	[Address(RVA = "0x35CF4B0", Offset = "0x35CF4B0", VA = "0x35CF4B0")]
	public void Reset()
	{
	}

	[Token(Token = "0x60192FC")]
	[Address(RVA = "0x35CF4C4", Offset = "0x35CF4C4", VA = "0x35CF4C4")]
	public void Add(Vector3 in_Pos, Vector3 in_Forward, Vector3 in_Top, uint in_ChannelMask)
	{
	}
}
