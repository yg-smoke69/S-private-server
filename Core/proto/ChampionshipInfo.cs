using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200179A")]
public class ChampionshipInfo
{
	[Token(Token = "0x4009AB3")]
	[FieldOffset(Offset = "0x8")]
	public uint championship_type;

	[Token(Token = "0x4009AB4")]
	[FieldOffset(Offset = "0xC")]
	public TeamChampionshipInfo team_info;

	[Token(Token = "0x4009AB5")]
	[FieldOffset(Offset = "0x10")]
	public AccountChampionshipInfo account_info;

	[Token(Token = "0x4009AB6")]
	[FieldOffset(Offset = "0x14")]
	public List<ChampionshipWinnerInfo> winnner_infos;

	[Token(Token = "0x6007DF4")]
	[Address(RVA = "0x309ADFC", Offset = "0x309ADFC", VA = "0x309ADFC")]
	public ChampionshipInfo()
	{
	}
}
