using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BF8")]
public class HurricaneBMapShapeDesc
{
	[Token(Token = "0x400B01B")]
	[FieldOffset(Offset = "0x8")]
	public uint level_id;

	[Token(Token = "0x400B01C")]
	[FieldOffset(Offset = "0xC")]
	public List<HurricaneBLine> map_lines;

	[Token(Token = "0x6008253")]
	[Address(RVA = "0x30A342C", Offset = "0x30A342C", VA = "0x30A342C")]
	public HurricaneBMapShapeDesc()
	{
	}
}
