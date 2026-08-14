using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016AB")]
public class CSCallbackDismissReq
{
	[Token(Token = "0x40096BC")]
	[FieldOffset(Offset = "0x8")]
	public ulong friend_id;

	[Token(Token = "0x40096BD")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x6007D0C")]
	[Address(RVA = "0x317E124", Offset = "0x317E124", VA = "0x317E124")]
	public CSCallbackDismissReq()
	{
	}
}
