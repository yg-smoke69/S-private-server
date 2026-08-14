using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B77")]
public class BooyahgoMiniGameSettingDesc
{
	[Token(Token = "0x400ACBF")]
	[FieldOffset(Offset = "0x8")]
	public uint max_node;

	[Token(Token = "0x400ACC0")]
	[FieldOffset(Offset = "0xC")]
	public uint ticket_id;

	[Token(Token = "0x400ACC1")]
	[FieldOffset(Offset = "0x10")]
	public uint token_id;

	[Token(Token = "0x400ACC2")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400ACC3")]
	[FieldOffset(Offset = "0x18")]
	public uint forward_step;

	[Token(Token = "0x400ACC4")]
	[FieldOffset(Offset = "0x1C")]
	public uint trapped_step;

	[Token(Token = "0x400ACC5")]
	[FieldOffset(Offset = "0x20")]
	public uint buff_multiple;

	[Token(Token = "0x400ACC6")]
	[FieldOffset(Offset = "0x24")]
	public uint buff_time;

	[Token(Token = "0x400ACC7")]
	[FieldOffset(Offset = "0x28")]
	public uint token_num;

	[Token(Token = "0x400ACC8")]
	[FieldOffset(Offset = "0x2C")]
	public uint start_token_num;

	[Token(Token = "0x400ACC9")]
	[FieldOffset(Offset = "0x30")]
	public uint skull_king_move_rounds;

	[Token(Token = "0x400ACCA")]
	[FieldOffset(Offset = "0x34")]
	public uint skull_king_max_rounds;

	[Token(Token = "0x400ACCB")]
	[FieldOffset(Offset = "0x38")]
	public uint points_per_step;

	[Token(Token = "0x400ACCC")]
	[FieldOffset(Offset = "0x3C")]
	public uint skull_king_left_pos;

	[Token(Token = "0x400ACCD")]
	[FieldOffset(Offset = "0x40")]
	public uint skull_king_right_pos;

	[Token(Token = "0x400ACCE")]
	[FieldOffset(Offset = "0x44")]
	public uint skull_king_move1_weight;

	[Token(Token = "0x400ACCF")]
	[FieldOffset(Offset = "0x48")]
	public uint skull_king_move2_weight;

	[Token(Token = "0x400ACD0")]
	[FieldOffset(Offset = "0x4C")]
	public uint ranking_start_time;

	[Token(Token = "0x400ACD1")]
	[FieldOffset(Offset = "0x50")]
	public uint ranking_end_time;

	[Token(Token = "0x400ACD2")]
	[FieldOffset(Offset = "0x54")]
	public string phase1_story;

	[Token(Token = "0x400ACD3")]
	[FieldOffset(Offset = "0x58")]
	public string phase2_story;

	[Token(Token = "0x400ACD4")]
	[FieldOffset(Offset = "0x5C")]
	public string phase3_story;

	[Token(Token = "0x400ACD5")]
	[FieldOffset(Offset = "0x60")]
	public uint phase1_num;

	[Token(Token = "0x400ACD6")]
	[FieldOffset(Offset = "0x64")]
	public uint phase2_num;

	[Token(Token = "0x400ACD7")]
	[FieldOffset(Offset = "0x68")]
	public uint phase3_num;

	[Token(Token = "0x60081D2")]
	[Address(RVA = "0x317CE80", Offset = "0x317CE80", VA = "0x317CE80")]
	public BooyahgoMiniGameSettingDesc()
	{
	}
}
