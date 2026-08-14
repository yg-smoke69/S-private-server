using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A06")]
public class MailContentDesc
{
	[Token(Token = "0x400A32D")]
	[FieldOffset(Offset = "0x8")]
	public uint type;

	[Token(Token = "0x400A32E")]
	[FieldOffset(Offset = "0xC")]
	public string title;

	[Token(Token = "0x400A32F")]
	[FieldOffset(Offset = "0x10")]
	public string content;

	[Token(Token = "0x600805E")]
	[Address(RVA = "0x30A736C", Offset = "0x30A736C", VA = "0x30A736C")]
	public MailContentDesc()
	{
	}
}
