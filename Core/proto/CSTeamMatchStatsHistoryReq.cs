using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B2")]
public class CSTeamMatchStatsHistoryReq
{
	[Token(Token = "0x4009B28")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009B29")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B2A")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x6007E0C")]
	[Address(RVA = "0x309A328", Offset = "0x309A328", VA = "0x309A328")]
	public CSTeamMatchStatsHistoryReq()
	{
	}
}
