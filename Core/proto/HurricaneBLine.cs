using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BFA")]
public class HurricaneBLine
{
	[Token(Token = "0x400B01F")]
	[FieldOffset(Offset = "0x8")]
	public uint line_id;

	[Token(Token = "0x400B020")]
	[FieldOffset(Offset = "0xC")]
	public uint[] cells_value;

	[Token(Token = "0x6008255")]
	[Address(RVA = "0x30A3424", Offset = "0x30A3424", VA = "0x30A3424")]
	public HurricaneBLine()
	{
	}
}
