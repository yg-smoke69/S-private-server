using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA6")]
public class CupTeamDesc
{
	[Token(Token = "0x400ADE6")]
	[FieldOffset(Offset = "0x8")]
	public uint limit_num;

	[Token(Token = "0x400ADE7")]
	[FieldOffset(Offset = "0xC")]
	public uint clean_time;

	[Token(Token = "0x400ADE8")]
	[FieldOffset(Offset = "0x10")]
	public uint player_apply_num;

	[Token(Token = "0x400ADE9")]
	[FieldOffset(Offset = "0x14")]
	public uint team_invite_num;

	[Token(Token = "0x400ADEA")]
	[FieldOffset(Offset = "0x18")]
	public uint team_join_cd;

	[Token(Token = "0x400ADEB")]
	[FieldOffset(Offset = "0x1C")]
	public uint team_exit_cd;

	[Token(Token = "0x6008201")]
	[Address(RVA = "0x309DEA8", Offset = "0x309DEA8", VA = "0x309DEA8")]
	public CupTeamDesc()
	{
	}
}
