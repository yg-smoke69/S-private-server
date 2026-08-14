using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B06")]
public class HackLibsSoCheckNameDesc
{
	[Token(Token = "0x400A9EE")]
	[FieldOffset(Offset = "0x8")]
	public uint platform;

	[Token(Token = "0x400A9EF")]
	[FieldOffset(Offset = "0xC")]
	public List<string> check_name;

	[Token(Token = "0x400A9F0")]
	[FieldOffset(Offset = "0x10")]
	public uint check_count_limit;

	[Token(Token = "0x6008161")]
	[Address(RVA = "0x30A2D4C", Offset = "0x30A2D4C", VA = "0x30A2D4C")]
	public HackLibsSoCheckNameDesc()
	{
	}
}
