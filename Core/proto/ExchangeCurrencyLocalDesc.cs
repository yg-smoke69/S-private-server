using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ABE")]
public class ExchangeCurrencyLocalDesc
{
	[Token(Token = "0x400A857")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A858")]
	[FieldOffset(Offset = "0xC")]
	public string origin;

	[Token(Token = "0x400A859")]
	[FieldOffset(Offset = "0x10")]
	public string start_time;

	[Token(Token = "0x400A85A")]
	[FieldOffset(Offset = "0x14")]
	public string end_time;

	[Token(Token = "0x400A85B")]
	[FieldOffset(Offset = "0x18")]
	public uint go_pos;

	[Token(Token = "0x400A85C")]
	[FieldOffset(Offset = "0x1C")]
	public string sub_go_pos;

	[Token(Token = "0x600811B")]
	[Address(RVA = "0x309FD40", Offset = "0x309FD40", VA = "0x309FD40")]
	public ExchangeCurrencyLocalDesc()
	{
	}
}
