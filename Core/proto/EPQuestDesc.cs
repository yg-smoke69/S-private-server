using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A80")]
public class EPQuestDesc
{
	[Token(Token = "0x400A5F6")]
	[FieldOffset(Offset = "0x8")]
	public uint ep_event_id;

	[Token(Token = "0x400A5F7")]
	[FieldOffset(Offset = "0xC")]
	public uint quest_id;

	[Token(Token = "0x400A5F8")]
	[FieldOffset(Offset = "0x10")]
	public uint daily_count;

	[Token(Token = "0x400A5F9")]
	[FieldOffset(Offset = "0x14")]
	public uint count_type;

	[Token(Token = "0x400A5FA")]
	[FieldOffset(Offset = "0x18")]
	public string start_time;

	[Token(Token = "0x400A5FB")]
	[FieldOffset(Offset = "0x1C")]
	public uint match_mode;

	[Token(Token = "0x400A5FC")]
	[FieldOffset(Offset = "0x20")]
	public uint[] role_condition;

	[Token(Token = "0x400A5FD")]
	[FieldOffset(Offset = "0x24")]
	public uint player_count;

	[Token(Token = "0x400A5FE")]
	[FieldOffset(Offset = "0x28")]
	public List<ChallengeCondition> conditions;

	[Token(Token = "0x400A5FF")]
	[FieldOffset(Offset = "0x2C")]
	public EInventory.AwardType award_type;

	[Token(Token = "0x400A600")]
	[FieldOffset(Offset = "0x30")]
	public uint award_id;

	[Token(Token = "0x400A601")]
	[FieldOffset(Offset = "0x34")]
	public uint award_num;

	[Token(Token = "0x400A602")]
	[FieldOffset(Offset = "0x38")]
	public EInventory.AwardType award_type2;

	[Token(Token = "0x400A603")]
	[FieldOffset(Offset = "0x3C")]
	public uint award_id2;

	[Token(Token = "0x400A604")]
	[FieldOffset(Offset = "0x40")]
	public uint award_num2;

	[Token(Token = "0x400A605")]
	[FieldOffset(Offset = "0x44")]
	public EInventory.AwardType award_type3;

	[Token(Token = "0x400A606")]
	[FieldOffset(Offset = "0x48")]
	public uint award_id3;

	[Token(Token = "0x400A607")]
	[FieldOffset(Offset = "0x4C")]
	public uint award_num3;

	[Token(Token = "0x400A608")]
	[FieldOffset(Offset = "0x50")]
	public uint award_time;

	[Token(Token = "0x400A609")]
	[FieldOffset(Offset = "0x54")]
	public uint award_time2;

	[Token(Token = "0x400A60A")]
	[FieldOffset(Offset = "0x58")]
	public uint award_time3;

	[Token(Token = "0x400A60B")]
	[FieldOffset(Offset = "0x5C")]
	public uint[] game_modes;

	[Token(Token = "0x60080DD")]
	[Address(RVA = "0x309F5F8", Offset = "0x309F5F8", VA = "0x309F5F8")]
	public EPQuestDesc()
	{
	}
}
