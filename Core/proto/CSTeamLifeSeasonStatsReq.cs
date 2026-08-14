using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A7")]
public class CSTeamLifeSeasonStatsReq
{
	[Token(Token = "0x4009B05")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009B06")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x6007E01")]
	[Address(RVA = "0x309A320", Offset = "0x309A320", VA = "0x309A320")]
	public CSTeamLifeSeasonStatsReq()
	{
	}
}
