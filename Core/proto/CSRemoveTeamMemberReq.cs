using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001791")]
public class CSRemoveTeamMemberReq
{
	[Token(Token = "0x4009A95")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009A96")]
	[FieldOffset(Offset = "0x10")]
	public ulong removee_id;

	[Token(Token = "0x6007DEB")]
	[Address(RVA = "0x30991CC", Offset = "0x30991CC", VA = "0x30991CC")]
	public CSRemoveTeamMemberReq()
	{
	}
}
