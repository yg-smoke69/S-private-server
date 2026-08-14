using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A29")]
public class ClanRacePointsGainDescList
{
	[Token(Token = "0x400A3E6")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanRacePointsGainDesc> rp_gain_list;

	[Token(Token = "0x6008081")]
	[Address(RVA = "0x309BFFC", Offset = "0x309BFFC", VA = "0x309BFFC")]
	public ClanRacePointsGainDescList()
	{
	}
}
