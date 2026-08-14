using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200170A")]
public class ChallengeStatus
{
	[Token(Token = "0x4009844")]
	[FieldOffset(Offset = "0x8")]
	public uint challenge_id;

	[Token(Token = "0x4009845")]
	[FieldOffset(Offset = "0xC")]
	public EPTarget_Status status;

	[Token(Token = "0x4009846")]
	[FieldOffset(Offset = "0x10")]
	public uint update_time;

	[Token(Token = "0x4009847")]
	[FieldOffset(Offset = "0x14")]
	public uint[] role_condition;

	[Token(Token = "0x4009848")]
	[FieldOffset(Offset = "0x18")]
	public uint count_type;

	[Token(Token = "0x4009849")]
	[FieldOffset(Offset = "0x1C")]
	public uint player_count;

	[Token(Token = "0x400984A")]
	[FieldOffset(Offset = "0x20")]
	public List<ChallengeCdt> conditions;

	[Token(Token = "0x400984B")]
	[FieldOffset(Offset = "0x24")]
	public uint match_mode;

	[Token(Token = "0x400984C")]
	[FieldOffset(Offset = "0x28")]
	public uint date;

	[Token(Token = "0x400984D")]
	[FieldOffset(Offset = "0x2C")]
	public uint challenge_type;

	[Token(Token = "0x400984E")]
	[FieldOffset(Offset = "0x30")]
	public uint special_challenge;

	[Token(Token = "0x400984F")]
	[FieldOffset(Offset = "0x34")]
	public uint daily_count;

	[Token(Token = "0x4009850")]
	[FieldOffset(Offset = "0x38")]
	public bool is_daily_quest;

	[Token(Token = "0x4009851")]
	[FieldOffset(Offset = "0x39")]
	public bool is_unfinished_daily_quest;

	[Token(Token = "0x4009852")]
	[FieldOffset(Offset = "0x3C")]
	public uint max_daily_count;

	[Token(Token = "0x4009853")]
	[FieldOffset(Offset = "0x40")]
	public uint week_id;

	[Token(Token = "0x4009854")]
	[FieldOffset(Offset = "0x44")]
	public uint[] game_modes;

	[Token(Token = "0x6007D64")]
	[Address(RVA = "0x309AD68", Offset = "0x309AD68", VA = "0x309AD68")]
	public ChallengeStatus()
	{
	}
}
