using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013C7")]
public class AccountClanWarMatchInfo
{
	[Token(Token = "0x4008B0C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x4008B0D")]
	[FieldOffset(Offset = "0x10")]
	public ulong captain_id;

	[Token(Token = "0x4008B0E")]
	[FieldOffset(Offset = "0x18")]
	public ulong[] member_ids;

	[Token(Token = "0x4008B0F")]
	[FieldOffset(Offset = "0x1C")]
	public uint min_player;

	[Token(Token = "0x4008B10")]
	[FieldOffset(Offset = "0x20")]
	public List<ClanWarMemberMatchInfo> members_match_info;

	[Token(Token = "0x4008B11")]
	[FieldOffset(Offset = "0x24")]
	public uint clan_war_mmr;

	[Token(Token = "0x6007AB2")]
	[Address(RVA = "0x3179438", Offset = "0x3179438", VA = "0x3179438")]
	public AccountClanWarMatchInfo()
	{
	}
}
