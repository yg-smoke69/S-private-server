using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200189A")]
public class CSFFWS03ChangeTeamCardsSequenceRes
{
	[Token(Token = "0x4009D59")]
	[FieldOffset(Offset = "0x8")]
	public List<FFWS03TeamCardsInfo> team_cards_info;

	[Token(Token = "0x6007EF3")]
	[Address(RVA = "0x317FF6C", Offset = "0x317FF6C", VA = "0x317FF6C")]
	public CSFFWS03ChangeTeamCardsSequenceRes()
	{
	}
}
