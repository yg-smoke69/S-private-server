using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BB6")]
public class FourSymbolsChatDesc
{
	[Token(Token = "0x400AE74")]
	[FieldOffset(Offset = "0x8")]
	public uint four_symbols_id;

	[Token(Token = "0x400AE75")]
	[FieldOffset(Offset = "0xC")]
	public string text_key;

	[Token(Token = "0x400AE76")]
	[FieldOffset(Offset = "0x10")]
	public string go_pos_key;

	[Token(Token = "0x400AE77")]
	[FieldOffset(Offset = "0x14")]
	public uint go_pos_id;

	[Token(Token = "0x400AE78")]
	[FieldOffset(Offset = "0x18")]
	public uint sub_go_pos_id;

	[Token(Token = "0x400AE79")]
	[FieldOffset(Offset = "0x1C")]
	public uint weight;

	[Token(Token = "0x6008211")]
	[Address(RVA = "0x30A0E70", Offset = "0x30A0E70", VA = "0x30A0E70")]
	public FourSymbolsChatDesc()
	{
	}
}
