using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017FC")]
public class CSGetMoneyHeistDescRes
{
	[Token(Token = "0x4009BD6")]
	[FieldOffset(Offset = "0x8")]
	public List<MoneyHeistAward> money_heist_award;

	[Token(Token = "0x6007E56")]
	[Address(RVA = "0x3187838", Offset = "0x3187838", VA = "0x3187838")]
	public CSGetMoneyHeistDescRes()
	{
	}
}
