using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016AA")]
public class CSDeclineSpecialFriendReq
{
	[Token(Token = "0x40096B9")]
	[FieldOffset(Offset = "0x8")]
	public ulong friend_id;

	[Token(Token = "0x40096BA")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x40096BB")]
	[FieldOffset(Offset = "0x14")]
	public bool is_create;

	[Token(Token = "0x6007D0B")]
	[Address(RVA = "0x317F598", Offset = "0x317F598", VA = "0x317F598")]
	public CSDeclineSpecialFriendReq()
	{
	}
}
