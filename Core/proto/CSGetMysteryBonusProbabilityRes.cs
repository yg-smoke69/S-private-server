using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20015CD")]
public class CSGetMysteryBonusProbabilityRes
{
	[Token(Token = "0x4009451")]
	[FieldOffset(Offset = "0x8")]
	public List<MysteryBonusProbability> mystery_bonus_prs;

	[Token(Token = "0x6007C17")]
	[Address(RVA = "0x3187CF4", Offset = "0x3187CF4", VA = "0x3187CF4")]
	public CSGetMysteryBonusProbabilityRes()
	{
	}
}
