using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001955")]
public class CSGetFriendsHurricaneBTeamInfoRes
{
	[Token(Token = "0x4009F73")]
	[FieldOffset(Offset = "0x8")]
	public List<FriendHurricaneBTeamInfo> friends;

	[Token(Token = "0x6007FAE")]
	[Address(RVA = "0x31854A0", Offset = "0x31854A0", VA = "0x31854A0")]
	public CSGetFriendsHurricaneBTeamInfoRes()
	{
	}
}
