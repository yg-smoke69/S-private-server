using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200158D")]
public class CSCupTeamMemberListWithAccountInfo
{
	[Token(Token = "0x4009379")]
	[FieldOffset(Offset = "0x8")]
	public List<CupTeamMemberWithAccountInfo> member_list;

	[Token(Token = "0x6007BD5")]
	[Address(RVA = "0x317F4CC", Offset = "0x317F4CC", VA = "0x317F4CC")]
	public CSCupTeamMemberListWithAccountInfo()
	{
	}
}
