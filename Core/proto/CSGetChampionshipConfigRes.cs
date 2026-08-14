using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017A1")]
public class CSGetChampionshipConfigRes
{
	[Token(Token = "0x4009ADA")]
	[FieldOffset(Offset = "0x8")]
	public ChampionshipOpenInfoDesc open_info;

	[Token(Token = "0x4009ADB")]
	[FieldOffset(Offset = "0xC")]
	public List<ChampionshipScoreRewardDesc> reward_infos;

	[Token(Token = "0x4009ADC")]
	[FieldOffset(Offset = "0x10")]
	public ChampionshipSettingDesc setting_info;

	[Token(Token = "0x6007DFB")]
	[Address(RVA = "0x3182D70", Offset = "0x3182D70", VA = "0x3182D70")]
	public CSGetChampionshipConfigRes()
	{
	}
}
