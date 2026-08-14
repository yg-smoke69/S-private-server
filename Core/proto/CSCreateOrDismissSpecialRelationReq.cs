using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016A8")]
public class CSCreateOrDismissSpecialRelationReq
{
	[Token(Token = "0x40096B3")]
	[FieldOffset(Offset = "0x8")]
	public ulong friend_id;

	[Token(Token = "0x40096B4")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x40096B5")]
	[FieldOffset(Offset = "0x14")]
	public bool is_create;

	[Token(Token = "0x6007D09")]
	[Address(RVA = "0x317F2E4", Offset = "0x317F2E4", VA = "0x317F2E4")]
	public CSCreateOrDismissSpecialRelationReq()
	{
	}
}
