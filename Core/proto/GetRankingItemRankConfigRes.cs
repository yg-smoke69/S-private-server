using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015BA")]
public class GetRankingItemRankConfigRes
{
	[Token(Token = "0x4009423")]
	[FieldOffset(Offset = "0x8")]
	public List<RankingItemRank> items;

	[Token(Token = "0x6007C04")]
	[Address(RVA = "0x30A2248", Offset = "0x30A2248", VA = "0x30A2248")]
	public GetRankingItemRankConfigRes()
	{
	}
}
