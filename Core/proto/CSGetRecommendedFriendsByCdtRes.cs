using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016A7")]
public class CSGetRecommendedFriendsByCdtRes
{
	[Token(Token = "0x40096B1")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountInfoWithPresenceAndSocialInfo> recommend_player_list;

	[Token(Token = "0x40096B2")]
	[FieldOffset(Offset = "0xC")]
	public bool is_search_result;

	[Token(Token = "0x6007D08")]
	[Address(RVA = "0x3095170", Offset = "0x3095170", VA = "0x3095170")]
	public CSGetRecommendedFriendsByCdtRes()
	{
	}
}
