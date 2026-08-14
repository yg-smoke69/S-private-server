using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B30")]
public class CustomEventCDNDesc
{
	[Token(Token = "0x400AAE7")]
	[FieldOffset(Offset = "0x8")]
	public uint cdn_id;

	[Token(Token = "0x400AAE8")]
	[FieldOffset(Offset = "0xC")]
	public string language;

	[Token(Token = "0x400AAE9")]
	[FieldOffset(Offset = "0x10")]
	public string cdn_url;

	[Token(Token = "0x600818B")]
	[Address(RVA = "0x309DFA8", Offset = "0x309DFA8", VA = "0x309DFA8")]
	public CustomEventCDNDesc()
	{
	}
}
