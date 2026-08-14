using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B79")]
public class BooyahgoEventDesc
{
	[Token(Token = "0x400ACDB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ACDC")]
	[FieldOffset(Offset = "0xC")]
	public string event_title;

	[Token(Token = "0x400ACDD")]
	[FieldOffset(Offset = "0x10")]
	public string event_desc;

	[Token(Token = "0x400ACDE")]
	[FieldOffset(Offset = "0x14")]
	public string event_result;

	[Token(Token = "0x400ACDF")]
	[FieldOffset(Offset = "0x18")]
	public uint weight;

	[Token(Token = "0x60081D4")]
	[Address(RVA = "0x317CDC8", Offset = "0x317CDC8", VA = "0x317CDC8")]
	public BooyahgoEventDesc()
	{
	}
}
