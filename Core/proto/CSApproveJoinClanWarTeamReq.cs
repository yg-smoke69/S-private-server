using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001657")]
public class CSApproveJoinClanWarTeamReq
{
	[Token(Token = "0x40095F9")]
	[FieldOffset(Offset = "0x8")]
	public ulong inviter_id;

	[Token(Token = "0x40095FA")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x6007CA1")]
	[Address(RVA = "0x317DD28", Offset = "0x317DD28", VA = "0x317DD28")]
	public CSApproveJoinClanWarTeamReq()
	{
	}
}
