using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016AF")]
public class CSGetAccountSpecialFriendAppsRes
{
	[Token(Token = "0x40096C2")]
	[FieldOffset(Offset = "0x8")]
	public List<SepcialFriendsAppsRes> special_friend_request;

	[Token(Token = "0x6007D10")]
	[Address(RVA = "0x3180D58", Offset = "0x3180D58", VA = "0x3180D58")]
	public CSGetAccountSpecialFriendAppsRes()
	{
	}
}
