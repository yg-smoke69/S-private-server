using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200157D")]
public class CSDeclineJoinCupTeamApplicationReq
{
	[Token(Token = "0x4009352")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] applicant_ids;

	[Token(Token = "0x4009353")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007BC5")]
	[Address(RVA = "0x317F590", Offset = "0x317F590", VA = "0x317F590")]
	public CSDeclineJoinCupTeamApplicationReq()
	{
	}
}
