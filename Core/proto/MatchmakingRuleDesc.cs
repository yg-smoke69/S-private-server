using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019DD")]
public class MatchmakingRuleDesc
{
	[Token(Token = "0x400A24D")]
	[FieldOffset(Offset = "0x8")]
	public uint map_id;

	[Token(Token = "0x400A24E")]
	[FieldOffset(Offset = "0xC")]
	public uint group_mode;

	[Token(Token = "0x400A24F")]
	[FieldOffset(Offset = "0x10")]
	public uint min_player_cnt;

	[Token(Token = "0x400A250")]
	[FieldOffset(Offset = "0x14")]
	public uint max_player_cnt;

	[Token(Token = "0x400A251")]
	[FieldOffset(Offset = "0x18")]
	public bool mmr_open;

	[Token(Token = "0x400A252")]
	[FieldOffset(Offset = "0x19")]
	public bool bot_open;

	[Token(Token = "0x400A253")]
	[FieldOffset(Offset = "0x1C")]
	public uint min_room_mmr_delta;

	[Token(Token = "0x400A254")]
	[FieldOffset(Offset = "0x20")]
	public uint base_mmr_delta;

	[Token(Token = "0x400A255")]
	[FieldOffset(Offset = "0x24")]
	public List<MatchmakingTimeMMRRangeItem> ranges;

	[Token(Token = "0x400A256")]
	[FieldOffset(Offset = "0x28")]
	public uint mm_timeout;

	[Token(Token = "0x400A257")]
	[FieldOffset(Offset = "0x2C")]
	public uint game_mode;

	[Token(Token = "0x400A258")]
	[FieldOffset(Offset = "0x30")]
	public uint language_timeout;

	[Token(Token = "0x400A259")]
	[FieldOffset(Offset = "0x34")]
	public uint difficulty;

	[Token(Token = "0x400A25A")]
	[FieldOffset(Offset = "0x38")]
	public uint halfway_join_time;

	[Token(Token = "0x400A25B")]
	[FieldOffset(Offset = "0x3C")]
	public uint min_group_cnt;

	[Token(Token = "0x400A25C")]
	[FieldOffset(Offset = "0x40")]
	public uint max_group_cnt;

	[Token(Token = "0x400A25D")]
	[FieldOffset(Offset = "0x44")]
	public uint begin_add_player_time;

	[Token(Token = "0x400A25E")]
	[FieldOffset(Offset = "0x48")]
	public uint stop_add_player_time;

	[Token(Token = "0x400A25F")]
	[FieldOffset(Offset = "0x4C")]
	public uint squad_prefer_protection_time;

	[Token(Token = "0x400A260")]
	[FieldOffset(Offset = "0x50")]
	public bool ai_open;

	[Token(Token = "0x400A261")]
	[FieldOffset(Offset = "0x54")]
	public uint mmr_fix_id;

	[Token(Token = "0x400A262")]
	[FieldOffset(Offset = "0x58")]
	public uint dual_prefer_protection_time;

	[Token(Token = "0x400A263")]
	[FieldOffset(Offset = "0x5C")]
	public uint penta_prefer_protection_time;

	[Token(Token = "0x6008035")]
	[Address(RVA = "0x30A8638", Offset = "0x30A8638", VA = "0x30A8638")]
	public MatchmakingRuleDesc()
	{
	}
}
