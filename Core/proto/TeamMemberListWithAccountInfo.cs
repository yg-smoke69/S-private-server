using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001795")]
public class TeamMemberListWithAccountInfo
{
	[Token(Token = "0x4009A9E")]
	[FieldOffset(Offset = "0x8")]
	public List<TeamMemberWithAccountInfo> member_list;

	[Token(Token = "0x6007DEF")]
	[Address(RVA = "0x33E34DC", Offset = "0x33E34DC", VA = "0x33E34DC")]
	public TeamMemberListWithAccountInfo()
	{
	}
}
