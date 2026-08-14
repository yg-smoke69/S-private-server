using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace WwiseGameSyncs;

[Token(Token = "0x2003E77")]
public struct WwiseGameSyncID : _Attribute
{
	[Token(Token = "0x401A69F")]
	[FieldOffset(Offset = "0x0")]
	private readonly uint m_Value;

	[Token(Token = "0x401A6A0")]
	[FieldOffset(Offset = "0x0")]
	public static readonly WwiseGameSyncID INVALID;

	[Token(Token = "0x60196D2")]
	[Address(RVA = "0x93FA04", Offset = "0x93FA04", VA = "0x93FA04")]
	private WwiseGameSyncID(uint value)
	{
	}

	[Token(Token = "0x60196D3")]
	[Address(RVA = "0x336FB14", Offset = "0x336FB14", VA = "0x336FB14")]
	public static implicit operator uint(WwiseGameSyncID id)
	{
		return default(uint);
	}

	[Token(Token = "0x60196D4")]
	[Address(RVA = "0x336DABC", Offset = "0x336DABC", VA = "0x336DABC")]
	public static implicit operator WwiseGameSyncID(uint value)
	{
		return default(WwiseGameSyncID);
	}

	[Token(Token = "0x60196D5")]
	[Address(RVA = "0x336FB18", Offset = "0x336FB18", VA = "0x336FB18")]
	public static bool operator ==(WwiseGameSyncID a, WwiseGameSyncID b)
	{
		return default(bool);
	}

	[Token(Token = "0x60196D6")]
	[Address(RVA = "0x336FB2C", Offset = "0x336FB2C", VA = "0x336FB2C")]
	public static bool operator !=(WwiseGameSyncID a, WwiseGameSyncID b)
	{
		return default(bool);
	}

	[Token(Token = "0x60196D7")]
	[Address(RVA = "0x93FA0C", Offset = "0x93FA0C", VA = "0x93FA0C", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x60196D8")]
	[Address(RVA = "0x93FA34", Offset = "0x93FA34", VA = "0x93FA34", Slot = "4")]
	public bool Equals(WwiseGameSyncID other)
	{
		return default(bool);
	}

	[Token(Token = "0x60196D9")]
	[Address(RVA = "0x93FA48", Offset = "0x93FA48", VA = "0x93FA48", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60196DA")]
	[Address(RVA = "0x93FA50", Offset = "0x93FA50", VA = "0x93FA50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
