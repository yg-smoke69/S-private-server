using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200163B")]
public class CSGetClanRaceInfoRes
{
	[Token(Token = "0x400957D")]
	[FieldOffset(Offset = "0x8")]
	public uint stage;

	[Token(Token = "0x400957E")]
	[FieldOffset(Offset = "0xC")]
	public bool is_open;

	[Token(Token = "0x400957F")]
	[FieldOffset(Offset = "0x10")]
	public List<ClanRaceRewardsDesc> rewards;

	[Token(Token = "0x4009580")]
	[FieldOffset(Offset = "0x14")]
	public uint race_point;

	[Token(Token = "0x4009581")]
	[FieldOffset(Offset = "0x18")]
	public uint latest_race_week_id;

	[Token(Token = "0x4009582")]
	[FieldOffset(Offset = "0x1C")]
	public List<RaceAwardExchange> exchange_info;

	[Token(Token = "0x4009583")]
	[FieldOffset(Offset = "0x20")]
	public ClanRaceOpenInfo clan_race_open_info;

	[Token(Token = "0x6007C85")]
	[Address(RVA = "0x3183124", Offset = "0x3183124", VA = "0x3183124")]
	public CSGetClanRaceInfoRes()
	{
	}
}
