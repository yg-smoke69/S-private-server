using System;
using Il2CppDummyDll;

namespace UMA;

[Serializable]
[Token(Token = "0x2003CFA")]
public struct IntFlags
{
	[Token(Token = "0x4019E49")]
	[FieldOffset(Offset = "0x0")]
	public uint Bits;

	[Token(Token = "0x60186AF")]
	[Address(RVA = "0x93CC7C", Offset = "0x93CC7C", VA = "0x93CC7C")]
	public bool HasBit(uint bit, int eShift = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60186B0")]
	[Address(RVA = "0x93CC94", Offset = "0x93CC94", VA = "0x93CC94")]
	public bool HasBits(uint bits, int eShift = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60186B1")]
	[Address(RVA = "0x93CCB0", Offset = "0x93CCB0", VA = "0x93CCB0")]
	public void SetBits(uint bit, int eShift = 0)
	{
	}

	[Token(Token = "0x60186B2")]
	[Address(RVA = "0x93CCC4", Offset = "0x93CCC4", VA = "0x93CCC4")]
	public void UnSetBits(uint bit, int eShift = 0)
	{
	}

	[Token(Token = "0x60186B3")]
	[Address(RVA = "0x224CFE8", Offset = "0x224CFE8", VA = "0x224CFE8")]
	public static uint IndexToBit(int i)
	{
		return default(uint);
	}

	[Token(Token = "0x60186B4")]
	[Address(RVA = "0x93CCD8", Offset = "0x93CCD8", VA = "0x93CCD8")]
	public bool HasBitAt(int i)
	{
		return default(bool);
	}

	[Token(Token = "0x60186B5")]
	[Address(RVA = "0x93CCF4", Offset = "0x93CCF4", VA = "0x93CCF4")]
	public void SetBitAt(int i)
	{
	}

	[Token(Token = "0x60186B6")]
	[Address(RVA = "0x93CD0C", Offset = "0x93CD0C", VA = "0x93CD0C")]
	public int GetBitIndex(uint mask = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x60186B7")]
	public static uint EnumToBit<T>(T t, int eShift = 0) where T : struct, IConvertible
	{
		return default(uint);
	}

	[Token(Token = "0x60186B8")]
	public bool HasBitAt<T>(T t, int eShift = 0) where T : struct, IConvertible
	{
		return default(bool);
	}

	[Token(Token = "0x60186B9")]
	public void SetBitAt<T>(T t, int eShift = 0) where T : struct, IConvertible
	{
	}

	[Token(Token = "0x60186BA")]
	public void UnSetBitAt<T>(T t, int eShift = 0) where T : struct, IConvertible
	{
	}
}
