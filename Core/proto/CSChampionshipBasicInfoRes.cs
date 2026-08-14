using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001796")]
public class CSChampionshipBasicInfoRes
{
	[Token(Token = "0x4009A9F")]
	[FieldOffset(Offset = "0x8")]
	public List<ChampionshipOpenInfoDesc> open_infos;

	[Token(Token = "0x4009AA0")]
	[FieldOffset(Offset = "0xC")]
	public uint limited_level;

	[Token(Token = "0x4009AA1")]
	[FieldOffset(Offset = "0x10")]
	public uint limited_rank;

	[Token(Token = "0x4009AA2")]
	[FieldOffset(Offset = "0x14")]
	public List<ChampionshipScoreRewardDesc> reward_infos;

	[Token(Token = "0x4009AA3")]
	[FieldOffset(Offset = "0x18")]
	public List<ChampionshipSettingDesc> setting_infos;

	[Token(Token = "0x4009AA4")]
	[FieldOffset(Offset = "0x1C")]
	public List<ChampionshipScoreBaseDesc> score_bases;

	[Token(Token = "0x4009AA5")]
	[FieldOffset(Offset = "0x20")]
	public List<ChampionshipNameOverwriteDesc> name_overwrite_infos;

	[Token(Token = "0x4009AA6")]
	[FieldOffset(Offset = "0x24")]
	public List<ChampionshipTeamDesc> team_settings;

	[Token(Token = "0x4009AA7")]
	[FieldOffset(Offset = "0x28")]
	public bool isInBlacklist;

	[Token(Token = "0x4009AA8")]
	[FieldOffset(Offset = "0x2C")]
	public uint upper_limited_level;

	[Token(Token = "0x4009AA9")]
	[FieldOffset(Offset = "0x30")]
	public uint upper_limited_rank;

	[Token(Token = "0x6007DF0")]
	[Address(RVA = "0x317E12C", Offset = "0x317E12C", VA = "0x317E12C")]
	public CSChampionshipBasicInfoRes()
	{
	}
}
