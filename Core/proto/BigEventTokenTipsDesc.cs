using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B49")]
public class BigEventTokenTipsDesc
{
	[Token(Token = "0x400ABAB")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400ABAC")]
	[FieldOffset(Offset = "0xC")]
	public uint token_id;

	[Token(Token = "0x400ABAD")]
	[FieldOffset(Offset = "0x10")]
	public string way;

	[Token(Token = "0x400ABAE")]
	[FieldOffset(Offset = "0x14")]
	public uint go_pos;

	[Token(Token = "0x400ABAF")]
	[FieldOffset(Offset = "0x18")]
	public ELimitedEvent.EventID event_id;

	[Token(Token = "0x400ABB0")]
	[FieldOffset(Offset = "0x1C")]
	public string sub_go_pos;

	[Token(Token = "0x60081A4")]
	[Address(RVA = "0x317C4A4", Offset = "0x317C4A4", VA = "0x317C4A4")]
	public BigEventTokenTipsDesc()
	{
	}
}
