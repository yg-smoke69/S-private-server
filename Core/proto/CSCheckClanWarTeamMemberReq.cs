using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200165C")]
public class CSCheckClanWarTeamMemberReq
{
	[Token(Token = "0x4009604")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x4009605")]
	[FieldOffset(Offset = "0x10")]
	public uint system_platform;

	[Token(Token = "0x4009606")]
	[FieldOffset(Offset = "0x14")]
	public MatchClientInfo client_info;

	[Token(Token = "0x6007CA6")]
	[Address(RVA = "0x317E2D4", Offset = "0x317E2D4", VA = "0x317E2D4")]
	public CSCheckClanWarTeamMemberReq()
	{
	}
}
