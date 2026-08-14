using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016A2")]
public class CSGetRecommendedFriendRes
{
	[Token(Token = "0x40096A7")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountInfoWithPresence> rand_friend_list;

	[Token(Token = "0x40096A8")]
	[FieldOffset(Offset = "0xC")]
	public List<AccountInfoWithPresence> common_friend_list;

	[Token(Token = "0x6007D03")]
	[Address(RVA = "0x30950CC", Offset = "0x30950CC", VA = "0x30950CC")]
	public CSGetRecommendedFriendRes()
	{
	}
}
