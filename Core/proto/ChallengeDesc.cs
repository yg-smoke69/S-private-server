using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A7F")]
public class ChallengeDesc
{
	[Token(Token = "0x400A5D9")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A5DA")]
	[FieldOffset(Offset = "0xC")]
	public uint challenge_id;

	[Token(Token = "0x400A5DB")]
	[FieldOffset(Offset = "0x10")]
	public uint challenge_type;

	[Token(Token = "0x400A5DC")]
	[FieldOffset(Offset = "0x14")]
	public string challenge_desc;

	[Token(Token = "0x400A5DD")]
	[FieldOffset(Offset = "0x18")]
	public uint if_reset;

	[Token(Token = "0x400A5DE")]
	[FieldOffset(Offset = "0x1C")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A5DF")]
	[FieldOffset(Offset = "0x20")]
	public uint award_id;

	[Token(Token = "0x400A5E0")]
	[FieldOffset(Offset = "0x24")]
	public uint award_num;

	[Token(Token = "0x400A5E1")]
	[FieldOffset(Offset = "0x28")]
	public uint count_type;

	[Token(Token = "0x400A5E2")]
	[FieldOffset(Offset = "0x2C")]
	public uint[] role_condition;

	[Token(Token = "0x400A5E3")]
	[FieldOffset(Offset = "0x30")]
	public uint player_count;

	[Token(Token = "0x400A5E4")]
	[FieldOffset(Offset = "0x34")]
	public List<ChallengeCondition> conditions;

	[Token(Token = "0x400A5E5")]
	[FieldOffset(Offset = "0x38")]
	public uint match_mode;

	[Token(Token = "0x400A5E6")]
	[FieldOffset(Offset = "0x3C")]
	public uint date;

	[Token(Token = "0x400A5E7")]
	[FieldOffset(Offset = "0x40")]
	public uint special_challenge;

	[Token(Token = "0x400A5E8")]
	[FieldOffset(Offset = "0x44")]
	public string start_time;

	[Token(Token = "0x400A5E9")]
	[FieldOffset(Offset = "0x48")]
	public EInventory.AwardType award_type2;

	[Token(Token = "0x400A5EA")]
	[FieldOffset(Offset = "0x4C")]
	public uint award_id2;

	[Token(Token = "0x400A5EB")]
	[FieldOffset(Offset = "0x50")]
	public uint award_num2;

	[Token(Token = "0x400A5EC")]
	[FieldOffset(Offset = "0x54")]
	public EInventory.AwardType award_type3;

	[Token(Token = "0x400A5ED")]
	[FieldOffset(Offset = "0x58")]
	public uint award_id3;

	[Token(Token = "0x400A5EE")]
	[FieldOffset(Offset = "0x5C")]
	public uint award_num3;

	[Token(Token = "0x400A5EF")]
	[FieldOffset(Offset = "0x60")]
	public uint award_time;

	[Token(Token = "0x400A5F0")]
	[FieldOffset(Offset = "0x64")]
	public uint award_time2;

	[Token(Token = "0x400A5F1")]
	[FieldOffset(Offset = "0x68")]
	public uint award_time3;

	[Token(Token = "0x400A5F2")]
	[FieldOffset(Offset = "0x6C")]
	public bool is_ep_only;

	[Token(Token = "0x400A5F3")]
	[FieldOffset(Offset = "0x6D")]
	public bool is_team_share;

	[Token(Token = "0x400A5F4")]
	[FieldOffset(Offset = "0x70")]
	public uint challenge_group;

	[Token(Token = "0x400A5F5")]
	[FieldOffset(Offset = "0x74")]
	public uint[] game_modes;

	[Token(Token = "0x60080DC")]
	[Address(RVA = "0x309AC70", Offset = "0x309AC70", VA = "0x309AC70")]
	public ChallengeDesc()
	{
	}
}
