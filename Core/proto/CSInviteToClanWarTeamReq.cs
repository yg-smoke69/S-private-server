using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001656")]
public class CSInviteToClanWarTeamReq
{
	[Token(Token = "0x40095F7")]
	[FieldOffset(Offset = "0x8")]
	public ulong invitee_id;

	[Token(Token = "0x40095F8")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x6007CA0")]
	[Address(RVA = "0x3097430", Offset = "0x3097430", VA = "0x3097430")]
	public CSInviteToClanWarTeamReq()
	{
	}
}
