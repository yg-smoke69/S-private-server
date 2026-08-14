using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200169F")]
public class CSFriendInviteReq
{
	[Token(Token = "0x40096A1")]
	[FieldOffset(Offset = "0x8")]
	public ulong inviter_id;

	[Token(Token = "0x40096A2")]
	[FieldOffset(Offset = "0x10")]
	public uint activity_id;

	[Token(Token = "0x40096A3")]
	[FieldOffset(Offset = "0x14")]
	public bool is_friend;

	[Token(Token = "0x40096A4")]
	[FieldOffset(Offset = "0x18")]
	public uint sub_type;

	[Token(Token = "0x6007D00")]
	[Address(RVA = "0x31808BC", Offset = "0x31808BC", VA = "0x31808BC")]
	public CSFriendInviteReq()
	{
	}
}
