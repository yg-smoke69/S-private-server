using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC1")]
public class MocoMonthChatDesc
{
	[Token(Token = "0x400AEB0")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x400AEB1")]
	[FieldOffset(Offset = "0xC")]
	public uint condition;

	[Token(Token = "0x400AEB2")]
	[FieldOffset(Offset = "0x10")]
	public string chat_key;

	[Token(Token = "0x400AEB3")]
	[FieldOffset(Offset = "0x14")]
	public string reply_key;

	[Token(Token = "0x600821C")]
	[Address(RVA = "0x30A8A24", Offset = "0x30A8A24", VA = "0x30A8A24")]
	public MocoMonthChatDesc()
	{
	}
}
