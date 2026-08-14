using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001697")]
public class CSFriendReq
{
	[Token(Token = "0x4009682")]
	[FieldOffset(Offset = "0x8")]
	public ulong adder;

	[Token(Token = "0x4009683")]
	[FieldOffset(Offset = "0x10")]
	public ulong addee;

	[Token(Token = "0x4009684")]
	[FieldOffset(Offset = "0x18")]
	public uint add_from;

	[Token(Token = "0x4009685")]
	[FieldOffset(Offset = "0x1C")]
	public uint friend_tag;

	[Token(Token = "0x6007CF2")]
	[Address(RVA = "0x31808C4", Offset = "0x31808C4", VA = "0x31808C4")]
	public CSFriendReq()
	{
	}
}
