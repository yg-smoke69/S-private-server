using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001643")]
public class ClanMemberListWithAccountInfo
{
	[Token(Token = "0x40095B3")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanMemberWithAccountInfo> member_list;

	[Token(Token = "0x6007C8D")]
	[Address(RVA = "0x309BD40", Offset = "0x309BD40", VA = "0x309BD40")]
	public ClanMemberListWithAccountInfo()
	{
	}
}
