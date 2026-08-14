using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001520")]
public class CSGetGameBonusEventDescRes
{
	[Token(Token = "0x40090CB")]
	[FieldOffset(Offset = "0x8")]
	public List<GameBonusEventDesc> game_bonus_events;

	[Token(Token = "0x6007B69")]
	[Address(RVA = "0x3185948", Offset = "0x3185948", VA = "0x3185948")]
	public CSGetGameBonusEventDescRes()
	{
	}
}
