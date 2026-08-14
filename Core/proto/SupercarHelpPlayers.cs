using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001380")]
public class SupercarHelpPlayers
{
	[Token(Token = "0x40089AE")]
	[FieldOffset(Offset = "0x8")]
	public List<SupercarHelpPlayer> players;

	[Token(Token = "0x6007A81")]
	[Address(RVA = "0x33E2EB8", Offset = "0x33E2EB8", VA = "0x33E2EB8")]
	public SupercarHelpPlayers()
	{
	}
}
