using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016F4")]
public class CSLoginDescReq
{
	[Token(Token = "0x4009805")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x4009806")]
	[FieldOffset(Offset = "0xC")]
	public uint platform;

	[Token(Token = "0x4009807")]
	[FieldOffset(Offset = "0x10")]
	public string country_code;

	[Token(Token = "0x4009808")]
	[FieldOffset(Offset = "0x14")]
	public uint client_type;

	[Token(Token = "0x6007D4E")]
	[Address(RVA = "0x30976FC", Offset = "0x30976FC", VA = "0x30976FC")]
	public CSLoginDescReq()
	{
	}
}
