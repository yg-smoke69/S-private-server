using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20016B6")]
public class SpecificIntimacyRankAwardInfo
{
	[Token(Token = "0x40096CE")]
	[FieldOffset(Offset = "0x8")]
	public ulong related_friend_id;

	[Token(Token = "0x40096CF")]
	[FieldOffset(Offset = "0x10")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x40096D0")]
	[FieldOffset(Offset = "0x14")]
	public List<IntimacyRankAwardInfo> award_infos;

	[Token(Token = "0x6007D17")]
	[Address(RVA = "0x33E2618", Offset = "0x33E2618", VA = "0x33E2618")]
	public SpecificIntimacyRankAwardInfo()
	{
	}
}
