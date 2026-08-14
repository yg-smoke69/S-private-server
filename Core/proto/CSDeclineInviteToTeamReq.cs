using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001790")]
public class CSDeclineInviteToTeamReq
{
	[Token(Token = "0x4009A94")]
	[FieldOffset(Offset = "0x8")]
	public ulong[] inviter_ids;

	[Token(Token = "0x6007DEA")]
	[Address(RVA = "0x317F580", Offset = "0x317F580", VA = "0x317F580")]
	public CSDeclineInviteToTeamReq()
	{
	}
}
