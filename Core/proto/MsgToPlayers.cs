using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001377")]
public class MsgToPlayers
{
	[Token(Token = "0x4008999")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] account_ids;

	[Token(Token = "0x400899A")]
	[FieldOffset(Offset = "0xC")]
	public uint protocol;

	[Token(Token = "0x400899B")]
	[FieldOffset(Offset = "0x10")]
	public uint ret;

	[Token(Token = "0x400899C")]
	[FieldOffset(Offset = "0x14")]
	public uint cmd;

	[Token(Token = "0x400899D")]
	[FieldOffset(Offset = "0x18")]
	public byte[] content;

	[Token(Token = "0x6007A78")]
	[Address(RVA = "0x30A90C4", Offset = "0x30A90C4", VA = "0x30A90C4")]
	public MsgToPlayers()
	{
	}
}
