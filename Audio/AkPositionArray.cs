using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003DE6")]
public class AkPositionArray : _Attribute
{
	[Token(Token = "0x401A44F")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr m_Buffer;

	[Token(Token = "0x401A450")]
	[FieldOffset(Offset = "0xC")]
	private IntPtr m_Current;

	[Token(Token = "0x401A451")]
	[FieldOffset(Offset = "0x10")]
	private uint m_MaxCount;

	[Token(Token = "0x401A452")]
	[FieldOffset(Offset = "0x14")]
	private uint _003CCount_003Ek__BackingField;

	[Token(Token = "0x17001B3E")]
	public uint Count
	{
		[Token(Token = "0x601931B")]
		[Address(RVA = "0x36C1F80", Offset = "0x36C1F80", VA = "0x36C1F80")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601931C")]
		[Address(RVA = "0x36C1F78", Offset = "0x36C1F78", VA = "0x36C1F78")]
		private set
		{
		}
	}

	[Token(Token = "0x601931A")]
	[Address(RVA = "0x36C1ED0", Offset = "0x36C1ED0", VA = "0x36C1ED0")]
	public AkPositionArray(uint in_Count)
	{
	}

	[Token(Token = "0x601931D")]
	[Address(RVA = "0x36C1F88", Offset = "0x36C1F88", VA = "0x36C1F88", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x601931E")]
	[Address(RVA = "0x36C2034", Offset = "0x36C2034", VA = "0x36C2034", Slot = "1")]
	~AkPositionArray()
	{
	}

	[Token(Token = "0x601931F")]
	[Address(RVA = "0x36C2098", Offset = "0x36C2098", VA = "0x36C2098")]
	public void Reset()
	{
	}

	[Token(Token = "0x6019320")]
	[Address(RVA = "0x36C20AC", Offset = "0x36C20AC", VA = "0x36C20AC")]
	public void Add(Vector3 in_Pos, Vector3 in_Forward, Vector3 in_Top)
	{
	}
}
