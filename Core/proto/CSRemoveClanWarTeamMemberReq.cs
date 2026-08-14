using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001658")]
public class CSRemoveClanWarTeamMemberReq
{
	[Token(Token = "0x40095FB")]
	[FieldOffset(Offset = "0x8")]
	public ulong removee_id;

	[Token(Token = "0x40095FC")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x6007CA2")]
	[Address(RVA = "0x30990F8", Offset = "0x30990F8", VA = "0x30990F8")]
	public CSRemoveClanWarTeamMemberReq()
	{
	}
}
