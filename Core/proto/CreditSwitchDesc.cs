using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001C02")]
public class CreditSwitchDesc
{
	[Token(Token = "0x400B041")]
	[FieldOffset(Offset = "0x8")]
	public bool credit_switch;

	[Token(Token = "0x400B042")]
	[FieldOffset(Offset = "0xC")]
	public string open_key;

	[Token(Token = "0x400B043")]
	[FieldOffset(Offset = "0x10")]
	public string close_key;

	[Token(Token = "0x600825D")]
	[Address(RVA = "0x309D928", Offset = "0x309D928", VA = "0x309D928")]
	public CreditSwitchDesc()
	{
	}
}
