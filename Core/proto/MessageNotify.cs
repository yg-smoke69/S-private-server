using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001375")]
public class MessageNotify
{
	[Token(Token = "0x4008993")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4008994")]
	[FieldOffset(Offset = "0x10")]
	public uint protocol;

	[Token(Token = "0x4008995")]
	[FieldOffset(Offset = "0x14")]
	public uint ret;

	[Token(Token = "0x4008996")]
	[FieldOffset(Offset = "0x18")]
	public uint cmd;

	[Token(Token = "0x4008997")]
	[FieldOffset(Offset = "0x1C")]
	public byte[] content;

	[Token(Token = "0x6007A76")]
	[Address(RVA = "0x30A88D0", Offset = "0x30A88D0", VA = "0x30A88D0")]
	public MessageNotify()
	{
	}
}
