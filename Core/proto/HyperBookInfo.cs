using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200198A")]
public class HyperBookInfo
{
	[Token(Token = "0x400A00B")]
	[FieldOffset(Offset = "0x8")]
	public uint book_id;

	[Token(Token = "0x400A00C")]
	[FieldOffset(Offset = "0xC")]
	public List<HyperBookPage> pages;

	[Token(Token = "0x400A00D")]
	[FieldOffset(Offset = "0x10")]
	public uint spin_num;

	[Token(Token = "0x6007FE5")]
	[Address(RVA = "0x30A36A4", Offset = "0x30A36A4", VA = "0x30A36A4")]
	public HyperBookInfo()
	{
	}
}
