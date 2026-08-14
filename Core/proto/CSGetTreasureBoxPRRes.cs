using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E2")]
public class CSGetTreasureBoxPRRes
{
	[Token(Token = "0x4009478")]
	[FieldOffset(Offset = "0x8")]
	public List<RareProbability> rare_pr;

	[Token(Token = "0x4009479")]
	[FieldOffset(Offset = "0xC")]
	public List<ItemProbability> item_pr;

	[Token(Token = "0x400947A")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardTypeProbability> award_type_pr;

	[Token(Token = "0x6007C2C")]
	[Address(RVA = "0x3095B70", Offset = "0x3095B70", VA = "0x3095B70")]
	public CSGetTreasureBoxPRRes()
	{
	}
}
