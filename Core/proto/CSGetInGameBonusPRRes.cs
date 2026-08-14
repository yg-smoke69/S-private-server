using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015E4")]
public class CSGetInGameBonusPRRes
{
	[Token(Token = "0x400947C")]
	[FieldOffset(Offset = "0x8")]
	public List<RareProbability> rare_pr;

	[Token(Token = "0x400947D")]
	[FieldOffset(Offset = "0xC")]
	public List<ItemProbability> item_pr;

	[Token(Token = "0x400947E")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardTypeProbability> award_type_pr;

	[Token(Token = "0x6007C2E")]
	[Address(RVA = "0x31861D8", Offset = "0x31861D8", VA = "0x31861D8")]
	public CSGetInGameBonusPRRes()
	{
	}
}
