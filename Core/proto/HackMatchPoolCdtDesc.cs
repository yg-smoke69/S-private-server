using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019EE")]
public class HackMatchPoolCdtDesc
{
	[Token(Token = "0x400A2D2")]
	[FieldOffset(Offset = "0x8")]
	public uint cdt_id;

	[Token(Token = "0x400A2D3")]
	[FieldOffset(Offset = "0xC")]
	public bool @switch;

	[Token(Token = "0x400A2D4")]
	[FieldOffset(Offset = "0x10")]
	public List<HackerPoolCdt> hacker_cdt;

	[Token(Token = "0x6008046")]
	[Address(RVA = "0x30A2DD8", Offset = "0x30A2DD8", VA = "0x30A2DD8")]
	public HackMatchPoolCdtDesc()
	{
	}
}
