using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018FC")]
public class UGCTeamStats
{
	[Token(Token = "0x4009E5E")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_index;

	[Token(Token = "0x4009E5F")]
	[FieldOffset(Offset = "0x10")]
	public int team_score;

	[Token(Token = "0x4009E60")]
	[FieldOffset(Offset = "0x14")]
	public uint team_rank;

	[Token(Token = "0x4009E61")]
	[FieldOffset(Offset = "0x18")]
	public bool is_quit;

	[Token(Token = "0x4009E62")]
	[FieldOffset(Offset = "0x1C")]
	public List<UGCPlayerStats> all_teammates;

	[Token(Token = "0x6007F55")]
	[Address(RVA = "0x33E3FE4", Offset = "0x33E3FE4", VA = "0x33E3FE4")]
	public UGCTeamStats()
	{
	}
}
