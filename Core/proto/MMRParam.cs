using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A3B")]
public class MMRParam
{
	[Token(Token = "0x400A43E")]
	[FieldOffset(Offset = "0x8")]
	public uint group_mode;

	[Token(Token = "0x400A43F")]
	[FieldOffset(Offset = "0xC")]
	public uint game_mode;

	[Token(Token = "0x400A440")]
	[FieldOffset(Offset = "0x10")]
	public uint map_id;

	[Token(Token = "0x400A441")]
	[FieldOffset(Offset = "0x14")]
	public float kill_real_player_avg;

	[Token(Token = "0x400A442")]
	[FieldOffset(Offset = "0x18")]
	public float kill_bot_avg;

	[Token(Token = "0x400A443")]
	[FieldOffset(Offset = "0x1C")]
	public float rank_base_mmr;

	[Token(Token = "0x400A444")]
	[FieldOffset(Offset = "0x20")]
	public float real_rank_base_mmr;

	[Token(Token = "0x400A445")]
	[FieldOffset(Offset = "0x24")]
	public float kill_real_player_base_mmr;

	[Token(Token = "0x400A446")]
	[FieldOffset(Offset = "0x28")]
	public float kill_bot_base_mmr;

	[Token(Token = "0x6008093")]
	[Address(RVA = "0x30A7138", Offset = "0x30A7138", VA = "0x30A7138")]
	public MMRParam()
	{
	}
}
