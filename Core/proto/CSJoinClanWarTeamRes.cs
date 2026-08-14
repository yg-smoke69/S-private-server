using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001664")]
public class CSJoinClanWarTeamRes
{
	[Token(Token = "0x4009616")]
	[FieldOffset(Offset = "0x8")]
	public List<ClanWarTeamMemberInfo> members_info;

	[Token(Token = "0x6007CAE")]
	[Address(RVA = "0x3097450", Offset = "0x3097450", VA = "0x3097450")]
	public CSJoinClanWarTeamRes()
	{
	}
}
