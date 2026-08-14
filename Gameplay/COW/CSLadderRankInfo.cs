using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002FD6")]
public class CSLadderRankInfo
{
	[Token(Token = "0x401235F")]
	[FieldOffset(Offset = "0x8")]
	public uint season_id;

	[Token(Token = "0x4012360")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x4012361")]
	[FieldOffset(Offset = "0x10")]
	public uint max_rank;

	[Token(Token = "0x4012362")]
	[FieldOffset(Offset = "0x14")]
	public uint ranking_points;

	[Token(Token = "0x4012363")]
	[FieldOffset(Offset = "0x18")]
	public uint peak_rank_pos;

	[Token(Token = "0x4012364")]
	[FieldOffset(Offset = "0x1C")]
	public bool show_rank;

	[Token(Token = "0x4012365")]
	[FieldOffset(Offset = "0x20")]
	public uint stars;

	[Token(Token = "0x4012366")]
	[FieldOffset(Offset = "0x24")]
	public bool is_hang_up_ban;

	[Token(Token = "0x4012367")]
	[FieldOffset(Offset = "0x28")]
	public uint star_protect_points;

	[Token(Token = "0x4012368")]
	[FieldOffset(Offset = "0x2C")]
	public bool reset_reward;

	[Token(Token = "0x4012369")]
	[FieldOffset(Offset = "0x30")]
	public uint season_reset_rank;

	[Token(Token = "0x401236A")]
	[FieldOffset(Offset = "0x34")]
	public uint games_played;

	[Token(Token = "0x6013FC5")]
	[Address(RVA = "0x1820C9C", Offset = "0x1820C9C", VA = "0x1820C9C")]
	public CSLadderRankInfo()
	{
	}
}
