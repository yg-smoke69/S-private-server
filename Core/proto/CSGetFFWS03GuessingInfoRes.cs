using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001892")]
public class CSGetFFWS03GuessingInfoRes
{
	[Token(Token = "0x4009D3B")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWSTeamInfoDesc> team_infos;

	[Token(Token = "0x4009D3C")]
	[FieldOffset(Offset = "0xC")]
	public List<FFWSWeaponInfoDesc> weapon_info;

	[Token(Token = "0x4009D3D")]
	[FieldOffset(Offset = "0x10")]
	public List<FFWSGuessingAwardDesc> awards;

	[Token(Token = "0x4009D3E")]
	[FieldOffset(Offset = "0x14")]
	public List<FFWSTeamResultsDesc> team_results;

	[Token(Token = "0x4009D3F")]
	[FieldOffset(Offset = "0x18")]
	public List<FFWSWeaponResultsDesc> weapon_results;

	[Token(Token = "0x4009D40")]
	[FieldOffset(Offset = "0x1C")]
	public List<FFWS03GuessingEntry> guess_entries;

	[Token(Token = "0x6007EEB")]
	[Address(RVA = "0x31847B0", Offset = "0x31847B0", VA = "0x31847B0")]
	public CSGetFFWS03GuessingInfoRes()
	{
	}
}
