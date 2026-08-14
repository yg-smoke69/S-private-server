using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013FC")]
public class LevelProbability
{
	[Token(Token = "0x4008BD8")]
	[FieldOffset(Offset = "0x8")]
	public ELottery.WeightType level;

	[Token(Token = "0x4008BD9")]
	[FieldOffset(Offset = "0xC")]
	public List<RareProbability> rare_prs;

	[Token(Token = "0x6007AD2")]
	[Address(RVA = "0x30A4474", Offset = "0x30A4474", VA = "0x30A4474")]
	public LevelProbability()
	{
	}
}
