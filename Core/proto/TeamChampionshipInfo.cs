using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200179C")]
public class TeamChampionshipInfo
{
	[Token(Token = "0x4009ABB")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4009ABC")]
	[FieldOffset(Offset = "0x10")]
	public uint championship_type;

	[Token(Token = "0x4009ABD")]
	[FieldOffset(Offset = "0x14")]
	public uint championship_id;

	[Token(Token = "0x4009ABE")]
	[FieldOffset(Offset = "0x18")]
	public uint tickets_num;

	[Token(Token = "0x4009ABF")]
	[FieldOffset(Offset = "0x1C")]
	public uint trial_games_played;

	[Token(Token = "0x4009AC0")]
	[FieldOffset(Offset = "0x20")]
	public uint trial_kills;

	[Token(Token = "0x4009AC1")]
	[FieldOffset(Offset = "0x24")]
	public uint trial_valid_score;

	[Token(Token = "0x4009AC2")]
	[FieldOffset(Offset = "0x28")]
	public uint trial_total_score;

	[Token(Token = "0x4009AC3")]
	[FieldOffset(Offset = "0x2C")]
	public uint trial_pos;

	[Token(Token = "0x4009AC4")]
	[FieldOffset(Offset = "0x30")]
	public bool is_enter_final;

	[Token(Token = "0x4009AC5")]
	[FieldOffset(Offset = "0x34")]
	public uint final_games_played;

	[Token(Token = "0x4009AC6")]
	[FieldOffset(Offset = "0x38")]
	public uint final_kills;

	[Token(Token = "0x4009AC7")]
	[FieldOffset(Offset = "0x3C")]
	public uint final_valid_score;

	[Token(Token = "0x4009AC8")]
	[FieldOffset(Offset = "0x40")]
	public uint final_total_score;

	[Token(Token = "0x4009AC9")]
	[FieldOffset(Offset = "0x44")]
	public uint final_pos;

	[Token(Token = "0x6007DF6")]
	[Address(RVA = "0x33E32C0", Offset = "0x33E32C0", VA = "0x33E32C0")]
	public TeamChampionshipInfo()
	{
	}
}
