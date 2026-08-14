using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ABD")]
public class ExchangeCurrencyDesc
{
	[Token(Token = "0x400A853")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A854")]
	[FieldOffset(Offset = "0xC")]
	public uint type;

	[Token(Token = "0x400A855")]
	[FieldOffset(Offset = "0x10")]
	public uint subtype;

	[Token(Token = "0x400A856")]
	[FieldOffset(Offset = "0x14")]
	public string website;

	[Token(Token = "0x600811A")]
	[Address(RVA = "0x309FCA0", Offset = "0x309FCA0", VA = "0x309FCA0")]
	public ExchangeCurrencyDesc()
	{
	}
}
