using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001428")]
public class GetTeamChampionshipInfoStatsReq
{
	[Token(Token = "0x4008C73")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x4008C74")]
	[FieldOffset(Offset = "0xC")]
	public uint championship_id;

	[Token(Token = "0x4008C75")]
	[FieldOffset(Offset = "0x10")]
	public ulong[] team_ids;

	[Token(Token = "0x6007AE5")]
	[Address(RVA = "0x30A2368", Offset = "0x30A2368", VA = "0x30A2368")]
	public GetTeamChampionshipInfoStatsReq()
	{
	}
}
