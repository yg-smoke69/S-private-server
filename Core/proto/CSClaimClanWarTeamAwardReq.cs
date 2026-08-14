using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200165E")]
public class CSClaimClanWarTeamAwardReq
{
	[Token(Token = "0x4009608")]
	[FieldOffset(Offset = "0x8")]
	public uint award_level;

	[Token(Token = "0x4009609")]
	[FieldOffset(Offset = "0x10")]
	public ulong clan_id;

	[Token(Token = "0x6007CA8")]
	[Address(RVA = "0x317E578", Offset = "0x317E578", VA = "0x317E578")]
	public CSClaimClanWarTeamAwardReq()
	{
	}
}
