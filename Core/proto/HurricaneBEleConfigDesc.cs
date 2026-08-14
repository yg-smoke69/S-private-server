using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF9")]
public class HurricaneBEleConfigDesc
{
	[Token(Token = "0x400B01D")]
	[FieldOffset(Offset = "0x8")]
	public uint level_id;

	[Token(Token = "0x400B01E")]
	[FieldOffset(Offset = "0xC")]
	public List<HurricaneBLine> ele_lines;

	[Token(Token = "0x6008254")]
	[Address(RVA = "0x30A3238", Offset = "0x30A3238", VA = "0x30A3238")]
	public HurricaneBEleConfigDesc()
	{
	}
}
