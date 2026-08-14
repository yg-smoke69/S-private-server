using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B2")]
public class SepcialFriendsAppsRes
{
	[Token(Token = "0x40096C6")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x40096C7")]
	[FieldOffset(Offset = "0x10")]
	public long request_time;

	[Token(Token = "0x40096C8")]
	[FieldOffset(Offset = "0x18")]
	public uint relation_type;

	[Token(Token = "0x40096C9")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_create;

	[Token(Token = "0x6007D13")]
	[Address(RVA = "0x33E21F4", Offset = "0x33E21F4", VA = "0x33E21F4")]
	public SepcialFriendsAppsRes()
	{
	}
}
