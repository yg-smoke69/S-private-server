using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017AD")]
public class TeamChampionshipInfoBundleRes
{
	[Token(Token = "0x4009B1A")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamChampionshipInfo> infos;

	[Token(Token = "0x6007E07")]
	[Address(RVA = "0x33E32C8", Offset = "0x33E32C8", VA = "0x33E32C8")]
	public TeamChampionshipInfoBundleRes()
	{
	}
}
