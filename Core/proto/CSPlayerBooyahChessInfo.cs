using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200183E")]
public class CSPlayerBooyahChessInfo
{
	[Token(Token = "0x4009C70")]
	[FieldOffset(Offset = "0x8")]
	public ulong account_id;

	[Token(Token = "0x4009C71")]
	[FieldOffset(Offset = "0x10")]
	public EMiniGame.GameStatus game_status;

	[Token(Token = "0x4009C72")]
	[FieldOffset(Offset = "0x14")]
	public uint player_index;

	[Token(Token = "0x4009C73")]
	[FieldOffset(Offset = "0x18")]
	public uint current_step;

	[Token(Token = "0x4009C74")]
	[FieldOffset(Offset = "0x1C")]
	public uint current_weapon;

	[Token(Token = "0x4009C75")]
	[FieldOffset(Offset = "0x20")]
	public uint booyah_times;

	[Token(Token = "0x4009C76")]
	[FieldOffset(Offset = "0x24")]
	public Chessboard chessboard;

	[Token(Token = "0x4009C77")]
	[FieldOffset(Offset = "0x28")]
	public Circle current_circle;

	[Token(Token = "0x4009C78")]
	[FieldOffset(Offset = "0x2C")]
	public uint current_reward_cnt;

	[Token(Token = "0x4009C79")]
	[FieldOffset(Offset = "0x30")]
	public uint total_reward_cnt;

	[Token(Token = "0x4009C7A")]
	[FieldOffset(Offset = "0x34")]
	public bool is_booyah;

	[Token(Token = "0x4009C7B")]
	[FieldOffset(Offset = "0x35")]
	public bool is_finish;

	[Token(Token = "0x4009C7C")]
	[FieldOffset(Offset = "0x38")]
	public int booyah_index;

	[Token(Token = "0x4009C7D")]
	[FieldOffset(Offset = "0x3C")]
	public uint play_times;

	[Token(Token = "0x6007E98")]
	[Address(RVA = "0x3098460", Offset = "0x3098460", VA = "0x3098460")]
	public CSPlayerBooyahChessInfo()
	{
	}
}
