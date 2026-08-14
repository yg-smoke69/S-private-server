using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums;

[Token(Token = "0x2003BDF")]
public sealed class Crc32 : _Attribute
{
	[Token(Token = "0x401986F")]
	private const uint CrcSeed = uint.MaxValue;

	[Token(Token = "0x4019870")]
	[FieldOffset(Offset = "0x0")]
	private static readonly uint[] CrcTable;

	[Token(Token = "0x4019871")]
	[FieldOffset(Offset = "0x8")]
	private uint crc;

	[Token(Token = "0x170018FD")]
	public long Value
	{
		[Token(Token = "0x6017E19")]
		[Address(RVA = "0x3518C40", Offset = "0x3518C40", VA = "0x3518C40", Slot = "4")]
		get
		{
			return default(long);
		}
		[Token(Token = "0x6017E1A")]
		[Address(RVA = "0x3518C4C", Offset = "0x3518C4C", VA = "0x3518C4C")]
		set
		{
		}
	}

	[Token(Token = "0x6017E16")]
	[Address(RVA = "0x35189A8", Offset = "0x35189A8", VA = "0x35189A8")]
	public Crc32()
	{
	}

	[Token(Token = "0x6017E17")]
	[Address(RVA = "0x35189B0", Offset = "0x35189B0", VA = "0x35189B0")]
	internal static uint ComputeCrc32(uint oldCrc, byte value)
	{
		return default(uint);
	}

	[Token(Token = "0x6017E18")]
	[Address(RVA = "0x3518A84", Offset = "0x3518A84", VA = "0x3518A84")]
	public static uint GetCrc32(string msg)
	{
		return default(uint);
	}

	[Token(Token = "0x6017E1B")]
	[Address(RVA = "0x3518C54", Offset = "0x3518C54", VA = "0x3518C54", Slot = "5")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017E1C")]
	[Address(RVA = "0x3518C60", Offset = "0x3518C60", VA = "0x3518C60", Slot = "6")]
	public void Update(int value)
	{
	}

	[Token(Token = "0x6017E1D")]
	[Address(RVA = "0x3518D50", Offset = "0x3518D50", VA = "0x3518D50", Slot = "7")]
	public void Update(byte[] buffer)
	{
	}

	[Token(Token = "0x6017E1E")]
	[Address(RVA = "0x3518E1C", Offset = "0x3518E1C", VA = "0x3518E1C", Slot = "8")]
	public void Update(byte[] buffer, int offset, int count)
	{
	}
}
