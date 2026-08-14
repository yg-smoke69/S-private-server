using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019AD")]
public class ChatItemDesc
{
	[Token(Token = "0x400A0FF")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400A100")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x400A101")]
	[FieldOffset(Offset = "0x10")]
	public uint coins_price;

	[Token(Token = "0x400A102")]
	[FieldOffset(Offset = "0x14")]
	public uint gems_price;

	[Token(Token = "0x400A103")]
	[FieldOffset(Offset = "0x18")]
	public uint gopos;

	[Token(Token = "0x6008004")]
	[Address(RVA = "0x309B264", Offset = "0x309B264", VA = "0x309B264")]
	public ChatItemDesc()
	{
	}
}
