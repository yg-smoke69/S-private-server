using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Checksums;

[Token(Token = "0x2003BDE")]
public sealed class Adler32 : _Attribute
{
	[Token(Token = "0x401986D")]
	private const uint BASE = 65521u;

	[Token(Token = "0x401986E")]
	[FieldOffset(Offset = "0x8")]
	private uint checksum;

	[Token(Token = "0x170018FC")]
	public long Value
	{
		[Token(Token = "0x6017E11")]
		[Address(RVA = "0x3518574", Offset = "0x3518574", VA = "0x3518574", Slot = "4")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x6017E10")]
	[Address(RVA = "0x3518548", Offset = "0x3518548", VA = "0x3518548")]
	public Adler32()
	{
	}

	[Token(Token = "0x6017E12")]
	[Address(RVA = "0x3518568", Offset = "0x3518568", VA = "0x3518568", Slot = "5")]
	public void Reset()
	{
	}

	[Token(Token = "0x6017E13")]
	[Address(RVA = "0x3518580", Offset = "0x3518580", VA = "0x3518580", Slot = "6")]
	public void Update(int value)
	{
	}

	[Token(Token = "0x6017E14")]
	[Address(RVA = "0x35185C8", Offset = "0x35185C8", VA = "0x35185C8", Slot = "7")]
	public void Update(byte[] buffer)
	{
	}

	[Token(Token = "0x6017E15")]
	[Address(RVA = "0x3518694", Offset = "0x3518694", VA = "0x3518694", Slot = "8")]
	public void Update(byte[] buffer, int offset, int count)
	{
	}
}
