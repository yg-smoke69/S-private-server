using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013FB")]
public class ProbabilityShow
{
	[Token(Token = "0x4008BD5")]
	[FieldOffset(Offset = "0x8")]
	public List<RareProbability> rare;

	[Token(Token = "0x4008BD6")]
	[FieldOffset(Offset = "0xC")]
	public List<ItemProbability> item;

	[Token(Token = "0x4008BD7")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardTypeProbability> award_type;

	[Token(Token = "0x6007AD1")]
	[Address(RVA = "0x33E021C", Offset = "0x33E021C", VA = "0x33E021C")]
	public ProbabilityShow()
	{
	}
}
