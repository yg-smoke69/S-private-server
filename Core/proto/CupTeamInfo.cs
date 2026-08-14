using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200158F")]
public class CupTeamInfo
{
	[Token(Token = "0x400937C")]
	[FieldOffset(Offset = "0x8")]
	public ulong team_id;

	[Token(Token = "0x400937D")]
	[FieldOffset(Offset = "0x10")]
	public uint cup_type;

	[Token(Token = "0x400937E")]
	[FieldOffset(Offset = "0x14")]
	public uint cup_id;

	[Token(Token = "0x400937F")]
	[FieldOffset(Offset = "0x18")]
	public uint tier;

	[Token(Token = "0x4009380")]
	[FieldOffset(Offset = "0x1C")]
	public string team_name;

	[Token(Token = "0x4009381")]
	[FieldOffset(Offset = "0x20")]
	public string country_or_area;

	[Token(Token = "0x4009382")]
	[FieldOffset(Offset = "0x24")]
	public uint head_pic;

	[Token(Token = "0x4009383")]
	[FieldOffset(Offset = "0x28")]
	public uint banner_id;

	[Token(Token = "0x4009384")]
	[FieldOffset(Offset = "0x2C")]
	public List<CupBattleRecord> records;

	[Token(Token = "0x4009385")]
	[FieldOffset(Offset = "0x30")]
	public bool is_locked;

	[Token(Token = "0x4009386")]
	[FieldOffset(Offset = "0x38")]
	public ulong captain_id;

	[Token(Token = "0x4009387")]
	[FieldOffset(Offset = "0x40")]
	public uint member_num;

	[Token(Token = "0x4009388")]
	[FieldOffset(Offset = "0x44")]
	public uint win_count;

	[Token(Token = "0x4009389")]
	[FieldOffset(Offset = "0x48")]
	public bool[] battle_record;

	[Token(Token = "0x6007BD7")]
	[Address(RVA = "0x309DEB0", Offset = "0x309DEB0", VA = "0x309DEB0")]
	public CupTeamInfo()
	{
	}
}
