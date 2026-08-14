using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B75")]
public class MonopolyEventOption
{
	[Token(Token = "0x400ACB9")]
	[FieldOffset(Offset = "0x8")]
	public string event_option;

	[Token(Token = "0x400ACBA")]
	[FieldOffset(Offset = "0xC")]
	public string event_result;

	[Token(Token = "0x400ACBB")]
	[FieldOffset(Offset = "0x10")]
	public EMiniGame.MonopolyEventResultType event_result_type;

	[Token(Token = "0x400ACBC")]
	[FieldOffset(Offset = "0x14")]
	public uint event_result_value;

	[Token(Token = "0x60081D0")]
	[Address(RVA = "0x30A8F84", Offset = "0x30A8F84", VA = "0x30A8F84")]
	public MonopolyEventOption()
	{
	}
}
