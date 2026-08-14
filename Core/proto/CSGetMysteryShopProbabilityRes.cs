using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001761")]
public class CSGetMysteryShopProbabilityRes
{
	[Token(Token = "0x4009A20")]
	[FieldOffset(Offset = "0x8")]
	public List<MysteryShopProbability> mystery_shop_prs;

	[Token(Token = "0x6007DBB")]
	[Address(RVA = "0x3188020", Offset = "0x3188020", VA = "0x3188020")]
	public CSGetMysteryShopProbabilityRes()
	{
	}
}
