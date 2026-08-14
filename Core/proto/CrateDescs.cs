using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019D0")]
public class CrateDescs
{
	[Token(Token = "0x400A1BA")]
	[FieldOffset(Offset = "0x8")]
	public uint crate_id;

	[Token(Token = "0x400A1BB")]
	[FieldOffset(Offset = "0xC")]
	public List<CrateTreasureGroupDesc> treasure_group;

	[Token(Token = "0x6008028")]
	[Address(RVA = "0x309D720", Offset = "0x309D720", VA = "0x309D720")]
	public CrateDescs()
	{
	}
}
