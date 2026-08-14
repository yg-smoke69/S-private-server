using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001896")]
public class CSFFWS03DailyCheckInInfoRes
{
	[Token(Token = "0x4009D51")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWS03TeamCardsInfo> team_cards_info;

	[Token(Token = "0x4009D52")]
	[FieldOffset(Offset = "0xC")]
	public ExchangeChangeData rewards;

	[Token(Token = "0x6007EEF")]
	[Address(RVA = "0x318016C", Offset = "0x318016C", VA = "0x318016C")]
	public CSFFWS03DailyCheckInInfoRes()
	{
	}
}
