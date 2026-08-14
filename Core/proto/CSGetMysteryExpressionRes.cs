using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001752")]
public class CSGetMysteryExpressionRes
{
	[Token(Token = "0x40099EA")]
	[FieldOffset(Offset = "0x8")]
	public List<MysteryShopExpressionDesc> mystery_shop_expressions;

	[Token(Token = "0x6007DAC")]
	[Address(RVA = "0x3187D80", Offset = "0x3187D80", VA = "0x3187D80")]
	public CSGetMysteryExpressionRes()
	{
	}
}
