using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001783")]
public class TeamInvitationRes
{
	[Token(Token = "0x4009A66")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009A67")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x4009A68")]
	[FieldOffset(Offset = "0x18")]
	public ulong inviter_id;

	[Token(Token = "0x4009A69")]
	[FieldOffset(Offset = "0x20")]
	public ulong create_at;

	[Token(Token = "0x6007DDD")]
	[Address(RVA = "0x33E3430", Offset = "0x33E3430", VA = "0x33E3430")]
	public TeamInvitationRes()
	{
	}
}
