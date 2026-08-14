using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20030C9")]
public class LadderRankInfo
{
	[Token(Token = "0x40128D8")]
	[FieldOffset(Offset = "0x8")]
	public int Rank;

	[Token(Token = "0x40128D9")]
	[FieldOffset(Offset = "0xC")]
	public int LadderScore;

	[Token(Token = "0x40128DA")]
	[FieldOffset(Offset = "0x10")]
	public int PeakRankPos;

	[Token(Token = "0x40128DB")]
	[FieldOffset(Offset = "0x14")]
	public bool GotNextRankAwards;

	[Token(Token = "0x40128DC")]
	[FieldOffset(Offset = "0x18")]
	public int MaxRank;

	[Token(Token = "0x40128DD")]
	[FieldOffset(Offset = "0x1C")]
	public bool reset_reward;

	[Token(Token = "0x40128DE")]
	[FieldOffset(Offset = "0x20")]
	public uint season_reset_rank;

	[Token(Token = "0x40128DF")]
	[FieldOffset(Offset = "0x24")]
	public uint games_played;

	[Token(Token = "0x6014717")]
	[Address(RVA = "0x1EF7174", Offset = "0x1EF7174", VA = "0x1EF7174")]
	public LadderRankInfo()
	{
	}
}
