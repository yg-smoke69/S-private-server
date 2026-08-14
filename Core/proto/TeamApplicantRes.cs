using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001781")]
public class TeamApplicantRes
{
	[Token(Token = "0x4009A62")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009A63")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x4009A64")]
	[FieldOffset(Offset = "0x18")]
	public ulong create_at;

	[Token(Token = "0x6007DDB")]
	[Address(RVA = "0x33E32B8", Offset = "0x33E32B8", VA = "0x33E32B8")]
	public TeamApplicantRes()
	{
	}
}
