using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20013D2")]
public class AccountFriendRes
{
	[Token(Token = "0x4008B35")]
	[FieldOffset(Offset = "0x8")]
	public List<AccountInfoWithPresence> friends;

	[Token(Token = "0x4008B36")]
	[FieldOffset(Offset = "0xC")]
	public ulong[] star_friends;

	[Token(Token = "0x4008B37")]
	[FieldOffset(Offset = "0x10")]
	public List<FriendAliasInfo> friends_alias_info;

	[Token(Token = "0x6007AB5")]
	[Address(RVA = "0x3179558", Offset = "0x3179558", VA = "0x3179558")]
	public AccountFriendRes()
	{
	}
}
