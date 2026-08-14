using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200178E")]
public class CSInviteToTeamReq
{
	[Token(Token = "0x4009A90")]
	[FieldOffset(Offset = "0x8")]
	public ulong invitee_id;

	[Token(Token = "0x4009A91")]
	[FieldOffset(Offset = "0x10")]
	public ulong team_id;

	[Token(Token = "0x6007DE8")]
	[Address(RVA = "0x3097440", Offset = "0x3097440", VA = "0x3097440")]
	public CSInviteToTeamReq()
	{
	}
}
