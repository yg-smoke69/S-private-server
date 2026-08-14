using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001661")]
public class ClanWarTeamMatchStats
{
	[Token(Token = "0x400960D")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400960E")]
	[FieldOffset(Offset = "0x10")]
	public uint team_arms;

	[Token(Token = "0x400960F")]
	[FieldOffset(Offset = "0x14")]
	public bool win;

	[Token(Token = "0x4009610")]
	[FieldOffset(Offset = "0x18")]
	public uint team_kills;

	[Token(Token = "0x6007CAB")]
	[Address(RVA = "0x309C45C", Offset = "0x309C45C", VA = "0x309C45C")]
	public ClanWarTeamMatchStats()
	{
	}
}
