using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200152E")]
public class RankingPointsDetail
{
	[Token(Token = "0x40091FA")]
	[FieldOffset(Offset = "0x8")]
	public int ranking_score;

	[Token(Token = "0x40091FB")]
	[FieldOffset(Offset = "0xC")]
	public int battle_score;

	[Token(Token = "0x40091FC")]
	[FieldOffset(Offset = "0x10")]
	public int newbie_score;

	[Token(Token = "0x40091FD")]
	[FieldOffset(Offset = "0x14")]
	public int victory_score;

	[Token(Token = "0x40091FE")]
	[FieldOffset(Offset = "0x18")]
	public int first_win_score;

	[Token(Token = "0x40091FF")]
	[FieldOffset(Offset = "0x1C")]
	public bool chicken_protect;

	[Token(Token = "0x4009200")]
	[FieldOffset(Offset = "0x20")]
	public int birth_island_quit_score;

	[Token(Token = "0x4009201")]
	[FieldOffset(Offset = "0x24")]
	public int scale_ranking_score;

	[Token(Token = "0x4009202")]
	[FieldOffset(Offset = "0x28")]
	public int scale_battle_score;

	[Token(Token = "0x4009203")]
	[FieldOffset(Offset = "0x2C")]
	public int veteran_score;

	[Token(Token = "0x4009204")]
	[FieldOffset(Offset = "0x30")]
	public int rankingtask_score;

	[Token(Token = "0x6007B77")]
	[Address(RVA = "0x33E0C5C", Offset = "0x33E0C5C", VA = "0x33E0C5C")]
	public RankingPointsDetail()
	{
	}
}
