using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AC9")]
public class FriendIntimacyDesc
{
	[Token(Token = "0x400A8A7")]
	[FieldOffset(Offset = "0x8")]
	public EFriend.IntimacyType type;

	[Token(Token = "0x400A8A8")]
	[FieldOffset(Offset = "0xC")]
	public uint intimacy;

	[Token(Token = "0x400A8A9")]
	[FieldOffset(Offset = "0x10")]
	public bool enable;

	[Token(Token = "0x400A8AA")]
	[FieldOffset(Offset = "0x14")]
	public uint match_mode;

	[Token(Token = "0x400A8AB")]
	[FieldOffset(Offset = "0x18")]
	public uint game_mode;

	[Token(Token = "0x6008126")]
	[Address(RVA = "0x30A13FC", Offset = "0x30A13FC", VA = "0x30A13FC")]
	public FriendIntimacyDesc()
	{
	}
}
