using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A03")]
public class RegionRecommendDesc
{
	[Token(Token = "0x400A324")]
	[FieldOffset(Offset = "0x8")]
	public string language;

	[Token(Token = "0x400A325")]
	[FieldOffset(Offset = "0xC")]
	public List<string> recommend_region_servers;

	[Token(Token = "0x600805B")]
	[Address(RVA = "0x33E15A8", Offset = "0x33E15A8", VA = "0x33E15A8")]
	public RegionRecommendDesc()
	{
	}
}
