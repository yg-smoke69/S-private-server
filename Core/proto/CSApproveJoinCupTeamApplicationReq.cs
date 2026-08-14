using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200157C")]
public class CSApproveJoinCupTeamApplicationReq
{
	[Token(Token = "0x4009350")]
	[FieldOffset(Offset = "0x8")]
	public ulong applicant_id;

	[Token(Token = "0x4009351")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007BC4")]
	[Address(RVA = "0x317DD30", Offset = "0x317DD30", VA = "0x317DD30")]
	public CSApproveJoinCupTeamApplicationReq()
	{
	}
}
