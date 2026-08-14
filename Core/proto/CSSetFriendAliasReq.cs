using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B0")]
public class CSSetFriendAliasReq
{
	[Token(Token = "0x40096C3")]
	[FieldOffset(Offset = "0x8")]
	public ulong friend_id;

	[Token(Token = "0x40096C4")]
	[FieldOffset(Offset = "0x10")]
	public string alias;

	[Token(Token = "0x6007D11")]
	[Address(RVA = "0x3099A98", Offset = "0x3099A98", VA = "0x3099A98")]
	public CSSetFriendAliasReq()
	{
	}
}
