using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A3")]
public class CSTeamChampionshipSeasonStatsReq
{
	[Token(Token = "0x4009AEE")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009AEF")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009AF0")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009AF1")]
	[FieldOffset(Offset = "0x18")]
	public bool need_members_info;

	[Token(Token = "0x6007DFD")]
	[Address(RVA = "0x309A154", Offset = "0x309A154", VA = "0x309A154")]
	public CSTeamChampionshipSeasonStatsReq()
	{
	}
}
