using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016A9")]
public class CSConfirmSpecialRelationReq
{
	[Token(Token = "0x40096B6")]
	[FieldOffset(Offset = "0x8")]
	public ulong friend_id;

	[Token(Token = "0x40096B7")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x40096B8")]
	[FieldOffset(Offset = "0x14")]
	public bool is_create;

	[Token(Token = "0x6007D0A")]
	[Address(RVA = "0x317F158", Offset = "0x317F158", VA = "0x317F158")]
	public CSConfirmSpecialRelationReq()
	{
	}
}
