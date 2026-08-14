using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B8")]
public class CSClaimIntimacyAwardReq
{
	[Token(Token = "0x40096D3")]
	[FieldOffset(Offset = "0x8")]
	public ulong related_friend_id;

	[Token(Token = "0x40096D4")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x40096D5")]
	[FieldOffset(Offset = "0x14")]
	public uint intimacy_level;

	[Token(Token = "0x6007D19")]
	[Address(RVA = "0x317E7D0", Offset = "0x317E7D0", VA = "0x317E7D0")]
	public CSClaimIntimacyAwardReq()
	{
	}
}
