using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017B1")]
public class TeamChampionshipMatchStats
{
	[Token(Token = "0x4009B1E")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009B1F")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009B20")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009B21")]
	[FieldOffset(Offset = "0x18")]
	public ulong match_id;

	[Token(Token = "0x4009B22")]
	[FieldOffset(Offset = "0x20")]
	public uint create_time;

	[Token(Token = "0x4009B23")]
	[FieldOffset(Offset = "0x24")]
	public uint end_time;

	[Token(Token = "0x4009B24")]
	[FieldOffset(Offset = "0x28")]
	public int score;

	[Token(Token = "0x4009B25")]
	[FieldOffset(Offset = "0x2C")]
	public EChampionship.ChampionshipPhase phase;

	[Token(Token = "0x4009B26")]
	[FieldOffset(Offset = "0x30")]
	public bool is_invalid;

	[Token(Token = "0x4009B27")]
	[FieldOffset(Offset = "0x34")]
	public TeamMatchStats team_match_stats;

	[Token(Token = "0x6007E0B")]
	[Address(RVA = "0x33E3354", Offset = "0x33E3354", VA = "0x33E3354")]
	public TeamChampionshipMatchStats()
	{
	}
}
