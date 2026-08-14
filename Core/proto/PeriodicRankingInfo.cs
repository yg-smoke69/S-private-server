using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200192B")]
public class PeriodicRankingInfo
{
	[Token(Token = "0x4009EFE")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x4009EFF")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x4009F00")]
	[FieldOffset(Offset = "0x10")]
	public uint max_rank;

	[Token(Token = "0x4009F01")]
	[FieldOffset(Offset = "0x14")]
	public uint ranking_points;

	[Token(Token = "0x4009F02")]
	[FieldOffset(Offset = "0x18")]
	public uint game_played;

	[Token(Token = "0x4009F03")]
	[FieldOffset(Offset = "0x1C")]
	public uint game_round_played;

	[Token(Token = "0x6007F84")]
	[Address(RVA = "0x33DF480", Offset = "0x33DF480", VA = "0x33DF480")]
	public PeriodicRankingInfo()
	{
	}
}
