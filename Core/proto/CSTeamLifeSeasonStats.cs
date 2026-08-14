using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A6")]
public class CSTeamLifeSeasonStats
{
	[Token(Token = "0x4009B02")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009B03")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B04")]
	[FieldOffset(Offset = "0x14")]
	public List<TeamSeasonStats> stats;

	[Token(Token = "0x6007E00")]
	[Address(RVA = "0x309A294", Offset = "0x309A294", VA = "0x309A294")]
	public CSTeamLifeSeasonStats()
	{
	}
}
