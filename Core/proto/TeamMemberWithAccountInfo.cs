using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001788")]
public class TeamMemberWithAccountInfo
{
	[Token(Token = "0x4009A7F")]
	[FieldOffset(Offset = "0x8")]
	public AccountInfoBasic basic_info;

	[Token(Token = "0x4009A80")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x4009A81")]
	[FieldOffset(Offset = "0x18")]
	public uint member_type;

	[Token(Token = "0x4009A82")]
	[FieldOffset(Offset = "0x20")]
	public ulong join_at;

	[Token(Token = "0x4009A83")]
	[FieldOffset(Offset = "0x28")]
	public string region;

	[Token(Token = "0x6007DE2")]
	[Address(RVA = "0x33E3568", Offset = "0x33E3568", VA = "0x33E3568")]
	public TeamMemberWithAccountInfo()
	{
	}
}
