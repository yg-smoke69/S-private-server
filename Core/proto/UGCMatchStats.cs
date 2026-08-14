using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20018FB")]
public class UGCMatchStats
{
	[Token(Token = "0x4009E56")]
	[FieldOffset(Offset = "0x8")]
	public bool is_draw;

	[Token(Token = "0x4009E57")]
	[FieldOffset(Offset = "0xC")]
	public int mode_template_id;

	[Token(Token = "0x4009E58")]
	[FieldOffset(Offset = "0x10")]
	public ulong self_account_id;

	[Token(Token = "0x4009E59")]
	[FieldOffset(Offset = "0x18")]
	public ulong self_team_index;

	[Token(Token = "0x4009E5A")]
	[FieldOffset(Offset = "0x20")]
	public int[] score_type_to_show;

	[Token(Token = "0x4009E5B")]
	[FieldOffset(Offset = "0x24")]
	public List<UGCTeamStats> all_team_stats;

	[Token(Token = "0x4009E5C")]
	[FieldOffset(Offset = "0x28")]
	public string map_name;

	[Token(Token = "0x4009E5D")]
	[FieldOffset(Offset = "0x2C")]
	public int[] rank_to_score_rule;

	[Token(Token = "0x6007F54")]
	[Address(RVA = "0x33E3E58", Offset = "0x33E3E58", VA = "0x33E3E58")]
	public UGCMatchStats()
	{
	}
}
