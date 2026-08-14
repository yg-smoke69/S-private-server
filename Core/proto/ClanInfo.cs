using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200163F")]
public class ClanInfo
{
	[Token(Token = "0x400958C")]
	[FieldOffset(Offset = "0x8")]
	public ulong clan_id;

	[Token(Token = "0x400958D")]
	[FieldOffset(Offset = "0x10")]
	public string clan_name;

	[Token(Token = "0x400958E")]
	[FieldOffset(Offset = "0x18")]
	public ulong create_at;

	[Token(Token = "0x400958F")]
	[FieldOffset(Offset = "0x20")]
	public ulong captain_id;

	[Token(Token = "0x4009590")]
	[FieldOffset(Offset = "0x28")]
	public uint clan_level;

	[Token(Token = "0x4009591")]
	[FieldOffset(Offset = "0x2C")]
	public uint capacity;

	[Token(Token = "0x4009592")]
	[FieldOffset(Offset = "0x30")]
	public uint member_num;

	[Token(Token = "0x4009593")]
	[FieldOffset(Offset = "0x34")]
	public uint entry_level;

	[Token(Token = "0x4009594")]
	[FieldOffset(Offset = "0x38")]
	public uint entry_type;

	[Token(Token = "0x4009595")]
	[FieldOffset(Offset = "0x3C")]
	public string clan_logo;

	[Token(Token = "0x4009596")]
	[FieldOffset(Offset = "0x40")]
	public string announcement;

	[Token(Token = "0x4009597")]
	[FieldOffset(Offset = "0x44")]
	public string slogan;

	[Token(Token = "0x4009598")]
	[FieldOffset(Offset = "0x48")]
	public string region;

	[Token(Token = "0x4009599")]
	[FieldOffset(Offset = "0x4C")]
	public string misc;

	[Token(Token = "0x400959A")]
	[FieldOffset(Offset = "0x50")]
	public string vice_captains;

	[Token(Token = "0x400959B")]
	[FieldOffset(Offset = "0x54")]
	public uint honor_point;

	[Token(Token = "0x400959C")]
	[FieldOffset(Offset = "0x58")]
	public uint race_point;

	[Token(Token = "0x400959D")]
	[FieldOffset(Offset = "0x60")]
	public ulong last_gain_rp_at;

	[Token(Token = "0x400959E")]
	[FieldOffset(Offset = "0x68")]
	public ulong claim_rp_award_at;

	[Token(Token = "0x400959F")]
	[FieldOffset(Offset = "0x70")]
	public uint area_id;

	[Token(Token = "0x40095A0")]
	[FieldOffset(Offset = "0x74")]
	public uint play_style;

	[Token(Token = "0x40095A1")]
	[FieldOffset(Offset = "0x78")]
	public uint entry_rank;

	[Token(Token = "0x40095A2")]
	[FieldOffset(Offset = "0x80")]
	public ulong deputy_captain;

	[Token(Token = "0x40095A3")]
	[FieldOffset(Offset = "0x88")]
	public uint clan_arms;

	[Token(Token = "0x40095A4")]
	[FieldOffset(Offset = "0x8C")]
	public uint clan_badge_id;

	[Token(Token = "0x40095A5")]
	[FieldOffset(Offset = "0x90")]
	public List<UnlockedClanBadgeInfo> unlocked_clan_badge_infos;

	[Token(Token = "0x40095A6")]
	[FieldOffset(Offset = "0x94")]
	public uint entry_cs_rank;

	[Token(Token = "0x6007C89")]
	[Address(RVA = "0x309B9A0", Offset = "0x309B9A0", VA = "0x309B9A0")]
	public ClanInfo()
	{
	}
}
