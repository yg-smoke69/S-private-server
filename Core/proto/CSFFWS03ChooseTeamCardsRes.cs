using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001898")]
public class CSFFWS03ChooseTeamCardsRes
{
	[Token(Token = "0x4009D56")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWS03TeamCardsInfo> team_cards_info;

	[Token(Token = "0x4009D57")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x6007EF1")]
	[Address(RVA = "0x3180098", Offset = "0x3180098", VA = "0x3180098")]
	public CSFFWS03ChooseTeamCardsRes()
	{
	}
}
