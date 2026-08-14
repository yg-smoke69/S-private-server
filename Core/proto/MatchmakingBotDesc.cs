using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20019E0")]
public class MatchmakingBotDesc
{
	[Token(Token = "0x400A271")]
	[FieldOffset(Offset = "0x8")]
	public uint mmr_start;

	[Token(Token = "0x400A272")]
	[FieldOffset(Offset = "0xC")]
	public uint mmr_end;

	[Token(Token = "0x400A273")]
	[FieldOffset(Offset = "0x10")]
	public uint bot_cnt;

	[Token(Token = "0x400A274")]
	[FieldOffset(Offset = "0x14")]
	public uint bot_wait_time;

	[Token(Token = "0x400A275")]
	[FieldOffset(Offset = "0x18")]
	public uint bot_mmr_separate;

	[Token(Token = "0x400A276")]
	[FieldOffset(Offset = "0x1C")]
	public uint none_bot_mmr_separate;

	[Token(Token = "0x400A277")]
	[FieldOffset(Offset = "0x20")]
	public uint bot_point;

	[Token(Token = "0x400A278")]
	[FieldOffset(Offset = "0x24")]
	public uint map_id;

	[Token(Token = "0x400A279")]
	[FieldOffset(Offset = "0x28")]
	public uint game_mode;

	[Token(Token = "0x400A27A")]
	[FieldOffset(Offset = "0x2C")]
	public uint group_mode;

	[Token(Token = "0x400A27B")]
	[FieldOffset(Offset = "0x30")]
	public uint bot_cnt_lv1;

	[Token(Token = "0x400A27C")]
	[FieldOffset(Offset = "0x34")]
	public uint bot_cnt_lv2;

	[Token(Token = "0x400A27D")]
	[FieldOffset(Offset = "0x38")]
	public uint bot_cnt_lv3;

	[Token(Token = "0x400A27E")]
	[FieldOffset(Offset = "0x3C")]
	public uint bot_cnt_lv4;

	[Token(Token = "0x400A27F")]
	[FieldOffset(Offset = "0x40")]
	public uint fill_bot_level;

	[Token(Token = "0x400A280")]
	[FieldOffset(Offset = "0x44")]
	public uint bot_cnt_lv5;

	[Token(Token = "0x400A281")]
	[FieldOffset(Offset = "0x48")]
	public uint bot_cnt_lv6;

	[Token(Token = "0x400A282")]
	[FieldOffset(Offset = "0x4C")]
	public uint team_bot_cnt_lv1;

	[Token(Token = "0x400A283")]
	[FieldOffset(Offset = "0x50")]
	public uint team_bot_cnt_lv2;

	[Token(Token = "0x400A284")]
	[FieldOffset(Offset = "0x54")]
	public uint team_bot_cnt_lv3;

	[Token(Token = "0x400A285")]
	[FieldOffset(Offset = "0x58")]
	public uint team_bot_cnt_lv4;

	[Token(Token = "0x400A286")]
	[FieldOffset(Offset = "0x5C")]
	public uint team_bot_cnt_lv5;

	[Token(Token = "0x400A287")]
	[FieldOffset(Offset = "0x60")]
	public uint team_bot_cnt_lv6;

	[Token(Token = "0x400A288")]
	[FieldOffset(Offset = "0x64")]
	public uint team_bot_cnt;

	[Token(Token = "0x400A289")]
	[FieldOffset(Offset = "0x68")]
	public uint casual_player_safe_zone_switch;

	[Token(Token = "0x400A28A")]
	[FieldOffset(Offset = "0x6C")]
	public List<AIInfoDesc> ai_infos;

	[Token(Token = "0x400A28B")]
	[FieldOffset(Offset = "0x70")]
	public uint ai_cnt;

	[Token(Token = "0x400A28C")]
	[FieldOffset(Offset = "0x74")]
	public List<AIInfoDesc> team_ai_infos;

	[Token(Token = "0x400A28D")]
	[FieldOffset(Offset = "0x78")]
	public uint team_ai_cnt;

	[Token(Token = "0x400A28E")]
	[FieldOffset(Offset = "0x7C")]
	public uint replaced_ai_bot_level;

	[Token(Token = "0x400A28F")]
	[FieldOffset(Offset = "0x80")]
	public uint index;

	[Token(Token = "0x6008038")]
	[Address(RVA = "0x30A84E0", Offset = "0x30A84E0", VA = "0x30A84E0")]
	public MatchmakingBotDesc()
	{
	}
}
