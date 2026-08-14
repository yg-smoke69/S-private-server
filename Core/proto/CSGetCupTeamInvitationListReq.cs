using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200157F")]
public class CSGetCupTeamInvitationListReq
{
	[Token(Token = "0x4009357")]
	[FieldOffset(Offset = "0x8")]
	public uint cup_type;

	[Token(Token = "0x4009358")]
	[FieldOffset(Offset = "0xC")]
	public uint cup_id;

	[Token(Token = "0x6007BC7")]
	[Address(RVA = "0x3183738", Offset = "0x3183738", VA = "0x3183738")]
	public CSGetCupTeamInvitationListReq()
	{
	}
}
