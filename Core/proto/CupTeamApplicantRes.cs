using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001589")]
public class CupTeamApplicantRes
{
	[Token(Token = "0x4009370")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009371")]
	[FieldOffset(Offset = "0x10")]
	public uint tier;

	[Token(Token = "0x4009372")]
	[FieldOffset(Offset = "0x18")]
	public ulong cup_team_id;

	[Token(Token = "0x4009373")]
	[FieldOffset(Offset = "0x20")]
	public ulong create_at;

	[Token(Token = "0x6007BD1")]
	[Address(RVA = "0x309DEA0", Offset = "0x309DEA0", VA = "0x309DEA0")]
	public CupTeamApplicantRes()
	{
	}
}
